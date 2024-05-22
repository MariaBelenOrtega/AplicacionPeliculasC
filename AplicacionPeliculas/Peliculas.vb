Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class Peliculas
    Private auto As Boolean
    Dim query As String
    Public idpeli As Integer
    

    Public Sub New()
        auto = True
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        ' Add any initialization after the InitializeComponent() call.

        query = "SELECT pais, idPais FROM Pais where estatus = 1"
        comboPais.DataSource = Conecction.SelectQuery(query)
        comboPais.DisplayMember = "pais"
        comboPais.ValueMember = "idPais"
        auto = False
    End Sub

    Private Sub comboGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboGenero.SelectedIndexChanged
        If auto Then
            Exit Sub
        End If

        If comboPais.Text Is Nothing Then
            Exit Sub
        End If
        Dim s = comboGenero.SelectedValue
        MsgBox(s)

        query = "select * FROM VWBuscador1  where pais like '%" & comboPais.Text & "%' and id = " & s & " and estatus = 1"
        'filtar()
        DataGridView1.DataSource = Conecction.SelectQuery(query)
        'Dim indiceColumna As Integer = 6
        'DataGridView1.Columns(indiceColumna).Visible = False
    End Sub
    Public Sub Actualizar()
        If auto Then
            Exit Sub
        End If

        auto = True

        query = "select * from vwgeneropais1 where idpais = " & comboPais.SelectedValue
        comboGenero.DataSource = Conecction.SelectQuery(query)
        comboGenero.DisplayMember = "Nombre"
        comboGenero.ValueMember = "id"

        auto = False
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            idpeli = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Form1.Show()
        Catch ex As Exception
            MsgBox("Error" + vbCrLf + "Haz doble clic sobre el nombre de la película a buscar.")
        End Try
    End Sub

    Private Sub comboPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPais.SelectedIndexChanged
        Actualizar()
    End Sub

    Private Sub PicAgregar_Click(sender As Object, e As EventArgs) Handles PicAgregar.Click
        Pelicula.Show()
    End Sub


    Private Sub filtrar()
        query = "select * FROM VWBuscador1 WHERE Pais LIKE  '% " & comboPais.Text & " %' AND   id ='%" & comboGenero.Text & "%'"
        DataGridView1.DataSource = Conecction.SelectQuery(query)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        inicio.Show()
    End Sub

    Private Sub Peliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class