Imports System.Runtime.InteropServices

Public Class Fun
    Public sock As Integer
    ' Public f As Form1
    <DllImport("KERNEL32.DLL")> _
    Public Shared Sub Beep(ByVal freq As Integer, ByVal dur As Integer)
    End Sub
    Public ReadOnly Property title
        Get
            Return TextBox6.Text
        End Get
    End Property
    Public ReadOnly Property message
        Get
            Return TextBox5.Text
        End Get
    End Property
    Public ReadOnly Property messageicon
        Get
            If RadioButton1.Checked Then
                Return "1"
            ElseIf RadioButton2.Checked Then
                Return "2"
            ElseIf RadioButton3.Checked Then
                Return "3"
            ElseIf RadioButton4.Checked Then
                Return "4"
            Else
                Return "1"
            End If
        End Get
    End Property
    Public ReadOnly Property messagebutton
        Get
            If RadioButton5.Checked Then
                Return "1"
            ElseIf RadioButton6.Checked Then
                Return "2"
            ElseIf RadioButton7.Checked Then
                Return "3"
            ElseIf RadioButton8.Checked Then
                Return "4"
            ElseIf RadioButton9.Checked Then
                Return "5"
            ElseIf RadioButton10.Checked Then
                Return "6"
            Else
                Return "1"
            End If
        End Get
    End Property
    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click
        Dim x As MessageBoxIcon
        Dim y As MessageBoxButtons

        If RadioButton1.Checked = True Then
            x = MessageBoxIcon.Information
        ElseIf RadioButton2.Checked Then
            x = MessageBoxIcon.Question
        ElseIf RadioButton3.Checked Then
            x = MessageBoxIcon.Warning
        ElseIf RadioButton4.Checked Then
            x = MessageBoxIcon.Error
        Else
            x = MessageBoxIcon.Asterisk
        End If
        '#################################################################"
        If RadioButton5.Checked Then
            y = MessageBoxButtons.YesNo

        ElseIf RadioButton6.Checked Then
            y = MessageBoxButtons.YesNoCancel
        ElseIf RadioButton7.Checked Then
            y = MessageBoxButtons.OK
        ElseIf RadioButton8.Checked Then
            y = MessageBoxButtons.OKCancel
        ElseIf RadioButton9.Checked Then
            y = MessageBoxButtons.RetryCancel

        ElseIf RadioButton10.Checked Then
            y = MessageBoxButtons.AbortRetryIgnore
        Else
            y = MessageBoxButtons.OK
        End If
        MessageBox.Show(TextBox5.Text, TextBox6.Text, y, x)
    End Sub '### Test Local
    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        Main.S.Send(sock, "ErorrMsg" & Main.Yy & messageicon & Main.Yy & messagebutton & Main.Yy & title & Main.Yy & message)
    End Sub

#Region "Small_Piano"
    Private Sub Button52_Click(sender As System.Object, e As System.EventArgs) Handles Button52.Click
        Main.S.Send(sock, "piano" & Main.Yy & 361)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(361, 300)
    End Sub

    Private Sub Button44_Click(sender As System.Object, e As System.EventArgs) Handles Button44.Click
        Main.S.Send(sock, "piano" & Main.Yy & 277)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(277, 300)
    End Sub

    Private Sub Button51_Click(sender As System.Object, e As System.EventArgs) Handles Button51.Click
        Main.S.Send(sock, "piano" & Main.Yy & 393)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(393, 300)
    End Sub

    Private Sub Button43_Click(sender As System.Object, e As System.EventArgs) Handles Button43.Click
        Main.S.Send(sock, "piano" & Main.Yy & 311)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(311, 300)
    End Sub

    Private Sub Button50_Click(sender As System.Object, e As System.EventArgs) Handles Button50.Click
        Main.S.Send(sock, "piano" & Main.Yy & 429)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(429, 300)
    End Sub

    Private Sub Button49_Click(sender As System.Object, e As System.EventArgs) Handles Button49.Click
        Main.S.Send(sock, "piano" & Main.Yy & 449)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(449, 300)
    End Sub

    Private Sub Button42_Click(sender As System.Object, e As System.EventArgs) Handles Button42.Click
        Main.S.Send(sock, "piano" & Main.Yy & 369)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(369, 300)
    End Sub

    Private Sub Button48_Click(sender As System.Object, e As System.EventArgs) Handles Button48.Click
        Main.S.Send(sock, "piano" & Main.Yy & 491)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(491, 300)
    End Sub

    Private Sub Button41_Click(sender As System.Object, e As System.EventArgs) Handles Button41.Click
        Main.S.Send(sock, "piano" & Main.Yy & 415)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(415, 300)
    End Sub

    Private Sub Button47_Click(sender As System.Object, e As System.EventArgs) Handles Button47.Click
        Main.S.Send(sock, "piano" & Main.Yy & 540)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(540, 300)
    End Sub

    Private Sub Button40_Click(sender As System.Object, e As System.EventArgs) Handles Button40.Click
        Main.S.Send(sock, "piano" & Main.Yy & 466)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(466, 300)
    End Sub

    Private Sub Button46_Click(sender As System.Object, e As System.EventArgs) Handles Button46.Click
        Main.S.Send(sock, "piano" & Main.Yy & 593)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(593, 300)
    End Sub

    Private Sub Button45_Click(sender As System.Object, e As System.EventArgs) Handles Button45.Click
        Main.S.Send(sock, "piano" & Main.Yy & 623)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(623, 300)
    End Sub
