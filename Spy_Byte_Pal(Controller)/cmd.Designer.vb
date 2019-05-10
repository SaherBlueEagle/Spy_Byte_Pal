<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cmd
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
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T1 = New System.Windows.Forms.RichTextBox()
        Me.SkyDarkSeperator2 = New X_Theme.SkyDarkSeperator()
        Me.SkyDarkSeperator1 = New X_Theme.SkyDarkSeperator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SkyDarkForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkyDarkForm1
        '
        Me.SkyDarkForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SkyDarkForm1.Controls.Add(Me.Label2)
        Me.SkyDarkForm1.Controls.Add(Me.T2)
        Me.SkyDarkForm1.Controls.Add(Me.Label1)
        Me.SkyDarkForm1.Controls.Add(Me.T1)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkSeperator2)
        Me.SkyDarkForm1.Controls.Add(Me.SkyDarkSeperator1)
        Me.SkyDarkForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SkyDarkForm1.Location = New System.Drawing.Point(0, 0)
        Me.SkyDarkForm1.Name = "SkyDarkForm1"
        Me.SkyDarkForm1.Size = New System.Drawing.Size(776, 473)
        Me.SkyDarkForm1.TabIndex = 0
        Me.SkyDarkForm1.Text = "Command prompt"
        '
        'T2
        '
        Me.T2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.T2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T2.ForeColor = System.Drawing.Color.Lime
        Me.T2.Location = New System.Drawing.Point(8, 427)
        Me.T2.Multiline = True
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(759, 43)
        Me.T2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(548, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "TIP : Type Command below and press enter"
        '
        'T1
        '
        Me.T1.BackColor = System.Drawing.Color.Black
        Me.T1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.T1.Cursor = System.Windows.Forms.Cursors.Default
        Me.T1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T1.ForeColor = System.Drawing.Color.Lime
        Me.T1.Location = New System.Drawing.Point(10, 23)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(757, 381)
        Me.T1.TabIndex = 9
        Me.T1.Text = ""
        '
        'SkyDarkSeperator2
        '
        Me.SkyDarkSeperator2.Align = X_Theme.SkyDarkSeperator.Alignment.Vertical
        Me.SkyDarkSeperator2.Location = New System.Drawing.Point(753, 23)
        Me.SkyDarkSeperator2.Name = "SkyDarkSeperator2"
        Me.SkyDarkSeperator2.Size = New System.Drawing.Size(28, 450)
        Me.SkyDarkSeperator2.TabIndex = 3
        Me.SkyDarkSeperator2.Text = "SkyDarkSeperator2"
        '
        'SkyDarkSeperator1
        '
        Me.SkyDarkSeperator1.Align = X_Theme.SkyDarkSeperator.Alignment.Vertical
        Me.SkyDarkSeperator1.Location = New System.Drawing.Point(-8, 23)
        Me.SkyDarkSeperator1.Name = "SkyDarkSeperator1"
        Me.SkyDarkSeperator1.Size = New System.Drawing.Size(28, 450)
        Me.SkyDarkSeperator1.TabIndex = 2
        Me.SkyDarkSeperator1.Text = "SkyDarkSeperator1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(12, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Command : "
        '
        'cmd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 473)
        Me.Controls.Add(Me.SkyDarkForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cmd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cmd"
        Me.SkyDarkForm1.ResumeLayout(False)
        Me.SkyDarkForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkyDarkForm1 As X_Theme.SkyDarkForm
    Friend WithEvents SkyDarkSeperator2 As X_Theme.SkyDarkSeperator
    Friend WithEvents SkyDarkSeperator1 As X_Theme.SkyDarkSeperator
    Friend WithEvents T1 As System.Windows.Forms.RichTextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
