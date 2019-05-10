<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Processmanager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Processmanager))
        Me.SkyDarkForm1 = New X_Theme.SkyDarkForm()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KillProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResumeProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.SkyDarkForm1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.ListView1)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(476, 508)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Process Manager"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(3, 26)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(468, 477)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 109
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ID"
        Me.ColumnHeader2.Width = 95
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cpu"
        Me.ColumnHeader3.Width = 81
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Active Window"
        Me.ColumnHeader4.Width = 179
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KillProcessToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.RestartProcessToolStripMenuItem, Me.SuspendToolStripMenuItem, Me.ResumeProcessToolStripMenuItem, Me.PropertiesToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(163, 136)
        '
        'KillProcessToolStripMenuItem
        '
        Me.KillProcessToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.KillProcessToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.KillProcessToolStripMenuItem.Image = CType(resources.GetObject("KillProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KillProcessToolStripMenuItem.Name = "KillProcessToolStripMenuItem"
        Me.KillProcessToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.KillProcessToolStripMenuItem.Text = "Kill Process"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RefreshToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh "
        '
        'RestartProcessToolStripMenuItem
        '
        Me.RestartProcessToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RestartProcessToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.RestartProcessToolStripMenuItem.Image = CType(resources.GetObject("RestartProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestartProcessToolStripMenuItem.Name = "RestartProcessToolStripMenuItem"
        Me.RestartProcessToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RestartProcessToolStripMenuItem.Text = "Restart Process"
        '
        'SuspendToolStripMenuItem
        '
        Me.SuspendToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SuspendToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.SuspendToolStripMenuItem.Image = CType(resources.GetObject("SuspendToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SuspendToolStripMenuItem.Name = "SuspendToolStripMenuItem"
        Me.SuspendToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SuspendToolStripMenuItem.Text = "Suspend Process"
        '
        'ResumeProcessToolStripMenuItem
        '
        Me.ResumeProcessToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ResumeProcessToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.ResumeProcessToolStripMenuItem.Image = CType(resources.GetObject("ResumeProcessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResumeProcessToolStripMenuItem.Name = "ResumeProcessToolStripMenuItem"
        Me.ResumeProcessToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ResumeProcessToolStripMenuItem.Text = "Resume Process"
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PropertiesToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.PropertiesToolStripMenuItem.Image = CType(resources.GetObject("PropertiesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "3.png")
        Me.ImageList1.Images.SetKeyName(1, "ace025d517e1e3b04a1098f055d4c2e7-48.png")
        Me.ImageList1.Images.SetKeyName(2, "File-Explorer-icon.png")
        Me.ImageList1.Images.SetKeyName(3, "Google-Chrome-Google-Chrome.ico")
        Me.ImageList1.Images.SetKeyName(4, "notepad.png")
        Me.ImageList1.Images.SetKeyName(5, "54egsd.ico")
        Me.ImageList1.Images.SetKeyName(6, "Firefox.png")
        Me.ImageList1.Images.SetKeyName(7, "Regedit-Logo.png")
        Me.ImageList1.Images.SetKeyName(8, "65664322.png")
        Me.ImageList1.Images.SetKeyName(9, "ffa.png")
        Me.ImageList1.Images.SetKeyName(10, "Icon Entry_9.ico")
        Me.ImageList1.Images.SetKeyName(11, "Icon Entry_14.ico")
        Me.ImageList1.Images.SetKeyName(12, "ffffs.ico")
        Me.ImageList1.Images.SetKeyName(13, "cccs.ico")
        Me.ImageList1.Images.SetKeyName(14, "yhike.ico")
        Me.ImageList1.Images.SetKeyName(15, "Icon Entry_7.ico")
        Me.ImageList1.Images.SetKeyName(16, "Icon Entry_15.ico")
        Me.ImageList1.Images.SetKeyName(17, "1112.ico")
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        '
        'Processmanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 508)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Processmanager"
        Me.Text = "Processmanager"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents KillProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuspendToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumeProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
