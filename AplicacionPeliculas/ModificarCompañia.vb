Public Class ModificarCompañia
    Public idcom As Integer
    Public nombreCom As String
    Dim query As String
    Private Sub dataModCom_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataModCom.CellContentClick
        Try
            idcom = dataModCom.Rows(e.RowIndex).Cells(0).Value
            nombreCom = dataModCom.Rows(e.RowIndex).Cells(1).Value
            Compañia.txtidCom.Text = idcom
            Compañia.txtNomCom.Text = nombreCom
            Compañia.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error" + vbCrLf + "Haz doble clic sobre el nombre de la película a buscar.")
        End Try
    End Sub
    Sub flitrarIdCom()
        query = "select * from Compania where idCompania LIKE '%" & txtidCom.Text & "%' and estatus = 1"
        dataModCom.DataSource = Conecction.SelectQuery(query)
    End Sub
    Sub flitrarCom()
        query = "select * from Compania where nombre LIKE '%" & txtNomCom.Text & "%' and estatus = 1"
        dataModCom.DataSource = Conecction.SelectQuery(query)
    End Sub

    Private Sub txtNomCom_TextChanged(sender As Object, e As EventArgs) Handles txtNomCom.TextChanged
        flitrarCom()
    End Sub

    Private Sub txtidCom_TextChanged(sender As Object, e As EventArgs) Handles txtidCom.TextChanged
        flitrarIdCom()
    End Sub
End Class