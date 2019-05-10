<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passwords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(passwords))
        Me.SkyDarkForm1 = New X_Theme.SkyDarkForm()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
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
        Me.SkyDarkForm1.Size = New System.Drawing.Size(830, 333)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Password Stealer"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Lime
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(3, 22)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(824, 308)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "URL"
        Me.ColumnHeader1.Width = 359
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User Name "
        Me.ColumnHeader2.Width = 156
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Password"
        Me.ColumnHeader3.Width = 121
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(151, 48)
        '
        'DownloadToolStripMenuItem
        '
        Me.DownloadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DownloadToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.DownloadToolStripMenuItem.Text = "Get Passwords"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "065.png")
        Me.ImageList1.Images.SetKeyName(1, "Chrome.ico")
        Me.ImageList1.Images.SetKeyName(2, "Tatice-Cristal-Intense-Internet-Explorer.ico")
        Me.ImageList1.Images.SetKeyName(3, "Morcha-Browsers-Firefox.ico")
        Me.ImageList1.Images.SetKeyName(4, "QWkgTSP.ico")
        '
        'passwords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 333)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "passwords"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "passwords"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DownloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
