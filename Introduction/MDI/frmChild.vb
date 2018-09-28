Public Class frmChild
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim message As String = String.Empty


        message = Me.DateTimePicker1.Value.ToShortDateString
        MsgBox(message)

        message = String.Empty
        For i = 0 To Me.CheckedListBox1.CheckedItems.Count - 1

            message = message & Me.CheckedListBox1.CheckedItems(i).ToString & ","

        Next

        MsgBox(message.TrimEnd(","))
    End Sub
End Class