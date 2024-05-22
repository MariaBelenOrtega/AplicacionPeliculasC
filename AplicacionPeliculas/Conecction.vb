Imports System.Data.SqlClient
Public Class Conecction

    Shared cnx As New SqlConnection

    Private Shared Sub connect()
        Try
            cnx.ConnectionString = "Data Source=LAPTOP-EIM430LI; Initial Catalog=Peliculas_Animacion;Integrated Security=True"
            cnx.Open()
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub

    Private Shared Sub disconect()
        Try
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al desconectar la base de datos" & ex.Message)
        End Try
    End Sub


    Public Shared Function SelectQuery(ByVal query As String) As DataTable
        Dim dt As New DataTable
        Try
            connect()
            Dim cmd As New SqlCommand(query, cnx)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta: " & ex.Message)
        Finally
            disconect()
        End Try
        Return dt
    End Function





    Public Shared Function ExecuteStoredProcedure(ByVal procedureName As String, ByVal parameters As SqlParameter()) As Boolean
        Dim connectionString As String = "Data Source=LAPTOP-EIM430LI; Initial Catalog=Peliculas_Animacion;Integrated Security=True" ' Reemplaza con tu cadena de conexión
        Dim connection As New SqlConnection(connectionString)

        Try
            connection.Open()

            ' Iniciar la transacción
            Dim transaction As SqlTransaction = connection.BeginTransaction()

            Try
                ' Crear el comando para el procedimiento almacenado
                Dim command As New SqlCommand()
                command.Connection = connection
                command.Transaction = transaction
                command.CommandType = CommandType.StoredProcedure
                command.CommandText = procedureName

                ' Agregar los parámetros al comando
                If parameters IsNot Nothing Then
                    command.Parameters.AddRange(parameters)
                End If

                ' Ejecutar el procedimiento almacenado
                command.ExecuteNonQuery()

                ' Confirmar la transacción si todas las operaciones se completaron correctamente
                transaction.Commit()

                Return True

            Catch ex As Exception
                ' Ocurrió un error, realizar un rollback de la transacción
                transaction.Rollback()

                ' Registrar el error en la tabla Errores
                Dim errorDescription As String = ex.Message
                Dim insertErrorQuery As String = "INSERT INTO Errores (descripcion) VALUES (@Descripcion);"

                Using insertErrorCommand As New SqlCommand(insertErrorQuery, connection)
                    insertErrorCommand.Parameters.AddWithValue("@Descripcion", errorDescription)
                    insertErrorCommand.ExecuteNonQuery()
                End Using

                Return False
            End Try

        Catch ex As Exception
            ' Ocurrió un error al conectar con la base de datos
            Console.WriteLine("Error al conectar con la base de datos: " & ex.Message)
            Return False
        Finally
            connection.Close()
        End Try
    End Function
End Class
