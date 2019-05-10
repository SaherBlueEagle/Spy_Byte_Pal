Public Class Manage_Devices_and_Printers
    Public sock As Integer

    Private Sub Manage_Devices_and_Printers_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Main.S.Send(sock, "getinfonow")
        'Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Main.S.Send(sock, "cputemp")
    End Sub
End Class