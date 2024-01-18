<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail_Report
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
        Me.DG_MAIN = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_assycode = New System.Windows.Forms.TextBox()
        Me.B_EXPORT = New System.Windows.Forms.Button()
        CType(Me.DG_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_MAIN
        '
        Me.DG_MAIN.AllowUserToAddRows = False
        Me.DG_MAIN.AllowUserToDeleteRows = False
        Me.DG_MAIN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_MAIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_MAIN.Location = New System.Drawing.Point(2, 117)
        Me.DG_MAIN.Name = "DG_MAIN"
        Me.DG_MAIN.ReadOnly = True
        Me.DG_MAIN.RowHeadersWidth = 51
        Me.DG_MAIN.RowTemplate.Height = 24
        Me.DG_MAIN.Size = New System.Drawing.Size(799, 328)
        Me.DG_MAIN.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(2, -1)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(799, 47)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "DETAIL COMPARE PTS AND WIP"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_assycode
        '
        Me.txt_assycode.BackColor = System.Drawing.Color.DodgerBlue
        Me.txt_assycode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_assycode.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_assycode.Location = New System.Drawing.Point(2, 68)
        Me.txt_assycode.Name = "txt_assycode"
        Me.txt_assycode.ReadOnly = True
        Me.txt_assycode.Size = New System.Drawing.Size(631, 30)
        Me.txt_assycode.TabIndex = 22
        Me.txt_assycode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_EXPORT
        '
        Me.B_EXPORT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_EXPORT.Location = New System.Drawing.Point(639, 66)
        Me.B_EXPORT.Name = "B_EXPORT"
        Me.B_EXPORT.Size = New System.Drawing.Size(149, 35)
        Me.B_EXPORT.TabIndex = 23
        Me.B_EXPORT.Text = "EXCEL"
        Me.B_EXPORT.UseVisualStyleBackColor = True
        '
        'Detail_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.B_EXPORT)
        Me.Controls.Add(Me.txt_assycode)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DG_MAIN)
        Me.Name = "Detail_Report"
        Me.Text = "Detail_Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DG_MAIN As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_assycode As TextBox
    Friend WithEvents B_EXPORT As Button
End Class
