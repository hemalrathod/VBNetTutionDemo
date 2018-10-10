Imports System.Data.SqlClient
Imports Introduction.DS
Imports Introduction.DSTableAdapters

Public Class frmData
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'This will create data adapter for the table
        Dim uda As New USERSTableAdapter

        'This will insert the data
        uda.Insert(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text, Me.TextBox4.Text, CDate(Me.MaskedTextBox1.Text), Me.TextBox6.Text, Me.TextBox7.Text)

        'Confirmation message
        MsgBox("Saved")

        uda = Nothing

        'Dim cn As New SqlConnection
        'cn.Open()


        'Dim da As New SqlDataAdapter

        'Dim dt As New DS.USERSDataTable

        'Dim row As DS.USERSRow = dt.NewUSERSRow

        'row.PASSWORD = "123"
        'dt.AddUSERSRow(row)
        'da.Update(dt)


        'cn.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            'This will create adapter
            Dim uda As New USERSTableAdapter
            Dim udt As USERSDataTable = uda.GetDataBy(Me.TextBox5.Text)
            Dim ur As USERSRow = udt.Item(0)
            Me.TextBox1.Text = ur.FIRSTNAME
            Me.TextBox2.Text = ur.LASTNAME
            Me.TextBox3.Text = ur.EMAIL
            Me.TextBox4.Text = ur.MOBILE
            Me.MaskedTextBox1.Text = ur.BIRTHDATE
            Me.TextBox6.Text = ur.USERNAME
            Me.TextBox7.Text = ur.PASSWORD
            ur = Nothing
            udt = Nothing
            uda = Nothing
        Catch ex As Exception
            MsgBox("Data not found " & ex.Message)
        End Try

    End Sub
End Class