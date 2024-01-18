<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Warning
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.B_BACK = New System.Windows.Forms.Button()
        Me.L_WARNING = New System.Windows.Forms.Label()
        Me.PB_WARNING = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PB_WARNING, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.B_BACK)
        Me.Panel1.Controls.Add(Me.L_WARNING)
        Me.Panel1.Location = New System.Drawing.Point(0, 232)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 219)
        Me.Panel1.TabIndex = 0
        '
        'B_BACK
        '
        Me.B_BACK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_BACK.Location = New System.Drawing.Point(687, 161)
        Me.B_BACK.Name = "B_BACK"
        Me.B_BACK.Size = New System.Drawing.Size(88, 36)
        Me.B_BACK.TabIndex = 1
        Me.B_BACK.Text = "BACK"
        Me.B_BACK.UseVisualStyleBackColor = True
        '
        'L_WARNING
        '
        Me.L_WARNING.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_WARNING.Location = New System.Drawing.Point(22, 22)
        Me.L_WARNING.Name = "L_WARNING"
        Me.L_WARNING.Size = New System.Drawing.Size(753, 175)
        Me.L_WARNING.TabIndex = 2
        Me.L_WARNING.Text = "Label1"
        Me.L_WARNING.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PB_WARNING
        '
        Me.PB_WARNING.Image = Global.CheckSheetSystem.My.Resources.Resources.warning
        Me.PB_WARNING.Location = New System.Drawing.Point(310, 35)
        Me.PB_WARNING.Name = "PB_WARNING"
        Me.PB_WARNING.Size = New System.Drawing.Size(170, 164)
        Me.PB_WARNING.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PB_WARNING.TabIndex = 1
        Me.PB_WARNING.TabStop = False
        '
        'Warning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PB_WARNING)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Warning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warning"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PB_WARNING, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PB_WARNING As PictureBox
    Friend WithEvents B_BACK As Button
    Friend WithEvents L_WARNING As Label
End Class
