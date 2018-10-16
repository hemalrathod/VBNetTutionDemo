Imports System.Data.SqlClient

Public Class db
    Dim cn As SqlConnection

    Public Sub New()
        Dim cnstr As String = My.Settings.MiscConnectionString
        cn = New SqlConnection(cnstr)
    End Sub
    Public Function Read(str As String) As SqlDataReader
        Try
            'Sql Command is used to execute a query
            Dim cmd As New SqlCommand
            'Valid sql query
            cmd.CommandText = str
            'Set a connection
            cmd.Connection = cn
            'Set its type
            cmd.CommandType = CommandType.Text
            'Execute
            cn.Open()
            Dim rdr As SqlDataReader = cmd.ExecuteReader
            Return rdr
        Catch ex As Exception
        Finally
            'This is must
            'cn.Close()
        End Try
    End Function
    Public Function Update(str As String) As Integer
        Try
            'Sql Command is used to execute a query
            Dim cmd As New SqlCommand
            'Valid sql query
            cmd.CommandText = str
            'Set a connection
            cmd.Connection = cn
            'Set its type
            cmd.CommandType = CommandType.Text
            'Execute
            cn.Open()
            Dim i As Integer = cmd.ExecuteNonQuery()
            Return i
        Catch ex As Exception

        Finally
            'This is must
            cn.Close()
        End Try
    End Function
End Class