#End Region

    Private Sub BlackShadesNetButton20_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton20.Click
        '  "LockPC"
        Main.S.Send(sock, "LockPC")
    End Sub

    Private Sub BlackShadesNetButton23_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton23.Click
        '"BepX"
        Main.S.Send(sock, "BepX" & Main.Yy & TextBox3.Text & Main.Yy & TextBox4.Text)
    End Sub

    Private Sub BlackShadesNetButton9_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton9.Click

        Main.S.Send(sock, "TaskbarHide") '
    End Sub

    Private Sub BlackShadesNetButton10_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton10.Click
        Main.S.Send(sock, "TaskbarShow") '"TaskbarHide"
    End Sub

    Private Sub BlackShadesNetButton2_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton2.Click
        'clock hide

        Main.S.Send(sock, "ClockOFF")
    End Sub

    Private Sub BlackShadesNetButton1_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton1.Click

        Main.S.Send(sock, "ClockON")
    End Sub

    Private Sub BlackShadesNetButton27_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton27.Click
        'screen off
        '"TurnOffMonitor"
        Main.S.Send(sock, "TurnOffMonitor")
    End Sub

    Private Sub BlackShadesNetButton28_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton28.Click
        'screen on 
        '"TurnOnMonitor"
        Main.S.Send(sock, "TurnOnMonitor")
    End Sub

    Private Sub BlackShadesNetButton26_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton26.Click

        Main.S.Send(sock, "IEhome" & Main.Yy & TextBox2.Text)
    End Sub

    Private Sub BlackShadesNetButton3_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton3.Click
        '"shutdowncomputer"
        Main.S.Send(sock, "shutdowncomputer")
    End Sub

    Private Sub BlackShadesNetButton4_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton4.Click
        '"logoff"
        Main.S.Send(sock, "logoff")
    End Sub

    Private Sub BlackShadesNetButton21_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton21.Click
        '
        Main.S.Send(sock, "restartcomputer")
    End Sub

    Private Sub BlackShadesNetButton22_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton22.Click
        '
        Main.S.Send(sock, "sleep")
    End Sub

    Private Sub BlackShadesNetButton6_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton6.Click
        '
        Main.S.Send(sock, "volup")
    End Sub

    Private Sub BlackShadesNetButton5_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton5.Click
        '
        Main.S.Send(sock, "voldn")
    End Sub

    Private Sub BlackShadesNetButton19_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton19.Click
        '
        Main.S.Send(sock, "mute")
    End Sub
    '

    Private Sub BlackShadesNetButton29_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton29.Click
        Main.S.Send(sock, "TextToSpeech" & Main.Yy & TextBox1.Text)
    End Sub

    Private Sub BlackShadesNetButton15_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton15.Click
        '
        Main.S.Send(sock, "NormalMouse")
    End Sub

    Private Sub BlackShadesNetButton16_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton16.Click
        ' 
        Main.S.Send(sock, "ReverseMouse")
    End Sub

    Private Sub BlackShadesNetButton14_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton14.Click
        '
        Main.S.Send(sock, "opencd")
    End Sub

    Private Sub BlackShadesNetButton13_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton13.Click
        '
        Main.S.Send(sock, "closecd")
    End Sub

    Private Sub BlackShadesNetButton8_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton8.Click
        '
        Main.S.Send(sock, "taskbaroff")
    End Sub

    Private Sub BlackShadesNetButton7_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton7.Click
        '
        Main.S.Send(sock, "taskbaron")
    End Sub

    Private Sub BlackShadesNetButton12_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton12.Click
        '
        Main.S.Send(sock, "taskmanageroff")
    End Sub

    Private Sub BlackShadesNetButton11_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton11.Click
        '
        Main.S.Send(sock, "taskmanageron")
    End Sub

    Private Sub BlackShadesNetButton25_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton25.Click
        '
        Main.S.Send(sock, "exploreroff")
    End Sub

    Private Sub BlackShadesNetButton24_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton24.Click
        '
        Main.S.Send(sock, "exploreron")
    End Sub

    Private Sub BlackShadesNetButton18_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton18.Click
        '
        Main.S.Send(sock, "blockmouseandkeyboard")
    End Sub

    Private Sub BlackShadesNetButton17_Click(sender As System.Object, e As System.EventArgs) Handles BlackShadesNetButton17.Click
        '
        Main.S.Send(sock, "unblockmouseandkeyboard")
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Main.S.Send(sock, "piano" & Main.Yy & 361)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(362, 300)
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Main.S.Send(sock, "piano" & Main.Yy & 361)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(365, 300)
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        Main.S.Send(sock, "piano" & Main.Yy & 361)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(361, 300)
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Main.S.Send(sock, "piano" & Main.Yy & 361)
        If Check_Sound.Checked = False Then Exit Sub
        Beep(361, 300)
    End Sub
End Class