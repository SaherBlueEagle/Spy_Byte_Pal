<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Computer_Information
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Computer_Information))
        Me.SkyDarkForm1 = New X_Theme.SkyDarkForm()
        Me.SkyDarkTabControl1 = New X_Theme.SkyDarkTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SkyDarkForm1.SuspendLayout()
        Me.SkyDarkTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.SkyDarkForm1.Size = New System.Drawing.Size(671, 335)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Full Computer Information Manager"
        '
        'SkyDarkTabControl1
        '
        Me.SkyDarkTabControl1.Controls.Add(Me.TabPage1)
        Me.SkyDarkTabControl1.Controls.Add(Me.TabPage2)
        Me.SkyDarkTabControl1.Controls.Add(Me.TabPage3)
        Me.SkyDarkTabControl1.Location = New System.Drawing.Point(3, 26)
        Me.SkyDarkTabControl1.Name = "SkyDarkTabControl1"
        Me.SkyDarkTabControl1.SelectedIndex = 0
        Me.SkyDarkTabControl1.Size = New System.Drawing.Size(665, 309)
        Me.SkyDarkTabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(657, 280)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Computer Information"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(651, 274)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "007.png")
        Me.ImageList1.Images.SetKeyName(1, "Computer 16x16.bmp")
        Me.ImageList1.Images.SetKeyName(2, "shell32_13.ico")
        Me.ImageList1.Images.SetKeyName(3, "shell32_220.ico")
        Me.ImageList1.Images.SetKeyName(4, "IP Address-48.png")
        Me.ImageList1.Images.SetKeyName(5, "Fatcow-Farm-Fresh-Network-adapter.ico")
        Me.ImageList1.Images.SetKeyName(6, "Ncrow-Mega-Pack-2-Windows-Media-Center.ico")
        Me.ImageList1.Images.SetKeyName(7, "Ampeross-Qetto-2-Camera.ico")
        Me.ImageList1.Images.SetKeyName(8, "1484365922_socket.ico")
        Me.ImageList1.Images.SetKeyName(9, "212121.png")
        Me.ImageList1.Images.SetKeyName(10, "1484366155_computer_connection.ico")
        Me.ImageList1.Images.SetKeyName(11, "1484366232_trojan.ico")
        Me.ImageList1.Images.SetKeyName(12, "Tatice-Cristal-Intense-Globe-terrestre-2.ico")
        Me.ImageList1.Images.SetKeyName(13, "1484366656_config-language.ico")
        Me.ImageList1.Images.SetKeyName(14, "1484366699_shield_accept.ico")
        Me.ImageList1.Images.SetKeyName(15, "Iconshock-Real-Vista-Video-Production-Resolution-active.ico")
        Me.ImageList1.Images.SetKeyName(16, "1484366814_document-09.ico")
        Me.ImageList1.Images.SetKeyName(17, "1484366890_preferences-system-time.ico")
        Me.ImageList1.Images.SetKeyName(18, "shell32_5.ico")
        Me.ImageList1.Images.SetKeyName(19, "command_prompt (2).png")
        Me.ImageList1.Images.SetKeyName(20, "Oxygen-Icons.org-Oxygen-Apps-system-software-update.ico")
        Me.ImageList1.Images.SetKeyName(21, "shell32_16811.ico")
        Me.ImageList1.Images.SetKeyName(22, "shell32_230.ico")
        Me.ImageList1.Images.SetKeyName(23, "Treetog-I-Set-Program-Default.ico")
        Me.ImageList1.Images.SetKeyName(24, "Kearone-Platecons-Ram-or-hardware.ico")
        Me.ImageList1.Images.SetKeyName(25, "Everaldo-Kids-Icons-Kcm-processor.ico")
        Me.ImageList1.Images.SetKeyName(26, "Ypf-Transformers-Dev-ram.ico")
        Me.ImageList1.Images.SetKeyName(27, "Oxygen-Icons.org-Oxygen-Devices-computer.ico")
        Me.ImageList1.Images.SetKeyName(28, "Custom-Icon-Design-Pretty-Office-7-Calendar.ico")
        Me.ImageList1.Images.SetKeyName(29, "Fatcow-Farm-Fresh-Bios.ico")
        Me.ImageList1.Images.SetKeyName(30, "Oxygen-Icons.org-Oxygen-Actions-system-search.ico")
        Me.ImageList1.Images.SetKeyName(31, "software-development-icon_309326.png")
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.ListView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(657, 280)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User Information"
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.ForeColor = System.Drawing.Color.Lime
        Me.ListView2.LargeImageList = Me.ImageList1
        Me.ListView2.Location = New System.Drawing.Point(3, 3)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(651, 274)
        Me.ListView2.SmallImageList = Me.ImageList1
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.List
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.ListView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(657, 280)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "[Extra] Hardware Information"
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ListView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView3.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.ForeColor = System.Drawing.Color.Lime
        Me.ListView3.LargeImageList = Me.ImageList1
        Me.ListView3.Location = New System.Drawing.Point(3, 3)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(651, 274)
        Me.ListView3.SmallImageList = Me.ImageList1
        Me.ListView3.TabIndex = 1
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.List
        '
        'SaveFileDialog1
        '
        '
        'Computer_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 335)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Computer_Information"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer_Information"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.SkyDarkTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents SkyDarkTabControl1 As X_Theme.SkyDarkTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
