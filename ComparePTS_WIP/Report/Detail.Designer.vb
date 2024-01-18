<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail
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
        Me.R_DETAIL = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txt_assy_c = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.B_SEARCH = New System.Windows.Forms.Button()
        Me.D_END = New System.Windows.Forms.DateTimePicker()
        Me.D_START = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'R_DETAIL
        '
        Me.R_DETAIL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.R_DETAIL.LocalReport.ReportEmbeddedResource = "ComparePTS_WIP.R_DETAIL.rdlc"
        Me.R_DETAIL.Location = New System.Drawing.Point(12, 187)
        Me.R_DETAIL.Name = "R_DETAIL"
        Me.R_DETAIL.ServerReport.BearerToken = Nothing
        Me.R_DETAIL.Size = New System.Drawing.Size(1229, 479)
        Me.R_DETAIL.TabIndex = 0
        '
        'txt_assy_c
        '
        Me.txt_assy_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_assy_c.Location = New System.Drawing.Point(246, 97)
        Me.txt_assy_c.Name = "txt_assy_c"
        Me.txt_assy_c.Size = New System.Drawing.Size(256, 30)
        Me.txt_assy_c.TabIndex = 17
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(10, 97)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(219, 30)
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Text = "FILTER ASSY CODE"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_SEARCH
        '
        Me.B_SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_SEARCH.Location = New System.Drawing.Point(246, 134)
        Me.B_SEARCH.Name = "B_SEARCH"
        Me.B_SEARCH.Size = New System.Drawing.Size(149, 35)
        Me.B_SEARCH.TabIndex = 15
        Me.B_SEARCH.Text = "SEARCH"
        Me.B_SEARCH.UseVisualStyleBackColor = True
        '
        'D_END
        '
        Me.D_END.CustomFormat = "yyyy-MM-dd 07:00:00"
        Me.D_END.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_END.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_END.Location = New System.Drawing.Point(539, 61)
        Me.D_END.Name = "D_END"
        Me.D_END.Size = New System.Drawing.Size(257, 30)
        Me.D_END.TabIndex = 14
        '
        'D_START
        '
        Me.D_START.CustomFormat = "yyyy-MM-dd 07:00:00"
        Me.D_START.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_START.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_START.Location = New System.Drawing.Point(246, 61)
        Me.D_START.Name = "D_START"
        Me.D_START.Size = New System.Drawing.Size(257, 30)
        Me.D_START.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(10, 61)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(219, 30)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = "FILTER DATE"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, -2)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1252, 47)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "REPORT DETAIL WIP"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(512, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "-"
        '
        'Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1253, 678)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_assy_c)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.B_SEARCH)
        Me.Controls.Add(Me.D_END)
        Me.Controls.Add(Me.D_START)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.R_DETAIL)
        Me.Name = "Detail"
        Me.Text = "Detail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents R_DETAIL As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txt_assy_c As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents B_SEARCH As Button
    Friend WithEvents D_END As DateTimePicker
    Friend WithEvents D_START As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
