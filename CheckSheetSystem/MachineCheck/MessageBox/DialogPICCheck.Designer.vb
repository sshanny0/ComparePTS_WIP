<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogPICCheck
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
        Me.T_RFID = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.B_SUBMIT_OK = New System.Windows.Forms.Button()
        Me.T_PIC_NIK = New System.Windows.Forms.TextBox()
        Me.B_CANCEL = New System.Windows.Forms.Button()
        Me.DG_HIS_CHECK = New System.Windows.Forms.DataGridView()
        CType(Me.DG_HIS_CHECK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(908, 44)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "APPROVAL"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_RFID
        '
        Me.T_RFID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_RFID.Location = New System.Drawing.Point(182, 72)
        Me.T_RFID.Name = "T_RFID"
        Me.T_RFID.Size = New System.Drawing.Size(688, 30)
        Me.T_RFID.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(22, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(138, 30)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "PIC RF ID"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_SUBMIT_OK
        '
        Me.B_SUBMIT_OK.BackColor = System.Drawing.Color.MidnightBlue
        Me.B_SUBMIT_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_SUBMIT_OK.ForeColor = System.Drawing.Color.White
        Me.B_SUBMIT_OK.Location = New System.Drawing.Point(516, 121)
        Me.B_SUBMIT_OK.Name = "B_SUBMIT_OK"
        Me.B_SUBMIT_OK.Size = New System.Drawing.Size(169, 45)
        Me.B_SUBMIT_OK.TabIndex = 5
        Me.B_SUBMIT_OK.Text = "APPROVE"
        Me.B_SUBMIT_OK.UseVisualStyleBackColor = False
        '
        'T_PIC_NIK
        '
        Me.T_PIC_NIK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_PIC_NIK.Location = New System.Drawing.Point(36, 121)
        Me.T_PIC_NIK.Name = "T_PIC_NIK"
        Me.T_PIC_NIK.Size = New System.Drawing.Size(124, 30)
        Me.T_PIC_NIK.TabIndex = 7
        Me.T_PIC_NIK.Visible = False
        '
        'B_CANCEL
        '
        Me.B_CANCEL.BackColor = System.Drawing.Color.MidnightBlue
        Me.B_CANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_CANCEL.ForeColor = System.Drawing.Color.White
        Me.B_CANCEL.Location = New System.Drawing.Point(701, 121)
        Me.B_CANCEL.Name = "B_CANCEL"
        Me.B_CANCEL.Size = New System.Drawing.Size(169, 45)
        Me.B_CANCEL.TabIndex = 8
        Me.B_CANCEL.Text = "CANCEL"
        Me.B_CANCEL.UseVisualStyleBackColor = False
        '
        'DG_HIS_CHECK
        '
        Me.DG_HIS_CHECK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_HIS_CHECK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_HIS_CHECK.Location = New System.Drawing.Point(24, 121)
        Me.DG_HIS_CHECK.Name = "DG_HIS_CHECK"
        Me.DG_HIS_CHECK.RowHeadersWidth = 51
        Me.DG_HIS_CHECK.RowTemplate.Height = 24
        Me.DG_HIS_CHECK.Size = New System.Drawing.Size(814, 58)
        Me.DG_HIS_CHECK.TabIndex = 9
        Me.DG_HIS_CHECK.Visible = False
        '
        'DialogPICCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(905, 200)
        Me.Controls.Add(Me.B_CANCEL)
        Me.Controls.Add(Me.T_PIC_NIK)
        Me.Controls.Add(Me.B_SUBMIT_OK)
        Me.Controls.Add(Me.T_RFID)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DG_HIS_CHECK)
        Me.Name = "DialogPICCheck"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DialogPICCheck"
        CType(Me.DG_HIS_CHECK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents T_RFID As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents B_SUBMIT_OK As Button
    Friend WithEvents T_PIC_NIK As TextBox
    Friend WithEvents B_CANCEL As Button
    Friend WithEvents DG_HIS_CHECK As DataGridView
End Class
