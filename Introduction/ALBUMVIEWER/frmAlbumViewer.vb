Imports System.IO

Public Class frmAlbumViewer
    Private Sub frmAlbumViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For i = 1 To 6
        '    Dim btn As New Button
        '    'btn.Text = "Button " & i
        '    Me.TableLayoutPanel1.Controls.Add(btn)
        '    Dim w As Integer = Me.TableLayoutPanel1.ColumnStyles.Item(0).Width * Me.TableLayoutPanel1.Size.Width / 100
        '    Dim h As Integer = Me.TableLayoutPanel1.RowStyles.Item(0).Height * Me.TableLayoutPanel1.Size.Height / 100
        '    btn.Size = New Size(w, h)
        '    btn.Image = Bitmap.FromFile("C:\Users\hemal\Downloads\JIYA PAN CARD.png").GetThumbnailImage(btn.Size.Width, btn.Size.Height, Nothing, IntPtr.Zero)
        '    btn.Tag = "C:\Users\hemal\Downloads\JIYA PAN CARD.png"
        '    AddHandler btn.Click, AddressOf HandleButtonClick
        'Next
    End Sub
    Private Sub HandleButtonClick(sender As Object, e As EventArgs)
        Dim btn As Button = sender
        'MsgBox(btn.Tag.ToString)
        frmImage.FilePath = btn.Tag.ToString
        frmImage.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            Dim folderpath As String = Me.FolderBrowserDialog1.SelectedPath
            Dim files As String() = Directory.GetFiles(folderpath)
            For Each file As String In files
                Dim ext As String = Path.GetExtension(file)
                If ext = ".png" Then
                    Dim btn As New Button
                    'btn.Text = "Button " & i
                    Me.TableLayoutPanel1.Controls.Add(btn)
                    Dim w As Integer = Me.TableLayoutPanel1.ColumnStyles.Item(0).Width * Me.TableLayoutPanel1.Size.Width / 100
                    Dim h As Integer = Me.TableLayoutPanel1.RowStyles.Item(0).Height * Me.TableLayoutPanel1.Size.Height / 100
                    btn.Size = New Size(w, h)
                    btn.Image = Bitmap.FromFile(file).GetThumbnailImage(btn.Size.Width, btn.Size.Height, Nothing, IntPtr.Zero)
                    btn.Tag = file
                    AddHandler btn.Click, AddressOf HandleButtonClick
                End If
            Next
        End If
    End Sub
End Class