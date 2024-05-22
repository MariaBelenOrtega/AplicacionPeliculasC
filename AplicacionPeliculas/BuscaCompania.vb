Public Class BuscaCompania
    Public idCompania As Integer
    Public nombreCompania As String
    Dim query As String
    Private Sub DataBuscaCompania_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataBuscaCompania.CellContentDoubleClick
        Try

            idCompania = DataBuscaCompania.Rows(e.RowIndex).Cells(0).Value
            nombreCompania = DataBuscaCompania.Rows(e.RowIndex).Cells(1).Value
            Pelicula.idCom = idCompania
            Pelicula.txtCompania.Text = nombreCompania
            Pelicula.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error" + vbCrLf + "Haz doble clic sobre el nombre de la Compañia.")
        End Try
    End Sub

    Sub flitrarCom()
        query = "select * from Compania where nombre LIKE '%" & txtNomCom.Text & "%' and estatus = 1"
        DataBuscaCompania.DataSource = Conecction.SelectQuery(query)
    End Sub

    Private Sub txtNomCom_TextChanged(sender As Object, e As EventArgs) Handles txtNomCom.TextChanged
        flitrarCom()
        Dim Columna As Integer = 2
        Dim Columna2 As Integer = 3
        Dim Columna3 As Integer = 4
        Dim Columna4 As Integer = 5
        Dim Columna5 As Integer = 6
        DataBuscaCompania.Columns(Columna).Visible = False
        DataBuscaCompania.Columns(Columna2).Visible = False
        DataBuscaCompania.Columns(Columna3).Visible = False
        DataBuscaCompania.Columns(Columna4).Visible = False
        DataBuscaCompania.Columns(Columna5).Visible = False
    End Sub

    Sub flitrarIdCom()
        query = "select * from Compania where idCompania LIKE '%" & txtid.Text & "%' and estatus = 1"
        DataBuscaCompania.DataSource = Conecction.SelectQuery(query)
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        flitrarIdCom()
        Dim Columna As Integer = 2
        Dim Columna2 As Integer = 3
        Dim Columna3 As Integer = 4
        Dim Columna4 As Integer = 5
        Dim Columna5 As Integer = 6
        DataBuscaCompania.Columns(Columna).Visible = False
        DataBuscaCompania.Columns(Columna2).Visible = False
        DataBuscaCompania.Columns(Columna3).Visible = False
        DataBuscaCompania.Columns(Columna4).Visible = False
        DataBuscaCompania.Columns(Columna5).Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Compañia.Show()

    End Sub


End Class