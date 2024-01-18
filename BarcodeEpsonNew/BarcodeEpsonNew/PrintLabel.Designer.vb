<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintLabel
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
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.nmr_qty = New System.Windows.Forms.NumericUpDown()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.cmb_model = New System.Windows.Forms.ComboBox()
        CType(Me.nmr_qty, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TextBox1.Location = New System.Drawing.Point(0, -1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(674, 56)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "PRINT LABEL EPSON KUWAIT"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(21, 129)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(156, 35)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = "MODEL"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(21, 170)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(156, 35)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = "QUANTITY"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nmr_qty
        '
        Me.nmr_qty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nmr_qty.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmr_qty.Location = New System.Drawing.Point(196, 170)
        Me.nmr_qty.Name = "nmr_qty"
        Me.nmr_qty.ReadOnly = True
        Me.nmr_qty.Size = New System.Drawing.Size(443, 35)
        Me.nmr_qty.TabIndex = 6
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.btn_print.Font = New System.Drawing.Font("Leelawadee UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.White
        Me.btn_print.Location = New System.Drawing.Point(196, 211)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(443, 46)
        Me.btn_print.TabIndex = 7
        Me.btn_print.Text = "PRINT"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'cmb_model
        '
        Me.cmb_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_model.Font = New System.Drawing.Font("Leelawadee", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_model.FormattingEnabled = True
        Me.cmb_model.IntegralHeight = False
        Me.cmb_model.Location = New System.Drawing.Point(196, 129)
        Me.cmb_model.Name = "cmb_model"
        Me.cmb_model.Size = New System.Drawing.Size(443, 35)
        Me.cmb_model.TabIndex = 8
        '
        'PrintLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(672, 283)
        Me.Controls.Add(Me.cmb_model)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.nmr_qty)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "PrintLabel"
        Me.Text = "s"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.nmr_qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents nmr_qty As NumericUpDown
    Friend WithEvents btn_print As Button
    Friend WithEvents cmb_model As ComboBox
End Class
