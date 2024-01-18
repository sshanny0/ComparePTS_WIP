Imports System.Data.SqlClient

Public Class DialogDeleteDetail
    Public Property LineCode As String
    Public Property MachineCode As String
    Public Property UnitName As String
    Public Property PartName As String
    Public Property MethodName As String
    Public Property MethodPart As String
    Public Property MethodRangeFrom As String
    Public Property MethodRangeTo As String
    Public Property MethodRangeUnit As String
    Private Sub B_DELETE_UNIT_Click(sender As Object, e As EventArgs) Handles B_DELETE_UNIT.Click
        TXT_MAIN.SendToBack()
        TXT_INFO_UNIT.BringToFront()
        B_YES_UNIT.BringToFront()
        B_NO_UNIT.BringToFront()
        TXT_INFO_UNIT.Text = "

        ARE YOU SURE YOU WANT TO DELETE " & LineCode & ", MACHINE " & MachineCode & ", UNIT " & UnitName & ""
    End Sub


    Private Sub B_YES_UNIT_Click(sender As Object, e As EventArgs) Handles B_YES_UNIT.Click
        Dim querySelect As String = String.Empty
        'querySelect &= "SELECT * FROM mt_checked_machine "
        'querySelect &= "WHERE line_cd = '" & LineCode & "' AND machine_cd = '" & MachineCode & "' AND unit_name = '" & UnitName & "'"
        querySelect &= "SELECT * FROM mt_master_machine "
        querySelect &= "WHERE line_cd = '" & LineCode & "' AND machine_cd = '" & MachineCode & "' AND unit_name = '" & UnitName & "' "
        querySelect &= "AND part_name = '" & PartName & "' AND method_part = '" & MethodPart & "' "
        querySelect &= "AND method_range_from = '" & MethodRangeFrom & "' AND method_range_to = '" & MethodRangeTo & "' AND method_range_unit = '" & MethodRangeUnit & "' "


        Dim dt2 As New DataTable()
        Using con1 As New SqlConnection(My.Settings.TDF)
            con1.Open()
            Using adapter As New SqlDataAdapter(querySelect, con1)
                adapter.Fill(dt2)
            End Using
            con1.Close()
        End Using

        For Each row As DataRow In dt2.Rows
            Dim line_cd As String = row("line_cd").ToString()
            Dim line_desc As String = row("line_desc").ToString()
            Dim machine_cd As String = row("machine_cd").ToString()
            Dim machine_name As String = row("machine_name").ToString()
            Dim part_name As String = row("part_name").ToString()
            Dim unit_name As String = row("unit_name").ToString()
            Dim method_part As String = row("method_part").ToString()
            Dim status As String = row("status").ToString()
            Dim reason As String = row("reason").ToString()
            Dim part_cd As String = row("part_cd").ToString()
            Dim method_range_from As String = row("method_range_from").ToString()
            Dim method_range_to As String = row("method_range_to").ToString()
            Dim method_range_unit As String = row("method_range_unit").ToString()
            Dim pic_input As String = row("pic_input").ToString()
            Dim date_his As String = row("created_at").ToString()

            Dim queryInsert As String = String.Empty
            queryInsert &= "INSERT INTO mt_master_machine_his (line_cd, line_desc, machine_cd, machine_name, part_name, unit_name, method_part, date_his, "
            queryInsert &= " method_range_from, method_range_to, method_range_unit, part_cd, pic_input, status_delete, created_at) VALUES "
            queryInsert &= " ('" & line_cd & "', '" & line_desc & "', '" & machine_cd & "', '" & machine_name & "', "
            queryInsert &= " '" & part_name & "', '" & unit_name & "', '" & method_part & "', '" & date_his & "', '" & method_range_from & "', '" & method_range_to & "', "
            queryInsert &= " '" & method_range_unit & "', '" & part_cd & "', '" & pic_input & "', 'DELETE UNIT', GETDATE()) "

            ExecuteQueryTDF(queryInsert)
        Next

        'Delete Master
        Dim queryDelete As String = String.Empty
        queryDelete &= " DELETE mt_master_machine WHERE  line_cd = '" & LineCode & "' AND machine_cd = '" & MachineCode & "' AND unit_name = '" & UnitName & "' "

        ExecuteQueryTDF(queryDelete)

        MsgBox("UNIT SUCCESSFULLY DELETED!", MsgBoxStyle.Information, "SUCCESS")

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

    Private Sub B_NO_UNIT_Click(sender As Object, e As EventArgs) Handles B_NO_UNIT.Click
        TXT_INFO_UNIT.Clear()
        TXT_MAIN.BringToFront()
        TXT_INFO_UNIT.SendToBack()
        B_YES_UNIT.SendToBack()
        B_NO_UNIT.SendToBack()
    End Sub

    Private Sub B_DELETE_PART_Click(sender As Object, e As EventArgs) Handles B_DELETE_PART.Click
        TXT_MAIN.SendToBack()
        TXT_INFO_PART.BringToFront()
        B_YES_PART.BringToFront()
        B_NO_PART.BringToFront()
        TXT_INFO_PART.Text = "

    ARE YOU SURE YOU WANT TO DELETE " & LineCode & ", MACHINE " & MachineCode & ", UNIT " & UnitName & ", PART " & PartName & ", METHOD " & MethodName & " "
    End Sub

    Private Sub B_YES_PART_Click(sender As Object, e As EventArgs) Handles B_YES_PART.Click
        Dim querySelect As String = String.Empty
        querySelect &= "SELECT * FROM mt_master_machine "
        querySelect &= "WHERE line_cd = '" & LineCode & "' AND machine_cd = '" & MachineCode & "' AND unit_name = '" & UnitName & "' "
        querySelect &= "AND part_name = '" & PartName & "' AND method_part = '" & MethodPart & "' "
        querySelect &= "AND method_range_from = '" & MethodRangeFrom & "' AND method_range_to = '" & MethodRangeTo & "' AND method_range_unit = '" & MethodRangeUnit & "' "

        Dim dt2 As New DataTable()
        Using con1 As New SqlConnection(My.Settings.TDF)
            con1.Open()
            Using adapter As New SqlDataAdapter(querySelect, con1)
                adapter.Fill(dt2)
            End Using
            con1.Close()
        End Using

        For Each row As DataRow In dt2.Rows
            Dim line_cd As String = row("line_cd").ToString()
            Dim line_desc As String = row("line_desc").ToString()
            Dim machine_cd As String = row("machine_cd").ToString()
            Dim machine_name As String = row("machine_name").ToString()
            Dim part_name As String = row("part_name").ToString()
            Dim unit_name As String = row("unit_name").ToString()
            Dim method_part As String = row("method_part").ToString()
            Dim status As String = row("status").ToString()
            Dim reason As String = row("reason").ToString()
            Dim part_cd As String = row("part_cd").ToString()
            Dim method_range_from As String = row("method_range_from").ToString()
            Dim method_range_to As String = row("method_range_to").ToString()
            Dim method_range_unit As String = row("method_range_unit").ToString()
            Dim pic_input As String = row("pic_input").ToString()
            Dim date_his As String = row("created_at").ToString()

            Dim queryInsert As String = String.Empty
            queryInsert &= "INSERT INTO mt_master_machine_his (line_cd, line_desc, machine_cd, machine_name, part_name, unit_name, method_part, date_his, "
            queryInsert &= " method_range_from, method_range_to, method_range_unit, part_cd, pic_input, status_delete, created_at) VALUES "
            queryInsert &= " ('" & line_cd & "', '" & line_desc & "', '" & machine_cd & "', '" & machine_name & "', "
            queryInsert &= " '" & part_name & "', '" & unit_name & "', '" & method_part & "', '" & date_his & "', '" & method_range_from & "', '" & method_range_to & "', "
            queryInsert &= " '" & method_range_unit & "', '" & part_cd & "', '" & pic_input & "', 'DELETE PART', GETDATE()) "

            ExecuteQueryTDF(queryInsert)
        Next

        'DELETE MASTER
        Dim query As String = String.Empty
        query &= " DELETE mt_master_machine WHERE line_cd = '" & LineCode & "' AND machine_cd = '" & MachineCode & "' AND unit_name = '" & UnitName & "' "
        query &= " AND part_name = '" & PartName & "' AND method_part = '" & MethodPart & "' "
        query &= " AND method_range_from = '" & MethodRangeFrom & "' AND method_range_to = '" & MethodRangeTo & "' AND method_range_unit = '" & MethodRangeUnit & "' "

        ExecuteQueryTDF(query)

        MsgBox("PART SUCCESSFULLY DELETED!", MsgBoxStyle.Information, "SUCCESS")

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

    Private Sub B_NO_PART_Click(sender As Object, e As EventArgs) Handles B_NO_PART.Click
        TXT_INFO_PART.Clear()
        TXT_MAIN.BringToFront()
        TXT_INFO_PART.SendToBack()
        B_YES_PART.SendToBack()
        B_NO_PART.SendToBack()
    End Sub

    Private Sub DialogDeleteDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        B_DELETE_UNIT.Focus()
    End Sub
End Class