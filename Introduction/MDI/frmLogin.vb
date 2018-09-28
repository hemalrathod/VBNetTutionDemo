Public Class frmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = "Admin"
        Dim password As String = "@123"

        If username.Equals(Me.TextBox1.Text) And password.Equals(Me.TextBox2.Text) Then
            Me.TextBox1.Clear()
            Me.TextBox2.Clear()
            frmMain.Show()
            Me.Hide()
        End If
    End Sub
End Class