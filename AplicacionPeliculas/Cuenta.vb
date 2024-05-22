Imports System.Collections.ObjectModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Cuenta
    Dim query As String
    Public idU As Integer
    Public NombreUser As String
    Public Username As String
    Public contraseñaU As String
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        query = "select convert(nvarchar(50),hashbytes('SHA1','" & txtcontra.Text & "'),1) from usuario
        where username = '" & txtusuario.Text & "'"
        Dim dt As DataTable
        Try
            dt = Conecction.SelectQuery(query)
            Dim contrausuario As Object = dt.Rows(0)(0)

            query = "select id, nombre,password, username from usuario where username ='" & txtusuario.Text & "'"
            dt = Conecction.SelectQuery(query)
            Dim contrabase As Object = dt.Rows(0)(2)

            If contrabase = contrausuario Then
                idU = dt.Rows(0)(0)
                NombreUser = dt.Rows(0)(1)
                Username = dt.Rows(0)(3)
                ''  MsgBox("Contraseña Correcta")
                Espera.Show()

            Else
                MsgBox("Contraseña incorrecta")
            End If

        Catch ex As Exception
            MsgBox("Usuario No existe")
        End Try
    End Sub
End Class