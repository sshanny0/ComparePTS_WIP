Imports System.Data.SqlClient

Public Class DialogUpdateDetail

    Public Property LineCode As String
    Public Property MachineCode As String
    Public Property UnitName As String
    Public Property PartName As String
    Public Property MethodName As String
    Public Property MethodPart As String
    Public Property MethodRangeFrom As String
    Public Property MethodRangeTo As String
    Public Property MethodRangeUnit As String

    Private Sub B_UPDATE_Click(sender As Object, e As EventArgs) Handles B_UPDATE.Click
        Dim query As String = String.Empty
        query &= " UPDATE mt_master_machine SET part_name = '" & T_PART.Text & "', method_part = '" & T_METHOD.Text & "', "
        query &= " method_range_from = '" & T_FROM.Text & "', method_range_to = '" & T_TO.Text & "', method_range_unit = '" & T_UNIT.Text & "' "
        query &= " WHERE line_cd = '" & LineCode & "' AND machine_cd = '" & MachineCode & "' AND unit_name = '" & UnitName & "' "
        query &= " AND part_name = '" & PartName & "' AND method_part = '" & MethodPart & "' "
        query &= " AND method_range_from = '" & MethodRangeFrom & "' AND method_range_to = '" & MethodRangeTo & "' AND method_range_unit = '" & MethodRangeUnit & "' "

        ExecuteQueryTDF(query)

        MsgBox("SUCCESSFULLY UPDATED!", MsgBoxStyle.Information, "SUCCESS")

        Dim masterForm As MasterMachine = Application.OpenForms("MasterMachine")
        Dim querydgv As String = String.Empty
        querydgv &= " SELECT "
        querydgv &= " line_cd AS 'LINE CD', "
        querydgv &= " machine_cd AS 'MACHINE CD', "
        querydgv &= " machine_name AS 'MACHINE NAME', "
        querydgv &= " unit_name AS 'UNIT', "
        querydgv &= " part_cd AS 'PART CODE', "
        querydgv &= " part_name AS 'PART FOR CHECK', "
        querydgv &= " method_part AS 'METHOD PART', "
        querydgv &= " method_range_from AS 'METHOD RANGE (FROM)', "
        querydgv &= " method_range_to AS 'METHOD RANGE (TO)', "
        querydgv &= " method_range_unit AS 'METHOD RANGE (UNIT)' "
        querydgv &= " FROM mt_master_machine "
        querydgv &= " ORDER BY line_cd "

        Dim dt As New DataTable
        Using con2 As New SqlConnection(My.Settings.TDF)
            Using adapter As New SqlDataAdapter(querydgv, con2)
                adapter.Fill(dt)
            End Using
        End Using

        masterForm.UpdateDataGridView(dt)

        Me.Close()
        Application.OpenForms("DialogUpdateDelete").Close()
    End Sub

    Private Sub DialogUpdateDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MethodPart = "" Then
            L_METHOD_1.Visible = "False"
            T_METHOD.Visible = "False"
        Else
            L_METHOD_RANGE.Visible = "False"
            L_METHOD_FROM_RANGE.Visible = "False"
            T_FROM.Visible = "False"
            L_METHOD_TO_RANGE.Visible = "False"
            T_TO.Visible = "False"
            L_METHOD_UNIT_RANGE.Visible = "False"
            T_UNIT.Visible = "False"
        End If

        T_PART.Text = PartName
        T_METHOD.Text = MethodPart

        T_FROM.Text = MethodRangeFrom
        T_TO.Text = MethodRangeTo
        T_UNIT.Text = MethodRangeUnit

        T_PART.Focus()
    End Sub

    Private Sub B_CANCEL_Click(sender As Object, e As EventArgs) Handles B_CANCEL.Click
        Me.Close()
    End Sub
End Class