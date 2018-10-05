Public Class Twowheeler
    Inherits Vehicle

    Public powercapacity As Decimal = 8
    Public price As Decimal

    'Sub can not return a value
    'Function can
    Public Sub SetNoofgears()
        MyBase.noofgears = 4
    End Sub


    Public Sub SetNoofwheels()
        MyBase.noofwheels = 2
    End Sub

    Public Function CalculateTorque()
        Dim torque As Decimal
        torque = 80 * 3.5 * noofgears / MyBase.GetPI
        Return torque
    End Function
End Class
