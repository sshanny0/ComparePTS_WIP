Imports System.Data.SqlClient

Public Class MainDailyMaintenance
    Public Sub GetLine()
        Dim query As String = String.Empty
        query &= " SELECT line_cd, line_desc FROM mt_master_machine GROUP BY line_cd, line_desc ORDER BY line_cd "

        Dim dt As DataTable = GetDataTDF(query)
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            col.Add(dt.Rows(i)("line_cd").ToString())
        Next
        T_LINE_CD.AutoCompleteSource = AutoCompleteSource.CustomSource
        T_LINE_CD.AutoCompleteCustomSource = col
        T_LINE_CD.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub
    Public Sub GetMachine()
        Dim query As String = String.Empty
        query &= " SELECT machine_name FROM mt_master_machine WHERE line_cd = '" & T_LINE_CD.Text & "' GROUP BY machine_name ORDER BY machine_name "

        Dim dt As DataTable = GetDataTDF(query)
        With C_MACHINE_NAME
            .DataSource = dt
            .ValueMember = "machine_name"
            .DisplayMember = "machine_name"
            .SelectedIndex = -1
        End With
    End Sub

    Public Sub GetUnit()
        Dim query As String = String.Empty

        query &= " SELECT DISTINCT unit_name FROM mt_master_machine WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
        query &= " AND line_cd = '" & T_LINE_CD.Text & "' "

        Dim dt As DataTable = GetDataTDF(query)
        With C_UNIT_NAME
            .DataSource = dt
            .ValueMember = "unit_name"
            .DisplayMember = "unit_name"
            .SelectedIndex = -1
        End With
    End Sub

    Public Sub GetPartName()
        Dim query As String = String.Empty

        query &= " SELECT DISTINCT part_name FROM mt_master_machine WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
        query &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' "

        Dim dt As DataTable = GetDataTDF(query)
        With C_PART_NAME
            .DataSource = dt
            .ValueMember = "part_name"
            .DisplayMember = "part_name"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub MainDailyMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLine()
    End Sub
    Private Sub T_LINE_NAME_TextChanged(sender As Object, e As EventArgs) Handles T_LINE_NAME.TextChanged
        If T_LINE_CD.Text = "" Then
            T_LINE_NAME.Clear()
        End If
    End Sub

    Private Sub T_LINE_CD_TextChanged(sender As Object, e As EventArgs) Handles T_LINE_CD.TextChanged
        If T_LINE_CD.Text = "" Then
            T_LINE_NAME.Clear()
        End If
    End Sub

    Private Sub C_MACHINE_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_MACHINE_NAME.SelectedIndexChanged
        If C_MACHINE_NAME.SelectedIndex = -1 Then
            T_MACHINE_CD.Text = ""
        Else
            Dim query As String = String.Empty
            query &= " SELECT machine_cd FROM mt_master_machine WHERE machine_name = '" & C_MACHINE_NAME.Text & "' GROUP BY machine_cd "

            Dim dt As DataTable = GetDataTDF(query)
            If dt.Rows.Count > 0 Then
                T_MACHINE_CD.Text = dt.Rows(0)(0)
            End If

            GetUnit()
        End If

    End Sub

    Private Sub T_LINE_CD_KeyDown(sender As Object, e As KeyEventArgs) Handles T_LINE_CD.KeyDown
        If e.KeyCode = Keys.Enter Then
            GetMachine()
            Dim query As String = String.Empty
            query &= " SELECT * FROM mt_master_machine WHERE line_cd = '" & T_LINE_CD.Text & "' "

            Dim dt As DataTable = GetDataTDF(query)
            If dt.Rows.Count > 0 Then
                T_LINE_NAME.Text = dt.Rows(0)(1).ToString

            End If
        End If
    End Sub

    Private Sub C_UNIT_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_UNIT_NAME.SelectedIndexChanged
        GetPartName()
    End Sub

    Private Sub C_PART_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_PART_NAME.SelectedIndexChanged
        If C_PART_NAME.SelectedIndex = -1 Then
            T_METHOD_NAME.Text = ""
        Else
            Dim query As String = String.Empty
            query &= " SELECT DISTINCT CASE WHEN method_part <> '' THEN method_part 
                       WHEN method_range_from <> '' AND method_range_to <> '' AND method_range_unit <> '' 
                       THEN CONCAT(method_range_from, ' - ',  method_range_to, ' ', method_range_unit)
                       END AS method_name FROM mt_master_machine WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
            query &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' AND part_name = '" & C_PART_NAME.Text & "' "

            Dim dt As DataTable = GetDataTDF(query)
            If dt.Rows.Count > 0 Then
                T_METHOD_NAME.Text = dt.Rows(0)(0)
            End If

            Dim queryfrom As String = String.Empty
            queryfrom &= " SELECT method_range_from FROM mt_master_machine WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
            queryfrom &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' AND part_name = '" & C_PART_NAME.Text & "' "

            Dim dt2 As DataTable = GetDataTDF(queryfrom)
            If dt2.Rows.Count > 0 Then
                T_METHOD_FROM.Text = dt2.Rows(0)(0)
            End If

            Dim queryto As String = String.Empty
            queryto &= " SELECT method_range_to FROM mt_master_machine WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
            queryto &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' AND part_name = '" & C_PART_NAME.Text & "' "

            Dim dt3 As DataTable = GetDataTDF(queryto)
            If dt3.Rows.Count > 0 Then
                T_METHOD_TO.Text = dt3.Rows(0)(0)
            End If

            Dim queryunit As String = String.Empty
            queryunit &= " SELECT method_range_unit FROM mt_master_machine WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
            queryunit &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' AND part_name = '" & C_PART_NAME.Text & "' "

            Dim dt4 As DataTable = GetDataTDF(queryunit)
            If dt4.Rows.Count > 0 Then
                T_METHOD_UNIT.Text = dt4.Rows(0)(0)
            End If

            If T_METHOD_FROM.Text <> "" And T_METHOD_TO.Text <> "" And T_METHOD_UNIT.Text <> "" Then
                C_METHOD_CHECK.Visible = "False"
            ElseIf T_METHOD_FROM.Text = "" And T_METHOD_TO.Text = "" And T_METHOD_UNIT.Text = "" Then
                T_METHOD_CHECK.Visible = "True"
            End If
        End If
    End Sub

    Private Sub T_METHOD_NAME_TextChanged(sender As Object, e As EventArgs) Handles T_METHOD_NAME.TextChanged
        If T_METHOD_NAME.Text = "" Then
            T_METHOD_NAME.Clear()
        End If
    End Sub

    Private Sub B_CHECK_Click(sender As Object, e As EventArgs) Handles B_CHECK.Click
        Dim WD As New Warning
        Dim query As String = String.Empty

        query &= " SELECT method_part, method_range_from, method_range_to FROM mt_master_machine "
        query &= " WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
        query &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' AND part_name = '" & C_PART_NAME.Text & "' "

        Dim queryuser As String = String.Empty
        queryuser &= " SELECT nik FROM mt_master_user WHERE rfid = '" & Login.T_RFID.Text & "' "

        Dim dt2 As DataTable = GetDataTDF(queryuser)
        If dt2.Rows.Count > 0 Then
            T_PIC_NIK.Text = dt2.Rows(0)(0)
        End If

        Using con As New SqlConnection(My.Settings.TDF)
            Using da As New SqlDataAdapter(query, con)
                Using dt As New DataTable()
                    da.Fill(dt)
                    For Each dr As DataRow In dt.Rows
                        If String.IsNullOrEmpty(dr("method_part").ToString()) Then
                            'buat method rank
                            If T_METHOD_CHECK.Text >= T_METHOD_FROM.Text And T_METHOD_CHECK.Text <= T_METHOD_TO.Text Then

                                Dim querycheck As String = String.Empty
                                querycheck &= "SELECT * FROM mt_checked_machine "
                                querycheck &= " WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
                                querycheck &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' AND part_name = '" & C_PART_NAME.Text & "' "
                                querycheck &= " AND method_range_from = '" & T_METHOD_FROM.Text & "' AND method_range_to = '" & T_METHOD_TO.Text & "' "
                                querycheck &= " AND method_range_unit = '" & T_METHOD_UNIT.Text & "' AND status = 'OK' AND date = CAST(GETDATE() AS DATE)"

                                Using con2 As New SqlConnection(My.Settings.TDF)
                                    Using cmd As New SqlCommand(querycheck, con2)
                                        con2.Open()

                                        Using reader As SqlDataReader = cmd.ExecuteReader
                                            If reader.HasRows Then
                                                WD.PB_WARNING.Image = CheckSheetSystem.My.Resources.Resources.warning
                                                WD.L_WARNING.Text = "data already exist!"
                                                WD.B_BACK.Text = "OK"
                                                WD.L_WARNING.Text = WD.L_WARNING.Text.ToUpper()
                                                WD.BackColor = Color.Gold
                                                WD.PB_WARNING.BackColor = Color.White
                                                WD.Show()
                                                WD.PB_WARNING.Select()
                                            Else
                                                WD.PB_WARNING.Image = CheckSheetSystem.My.Resources.Resources.checked
                                                WD.L_WARNING.Text = "data already saved!"
                                                WD.B_BACK.Text = "OK"
                                                WD.L_WARNING.Text = WD.L_WARNING.Text.ToUpper()
                                                WD.BackColor = Color.LimeGreen
                                                WD.PB_WARNING.BackColor = Color.White
                                                WD.Show()
                                                WD.PB_WARNING.Select()

                                                Dim queryInsert As String = String.Empty
                                                queryInsert &= "INSERT INTO mt_checked_machine (date, line_cd, line_desc, machine_cd, machine_name, part_name, part_cd, unit_name, "
                                                queryInsert &= " method_part, method_range_from, method_range_to, method_range_unit, reason, result, created_at, status, pic_input, status_check) "

                                                queryInsert &= "SELECT CAST(GETDATE() AS DATE) AS date, line_cd, line_desc, machine_cd, machine_name, part_name, part_cd, unit_name, "
                                                queryInsert &= " method_part, method_range_from, method_range_to, method_range_unit, '" & T_REMARK.Text & "' AS reason, "
                                                queryInsert &= " '" & T_METHOD_CHECK.Text & "' AS result, GETDATE() AS created_at, 'OK' AS status, '" & T_PIC_NIK.Text & "' AS pic_input, "
                                                queryInsert &= " 'NOT CHECKED' AS status_check"
                                                queryInsert &= " FROM mt_master_machine "
                                                queryInsert &= " WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
                                                queryInsert &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' AND part_name = '" & C_PART_NAME.Text & "' "
                                                queryInsert &= " AND method_range_from = '" & T_METHOD_FROM.Text & "' AND method_range_to = '" & T_METHOD_TO.Text & "' "
                                                queryInsert &= " AND method_range_unit = '" & T_METHOD_UNIT.Text & "' "
                                                ExecuteQueryTDF(queryInsert)
                                            End If
                                        End Using
                                        con2.Close()
                                    End Using
                                End Using

                                L_REMARK.Clear()
                                T_REMARK.Clear()
                                L_REMARK.Visible = "False"
                                T_REMARK.Visible = "False"
                            Else
                                Dim queryInsert As String = String.Empty
                                queryInsert &= "INSERT INTO mt_checked_machine (date, line_cd, line_desc, machine_cd, machine_name, part_name, part_cd, unit_name, "
                                queryInsert &= " method_part, method_range_from, method_range_to, method_range_unit, reason, result, created_at, status, pic_input, status_check) "

                                queryInsert &= "SELECT CAST(GETDATE() AS DATE) AS date, line_cd, line_desc, machine_cd, machine_name, part_name, part_cd, unit_name, "
                                queryInsert &= " method_part, method_range_from, method_range_to, method_range_unit, '" & T_REMARK.Text & "' AS reason, "
                                queryInsert &= " '" & T_METHOD_CHECK.Text & "' AS result, GETDATE() AS created_at, 'NG' AS status, '" & T_PIC_NIK.Text & "' AS pic_input, "
                                queryInsert &= " 'NOT CHECKED' AS status_check"
                                queryInsert &= " FROM mt_master_machine "
                                queryInsert &= " WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
                                queryInsert &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' AND part_name = '" & C_PART_NAME.Text & "' "
                                queryInsert &= " AND method_range_from = '" & T_METHOD_FROM.Text & "' AND method_range_to = '" & T_METHOD_TO.Text & "' "
                                queryInsert &= " AND method_range_unit = '" & T_METHOD_UNIT.Text & "' "

                                ExecuteQueryTDF(queryInsert)

                                WD.PB_WARNING.Image = CheckSheetSystem.My.Resources.Resources.checked
                                WD.L_WARNING.Text = "data already saved!"
                                WD.B_BACK.Text = "OK"
                                WD.L_WARNING.Text = WD.L_WARNING.Text.ToUpper()
                                WD.BackColor = Color.LimeGreen
                                WD.PB_WARNING.BackColor = Color.White
                                WD.Show()
                                WD.PB_WARNING.Select()
                            End If
                        Else
                            'buat method part
                            If C_METHOD_CHECK.Text = "OK" Then
                                Dim querycheck As String = String.Empty
                                querycheck &= "SELECT * FROM mt_checked_machine "
                                querycheck &= " WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
                                querycheck &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' AND part_name = '" & C_PART_NAME.Text & "' "
                                querycheck &= " AND method_part = '" & T_METHOD_NAME.Text & "' AND status = 'OK' AND date = CAST(GETDATE() AS DATE)"

                                Using con2 As New SqlConnection(My.Settings.TDF)
                                    Using cmd As New SqlCommand(querycheck, con2)
                                        con2.Open()
                                        Using reader As SqlDataReader = cmd.ExecuteReader
                                            If reader.HasRows Then
                                                WD.PB_WARNING.Image = CheckSheetSystem.My.Resources.Resources.warning
                                                WD.L_WARNING.Text = "data already exist!"
                                                WD.B_BACK.Text = "OK"
                                                WD.L_WARNING.Text = WD.L_WARNING.Text.ToUpper()
                                                WD.BackColor = Color.Gold
                                                WD.PB_WARNING.BackColor = Color.White
                                                WD.Show()
                                                WD.PB_WARNING.Select()
                                            Else
                                                Dim queryInsert As String = String.Empty
                                                queryInsert &= "INSERT INTO mt_checked_machine (date, line_cd, line_desc, machine_cd, machine_name, part_name, part_cd, unit_name, "
                                                queryInsert &= " method_part, method_range_from, method_range_to, method_range_unit, reason, result, created_at, status, pic_input, status_check) "

                                                queryInsert &= "SELECT CAST(GETDATE() AS DATE) AS date, line_cd, line_desc, machine_cd, machine_name, part_name, part_cd, unit_name, "
                                                queryInsert &= " method_part, method_range_from, method_range_to, method_range_unit, '" & T_REMARK.Text & "' AS reason, "
                                                queryInsert &= " '" & C_METHOD_CHECK.Text & "' AS result, GETDATE() AS created_at, 'OK' AS status, '" & T_PIC_NIK.Text & "' AS pic_input, "
                                                queryInsert &= " 'NOT CHECKED' AS status_check"
                                                queryInsert &= " FROM mt_master_machine "
                                                queryInsert &= " WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
                                                queryInsert &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' AND part_name = '" & C_PART_NAME.Text & "' "
                                                queryInsert &= " AND method_part = '" & T_METHOD_NAME.Text & "' "

                                                ExecuteQueryTDF(queryInsert)

                                                WD.PB_WARNING.Image = CheckSheetSystem.My.Resources.Resources.checked
                                                WD.L_WARNING.Text = "data already saved!"
                                                WD.B_BACK.Text = "OK"
                                                WD.L_WARNING.Text = WD.L_WARNING.Text.ToUpper()
                                                WD.BackColor = Color.LimeGreen
                                                WD.PB_WARNING.BackColor = Color.White
                                                WD.Show()
                                                WD.PB_WARNING.Select()

                                                L_REMARK.Clear()
                                                T_REMARK.Clear()
                                                L_REMARK.Visible = "False"
                                                T_REMARK.Visible = "False"
                                            End If
                                        End Using
                                        con2.Close()
                                    End Using
                                End Using
                            Else
                                Dim queryInsert As String = String.Empty
                                queryInsert &= "INSERT INTO mt_checked_machine (date, line_cd, line_desc, machine_cd, machine_name, part_name, part_cd, unit_name, "
                                queryInsert &= " method_part, method_range_from, method_range_to, method_range_unit, reason, result, created_at, status, pic_input, status_check) "

                                queryInsert &= "SELECT CAST(GETDATE() AS DATE) AS date, line_cd, line_desc, machine_cd, machine_name, part_name, part_cd, unit_name, "
                                queryInsert &= " method_part, method_range_from, method_range_to, method_range_unit, '" & T_REMARK.Text & "' AS reason, "
                                queryInsert &= " '" & C_METHOD_CHECK.Text & "' AS result, GETDATE() AS created_at, 'NG' AS status, '" & T_PIC_NIK.Text & "' AS pic_input, "
                                queryInsert &= " 'NOT CHECKED' AS status_check"
                                queryInsert &= " FROM mt_master_machine "
                                queryInsert &= " WHERE machine_name = '" & C_MACHINE_NAME.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "' "
                                queryInsert &= " AND line_cd = '" & T_LINE_CD.Text & "' AND unit_name = '" & C_UNIT_NAME.Text & "' AND part_name = '" & C_PART_NAME.Text & "' "
                                queryInsert &= " AND method_part = '" & T_METHOD_NAME.Text & "' "

                                ExecuteQueryTDF(queryInsert)

                                WD.PB_WARNING.Image = CheckSheetSystem.My.Resources.Resources.checked
                                WD.L_WARNING.Text = "data already saved!"
                                WD.B_BACK.Text = "OK"
                                WD.L_WARNING.Text = WD.L_WARNING.Text.ToUpper()
                                WD.BackColor = Color.LimeGreen
                                WD.PB_WARNING.BackColor = Color.White
                                WD.Show()
                                WD.PB_WARNING.Select()
                            End If
                        End If
                    Next
                End Using
            End Using
        End Using
    End Sub

    Private Sub B_CLEAR_Click(sender As Object, e As EventArgs) Handles B_CLEAR.Click

        C_METHOD_CHECK.Visible = "True"
        T_LINE_CD.Clear()
        T_LINE_NAME.Clear()
        T_MACHINE_CD.Clear()
        T_METHOD_FROM.Clear()
        T_METHOD_TO.Clear()
        T_METHOD_UNIT.Clear()
        T_METHOD_CHECK.Clear()
        T_METHOD_NAME.Clear()
        T_REMARK.Clear()
        C_MACHINE_NAME.SelectedIndex = -1
        C_UNIT_NAME.SelectedIndex = -1
        C_PART_NAME.SelectedIndex = -1
        C_METHOD_CHECK.SelectedIndex = -1
    End Sub

    Private Sub B_BACK_Click(sender As Object, e As EventArgs) Handles B_BACK.Click
        Me.Close()
    End Sub

    Private Sub C_METHOD_CHECK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_METHOD_CHECK.SelectedIndexChanged
        If C_METHOD_CHECK.Text = "NOT OK" Then
            L_REMARK.Visible = "True"
            L_REMARK.Text = "Remark"
            T_REMARK.Visible = "True"
        ElseIf C_METHOD_CHECK.Text = "OK" Then
            L_REMARK.Visible = "False"
            T_REMARK.Visible = "False"
            T_REMARK.Clear()
        End If
    End Sub

    Private Sub T_METHOD_CHECK_TextChanged(sender As Object, e As EventArgs) Handles T_METHOD_CHECK.TextChanged
        If T_METHOD_CHECK.Text >= T_METHOD_FROM.Text And T_METHOD_CHECK.Text <= T_METHOD_TO.Text Then
            L_REMARK.Visible = "False"
            T_REMARK.Visible = "False"
            T_REMARK.Clear()
        Else
            L_REMARK.Visible = "True"
            L_REMARK.Text = "Remark"
            T_REMARK.Visible = "True"
        End If
    End Sub
End Class