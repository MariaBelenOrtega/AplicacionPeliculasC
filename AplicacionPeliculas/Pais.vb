Imports System.Data.SqlClient

Public Class Pais

    Private numClicks As Integer = 0
    Private Sub picAgregar_Click(sender As Object, e As EventArgs) Handles picAgregar.Click
        numClicks += 1
        If numClicks = 1 Then
            txtidIPais.Enabled = False
        Else
            Dim parameters As SqlParameter() = {
           New SqlParameter("@pais", txtNomPais.Text),
           New SqlParameter("@UsuarioCrea", Cuenta.idU)
             }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPAgregarPais", parameters)
            If success Then
                MsgBox("El Registro ha sido Agregado")
                txtidIPais.Enabled = True
                numClicks = 0
            Else
                MsgBox("El Registro no se Agrego")
            End If
        End If

        Limpiar()
    End Sub

    Sub Limpiar()
        txtNomPais.Clear()
        txtidIPais.Clear()
    End Sub

    Private Sub PicBorrar_Click(sender As Object, e As EventArgs) Handles PicBorrar.Click
        numClicks += 1

        If numClicks = 1 Then
            txtNomPais.Enabled = False

        Else
            Dim parameters As SqlParameter() = {
          New SqlParameter("@idPais", txtidIPais.Text),
          New SqlParameter("@IdUsuarioModifica", Cuenta.idU)
            }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPEliminarPais", parameters)
            If success Then
                MsgBox("El Registro ha sido Borrado")
                txtNomPais.Enabled = True
                numClicks = 0
            Else
                MsgBox("El Registro no se Borro")
                numClicks = 0
            End If
        End If
        Limpiar()
    End Sub

    Private Sub PicActualizar_Click(sender As Object, e As EventArgs) Handles PicActualizar.Click
        numClicks += 1
        If numClicks = 1 Then
            Dim query As String = "SELECT idPais, Pais  FROM Pais where estatus = 1"
            Dim dt As DataTable = Conecction.SelectQuery(query)
            ModificarPais.dataModPais.DataSource = dt
            ModificarPais.Show()
        Else
            Dim parameters As SqlParameter() = {
         New SqlParameter("@idPais", txtidIPais.Text),
           New SqlParameter("@pais", txtNomPais.Text),
         New SqlParameter("@IdUsuarioModifica", Cuenta.idU)
           }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPActualizarPais", parameters)
            If success Then
                MsgBox("El Registro ha sido Modificado")
                numClicks = 0
            Else
                MsgBox("El Registro no se Modifico")
            End If
        End If
        Limpiar()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim query As String = "SELECT idPais, Pais  FROM Pais where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BusquedaPais.DataBuscaPais.DataSource = dt
        BusquedaPais.Show()
    End Sub
End Class