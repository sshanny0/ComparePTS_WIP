Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class Detail
    Public reportPath As String = Application.StartupPath + "\R_DETAIL.rdlc"
    'Public reportPath As String = "E:\Hanny\VB\ComparePTS_WIP\Report\R_DETAIL.rdlc"
    Public conTDF As New SqlConnection(My.Settings.TDF)

    Function GetDataTDF(sql As String) As DataTable
        Dim dataadapter As New SqlDataAdapter(sql, conTDF)
        Dim dt As New DataTable

        conTDF.Open()
        dataadapter.Fill(dt)
        conTDF.Close()
        Return dt
    End Function
    Private Sub Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AssyCode()
        Me.R_DETAIL.RefreshReport()
    End Sub

    Public Sub AssyCode()
        Dim query As String = String.Empty
        query &= " SELECT assy_code
        FROM WIP_AUTO_MOUNTING
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
        R_DETAIL.Reset()
        R_DETAIL.LocalReport.DataSources.Clear()

        Dim query As String = String.Empty
        query &= "  SELECT assy_code, qty, lot_no, line, model, ref_no, job_number, seq, created_at
                    FROM WIP_AUTO_MOUNTING "
        If D_START.Text <> Nothing And D_END.Text <> Nothing Then
            query &= " WHERE created_at BETWEEN '" & D_START.Text & "' AND '" & D_END.Text & "' "
        End If
        If txt_assy_c.Text <> Nothing Then
            query &= " AND assy_code = '" & txt_assy_c.Text & "' "
        End If

        Dim dt As New DataTable
        Using con As New SqlConnection(My.Settings.TDF)
            con.Open()
            Using cmd As New SqlCommand(query, con)
                Dim da As New SqlDataAdapter
                da.SelectCommand = cmd
                da.Fill(dt)
                Me.R_DETAIL.Visible = True
            End Using
        End Using
        With Me.R_DETAIL.LocalReport
            .DataSources.Clear()
            .ReportPath = reportPath
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        Me.R_DETAIL.RefreshReport()
        Dim bindingsource As BindingSource = New BindingSource()
    End Sub
End Class