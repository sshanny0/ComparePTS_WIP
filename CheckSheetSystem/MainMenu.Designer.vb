<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.B_DAILY_MAINTENANCE = New System.Windows.Forms.Button()
        Me.B_MASTER_MACHINE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_MAINTENANCE_REPORT = New System.Windows.Forms.Button()
        Me.B_DAILY_CHECK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(-1, -2)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(674, 48)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "MAIN MENU CHECK SHEET SYSTEM"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'B_DAILY_MAINTENANCE
        '
        Me.B_DAILY_MAINTENANCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.B_DAILY_MAINTENANCE.Location = New System.Drawing.Point(45, 102)
        Me.B_DAILY_MAINTENANCE.Name = "B_DAILY_MAINTENANCE"
        Me.B_DAILY_MAINTENANCE.Size = New System.Drawing.Size(268, 132)
        Me.B_DAILY_MAINTENANCE.TabIndex = 7
        Me.B_DAILY_MAINTENANCE.Text = "DAILY MAINTENANCE"
        Me.B_DAILY_MAINTENANCE.UseVisualStyleBackColor = True
        '
        'B_MASTER_MACHINE
        '
        Me.B_MASTER_MACHINE.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.B_MASTER_MACHINE.Location = New System.Drawing.Point(45, 272)
        Me.B_MASTER_MACHINE.Name = "B_MASTER_MACHINE"
        Me.B_MASTER_MACHINE.Size = New System.Drawing.Size(268, 132)
        Me.B_MASTER_MACHINE.TabIndex = 12
        Me.B_MASTER_MACHINE.Text = "MASTER MACHINE"
        Me.B_MASTER_MACHINE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Version : 1.0"
        '
        'B_MAINTENANCE_REPORT
        '
        Me.B_MAINTENANCE_REPORT.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.B_MAINTENANCE_REPORT.Location = New System.Drawing.Point(360, 272)
        Me.B_MAINTENANCE_REPORT.Name = "B_MAINTENANCE_REPORT"
        Me.B_MAINTENANCE_REPORT.Size = New System.Drawing.Size(268, 132)
        Me.B_MAINTENANCE_REPORT.TabIndex = 14
        Me.B_MAINTENANCE_REPORT.Text = "MAINTENANCE REPORT"
        Me.B_MAINTENANCE_REPORT.UseVisualStyleBackColor = True
        '
        'B_DAILY_CHECK
        '
        Me.B_DAILY_CHECK.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.B_DAILY_CHECK.Location = New System.Drawing.Point(360, 102)
        Me.B_DAILY_CHECK.Name = "B_DAILY_CHECK"
        Me.B_DAILY_CHECK.Size = New System.Drawing.Size(268, 132)
        Me.B_DAILY_CHECK.TabIndex = 15
        Me.B_DAILY_CHECK.Text = "DAILY CHECK"
        Me.B_DAILY_CHECK.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(672, 479)
        Me.Controls.Add(Me.B_DAILY_CHECK)
        Me.Controls.Add(Me.B_MAINTENANCE_REPORT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_MASTER_MACHINE)
        Me.Controls.Add(Me.B_DAILY_MAINTENANCE)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PT KATOLEC INDONESIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents B_DAILY_MAINTENANCE As Button
    Friend WithEvents B_MASTER_MACHINE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents B_MAINTENANCE_REPORT As Button
    Friend WithEvents B_DAILY_CHECK As Button
End Class
