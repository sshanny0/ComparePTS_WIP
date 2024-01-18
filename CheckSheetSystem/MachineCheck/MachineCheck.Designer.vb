<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachineCheck
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
        Me.DG_CHECK = New System.Windows.Forms.DataGridView()
        Me.C_MACHINE_NAME = New System.Windows.Forms.ComboBox()
        Me.T_MACHINE_CD = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.T_LINE_NAME = New System.Windows.Forms.TextBox()
        Me.T_LINE_CD = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.B_SEARCH = New System.Windows.Forms.Button()
        Me.B_SUBMIT = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.B_REFRESH = New System.Windows.Forms.Button()
        CType(Me.DG_CHECK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_CHECK
        '
        Me.DG_CHECK.AllowUserToAddRows = False
        Me.DG_CHECK.AllowUserToDeleteRows = False
        Me.DG_CHECK.AllowUserToOrderColumns = True
        Me.DG_CHECK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_CHECK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_CHECK.Location = New System.Drawing.Point(12, 211)
        Me.DG_CHECK.Name = "DG_CHECK"
        Me.DG_CHECK.RowHeadersWidth = 51
        Me.DG_CHECK.RowTemplate.Height = 24
        Me.DG_CHECK.Size = New System.Drawing.Size(996, 266)
        Me.DG_CHECK.TabIndex = 0
        '
        'C_MACHINE_NAME
        '
        Me.C_MACHINE_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_MACHINE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_MACHINE_NAME.FormattingEnabled = True
        Me.C_MACHINE_NAME.Location = New System.Drawing.Point(194, 105)
        Me.C_MACHINE_NAME.Name = "C_MACHINE_NAME"
        Me.C_MACHINE_NAME.Size = New System.Drawing.Size(233, 33)
        Me.C_MACHINE_NAME.TabIndex = 19
        '
        'T_MACHINE_CD
        '
        Me.T_MACHINE_CD.BackColor = System.Drawing.Color.DarkKhaki
        Me.T_MACHINE_CD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_MACHINE_CD.Location = New System.Drawing.Point(433, 105)
        Me.T_MACHINE_CD.Name = "T_MACHINE_CD"
        Me.T_MACHINE_CD.ReadOnly = True
        Me.T_MACHINE_CD.Size = New System.Drawing.Size(304, 30)
        Me.T_MACHINE_CD.TabIndex = 18
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(12, 105)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(176, 30)
        Me.TextBox3.TabIndex = 17
        Me.TextBox3.Text = "MACHINE NAME"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_LINE_NAME
        '
        Me.T_LINE_NAME.BackColor = System.Drawing.Color.DarkKhaki
        Me.T_LINE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_LINE_NAME.Location = New System.Drawing.Point(366, 67)
        Me.T_LINE_NAME.Name = "T_LINE_NAME"
        Me.T_LINE_NAME.ReadOnly = True
        Me.T_LINE_NAME.Size = New System.Drawing.Size(371, 30)
        Me.T_LINE_NAME.TabIndex = 16
        '
        'T_LINE_CD
        '
        Me.T_LINE_CD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_LINE_CD.Location = New System.Drawing.Point(156, 67)
        Me.T_LINE_CD.Name = "T_LINE_CD"
        Me.T_LINE_CD.Size = New System.Drawing.Size(204, 30)
        Me.T_LINE_CD.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(12, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(138, 30)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Text = "LINE"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_SEARCH
        '
        Me.B_SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_SEARCH.Location = New System.Drawing.Point(758, 155)
        Me.B_SEARCH.Name = "B_SEARCH"
        Me.B_SEARCH.Size = New System.Drawing.Size(116, 36)
        Me.B_SEARCH.TabIndex = 20
        Me.B_SEARCH.Text = "SEARCH"
        Me.B_SEARCH.UseVisualStyleBackColor = True
        '
        'B_SUBMIT
        '
        Me.B_SUBMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_SUBMIT.Location = New System.Drawing.Point(892, 155)
        Me.B_SUBMIT.Name = "B_SUBMIT"
        Me.B_SUBMIT.Size = New System.Drawing.Size(116, 36)
        Me.B_SUBMIT.TabIndex = 21
        Me.B_SUBMIT.Text = "SUBMIT"
        Me.B_SUBMIT.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1023, 45)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = "MACHINE CHECK"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_REFRESH
        '
        Me.B_REFRESH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_REFRESH.Location = New System.Drawing.Point(605, 155)
        Me.B_REFRESH.Name = "B_REFRESH"
        Me.B_REFRESH.Size = New System.Drawing.Size(132, 36)
        Me.B_REFRESH.TabIndex = 23
        Me.B_REFRESH.Text = "REFRESH"
        Me.B_REFRESH.UseVisualStyleBackColor = True
        '
        'MachineCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1020, 489)
        Me.Controls.Add(Me.B_REFRESH)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.B_SUBMIT)
        Me.Controls.Add(Me.B_SEARCH)
        Me.Controls.Add(Me.C_MACHINE_NAME)
        Me.Controls.Add(Me.T_MACHINE_CD)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.T_LINE_NAME)
        Me.Controls.Add(Me.T_LINE_CD)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DG_CHECK)
        Me.Name = "MachineCheck"
        Me.Text = "MachineCheck"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_CHECK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DG_CHECK As DataGridView
    Friend WithEvents C_MACHINE_NAME As ComboBox
    Friend WithEvents T_MACHINE_CD As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents T_LINE_NAME As TextBox
    Friend WithEvents T_LINE_CD As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents B_SEARCH As Button
    Friend WithEvents B_SUBMIT As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents B_REFRESH As Button
End Class
