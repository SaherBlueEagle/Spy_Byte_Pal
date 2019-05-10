<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lan))
        Me.SkyDarkForm1 = New X_Theme.SkyDarkForm()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshLansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenPortScannerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HackThisComputerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMG = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkyDarkForm1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.ListView2)
        Me.SkyDarkForm1.Controls.Add(Me.ListView1)
        Me.SkyDarkForm1.Controls.Add(Me.Label2)
        Me.SkyDarkForm1.Controls.Add(Me.Label1)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(556, 453)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Lan Network Manager "
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.ListView2.ForeColor = System.Drawing.Color.Lime
        Me.ListView2.LargeImageList = Me.ImageList2
        Me.ListView2.Location = New System.Drawing.Point(362, 24)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(191, 391)
        Me.ListView2.SmallImageList = Me.ImageList2
        Me.ListView2.TabIndex = 28
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Port Scanner Results"
        Me.ColumnHeader2.Width = 186
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ImageList2.Images.SetKeyName(0, "151.png")
        Me.ImageList2.Images.SetKeyName(1, "152.png")
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.LargeImageList = Me.IMG
        Me.ListView1.Location = New System.Drawing.Point(4, 24)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(357, 391)
        Me.ListView1.SmallImageList = Me.IMG
        Me.ListView1.TabIndex = 26
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Computer Name"
        Me.ColumnHeader1.Width = 307
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshLansToolStripMenuItem, Me.OpenPortScannerToolStripMenuItem, Me.HackThisComputerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(241, 70)
        '
        'RefreshLansToolStripMenuItem
        '
        Me.RefreshLansToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.RefreshLansToolStripMenuItem.Image = CType(resources.GetObject("RefreshLansToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshLansToolStripMenuItem.Name = "RefreshLansToolStripMenuItem"
        Me.RefreshLansToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.RefreshLansToolStripMenuItem.Text = "Refresh Lans"
        '
        'OpenPortScannerToolStripMenuItem
        '
        Me.OpenPortScannerToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.OpenPortScannerToolStripMenuItem.Image = CType(resources.GetObject("OpenPortScannerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenPortScannerToolStripMenuItem.Name = "OpenPortScannerToolStripMenuItem"
        Me.OpenPortScannerToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.OpenPortScannerToolStripMenuItem.Text = "Scan For Any open ports"
        '
        'HackThisComputerToolStripMenuItem
        '
        Me.HackThisComputerToolStripMenuItem.BackColor = System.Drawing.Color.DimGray
        Me.HackThisComputerToolStripMenuItem.ForeColor = System.Drawing.Color.Gray
        Me.HackThisComputerToolStripMenuItem.Image = CType(resources.GetObject("HackThisComputerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HackThisComputerToolStripMenuItem.Name = "HackThisComputerToolStripMenuItem"
        Me.HackThisComputerToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.HackThisComputerToolStripMenuItem.Text = "Hack This Computer[Permium]"
        '
        'IMG
        '
        Me.IMG.ImageStream = CType(resources.GetObject("IMG.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IMG.TransparentColor = System.Drawing.Color.Transparent
        Me.IMG.Images.SetKeyName(0, "8.jpg")
        Me.IMG.Images.SetKeyName(1, "xp.png")
        Me.IMG.Images.SetKeyName(2, "PCo.jpg")
        Me.IMG.Images.SetKeyName(3, "linux.png")
        Me.IMG.Images.SetKeyName(4, "PC11.jpg")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(0, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "PC Local IP  :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(0, 431)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 22)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "None Selected Double click"
        '
        'Lan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 453)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lan"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.SkyDarkForm1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshLansToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenPortScannerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HackThisComputerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IMG As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
End Class
