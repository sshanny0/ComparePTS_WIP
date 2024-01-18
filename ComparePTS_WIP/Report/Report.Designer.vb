<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.R_DATA = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.D_START = New System.Windows.Forms.DateTimePicker()
        Me.D_END = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_SEARCH = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.txt_assy_c = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(1, 2)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1186, 47)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "REPORT COMPARE PTS AND WIP"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R_DATA
        '
        Me.R_DATA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.R_DATA.Location = New System.Drawing.Point(13, 180)
        Me.R_DATA.Margin = New System.Windows.Forms.Padding(4)
        Me.R_DATA.Name = "R_DATA"
        Me.R_DATA.ServerReport.BearerToken = Nothing
        Me.R_DATA.Size = New System.Drawing.Size(1160, 495)
        Me.R_DATA.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(13, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(219, 30)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "FILTER DATE"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'D_START
        '
        Me.D_START.CustomFormat = "yyyy-MM-dd 07:00:00"
        Me.D_START.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_START.Location = New System.Drawing.Point(249, 65)
        Me.D_START.Name = "D_START"
        Me.D_START.Size = New System.Drawing.Size(257, 30)
        Me.D_START.TabIndex = 5
        '
        'D_END
        '
        Me.D_END.CustomFormat = "yyyy-MM-dd 07:00:00"
        Me.D_END.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_END.Location = New System.Drawing.Point(537, 65)
        Me.D_END.Name = "D_END"
        Me.D_END.Size = New System.Drawing.Size(257, 30)
        Me.D_END.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(512, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "-"
        '
        'B_SEARCH
        '
        Me.B_SEARCH.Location = New System.Drawing.Point(249, 138)
        Me.B_SEARCH.Name = "B_SEARCH"
        Me.B_SEARCH.Size = New System.Drawing.Size(149, 35)
        Me.B_SEARCH.TabIndex = 8
        Me.B_SEARCH.Text = "SEARCH"
        Me.B_SEARCH.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(13, 101)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(219, 30)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "FILTER ASSY CODE"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_assy_c
        '
        Me.txt_assy_c.Location = New System.Drawing.Point(249, 101)
        Me.txt_assy_c.Name = "txt_assy_c"
        Me.txt_assy_c.Size = New System.Drawing.Size(256, 30)
        Me.txt_assy_c.TabIndex = 10
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1186, 688)
        Me.Controls.Add(Me.txt_assy_c)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.B_SEARCH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.D_END)
        Me.Controls.Add(Me.D_START)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.R_DATA)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PT KATOLEC INDONESIA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents R_DATA As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents D_START As DateTimePicker
    Friend WithEvents D_END As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents B_SEARCH As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txt_assy_c As TextBox
End Class
