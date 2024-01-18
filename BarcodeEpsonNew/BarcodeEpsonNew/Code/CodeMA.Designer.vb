<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeMA
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cmb_assy = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.dt_prod = New System.Windows.Forms.DateTimePicker()
        Me.txt_qty_info = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.qty_start = New System.Windows.Forms.NumericUpDown()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.qty_end = New System.Windows.Forms.NumericUpDown()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.cmb_printer = New System.Windows.Forms.ComboBox()
        Me.dgv_log = New System.Windows.Forms.DataGridView()
        CType(Me.qty_start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qty_end, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_log, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Leelawadee UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(1, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(735, 56)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "PRINT MA"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(23, 87)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(180, 35)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = "ASSY CODE"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_assy
        '
        Me.cmb_assy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_assy.Font = New System.Drawing.Font("Leelawadee", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_assy.FormattingEnabled = True
        Me.cmb_assy.IntegralHeight = False
        Me.cmb_assy.Location = New System.Drawing.Point(241, 87)
        Me.cmb_assy.Name = "cmb_assy"
        Me.cmb_assy.Size = New System.Drawing.Size(469, 35)
        Me.cmb_assy.TabIndex = 15
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(23, 142)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(180, 35)
        Me.TextBox4.TabIndex = 16
        Me.TextBox4.Text = "PROD DATE"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dt_prod
        '
        Me.dt_prod.CustomFormat = "yyyy-MM-dd HH:mm:ss.mmm"
        Me.dt_prod.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_prod.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_prod.Location = New System.Drawing.Point(241, 142)
        Me.dt_prod.Name = "dt_prod"
        Me.dt_prod.Size = New System.Drawing.Size(469, 39)
        Me.dt_prod.TabIndex = 17
        Me.dt_prod.Value = New Date(2023, 12, 14, 0, 0, 0, 0)
        '
        'txt_qty_info
        '
        Me.txt_qty_info.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty_info.Location = New System.Drawing.Point(23, 198)
        Me.txt_qty_info.Multiline = True
        Me.txt_qty_info.Name = "txt_qty_info"
        Me.txt_qty_info.ReadOnly = True
        Me.txt_qty_info.Size = New System.Drawing.Size(687, 35)
        Me.txt_qty_info.TabIndex = 26
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(23, 254)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(147, 35)
        Me.TextBox5.TabIndex = 27
        Me.TextBox5.Text = "START NO"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'qty_start
        '
        Me.qty_start.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.qty_start.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty_start.Location = New System.Drawing.Point(203, 254)
        Me.qty_start.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.qty_start.Name = "qty_start"
        Me.qty_start.Size = New System.Drawing.Size(153, 35)
        Me.qty_start.TabIndex = 28
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(377, 253)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(147, 35)
        Me.TextBox6.TabIndex = 29
        Me.TextBox6.Text = "END NO"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'qty_end
        '
        Me.qty_end.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.qty_end.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty_end.Location = New System.Drawing.Point(557, 253)
        Me.qty_end.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.qty_end.Name = "qty_end"
        Me.qty_end.Size = New System.Drawing.Size(153, 35)
        Me.qty_end.TabIndex = 30
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btn_print.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.White
        Me.btn_print.Location = New System.Drawing.Point(557, 308)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(153, 46)
        Me.btn_print.TabIndex = 31
        Me.btn_print.Text = "PRINT"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(65, 308)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(148, 46)
        Me.ListView1.TabIndex = 32
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.Visible = False
        '
        'cmb_printer
        '
        Me.cmb_printer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_printer.Font = New System.Drawing.Font("Leelawadee UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_printer.FormattingEnabled = True
        Me.cmb_printer.Location = New System.Drawing.Point(23, 308)
        Me.cmb_printer.Name = "cmb_printer"
        Me.cmb_printer.Size = New System.Drawing.Size(284, 39)
        Me.cmb_printer.TabIndex = 33
        '
        'dgv_log
        '
        Me.dgv_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_log.Location = New System.Drawing.Point(23, 390)
        Me.dgv_log.Name = "dgv_log"
        Me.dgv_log.RowHeadersWidth = 51
        Me.dgv_log.RowTemplate.Height = 24
        Me.dgv_log.Size = New System.Drawing.Size(687, 303)
        Me.dgv_log.TabIndex = 36
        '
        'CodeMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(735, 706)
        Me.Controls.Add(Me.dgv_log)
        Me.Controls.Add(Me.cmb_printer)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.qty_end)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.qty_start)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.txt_qty_info)
        Me.Controls.Add(Me.dt_prod)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.cmb_assy)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "CodeMA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CodeMA"
        CType(Me.qty_start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qty_end, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_log, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents cmb_assy As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents dt_prod As DateTimePicker
    Friend WithEvents txt_qty_info As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents qty_start As NumericUpDown
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents qty_end As NumericUpDown
    Friend WithEvents btn_print As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ListView1 As ListView
    Friend WithEvents cmb_printer As ComboBox
    Friend WithEvents dgv_log As DataGridView
End Class
