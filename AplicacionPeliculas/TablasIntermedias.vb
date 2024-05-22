Public Class TablasIntermedias
    Dim idbuscaP As Integer
    Private Sub PicBuscaPeli_Click(sender As Object, e As EventArgs) Handles PicBuscaPeli.Click
        Peliculas.Show()
    End Sub

    Private Sub TablasIntermedias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idbuscaP = Peliculas.idpeli
    End Sub


End Class