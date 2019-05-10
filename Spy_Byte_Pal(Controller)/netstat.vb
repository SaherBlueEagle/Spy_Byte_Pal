Public Class netstat
    Public sock As Integer

    Private Sub RefreshNetworkInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshNetworkInformationToolStripMenuItem.Click
        ListView2.Items.Clear()
        ListView1.Items.Clear()
        Main.S.Send(sock, "getstat")
    End Sub


    Private Sub netstat_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListView2.Items.Clear()
        ListView1.Items.Clear()
        Main.S.Send(sock, "getstat")
    End Sub
End Class