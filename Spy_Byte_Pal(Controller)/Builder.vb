Public Class Builder

    Private Sub Builder_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Finish_Form.SaveControl()
    End Sub

    Private Sub Builder_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        builder_host.Show()
        builder_host.Parent = Me.Panel2
        Me.TransparencyKey = Color.FromArgb(62, 60, 58)

    End Sub
End Class