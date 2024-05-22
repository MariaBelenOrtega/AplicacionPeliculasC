Public Class ModificaIdioma
    Public idIdioma As Integer
    Public nombreIdioma As String
    Dim query As String

    Private Sub DataModIdioma_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataModIdioma.CellContentClick
        Try
            idIdioma = DataModIdioma.Rows(e.RowIndex).Cells(0).Value
            nombreIdioma = DataModIdioma.Rows(e.RowIndex).Cells(1).Value
            Idioma.txtidIdioma.Text = idIdioma
            Idioma.txtNomIdioma.Text = nombreIdioma
            Idioma.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error" + vbCrLf + "Haz doble clic sobre el nombre de la película a buscar.")
        End Try
    End Sub

    Sub filitrarIdIdioma()
        query = "select * from Idioma where idIdioma LIKE '%" & txtidIdioma.Text & "%' and estatus = 1"
        DataModIdioma.DataSource = Conecction.SelectQuery(query)
    End Sub

    Sub filitrarIdioma()
        query = "select * from Idioma where Idioma LIKE '%" & txtNomIdioma.Text & "%' and estatus = 1"
        DataModIdioma.DataSource = Conecction.SelectQuery(query)
    End Sub

    Private Sub txtNomIdioma_TextChanged(sender As Object, e As EventArgs) Handles txtNomIdioma.TextChanged
        filitrarIdioma()
    End Sub

    Private Sub txtidIdioma_TextChanged(sender As Object, e As EventArgs) Handles txtidIdioma.TextChanged
        filitrarIdIdioma()
    End Sub
End Class