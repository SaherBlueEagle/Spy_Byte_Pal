Public Class Compiler
    Public sock As Integer
    Private Sub SkyDarkButton1_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton1.Click
        If SkyDarkCombo1.SelectedItem.ToString.Contains(".vbs") Then
            Main.S.Send(sock, "script" & Main.Yy & TextBox8.Text & Main.Yy & ".vbs")
        ElseIf SkyDarkCombo1.SelectedItem.ToString.Contains(".bat") Then
            Main.S.Send(sock, "script" & Main.Yy & TextBox8.Text & Main.Yy & ".bat")
        ElseIf SkyDarkCombo1.SelectedItem.ToString.Contains(".html") Then
            Main.S.Send(sock, "script" & Main.Yy & TextBox8.Text & Main.Yy & ".html")
        Else
            MsgBox("Please Choose a Type", MsgBoxStyle.Critical)
        End If
    End Sub
End Class