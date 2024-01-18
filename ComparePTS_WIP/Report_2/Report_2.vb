Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Report_2
    Public conTDF As New SqlConnection(My.Settings.TDF)

    Function GetDataTDF(sql As String) As DataTable
        Dim dataadapter As New SqlDataAdapter(sql, conTDF)
        Dim dt As New DataTable

        conTDF.Open()
        dataadapter.Fill(dt)
        conTDF.Close()
        Return dt
    End Function

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

    Public Sub ExportExcel()
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        ' Add headers to the Excel sheet
        For j = 0 To DG_MAIN.ColumnCount - 1
            xlWorkSheet.Cells(1, j + 1) = DG_MAIN.Columns(j).HeaderText
            Dim header As Excel.Range = xlWorkSheet.Cells(1, j + 1)
            header.HorizontalAlignment = Excel.Constants.xlCenter
            header.VerticalAlignment = Excel.Constants.xlCenter
            header.Font.Bold = True
        Next
        ' Add data to the Excel sheet
        For i = 0 To DG_MAIN.RowCount - 2
            For j = 0 To DG_MAIN.ColumnCount - 1
                Dim cell As Excel.Range = xlWorkSheet.Cells(i + 2, j + 1)
                cell.Value = DG_MAIN(j, i).Value.ToString()
                cell.HorizontalAlignment = Excel.Constants.xlCenter
                cell.VerticalAlignment = Excel.Constants.xlCenter
            Next
        Next

        xlWorkSheet.Columns.AutoFit()

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files|*.xlsx"
        saveFileDialog.Title = "Save Excel File"
        saveFileDialog.FileName = "Compare_WIP.xlsx" ' Default file name

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            xlWorkSheet.SaveAs(saveFileDialog.FileName)
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            MsgBox("File saved successfully.")
        Else
            ' User canceled the save operation
            xlWorkBook.Close()
            xlApp.Quit()
            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
            MsgBox("Save operation canceled.")
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub B_SEARCH_Click(sender As Object, e As EventArgs) Handles B_SEARCH.Click
        Dim query As String = String.Empty

        query &= " SELECT t.assy_code AS [ASSY CODE], 
                   SUM(t.qty1) AS [AUTO MOUNTING], 
                   FORMAT(MAX(t.tgl_auto_mounting), 'yyyy-MM-dd') AS [TANGGAL MOUNTING], 
                   FORMAT(MAX(t.tgl_auto_mounting), 'HH:mm') AS [WAKTU MOUNTING], 
                   SUM(t.qty2) AS [AUTO INSERT], 
                   FORMAT(MAX(t.tgl_auto_insert), 'yyyy-MM-dd') AS [TANGGAL INSERT], 
                   FORMAT(MAX(t.tgl_auto_insert), 'HH:mm') AS [WAKTU INSERT],
                   CASE WHEN SUM(t.qty1) < SUM(t.qty2) THEN 'INPUT QUANTITY BERBEDA'
                   WHEN SUM(t.qty1) > SUM(t.qty2) THEN 'INPUT QUANTITY BERBEDA'
                   ELSE '' END AS KETERANGAN
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

        Dim dt As DataTable = GetDataTDF(query)
        DG_MAIN.DataSource = dt

        Me.DG_MAIN.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DG_MAIN.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.DG_MAIN.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        Me.DG_MAIN.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        Me.DG_MAIN.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Me.DG_MAIN.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        Me.DG_MAIN.Columns(0).Width = 190
        Me.DG_MAIN.Columns(1).Width = 180
        Me.DG_MAIN.Columns(2).Width = 200
        Me.DG_MAIN.Columns(3).Width = 180
        Me.DG_MAIN.Columns(4).Width = 140
        Me.DG_MAIN.Columns(5).Width = 200
        Me.DG_MAIN.Columns(6).Width = 180
        Me.DG_MAIN.Columns(7).Width = 195
    End Sub

    Private Sub B_EXPORT_Click(sender As Object, e As EventArgs) Handles B_EXPORT.Click
        ExportExcel()
    End Sub

    Private Sub DG_MAIN_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_MAIN.CellDoubleClick
        ' Assuming the "assy_code" is in the first column (index 0)
        Dim columnIndexAssyCode As Integer = 0

        ' Check if the double-clicked cell is in the first column (where the "assy_code" is located)
        'If e.ColumnIndex = columnIndexAssyCode AndAlso e.RowIndex >= 0 Then
        '    ' Get the value of the "assy_code" in the clicked row
        '    Dim assyCode As String = DG_MAIN.Rows(e.RowIndex).Cells(columnIndexAssyCode).Value.ToString()
        Dim assyCode As String = DG_MAIN.Rows(e.RowIndex).Cells(columnIndexAssyCode).Value.ToString()

        Dim query As String = String.Empty
            query &= " SELECT t.assy_code AS [ASSY CODE], t.qty_wip_auto_mounting AS [AUTO MOUNTING], t.ref_no_AM AS [REF NO MOUNTING],  
                       FORMAT(t.tgl_auto_mounting, 'yyyy-MM-dd') AS [TANGGAL MOUNTING], 
                       FORMAT(t.tgl_auto_mounting, 'HH:mm') AS [WAKTU MOUNTING], 
                       t.qty_wip_auto_insert AS [AUTO INSERT], 
                       t.ref_no_AI AS [REF NO INSERT],
                       FORMAT(t.tgl_auto_insert, 'yyyy-MM-dd') AS [TANGGAL INSERT], 
                       FORMAT(t.tgl_auto_insert, 'HH:mm') AS [WAKTU INSERT],
                       CASE WHEN t.qty_wip_auto_mounting < t.qty_wip_auto_insert THEN 'INPUT QUANTITY BERBEDA'
                       WHEN t.qty_wip_auto_mounting > t.qty_wip_auto_insert THEN 'INPUT QUANTITY BERBEDA'
                       ELSE '' END AS KETERANGAN
                       FROM (
                           SELECT  am.assy_code, am.qty_wip_auto_mounting, ai.qty_wip_auto_insert, am.ref_no_AM, ai.ref_no_AI, 
                           am.tgl_auto_mounting, 
                           ai.tgl_auto_insert
                               FROM (
                                   SELECT assy_code, SUM(qty) AS qty_wip_auto_mounting, 0 AS qty_wip_auto_insert, ref_no AS ref_no_AM, '' AS ref_no_AI,
                                       RANK() OVER (PARTITION BY assy_code ORDER BY MAX(created_at) DESC) rk, 
                                       MAX(created_at) AS tgl_auto_mounting, 
                                       0 AS tgl_auto_insert
                                   FROM WIP_AUTO_MOUNTING 
                                   WHERE created_at BETWEEN '" & D_START.Text & "' AND '" & D_END.Text & "' 
                                   AND assy_code = '" & assyCode & "' "
            query &= " GROUP BY assy_code, ref_no) am
                       FULL JOIN (
                           SELECT assy_code, 0 AS qty_wip_auto_mounting, SUM(qty) AS qty_wip_auto_insert, '' AS ref_no_AM, ref_no AS ref_no_AI,
                           RANK() OVER (PARTITION BY assy_code ORDER BY MAX(created_at) DESC) rk, 0 AS tgl_auto_mounting, 
                           MAX(created_at) AS tgl_auto_insert
                           FROM WIP_AUTO_INPUT 
                           WHERE created_at BETWEEN '" & D_START.Text & "' AND '" & D_END.Text & "' 
                           AND assy_code = '" & assyCode & "' "
            query &= " GROUP BY assy_code, ref_no) ai ON am.assy_code = ai.assy_code AND am.ref_no_AM = ai.ref_no_AI) t
                       WHERE t.ref_no_AM = t.ref_no_AI
                       ORDER BY t.tgl_auto_mounting ASC, t.tgl_auto_insert ASC "

        Dim dt As DataTable = GetDataTDF(query)
        Dim f As New Detail_Report()

        f.txt_assycode.Text = "ASSY CODE: " + assyCode
        f.DG_MAIN.DataSource = dt

        f.DG_MAIN.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        f.DG_MAIN.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        f.DG_MAIN.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 12)
        f.DG_MAIN.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10)
        f.DG_MAIN.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        f.DG_MAIN.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        f.DG_MAIN.Columns(0).Width = 190
        f.DG_MAIN.Columns(1).Width = 150
        f.DG_MAIN.Columns(2).Width = 180
        f.DG_MAIN.Columns(3).Width = 100
        f.DG_MAIN.Columns(4).Width = 100
        f.DG_MAIN.Columns(5).Width = 150
        f.DG_MAIN.Columns(6).Width = 180
        f.DG_MAIN.Columns(7).Width = 100
        f.DG_MAIN.Columns(8).Width = 100
        f.DG_MAIN.Columns(9).Width = 200

        f.Show()
        'End If
    End Sub

End Class