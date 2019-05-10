Public Class Builder_Options_
    Dim x, y As Integer
    Dim loc As Object
    Dim xx As Integer
    Dim yy As Integer
    Dim loc2 As Object
    Dim locc As Object

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Not yy <= Builder.Panel2.Height - Me.Height Then
            yy -= 50
            Me.Location = New Point(locc, yy)
        Else
            Timer1.Stop()
            Builder_Anti.Show()
            Builder_Anti.Parent = Builder.Panel2

        End If
    End Sub

    Private Sub Builder_Options__Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TopLevel = False


        '   Me.Label1.Text = My.Settings.Username
        ' xx = Builder.Panel2.Width
        yy = Builder.Panel2.Height
        'x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        'y = Screen.PrimaryScreen.WorkingArea.Height


        '  locc = Builder.Panel2.Location.X + builder_host.Width

        locc = builder_host.Width

        ' loc = Screen.PrimaryScreen.WorkingArea.Location.X
        ' loc2 = Screen.PrimaryScreen.WorkingArea.Location.Y



        Me.Location = New Point(locc, yy)
        Me.TopMost = True
        Timer1.Start()
    End Sub
End Class