Imports System.Data.SqlClient

Public Class Idioma
    Private numClicks As Integer = 0

    Private Sub picAgregar_Click(sender As Object, e As EventArgs) Handles picAgregar.Click
        numClicks += 1
        If numClicks = 1 Then
            txtidIdioma.Enabled = False
        Else
            Dim parameters As SqlParameter() = {
           New SqlParameter("@Idioma", txtNomIdioma.Text),
           New SqlParameter("@UsuarioCrea", Cuenta.idU)
             }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPAgregarIdioma", parameters)
            If success Then
                MsgBox("El Registro ha sido Agregado")
                txtidIdioma.Enabled = True
                numClicks = 0
            Else
                MsgBox("El Registro no se Agrego")
            End If
        End If

        Limpiar()
    End Sub

    Sub Limpiar()
        txtNomIdioma.Clear()
        txtidIdioma.Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim query As String = "SELECT idIdioma, Idioma  FROM Idioma where estatus = 1"
        Dim dt As DataTable = Conecction.SelectQuery(query)
        BuscaIdioma.dataBuscaIdioma.DataSource = dt
        BuscaIdioma.Show()
    End Sub

    Private Sub PicBorrar_Click(sender As Object, e As EventArgs) Handles PicBorrar.Click
        numClicks += 1

        If numClicks = 1 Then
            txtNomIdioma.Enabled = False

        Else
            Dim parameters As SqlParameter() = {
          New SqlParameter("@idIdioma", txtidIdioma.Text),
          New SqlParameter("@IdUsuarioModifica", Cuenta.idU)
            }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPEliminarIdioma", parameters)
            If success Then
                MsgBox("El Registro ha sido Borrado")
                txtNomIdioma.Enabled = True
                numClicks = 0
            Else
                MsgBox("El Registro no se Borro")
                numClicks = 0
            End If
        End If

        Limpiar()
    End Sub

    Private Sub PicActualizar_Click(sender As Object, e As EventArgs) Handles PicActualizar.Click
        numClicks += 1
        If numClicks = 1 Then
            Dim query As String = "SELECT idIdioma, Idioma  FROM Idioma where estatus = 1"
            Dim dt As DataTable = Conecction.SelectQuery(query)
            ModificaIdioma.DataModIdioma.DataSource = dt
            ModificaIdioma.Show()
        Else
            Dim parameters As SqlParameter() = {
         New SqlParameter("@idIdioma", txtidIdioma.Text),
           New SqlParameter("@nombre", txtNomIdioma.Text),
         New SqlParameter("@IdUsuarioModifica", Cuenta.idU)
           }
            Dim success As Boolean = Conecction.ExecuteStoredProcedure("SPActualizarIdioma", parameters)
            If success Then
                MsgBox("El Registro ha sido Modificado")
                numClicks = 0
            Else
                MsgBox("El Registro no se Modifico")
            End If
        End If
        Limpiar()
    End Sub



End Class