<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogUpdateReason
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
        Me.T_REMARK = New System.Windows.Forms.TextBox()
        Me.L_PART_1 = New System.Windows.Forms.TextBox()
        Me.B_CANCEL = New System.Windows.Forms.Button()
        Me.B_UPDATE = New System.Windows.Forms.Button()
        Me.DG_HIS_CHECK = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DG_HIS_CHECK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, -1)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1087, 39)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "UPDATE REMARK"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_REMARK
        '
        Me.T_REMARK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_REMARK.Location = New System.Drawing.Point(271, 73)
        Me.T_REMARK.Name = "T_REMARK"
        Me.T_REMARK.Size = New System.Drawing.Size(786, 30)
        Me.T_REMARK.TabIndex = 29
        '
        'L_PART_1
        '
        Me.L_PART_1.BackColor = System.Drawing.Color.RoyalBlue
        Me.L_PART_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_PART_1.ForeColor = System.Drawing.Color.White
        Me.L_PART_1.Location = New System.Drawing.Point(32, 73)
        Me.L_PART_1.Name = "L_PART_1"
        Me.L_PART_1.ReadOnly = True
        Me.L_PART_1.Size = New System.Drawing.Size(225, 30)
        Me.L_PART_1.TabIndex = 28
        Me.L_PART_1.Text = "REMARK"
        Me.L_PART_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_CANCEL
        '
        Me.B_CANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.B_CANCEL.Location = New System.Drawing.Point(947, 119)
        Me.B_CANCEL.Name = "B_CANCEL"
        Me.B_CANCEL.Size = New System.Drawing.Size(110, 39)
        Me.B_CANCEL.TabIndex = 46
        Me.B_CANCEL.Text = "CANCEL"
        Me.B_CANCEL.UseVisualStyleBackColor = True
        '
        'B_UPDATE
        '
        Me.B_UPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.B_UPDATE.Location = New System.Drawing.Point(823, 119)
        Me.B_UPDATE.Name = "B_UPDATE"
        Me.B_UPDATE.Size = New System.Drawing.Size(110, 39)
        Me.B_UPDATE.TabIndex = 45
        Me.B_UPDATE.Text = "UPDATE"
        Me.B_UPDATE.UseVisualStyleBackColor = True
        '
        'DG_HIS_CHECK
        '
        Me.DG_HIS_CHECK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_HIS_CHECK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_HIS_CHECK.Location = New System.Drawing.Point(32, 195)
        Me.DG_HIS_CHECK.Name = "DG_HIS_CHECK"
        Me.DG_HIS_CHECK.RowHeadersWidth = 51
        Me.DG_HIS_CHECK.RowTemplate.Height = 24
        Me.DG_HIS_CHECK.Size = New System.Drawing.Size(1025, 273)
        Me.DG_HIS_CHECK.TabIndex = 47
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(32, 157)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(366, 32)
        Me.TextBox2.TabIndex = 48
        Me.TextBox2.Text = "DAILY HISTORY MACHINE CHECK"
        '
        'DialogUpdateReason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1085, 480)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DG_HIS_CHECK)
        Me.Controls.Add(Me.B_CANCEL)
        Me.Controls.Add(Me.B_UPDATE)
        Me.Controls.Add(Me.T_REMARK)
        Me.Controls.Add(Me.L_PART_1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "DialogUpdateReason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DialogUpdateReason"
        CType(Me.DG_HIS_CHECK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents T_REMARK As TextBox
    Friend WithEvents L_PART_1 As TextBox
    Friend WithEvents B_CANCEL As Button
    Friend WithEvents B_UPDATE As Button
    Friend WithEvents DG_HIS_CHECK As DataGridView
    Friend WithEvents TextBox2 As TextBox
End Class
