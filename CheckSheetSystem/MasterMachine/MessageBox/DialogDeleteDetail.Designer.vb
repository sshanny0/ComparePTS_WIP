<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogDeleteDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.B_DELETE_UNIT = New System.Windows.Forms.Button()
        Me.B_DELETE_PART = New System.Windows.Forms.Button()
        Me.B_NO_UNIT = New System.Windows.Forms.Button()
        Me.B_YES_UNIT = New System.Windows.Forms.Button()
        Me.TXT_INFO_UNIT = New System.Windows.Forms.TextBox()
        Me.TXT_INFO_PART = New System.Windows.Forms.TextBox()
        Me.B_YES_PART = New System.Windows.Forms.Button()
        Me.B_NO_PART = New System.Windows.Forms.Button()
        Me.TXT_MAIN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, -2)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(757, 39)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "DELETE"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_DELETE_UNIT
        '
        Me.B_DELETE_UNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_DELETE_UNIT.Location = New System.Drawing.Point(12, 246)
        Me.B_DELETE_UNIT.Name = "B_DELETE_UNIT"
        Me.B_DELETE_UNIT.Size = New System.Drawing.Size(164, 40)
        Me.B_DELETE_UNIT.TabIndex = 15
        Me.B_DELETE_UNIT.Text = "DELETE UNIT"
        Me.B_DELETE_UNIT.UseVisualStyleBackColor = True
        '
        'B_DELETE_PART
        '
        Me.B_DELETE_PART.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_DELETE_PART.Location = New System.Drawing.Point(568, 246)
        Me.B_DELETE_PART.Name = "B_DELETE_PART"
        Me.B_DELETE_PART.Size = New System.Drawing.Size(178, 40)
        Me.B_DELETE_PART.TabIndex = 16
        Me.B_DELETE_PART.Text = "DELETE PART"
        Me.B_DELETE_PART.UseVisualStyleBackColor = True
        '
        'B_NO_UNIT
        '
        Me.B_NO_UNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_NO_UNIT.Location = New System.Drawing.Point(431, 178)
        Me.B_NO_UNIT.Name = "B_NO_UNIT"
        Me.B_NO_UNIT.Size = New System.Drawing.Size(65, 33)
        Me.B_NO_UNIT.TabIndex = 18
        Me.B_NO_UNIT.Text = "NO"
        Me.B_NO_UNIT.UseVisualStyleBackColor = True
        '
        'B_YES_UNIT
        '
        Me.B_YES_UNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_YES_UNIT.Location = New System.Drawing.Point(307, 178)
        Me.B_YES_UNIT.Name = "B_YES_UNIT"
        Me.B_YES_UNIT.Size = New System.Drawing.Size(77, 33)
        Me.B_YES_UNIT.TabIndex = 17
        Me.B_YES_UNIT.Text = "YES"
        Me.B_YES_UNIT.UseVisualStyleBackColor = True
        '
        'TXT_INFO_UNIT
        '
        Me.TXT_INFO_UNIT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_INFO_UNIT.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TXT_INFO_UNIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_INFO_UNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_INFO_UNIT.ForeColor = System.Drawing.SystemColors.Window
        Me.TXT_INFO_UNIT.Location = New System.Drawing.Point(12, 51)
        Me.TXT_INFO_UNIT.Multiline = True
        Me.TXT_INFO_UNIT.Name = "TXT_INFO_UNIT"
        Me.TXT_INFO_UNIT.ReadOnly = True
        Me.TXT_INFO_UNIT.Size = New System.Drawing.Size(734, 171)
        Me.TXT_INFO_UNIT.TabIndex = 14
        Me.TXT_INFO_UNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_INFO_PART
        '
        Me.TXT_INFO_PART.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_INFO_PART.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TXT_INFO_PART.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_INFO_PART.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_INFO_PART.ForeColor = System.Drawing.SystemColors.Window
        Me.TXT_INFO_PART.Location = New System.Drawing.Point(12, 51)
        Me.TXT_INFO_PART.Multiline = True
        Me.TXT_INFO_PART.Name = "TXT_INFO_PART"
        Me.TXT_INFO_PART.ReadOnly = True
        Me.TXT_INFO_PART.Size = New System.Drawing.Size(734, 171)
        Me.TXT_INFO_PART.TabIndex = 25
        Me.TXT_INFO_PART.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_YES_PART
        '
        Me.B_YES_PART.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_YES_PART.Location = New System.Drawing.Point(307, 178)
        Me.B_YES_PART.Name = "B_YES_PART"
        Me.B_YES_PART.Size = New System.Drawing.Size(78, 33)
        Me.B_YES_PART.TabIndex = 26
        Me.B_YES_PART.Text = "YES"
        Me.B_YES_PART.UseVisualStyleBackColor = True
        '
        'B_NO_PART
        '
        Me.B_NO_PART.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_NO_PART.Location = New System.Drawing.Point(433, 178)
        Me.B_NO_PART.Name = "B_NO_PART"
        Me.B_NO_PART.Size = New System.Drawing.Size(65, 33)
        Me.B_NO_PART.TabIndex = 27
        Me.B_NO_PART.Text = "NO"
        Me.B_NO_PART.UseVisualStyleBackColor = True
        '
        'TXT_MAIN
        '
        Me.TXT_MAIN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_MAIN.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TXT_MAIN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_MAIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MAIN.ForeColor = System.Drawing.SystemColors.Window
        Me.TXT_MAIN.Location = New System.Drawing.Point(12, 51)
        Me.TXT_MAIN.Multiline = True
        Me.TXT_MAIN.Name = "TXT_MAIN"
        Me.TXT_MAIN.ReadOnly = True
        Me.TXT_MAIN.Size = New System.Drawing.Size(734, 171)
        Me.TXT_MAIN.TabIndex = 28
        Me.TXT_MAIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DialogDeleteDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(758, 297)
        Me.Controls.Add(Me.TXT_MAIN)
        Me.Controls.Add(Me.B_NO_PART)
        Me.Controls.Add(Me.B_YES_PART)
        Me.Controls.Add(Me.TXT_INFO_PART)
        Me.Controls.Add(Me.B_NO_UNIT)
        Me.Controls.Add(Me.B_YES_UNIT)
        Me.Controls.Add(Me.B_DELETE_PART)
        Me.Controls.Add(Me.B_DELETE_UNIT)
        Me.Controls.Add(Me.TXT_INFO_UNIT)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "DialogDeleteDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DialogDeleteDetail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents B_DELETE_UNIT As Button
    Friend WithEvents B_DELETE_PART As Button
    Friend WithEvents B_NO_UNIT As Button
    Friend WithEvents B_YES_UNIT As Button
    Friend WithEvents TXT_INFO_UNIT As TextBox
    Friend WithEvents TXT_INFO_PART As TextBox
    Friend WithEvents B_YES_PART As Button
    Friend WithEvents B_NO_PART As Button
    Friend WithEvents TXT_MAIN As TextBox
End Class
