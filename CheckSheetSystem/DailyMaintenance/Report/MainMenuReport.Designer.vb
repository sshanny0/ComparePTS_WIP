<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenuReport
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.B_DAILY_MAINTENANCE = New System.Windows.Forms.Button()
        Me.B_WEEK_MAINTENANCE = New System.Windows.Forms.Button()
        Me.B_MONTH_MAINTENANCE = New System.Windows.Forms.Button()
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
        Me.TextBox1.Location = New System.Drawing.Point(-1, 1)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(904, 48)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "MAIN MENU MAINTENANCE REPORT"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_DAILY_MAINTENANCE
        '
        Me.B_DAILY_MAINTENANCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_DAILY_MAINTENANCE.Location = New System.Drawing.Point(73, 145)
        Me.B_DAILY_MAINTENANCE.Name = "B_DAILY_MAINTENANCE"
        Me.B_DAILY_MAINTENANCE.Size = New System.Drawing.Size(341, 191)
        Me.B_DAILY_MAINTENANCE.TabIndex = 8
        Me.B_DAILY_MAINTENANCE.Text = "DAILY REPORT"
        Me.B_DAILY_MAINTENANCE.UseVisualStyleBackColor = True
        '
        'B_WEEK_MAINTENANCE
        '
        Me.B_WEEK_MAINTENANCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_WEEK_MAINTENANCE.Location = New System.Drawing.Point(482, 145)
        Me.B_WEEK_MAINTENANCE.Name = "B_WEEK_MAINTENANCE"
        Me.B_WEEK_MAINTENANCE.Size = New System.Drawing.Size(341, 191)
        Me.B_WEEK_MAINTENANCE.TabIndex = 9
        Me.B_WEEK_MAINTENANCE.Text = "WEEKLY REPORT"
        Me.B_WEEK_MAINTENANCE.UseVisualStyleBackColor = True
        '
        'B_MONTH_MAINTENANCE
        '
        Me.B_MONTH_MAINTENANCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_MONTH_MAINTENANCE.Location = New System.Drawing.Point(73, 398)
        Me.B_MONTH_MAINTENANCE.Name = "B_MONTH_MAINTENANCE"
        Me.B_MONTH_MAINTENANCE.Size = New System.Drawing.Size(341, 191)
        Me.B_MONTH_MAINTENANCE.TabIndex = 10
        Me.B_MONTH_MAINTENANCE.Text = "MONTHLY REPORT"
        Me.B_MONTH_MAINTENANCE.UseVisualStyleBackColor = True
        '
        'B_BACK
        '
        Me.B_BACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_BACK.Location = New System.Drawing.Point(776, 68)
        Me.B_BACK.Name = "B_BACK"
        Me.B_BACK.Size = New System.Drawing.Size(103, 36)
        Me.B_BACK.TabIndex = 12
        Me.B_BACK.Text = "BACK"
        Me.B_BACK.UseVisualStyleBackColor = True
        '
        'MainMenuReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(900, 634)
        Me.Controls.Add(Me.B_BACK)
        Me.Controls.Add(Me.B_MONTH_MAINTENANCE)
        Me.Controls.Add(Me.B_WEEK_MAINTENANCE)
        Me.Controls.Add(Me.B_DAILY_MAINTENANCE)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "MainMenuReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenuReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents B_DAILY_MAINTENANCE As Button
    Friend WithEvents B_WEEK_MAINTENANCE As Button
    Friend WithEvents B_MONTH_MAINTENANCE As Button
    Friend WithEvents B_BACK As Button
End Class
