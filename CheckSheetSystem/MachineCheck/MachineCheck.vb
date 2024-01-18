Imports System.Data.Common
Imports System.Data.SqlClient

Public Class MachineCheck
    Private selectedRowIndex As Integer = -1

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
        End If
    End Sub

    Private Sub MachineCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLine()
    End Sub

    Public Sub LoadMachineCheck()
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
        query &= "WHERE rk = 1 AND [LINE CD] = '" & T_LINE_CD.Text & "' AND [LINE DESC] = '" & T_LINE_NAME.Text & "' "
        query &= "AND status_check = 'NOT CHECKED' AND date = CAST(GETDATE() AS DATE)"
        If Not String.IsNullOrEmpty(T_MACHINE_CD.Text) Then
            query &= "AND [MACHINE CD] = '" & T_MACHINE_CD.Text & "' AND [MACHINE NAME] = '" & C_MACHINE_NAME.Text & "' "
        End If

        Dim dt As DataTable = GetDataTDF(query)
        DG_CHECK.DataSource = dt

        DG_CHECK.Columns("rk").Visible = False
        DG_CHECK.Columns("reason").Visible = False
        DG_CHECK.Columns("date").Visible = False
        DG_CHECK.Columns("status").Visible = False
        DG_CHECK.Columns("id").Visible = False

        Dim columnExists As Boolean = False
        For Each column As DataGridViewColumn In DG_CHECK.Columns
            If column.Name = "checkBoxColumn" Then
                columnExists = True
                Exit For
            End If
        Next

        ' If checkBoxColumn doesn't exist, add it
        If Not columnExists Then
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = "Check"
            checkBoxColumn.Name = "checkBoxColumn"
            DG_CHECK.Columns.Insert(0, checkBoxColumn)
        End If
    End Sub
    Private Sub DG_CHECK_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_CHECK.CellClick
        ' Check if the clicked cell is not a header cell
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Store the selected row index
            selectedRowIndex = e.RowIndex
        End If
    End Sub
    Private Sub B_SEARCH_Click(sender As Object, e As EventArgs) Handles B_SEARCH.Click
        LoadMachineCheck()
    End Sub

    Private Sub B_SUBMIT_Click(sender As Object, e As EventArgs) Handles B_SUBMIT.Click
        If selectedRowIndex >= 0 AndAlso selectedRowIndex < DG_CHECK.Rows.Count Then
            Dim checkcolumn As String = DG_CHECK.Item(0, selectedRowIndex).Value
            Dim reason As String = DG_CHECK.Item(2, selectedRowIndex).Value
            Dim date_input As String = DG_CHECK.Item(3, selectedRowIndex).Value
            Dim status_input As String = DG_CHECK.Item(4, selectedRowIndex).Value
            Dim id_input As String = DG_CHECK.Item(5, selectedRowIndex).Value
            Dim line_cd As String = DG_CHECK.Item(6, selectedRowIndex).Value
            Dim line_desc As String = DG_CHECK.Item(7, selectedRowIndex).Value
            Dim machine_cd As String = DG_CHECK.Item(8, selectedRowIndex).Value
            Dim machine_name As String = DG_CHECK.Item(9, selectedRowIndex).Value
            Dim unit_name As String = DG_CHECK.Item(10, selectedRowIndex).Value
            Dim part_cd As String = DG_CHECK.Item(11, selectedRowIndex).Value
            Dim part_name As String = DG_CHECK.Item(12, selectedRowIndex).Value
            Dim method_part As String = DG_CHECK.Item(13, selectedRowIndex).Value
            Dim method_range_from As String = DG_CHECK.Item(14, selectedRowIndex).Value
            Dim method_range_to As String = DG_CHECK.Item(15, selectedRowIndex).Value
            Dim method_range_unit As String = DG_CHECK.Item(16, selectedRowIndex).Value
            Dim result_check As String = DG_CHECK.Item(17, selectedRowIndex).Value
            Dim remark As String = DG_CHECK.Item(18, selectedRowIndex).Value
            Dim pic_input As String = DG_CHECK.Item(19, selectedRowIndex).Value

            Dim DPC As New DialogPICCheck
            DPC.checkcolumn = checkcolumn
            DPC.reason = reason
            DPC.date_input = date_input
            DPC.status_input = status_input
            DPC.id_input = id_input
            DPC.line_cd = line_cd
            DPC.line_desc = line_desc
            DPC.machine_cd = machine_cd
            DPC.machine_name = machine_name
            DPC.unit_name = unit_name
            DPC.part_cd = part_cd
            DPC.part_name = part_name
            DPC.method_part = method_part
            DPC.method_range_from = method_range_from
            DPC.method_range_to = method_range_to
            DPC.method_range_unit = method_range_unit
            DPC.result_check = result_check
            DPC.remark = remark
            DPC.pic_input = pic_input
            DPC.Show()
        End If
    End Sub

    Private Sub B_REFRESH_Click(sender As Object, e As EventArgs) Handles B_REFRESH.Click
        LoadMachineCheck()
    End Sub

    Private Sub DG_CHECK_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_CHECK.CellContentDoubleClick
        Dim id_input As String = DG_CHECK.Item(5, e.RowIndex).Value
        Dim line_cd As String = DG_CHECK.Item(6, e.RowIndex).Value
        Dim line_desc As String = DG_CHECK.Item(7, e.RowIndex).Value
        Dim machine_cd As String = DG_CHECK.Item(8, e.RowIndex).Value
        Dim machine_name As String = DG_CHECK.Item(9, e.RowIndex).Value
        Dim unit_name As String = DG_CHECK.Item(10, e.RowIndex).Value
        Dim part_cd As String = DG_CHECK.Item(11, e.RowIndex).Value
        Dim part_name As String = DG_CHECK.Item(12, e.RowIndex).Value
        Dim method_part As String = DG_CHECK.Item(13, e.RowIndex).Value
        Dim method_range_from As String = DG_CHECK.Item(14, e.RowIndex).Value
        Dim method_range_to As String = DG_CHECK.Item(15, e.RowIndex).Value
        Dim method_range_unit As String = DG_CHECK.Item(16, e.RowIndex).Value
        Dim result_check As String = DG_CHECK.Item(17, e.RowIndex).Value
        Dim remark As String = DG_CHECK.Item(18, e.RowIndex).Value
        Dim pic_input As String = DG_CHECK.Item(19, e.RowIndex).Value

        Dim DUR As New DialogUpdateReason
        DUR.id_input = id_input
        DUR.line_cd = line_cd
        DUR.line_desc = line_desc
        DUR.machine_cd = machine_cd
        DUR.machine_name = machine_name
        DUR.unit_name = unit_name
        DUR.part_cd = part_cd
        DUR.part_name = part_name
        DUR.method_part = method_part
        DUR.method_range_from = method_range_from
        DUR.method_range_to = method_range_to
        DUR.method_range_unit = method_range_unit
        DUR.result_check = result_check
        DUR.remark = remark
        DUR.pic_input = pic_input

        DUR.Show()
    End Sub

    Public Sub UpdateDataGridView(dataTable As DataTable)
        DG_CHECK.DataSource = dataTable

        DG_CHECK.Columns("rk").Visible = False
        DG_CHECK.Columns("reason").Visible = False
        DG_CHECK.Columns("date").Visible = False
        DG_CHECK.Columns("status").Visible = False
        DG_CHECK.Columns("id").Visible = False

        Dim columnExists As Boolean = False
        For Each column As DataGridViewColumn In DG_CHECK.Columns
            If column.Name = "checkBoxColumn" Then
                columnExists = True
                Exit For
            End If
        Next

        ' If checkBoxColumn doesn't exist, add it
        If Not columnExists Then
            Dim checkBoxColumn As New DataGridViewCheckBoxColumn()
            checkBoxColumn.HeaderText = "Check"
            checkBoxColumn.Name = "checkBoxColumn"
            DG_CHECK.Columns.Insert(0, checkBoxColumn)
        End If
    End Sub
End Class