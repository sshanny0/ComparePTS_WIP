<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogUpdateDelete
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.B_UPDATE = New System.Windows.Forms.Button()
        Me.B_DELETE = New System.Windows.Forms.Button()
        Me.B_CANCEL = New System.Windows.Forms.Button()
        Me.TXT_INFO = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(1, -1)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(579, 39)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Text = "INFORMATION"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_UPDATE
        '
        Me.B_UPDATE.Location = New System.Drawing.Point(230, 231)
        Me.B_UPDATE.Name = "B_UPDATE"
        Me.B_UPDATE.Size = New System.Drawing.Size(109, 40)
        Me.B_UPDATE.TabIndex = 10
        Me.B_UPDATE.Text = "UPDATE"
        Me.B_UPDATE.UseVisualStyleBackColor = True
        '
        'B_DELETE
        '
        Me.B_DELETE.Location = New System.Drawing.Point(12, 231)
        Me.B_DELETE.Name = "B_DELETE"
        Me.B_DELETE.Size = New System.Drawing.Size(107, 40)
        Me.B_DELETE.TabIndex = 11
        Me.B_DELETE.Text = "DELETE"
        Me.B_DELETE.UseVisualStyleBackColor = True
        '
        'B_CANCEL
        '
        Me.B_CANCEL.Location = New System.Drawing.Point(458, 231)
        Me.B_CANCEL.Name = "B_CANCEL"
        Me.B_CANCEL.Size = New System.Drawing.Size(110, 40)
        Me.B_CANCEL.TabIndex = 12
        Me.B_CANCEL.Text = "CANCEL"
        Me.B_CANCEL.UseVisualStyleBackColor = True
        '
        'TXT_INFO
        '
        Me.TXT_INFO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_INFO.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TXT_INFO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_INFO.ForeColor = System.Drawing.SystemColors.Window
        Me.TXT_INFO.Location = New System.Drawing.Point(12, 45)
        Me.TXT_INFO.Multiline = True
        Me.TXT_INFO.Name = "TXT_INFO"
        Me.TXT_INFO.ReadOnly = True
        Me.TXT_INFO.Size = New System.Drawing.Size(556, 180)
        Me.TXT_INFO.TabIndex = 13
        Me.TXT_INFO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DialogUpdateDelete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(580, 283)
        Me.Controls.Add(Me.TXT_INFO)
        Me.Controls.Add(Me.B_CANCEL)
        Me.Controls.Add(Me.B_DELETE)
        Me.Controls.Add(Me.B_UPDATE)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogUpdateDelete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents B_UPDATE As Button
    Friend WithEvents B_DELETE As Button
    Friend WithEvents B_CANCEL As Button
    Friend WithEvents TXT_INFO As TextBox
End Class
