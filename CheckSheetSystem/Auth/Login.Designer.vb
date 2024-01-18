<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.T_RFID = New System.Windows.Forms.TextBox()
        Me.B_LOGIN = New System.Windows.Forms.Button()
        Me.B_REGISTER = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Roboto", 20.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(1, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(595, 44)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "CHECKSHEET SYSTEM"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(40, 82)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(138, 32)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "PIC RF ID"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_RFID
        '
        Me.T_RFID.Location = New System.Drawing.Point(184, 82)
        Me.T_RFID.Name = "T_RFID"
        Me.T_RFID.Size = New System.Drawing.Size(362, 32)
        Me.T_RFID.TabIndex = 2
        '
        'B_LOGIN
        '
        Me.B_LOGIN.BackColor = System.Drawing.Color.MidnightBlue
        Me.B_LOGIN.ForeColor = System.Drawing.Color.White
        Me.B_LOGIN.Location = New System.Drawing.Point(184, 139)
        Me.B_LOGIN.Name = "B_LOGIN"
        Me.B_LOGIN.Size = New System.Drawing.Size(169, 45)
        Me.B_LOGIN.TabIndex = 3
        Me.B_LOGIN.Text = "SIGN IN"
        Me.B_LOGIN.UseVisualStyleBackColor = False
        '
        'B_REGISTER
        '
        Me.B_REGISTER.BackColor = System.Drawing.Color.MidnightBlue
        Me.B_REGISTER.ForeColor = System.Drawing.Color.White
        Me.B_REGISTER.Location = New System.Drawing.Point(377, 139)
        Me.B_REGISTER.Name = "B_REGISTER"
        Me.B_REGISTER.Size = New System.Drawing.Size(169, 45)
        Me.B_REGISTER.TabIndex = 4
        Me.B_REGISTER.Text = "SIGN UP"
        Me.B_REGISTER.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(598, 207)
        Me.Controls.Add(Me.B_REGISTER)
        Me.Controls.Add(Me.B_LOGIN)
        Me.Controls.Add(Me.T_RFID)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PT KATOLEC INDONESIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents T_RFID As TextBox
    Friend WithEvents B_LOGIN As Button
    Friend WithEvents B_REGISTER As Button
End Class
