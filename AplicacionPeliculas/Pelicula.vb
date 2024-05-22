Imports System.Data.SqlClient

Public Class Pelicula
    Public idp As Integer
    Public nomPais As String
    Public idG As Integer
    Public nomG As String
    Public idid As Integer
    Public noiD As String
    Public idCom As Integer
    Public nomcOM As String
    Private numClicks As Integer = 0
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub bloqueotextos()
        txtpais.ReadOnly = True
        txtIdioma.ReadOnly = True
        txtGenero.ReadOnly = True
        txtCompania.ReadOnly = True
    End Sub
    Private Sub Pelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bloqueotextos()
        Label7.Visible = False
        txtId.Visible = False
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim adultValue As String = comboAdult.Text

        Dim parameters As SqlParameter() = {
            New SqlParameter("@Titulo", txtno.Text),
            New SqlParameter("@LanzamientoPelicula", txtFechaLanzamiento.Text),
            New SqlParameter("@DuracionPelicula", txtDuracion.Text),
            New SqlParameter("@Adult", adultValue),
            New SqlParameter("@IdiomaOriginal", txtIdiomaOriginal.Text),
            New SqlParameter("@TituloOriginal", txtNombreOriginal.Text),
            New SqlParameter("@Descripcion", txtDescripcion.Text),
            New SqlParameter("@Genero", txtGenero.Text),
            New SqlParameter("@Compania", txtCompania.Text),
            New SqlParameter("@Idioma", txtIdioma.Text),
            New SqlParameter("@Pais", txtpais.Text),
            New SqlParameter("@IdGenero", idG),
            New SqlParameter("@IdCompania", idCom),
            New SqlParameter("@IdPais", idp),
            New SqlParameter("@Ididioma", idid)
            }

        ' Ejecutar el stored procedure
        Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPAgregarPelicula3", parameters)
        If success Then
            MsgBox("El Registro ha sido Agregado")
            Peliculas.Actualizar()
            numClicks = 0
        Else
            MsgBox("El Registro no se Agrego")
            numClicks = 0
        End If

        Limpiar()
    End Sub
    Sub Limpiar()
        txtno.Clear()
        txtNombreOriginal.Clear()
        txtDuracion.Clear()
        txtFechaLanzamiento.Clear()
        txtGenero.Clear()
        txtIdiomaOriginal.Clear()
        txtpais.Clear()
        txtCompania.Clear()
        txtDescripcion.Clear()
        txtIdioma.Clear()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim query As String = "SELECT idPais, Pais  FROM Pais where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BusquedaPais.DataBuscaPais.DataSource = dt
        BusquedaPais.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim query As String = "SELECT idIdioma, Idioma  FROM Idioma where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BuscaIdioma.dataBuscaIdioma.DataSource = dt
        BuscaIdioma.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim query As String = "SELECT id, nombre  FROM Genero where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BuscaGenero.DataBuscagenero.DataSource = dt
        BuscaGenero.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim query As String = "SELECT idCompania, nombre  FROM Compania where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BuscaCompania.DataBuscaCompania.DataSource = dt
        BuscaCompania.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        numClicks += 1
        If numClicks = 1 Then
            Label7.Visible = True
            txtId.Visible = True
            txtno.ReadOnly = True
            txtNombreOriginal.ReadOnly = True
            txtDescripcion.ReadOnly = True
            txtDuracion.ReadOnly = True
            txtIdiomaOriginal.ReadOnly = True
            txtFechaLanzamiento.ReadOnly = True
            comboAdult.Enabled = False

        Else
            Dim parameters As SqlParameter() = {
           New SqlParameter("@idPelicula", txtId.Text),
           New SqlParameter("@IdUsuarioModifica", Cuenta.idU)
           }

            ' Ejecutar el stored procedure
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPEliminarPelicula3", parameters)
            If success Then
                MsgBox("El Registro ha sido Eliminado")
                Label7.Visible = False
                txtId.Visible = False
                Peliculas.Actualizar()
                numClicks = 0
            Else
                MsgBox("El Registro no se Elimino")
                numClicks = 0
            End If
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        numClicks += 1
        If numClicks = 1 Then
            txtId.Visible = True
            Label7.Visible = True
        Else
            Dim adultValue As String = comboAdult.Text

            Dim parameters As SqlParameter() = {
                New SqlParameter("@IdPelicula", txtId.Text),
                New SqlParameter("@Titulo", txtno.Text),
                New SqlParameter("@LanzamientoPelicula", txtFechaLanzamiento.Text),
                New SqlParameter("@DuracionPelicula", txtDuracion.Text),
                New SqlParameter("@Adult", adultValue),
                New SqlParameter("@IdiomaOriginal", txtIdiomaOriginal.Text),
                New SqlParameter("@TituloOriginal", txtNombreOriginal.Text),
                New SqlParameter("@Descripcion", txtDescripcion.Text),
                New SqlParameter("@Genero", txtGenero.Text),
                New SqlParameter("@Compania", txtCompania.Text),
                New SqlParameter("@Idioma", txtIdioma.Text),
                New SqlParameter("@Pais", txtpais.Text),
                New SqlParameter("@IdGenero", idG),
                New SqlParameter("@IdCompania", idCom),
                New SqlParameter("@IdPais", idp),
                New SqlParameter("@Ididioma", idid)
                }

            ' Ejecutar el stored procedure
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPActualizarPelicula3", parameters)
            If success Then
                MsgBox("El Registro ha sido Actualizado")
                Peliculas.Actualizar()
                numClicks = 0
            Else
                MsgBox("El Registro no se Actualizo")
                numClicks = 0
            End If

            Limpiar()
        End If
    End Sub
End Class