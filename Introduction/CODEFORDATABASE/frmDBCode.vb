Imports System.Data.SqlClient

Public Class frmDBCode
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "INSERT INTO USERS VALUES('" & Me.TextBox1.Text & "','" & Me.TextBox2.Text & "','" & Me.TextBox3.Text & "','" & Me.TextBox4.Text & "','" & CDate(Me.MaskedTextBox1.Text) & "','" & Me.TextBox6.Text & "','" & Me.TextBox7.Text & "')"
        Dim obj As New db
        Dim i As Integer = obj.Update(str)
        MsgBox(i)
        obj = Nothing
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.TextBox6.Text = "" Then
            Exit Sub
        End If
        Dim str As String = "Select * from Users where Username='" & Me.TextBox6.Text.Trim & "'"
        Dim obj As New db
        Dim rdr As SqlDataReader = obj.Read(str)
        If rdr.HasRows = True Then
            rdr.Read()
            Me.TextBox1.Text = rdr.Item("FIRSTNAME")
            Me.TextBox2.Text = rdr.Item("LASTNAME")
            Me.TextBox3.Text = rdr.Item("EMAIL")
            Me.TextBox4.Text = rdr.Item("MOBILE")
            Me.MaskedTextBox1.Text = rdr.Item("BIRTHDATE")
            Me.TextBox7.Text = rdr.Item("PASSWORD")
            Me.TextBox6.ReadOnly = True
        End If
        rdr.Close()
        obj = Nothing

    End Sub
End Class