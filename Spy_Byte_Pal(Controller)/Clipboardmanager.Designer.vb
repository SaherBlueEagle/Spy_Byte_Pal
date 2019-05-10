<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clipboardmanager
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SkyDarkButton3 = New X_Theme.SkyDarkButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkyDarkButton2 = New X_Theme.SkyDarkButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SkyDarkButton4 = New X_Theme.SkyDarkButton()
        Me.SkyDarkButton5 = New X_Theme.SkyDarkButton()
        Me.SkyDarkSeperator2 = New X_Theme.SkyDarkSeperator()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SkyDarkForm1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton5)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton4)
        Me.SkyDarkForm1.Controls.Add(Me.PictureBox2)
        Me.SkyDarkForm1.Controls.Add(Me.Label4)
        Me.SkyDarkForm1.Controls.Add(Me.Label3)
        Me.SkyDarkForm1.Controls.Add(Me.TextBox2)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton3)
        Me.SkyDarkForm1.Controls.Add(Me.PictureBox1)
        Me.SkyDarkForm1.Controls.Add(Me.Label1)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton2)
        Me.SkyDarkForm1.Controls.Add(Me.Label2)
        Me.SkyDarkForm1.Controls.Add(Me.TextBox1)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkSeperator2)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(642, 410)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Clipboard Manager"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(333, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 22)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Clipboard Text Setter"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.Color.Lime
        Me.TextBox2.Location = New System.Drawing.Point(337, 53)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(205, 52)
        Me.TextBox2.TabIndex = 38
        '
        'SkyDarkButton3
        '
        Me.SkyDarkButton3.ForeColor = System.Drawing.Color.Lime
        Me.SkyDarkButton3.Location = New System.Drawing.Point(548, 66)
        Me.SkyDarkButton3.Name = "SkyDarkButton3"
        Me.SkyDarkButton3.Size = New System.Drawing.Size(83, 23)
        Me.SkyDarkButton3.TabIndex = 37
        Me.SkyDarkButton3.Text = "Set Clipboard"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(298, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(78, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 22)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Clipboard Image"
        '
        'SkyDarkButton2
        '
        Me.SkyDarkButton2.ForeColor = System.Drawing.Color.Lime
        Me.SkyDarkButton2.Location = New System.Drawing.Point(42, 383)
        Me.SkyDarkButton2.Name = "SkyDarkButton2"
        Me.SkyDarkButton2.Size = New System.Drawing.Size(215, 23)
        Me.SkyDarkButton2.TabIndex = 33
        Me.SkyDarkButton2.Text = "Get Clipboard data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 22)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Clipboard Text"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(7, 53)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(294, 63)
        Me.TextBox1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(332, 140)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(298, 237)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(393, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 22)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Clipboard Image Setter"
        '
        'SkyDarkButton4
        '
        Me.SkyDarkButton4.ForeColor = System.Drawing.Color.Lime
        Me.SkyDarkButton4.Location = New System.Drawing.Point(518, 383)
        Me.SkyDarkButton4.Name = "SkyDarkButton4"
        Me.SkyDarkButton4.Size = New System.Drawing.Size(113, 23)
        Me.SkyDarkButton4.TabIndex = 45
        Me.SkyDarkButton4.Text = "Set Clipboard Image"
        '
        'SkyDarkButton5
        '
        Me.SkyDarkButton5.ForeColor = System.Drawing.Color.Lime
        Me.SkyDarkButton5.Location = New System.Drawing.Point(332, 383)
        Me.SkyDarkButton5.Name = "SkyDarkButton5"
        Me.SkyDarkButton5.Size = New System.Drawing.Size(112, 23)
        Me.SkyDarkButton5.TabIndex = 46
        Me.SkyDarkButton5.Text = "Browse For Image"
        '
        'SkyDarkSeperator2
        '
        Me.SkyDarkSeperator2.Align = X_Theme.SkyDarkSeperator.Alignment.Vertical
        Me.SkyDarkSeperator2.Location = New System.Drawing.Point(277, 22)
        Me.SkyDarkSeperator2.Name = "SkyDarkSeperator2"
        Me.SkyDarkSeperator2.Size = New System.Drawing.Size(75, 472)
        Me.SkyDarkSeperator2.TabIndex = 47
        Me.SkyDarkSeperator2.Text = "SkyDarkSeperator2"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Clipboardmanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 410)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clipboardmanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clipboardmanager"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.SkyDarkForm1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SkyDarkButton2 As X_Theme.SkyDarkButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents SkyDarkButton3 As X_Theme.SkyDarkButton
    Friend WithEvents SkyDarkButton5 As X_Theme.SkyDarkButton
    Friend WithEvents SkyDarkButton4 As X_Theme.SkyDarkButton
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SkyDarkSeperator2 As X_Theme.SkyDarkSeperator
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
