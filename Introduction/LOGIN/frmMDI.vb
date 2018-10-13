Public Class frmMDI
    Private Sub frmMDI_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            'Calling the sub
            CloseApplication()
        End If
    End Sub

    Private Sub CloseApplication()
        'Confirmation for exiting application
        If MessageBox.Show(Me, "Are you sure you want to close this application?", "Close", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmMDI_Load(sender As Object, e As EventArgs) Handles Me.Load
        ViewToolStripMenuItem.Enabled = False
        'Validation calling
        frmStart.ShowDialog()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        'MsgBox(JUNCTION.USERNAME)
        If JUNCTION.USERNAME = "admin" Then
            'MsgBox("True")
            ViewToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        frmGrid.MdiParent = Me
        frmGrid.Show()
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        frmSetting.MdiParent = Me
        frmSetting.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        CloseApplication()
    End Sub

    Private Sub frmMDI_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.ToolStripStatusLabel1.Text = "USERNAME:" & JUNCTION.USERNAME
    End Sub
End Class