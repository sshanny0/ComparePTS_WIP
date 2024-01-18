Public Class Register
    Public Sub txtClear()
        For Each txt In {T_RFID, T_NIK, T_NAME}
            txt.Clear()
        Next
        C_STATUS.Text = ""
        T_NIK.Select()
    End Sub
    Private Sub B_CLEAR_Click(sender As Object, e As EventArgs) Handles B_CLEAR.Click
        txtClear()
    End Sub

    Private Sub B_REGISTER_Click(sender As Object, e As EventArgs) Handles B_REGISTER.Click
        If T_NIK.Text = "" Then
            MsgBox("NIK CANNOT BE NULL", MsgBoxStyle.Exclamation, "WARNING")
            T_NIK.Select()
        ElseIf T_NAME.Text = "" Then
            MsgBox("NAME CANNOT BE NULL", MsgBoxStyle.Exclamation, "WARNING")
            T_NAME.Select()
        ElseIf T_RFID.Text = "" Then
            MsgBox("RF ID CANNOT BE NULL", MsgBoxStyle.Exclamation, "WARNING")
            T_RFID.Select()
        Else
            Dim queryCheck As String = String.Empty
            queryCheck &= " SELECT * FROM mt_master_user WHERE rfid = '" & T_RFID.Text & "' AND nik = '" & T_NIK.Text & "' "
            queryCheck &= " AND name = '" & T_NAME.Text & "' AND type = 'CHECK_SHEET_SYSTEM' "

            Dim reader As ModSqlRaeder = getDataReaderTDF(queryCheck)

            If reader.sqlDataReader.Read Then
                MsgBox("USER ALREADY EXISTS!", MsgBoxStyle.Exclamation, "WARNING")
            Else
                Dim query As String = String.Empty
                query &= " INSERT INTO mt_master_user (nik, name, rfid, created_at, type, status) "
                query &= " VALUES('" & T_NIK.Text & "','" & T_NAME.Text & "','" & T_RFID.Text & "', GETDATE(), 'CHECK_SHEET_SYSTEM','" & C_STATUS.Text & "') "

                ExecuteQueryTDF(query)
                MsgBox("SUCCESSFULLY REGISTERED. PLEASE LOGIN", MsgBoxStyle.Information, "INFORMATION")
                txtClear()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub T_NIK_KeyDown(sender As Object, e As KeyEventArgs) Handles T_NIK.KeyDown
        If e.KeyCode = Keys.Enter Then
            T_NAME.Select()
        End If
    End Sub

    Private Sub T_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles T_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            T_RFID.Select()
        End If
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class