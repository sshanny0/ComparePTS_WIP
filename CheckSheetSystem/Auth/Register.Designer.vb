<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.B_REGISTER = New System.Windows.Forms.Button()
        Me.B_CLEAR = New System.Windows.Forms.Button()
        Me.T_RFID = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.T_NIK = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.T_NAME = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.C_STATUS = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'B_REGISTER
        '
        Me.B_REGISTER.BackColor = System.Drawing.Color.MidnightBlue
        Me.B_REGISTER.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.B_REGISTER.ForeColor = System.Drawing.Color.White
        Me.B_REGISTER.Location = New System.Drawing.Point(209, 243)
        Me.B_REGISTER.Margin = New System.Windows.Forms.Padding(4)
        Me.B_REGISTER.Name = "B_REGISTER"
        Me.B_REGISTER.Size = New System.Drawing.Size(160, 49)
        Me.B_REGISTER.TabIndex = 9
        Me.B_REGISTER.Text = "SIGN UP"
        Me.B_REGISTER.UseVisualStyleBackColor = False
        '
        'B_CLEAR
        '
        Me.B_CLEAR.BackColor = System.Drawing.Color.MidnightBlue
        Me.B_CLEAR.ForeColor = System.Drawing.Color.White
        Me.B_CLEAR.Location = New System.Drawing.Point(495, 243)
        Me.B_CLEAR.Margin = New System.Windows.Forms.Padding(4)
        Me.B_CLEAR.Name = "B_CLEAR"
        Me.B_CLEAR.Size = New System.Drawing.Size(154, 49)
        Me.B_CLEAR.TabIndex = 8
        Me.B_CLEAR.Text = "CLEAR"
        Me.B_CLEAR.UseVisualStyleBackColor = False
        '
        'T_RFID
        '
        Me.T_RFID.Location = New System.Drawing.Point(209, 150)
        Me.T_RFID.Margin = New System.Windows.Forms.Padding(4)
        Me.T_RFID.Name = "T_RFID"
        Me.T_RFID.Size = New System.Drawing.Size(441, 32)
        Me.T_RFID.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(13, 150)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(188, 32)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "PIC RF ID"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Navy
        Me.TextBox1.Font = New System.Drawing.Font("Roboto", 20.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(2, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(664, 48)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "SIGN UP PIC CHECKSHEET SYSTEM"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_NIK
        '
        Me.T_NIK.Location = New System.Drawing.Point(208, 70)
        Me.T_NIK.Margin = New System.Windows.Forms.Padding(4)
        Me.T_NIK.Name = "T_NIK"
        Me.T_NIK.Size = New System.Drawing.Size(441, 32)
        Me.T_NIK.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(12, 70)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(188, 32)
        Me.TextBox4.TabIndex = 10
        Me.TextBox4.Text = "NIK"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T_NAME
        '
        Me.T_NAME.Location = New System.Drawing.Point(208, 110)
        Me.T_NAME.Margin = New System.Windows.Forms.Padding(4)
        Me.T_NAME.Name = "T_NAME"
        Me.T_NAME.Size = New System.Drawing.Size(441, 32)
        Me.T_NAME.TabIndex = 13
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(12, 110)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(188, 32)
        Me.TextBox6.TabIndex = 12
        Me.TextBox6.Text = "NAME"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'C_STATUS
        '
        Me.C_STATUS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_STATUS.FormattingEnabled = True
        Me.C_STATUS.Items.AddRange(New Object() {"", "ACTIVE", "INACTIVE"})
        Me.C_STATUS.Location = New System.Drawing.Point(209, 189)
        Me.C_STATUS.Name = "C_STATUS"
        Me.C_STATUS.Size = New System.Drawing.Size(441, 32)
        Me.C_STATUS.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(13, 189)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(188, 32)
        Me.TextBox3.TabIndex = 15
        Me.TextBox3.Text = "STATUS"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(668, 308)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.C_STATUS)
        Me.Controls.Add(Me.T_NAME)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.T_NIK)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.B_REGISTER)
        Me.Controls.Add(Me.B_CLEAR)
        Me.Controls.Add(Me.T_RFID)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents B_REGISTER As Button
    Friend WithEvents B_CLEAR As Button
    Friend WithEvents T_RFID As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents T_NIK As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents T_NAME As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents C_STATUS As ComboBox
    Friend WithEvents TextBox3 As TextBox
End Class
