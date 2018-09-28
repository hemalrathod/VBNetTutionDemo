Public Class frmMain

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        frmChild.MdiParent = Me
        frmChild.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Application.Exit()
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class