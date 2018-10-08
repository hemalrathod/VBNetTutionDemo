Public Class frmEvent
    Dim privatesession As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hello")

    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        'Cursor enter will fire the code
        MsgBox("Cursor in")
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Dim str As String = Me.TextBox1.Text

        If str = "Admin" Then
            Me.Label1.Text = "User already exists"
        Else
            Me.Label1.Text = "User available"
        End If
    End Sub

    Private Sub frmEvent_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEvent_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        MsgBox(e.X & "," & e.Y)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBox3.Focus()
        End If
    End Sub

    Private Sub frmEvent_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        MsgBox("Resize")
    End Sub

    Private Sub frmEvent_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Maximized Then
            MsgBox("Maximized")
        End If
        If Me.WindowState = FormWindowState.Minimized Then
            MsgBox("Minimized")
        End If
    End Sub

    Private Sub frmEvent_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged
        MsgBox("Maximum changed")
    End Sub

    Private Sub frmEvent_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        privatesession = String.Empty
        MsgBox("Form closed")
    End Sub

    Private Sub frmEvent_Load(sender As Object, e As EventArgs) Handles Me.Load
        privatesession = New Guid().NewGuid().ToString()
        MsgBox(privatesession)
    End Sub

    Private Sub frmEvent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MsgBox("Form closing started")
    End Sub
End Class