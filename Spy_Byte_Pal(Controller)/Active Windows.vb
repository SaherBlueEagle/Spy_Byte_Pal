Public Class Active_Windows
    Dim rr As New TextBox
    Dim KKKKS As New TextBox
    Public sock As Integer
    Dim state As Integer
    Dim time As Integer

    Private Sub Active_Windows_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        rr.Text = 1
        Timer3.Enabled = True
        Me.Opacity = 0.8R



        Main.S.Send(sock, "Winsx")




        If state = 1 Then

            Timer1.Interval = time
            Timer1.Start()
        Else

            Timer1.Stop()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ListView1.Items.Clear()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        KKKKS.Text = ListView1.Items.Item(ListView1.FocusedItem.Index).SubItems.Item(0).Text
        'MsgBox(KKKKS.Text)
    End Sub



    Private Sub KillWindowsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KillWindowsToolStripMenuItem.Click


        For Each x As ListViewItem In Main.L1.SelectedItems
            Main.S.Send(x.ToolTipText, "KLACt" & "|BlueEagle|" & KKKKS.Text)
            ListView1.Items.Clear()
            Main.S.Send(sock, "Winsx")
        Next
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        rr.Text = 1
        Timer3.Enabled = True
        Me.Opacity = 0.8R

        ListView1.Items.Clear()
        Main.S.Send(sock, "Winsx")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim C As String
        C = ListView1.Items.Count.ToString

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        rr.Text += 1

        If rr.Text = 5 Then
            Me.Opacity = 9.9R

            Timer3.Enabled = False
        End If
    End Sub

End Class