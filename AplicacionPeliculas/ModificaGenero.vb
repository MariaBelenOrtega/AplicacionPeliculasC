Public Class ModificaGenero
    Public idgenero As Integer
    Public nombregenero As String
    Dim query As String
    Private Sub DataModgenero_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataModgenero.CellContentClick
        Try
            idgenero = DataModgenero.Rows(e.RowIndex).Cells(0).Value
            nombregenero = DataModgenero.Rows(e.RowIndex).Cells(1).Value
            Genero.txtidgen.Text = idgenero
            Genero.txtNomGenero.Text = nombregenero
            Genero.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error" + vbCrLf + "Haz doble clic sobre el nombre de la película a buscar.")
        End Try
    End Sub
    Sub flitrarIdGen()
        query = "select * from Genero where id LIKE '%" & txtidGen.Text & "%' and estatus = 1"
        DataModgenero.DataSource = Conecction.SelectQuery(query)
    End Sub

    Sub flitrarGen()
        query = "select * from Genero where nombre LIKE '%" & txtNomGen.Text & "%' and estatus = 1"
        DataModgenero.DataSource = Conecction.SelectQuery(query)
    End Sub

    Private Sub txtNomGen_TextChanged(sender As Object, e As EventArgs) Handles txtNomGen.TextChanged
        flitrarGen()
    End Sub

    Private Sub txtidGen_TextChanged(sender As Object, e As EventArgs) Handles txtidGen.TextChanged
        flitrarIdGen()
    End Sub

End Class