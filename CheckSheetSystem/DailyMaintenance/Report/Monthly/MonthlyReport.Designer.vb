<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthlyReport
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
        Me.DT_MONTH = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.T_LINE_NAME = New System.Windows.Forms.TextBox()
        Me.B_SUBMIT = New System.Windows.Forms.Button()
        Me.T_LINE_CD = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.R_MONTHLY = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.B_BACK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, -4)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1141, 48)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.Text = "MONTHLY MACHINE MAINTENANCE REPORT"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DT_MONTH
        '
        Me.DT_MONTH.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_MONTH.CustomFormat = "yyyy-MM"
        Me.DT_MONTH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_MONTH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DT_MONTH.Location = New System.Drawing.Point(156, 116)
        Me.DT_MONTH.Name = "DT_MONTH"
        Me.DT_MONTH.Size = New System.Drawing.Size(204, 30)
        Me.DT_MONTH.TabIndex = 28
        Me.DT_MONTH.Value = New Date(2023, 12, 1, 0, 0, 0, 0)
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(12, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(138, 30)
        Me.TextBox3.TabIndex = 27
        Me.TextBox3.Text = "MONTH"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_LINE_NAME
        '
        Me.T_LINE_NAME.BackColor = System.Drawing.Color.DarkKhaki
        Me.T_LINE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_LINE_NAME.Location = New System.Drawing.Point(366, 71)
        Me.T_LINE_NAME.Name = "T_LINE_NAME"
        Me.T_LINE_NAME.ReadOnly = True
        Me.T_LINE_NAME.Size = New System.Drawing.Size(371, 30)
        Me.T_LINE_NAME.TabIndex = 26
        '
        'B_SUBMIT
        '
        Me.B_SUBMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_SUBMIT.Location = New System.Drawing.Point(833, 69)
        Me.B_SUBMIT.Name = "B_SUBMIT"
        Me.B_SUBMIT.Size = New System.Drawing.Size(137, 35)
        Me.B_SUBMIT.TabIndex = 25
        Me.B_SUBMIT.Text = "SUBMIT"
        Me.B_SUBMIT.UseVisualStyleBackColor = True
        '
        'T_LINE_CD
        '
        Me.T_LINE_CD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_LINE_CD.Location = New System.Drawing.Point(156, 71)
        Me.T_LINE_CD.Name = "T_LINE_CD"
        Me.T_LINE_CD.Size = New System.Drawing.Size(204, 30)
        Me.T_LINE_CD.TabIndex = 24
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(12, 71)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(138, 30)
        Me.TextBox2.TabIndex = 23
        Me.TextBox2.Text = "LINE"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_MONTHLY
        '
        Me.R_MONTHLY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.R_MONTHLY.Location = New System.Drawing.Point(12, 204)
        Me.R_MONTHLY.Name = "R_MONTHLY"
        Me.R_MONTHLY.ServerReport.BearerToken = Nothing
        Me.R_MONTHLY.Size = New System.Drawing.Size(1114, 280)
        Me.R_MONTHLY.TabIndex = 22
        '
        'B_BACK
        '
        Me.B_BACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_BACK.Location = New System.Drawing.Point(990, 69)
        Me.B_BACK.Name = "B_BACK"
        Me.B_BACK.Size = New System.Drawing.Size(137, 35)
        Me.B_BACK.TabIndex = 29
        Me.B_BACK.Text = "BACK"
        Me.B_BACK.UseVisualStyleBackColor = True
        '
        'MonthlyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1140, 501)
        Me.Controls.Add(Me.B_BACK)
        Me.Controls.Add(Me.DT_MONTH)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.T_LINE_NAME)
        Me.Controls.Add(Me.B_SUBMIT)
        Me.Controls.Add(Me.T_LINE_CD)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.R_MONTHLY)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "MonthlyReport"
        Me.Text = "MonthlyReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DT_MONTH As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents T_LINE_NAME As TextBox
    Friend WithEvents B_SUBMIT As Button
    Friend WithEvents T_LINE_CD As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents R_MONTHLY As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents B_BACK As Button
End Class
