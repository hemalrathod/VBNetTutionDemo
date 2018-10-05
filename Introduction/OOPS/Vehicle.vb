Public Class Vehicle

    Public noofwheels As Integer
    Public noofgears As Integer
    Public power As Decimal
    Public clr As String
    Private PI As Decimal = 3.14

    Public Function GetPI()
        DoSomethingSecret()
        Return PI
    End Function


    Private Sub DoSomethingSecret()
        PI = 3.14 - 6.28 + 6.28
    End Sub
End Class
