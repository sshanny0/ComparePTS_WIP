<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogUpdateDetail
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
        Me.T_METHOD = New System.Windows.Forms.TextBox()
        Me.L_METHOD_1 = New System.Windows.Forms.TextBox()
        Me.T_PART = New System.Windows.Forms.TextBox()
        Me.L_PART_1 = New System.Windows.Forms.TextBox()
        Me.B_UPDATE = New System.Windows.Forms.Button()
        Me.B_CANCEL = New System.Windows.Forms.Button()
        Me.L_METHOD_RANGE = New System.Windows.Forms.TextBox()
        Me.L_METHOD_FROM_RANGE = New System.Windows.Forms.TextBox()
        Me.L_METHOD_TO_RANGE = New System.Windows.Forms.TextBox()
        Me.L_METHOD_UNIT_RANGE = New System.Windows.Forms.TextBox()
        Me.T_FROM = New System.Windows.Forms.TextBox()
        Me.T_TO = New System.Windows.Forms.TextBox()
        Me.T_UNIT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(2, -3)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(836, 39)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "UPDATE PART AND METHOD"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_METHOD
        '
        Me.T_METHOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_METHOD.Location = New System.Drawing.Point(254, 112)
        Me.T_METHOD.Name = "T_METHOD"
        Me.T_METHOD.Size = New System.Drawing.Size(562, 28)
        Me.T_METHOD.TabIndex = 29
        '
        'L_METHOD_1
        '
        Me.L_METHOD_1.BackColor = System.Drawing.Color.RoyalBlue
        Me.L_METHOD_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_METHOD_1.ForeColor = System.Drawing.Color.White
        Me.L_METHOD_1.Location = New System.Drawing.Point(15, 112)
        Me.L_METHOD_1.Name = "L_METHOD_1"
        Me.L_METHOD_1.ReadOnly = True
        Me.L_METHOD_1.Size = New System.Drawing.Size(225, 28)
        Me.L_METHOD_1.TabIndex = 28
        Me.L_METHOD_1.Text = "METHOD OF CHECK"
        Me.L_METHOD_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_PART
        '
        Me.T_PART.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_PART.Location = New System.Drawing.Point(254, 52)
        Me.T_PART.Name = "T_PART"
        Me.T_PART.Size = New System.Drawing.Size(562, 28)
        Me.T_PART.TabIndex = 27
        '
        'L_PART_1
        '
        Me.L_PART_1.BackColor = System.Drawing.Color.RoyalBlue
        Me.L_PART_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_PART_1.ForeColor = System.Drawing.Color.White
        Me.L_PART_1.Location = New System.Drawing.Point(15, 52)
        Me.L_PART_1.Name = "L_PART_1"
        Me.L_PART_1.ReadOnly = True
        Me.L_PART_1.Size = New System.Drawing.Size(225, 28)
        Me.L_PART_1.TabIndex = 26
        Me.L_PART_1.Text = "PART FOR CHECK "
        Me.L_PART_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_UPDATE
        '
        Me.B_UPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.B_UPDATE.Location = New System.Drawing.Point(582, 163)
        Me.B_UPDATE.Name = "B_UPDATE"
        Me.B_UPDATE.Size = New System.Drawing.Size(110, 39)
        Me.B_UPDATE.TabIndex = 43
        Me.B_UPDATE.Text = "UPDATE"
        Me.B_UPDATE.UseVisualStyleBackColor = True
        '
        'B_CANCEL
        '
        Me.B_CANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.B_CANCEL.Location = New System.Drawing.Point(706, 163)
        Me.B_CANCEL.Name = "B_CANCEL"
        Me.B_CANCEL.Size = New System.Drawing.Size(110, 39)
        Me.B_CANCEL.TabIndex = 44
        Me.B_CANCEL.Text = "CANCEL"
        Me.B_CANCEL.UseVisualStyleBackColor = True
        '
        'L_METHOD_RANGE
        '
        Me.L_METHOD_RANGE.BackColor = System.Drawing.Color.RoyalBlue
        Me.L_METHOD_RANGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_METHOD_RANGE.ForeColor = System.Drawing.Color.White
        Me.L_METHOD_RANGE.Location = New System.Drawing.Point(15, 112)
        Me.L_METHOD_RANGE.Name = "L_METHOD_RANGE"
        Me.L_METHOD_RANGE.ReadOnly = True
        Me.L_METHOD_RANGE.Size = New System.Drawing.Size(225, 28)
        Me.L_METHOD_RANGE.TabIndex = 45
        Me.L_METHOD_RANGE.Text = "METHOD OF RANGE"
        Me.L_METHOD_RANGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_METHOD_FROM_RANGE
        '
        Me.L_METHOD_FROM_RANGE.BackColor = System.Drawing.Color.RoyalBlue
        Me.L_METHOD_FROM_RANGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_METHOD_FROM_RANGE.ForeColor = System.Drawing.Color.White
        Me.L_METHOD_FROM_RANGE.Location = New System.Drawing.Point(254, 112)
        Me.L_METHOD_FROM_RANGE.Name = "L_METHOD_FROM_RANGE"
        Me.L_METHOD_FROM_RANGE.ReadOnly = True
        Me.L_METHOD_FROM_RANGE.Size = New System.Drawing.Size(85, 28)
        Me.L_METHOD_FROM_RANGE.TabIndex = 46
        Me.L_METHOD_FROM_RANGE.Text = "FROM"
        Me.L_METHOD_FROM_RANGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_METHOD_TO_RANGE
        '
        Me.L_METHOD_TO_RANGE.BackColor = System.Drawing.Color.RoyalBlue
        Me.L_METHOD_TO_RANGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_METHOD_TO_RANGE.ForeColor = System.Drawing.Color.White
        Me.L_METHOD_TO_RANGE.Location = New System.Drawing.Point(464, 112)
        Me.L_METHOD_TO_RANGE.Name = "L_METHOD_TO_RANGE"
        Me.L_METHOD_TO_RANGE.ReadOnly = True
        Me.L_METHOD_TO_RANGE.Size = New System.Drawing.Size(69, 28)
        Me.L_METHOD_TO_RANGE.TabIndex = 47
        Me.L_METHOD_TO_RANGE.Text = "TO"
        Me.L_METHOD_TO_RANGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'L_METHOD_UNIT_RANGE
        '
        Me.L_METHOD_UNIT_RANGE.BackColor = System.Drawing.Color.RoyalBlue
        Me.L_METHOD_UNIT_RANGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_METHOD_UNIT_RANGE.ForeColor = System.Drawing.Color.White
        Me.L_METHOD_UNIT_RANGE.Location = New System.Drawing.Point(659, 112)
        Me.L_METHOD_UNIT_RANGE.Name = "L_METHOD_UNIT_RANGE"
        Me.L_METHOD_UNIT_RANGE.ReadOnly = True
        Me.L_METHOD_UNIT_RANGE.Size = New System.Drawing.Size(69, 28)
        Me.L_METHOD_UNIT_RANGE.TabIndex = 48
        Me.L_METHOD_UNIT_RANGE.Text = "UNIT"
        Me.L_METHOD_UNIT_RANGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_FROM
        '
        Me.T_FROM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_FROM.Location = New System.Drawing.Point(345, 112)
        Me.T_FROM.Name = "T_FROM"
        Me.T_FROM.Size = New System.Drawing.Size(103, 28)
        Me.T_FROM.TabIndex = 49
        '
        'T_TO
        '
        Me.T_TO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_TO.Location = New System.Drawing.Point(539, 112)
        Me.T_TO.Name = "T_TO"
        Me.T_TO.Size = New System.Drawing.Size(103, 28)
        Me.T_TO.TabIndex = 50
        '
        'T_UNIT
        '
        Me.T_UNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_UNIT.Location = New System.Drawing.Point(734, 112)
        Me.T_UNIT.Name = "T_UNIT"
        Me.T_UNIT.Size = New System.Drawing.Size(82, 28)
        Me.T_UNIT.TabIndex = 51
        '
        'DialogUpdateDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(838, 205)
        Me.Controls.Add(Me.T_UNIT)
        Me.Controls.Add(Me.T_TO)
        Me.Controls.Add(Me.T_FROM)
        Me.Controls.Add(Me.L_METHOD_UNIT_RANGE)
        Me.Controls.Add(Me.L_METHOD_TO_RANGE)
        Me.Controls.Add(Me.L_METHOD_FROM_RANGE)
        Me.Controls.Add(Me.L_METHOD_RANGE)
        Me.Controls.Add(Me.B_CANCEL)
        Me.Controls.Add(Me.B_UPDATE)
        Me.Controls.Add(Me.T_METHOD)
        Me.Controls.Add(Me.L_METHOD_1)
        Me.Controls.Add(Me.T_PART)
        Me.Controls.Add(Me.L_PART_1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "DialogUpdateDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DialogUpdateDetail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents T_METHOD As TextBox
    Friend WithEvents L_METHOD_1 As TextBox
    Friend WithEvents T_PART As TextBox
    Friend WithEvents L_PART_1 As TextBox
    Friend WithEvents B_UPDATE As Button
    Friend WithEvents B_CANCEL As Button
    Friend WithEvents L_METHOD_RANGE As TextBox
    Friend WithEvents L_METHOD_FROM_RANGE As TextBox
    Friend WithEvents L_METHOD_TO_RANGE As TextBox
    Friend WithEvents L_METHOD_UNIT_RANGE As TextBox
    Friend WithEvents T_FROM As TextBox
    Friend WithEvents T_TO As TextBox
    Friend WithEvents T_UNIT As TextBox
End Class
