Imports Introduction.DS
Imports Introduction.DSTableAdapters

Public Class frmStart
    Private Sub frmStart_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Validation for empty string
        If Me.TextBox1.Text = String.Empty Or Me.TextBox2.Text = String.Empty Then
            Exit Sub
        End If

        'Login Validation
        Dim username As String = Me.TextBox1.Text.Trim
        Dim password As String = Me.TextBox2.Text.Trim

        Dim uda As New USERSTableAdapter
        Dim ud As USERSDataTable = uda.GetUsersByUsernamePassword(username, password)
        If ud.Count > 0 Then
            JUNCTION.USERNAME = username
            Me.Hide()
        Else
            MsgBox("Username or password is incorrect")
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Button1.Focus()
        End If
    End Sub
End Class