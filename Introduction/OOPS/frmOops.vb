Public Class frmOops
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Use class to create object

        Dim splendor As New Twowheeler

        splendor.SetNoofgears()
        MsgBox(splendor.CalculateTorque())
    End Sub
End Class