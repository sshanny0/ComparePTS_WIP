Option Strict Off
Option Explicit On
Imports System.IO
Imports System.IO.Ports
Imports ZXing
Imports System.Configuration
Imports System.Drawing.Printing
Imports System.Drawing.Drawing2D
Imports com.citizen.sdk.LabelPrint
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Reflection

Public Class CodeIF
    Inherits System.Windows.Forms.Form
    'Declaration of Private Subroutine
    Private Declare Sub about Lib "tsclib.dll" ()
    Private Declare Sub openport Lib "tsclib.dll" (ByVal PrinterName As String)
    Private Declare Sub closeport Lib "tsclib.dll" ()
    Private Declare Sub sendcommand Lib "tsclib.dll" (ByVal command_Renamed As String)
    Private Declare Sub setup Lib "tsclib.dll" (ByVal LabelWidth As String, ByVal LabelHeight As String, ByVal Speed As String, ByVal Density As String, ByVal Sensor As String, ByVal Vertical As String, ByVal Offset As String)
    Private Declare Sub downloadpcx Lib "tsclib.dll" (ByVal Filename As String, ByVal ImageName As String)
    Private Declare Sub barcode Lib "tsclib.dll" (ByVal X As String, ByVal Y As String, ByVal CodeType As String, ByVal Height_Renamed As String, ByVal Readable As String,
                                                  ByVal rotation As String, ByVal Narrow As String, ByVal Wide As String, ByVal Code As String)
    Private Declare Sub printerfont Lib "tsclib.dll" (ByVal X As String, ByVal Y As String, ByVal FontName As String, ByVal rotation As String, ByVal Xmul As String, ByVal Ymul As String, ByVal Content As String)
    Private Declare Sub clearbuffer Lib "tsclib.dll" ()
    Private Declare Sub printlabel Lib "tsclib.dll" (ByVal NumberOfSet As String, ByVal NumberOfCopy As String)
    Private Declare Sub formfeed Lib "tsclib.dll" ()
    Private Declare Sub nobackfeed Lib "tsclib.dll" ()
    Private Declare Sub windowsfont Lib "tsclib.dll" (ByVal X As Short, ByVal Y As Short, ByVal fontheight_Renamed As Short, ByVal rotation As Short, ByVal fontstyle As Short, ByVal fontunderline As Short, ByVal FaceName As String, ByVal TextContent As String)
    Private Declare Sub windowsfontUnicode Lib "tsclib.dll" (ByVal X As Short, ByVal Y As Short, ByVal fontheight_Renamed As Short, ByVal rotation As Short, ByVal fontstyle As Short, ByVal fontunderline As Short, ByVal FaceName As String, ByVal TextContent As Byte())
    Private Declare Sub sendBinaryData Lib "tsclib.dll" (ByVal TextContent As Byte(), ByVal length As Integer)
    Private Declare Function usbportqueryprinter Lib "tsclib.dll" () As Byte

    Public rowsq As Integer = 1
    Private lastSqNo As Integer = 0
    Public cmb_assy_value As String = String.Empty
    Sub GetBoardNo()
        If cmb_assy.SelectedIndex <> -1 Then
            cmb_assy_value = DirectCast(cmb_assy.SelectedItem, DataRowView).Row("AssyNo").ToString()
        End If

        'GET BOARDNO
        Dim querygetBoard As String = String.Empty
        querygetBoard &= "SELECT BoardNo FROM AssyCode_List "
        querygetBoard &= "WHERE AssyNo = '" & cmb_assy_value & "'"
        Dim dt As DataTable = GetDataTDF(querygetBoard)
        If dt.Rows.Count > 0 Then
            Dim boardNo As String = dt.Rows(0)("BoardNo").ToString()

            'CHECK QTY
            Dim queryQty As String = String.Empty
            queryQty &= "SELECT TOP 1 SerialNo FROM Log_PCB_Prod_SrNo "
            queryQty &= "WHERE AssyNo = '" & cmb_assy_value & "' "
            queryQty &= "AND BoardNo = '" & boardNo & "' "
            queryQty &= "AND FORMAT(CreateDate, 'yyyy-MM') = '" & dt_prod.Value.ToString("yyyy-MM") & "' "
            queryQty &= "ORDER BY SerialNo DESC"
            Dim dt2 As DataTable = GetDataTDF(queryQty)
            If dt2.Rows.Count > 0 And cmb_assy_value IsNot Nothing Then
                Dim serialno As String = dt2.Rows(0).Item("SerialNo").ToString()
                txt_qty_info.Text = "LAST SERIAL NUMBER = " & serialno
            Else
                txt_qty_info.Text = "LAST SERIAL NUMBER = 00000"
            End If
        End If
    End Sub
    Sub GetLog()
        If cmb_assy.SelectedIndex <> -1 Then
            cmb_assy_value = DirectCast(cmb_assy.SelectedItem, DataRowView).Row("AssyNo").ToString()
        End If

        Dim queryLog As String = String.Empty
        queryLog &= "SELECT AssyNo AS [Assy No], RangeCount AS Range, ProductionDate AS Date, COUNT(SrnoPrint) AS [Total Count] FROM Log_PCB_Prod_SrNo
                     WHERE AssyNo = '" & cmb_assy_value & "' AND MONTH(ProductionDate) = MONTH(GETDATE())
                     GROUP BY RangeCount, ProductionDate, AssyNo ORDER BY ProductionDate DESC"
        Dim dt As DataTable = GetDataTDF(queryLog)
        dgv_log.DataSource = dt

        Me.dgv_log.Columns(2).Width = 120
    End Sub
    Private Sub CodeIF_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainMenu.Show()
        Me.Hide()
    End Sub
    Private Sub CodeIF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_assy.Select()

        dt_prod.Value = DateTime.Now

        Dim queryBoard As String = String.Empty
        queryBoard &= "SELECT [AssyNo] + ' (' + [Model] + ')' AS AssyNoDS, AssyNo FROM AssyCode_List "
        queryBoard &= "WHERE BoardDesc = 'IF'"

        Dim dt As DataTable = GetDataTDF(queryBoard)
        With cmb_assy
            .DataSource = dt
            .ValueMember = "AssyNo"
            .DisplayMember = "AssyNoDS"
            .SelectedIndex = -1
        End With

        'SET PRINTER
        Dim strInstalledPrinters As String
        Dim prntDoc As New PrintDocument

        For Each strInstalledPrinters In PrinterSettings.InstalledPrinters
            If strInstalledPrinters.Contains("TSC") Then
                cmb_printer.Items.Add(strInstalledPrinters)
            End If
        Next strInstalledPrinters
        cmb_printer.SelectedIndex = 0
        cmb_printer.Text = prntDoc.PrinterSettings.PrinterName

        GetBoardNo()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        dt_prod.Value = DateTime.Now

        cmb_assy_value = DirectCast(cmb_assy.SelectedItem, DataRowView).Row("AssyNo").ToString()

        'GET BOARDNO
        Dim querygetBoard As String = String.Empty
        querygetBoard &= "SELECT BoardNo FROM AssyCode_List "
        querygetBoard &= "WHERE AssyNo = '" & cmb_assy_value & "'"
        Dim dt As DataTable = GetDataTDF(querygetBoard)
        Dim boardNo As String = dt.Rows(0)("BoardNo").ToString()

        'GET FACTORYCODE
        Dim queryFactory As String = String.Empty
        queryFactory &= "SELECT fcode FROM PCB_Prod_Factory "
        queryFactory &= "WHERE fdesc = 'PT. KAI'"
        Dim dt2 As DataTable = GetDataTDF(queryFactory)
        Dim codeFac As String = dt2.Rows(0).Item("fcode").ToString()

        'GET YEAR
        Dim strYear As String = dt_prod.Value.Year
        strYear = strYear.Substring(strYear.Length - 1)

        'GET MONTH
        Dim strMonth As String = dt_prod.Value.Month
        If strMonth = "10" Then
            strMonth = "X"
        ElseIf strMonth = "11" Then
            strMonth = "Y"
        ElseIf strMonth = "12" Then
            strMonth = "Z"
        End If

        'CHECK DATA
        Dim queryCheck As String = String.Empty
        queryCheck &= "SELECT TOP 1 SerialCount, SerialNo FROM Log_PCB_Prod_SrNo "
        queryCheck &= "WHERE AssyNo = '" & cmb_assy_value & "' "
        queryCheck &= "AND BoardNo = '" & boardNo & "' "
        queryCheck &= "AND FORMAT(CreateDate, 'yyyy-MM') = '" & dt_prod.Value.ToString("yyyy-MM") & "' "
        queryCheck &= "ORDER BY SerialCount DESC, SerialNo DESC "
        Dim dt3 As DataTable = GetDataTDF(queryCheck)

        'CHECK SQNO
        Dim querySqno = "SELECT TOP 1 sqno FROM PCB_Prod_SrNo "
        'querySqno &= "WHERE FORMAT(create_date, 'yyyy-MM') = '" & dt_prod.Value.ToString("yyyy-MM") & "' "
        querySqno &= "ORDER BY sqno DESC "
        Dim dt4 As DataTable = GetDataTDF(querySqno)
        Dim sqno As String = dt4.Rows(0).Item("sqno").ToString()

        If dt3.Rows.Count > 0 Then
            Dim serialno As String = dt3.Rows(0).Item("SerialNo").ToString()
            Dim serialno2 As String = dt3.Rows(0).Item("SerialNo").ToString()
            Dim serialcount As String = dt3.Rows(0).Item("SerialCount").ToString()

            If Convert.ToInt32(qty_end.Text) < Convert.ToInt32(serialcount + 1) Then
                MsgBox("Quantity kurang dari SN terakhir!")
            Else
                For counter = Convert.ToInt32(serialcount + 1) To Convert.ToInt32(qty_end.Text)
                    serialno = (Convert.ToInt32(serialno) + 1).ToString("00000")
                    serialno2 = (Convert.ToInt32(serialno2) + 1).ToString("00000")
                    Dim result As String = boardNo + strYear + strMonth + codeFac + serialno
                    Dim result2 As String = boardNo + strYear + strMonth + codeFac + serialno2

                    'INSERT TO LABELHISTORY
                    Dim insertLabelHis As String = String.Empty
                    insertLabelHis &= "INSERT INTO labelHistory (ManufactureCode, AssyNo, ProductionDate, BoardNo, SerialNo, Srnoprint, CreateDate, Type) "
                    insertLabelHis &= "VALUES ('" & codeFac & "', '" & cmb_assy_value & "', CONVERT(DATETIME, '" & dt_prod.Text & "', 101), '" & boardNo & "', '" & serialno & "', "
                    insertLabelHis &= "'" & result & "', CONVERT(DATETIME, '" & dt_prod.Text & "', 101), 'BARCODE')"
                    ExecuteQueryTDF(insertLabelHis)

                    'INSERT INTO PCB_PROD_SRNO
                    If serialno2 <= Convert.ToInt32(qty_end.Text) Then
                        If lastSqNo <> sqno Then
                            rowsq = 1 ' Reset rowsq to 1 if sqno has changed
                        Else
                            rowsq += 1 ' Increment rowsq if sqno is the same
                        End If

                        lastSqNo = sqno

                        Dim insertPCB As String = String.Empty
                        insertPCB &= "INSERT INTO PCB_Prod_SrNo (sqno, rowsq, srno1, srno2, AssyNo, create_date) "
                        insertPCB &= "VALUES ('" & sqno + 1 & "', '" & rowsq & "', "
                        insertPCB &= "'" & result2 & "', "
                        If serialno2 < Convert.ToInt32(qty_end.Text) Then
                            insertPCB &= "'" & boardNo + strYear + strMonth + codeFac + (Convert.ToInt32(serialno2) + 1).ToString("00000") & "', "
                        Else
                            insertPCB &= "NULL, "
                        End If
                        insertPCB &= "'" & cmb_assy_value & "', CONVERT(DATETIME, '" & dt_prod.Text & "', 101))"
                        ExecuteQueryTDF(insertPCB)
                        serialno2 = (Convert.ToInt32(serialno2) + 1).ToString("00000")
                    End If

                    'INSERT INTO LOG_PCB_PROD_SRNO
                    Dim insertLogPCB As String = String.Empty
                    insertLogPCB &= "INSERT INTO Log_PCB_Prod_SrNo (ManufactureCode, AssyNo, ProductionDate, BoardNo, SerialNo, SerialCount, Srnoprint, CreateDate, "
                    insertLogPCB &= "Type, RangeCount) "
                    insertLogPCB &= "VALUES ('" & codeFac & "', '" & cmb_assy_value & "', CONVERT(DATETIME, '" & dt_prod.Text & "', 101), '" & boardNo & "', '" & serialno & "', "
                    insertLogPCB &= "'" & counter & "', '" & result & "', CONVERT(DATETIME, '" & dt_prod.Text & "', 101), 'BARCODE', "
                    insertLogPCB &= "'" & qty_start.Value & "-" & qty_end.Value & "')"
                    ExecuteQueryTDF(insertLogPCB)
                Next
                'PRINTING
                PrintTSC()
            End If
        Else
            If qty_end.Value = 0 Then
                MsgBox("Quantity end tidak boleh kosong!")
            ElseIf qty_end.Value <> 0 Then
                Dim pcbCounter As Integer = 0
                For counter = Convert.ToInt32(qty_start.Text) To Convert.ToInt32(qty_end.Text)
                    Dim serialno As String = counter.ToString("00000")
                    Dim result As String = boardNo + strYear + strMonth + codeFac + serialno

                    'INSERT TO LABELHISTORY
                    Dim insertLabelHis As String = String.Empty
                    insertLabelHis &= "INSERT INTO labelHistory (ManufactureCode, AssyNo, ProductionDate, BoardNo, SerialNo, Srnoprint, CreateDate, Type) "
                    insertLabelHis &= "VALUES ('" & codeFac & "', '" & cmb_assy_value & "', CONVERT(DATETIME, '" & dt_prod.Text & "', 101), '" & boardNo & "', '" & serialno & "', '" & result & "', "
                    insertLabelHis &= "CONVERT(DATETIME, '" & dt_prod.Text & "', 101), 'BARCODE')"
                    ExecuteQueryTDF(insertLabelHis)

                    'INSERT INTO PCB_PROD_SRNO
                    If counter + pcbCounter <= Convert.ToInt32(qty_end.Text) Then
                        Dim insertPCB As String = String.Empty
                        insertPCB &= "INSERT INTO PCB_Prod_SrNo (sqno, rowsq, srno1, srno2, AssyNo, create_date) "
                        insertPCB &= "VALUES ('" & sqno + 1 & "', '" & rowsq & "', "
                        insertPCB &= "'" & boardNo + strYear + strMonth + codeFac + (counter + pcbCounter).ToString("00000") & "', "
                        pcbCounter += 1
                        If counter + pcbCounter <= Convert.ToInt32(qty_end.Text) Then
                            insertPCB &= "'" & boardNo + strYear + strMonth + codeFac + (counter + pcbCounter).ToString("00000") & "', "
                        Else
                            insertPCB &= "NULL, "
                        End If
                        insertPCB &= "'" & cmb_assy_value & "', CONVERT(DATETIME, '" & dt_prod.Text & "', 101))"
                        ExecuteQueryTDF(insertPCB)
                        rowsq = rowsq + 1
                    End If

                    'INSERT INTO LOG_PCB_PROD_SRNO
                    Dim insertLogPCB As String = String.Empty
                    insertLogPCB &= "INSERT INTO Log_PCB_Prod_SrNo (ManufactureCode, AssyNo, ProductionDate, BoardNo, SerialNo, SerialCount, Srnoprint, CreateDate, "
                    insertLogPCB &= "Type, RangeCount) "
                    insertLogPCB &= "VALUES ('" & codeFac & "', '" & cmb_assy_value & "', CONVERT(DATETIME, '" & dt_prod.Text & "', 101), '" & boardNo & "', '" & serialno & "', "
                    insertLogPCB &= "'" & counter & "', '" & result & "', CONVERT(DATETIME, '" & dt_prod.Text & "', 101), 'BARCODE', "
                    insertLogPCB &= "'" & qty_start.Value & "-" & qty_end.Value & "')"
                    ExecuteQueryTDF(insertLogPCB)
                Next
                'PRINTING
                PrintTSC()
            End If
        End If
        GetBoardNo()
        GetLog()
    End Sub

    Private Sub cmb_assy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_assy.SelectedIndexChanged
        GetBoardNo()
        GetLog()
    End Sub

    Private Sub dt_prod_ValueChanged(sender As Object, e As EventArgs) Handles dt_prod.ValueChanged
        GetBoardNo()
    End Sub

    Sub PrintTSC()
        cmb_assy_value = DirectCast(cmb_assy.SelectedItem, DataRowView).Row("AssyNo").ToString()

        'CHECK SQNO FOR PRINT
        Dim querySqnoPrint = "SELECT TOP 1 sqno FROM PCB_Prod_SrNo "
        querySqnoPrint &= "WHERE FORMAT(create_date, 'yyyy-MM') = '" & dt_prod.Value.ToString("yyyy-MM") & "' "
        querySqnoPrint &= "AND AssyNo = '" & cmb_assy_value & "' "
        querySqnoPrint &= "ORDER BY sqno DESC "
        Dim dtsqnoprint As DataTable = GetDataTDF(querySqnoPrint)
        Dim sqnoprint As String = dtsqnoprint.Rows(0).Item("sqno").ToString()
        Dim queryPrint As String = String.Empty
        queryPrint &= "SELECT * FROM PCB_Prod_SrNo "
        queryPrint &= "WHERE AssyNo = '" & cmb_assy_value & "' AND sqno = '" & sqnoprint & "' "
        queryPrint &= "ORDER BY sqno DESC, rowsq ASC"
        Dim dtprint As DataTable = GetDataTDF(queryPrint)
        If dtprint.Rows.Count > 0 Then
            For Each row As DataRow In dtprint.Rows
                Call openport(cmb_printer.Text)
                Call setup("43", "4", "12", "12", "0", "2", "0")
                Call clearbuffer()

                'SRNO1
                Dim printSrno1 As String = row.Item("srno1").ToString()
                Call barcode("4", "1", "128", "15", "0", "0", "1", "1", printSrno1)
                Call windowsfont("17", "17", "15", "0", "0", "0", "Times New Roman", printSrno1 & " / " & cmb_assy_value)

                'SRNO2
                If Not IsDBNull(row.Item("srno2")) Then
                    Dim printSrno2 As String = row.Item("srno2").ToString()
                    Call barcode("188", "1", "128", "15", "0", "0", "1", "1", printSrno2)
                    Call windowsfont("200", "17", "15", "0", "0", "0", "Times New Roman", printSrno2 & " / " & cmb_assy_value)
                End If

                Call printlabel("1", "1")
                Call closeport()
            Next
        End If
    End Sub

    Sub printCitizen()
        cmb_assy_value = DirectCast(cmb_assy.SelectedItem, DataRowView).Row("AssyNo").ToString()

        'PRINTING
        ' Search for USB printers and populate listView1
        Dim searchmode As Integer = 0 ' 0: SearchCitizenPrinter, 1: SearchLabelPrinter
        Dim res As Integer = 0
        Dim type As Integer = LabelConst.CLS_PORT_USB ' Set the type to CLS_PORT_USB
        Dim printer As New LabelPrinter()

        ' Initialize
        ListView1.Items.Clear()

        If searchmode = 0 Then
            Dim info() As CitizenPrinterInfo
            info = printer.SearchCitizenPrinter(type, 10, res)
            If res <> LabelConst.CLS_SUCCESS Then
                If res = LabelConst.CLS_E_NO_LIST Then
                    MessageBox.Show("Printer Not Found.", "Warning")
                Else
                    MessageBox.Show("SearchCitizenPrinter Failed", "Error")
                End If
                Return
            End If

            ' List up all available Citizen printers in the listView
            For i As Integer = 0 To info.Length - 1
                Dim CLSs(1) As String
                CLSs(0) = info(i).deviceName
                CLSs(1) = info(i).printerModel
                ListView1.Items.Add(New ListViewItem(CLSs))
            Next
        Else
            Dim address() As String
            address = printer.SearchLabelPrinter(type, 10, res)
            If res <> LabelConst.CLS_SUCCESS Then
                If res = LabelConst.CLS_E_NO_LIST Then
                    MessageBox.Show("Printer Not Found.", "Warning")
                Else
                    MessageBox.Show("SearchLabelPrinter Failed", "Error")
                End If
                Return
            End If

            ' List up all available Label printers in the listView
            For i As Integer = 0 To address.Length - 1
                Dim CLSs As String = address(i)
                ListView1.Items.Add(New ListViewItem(CLSs))
            Next
        End If

        'Assuming ListView1 has at least one item
        If ListView1.Items.Count > 0 Then
            ListView1.Focus()
            ListView1.Items(0).Selected = True

            ' Retrieve the information from the first item
            Dim selectedPrinterInfo As String = ListView1.Items(0).Text

            'CHECK SQNO FOR PRINT
            Dim querySqnoPrint = "SELECT TOP 1 sqno FROM PCB_Prod_SrNo "
            querySqnoPrint &= "WHERE FORMAT(create_date, 'yyyy-MM') = '" & dt_prod.Value.ToString("yyyy-MM") & "' "
            querySqnoPrint &= "AND AssyNo = '" & cmb_assy_value & "' "
            querySqnoPrint &= "ORDER BY sqno DESC "
            Dim dtsqnoprint As DataTable = GetDataTDF(querySqnoPrint)
            Dim sqnoprint As String = dtsqnoprint.Rows(0).Item("sqno").ToString()
            Dim queryPrint As String = String.Empty
            queryPrint &= "SELECT * FROM PCB_Prod_SrNo "
            queryPrint &= "WHERE AssyNo = '" & cmb_assy_value & "' AND sqno = '" & sqnoprint & "' "
            queryPrint &= "ORDER BY sqno DESC, rowsq ASC"
            Dim dtprint As DataTable = GetDataTDF(queryPrint)

            ' Create an instance (LabelPrinter class) outside the loop
            Dim connectedPrinter As New LabelPrinter()

            ' Connect printer outside the loop
            Dim connectResult As Integer = connectedPrinter.Connect(type, selectedPrinterInfo)
            If LabelConst.CLS_SUCCESS = connectResult Then
                ' Get Properties
                Dim printDarkness As Integer = connectedPrinter.GetPrintDarkness()
                connectedPrinter.SetPrintDarkness(24)

                Dim doubleheat As Integer = connectedPrinter.GetDoubleHeat()
                connectedPrinter.SetDoubleHeat(1)

                Dim labelsensor As Integer = connectedPrinter.GetLabelSensor()
                connectedPrinter.SetLabelSensor(LabelConst.CLS_SELSENSOR_SEETHROUGH)

                ' Loop through the rows
                If dtprint.Rows.Count > 0 Then
                    For Each row As DataRow In dtprint.Rows
                        ' BarCode
                        Dim design As New LabelDesign()

                        ' SRNO1
                        Dim printSrno1 As String = row.Item("srno1").ToString()
                        ' String Data, Int symbology, Int rotation, Int thick, Int narrow, Int height, Int x, Int y, Int showText
                        'design.DrawBarCode(printSrno1, LabelConst.CLS_BCS_CODE128, LabelConst.CLS_RT_NORMAL, 1, 1, 10, 10, 7, LabelConst.CLS_BCS_TEXT_HIDE)
                        design.DrawTextDLFont(printSrno1, LabelConst.CLS_ENC_CDPG_WINDOWS_1252, "", LabelConst.CLS_RT_NORMAL, 1, 1, 12, 100, 100)

                        ' SRNO2
                        If Not IsDBNull(row.Item("srno2")) Then
                            Dim printSrno2 As String = row.Item("srno2").ToString()
                            design.DrawBarCode(printSrno2, LabelConst.CLS_BCS_CODE128, LabelConst.CLS_RT_NORMAL, 1, 1, 10, 100, 7, LabelConst.CLS_BCS_TEXT_HIDE)
                        End If

                        ' Print Label
                        Dim printResult As Integer = connectedPrinter.Print(design, 1)

                        If LabelConst.CLS_SUCCESS <> printResult Then
                            ' Print Error
                            MessageBox.Show("Print Error : " + printResult.ToString(), "Citizen_Label_sample", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Next
                End If
                connectedPrinter.Disconnect()
            Else
                ' Connect Error
                MessageBox.Show("Connect Error : " + connectResult.ToString(), "Citizen_Label_sample", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class