
Imports System.Data.SqlClient
Imports System.Globalization

Public Class DailyReport

    Public Sub LoadReport()

        'TABLE MAIN
        Dim dt As New DataTable
        Using con As New SqlConnection(My.Settings.TDF)
            con.Open()

            Dim query As String = String.Empty
            query &= "SELECT * FROM (SELECT RANK() OVER (PARTITION BY machine_cd, line_cd, part_name ORDER BY a.created_at DESC) AS rk, "
            query &= "a.created_at AS datetime_created, machine_name, machine_cd, unit_name, part_name, reason, result, "
            query &= "name, nik, b.created_at AS datetime_checked "
            query &= "FROM mt_checked_machine_final a "
            query &= "LEFT JOIN mt_log_user b ON a.id = b.id_checked_final "
            query &= "WHERE date_input = CAST(GETDATE() AS DATE) AND line_cd = '" & T_LINE_CD.Text & "') t "
            query &= "WHERE rk = 1"

            Using cmd As New SqlCommand(query, con)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt)
            End Using
        End Using

        'TABLE BEFORE
        Dim dt2 As New DataTable
        Using con As New SqlConnection(My.Settings.TDF)
            con.Open()

            Dim query As String = String.Empty
            query &= "SELECT * FROM (SELECT RANK() OVER (PARTITION BY machine_cd, line_cd, part_name ORDER BY created_at DESC) AS rk, *  FROM mt_checked_machine "
            query &= "WHERE date = CAST(GETDATE() AS DATE) AND line_cd = '" & T_LINE_CD.Text & "') t "
            query &= "WHERE rk = 2"

            Using cmd As New SqlCommand(query, con)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt2)
            End Using
        End Using

        'TABLE DATE TITLE
        Dim dt3 As New DataTable
        Using con As New SqlConnection(My.Settings.TDF)
            con.Open()

            Dim query As String = String.Empty
            query &= " SELECT MAX(created_at) created_at, MAX(line_cd) line_cd, MAX(line_desc) line_desc FROM mt_checked_machine_final "
            query &= "WHERE date_input = CAST(GETDATE() AS DATE) AND line_cd = '" & T_LINE_CD.Text & "' "
            Using cmd As New SqlCommand(query, con)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt3)
            End Using
        End Using


        With Me.R_DAILY.LocalReport
            .DataSources.Clear()
            '.ReportPath = "E:\Hanny\VB\CheckSheetSystem\DailyMaintenance\Report\Daily\DailyReport.rdlc"
            .ReportPath = Application.StartupPath + "\Report\DailyReport.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dt2))
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", dt3))
        End With

        Me.R_DAILY.RefreshReport()
    End Sub

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

    Private Sub T_LINE_CD_KeyDown(sender As Object, e As KeyEventArgs) Handles T_LINE_CD.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim query As String = String.Empty
            query &= " SELECT * FROM mt_master_machine WHERE line_cd = '" & T_LINE_CD.Text & "' "

            Dim dt As DataTable = GetDataTDF(query)
            If dt.Rows.Count > 0 Then
                T_LINE_NAME.Text = dt.Rows(0)(1).ToString
            End If
        End If
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

    Private Sub B_SUBMIT_Click(sender As Object, e As EventArgs) Handles B_SUBMIT.Click
        LoadReport()
    End Sub

    Private Sub DailyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLine()
    End Sub

    Private Sub B_BACK_Click(sender As Object, e As EventArgs) Handles B_BACK.Click
        Me.Close()
    End Sub
End Class