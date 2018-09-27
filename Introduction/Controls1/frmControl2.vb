Public Class frmControl2


    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        'To store facility names
        Dim facility As String = String.Empty

        If Me.CheckBox1.Checked = True Then
            facility = facility & Me.CheckBox1.Text & ","
        End If
        If Me.CheckBox2.Checked = True Then
            facility = facility & Me.CheckBox2.Text & ","
        End If
        If Me.CheckBox3.Checked = True Then
            facility = facility & Me.CheckBox3.Text
        End If

        MsgBox("Facility allotted to customer:" & facility)


        Dim gender As String = String.Empty
        If Me.RadioButton1.Checked = True Then
            gender = Me.RadioButton1.Text
        End If
        If Me.RadioButton2.Checked = True Then
            gender = Me.RadioButton2.Text
        End If
        MsgBox("Customer gender is:" & gender)


        MsgBox(Me.ComboBox1.Text)

        'Listbox items display
        Dim listboxselection As String = String.Empty
        Dim i As Integer = 0
        For i = 0 To Me.ListBox1.Items.Count - 1
            If Me.ListBox1.GetSelected(i) Then
                listboxselection = listboxselection & Me.ListBox1.Items(i).ToString & ","
            End If

        Next
        listboxselection = listboxselection.Replace(" ", "").TrimEnd(",")
        MsgBox("List Box Selected Service:" & listboxselection)
    End Sub
End Class