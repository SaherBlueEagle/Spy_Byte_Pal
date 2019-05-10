<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RDP
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
        Me.components = New System.ComponentModel.Container()
        Me.SkyDarkForm1 = New X_Theme.SkyDarkForm()
        Me.c1 = New System.Windows.Forms.ComboBox()
        Me.c2 = New System.Windows.Forms.ComboBox()
        Me.p1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CyberButton1 = New X_Theme.SkyDarkButton()
        Me.Button1 = New X_Theme.SkyDarkButton()
        Me.c = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SkyDarkForm1.SuspendLayout()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.c1)
        Me.SkyDarkForm1.Controls.Add(Me.c2)
        Me.SkyDarkForm1.Controls.Add(Me.p1)
        Me.SkyDarkForm1.Controls.Add(Me.CheckBox1)
        Me.SkyDarkForm1.Controls.Add(Me.CheckBox2)
        Me.SkyDarkForm1.Controls.Add(Me.CyberButton1)
        Me.SkyDarkForm1.Controls.Add(Me.Button1)
        Me.SkyDarkForm1.Controls.Add(Me.c)
        Me.SkyDarkForm1.Controls.Add(Me.Label3)
        Me.SkyDarkForm1.Controls.Add(Me.Label1)
        Me.SkyDarkForm1.Controls.Add(Me.Label2)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(999, 603)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Desktop Controller "
        '
        'c1
        '
        Me.c1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.c1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c1.ForeColor = System.Drawing.Color.Lime
        Me.c1.FormattingEnabled = True
        Me.c1.Location = New System.Drawing.Point(93, 28)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(116, 21)
        Me.c1.TabIndex = 65
        '
        'c2
        '
        Me.c2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.c2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c2.ForeColor = System.Drawing.Color.Lime
        Me.c2.FormattingEnabled = True
        Me.c2.Location = New System.Drawing.Point(325, 28)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(112, 21)
        Me.c2.TabIndex = 64
        '
        'p1
        '
        Me.p1.Location = New System.Drawing.Point(3, 55)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(993, 545)
        Me.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.p1.TabIndex = 61
        Me.p1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox1.Location = New System.Drawing.Point(778, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox1.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox1.TabIndex = 60
        Me.CheckBox1.Text = "Keyboard"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox2.Location = New System.Drawing.Point(715, 32)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox2.Size = New System.Drawing.Size(57, 17)
        Me.CheckBox2.TabIndex = 50
        Me.CheckBox2.Text = "mouse"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CyberButton1
        '
        Me.CyberButton1.Location = New System.Drawing.Point(634, 29)
        Me.CyberButton1.Name = "CyberButton1"
        Me.CyberButton1.Size = New System.Drawing.Size(75, 23)
        Me.CyberButton1.TabIndex = 59
        Me.CyberButton1.Text = "save(.jpg)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(553, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Start"
        '
        'c
        '
        Me.c.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.c.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c.ForeColor = System.Drawing.Color.Lime
        Me.c.Location = New System.Drawing.Point(504, 33)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(43, 16)
        Me.c.TabIndex = 57
        Me.c.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(444, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Quality :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(215, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Update Interval :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Screen Size :"
        '
        'Timer1
        '
        '
        'RDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 603)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RDP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remote Desktop"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.SkyDarkForm1.PerformLayout()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As X_Theme.SkyDarkButton
    Friend WithEvents CyberButton1 As X_Theme.SkyDarkButton
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents p1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents c2 As System.Windows.Forms.ComboBox
    Friend WithEvents c1 As System.Windows.Forms.ComboBox
End Class
