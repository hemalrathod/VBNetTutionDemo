Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This will exit my application

        'Dont use Me.close() because it will just disable the visual appearance of the form
        'It will be there in the memory
        'Me.Close()

        If MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Use this instead
            Application.Exit()
        End If
    End Sub
End Class
