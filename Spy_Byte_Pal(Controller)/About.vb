Public Class About
    Dim speechobject
    Dim x, y As Integer
    Dim loc As Object
    Dim loc2 As Object
    Private Sub Speak()
        speechobject = CreateObject("sapi.spvoice")
        speechobject.speak("Welcome to Spy Pal ")
        speechobject.speak("Saher Blue Eagle Products")
        Timer1.Stop()
    End Sub

    Private Sub About_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Process.Start("https://www.facebook.com/SaherBlueEagle.ghtml")
    End Sub

    Private Sub About_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.TransparencyKey = Color.FromArgb(62, 60, 58)
        x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        y = Screen.PrimaryScreen.WorkingArea.Height




        Loc = Screen.PrimaryScreen.WorkingArea.Location.X
        loc2 = Screen.PrimaryScreen.WorkingArea.Location.Y



        Me.Location = New Point(Loc, y)
        Me.TopMost = True
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Not y <= Screen.PrimaryScreen.WorkingArea.Height - Me.Height Then
            y -= 50
            Me.Location = New Point(loc, y)
        Else
            Speak()

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.facebook.com/SaherBlueEagle.ghtml")
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("https://www.youtube.com/channel/UC_TMZYaLIgjsdJMwurHAi4Q")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("https://www.youtube.com/channel/UCgl15Th67TchA296hkkWbAA")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://www.facebook.com/CyberSpLiTTerVbs")
    End Sub
End Class