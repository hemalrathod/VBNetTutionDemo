Public Class frmPicture
    Dim str As String = String.Empty
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            str = Me.OpenFileDialog1.FileName

            Me.PictureBox1.Image = Bitmap.FromFile(Str)

            Me.Button2.BackgroundImage = Bitmap.FromFile(Str)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmImage.FilePath = str
        frmImage.ShowDialog()
    End Sub
End Class