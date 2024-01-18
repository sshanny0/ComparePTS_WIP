Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T_RFID.Select()
    End Sub
    Public Sub PostLogin()
        If T_RFID.Text = "" Then
            MsgBox("SCAN YOUR RF ID FIRST!", MsgBoxStyle.Critical, "ERROR 404")
            T_RFID.Select()
        Else
            Dim query As String = String.Empty
            query &= " SELECT * FROM mt_master_user WHERE rfid = '" & T_RFID.Text & "' "

            Dim reader As ModSqlRaeder = getDataReaderTDF(query)
            If reader.sqlDataReader.Read Then

                If reader.sqlDataReader("status") = "ACTIVE" Then
                    MainMenu.Show()
                    MainMenu.B_DAILY_MAINTENANCE.Focus()
                    Me.Hide()
                ElseIf reader.sqlDataReader("status") = "INACTIVE" Then
                    MsgBox("YOUR ACCOUNT IS INACTIVE", MsgBoxStyle.Exclamation, "WARNING")
                End If
            Else
                MsgBox("REGISTER YOUR RFID FIRST!", MsgBoxStyle.Critical, "ERROR 404 NOT FOUND")
            End If
        End If
    End Sub
    Private Sub B_LOGIN_Click(sender As Object, e As EventArgs) Handles B_LOGIN.Click
        PostLogin()
    End Sub

    Private Sub T_RFID_KeyDown(sender As Object, e As KeyEventArgs) Handles T_RFID.KeyDown
        If e.KeyValue = Keys.Enter Then
            PostLogin()
        End If
    End Sub

    Private Sub B_REGISTER_Click(sender As Object, e As EventArgs) Handles B_REGISTER.Click
        Dim f As New Register
        f.Show()
        f.T_NIK.Select()
    End Sub
End Class
