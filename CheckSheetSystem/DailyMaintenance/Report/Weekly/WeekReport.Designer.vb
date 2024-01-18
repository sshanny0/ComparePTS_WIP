<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WeekReport
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
        Me.T_LINE_NAME = New System.Windows.Forms.TextBox()
        Me.B_SUBMIT = New System.Windows.Forms.Button()
        Me.T_LINE_CD = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.R_WEEKLY = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DT_WEEK_FROM = New System.Windows.Forms.DateTimePicker()
        Me.DT_WEEK_TO = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.B_BACK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'T_LINE_NAME
        '
        Me.T_LINE_NAME.BackColor = System.Drawing.Color.DarkKhaki
        Me.T_LINE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_LINE_NAME.Location = New System.Drawing.Point(369, 71)
        Me.T_LINE_NAME.Name = "T_LINE_NAME"
        Me.T_LINE_NAME.ReadOnly = True
        Me.T_LINE_NAME.Size = New System.Drawing.Size(371, 30)
        Me.T_LINE_NAME.TabIndex = 19
        '
        'B_SUBMIT
        '
        Me.B_SUBMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_SUBMIT.Location = New System.Drawing.Point(832, 114)
        Me.B_SUBMIT.Name = "B_SUBMIT"
        Me.B_SUBMIT.Size = New System.Drawing.Size(137, 35)
        Me.B_SUBMIT.TabIndex = 18
        Me.B_SUBMIT.Text = "SUBMIT"
        Me.B_SUBMIT.UseVisualStyleBackColor = True
        '
        'T_LINE_CD
        '
        Me.T_LINE_CD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_LINE_CD.Location = New System.Drawing.Point(159, 71)
        Me.T_LINE_CD.Name = "T_LINE_CD"
        Me.T_LINE_CD.Size = New System.Drawing.Size(204, 30)
        Me.T_LINE_CD.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(15, 71)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(138, 30)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = "LINE"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(2, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1139, 48)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "WEEKLY MACHINE MAINTENANCE REPORT"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_WEEKLY
        '
        Me.R_WEEKLY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.R_WEEKLY.Location = New System.Drawing.Point(15, 203)
        Me.R_WEEKLY.Name = "R_WEEKLY"
        Me.R_WEEKLY.ServerReport.BearerToken = Nothing
        Me.R_WEEKLY.Size = New System.Drawing.Size(1112, 261)
        Me.R_WEEKLY.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(15, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(138, 30)
        Me.TextBox3.TabIndex = 20
        Me.TextBox3.Text = "FROM DATE"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DT_WEEK_FROM
        '
        Me.DT_WEEK_FROM.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_WEEK_FROM.CustomFormat = "yyyy-MM-dd"
        Me.DT_WEEK_FROM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_WEEK_FROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_WEEK_FROM.Location = New System.Drawing.Point(159, 116)
        Me.DT_WEEK_FROM.Name = "DT_WEEK_FROM"
        Me.DT_WEEK_FROM.Size = New System.Drawing.Size(204, 30)
        Me.DT_WEEK_FROM.TabIndex = 21
        Me.DT_WEEK_FROM.Value = New Date(2023, 12, 1, 0, 0, 0, 0)
        '
        'DT_WEEK_TO
        '
        Me.DT_WEEK_TO.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_WEEK_TO.CustomFormat = "yyyy-MM-dd"
        Me.DT_WEEK_TO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_WEEK_TO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_WEEK_TO.Location = New System.Drawing.Point(522, 116)
        Me.DT_WEEK_TO.Name = "DT_WEEK_TO"
        Me.DT_WEEK_TO.Size = New System.Drawing.Size(218, 30)
        Me.DT_WEEK_TO.TabIndex = 23
        Me.DT_WEEK_TO.Value = New Date(2023, 12, 1, 0, 0, 0, 0)
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(378, 116)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(138, 30)
        Me.TextBox4.TabIndex = 22
        Me.TextBox4.Text = "TO DATE"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_BACK
        '
        Me.B_BACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_BACK.Location = New System.Drawing.Point(992, 114)
        Me.B_BACK.Name = "B_BACK"
        Me.B_BACK.Size = New System.Drawing.Size(137, 35)
        Me.B_BACK.TabIndex = 24
        Me.B_BACK.Text = "BACK"
        Me.B_BACK.UseVisualStyleBackColor = True
        '
        'WeekReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1139, 487)
        Me.Controls.Add(Me.B_BACK)
        Me.Controls.Add(Me.DT_WEEK_TO)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.DT_WEEK_FROM)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.T_LINE_NAME)
        Me.Controls.Add(Me.B_SUBMIT)
        Me.Controls.Add(Me.T_LINE_CD)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.R_WEEKLY)
        Me.Name = "WeekReport"
        Me.Text = "WeekReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents T_LINE_NAME As TextBox
    Friend WithEvents B_SUBMIT As Button
    Friend WithEvents T_LINE_CD As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents R_WEEKLY As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DT_WEEK_FROM As DateTimePicker
    Friend WithEvents DT_WEEK_TO As DateTimePicker
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents B_BACK As Button
End Class
