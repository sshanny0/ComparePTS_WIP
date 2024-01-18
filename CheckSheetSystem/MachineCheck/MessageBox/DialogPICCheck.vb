Imports System.Data.SqlClient

Public Class DialogPICCheck
    Public Property checkcolumn As String
    Public Property reason As String
    Public Property date_input As String
    Public Property status_input As String
    Public Property id_input As String
    Public Property line_cd As String
    Public Property line_desc As String
    Public Property machine_cd As String
    Public Property machine_name As String
    Public Property unit_name As String
    Public Property part_cd As String
    Public Property part_name As String
    Public Property method_part As String
    Public Property method_range_from As String
    Public Property method_range_to As String
    Public Property method_range_unit As String
    Public Property result_check As String
    Public Property remark As String
    Public Property pic_input As String

    Function ExecuteQueryTDFWithOutput(ByVal query As String) As Integer
        Dim insertedId As Integer = 0
        Using connection As New SqlConnection(My.Settings.TDF)
            connection.Open()
            Using cmd As New SqlCommand(query, connection)
                ' Execute the query
                insertedId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
        Return insertedId
    End Function

    Private Sub B_SUBMIT_OK_Click(sender As Object, e As EventArgs) Handles B_SUBMIT_OK.Click
        Dim queryuser As String = String.Empty
        queryuser &= " SELECT nik FROM mt_master_user WHERE rfid = '" & T_RFID.Text & "' "
        Dim dt As DataTable = GetDataTDF(queryuser)
        If dt.Rows.Count > 0 Then
            T_PIC_NIK.Text = dt.Rows(0)(0)
        End If

        If MachineCheck.DG_CHECK.Rows.Count > 0 Then
            For Each row As DataGridViewRow In MachineCheck.DG_CHECK.Rows
                Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("checkBoxColumn").Value)
                If isSelected Then
                    Dim date_input_i As String = row.Cells("date").Value
                    Dim status_input_i As String = row.Cells("status").Value
                    Dim id_input_i As String = row.Cells("id").Value
                    Dim line_cd_i As String = row.Cells("LINE CD").Value
                    Dim line_desc_i As String = row.Cells("LINE DESC").Value
                    Dim machine_cd_i As String = row.Cells("MACHINE CD").Value
                    Dim machine_name_i As String = row.Cells("MACHINE NAME").Value
                    Dim part_name_i As String = row.Cells("PART FOR CHECK").Value
                    Dim unit_name_i As String = row.Cells("UNIT").Value
                    Dim method_part_i As String = row.Cells("METHOD PART").Value
                    Dim reason_i As String = row.Cells("REMARK").Value
                    Dim method_range_from_i As String = row.Cells("METHOD RANGE (FROM)").Value
                    Dim method_range_to_i As String = row.Cells("METHOD RANGE (TO)").Value
                    Dim method_range_unit_i As String = row.Cells("METHOD RANGE (UNIT)").Value
                    Dim result_i As String = row.Cells("RESULT").Value
                    Dim part_cd_i As String = row.Cells("PART CODE").Value
                    Dim pic_input_i As String = row.Cells("PIC INPUT").Value

                    ''UPDATE STATUS_CHECK
                    Dim updateCheck As String = String.Empty
                    updateCheck &= "UPDATE mt_checked_machine SET status_check = 'CHECKED' "
                    updateCheck &= "WHERE line_cd = '" & line_cd_i & "' AND line_desc = '" & line_desc_i & "' "
                    updateCheck &= "AND machine_cd = '" & machine_cd_i & "' AND machine_name = '" & machine_name_i & "' "
                    updateCheck &= "AND part_name = '" & part_name_i & "' AND unit_name = '" & unit_name_i & "' AND method_part = '" & method_part_i & "' "
                    updateCheck &= "AND method_range_from = '" & method_range_from_i & "' AND method_range_to = '" & method_range_to_i & "' "
                    updateCheck &= "AND method_range_unit = '" & method_range_unit_i & "' "
                    ExecuteQueryTDF(updateCheck)

                    'INSERT TO DATA FINAL
                    Dim queryInsert As String = String.Empty
                    queryInsert &= "INSERT INTO mt_checked_machine_final (line_cd, line_desc, machine_cd, machine_name, part_name, unit_name, method_part, reason, date_input, created_at, "
                    queryInsert &= "method_range_from, method_range_to, method_range_unit, result, part_cd, status, pic_input, pic_check, status_check, id_check) "
                    queryInsert &= "VALUES('" & line_cd_i & "', '" & line_desc_i & "', '" & machine_cd_i & "', '" & machine_name_i & "', '" & part_name_i & "', '" & unit_name_i & "', "
                    queryInsert &= "'" & method_part_i & "', '" & reason_i & "', CONVERT(DATE, '" & date_input_i & "', 104), "
                    queryInsert &= "GETDATE(), '" & method_range_from_i & "', '" & method_range_to_i & "', '" & method_range_unit_i & "', '" & result_i & "', "
                    queryInsert &= "'" & part_cd_i & "', '" & status_input_i & "', "
                    queryInsert &= "'" & pic_input_i & "', '" & T_PIC_NIK.Text & "', 'CHECKED', '" & id_input_i & "') "
                    queryInsert &= "SELECT SCOPE_IDENTITY()"
                    'queryInsert &= "WHERE line_cd = '" & line_cd & "' AND line_desc = '" & line_desc & "' "
                    'queryInsert &= "AND machine_cd = '" & machine_cd & "' AND machine_name = '" & machine_name & "' "
                    'ExecuteQueryTDF(queryInsert)
                    Dim insertedId As Integer = ExecuteQueryTDFWithOutput(queryInsert)

                    'INSERT PIC LOG'
                    Dim queryLog As String = String.Empty
                    queryLog &= "INSERT INTO mt_log_user (nik, name, rfid, created_at, menu, id_checked_final)"
                    queryLog &= " SELECT nik, name, rfid, GETDATE(), 'MACHINE CHECK' AS menu, '" & insertedId & "' AS id_checked_final "
                    queryLog &= " FROM mt_master_user WHERE rfid = '" & T_RFID.Text & "'"
                    ExecuteQueryTDF(queryLog)
                End If
            Next
        End If
        MessageBox.Show("Data berhasil di input!")
        Me.Close()
    End Sub

    Private Sub B_CANCEL_Click(sender As Object, e As EventArgs) Handles B_CANCEL.Click
        Me.Close()
    End Sub

    Private Sub DialogPICCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = String.Empty

        query &= "SELECT line_cd AS 'LINE CD', line_desc AS 'LINE DESC', "
        query &= " machine_cd AS 'MACHINE CD', "
        query &= " machine_name AS 'MACHINE NAME', "
        query &= " unit_name AS 'UNIT', "
        query &= " part_cd AS 'PART CODE', "
        query &= " part_name AS 'PART FOR CHECK', "
        query &= " method_part AS 'METHOD PART', "
        query &= " method_range_from AS 'METHOD RANGE (FROM)', "
        query &= " method_range_to AS 'METHOD RANGE (TO)', "
        query &= " method_range_unit AS 'METHOD RANGE (UNIT)', "
        query &= " result AS RESULT, "
        query &= " reason AS REMARK, "
        query &= " pic_input AS 'PIC INPUT' "
        query &= "FROM mt_checked_machine "
        query &= "WHERE line_cd = '" & line_cd & "' AND line_desc = '" & line_desc & "' "
        query &= "AND machine_cd = '" & machine_cd & "' AND machine_name = '" & machine_name & "' "
        query &= "AND part_name = '" & part_name & "' AND unit_name = '" & unit_name & "' AND method_part = '" & method_part & "' "
        query &= "AND method_range_from = '" & method_range_from & "' AND method_range_to = '" & method_range_to & "' "
        query &= "AND method_range_unit = '" & method_range_unit & "' "
        query &= "ORDER BY created_at DESC"

        Dim dt As DataTable = GetDataTDF(query)
        DG_HIS_CHECK.DataSource = dt

        T_RFID.Focus()
    End Sub
End Class