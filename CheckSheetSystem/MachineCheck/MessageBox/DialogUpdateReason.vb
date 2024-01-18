Imports System.Data.SqlClient

Public Class DialogUpdateReason
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
    Private Sub B_UPDATE_Click(sender As Object, e As EventArgs) Handles B_UPDATE.Click

        Dim queryUpdate As String = String.Empty
        queryUpdate &= "UPDATE mt_checked_machine SET reason = '" & T_REMARK.Text & "' "
        queryUpdate &= "WHERE id = '" & id_input & "' "
        'queryUpdate &= "WHERE line_cd = '" & line_cd & "' AND line_desc = '" & line_desc & "' "
        'queryUpdate &= "AND machine_cd = '" & machine_cd & "' AND machine_name = '" & machine_name & "' "
        'queryUpdate &= "AND unit_name = '" & unit_name & "' "
        'queryUpdate &= "AND part_cd = '" & part_cd & "' AND part_name = '" & part_name & "' "
        'queryUpdate &= "AND method_part = '" & method_part & "' "
        'queryUpdate &= "AND method_range_from = '" & method_range_from & "' AND method_range_to = '" & method_range_to & "' AND method_range_unit = '" & method_range_unit & "' "
        'queryUpdate &= "AND result = '" & result_check & "' AND reason = '" & remark & "' AND pic_input = '" & pic_input & "' "

        ExecuteQueryTDF(queryUpdate)
        MessageBox.Show("Data berhasil di update!")

        Machine_His()

        Dim machinecheckform As MachineCheck = Application.OpenForms("MachineCheck")
        Dim query As String = String.Empty

        query &= "SELECT * FROM ("
        query &= "SELECT RANK() OVER (PARTITION BY machine_cd, line_cd, part_name ORDER BY created_at DESC) AS rk, reason, date, status, "
        query &= " id, line_cd AS 'LINE CD', line_desc AS 'LINE DESC', "
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
        query &= " pic_input AS 'PIC INPUT', status_check "
        query &= "FROM mt_checked_machine) a "
        query &= "WHERE rk = 1 AND [LINE CD] = '" & line_cd & "' AND [LINE DESC] = '" & line_desc & "' "
        query &= "AND status_check = 'NOT CHECKED' AND date = CAST(GETDATE() AS DATE)"
        If Not String.IsNullOrEmpty(machine_cd) Then
            query &= "AND [MACHINE CD] = '" & machine_cd & "' AND [MACHINE NAME] = '" & machine_name & "' "
        End If

        Dim dt As New DataTable
        Using con2 As New SqlConnection(My.Settings.TDF)
            Using adapter As New SqlDataAdapter(query, con2)
                adapter.Fill(dt)
            End Using
        End Using

        machinecheckform.UpdateDataGridView(dt)

        Me.Close()
    End Sub

    Private Sub DialogUpdateReason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T_REMARK.Text = remark
        T_REMARK.Focus()
        Machine_His()
    End Sub

    Private Sub B_CANCEL_Click(sender As Object, e As EventArgs) Handles B_CANCEL.Click
        Me.Close()
    End Sub

    Sub Machine_His()
        Dim query As String = String.Empty

        query &= "SELECT date AS DATE, line_cd AS 'LINE CD', line_desc AS 'LINE DESC', "
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
    End Sub
End Class