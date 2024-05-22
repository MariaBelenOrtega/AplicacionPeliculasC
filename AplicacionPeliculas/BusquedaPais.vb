Imports System.Collections.ObjectModel

Public Class BusquedaPais
    Public idpais As Integer
    Public nombrepais As String
    Dim query As String

    Private Sub DataBuscaPais_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataBuscaPais.CellContentDoubleClick
        Try

            idpais = DataBuscaPais.Rows(e.RowIndex).Cells(0).Value
            nombrepais = DataBuscaPais.Rows(e.RowIndex).Cells(1).Value
            Pelicula.idp = idpais
            Pelicula.txtpais.Text = nombrepais
            Pelicula.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Error" + vbCrLf + "Haz doble clic sobre el nombre del Pais.")
        End Try
    End Sub

    Private Sub txtNomPais_TextChanged(sender As Object, e As EventArgs) Handles txtNomPais.TextChanged
        filitrarPais()
    End Sub
    Sub filitrarIdPais()
        query = "select * from Pais where idPais LIKE '%" & txtidPais.Text & "%'and estatus = 1"
        DataBuscaPais.DataSource = Conecction.SelectQuery(query)
    End Sub

    Sub filitrarPais()
        query = "select * from Pais where Pais LIKE '%" & txtNomPais.Text & "%' and estatus = 1"
        DataBuscaPais.DataSource = Conecction.SelectQuery(query)
    End Sub

    Private Sub txtidPais_TextChanged(sender As Object, e As EventArgs) Handles txtidPais.TextChanged
        filitrarIdPais()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Pais.Show()
    End Sub
End Class