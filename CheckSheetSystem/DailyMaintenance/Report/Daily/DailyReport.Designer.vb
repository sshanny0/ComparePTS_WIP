<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DailyReport
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
        Me.R_DAILY = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.T_LINE_CD = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.B_SUBMIT = New System.Windows.Forms.Button()
        Me.T_LINE_NAME = New System.Windows.Forms.TextBox()
        Me.B_BACK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'R_DAILY
        '
        Me.R_DAILY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.R_DAILY.Location = New System.Drawing.Point(12, 125)
        Me.R_DAILY.Name = "R_DAILY"
        Me.R_DAILY.ServerReport.BearerToken = Nothing
        Me.R_DAILY.Size = New System.Drawing.Size(1115, 242)
        Me.R_DAILY.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, -1)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1140, 48)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "DAILY MACHINE MAINTENANCE REPORT"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_LINE_CD
        '
        Me.T_LINE_CD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_LINE_CD.Location = New System.Drawing.Point(156, 70)
        Me.T_LINE_CD.Name = "T_LINE_CD"
        Me.T_LINE_CD.Size = New System.Drawing.Size(204, 30)
        Me.T_LINE_CD.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(12, 70)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(138, 30)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "LINE"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_SUBMIT
        '
        Me.B_SUBMIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_SUBMIT.Location = New System.Drawing.Point(831, 68)
        Me.B_SUBMIT.Name = "B_SUBMIT"
        Me.B_SUBMIT.Size = New System.Drawing.Size(137, 35)
        Me.B_SUBMIT.TabIndex = 12
        Me.B_SUBMIT.Text = "SUBMIT"
        Me.B_SUBMIT.UseVisualStyleBackColor = True
        '
        'T_LINE_NAME
        '
        Me.T_LINE_NAME.BackColor = System.Drawing.Color.DarkKhaki
        Me.T_LINE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T_LINE_NAME.Location = New System.Drawing.Point(366, 70)
        Me.T_LINE_NAME.Name = "T_LINE_NAME"
        Me.T_LINE_NAME.ReadOnly = True
        Me.T_LINE_NAME.Size = New System.Drawing.Size(371, 30)
        Me.T_LINE_NAME.TabIndex = 13
        '
        'B_BACK
        '
        Me.B_BACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_BACK.Location = New System.Drawing.Point(990, 68)
        Me.B_BACK.Name = "B_BACK"
        Me.B_BACK.Size = New System.Drawing.Size(137, 35)
        Me.B_BACK.TabIndex = 14
        Me.B_BACK.Text = "BACK"
        Me.B_BACK.UseVisualStyleBackColor = True
        '
        'DailyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1139, 395)
        Me.Controls.Add(Me.B_BACK)
        Me.Controls.Add(Me.T_LINE_NAME)
        Me.Controls.Add(Me.B_SUBMIT)
        Me.Controls.Add(Me.T_LINE_CD)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.R_DAILY)
        Me.Name = "DailyReport"
        Me.Text = "DailyReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents R_DAILY As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents T_LINE_CD As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents B_SUBMIT As Button
    Friend WithEvents T_LINE_NAME As TextBox
    Friend WithEvents B_BACK As Button
End Class
