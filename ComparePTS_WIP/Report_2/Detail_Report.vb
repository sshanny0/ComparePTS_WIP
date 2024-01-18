Imports Excel = Microsoft.Office.Interop.Excel
Public Class Detail_Report
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
        saveFileDialog.FileName = "Detail_WIP.xlsx" ' Default file name

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

    Private Sub B_EXPORT_Click_1(sender As Object, e As EventArgs) Handles B_EXPORT.Click
        ExportExcel()
    End Sub
End Class