Imports System.Data.SqlClient

Public Class Usuario
    Public query As String
    Private numClicks As Integer = 0
    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Cuenta.NombreUser
        txtContraseña.Visible = False
        Label5.Visible = False
        txtNombreU.Text = Cuenta.NombreUser
        txtUsernameU.Text = Cuenta.Username
        txtUsernameU.Enabled = False
        txtNombreU.Enabled = False
        txtId.Visible = False
        Label6.Visible = False

        If Cuenta.idU = 1 Then
            picAgregar.Visible = True
            PicBorrar.Visible = True
            PicActualizar.Visible = True
        Else
            picAgregar.Visible = False
            PicBorrar.Visible = False
            PicActualizar.Visible = True
        End If

        If Cuenta.idU <> 1 Then
            txtContraseña.Enabled = False
            txtUsernameU.Enabled = False
            txtNombreU.Enabled = False
        End If
    End Sub

    Private Sub picAgregar_Click(sender As Object, e As EventArgs) Handles picAgregar.Click
        numClicks += 1
        If numClicks = 1 Then
            txtContraseña.Clear()
            txtUsernameU.Clear()
            txtNombreU.Clear()
            txtContraseña.Enabled = True
            txtUsernameU.Enabled = True
            txtNombreU.Enabled = True
            txtContraseña.Visible = True
            Label5.Visible = True
        Else
            Dim parameters As SqlParameter() = {
            New SqlParameter("@nombre", txtNombreU.Text),
            New SqlParameter("@username", txtUsernameU.Text),
            New SqlParameter("@password", txtContraseña.Text)
         }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPAgregarUsuario", parameters)
            If success Then
                MsgBox("El Usuario ha sido Agregado")
                txtUsernameU.Enabled = False
                txtNombreU.Enabled = False
                txtContraseña.Enabled = False
                numClicks = 0
            Else
                MsgBox("El Usuario no se Agrego")

            End If
        End If
    End Sub

    Private Sub PicActualizar_Click(sender As Object, e As EventArgs) Handles PicActualizar.Click
        numClicks += 1
        If Cuenta.idU = 1 Then
            BuscaUsuario.Show()

        End If
        If numClicks = 1 Then
            txtContraseña.Clear()
            txtUsernameU.Clear()
            txtNombreU.Clear()
            txtContraseña.Enabled = True
            txtUsernameU.Enabled = True
            txtNombreU.Enabled = True
            txtContraseña.Visible = True
            Label5.Visible = True
        Else
            Dim parameters As SqlParameter() = {
            New SqlParameter("@id", Cuenta.idU),
            New SqlParameter("@nombre", txtNombreU.Text),
            New SqlParameter("@username", txtUsernameU.Text),
            New SqlParameter("@password", txtContraseña.Text)
         }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPActualizarUsuario", parameters)
            If success Then
                MsgBox("El Usuario ha sido Actualizado")
                numClicks = 0
                If Cuenta.idU = 1 Then
                    Label2.Text = Cuenta.NombreUser
                Else
                    Label2.Text = txtNombreU.Text
                End If

                txtUsernameU.Enabled = False
                    txtNombreU.Enabled = False
                    txtContraseña.Enabled = False
                Else
                    MsgBox("El Usuario no se Actualizo")

            End If
        End If
    End Sub

    Private Sub PicBorrar_Click(sender As Object, e As EventArgs) Handles PicBorrar.Click
        numClicks += 1
        If numClicks = 1 Then
            txtId.Visible = True
            Label6.Visible = True
            txtUsernameU.Clear()
            txtNombreU.Clear()
            txtUsernameU.Visible = True
            txtNombreU.Visible = True
            txtContraseña.Visible = False
            Label5.Visible = False
        Else
            Dim parameters As SqlParameter() = {
            New SqlParameter("@id", txtId.Text)
         }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPEliminarUsuario", parameters)
            If success Then
                MsgBox("El Usuario ha sido Borrado")
                numClicks = 0
                Label2.Text = txtNombreU.Text
                txtUsernameU.Enabled = False
                txtNombreU.Enabled = False
                txtContraseña.Enabled = False
                txtContraseña.Visible = False
                Label5.Visible = False
            Else
                MsgBox("El Usuario no se Borro")

            End If
        End If

    End Sub

    Private Sub PicBuscar_Click(sender As Object, e As EventArgs) Handles PicBuscar.Click
        Dim query As String = "SELECT id, nombre  FROM Usuario where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BuscaUsuario.DataBusca.DataSource = dt
        BuscaUsuario.Show()
    End Sub
End Class