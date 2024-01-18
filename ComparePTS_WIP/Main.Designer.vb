<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.B_SAVE = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txt_main_input = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.N_QTY = New System.Windows.Forms.NumericUpDown()
        Me.txt_assy_c = New System.Windows.Forms.TextBox()
        Me.txt_mil_no = New System.Windows.Forms.TextBox()
        Me.txt_line = New System.Windows.Forms.TextBox()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.txt_ref_no = New System.Windows.Forms.TextBox()
        Me.txt_job_number = New System.Windows.Forms.TextBox()
        Me.txt_seq = New System.Windows.Forms.TextBox()
        CType(Me.N_QTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(1342, 63)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "INPUT WIP"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_SAVE
        '
        Me.B_SAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_SAVE.Location = New System.Drawing.Point(366, 277)
        Me.B_SAVE.Name = "B_SAVE"
        Me.B_SAVE.Size = New System.Drawing.Size(394, 54)
        Me.B_SAVE.TabIndex = 3
        Me.B_SAVE.Text = "SAVE"
        Me.B_SAVE.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(15, 101)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(345, 38)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "SCAN LABEL QR CODE "
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_main_input
        '
        Me.txt_main_input.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_main_input.Location = New System.Drawing.Point(366, 101)
        Me.txt_main_input.Name = "txt_main_input"
        Me.txt_main_input.Size = New System.Drawing.Size(394, 38)
        Me.txt_main_input.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.DodgerBlue
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(15, 145)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(345, 38)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "QUANTITY"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'N_QTY
        '
        Me.N_QTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_QTY.Location = New System.Drawing.Point(366, 145)
        Me.N_QTY.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.N_QTY.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.N_QTY.Name = "N_QTY"
        Me.N_QTY.Size = New System.Drawing.Size(394, 143)
        Me.N_QTY.TabIndex = 0
        '
        'txt_assy_c
        '
        Me.txt_assy_c.Location = New System.Drawing.Point(383, 107)
        Me.txt_assy_c.Name = "txt_assy_c"
        Me.txt_assy_c.Size = New System.Drawing.Size(22, 30)
        Me.txt_assy_c.TabIndex = 6
        '
        'txt_mil_no
        '
        Me.txt_mil_no.Location = New System.Drawing.Point(411, 107)
        Me.txt_mil_no.Name = "txt_mil_no"
        Me.txt_mil_no.Size = New System.Drawing.Size(22, 30)
        Me.txt_mil_no.TabIndex = 7
        '
        'txt_line
        '
        Me.txt_line.Location = New System.Drawing.Point(439, 107)
        Me.txt_line.Name = "txt_line"
        Me.txt_line.Size = New System.Drawing.Size(22, 30)
        Me.txt_line.TabIndex = 8
        '
        'txt_model
        '
        Me.txt_model.Location = New System.Drawing.Point(467, 107)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(22, 30)
        Me.txt_model.TabIndex = 9
        '
        'txt_ref_no
        '
        Me.txt_ref_no.Location = New System.Drawing.Point(495, 107)
        Me.txt_ref_no.Name = "txt_ref_no"
        Me.txt_ref_no.Size = New System.Drawing.Size(22, 30)
        Me.txt_ref_no.TabIndex = 10
        '
        'txt_job_number
        '
        Me.txt_job_number.Location = New System.Drawing.Point(523, 107)
        Me.txt_job_number.Name = "txt_job_number"
        Me.txt_job_number.Size = New System.Drawing.Size(22, 30)
        Me.txt_job_number.TabIndex = 11
        '
        'txt_seq
        '
        Me.txt_seq.Location = New System.Drawing.Point(551, 107)
        Me.txt_seq.Name = "txt_seq"
        Me.txt_seq.Size = New System.Drawing.Size(22, 30)
        Me.txt_seq.TabIndex = 12
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1342, 638)
        Me.Controls.Add(Me.txt_main_input)
        Me.Controls.Add(Me.txt_seq)
        Me.Controls.Add(Me.txt_job_number)
        Me.Controls.Add(Me.txt_ref_no)
        Me.Controls.Add(Me.txt_model)
        Me.Controls.Add(Me.txt_line)
        Me.Controls.Add(Me.txt_mil_no)
        Me.Controls.Add(Me.txt_assy_c)
        Me.Controls.Add(Me.N_QTY)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.B_SAVE)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PT KATOLEC INDONESIA"
        CType(Me.N_QTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents B_SAVE As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txt_main_input As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents N_QTY As NumericUpDown
    Friend WithEvents txt_assy_c As TextBox
    Friend WithEvents txt_mil_no As TextBox
    Friend WithEvents txt_line As TextBox
    Friend WithEvents txt_model As TextBox
    Friend WithEvents txt_ref_no As TextBox
    Friend WithEvents txt_job_number As TextBox
    Friend WithEvents txt_seq As TextBox
End Class
