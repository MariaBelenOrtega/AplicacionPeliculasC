Public Class inicio


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Pelicula.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Genero.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim query As String = "SELECT idPais, Pais  FROM Pais where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BusquedaPais.DataBuscaPais.DataSource = dt
        BusquedaPais.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim query As String = "SELECT id, nombre  FROM Genero where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BuscaGenero.DataBuscagenero.DataSource = dt
        BuscaGenero.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim query As String = "SELECT idCompania, nombre  FROM Compania where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BuscaCompania.DataBuscaCompania.DataSource = dt
        BuscaCompania.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim query As String = "SELECT idIdioma, Idioma  FROM Idioma where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BuscaIdioma.dataBuscaIdioma.DataSource = dt
        BuscaIdioma.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Idioma.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Pais.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Compañia.Show()
    End Sub



    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Usuario.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Peliculas.Show()
    End Sub


End Class