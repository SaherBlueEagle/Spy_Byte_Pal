Public Class builder_host
    Dim x, y As Integer
    Dim loc As Object
    Dim xx As Integer
    Dim yy As Integer
    Dim loc2 As Object
    Dim locc As Object

    Private Sub builder_host_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TopLevel = False


        '   Me.Label1.Text = My.Settings.Username
        ' xx = Builder.Panel2.Width
        yy = Builder.Panel2.Height
        'x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        'y = Screen.PrimaryScreen.WorkingArea.Height


        locc = Builder.Panel2.Location.X '- Me.Width

        ' loc = Screen.PrimaryScreen.WorkingArea.Location.X
        ' loc2 = Screen.PrimaryScreen.WorkingArea.Location.Y



        Me.Location = New Point(locc, yy)
        Me.TopMost = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Not yy <= Builder.Panel2.Height - Me.Height Then
            yy -= 50
            Me.Location = New Point(locc, yy)
        Else
            Timer1.Stop()
            Builder_Options_.Show()
            Builder_Options_.Parent = Builder.Panel2
        End If
    End Sub

   
End Class