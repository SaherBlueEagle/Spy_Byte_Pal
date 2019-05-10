<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditor
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SkyDarkForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.TextBox1)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton2)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkButton1)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(470, 358)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Text Editor"
        '
        'SkyDarkButton1
        '
        Me.SkyDarkButton1.Location = New System.Drawing.Point(392, 334)
        Me.SkyDarkButton1.Name = "SkyDarkButton1"
        Me.SkyDarkButton1.Size = New System.Drawing.Size(75, 23)
        Me.SkyDarkButton1.TabIndex = 2
        Me.SkyDarkButton1.Text = "Save"
        '
        'SkyDarkButton2
        '
        Me.SkyDarkButton2.Location = New System.Drawing.Point(298, 334)
        Me.SkyDarkButton2.Name = "SkyDarkButton2"
        Me.SkyDarkButton2.Size = New System.Drawing.Size(75, 23)
        Me.SkyDarkButton2.TabIndex = 3
        Me.SkyDarkButton2.Text = "Cancel"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(3, 24)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(464, 304)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.WordWrap = False
        '
        'TextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 358)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TextEditor"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.SkyDarkForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents SkyDarkButton1 As X_Theme.SkyDarkButton
    Friend WithEvents SkyDarkButton2 As X_Theme.SkyDarkButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
