Public Class frmImage
    Private filepathsecret As String
    Public Property FilePath As String
        Get
            Return filepathsecret
        End Get
        Set(ByVal value As String)
            filepathsecret = value
        End Set
    End Property
    Private Sub frmImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PictureBox1.Image = Bitmap.FromFile(filepathsecret)
    End Sub
End Class