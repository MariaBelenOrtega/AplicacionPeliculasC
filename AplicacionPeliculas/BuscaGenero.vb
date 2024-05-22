Public Class BuscaGenero
    Public idgenero As Integer
    Public nombregenero As String
    Dim query As String

    Private Sub DataBuscagenero_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataBuscagenero.CellContentDoubleClick
        Try
            idgenero = DataBuscagenero.Rows(e.RowIndex).Cells(0).Value
            nombregenero = DataBuscagenero.Rows(e.RowIndex).Cells(1).Value
            Pelicula.idG = idgenero
            Pelicula.txtGenero.Text = nombregenero
            Pelicula.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error" + vbCrLf + "Haz doble clic sobre el nombre del Genero")
        End Try
    End Sub

    Private Sub txtNomCom_TextChanged(sender As Object, e As EventArgs) Handles txtNomGen.TextChanged
        flitrarGen()
    End Sub

    Sub flitrarIdGen()
        query = "select * from Genero where id LIKE '%" & txtidGen.Text & "%' and estatus = 1"
        DataBuscagenero.DataSource = Conecction.SelectQuery(query)
    End Sub

    Sub flitrarGen()
        query = "select * from Genero where nombre LIKE '%" & txtNomGen.Text & "%' and estatus = 1"
        DataBuscagenero.DataSource = Conecction.SelectQuery(query)
    End Sub

    Private Sub txtidGen_TextChanged(sender As Object, e As EventArgs) Handles txtidGen.TextChanged
        flitrarIdGen()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Genero.Show()
    End Sub
End Class