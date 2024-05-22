Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Genero
    Private numClicks As Integer = 0
    Private Sub picAgregar_Click(sender As Object, e As EventArgs) Handles picAgregar.Click
        numClicks += 1
        If numClicks = 1 Then
            txtidgen.Enabled = False
        Else
            Dim parameters As SqlParameter() = {
           New SqlParameter("@NombreGenero", txtNomGenero.Text),
           New SqlParameter("@UsuarioCrea", Cuenta.idU)
             }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPAgregarGenero", parameters)
            If success Then
                MsgBox("El Registro ha sido Agregado")
                txtidgen.Enabled = True
                numClicks = 0
            Else
                MsgBox("El Registro no se Agrego")
            End If
        End If

        Limpiar()
    End Sub


    Sub Limpiar()
        txtNomGenero.Clear()
        txtidgen.Clear()
    End Sub

    Private Sub PicBorrar_Click(sender As Object, e As EventArgs) Handles PicBorrar.Click
        numClicks += 1

        If numClicks = 1 Then
            txtNomGenero.Enabled = False

        Else
            Dim parameters As SqlParameter() = {
          New SqlParameter("@id", txtidgen.Text),
          New SqlParameter("@IdUsuarioModifica", Cuenta.idU)
            }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPEliminarGenero", parameters)
            If success Then
                MsgBox("El Registro ha sido Borrado")
                txtNomGenero.Enabled = True
                numClicks = 0
            Else
                MsgBox("El Registro no se Borro")
            End If
        End If

        Limpiar()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim query As String = "SELECT id, nombre  FROM Genero where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BuscaGenero.DataBuscagenero.DataSource = dt
        BuscaGenero.Show()
    End Sub

    Private Sub PicActualizar_Click(sender As Object, e As EventArgs) Handles PicActualizar.Click
        numClicks += 1
        If numClicks = 1 Then
            Dim query As String = "SELECT id, nombre  FROM Genero where estatus = 1"
            Dim dt As DataTable = Conecction.SelectQuery(query)
            ModificaGenero.DataModgenero.DataSource = dt
            ModificaGenero.Show()
        Else
            Dim parameters As SqlParameter() = {
         New SqlParameter("@id", txtidgen.Text),
           New SqlParameter("@nombre", txtNomGenero.Text),
         New SqlParameter("@IdUsuarioModifica", Cuenta.idU)
           }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPActualizarGenero", parameters)
            If success Then
                MsgBox("El Registro ha sido Modificado")
                numClicks = 0
            Else
                MsgBox("El Registro no se Modifico")

            End If
        End If
        Limpiar()
    End Sub

    Private Sub Genero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class