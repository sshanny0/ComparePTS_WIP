<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDailyMaintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDailyMaintenance))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.T_LINE_CD = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.T_LINE_NAME = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.T_MACHINE_CD = New System.Windows.Forms.TextBox()
        Me.C_MACHINE_NAME = New System.Windows.Forms.ComboBox()
        Me.P_ITEM = New System.Windows.Forms.Panel()
        Me.B_BACK = New System.Windows.Forms.Button()
        Me.B_CLEAR = New System.Windows.Forms.Button()
        Me.C_METHOD_CHECK = New System.Windows.Forms.ComboBox()
        Me.T_PIC_NIK = New System.Windows.Forms.TextBox()
        Me.T_METHOD_UNIT = New System.Windows.Forms.TextBox()
        Me.L_REMARK = New System.Windows.Forms.TextBox()
        Me.T_REMARK = New System.Windows.Forms.TextBox()
        Me.T_METHOD_TO = New System.Windows.Forms.TextBox()
        Me.T_METHOD_FROM = New System.Windows.Forms.TextBox()
        Me.T_METHOD_NAME = New System.Windows.Forms.TextBox()
        Me.B_CHECK = New System.Windows.Forms.Button()
        Me.T_METHOD_CHECK = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.C_UNIT_NAME = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.C_PART_NAME = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.T_JUDUL_ITEM = New System.Windows.Forms.TextBox()
        Me.P_ITEM.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(1, -1)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(747, 40)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "DAILY MAINTENANCE"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_LINE_CD
        '
        Me.T_LINE_CD.Location = New System.Drawing.Point(156, 63)
        Me.T_LINE_CD.Name = "T_LINE_CD"
        Me.T_LINE_CD.Size = New System.Drawing.Size(204, 30)
        Me.T_LINE_CD.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(12, 63)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(138, 30)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Text = "LINE"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_LINE_NAME
        '
        Me.T_LINE_NAME.BackColor = System.Drawing.Color.DarkKhaki
        Me.T_LINE_NAME.Location = New System.Drawing.Point(366, 63)
        Me.T_LINE_NAME.Name = "T_LINE_NAME"
        Me.T_LINE_NAME.ReadOnly = True
        Me.T_LINE_NAME.Size = New System.Drawing.Size(371, 30)
        Me.T_LINE_NAME.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(12, 101)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(176, 30)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "MACHINE NAME"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_MACHINE_CD
        '
        Me.T_MACHINE_CD.BackColor = System.Drawing.Color.DarkKhaki
        Me.T_MACHINE_CD.Location = New System.Drawing.Point(433, 101)
        Me.T_MACHINE_CD.Name = "T_MACHINE_CD"
        Me.T_MACHINE_CD.ReadOnly = True
        Me.T_MACHINE_CD.Size = New System.Drawing.Size(304, 30)
        Me.T_MACHINE_CD.TabIndex = 12
        '
        'C_MACHINE_NAME
        '
        Me.C_MACHINE_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_MACHINE_NAME.FormattingEnabled = True
        Me.C_MACHINE_NAME.Location = New System.Drawing.Point(194, 101)
        Me.C_MACHINE_NAME.Name = "C_MACHINE_NAME"
        Me.C_MACHINE_NAME.Size = New System.Drawing.Size(233, 33)
        Me.C_MACHINE_NAME.TabIndex = 13
        '
        'P_ITEM
        '
        Me.P_ITEM.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P_ITEM.BackColor = System.Drawing.Color.PowderBlue
        Me.P_ITEM.Controls.Add(Me.B_BACK)
        Me.P_ITEM.Controls.Add(Me.B_CLEAR)
        Me.P_ITEM.Controls.Add(Me.C_METHOD_CHECK)
        Me.P_ITEM.Controls.Add(Me.T_PIC_NIK)
        Me.P_ITEM.Controls.Add(Me.T_METHOD_UNIT)
        Me.P_ITEM.Controls.Add(Me.L_REMARK)
        Me.P_ITEM.Controls.Add(Me.T_REMARK)
        Me.P_ITEM.Controls.Add(Me.T_METHOD_TO)
        Me.P_ITEM.Controls.Add(Me.T_METHOD_FROM)
        Me.P_ITEM.Controls.Add(Me.T_METHOD_NAME)
        Me.P_ITEM.Controls.Add(Me.B_CHECK)
        Me.P_ITEM.Controls.Add(Me.T_METHOD_CHECK)
        Me.P_ITEM.Controls.Add(Me.TextBox8)
        Me.P_ITEM.Controls.Add(Me.TextBox6)
        Me.P_ITEM.Controls.Add(Me.C_UNIT_NAME)
        Me.P_ITEM.Controls.Add(Me.TextBox7)
        Me.P_ITEM.Controls.Add(Me.TextBox5)
        Me.P_ITEM.Controls.Add(Me.C_PART_NAME)
        Me.P_ITEM.Controls.Add(Me.TextBox4)
        Me.P_ITEM.Controls.Add(Me.T_JUDUL_ITEM)
        Me.P_ITEM.Location = New System.Drawing.Point(12, 151)
        Me.P_ITEM.Name = "P_ITEM"
        Me.P_ITEM.Size = New System.Drawing.Size(725, 354)
        Me.P_ITEM.TabIndex = 14
        '
        'B_BACK
        '
        Me.B_BACK.Location = New System.Drawing.Point(394, 306)
        Me.B_BACK.Name = "B_BACK"
        Me.B_BACK.Size = New System.Drawing.Size(93, 35)
        Me.B_BACK.TabIndex = 29
        Me.B_BACK.Text = "BACK"
        Me.B_BACK.UseVisualStyleBackColor = True
        '
        'B_CLEAR
        '
        Me.B_CLEAR.Location = New System.Drawing.Point(505, 306)
        Me.B_CLEAR.Name = "B_CLEAR"
        Me.B_CLEAR.Size = New System.Drawing.Size(93, 35)
        Me.B_CLEAR.TabIndex = 28
        Me.B_CLEAR.Text = "CLEAR"
        Me.B_CLEAR.UseVisualStyleBackColor = True
        '
        'C_METHOD_CHECK
        '
        Me.C_METHOD_CHECK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_METHOD_CHECK.FormattingEnabled = True
        Me.C_METHOD_CHECK.Items.AddRange(New Object() {"", "OK", "NOT OK"})
        Me.C_METHOD_CHECK.Location = New System.Drawing.Point(246, 223)
        Me.C_METHOD_CHECK.Name = "C_METHOD_CHECK"
        Me.C_METHOD_CHECK.Size = New System.Drawing.Size(462, 33)
        Me.C_METHOD_CHECK.TabIndex = 15
        '
        'T_PIC_NIK
        '
        Me.T_PIC_NIK.Location = New System.Drawing.Point(12, 311)
        Me.T_PIC_NIK.Name = "T_PIC_NIK"
        Me.T_PIC_NIK.Size = New System.Drawing.Size(100, 30)
        Me.T_PIC_NIK.TabIndex = 27
        Me.T_PIC_NIK.Visible = False
        '
        'T_METHOD_UNIT
        '
        Me.T_METHOD_UNIT.BackColor = System.Drawing.SystemColors.ControlLight
        Me.T_METHOD_UNIT.Location = New System.Drawing.Point(505, 124)
        Me.T_METHOD_UNIT.Name = "T_METHOD_UNIT"
        Me.T_METHOD_UNIT.ReadOnly = True
        Me.T_METHOD_UNIT.Size = New System.Drawing.Size(109, 30)
        Me.T_METHOD_UNIT.TabIndex = 26
        Me.T_METHOD_UNIT.Visible = False
        '
        'L_REMARK
        '
        Me.L_REMARK.BackColor = System.Drawing.Color.RoyalBlue
        Me.L_REMARK.ForeColor = System.Drawing.Color.White
        Me.L_REMARK.Location = New System.Drawing.Point(12, 267)
        Me.L_REMARK.Name = "L_REMARK"
        Me.L_REMARK.ReadOnly = True
        Me.L_REMARK.Size = New System.Drawing.Size(126, 30)
        Me.L_REMARK.TabIndex = 25
        Me.L_REMARK.Text = "REMARK"
        Me.L_REMARK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.L_REMARK.Visible = False
        '
        'T_REMARK
        '
        Me.T_REMARK.Location = New System.Drawing.Point(144, 267)
        Me.T_REMARK.Name = "T_REMARK"
        Me.T_REMARK.Size = New System.Drawing.Size(564, 30)
        Me.T_REMARK.TabIndex = 24
        Me.T_REMARK.Visible = False
        '
        'T_METHOD_TO
        '
        Me.T_METHOD_TO.BackColor = System.Drawing.SystemColors.ControlLight
        Me.T_METHOD_TO.Location = New System.Drawing.Point(378, 124)
        Me.T_METHOD_TO.Name = "T_METHOD_TO"
        Me.T_METHOD_TO.ReadOnly = True
        Me.T_METHOD_TO.Size = New System.Drawing.Size(109, 30)
        Me.T_METHOD_TO.TabIndex = 23
        Me.T_METHOD_TO.Visible = False
        '
        'T_METHOD_FROM
        '
        Me.T_METHOD_FROM.BackColor = System.Drawing.SystemColors.ControlLight
        Me.T_METHOD_FROM.Location = New System.Drawing.Point(246, 124)
        Me.T_METHOD_FROM.Name = "T_METHOD_FROM"
        Me.T_METHOD_FROM.ReadOnly = True
        Me.T_METHOD_FROM.Size = New System.Drawing.Size(109, 30)
        Me.T_METHOD_FROM.TabIndex = 22
        Me.T_METHOD_FROM.Visible = False
        '
        'T_METHOD_NAME
        '
        Me.T_METHOD_NAME.BackColor = System.Drawing.SystemColors.ControlLight
        Me.T_METHOD_NAME.Location = New System.Drawing.Point(246, 124)
        Me.T_METHOD_NAME.Name = "T_METHOD_NAME"
        Me.T_METHOD_NAME.ReadOnly = True
        Me.T_METHOD_NAME.Size = New System.Drawing.Size(462, 30)
        Me.T_METHOD_NAME.TabIndex = 15
        '
        'B_CHECK
        '
        Me.B_CHECK.Location = New System.Drawing.Point(615, 306)
        Me.B_CHECK.Name = "B_CHECK"
        Me.B_CHECK.Size = New System.Drawing.Size(93, 35)
        Me.B_CHECK.TabIndex = 21
        Me.B_CHECK.Text = "CHECK"
        Me.B_CHECK.UseVisualStyleBackColor = True
        '
        'T_METHOD_CHECK
        '
        Me.T_METHOD_CHECK.Location = New System.Drawing.Point(246, 223)
        Me.T_METHOD_CHECK.Name = "T_METHOD_CHECK"
        Me.T_METHOD_CHECK.Size = New System.Drawing.Size(462, 30)
        Me.T_METHOD_CHECK.TabIndex = 15
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox8.ForeColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(12, 223)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(228, 30)
        Me.TextBox8.TabIndex = 20
        Me.TextBox8.Text = "METHOD TO CHECK"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.BackColor = System.Drawing.Color.SteelBlue
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(1, 176)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(725, 30)
        Me.TextBox6.TabIndex = 19
        Me.TextBox6.Text = "DAILY CHECK "
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C_UNIT_NAME
        '
        Me.C_UNIT_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_UNIT_NAME.FormattingEnabled = True
        Me.C_UNIT_NAME.Location = New System.Drawing.Point(246, 46)
        Me.C_UNIT_NAME.Name = "C_UNIT_NAME"
        Me.C_UNIT_NAME.Size = New System.Drawing.Size(462, 33)
        Me.C_UNIT_NAME.TabIndex = 18
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox7.ForeColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(12, 46)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(228, 30)
        Me.TextBox7.TabIndex = 15
        Me.TextBox7.Text = "UNIT"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(12, 124)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(228, 30)
        Me.TextBox5.TabIndex = 16
        Me.TextBox5.Text = "METHOD RANK"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C_PART_NAME
        '
        Me.C_PART_NAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_PART_NAME.FormattingEnabled = True
        Me.C_PART_NAME.Location = New System.Drawing.Point(246, 85)
        Me.C_PART_NAME.Name = "C_PART_NAME"
        Me.C_PART_NAME.Size = New System.Drawing.Size(462, 33)
        Me.C_PART_NAME.TabIndex = 15
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(12, 85)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(228, 30)
        Me.TextBox4.TabIndex = 14
        Me.TextBox4.Text = "PART NAME"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_JUDUL_ITEM
        '
        Me.T_JUDUL_ITEM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T_JUDUL_ITEM.BackColor = System.Drawing.Color.SteelBlue
        Me.T_JUDUL_ITEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.T_JUDUL_ITEM.ForeColor = System.Drawing.Color.White
        Me.T_JUDUL_ITEM.Location = New System.Drawing.Point(0, 0)
        Me.T_JUDUL_ITEM.Margin = New System.Windows.Forms.Padding(4)
        Me.T_JUDUL_ITEM.Multiline = True
        Me.T_JUDUL_ITEM.Name = "T_JUDUL_ITEM"
        Me.T_JUDUL_ITEM.ReadOnly = True
        Me.T_JUDUL_ITEM.Size = New System.Drawing.Size(725, 30)
        Me.T_JUDUL_ITEM.TabIndex = 8
        Me.T_JUDUL_ITEM.Text = "ITEM CASE"
        Me.T_JUDUL_ITEM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MainDailyMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(747, 522)
        Me.Controls.Add(Me.P_ITEM)
        Me.Controls.Add(Me.C_MACHINE_NAME)
        Me.Controls.Add(Me.T_MACHINE_CD)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.T_LINE_NAME)
        Me.Controls.Add(Me.T_LINE_CD)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainDailyMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PT KATOLEC INDONESIA"
        Me.P_ITEM.ResumeLayout(False)
        Me.P_ITEM.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents T_LINE_CD As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents T_LINE_NAME As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents T_MACHINE_CD As TextBox
    Friend WithEvents C_MACHINE_NAME As ComboBox
    Friend WithEvents P_ITEM As Panel
    Friend WithEvents T_JUDUL_ITEM As TextBox
    Friend WithEvents C_PART_NAME As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents C_UNIT_NAME As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents B_CHECK As Button
    Friend WithEvents T_METHOD_CHECK As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents T_METHOD_NAME As TextBox
    Friend WithEvents T_METHOD_TO As TextBox
    Friend WithEvents T_METHOD_FROM As TextBox
    Friend WithEvents T_REMARK As TextBox
    Friend WithEvents L_REMARK As TextBox
    Friend WithEvents T_METHOD_UNIT As TextBox
    Friend WithEvents T_PIC_NIK As TextBox
    Friend WithEvents C_METHOD_CHECK As ComboBox
    Friend WithEvents B_CLEAR As Button
    Friend WithEvents B_BACK As Button
End Class
