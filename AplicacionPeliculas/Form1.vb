Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form1
    Dim query As String
    Public idbusca As Integer
    Private Sub bloqueotextos()
        txtId.ReadOnly = True
        txtno.ReadOnly = True
        txtNombreOriginal.ReadOnly = True
        txtGenero.ReadOnly = True
        txtFechaLanzamiento.ReadOnly = True
        txtIdioma.ReadOnly = True
        txtIdiomaOriginal.ReadOnly = True
        txtCompania.ReadOnly = True
        txtDuracion.ReadOnly = True
        txtDescripcion.ReadOnly = True
        comboAdult.Enabled = False
        txtpais.ReadOnly = True

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloqueotextos()
        idbusca = Peliculas.idpeli
        busqueda()
    End Sub
    Public Sub busqueda()
        Dim dt As DataTable
        Dim query As String = "select * from VWPELICULA2 where idPelicula = ' " & idbusca.ToString & "'"
        dt = Conecction.SelectQuery(query)


        txtId.Text = dt.Rows(0)(0)
        txtno.Text = dt.Rows(0)(1)
        txtFechaLanzamiento.Text = dt.Rows(0)(2)
        txtDuracion.Text = dt.Rows(0)(3) & " Min."
        comboAdult.Text = dt.Rows(0)(4)
        txtIdiomaOriginal.Text = dt.Rows(0)(5)
        txtpais.Text = dt.Rows(0)(6)
        txtNombreOriginal.Text = dt.Rows(0)(7)
        txtDescripcion.Text = dt.Rows(0)(8)
        txtGenero.Text = dt.Rows(0)(9)
        txtCompania.Text = dt.Rows(0)(10)
        txtIdioma.Text = dt.Rows(0)(11)

    End Sub

    Sub limpiar()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Pelicula.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Pelicula.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Pelicula.txtId.Visible = True
        Pelicula.Label7.Visible = True
        Pelicula.txtId.Text = idbusca
        Pelicula.Show()
    End Sub
End Class
