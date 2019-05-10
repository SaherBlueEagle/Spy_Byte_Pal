<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flooder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SkyDarkForm1 = New X_Theme.SkyDarkForm()
        Me.SkyDarkTabControl1 = New X_Theme.SkyDarkTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.attsock = New System.Windows.Forms.TextBox()
        Me.atttime = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.attthrd = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.attip = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.attport = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SkyDarkButton1 = New X_Theme.SkyDarkButton()
        Me.label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Ddosbar = New System.Windows.Forms.TrackBar()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.attlog = New System.Windows.Forms.TextBox()
        Me.SkyDarkForm1.SuspendLayout()
        Me.SkyDarkTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Ddosbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkTabControl1)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(464, 161)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "DDOS / Http Flooder"
        '
        'SkyDarkTabControl1
        '
        Me.SkyDarkTabControl1.Controls.Add(Me.TabPage1)
        Me.SkyDarkTabControl1.Controls.Add(Me.TabPage2)
        Me.SkyDarkTabControl1.Controls.Add(Me.TabPage3)
        Me.SkyDarkTabControl1.Location = New System.Drawing.Point(3, 25)
        Me.SkyDarkTabControl1.Name = "SkyDarkTabControl1"
        Me.SkyDarkTabControl1.SelectedIndex = 0
        Me.SkyDarkTabControl1.Size = New System.Drawing.Size(458, 133)
        Me.SkyDarkTabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(450, 104)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main Panel"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.attsock)
        Me.GroupBox2.Controls.Add(Me.atttime)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.attthrd)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox2.Location = New System.Drawing.Point(217, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 103)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Threads & Request Options"
        '
        'attsock
        '
        Me.attsock.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.attsock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attsock.ForeColor = System.Drawing.Color.Lime
        Me.attsock.Location = New System.Drawing.Point(72, 75)
        Me.attsock.Name = "attsock"
        Me.attsock.Size = New System.Drawing.Size(93, 20)
        Me.attsock.TabIndex = 30
        '
        'atttime
        '
        Me.atttime.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.atttime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.atttime.ForeColor = System.Drawing.Color.Lime
        Me.atttime.Location = New System.Drawing.Point(128, 36)
        Me.atttime.Name = "atttime"
        Me.atttime.Size = New System.Drawing.Size(77, 20)
        Me.atttime.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Lime
        Me.Label19.Location = New System.Drawing.Point(69, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Number of sockets"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Lime
        Me.Label17.Location = New System.Drawing.Point(125, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Delay (ms)"
        '
        'attthrd
        '
        Me.attthrd.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.attthrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attthrd.ForeColor = System.Drawing.Color.Lime
        Me.attthrd.Location = New System.Drawing.Point(6, 36)
        Me.attthrd.Name = "attthrd"
        Me.attthrd.Size = New System.Drawing.Size(77, 20)
        Me.attthrd.TabIndex = 28
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Lime
        Me.Label18.Location = New System.Drawing.Point(3, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Number of threads"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.attip)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.attport)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox1.Location = New System.Drawing.Point(2, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 65)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connecttion Options"
        '
        'attip
        '
        Me.attip.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.attip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attip.ForeColor = System.Drawing.Color.Lime
        Me.attip.Location = New System.Drawing.Point(8, 36)
        Me.attip.Name = "attip"
        Me.attip.Size = New System.Drawing.Size(129, 20)
        Me.attip.TabIndex = 22
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Lime
        Me.Label20.Location = New System.Drawing.Point(140, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(27, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Port"
        '
        'attport
        '
        Me.attport.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.attport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attport.ForeColor = System.Drawing.Color.Lime
        Me.attport.Location = New System.Drawing.Point(143, 36)
        Me.attport.Name = "attport"
        Me.attport.Size = New System.Drawing.Size(60, 20)
        Me.attport.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Lime
        Me.Label15.Location = New System.Drawing.Point(8, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "IP"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.SkyDarkButton1)
        Me.TabPage2.Controls.Add(Me.label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Ddosbar)
        Me.TabPage2.ForeColor = System.Drawing.Color.Lime
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(450, 104)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Flooder"
        '
        'SkyDarkButton1
        '
        Me.SkyDarkButton1.Location = New System.Drawing.Point(372, 78)
        Me.SkyDarkButton1.Name = "SkyDarkButton1"
        Me.SkyDarkButton1.Size = New System.Drawing.Size(75, 23)
        Me.SkyDarkButton1.TabIndex = 34
        Me.SkyDarkButton1.Text = "Start"
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.ForeColor = System.Drawing.Color.Lime
        Me.label14.Location = New System.Drawing.Point(347, 59)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(26, 13)
        Me.label14.TabIndex = 33
        Me.label14.Text = "TCP"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Lime
        Me.Label13.Location = New System.Drawing.Point(261, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "SYN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Lime
        Me.Label12.Location = New System.Drawing.Point(161, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "HTTP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Lime
        Me.Label11.Location = New System.Drawing.Point(73, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "UDP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Lime
        Me.Label10.Location = New System.Drawing.Point(171, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Choose Flood Type"
        '
        'Ddosbar
        '
        Me.Ddosbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Ddosbar.Location = New System.Drawing.Point(75, 27)
        Me.Ddosbar.Maximum = 4
        Me.Ddosbar.Minimum = 1
        Me.Ddosbar.Name = "Ddosbar"
        Me.Ddosbar.Size = New System.Drawing.Size(298, 45)
        Me.Ddosbar.TabIndex = 28
        Me.Ddosbar.Value = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.attlog)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(450, 104)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Log"
        '
        'attlog
        '
        Me.attlog.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.attlog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attlog.ForeColor = System.Drawing.Color.Lime
        Me.attlog.Location = New System.Drawing.Point(3, 3)
        Me.attlog.Multiline = True
        Me.attlog.Name = "attlog"
        Me.attlog.ReadOnly = True
        Me.attlog.Size = New System.Drawing.Size(441, 95)
        Me.attlog.TabIndex = 15
        Me.attlog.Text = "Flood Logs :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Flooder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 161)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Flooder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flooder"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.SkyDarkTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Ddosbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents SkyDarkTabControl1 As X_Theme.SkyDarkTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents attsock As System.Windows.Forms.TextBox
    Friend WithEvents atttime As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents attthrd As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents attip As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents attport As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Ddosbar As System.Windows.Forms.TrackBar
    Friend WithEvents SkyDarkButton1 As X_Theme.SkyDarkButton
    Friend WithEvents attlog As System.Windows.Forms.TextBox
End Class
