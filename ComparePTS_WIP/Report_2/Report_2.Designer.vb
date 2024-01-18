<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_2
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
        Me.txt_assy_c = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.B_SEARCH = New System.Windows.Forms.Button()
        Me.D_END = New System.Windows.Forms.DateTimePicker()
        Me.D_START = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DG_MAIN = New System.Windows.Forms.DataGridView()
        Me.B_EXPORT = New System.Windows.Forms.Button()
        CType(Me.DG_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_assy_c
        '
        Me.txt_assy_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_assy_c.Location = New System.Drawing.Point(249, 98)
        Me.txt_assy_c.Name = "txt_assy_c"
        Me.txt_assy_c.Size = New System.Drawing.Size(256, 30)
        Me.txt_assy_c.TabIndex = 17
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(13, 98)
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
        Me.B_SEARCH.Location = New System.Drawing.Point(249, 135)
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
        Me.D_END.Location = New System.Drawing.Point(537, 62)
        Me.D_END.Name = "D_END"
        Me.D_END.Size = New System.Drawing.Size(257, 30)
        Me.D_END.TabIndex = 14
        '
        'D_START
        '
        Me.D_START.CustomFormat = "yyyy-MM-dd 07:00:00"
        Me.D_START.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_START.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_START.Location = New System.Drawing.Point(249, 62)
        Me.D_START.Name = "D_START"
        Me.D_START.Size = New System.Drawing.Size(257, 30)
        Me.D_START.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(13, 62)
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
        Me.TextBox1.Location = New System.Drawing.Point(1, -1)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(978, 47)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "REPORT COMPARE PTS AND WIP"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DG_MAIN
        '
        Me.DG_MAIN.AllowUserToAddRows = False
        Me.DG_MAIN.AllowUserToDeleteRows = False
        Me.DG_MAIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_MAIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_MAIN.Location = New System.Drawing.Point(1, 190)
        Me.DG_MAIN.Name = "DG_MAIN"
        Me.DG_MAIN.ReadOnly = True
        Me.DG_MAIN.RowHeadersWidth = 51
        Me.DG_MAIN.RowTemplate.Height = 24
        Me.DG_MAIN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_MAIN.Size = New System.Drawing.Size(978, 260)
        Me.DG_MAIN.TabIndex = 18
        '
        'B_EXPORT
        '
        Me.B_EXPORT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_EXPORT.Location = New System.Drawing.Point(413, 135)
        Me.B_EXPORT.Name = "B_EXPORT"
        Me.B_EXPORT.Size = New System.Drawing.Size(149, 35)
        Me.B_EXPORT.TabIndex = 19
        Me.B_EXPORT.Text = "EXCEL"
        Me.B_EXPORT.UseVisualStyleBackColor = True
        '
        'Report_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 450)
        Me.Controls.Add(Me.B_EXPORT)
        Me.Controls.Add(Me.DG_MAIN)
        Me.Controls.Add(Me.txt_assy_c)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.B_SEARCH)
        Me.Controls.Add(Me.D_END)
        Me.Controls.Add(Me.D_START)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Report_2"
        Me.Text = "Report_2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_assy_c As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents B_SEARCH As Button
    Friend WithEvents D_END As DateTimePicker
    Friend WithEvents D_START As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DG_MAIN As DataGridView
    Friend WithEvents B_EXPORT As Button
End Class
