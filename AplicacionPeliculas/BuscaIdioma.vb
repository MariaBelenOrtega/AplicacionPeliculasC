Public Class BuscaIdioma
    Public idIdioma As Integer
    Public nombreIdioma As String
    Dim query As String


    Private Sub dataBuscaIdioma_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataBuscaIdioma.CellContentDoubleClick
        Try

            idIdioma = dataBuscaIdioma.Rows(e.RowIndex).Cells(0).Value
            nombreIdioma = dataBuscaIdioma.Rows(e.RowIndex).Cells(1).Value
            Pelicula.idid = idIdioma
            Pelicula.txtIdioma.Text = nombreIdioma
            Pelicula.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error" + vbCrLf + "Haz doble clic sobre el nombre del Idioma")
        End Try
    End Sub

    Private Sub txtNomIdioma_TextChanged(sender As Object, e As EventArgs) Handles txtNomIdioma.TextChanged
        filitrarIdioma()
    End Sub

    Sub filitrarIdIdioma()
        query = "select * from Idioma where idIdioma LIKE '%" & txtidIdioma.Text & "%' and estatus = 1"
        dataBuscaIdioma.DataSource = Conecction.SelectQuery(query)
    End Sub

    Sub filitrarIdioma()
        query = "select * from Idioma where Idioma LIKE '%" & txtNomIdioma.Text & "%' and estatus = 1"
        dataBuscaIdioma.DataSource = Conecction.SelectQuery(query)
    End Sub

    Private Sub txtidIdioma_TextChanged(sender As Object, e As EventArgs) Handles txtidIdioma.TextChanged
        filitrarIdIdioma()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Idioma.Show()
    End Sub
End Class