Public Class Builder_Anti
    Dim x, y As Integer
    Dim loc As Object
    Dim xx As Integer
    Dim yy As Integer
    Dim loc2 As Object
    Dim locc As Object

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Not yy <= Builder.Panel2.Height - (builder_host.Height - (builder_host.TextBox4.Location.Y * 1.25)) Then
            yy -= 50
            Me.Location = New Point(locc, yy)
        Else
            Timer1.Stop()
            'after covering 
            'Start The Builder Button Form
            Finish_Form.Show()
            Finish_Form.Parent = Builder.Panel2
        End If
    End Sub

    Private Sub Builder_Anti__Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TopLevel = False


        '   Me.Label1.Text = My.Settings.Username
        ' xx = Builder.Panel2.Width
        yy = Builder.Panel2.Height
        'x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
        'y = Screen.PrimaryScreen.WorkingArea.Height


        '  locc = Builder.Panel2.Location.X + builder_host.Width

        locc = Builder.Panel2.Location.X

        ' loc = Screen.PrimaryScreen.WorkingArea.Location.X
        ' loc2 = Screen.PrimaryScreen.WorkingArea.Location.Y



        Me.Location = New Point(locc, yy)
        Me.TopMost = True
        Timer1.Start()
    End Sub

End Class