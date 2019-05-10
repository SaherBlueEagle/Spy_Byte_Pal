<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compiler
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
        Me.SkyDarkCombo1 = New X_Theme.SkyDarkCombo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.SkyDarkButton1 = New X_Theme.SkyDarkButton()
        Me.SkyDarkForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton1)
        Me.SkyDarkForm1.Controls.Add(Me.TextBox8)
        Me.SkyDarkForm1.Controls.Add(Me.Label2)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkCombo1)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(809, 499)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Code Compiler"
        '
        'SkyDarkCombo1
        '
        Me.SkyDarkCombo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.SkyDarkCombo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SkyDarkCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SkyDarkCombo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.SkyDarkCombo1.FormattingEnabled = True
        Me.SkyDarkCombo1.Items.AddRange(New Object() {".vbs[VB_Script]", ".bat[Batch_Script]", ".html[HTML_Page]"})
        Me.SkyDarkCombo1.Location = New System.Drawing.Point(4, 50)
        Me.SkyDarkCombo1.Name = "SkyDarkCombo1"
        Me.SkyDarkCombo1.Size = New System.Drawing.Size(184, 21)
        Me.SkyDarkCombo1.StartIndex = 0
        Me.SkyDarkCombo1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(4, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 22)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Type :-"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.Lime
        Me.TextBox8.Location = New System.Drawing.Point(4, 77)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox8.Size = New System.Drawing.Size(802, 389)
        Me.TextBox8.TabIndex = 33
        Me.TextBox8.Text = "MsgBox(""Hello"")"
        Me.TextBox8.WordWrap = False
        '
        'SkyDarkButton1
        '
        Me.SkyDarkButton1.Location = New System.Drawing.Point(731, 472)
        Me.SkyDarkButton1.Name = "SkyDarkButton1"
        Me.SkyDarkButton1.Size = New System.Drawing.Size(75, 23)
        Me.SkyDarkButton1.TabIndex = 34
        Me.SkyDarkButton1.Text = "Run Code"
        '
        'Compiler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 499)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Compiler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compiler"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.SkyDarkForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents SkyDarkCombo1 As X_Theme.SkyDarkCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents SkyDarkButton1 As X_Theme.SkyDarkButton
End Class
