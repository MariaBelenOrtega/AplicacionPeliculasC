Public Class Espera
    Private Sub Espera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SimularProgreso()
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.None
        ProgressBar1.Maximum = 100

    End Sub

    Public Sub SimularProgreso()
        For i As Integer = 0 To 100
            ProgressBar1.Value = i
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
        Next

        If ProgressBar1.Value = 100 Then
            Peliculas.Show()
            Me.Close()
        End If
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class