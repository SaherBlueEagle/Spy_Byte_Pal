<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Active_Windows
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Active_Windows))
        Me.SkyDarkForm1 = New X_Theme.SkyDarkForm()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KillWindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.SkyDarkForm1.Size = New System.Drawing.Size(530, 341)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Active Windows Manager "
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(3, 26)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(524, 312)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Active Windows"
        Me.ColumnHeader1.Width = 518
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "3.png")
        '
        'Timer3
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KillWindowsToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 48)
        '
        'KillWindowsToolStripMenuItem
        '
        Me.KillWindowsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.KillWindowsToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.KillWindowsToolStripMenuItem.Image = CType(resources.GetObject("KillWindowsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KillWindowsToolStripMenuItem.Name = "KillWindowsToolStripMenuItem"
        Me.KillWindowsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.KillWindowsToolStripMenuItem.Text = "Kill Window"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.RefreshToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh "
        '
        'Active_Windows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 341)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Active_Windows"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Active_Windows"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents KillWindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
