Public Class BuscaUsuario
    Public id As Integer
    Public nombre As String
    Public Username As String
    Dim query As String

    Private Sub DataBusca_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataBusca.CellContentDoubleClick
        Try

            id = DataBusca.Rows(e.RowIndex).Cells(0).Value
            nombre = DataBusca.Rows(e.RowIndex).Cells(1).Value
            Username = DataBusca.Rows(e.RowIndex).Cells(2).Value
            Usuario.txtNombreU.Text = nombre
            Usuario.txtId.Text = id
            Usuario.txtUsernameU.Text = Username
            Usuario.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error" + vbCrLf + "Haz doble clic sobre el nombre del Usuario a buscar.")
        End Try
    End Sub

    Sub filitrarId()
        query = "select id, nombre, username from Usuario where id LIKE '%" & txtid.Text & "%'and estatus = 1"
        DataBusca.DataSource = Conecction.SelectQuery(query)
    End Sub

    Sub filitrar()
        query = "select id, nombre, username from Usuario where nombre LIKE '%" & txtNom.Text & "%' and estatus = 1"
        DataBusca.DataSource = Conecction.SelectQuery(query)
    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        filitrar()
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        filitrarId()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Usuario.Show()
    End Sub
End Class