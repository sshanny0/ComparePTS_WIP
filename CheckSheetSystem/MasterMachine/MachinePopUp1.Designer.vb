<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachinePopUp1
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
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.BTN_DELETE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_UPDATE.Location = New System.Drawing.Point(60, 94)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(189, 102)
        Me.BTN_UPDATE.TabIndex = 0
        Me.BTN_UPDATE.Text = "UPDATE"
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELETE.Location = New System.Drawing.Point(317, 94)
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(200, 102)
        Me.BTN_DELETE.TabIndex = 1
        Me.BTN_DELETE.Text = "DELETE"
        Me.BTN_DELETE.UseVisualStyleBackColor = True
        '
        'MachinePopUp1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(597, 308)
        Me.Controls.Add(Me.BTN_DELETE)
        Me.Controls.Add(Me.BTN_UPDATE)
        Me.Name = "MachinePopUp1"
        Me.Text = "MachinePopUp1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTN_UPDATE As Button
    Friend WithEvents BTN_DELETE As Button
End Class
