Imports Introduction.DSTableAdapters

Public Class frmGrid
    Public Sub RefreshGrid()
        'TODO: This line of code loads data into the 'DS.USERS' table. You can move, or remove it, as needed.
        Me.USERSTableAdapter.Fill(Me.DS.USERS)
    End Sub
    Private Sub frmGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()

    End Sub

    Private Sub frmGrid_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim username As String = Me.DataGridView1.SelectedRows(0).Cells(5).Value.ToString
        'MsgBox(username)
        Dim frm As New frmSetting(username)
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmSetting(1)
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            'MsgBox("delete")
            DeleteUser()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DeleteUser()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteUser()
    End Sub
    Private Sub DeleteUser()
        Dim uda As New USERSTableAdapter
        Dim username As String = Me.DataGridView1.SelectedRows(0).Cells(5).Value.ToString
        If username = "admin" Then
            MsgBox("Admin can not be deleted. નવી મજૂરી કરવી પડશે.")
            Exit Sub
        End If
        If MessageBox.Show(Me, "Delete?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            uda.Delete(username)
        MsgBox("User deleted")
            RefreshGrid()
        End If
        uda = Nothing
    End Sub
End Class