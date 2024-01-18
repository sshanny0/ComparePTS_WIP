<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.B_INPUT = New System.Windows.Forms.Button()
        Me.B_REPORT = New System.Windows.Forms.Button()
        Me.B_DETAIL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(929, 49)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "MENU INPUT & REPORT WIP AUTO"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_INPUT
        '
        Me.B_INPUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.B_INPUT.Location = New System.Drawing.Point(12, 55)
        Me.B_INPUT.Name = "B_INPUT"
        Me.B_INPUT.Size = New System.Drawing.Size(297, 256)
        Me.B_INPUT.TabIndex = 2
        Me.B_INPUT.Text = "INPUT"
        Me.B_INPUT.UseVisualStyleBackColor = True
        '
        'B_REPORT
        '
        Me.B_REPORT.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.B_REPORT.Location = New System.Drawing.Point(618, 55)
        Me.B_REPORT.Name = "B_REPORT"
        Me.B_REPORT.Size = New System.Drawing.Size(297, 256)
        Me.B_REPORT.TabIndex = 3
        Me.B_REPORT.Text = "REPORT COMPARE"
        Me.B_REPORT.UseVisualStyleBackColor = True
        '
        'B_DETAIL
        '
        Me.B_DETAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.B_DETAIL.Location = New System.Drawing.Point(315, 55)
        Me.B_DETAIL.Name = "B_DETAIL"
        Me.B_DETAIL.Size = New System.Drawing.Size(297, 256)
        Me.B_DETAIL.TabIndex = 4
        Me.B_DETAIL.Text = "REPORT DETAIL"
        Me.B_DETAIL.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(926, 323)
        Me.Controls.Add(Me.B_DETAIL)
        Me.Controls.Add(Me.B_REPORT)
        Me.Controls.Add(Me.B_INPUT)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PT KATOLEC INDONESIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents B_INPUT As Button
    Friend WithEvents B_REPORT As Button
    Friend WithEvents B_DETAIL As Button
End Class
