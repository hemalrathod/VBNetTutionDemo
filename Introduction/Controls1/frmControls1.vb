Public Class frmControls1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Get both the information
        Dim email As String
        Dim password As String

        'Assign the values of both textboxes
        email = Me.TextBox1.Text
        password = Me.TextBox2.Text

        'Validation
        Dim originalEmail As String = "Admin"
        Dim originalPassword As String = "@123"
        If email = originalEmail And password = originalPassword Then
            MsgBox("Success")
        Else
            MsgBox("Login invalid")
        End If

    End Sub
End Class
