Public Class ModificarPais
    Public idPais As Integer
    Public nombrePais As String
    Dim query As String

    Private Sub dataModPais_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataModPais.CellContentClick
        Try
            idPais = dataModPais.Rows(e.RowIndex).Cells(0).Value
            nombrePais = dataModPais.Rows(e.RowIndex).Cells(1).Value
            Pais.txtidIPais.Text = idPais
            Pais.txtNomPais.Text = nombrePais
            Pais.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error" + vbCrLf + "Haz doble clic sobre el nombre de la película a buscar.")
        End Try
    End Sub

    Private Sub txtNomPais_TextChanged(sender As Object, e As EventArgs) Handles txtNomPais.TextChanged
        filitrarPais()
    End Sub
    Sub filitrarIdPais()
        query = "select * from Pais where idPais LIKE '%" & txtidPais.Text & "%'and estatus = 1"
        dataModPais.DataSource = Conecction.SelectQuery(query)
    End Sub

    Sub filitrarPais()
        query = "select * from Pais where Pais LIKE '%" & txtNomPais.Text & "%' and estatus = 1"
        dataModPais.DataSource = Conecction.SelectQuery(query)
    End Sub

    Private Sub txtidPais_TextChanged(sender As Object, e As EventArgs) Handles txtidPais.TextChanged
        filitrarIdPais()
    End Sub
End Class