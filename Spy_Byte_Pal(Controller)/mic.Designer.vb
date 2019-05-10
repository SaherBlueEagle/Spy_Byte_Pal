<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mic))
        Me.SkyDarkForm1 = New X_Theme.SkyDarkForm()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SkyDarkButton2 = New X_Theme.SkyDarkButton()
        Me.SkyDarkButton1 = New X_Theme.SkyDarkButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkyDarkForm1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.Label1)
        Me.SkyDarkForm1.Controls.Add(Me.PictureBox1)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton2)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton1)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(215, 98)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "MicroPhone"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'SkyDarkButton2
        '
        Me.SkyDarkButton2.Location = New System.Drawing.Point(41, 54)
        Me.SkyDarkButton2.Name = "SkyDarkButton2"
        Me.SkyDarkButton2.Size = New System.Drawing.Size(152, 23)
        Me.SkyDarkButton2.TabIndex = 5
        Me.SkyDarkButton2.Text = "Stop Recording"
        '
        'SkyDarkButton1
        '
        Me.SkyDarkButton1.Location = New System.Drawing.Point(40, 25)
        Me.SkyDarkButton1.Name = "SkyDarkButton1"
        Me.SkyDarkButton1.Size = New System.Drawing.Size(152, 23)
        Me.SkyDarkButton1.TabIndex = 2
        Me.SkyDarkButton1.Text = "Start Recording"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(61, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "00:00:00:000"
        '
        'mic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(215, 98)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mic"
        Me.Text = "mic"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.SkyDarkForm1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents SkyDarkButton2 As X_Theme.SkyDarkButton
    Friend WithEvents SkyDarkButton1 As X_Theme.SkyDarkButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
