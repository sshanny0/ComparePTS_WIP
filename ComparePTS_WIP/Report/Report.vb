Imports System.Data.SqlClient

Public Class Report
    Public reportPath As String = Application.StartupPath + "\R_DATA.rdlc"
    'Public reportPath As String = "E:\Hanny\VB\ComparePTS_WIP\Report\R_DATA.rdlc"
    Public conTDF As New SqlConnection(My.Settings.TDF)

    Function GetDataTDF(sql As String) As DataTable
        Dim dataadapter As New SqlDataAdapter(sql, conTDF)
        Dim dt As New DataTable

        conTDF.Open()
        dataadapter.Fill(dt)
        conTDF.Close()
        Return dt
    End Function

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AssyCode()
        Me.R_DATA.RefreshReport()
    End Sub
    Public Sub AssyCode()
        Dim query As String = String.Empty
        query &= " SELECT assy_code, SUM(qty_wip_auto_mounting) AS qty1, SUM(qty_wip_auto_insert) AS qty2 
                   FROM( 
                   SELECT assy_code, SUM(qty) AS qty_wip_auto_mounting, 0 AS qty_wip_auto_insert 
                   FROM WIP_AUTO_MOUNTING 
											
                   GROUP BY assy_code 

                   UNION ALL

                   SELECT assy_code, 0 AS qty_wip_auto_mounting, SUM(qty) AS qty_wip_auto_insert  
                   FROM WIP_AUTO_INPUT 
                   GROUP BY assy_code 
                   ) asd
                   GROUP BY assy_code "

        Dim dt As DataTable = GetDataTDF(query)
        Dim col As New AutoCompleteStringCollection
        For i = 0 To dt.Rows.Count - 1
            col.Add(dt.Rows(i)("assy_code").ToString())
        Next

        txt_assy_c.AutoCompleteSource = AutoCompleteSource.CustomSource
        txt_assy_c.AutoCompleteCustomSource = col
        txt_assy_c.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub B_SEARCH_Click(sender As Object, e As EventArgs) Handles B_SEARCH.Click
        R_DATA.Reset()
        R_DATA.LocalReport.DataSources.Clear()

        Dim query As String = String.Empty

        'DETAIL REF_NO
        'query &= " SELECT t.assy_code AS assy_code , t.qty_wip_auto_mounting AS qty1, t.qty_wip_auto_insert AS qty2, t.ref_no_AM AS ref_no_AM, 
        '           t.ref_no_AI AS ref_no_AI, t.tgl_auto_mounting, t.tgl_auto_insert
        '           FROM (
        '               SELECT  am.assy_code, am.qty_wip_auto_mounting, ai.qty_wip_auto_insert, am.ref_no_AM, ai.ref_no_AI, 
        '               am.tgl_auto_mounting, 
        '               ai.tgl_auto_insert
        '                   FROM (
        '                       SELECT assy_code, SUM(qty) AS qty_wip_auto_mounting, 0 AS qty_wip_auto_insert, ref_no AS ref_no_AM, '' AS ref_no_AI,
        '                           RANK() OVER (PARTITION BY assy_code ORDER BY MAX(created_at) DESC) rk, 
        '                           MAX(created_at) AS tgl_auto_mounting, 
        '                           0 AS tgl_auto_insert
        '                       FROM WIP_AUTO_MOUNTING 
        '                       WHERE created_at BETWEEN '" & D_START.Text & "' AND '" & D_END.Text & "' "
        'If txt_assy_c.Text <> Nothing Then
        '    query &= " AND assy_code = '" & txt_assy_c.Text & "' "
        'End If
        'query &= " GROUP BY assy_code, ref_no) am
        '           FULL JOIN (
        '               SELECT assy_code, 0 AS qty_wip_auto_mounting, SUM(qty) AS qty_wip_auto_insert, '' AS ref_no_AM, ref_no AS ref_no_AI,
        '               RANK() OVER (PARTITION BY assy_code ORDER BY MAX(created_at) DESC) rk, 0 AS tgl_auto_mounting, 
        '               MAX(created_at) AS tgl_auto_insert
        '               FROM WIP_AUTO_INPUT 
        '               WHERE created_at BETWEEN '" & D_START.Text & "' AND '" & D_END.Text & "' "
        'If txt_assy_c.Text <> Nothing Then
        '    query &= " AND assy_code = '" & txt_assy_c.Text & "' "
        'End If
        'query &= " GROUP BY assy_code, ref_no) ai ON am.assy_code = ai.assy_code AND am.ref_no_AM = ai.ref_no_AI) t
        '           WHERE t.ref_no_AM = t.ref_no_AI
        '           ORDER BY t.tgl_auto_mounting ASC, t.tgl_auto_insert ASC "

        query &= " SELECT t.assy_code AS assy_code, 
                   SUM(t.qty1) AS qty1, 
                   SUM(t.qty2) AS qty2, 
                   MAX(t.ref_no_AM) AS ref_no_AM, 
                   MAX(t.ref_no_AI) AS ref_no_AI, 
                   MAX(t.tgl_auto_mounting) AS tgl_auto_mounting, 
                   MAX(t.tgl_auto_insert) AS tgl_auto_insert
                   FROM (
                       SELECT am.assy_code, 
                       am.qty_wip_auto_mounting AS qty1, 
                       ai.qty_wip_auto_insert AS qty2, 
                       am.ref_no_AM, 
                       ai.ref_no_AI, 
                       am.tgl_auto_mounting, 
                       ai.tgl_auto_insert
                       FROM (
                          SELECT assy_code, 
                          SUM(qty) AS qty_wip_auto_mounting, 
                          0 AS qty_wip_auto_insert, 
                          ref_no AS ref_no_AM, 
                          '' AS ref_no_AI,
                          RANK() OVER (PARTITION BY assy_code ORDER BY MAX(created_at) DESC) rk, 
                          MAX(created_at) AS tgl_auto_mounting, 
                          0 AS tgl_auto_insert
                          FROM WIP_AUTO_MOUNTING 
                          WHERE created_at BETWEEN '" & D_START.Text & "' AND '" & D_END.Text & "' "
        If txt_assy_c.Text <> Nothing Then
            query &= " AND assy_code = '" & txt_assy_c.Text & "' "
        End If
        query &= " GROUP BY assy_code, ref_no) am
                   FULL JOIN (
                           SELECT assy_code, 
                           0 AS qty_wip_auto_mounting, 
                           SUM(qty) AS qty_wip_auto_insert, 
                           '' AS ref_no_AM, 
                           ref_no AS ref_no_AI,
                           RANK() OVER (PARTITION BY assy_code ORDER BY MAX(created_at) DESC) rk, 
                           0 AS tgl_auto_mounting, 
                           MAX(created_at) AS tgl_auto_insert
                           FROM WIP_AUTO_INPUT 
                           WHERE created_at BETWEEN '" & D_START.Text & "' AND '" & D_END.Text & "' "
        If txt_assy_c.Text <> Nothing Then
            query &= " AND assy_code = '" & txt_assy_c.Text & "' "
        End If
        query &= "  GROUP BY assy_code, ref_no
                       ) ai ON am.assy_code = ai.assy_code AND am.ref_no_AM = ai.ref_no_AI
                       WHERE am.ref_no_AM = ai.ref_no_AI OR (am.ref_no_AM = '' AND ai.ref_no_AI = '')) t
                 GROUP BY t.assy_code
           ORDER BY MAX(t.tgl_auto_mounting) ASC, MAX(t.tgl_auto_insert) ASC "

        Dim dt As New DataTable
        Using con As New SqlConnection(My.Settings.TDF)
            con.Open()
            Using cmd As New SqlCommand(query, con)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt)
                Me.R_DATA.Visible = True
            End Using
        End Using
        With Me.R_DATA.LocalReport
            .DataSources.Clear()
            .ReportPath = reportPath
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        Me.R_DATA.RefreshReport()
        Dim bindingsource As BindingSource = New BindingSource()
    End Sub
End Class