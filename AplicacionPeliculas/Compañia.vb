Imports System.Data.SqlClient

Public Class Compañia
    Private numClicks As Integer = 0

    Private Sub picAgregar_Click(sender As Object, e As EventArgs) Handles picAgregar.Click
        numClicks += 1
        If numClicks = 1 Then
            txtidCom.Enabled = False
        Else
            Dim parameters As SqlParameter() = {
           New SqlParameter("@nombre", txtNomCom.Text),
           New SqlParameter("@UsuarioCrea", Cuenta.idU)
             }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPAgregarCompania", parameters)
            If success Then
                MsgBox("El Registro ha sido Agregado")
                txtidCom.Enabled = True
                numClicks = 0
            Else
                MsgBox("El Registro no se Agrego")
            End If
        End If

        Limpiar()
    End Sub

    Sub Limpiar()
        txtNomCom.Clear()
        txtidCom.Clear()
    End Sub

    Private Sub PicBorrar_Click(sender As Object, e As EventArgs) Handles PicBorrar.Click
        numClicks += 1

        If numClicks = 1 Then
            txtNomCom.Enabled = False

        Else
            Dim parameters As SqlParameter() = {
          New SqlParameter("@idCompania", txtidCom.Text),
          New SqlParameter("@IdUsuarioModifica", Cuenta.idU)
            }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPEliminarCompania", parameters)
            If success Then
                MsgBox("El Registro ha sido Borrado")
                txtNomCom.Enabled = True
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
            Dim query As String = "SELECT idCompania, nombre  FROM Compania where estatus = 1"
            Dim dt As DataTable = Conecction.SelectQuery(query)
            ModificarCompañia.dataModCom.DataSource = dt
            ModificarCompañia.Show()
        Else
            Dim parameters As SqlParameter() = {
         New SqlParameter("@idCompania", txtidCom.Text),
           New SqlParameter("@nombre", txtNomCom.Text),
         New SqlParameter("@IdUsuarioModifica", Cuenta.idU)
           }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPActualizarCompania", parameters)
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
        Dim query As String = "SELECT idCompania, nombre  FROM Compania where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BuscaCompania.DataBuscaCompania.DataSource = dt
        BuscaCompania.Show()
    End Sub


End Class