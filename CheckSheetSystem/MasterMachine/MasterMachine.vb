Imports System.CodeDom.Compiler
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Reflection
Imports Microsoft.Office.Interop

Public Class MasterMachine

    Dim partcdcount As Integer = 1
    Dim partmethodcount As Integer = 1
    Dim buttonpartcount As Integer = 1
    Dim buttonrangecount As Integer = 1
    Dim methodcheckcount As Integer = 1
    Dim methodfromcount As Integer = 1
    Dim methodtocount As Integer = 1
    Dim methodunicount As Integer = 1
    Public Sub GetLine()
        Dim query As String = String.Empty
        query &= "SELECT I_LINE_CD, I_LINE_NAME FROM M_LINE GROUP BY I_LINE_CD, I_LINE_NAME "

        Dim dt As DataTable = GetDataPTS(query)
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To dt.Rows.Count - 1
            col.Add(dt.Rows(i)("I_LINE_CD").ToString())
        Next
        T_LINE_CD.AutoCompleteSource = AutoCompleteSource.CustomSource
        T_LINE_CD.AutoCompleteCustomSource = col
        T_LINE_CD.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub
    Public Sub GetMachine()
        Dim query As String = String.Empty
        query &= " SELECT I_MACHINE_NAME FROM M_MACHINE WHERE I_LINE_CD = '" & T_LINE_CD.Text & "' GROUP BY I_MACHINE_NAME ORDER BY I_MACHINE_NAME"

        Dim dt As DataTable = GetDataPTS(query)
        With C_MACHINE_NAME
            .DataSource = dt
            .ValueMember = "I_MACHINE_NAME"
            .DisplayMember = "I_MACHINE_NAME"
            .SelectedIndex = -1
        End With
    End Sub


    Public Sub AddNewTextBox()
        Dim TextToCheckDynamic As String = "PART CODE " & (P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count + 1).ToString()
        Dim TextToCheckDynamic3 As String = "PART CHECK " & (P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count + 1).ToString()

        If Not P_PART_VISIBLE.Controls.OfType(Of TextBox)().Any(Function(txt) txt.Text = TextToCheckDynamic) Then
            Dim textbox As New TextBox

            ' Mengatur properti TextBox
            textbox.Left = 11
            textbox.Size = New Size(152, 30)
            textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox.ForeColor = Color.White
            textbox.BackColor = Color.RoyalBlue
            textbox.TextAlign = HorizontalAlignment.Center
            textbox.BorderStyle = BorderStyle.Fixed3D
            textbox.ReadOnly = True
            textbox.Name = "L_PART_CODE_MAIN"

            ' Penentuan posisi top untuk TextBox
            If P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count = 0 Then
                textbox.Top = 1 * 11 ' Jika ini label pertama
            Else
                textbox.Top = (P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count) * 15 + P_PART_VISIBLE.Controls.OfType(Of Button)().Count * 17
            End If

            'textbox.Text = TextToCheckDynamic
            textbox.Text = "PART CODE " & Me.partcdcount.ToString
            partcdcount = partcdcount + 1
            ' Menambahkan TextBox ke Controls
            P_PART_VISIBLE.Controls.Add(textbox)

            ' Membuat TextBox kedua dengan properti yang sama
            Dim textbox2 As New TextBox
            textbox2.Left = 171
            textbox2.Size = New Size(105, 30)
            textbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox2.Top = textbox.Top
            textbox2.Name = "T_PART_CODE_MAIN"
            P_PART_VISIBLE.Controls.Add(textbox2)

            ' Membuat TextBox ketiga dengan properti yang sama
            Dim textbox3 As New TextBox
            textbox3.Left = 282
            textbox3.Size = New Size(155, 30)
            textbox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox3.ForeColor = Color.White
            textbox3.BackColor = Color.RoyalBlue
            textbox3.TextAlign = HorizontalAlignment.Center
            textbox3.BorderStyle = BorderStyle.Fixed3D
            textbox3.Top = textbox.Top
            'textbox3.Text = TextToCheckDynamic3
            textbox3.Text = "PART CHECK " & Me.partmethodcount.ToString
            partmethodcount = partmethodcount + 1
            textbox3.ReadOnly = True
            textbox3.Name = "L_PART_CHECK_MAIN"
            P_PART_VISIBLE.Controls.Add(textbox3)

            ' Membuat TextBox keempat dengan properti yang sama
            Dim textbox4 As New TextBox
            textbox4.Left = 443
            textbox4.Size = New Size(201, 30)
            textbox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox4.Top = textbox.Top
            textbox4.Name = "T_PART_CHECK_MAIN"
            P_PART_VISIBLE.Controls.Add(textbox4)
        End If
    End Sub

    Public Sub AddNewButton()
        Dim ButtonTextToCheckDynamic As String = "METHOD WITH PART " & (P_PART_VISIBLE.Controls.OfType(Of Button)().Count + 1).ToString()
        Dim ButtonTextToCheckDynamic2 As String = "METHOD WITH RANGE " & (P_PART_VISIBLE.Controls.OfType(Of Button)().Count + 1).ToString()

        If Not P_PART_VISIBLE.Controls.OfType(Of Button)().Any(Function(btn) btn.Text = ButtonTextToCheckDynamic) Then
            Dim button As New Button

            button.Left = 11
            button.Size = New Size(240, 38)
            button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            button.BackColor = Color.LightGray
            button.TextAlign = ContentAlignment.MiddleCenter
            button.Name = "B_METHOD_PART_MAIN"

            If P_PART_VISIBLE.Controls.OfType(Of Button)().Count = 1 Then
                button.Top = 1 * 43 ' Jika ini tombol pertama
            Else
                ' Gunakan nilai yang sesuai untuk tombol selanjutnya
                button.Top = (P_PART_VISIBLE.Controls.OfType(Of Button)().Count - 1) * 17 + P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count * 15
            End If

            'button.Text = ButtonTextToCheckDynamic
            button.Text = "METHOD WITH PART " & Me.buttonpartcount.ToString
            buttonpartcount = buttonpartcount + 1
            P_PART_VISIBLE.Controls.Add(button)

            Dim button2 As New Button

            button2.Left = 280
            button2.Size = New Size(240, 38)
            button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            button2.BackColor = Color.LightGray
            button2.TextAlign = ContentAlignment.MiddleCenter
            button2.Top = button.Top
            'button2.Text = ButtonTextToCheckDynamic2
            button2.Text = "METHOD WITH RANGE " & Me.buttonrangecount.ToString
            buttonrangecount = buttonrangecount + 1
            button2.Name = "B_METHOD_RANGE_MAIN"
            P_PART_VISIBLE.Controls.Add(button2)

            AddHandler button.Click, AddressOf B_METHOD_PART_MAIN
            AddHandler button2.Click, AddressOf B_METHOD_RANGE_MAIN
        End If
    End Sub

    Public Sub AddNewMethodPart()
        Dim TextToCheckDynamic As String = "METHOD OF CHECK " & (P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count + 1).ToString()

        If Not P_PART_VISIBLE.Controls.OfType(Of TextBox)().Any(Function(txt) txt.Text = TextToCheckDynamic) Then
            Dim textbox As New TextBox

            ' Mengatur properti TextBox
            textbox.Left = 11
            textbox.Size = New Size(225, 30)
            textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox.ForeColor = Color.White
            textbox.BackColor = Color.RoyalBlue
            textbox.TextAlign = HorizontalAlignment.Center
            textbox.BorderStyle = BorderStyle.Fixed3D
            textbox.ReadOnly = True
            textbox.Name = "L_METHOD_CHECK_MAIN"

            ' Penentuan posisi top untuk TextBox
            If P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count = 0 Then
                textbox.Top = 1 * 43 ' Jika ini label pertama
            Else
                textbox.Top = (P_PART_VISIBLE.Controls.OfType(Of Button)().Count - 1) * 17 + P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count * 15
            End If

            'textbox.Text = TextToCheckDynamic
            textbox.Text = "METHOD OF CHECK " & Me.methodcheckcount.ToString
            methodcheckcount = methodcheckcount + 1
            P_PART_VISIBLE.Controls.Add(textbox)

            ' Membuat TextBox kedua dengan properti yang sama
            Dim textbox2 As New TextBox
            textbox2.Left = 246
            textbox2.Size = New Size(398, 30)
            textbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox2.Top = textbox.Top
            textbox2.Name = "T_METHOD_CHECK_MAIN"
            P_PART_VISIBLE.Controls.Add(textbox2)
        End If
    End Sub

    Public Sub AddNewMethodRange()
        Dim TextToCheckDynamic1 As String = "FROM " & (P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count + 1).ToString()
        Dim TextToCheckDynamic3 As String = "TO " & (P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count + 1).ToString()
        Dim TextToCheckDynamic5 As String = "SATUAN " & (P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count + 1).ToString()

        If Not P_PART_VISIBLE.Controls.OfType(Of TextBox)().Any(Function(txt) txt.Text = TextToCheckDynamic1) Then
            Dim textbox As New TextBox
            textbox.Left = 11
            textbox.Size = New Size(96, 30)
            textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox.ForeColor = Color.White
            textbox.BackColor = Color.RoyalBlue
            textbox.TextAlign = HorizontalAlignment.Center
            textbox.BorderStyle = BorderStyle.Fixed3D
            textbox.ReadOnly = True
            textbox.Name = "L_RANGE_FROM_MAIN"

            ' Penentuan posisi top untuk TextBox
            If P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count = 0 Then
                textbox.Top = 1 * 43 ' Jika ini label pertama
            Else
                textbox.Top = (P_PART_VISIBLE.Controls.OfType(Of Button)().Count - 1) * 17 + P_PART_VISIBLE.Controls.OfType(Of TextBox)().Count * 15
            End If

            'textbox.Text = TextToCheckDynamic1
            textbox.Text = "FROM " & Me.methodfromcount.ToString
            methodfromcount = methodfromcount + 1
            P_PART_VISIBLE.Controls.Add(textbox)

            Dim textbox2 As New TextBox
            textbox2.Left = 113
            textbox2.Size = New Size(105, 30)
            textbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox2.Top = textbox.Top
            textbox2.Name = "T_RANGE_FROM_MAIN"
            P_PART_VISIBLE.Controls.Add(textbox2)

            Dim textbox3 As New TextBox
            textbox3.Left = 224
            textbox3.Size = New Size(96, 30)
            textbox3.Top = textbox.Top
            textbox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox3.ForeColor = Color.White
            textbox3.BackColor = Color.RoyalBlue
            textbox3.TextAlign = HorizontalAlignment.Center
            textbox3.BorderStyle = BorderStyle.Fixed3D
            'textbox3.Text = TextToCheckDynamic3
            textbox3.Text = "TO " & Me.methodtocount.ToString
            methodtocount = methodtocount + 1
            textbox3.ReadOnly = True
            textbox3.Name = "L_RANGE_TO_MAIN"
            P_PART_VISIBLE.Controls.Add(textbox3)

            Dim textbox4 As New TextBox
            textbox4.Left = 326
            textbox4.Size = New Size(95, 30)
            textbox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox4.Top = textbox.Top
            textbox4.Name = "T_RANGE_TO_MAIN"
            P_PART_VISIBLE.Controls.Add(textbox4)

            Dim textbox5 As New TextBox
            textbox5.Left = 427
            textbox5.Size = New Size(96, 30)
            textbox5.Top = textbox.Top
            textbox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox5.ForeColor = Color.White
            textbox5.BackColor = Color.RoyalBlue
            textbox5.TextAlign = HorizontalAlignment.Center
            textbox5.BorderStyle = BorderStyle.Fixed3D
            'textbox5.Text = TextToCheckDynamic5
            textbox5.Text = "UNIT " & Me.methodunicount.ToString
            methodunicount = methodunicount + 1
            textbox5.ReadOnly = True
            textbox5.Name = "L_RANGE_UNIT_MAIN"
            P_PART_VISIBLE.Controls.Add(textbox5)

            Dim textbox6 As New TextBox
            textbox6.Left = 529
            textbox6.Size = New Size(115, 30)
            textbox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
            textbox6.Top = textbox.Top
            textbox6.Name = "T_RANGE_UNIT_MAIN"
            P_PART_VISIBLE.Controls.Add(textbox6)
        End If
    End Sub

    Private buttonRangeMain As Button
    Private Sub B_METHOD_PART_MAIN(sender As Object, e As EventArgs)
        AddNewMethodPart()
        CType(sender, Button).Visible = False

        For Each ctrl As Control In P_PART_VISIBLE.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name = "B_METHOD_RANGE_MAIN" Then
                Dim buttonRangeMain As Button = DirectCast(ctrl, Button)
                buttonRangeMain.Visible = False
            End If
        Next
    End Sub

    Private Sub B_METHOD_RANGE_MAIN(sender As Object, e As EventArgs)
        AddNewMethodRange()
        CType(sender, Button).Visible = False

        For Each ctrl As Control In P_PART_VISIBLE.Controls
            If TypeOf ctrl Is Button AndAlso ctrl.Name = "B_METHOD_PART_MAIN" Then
                Dim buttonRangeMain As Button = DirectCast(ctrl, Button)
                buttonRangeMain.Visible = False
            End If
        Next
    End Sub
    Public Sub txtClear()
        For Each txt_part In {T_PART_1, T_PART_2, T_PART_3, T_PART_4, T_PART_5}
            txt_part.Clear()
        Next
        For Each txt_method In {T_METHOD_1, T_METHOD_2, T_METHOD_3, T_METHOD_4, T_METHOD_5}
            txt_method.Clear()
        Next
        For Each txt_part_code In {T_CODE_PART_1, T_CODE_PART_2, T_CODE_PART_3, T_CODE_PART_4, T_CODE_PART_5}
            txt_part_code.Clear()
        Next
        For Each txt In {T_LINE_CD, T_LINE_NAME, T_UNIT, T_MACHINE_CD}
            txt.Clear()
        Next
        For Each txt_from_to_unit In {T_FROM_METHOD_1, T_TO_METHOD_1, T_UNIT}
            txt_from_to_unit.Clear()
        Next
        C_MACHINE_NAME.SelectedIndex = -1
        T_LINE_CD.Select()
    End Sub
    Public Sub Visibility()
        P_PART_MAIN.Visible = True

        B_METHOD_PART_1.Visible = "True"
        B_METHOD_PART_2.Visible = "True"
        B_METHOD_PART_3.Visible = "True"
        B_METHOD_PART_4.Visible = "True"
        B_METHOD_PART_5.Visible = "True"

        B_METHOD_RANGE_1.Visible = "True"
        B_METHOD_RANGE_2.Visible = "True"
        B_METHOD_RANGE_3.Visible = "True"
        B_METHOD_RANGE_4.Visible = "True"
        B_METHOD_RANGE_5.Visible = "True"

        L_METHOD_1.Visible = "False"
        T_METHOD_1.Visible = "False"
        L_FROM_METHOD_1.Visible = "False"
        T_FROM_METHOD_1.Visible = "False"
        L_TO_METHOD_1.Visible = "False"
        T_TO_METHOD_1.Visible = "False"
        L_UNIT_METHOD_1.Visible = "False"
        T_UNIT_METHOD_1.Visible = "False"

        L_METHOD_2.Visible = "False"
        T_METHOD_2.Visible = "False"
        L_FROM_METHOD_2.Visible = "False"
        T_FROM_METHOD_2.Visible = "False"
        L_TO_METHOD_2.Visible = "False"
        T_TO_METHOD_2.Visible = "False"
        L_UNIT_METHOD_2.Visible = "False"
        T_UNIT_METHOD_2.Visible = "False"

        L_METHOD_3.Visible = "False"
        T_METHOD_3.Visible = "False"
        L_FROM_METHOD_3.Visible = "False"
        T_FROM_METHOD_3.Visible = "False"
        L_TO_METHOD_3.Visible = "False"
        T_TO_METHOD_3.Visible = "False"
        L_UNIT_METHOD_3.Visible = "False"
        T_UNIT_METHOD_3.Visible = "False"

        L_METHOD_4.Visible = "False"
        T_METHOD_4.Visible = "False"
        L_FROM_METHOD_4.Visible = "False"
        T_FROM_METHOD_4.Visible = "False"
        L_TO_METHOD_4.Visible = "False"
        T_TO_METHOD_4.Visible = "False"
        L_UNIT_METHOD_4.Visible = "False"
        T_UNIT_METHOD_4.Visible = "False"

        L_METHOD_5.Visible = "False"
        T_METHOD_5.Visible = "False"
        L_FROM_METHOD_5.Visible = "False"
        T_FROM_METHOD_5.Visible = "False"
        L_TO_METHOD_5.Visible = "False"
        T_TO_METHOD_5.Visible = "False"
        L_UNIT_METHOD_5.Visible = "False"
        T_UNIT_METHOD_5.Visible = "False"
    End Sub
    Public Sub GetMachineData()
        Dim query As String = String.Empty
        query &= " SELECT "
        query &= " line_cd AS 'LINE CD', "
        query &= " machine_cd AS 'MACHINE CD', "
        query &= " machine_name AS 'MACHINE NAME', "
        query &= " unit_name AS 'UNIT', "
        query &= " part_cd AS 'PART CODE', "
        query &= " part_name AS 'PART FOR CHECK', "
        'query &= " CASE WHEN method_part <> '' THEN method_part 
        '           WHEN method_range_from <> '' AND method_range_to <> '' AND method_range_unit <> '' THEN CONCAT(method_range_from, '-',  method_range_to, ' ', method_range_unit)
        '           END AS 'METHOD OF CHECK' "
        query &= " method_part AS 'METHOD PART', "
        query &= " method_range_from AS 'METHOD RANGE (FROM)', "
        query &= " method_range_to AS 'METHOD RANGE (TO)', "
        query &= " method_range_unit AS 'METHOD RANGE (UNIT)' "
        query &= " FROM mt_master_machine "
        query &= " ORDER BY line_cd "

        Dim dt As DataTable = GetDataTDF(query)
        D_DATA.DataSource = dt
        D_DATA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
    End Sub
    Private Sub MasterMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetLine()
        GetMachineData()
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

    Private Sub C_MACHINE_CD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_MACHINE_NAME.SelectedIndexChanged
        If C_MACHINE_NAME.SelectedIndex = -1 Then
            T_MACHINE_CD.Text = ""
        Else
            Dim query As String = String.Empty
            query &= " SELECT I_MACHINE_CD FROM M_MACHINE WHERE I_MACHINE_NAME = '" & C_MACHINE_NAME.Text & "' GROUP BY I_MACHINE_CD "

            Dim dt As DataTable = GetDataPTS(query)
            If dt.Rows.Count > 0 Then
                T_MACHINE_CD.Text = dt.Rows(0)(0)
            End If
            T_UNIT.Select()
        End If

    End Sub

    Private Sub T_LINE_CD_KeyDown(sender As Object, e As KeyEventArgs) Handles T_LINE_CD.KeyDown
        If e.KeyCode = Keys.Enter Then
            GetMachine()
            Dim query As String = String.Empty
            query &= " SELECT * FROM M_LINE WHERE I_LINE_CD = '" & T_LINE_CD.Text & "' "

            Dim dt As DataTable = GetDataPTS(query)
            If dt.Rows.Count > 0 Then
                T_LINE_NAME.Text = dt.Rows(0)(1).ToString

            End If
            C_MACHINE_NAME.Select()
        End If
    End Sub

    Private Sub B_EXCEL_Click(sender As Object, e As EventArgs) Handles B_EXCEL.Click
        'verfying the datagridview having data or not
        If ((D_DATA.Columns.Count = 0) Or (D_DATA.Rows.Count = 0)) Then
            Exit Sub
        End If

        'Creating dataset to export
        Dim dset As New DataSet
        'add table to dataset
        dset.Tables.Add()
        'add column to that table
        For i As Integer = 0 To D_DATA.ColumnCount - 1
            dset.Tables(0).Columns.Add(D_DATA.Columns(i).HeaderText)
        Next
        'add rows to the table
        Dim dr1 As DataRow
        For i As Integer = 0 To D_DATA.RowCount - 1
            dr1 = dset.Tables(0).NewRow
            For j As Integer = 0 To D_DATA.Columns.Count - 1
                dr1(j) = D_DATA.Rows(i).Cells(j).Value
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next

        Dim excel As New Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In dt.Columns
            colIndex = colIndex + 1
            excel.Cells(1, colIndex) = dc.ColumnName
        Next

        For Each dr In dt.Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

            Next
        Next

        wSheet.Columns.AutoFit()
        Dim sd As New SaveFileDialog
        sd.Filter = "Excel files (*.xlsx)|*.xlsx"
        If sd.ShowDialog = Windows.Forms.DialogResult.OK Then
            wBook.SaveAs(sd.FileName)
        End If
        excel.Quit()
    End Sub

    Private Sub B_CLOSE_Click(sender As Object, e As EventArgs) Handles B_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub B_ADD_Click(sender As Object, e As EventArgs) Handles B_ADD.Click
        'AddNewTextBox()
        'AddNewButton()
        P_PART_MAIN.Visible = False
    End Sub


    Private Sub B_CLEAR_Click(sender As Object, e As EventArgs) Handles B_CLEAR.Click
        txtClear()
        Visibility()
    End Sub

    Private Sub B_SAVE_Click(sender As Object, e As EventArgs) Handles B_SAVE.Click
        If T_LINE_CD.Text = "" Or T_LINE_NAME.Text = "" Then
            MsgBox("PLEASE INPUT THE LINE!", MsgBoxStyle.Exclamation, "WARNING")
        ElseIf C_MACHINE_NAME.SelectedIndex = -1 Or T_MACHINE_CD.Text = "" Then
            MsgBox("PLEASE SELECT THE MACHINE!", MsgBoxStyle.Exclamation, "WARNING")
        ElseIf T_UNIT.Text = "" Then
            MsgBox("PLEASE INPUT THE UNIT", MsgBoxStyle.Exclamation, "WARNING")
            'ElseIf {T_PART_1.Text, T_PART_2.Text, T_PART_3.Text, T_PART_4.Text, T_PART_5.Text}.Any(Function(tb) tb.TextLength > 0) Then
        ElseIf T_CODE_PART_1.Text = "" AndAlso T_CODE_PART_2.Text = "" AndAlso T_CODE_PART_3.Text = "" AndAlso T_CODE_PART_4.Text = "" AndAlso T_CODE_PART_5.Text = "" Then
            MsgBox("PLEASE INPUT AT LEAST ONE PART CODE FOR CHECK", MsgBoxStyle.Exclamation, "WARNING")
        ElseIf T_PART_1.Text = "" AndAlso T_PART_2.Text = "" AndAlso T_PART_3.Text = "" AndAlso T_PART_4.Text = "" AndAlso T_PART_5.Text = "" Then
            MsgBox("PLEASE INPUT AT LEAST ONE PART FOR CHECK", MsgBoxStyle.Exclamation, "WARNING")
        ElseIf T_METHOD_1.Text = "" AndAlso T_METHOD_2.Text = "" AndAlso T_METHOD_3.Text = "" AndAlso T_METHOD_4.Text = "" AndAlso T_METHOD_5.Text = "" AndAlso T_FROM_METHOD_1.Text = "" AndAlso T_FROM_METHOD_2.Text = "" AndAlso T_FROM_METHOD_3.Text = "" AndAlso T_FROM_METHOD_4.Text = "" AndAlso T_FROM_METHOD_5.Text = "" Then
            MsgBox("PLEASE INPUT AT LEAST ONE METHOD OF CHECK", MsgBoxStyle.Exclamation, "WARNING")
        Else

            Dim queryCheck As String = String.Empty
            queryCheck &= " SELECT * FROM mt_master_machine WHERE line_cd = '" & T_LINE_CD.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "'  "
            queryCheck &= " AND unit_name = '" & T_UNIT.Text & "' AND part_cd IN ('" & T_CODE_PART_1.Text & "', '" & T_CODE_PART_2.Text & "', '" & T_CODE_PART_3.Text & "', "
            queryCheck &= " '" & T_CODE_PART_4.Text & "', '" & T_CODE_PART_5.Text & "') "
            queryCheck &= " AND part_name IN('" & T_PART_1.Text & "', '" & T_PART_2.Text & "', '" & T_PART_3.Text & "', "
            queryCheck &= " '" & T_PART_4.Text & "', '" & T_PART_5.Text & "') AND method_part IN('" & T_METHOD_1.Text & "', '" & T_METHOD_2.Text & "', "
            queryCheck &= " '" & T_METHOD_3.Text & "', '" & T_METHOD_4.Text & "', '" & T_METHOD_5.Text & "') "

            'MessageBox.Show(queryCheck)
            Using con As New SqlConnection(My.Settings.TDF)
                Using cmd As New SqlCommand(queryCheck, con)
                    con.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader
                        If reader.HasRows Then
                            MsgBox("THE MACHINE ALREADY INSERTED!", MsgBoxStyle.Critical, "WARNING")
                        Else
                            'PARCODE
                            Dim partcodeValues As New List(Of String)()

                            If T_CODE_PART_1.Text <> "" Then
                                partcodeValues.Add(T_CODE_PART_1.Text)
                            End If

                            If T_CODE_PART_2.Text <> "" Then
                                partcodeValues.Add(T_CODE_PART_2.Text)
                            End If

                            If T_CODE_PART_3.Text <> "" Then
                                partcodeValues.Add(T_CODE_PART_3.Text)
                            End If

                            If T_CODE_PART_4.Text <> "" Then
                                partcodeValues.Add(T_CODE_PART_4.Text)
                            End If

                            If T_CODE_PART_5.Text <> "" Then
                                partcodeValues.Add(T_CODE_PART_5.Text)
                            End If

                            'PARTNAME
                            Dim partValues As New List(Of String)()

                            If T_PART_1.Text <> "" Then
                                partValues.Add(T_PART_1.Text)
                            End If

                            If T_PART_2.Text <> "" Then
                                partValues.Add(T_PART_2.Text)
                            End If

                            If T_PART_3.Text <> "" Then
                                partValues.Add(T_PART_3.Text)
                            End If

                            If T_PART_4.Text <> "" Then
                                partValues.Add(T_PART_4.Text)
                            End If

                            If T_PART_5.Text <> "" Then
                                partValues.Add(T_PART_5.Text)
                            End If

                            'METHODNAME
                            Dim methodnames As New List(Of String)()

                            If T_METHOD_1.Text <> "" Then
                                methodnames.Add(T_METHOD_1.Text)
                            Else
                                methodnames.Add(T_METHOD_1.Text)
                            End If
                            If T_METHOD_2.Text <> "" Then
                                methodnames.Add(T_METHOD_2.Text)
                            Else
                                methodnames.Add(T_METHOD_2.Text)
                            End If
                            If T_METHOD_3.Text <> "" Then
                                methodnames.Add(T_METHOD_3.Text)
                            Else
                                methodnames.Add(T_METHOD_3.Text)
                            End If
                            If T_METHOD_4.Text <> "" Then
                                methodnames.Add(T_METHOD_4.Text)
                            Else
                                methodnames.Add(T_METHOD_4.Text)
                            End If
                            If T_METHOD_5.Text <> "" Then
                                methodnames.Add(T_METHOD_5.Text)
                            Else
                                methodnames.Add(T_METHOD_5.Text)
                            End If

                            'METHODFROM
                            Dim methodfromm As New List(Of String)()

                            If T_FROM_METHOD_1.Text <> "" Then
                                methodfromm.Add(T_FROM_METHOD_1.Text)
                            Else
                                methodfromm.Add(T_FROM_METHOD_1.Text)
                            End If
                            If T_FROM_METHOD_2.Text <> "" Then
                                methodfromm.Add(T_FROM_METHOD_2.Text)
                            Else
                                methodfromm.Add(T_FROM_METHOD_2.Text)
                            End If
                            If T_FROM_METHOD_3.Text <> "" Then
                                methodfromm.Add(T_FROM_METHOD_3.Text)
                            Else
                                methodfromm.Add(T_FROM_METHOD_3.Text)
                            End If
                            If T_FROM_METHOD_4.Text <> "" Then
                                methodfromm.Add(T_FROM_METHOD_4.Text)
                            Else
                                methodfromm.Add(T_FROM_METHOD_4.Text)
                            End If
                            If T_FROM_METHOD_5.Text <> "" Then
                                methodfromm.Add(T_FROM_METHOD_5.Text)
                            Else
                                methodfromm.Add(T_FROM_METHOD_5.Text)
                            End If

                            'METHODTO
                            Dim methodtoo As New List(Of String)()

                            If T_TO_METHOD_1.Text <> "" Then
                                methodtoo.Add(T_TO_METHOD_1.Text)
                            Else
                                methodtoo.Add(T_TO_METHOD_1.Text)
                            End If
                            If T_TO_METHOD_2.Text <> "" Then
                                methodtoo.Add(T_TO_METHOD_2.Text)
                            Else
                                methodtoo.Add(T_TO_METHOD_2.Text)
                            End If
                            If T_TO_METHOD_3.Text <> "" Then
                                methodtoo.Add(T_TO_METHOD_3.Text)
                            Else
                                methodtoo.Add(T_TO_METHOD_3.Text)
                            End If
                            If T_TO_METHOD_4.Text <> "" Then
                                methodtoo.Add(T_TO_METHOD_4.Text)
                            Else
                                methodtoo.Add(T_TO_METHOD_4.Text)
                            End If
                            If T_TO_METHOD_5.Text <> "" Then
                                methodtoo.Add(T_TO_METHOD_5.Text)
                            Else
                                methodtoo.Add(T_TO_METHOD_5.Text)
                            End If

                            'METHODUNIT
                            Dim methodunits As New List(Of String)()

                            If T_UNIT_METHOD_1.Text <> "" Then
                                methodunits.Add(T_UNIT_METHOD_1.Text)
                            Else
                                methodunits.Add(T_UNIT_METHOD_1.Text)
                            End If
                            If T_UNIT_METHOD_2.Text <> "" Then
                                methodunits.Add(T_UNIT_METHOD_2.Text)
                            Else
                                methodunits.Add(T_UNIT_METHOD_2.Text)
                            End If
                            If T_UNIT_METHOD_3.Text <> "" Then
                                methodunits.Add(T_UNIT_METHOD_3.Text)
                            Else
                                methodunits.Add(T_UNIT_METHOD_3.Text)
                            End If
                            If T_UNIT_METHOD_4.Text <> "" Then
                                methodunits.Add(T_UNIT_METHOD_4.Text)
                            Else
                                methodunits.Add(T_UNIT_METHOD_4.Text)
                            End If
                            If T_UNIT_METHOD_5.Text <> "" Then
                                methodunits.Add(T_UNIT_METHOD_5.Text)
                            Else
                                methodunits.Add(T_UNIT_METHOD_5.Text)
                            End If

                            For i As Integer = 0 To partValues.Count - 1
                                Dim partValue As String = partValues(i)
                                Dim methodname As String = methodnames(i)
                                Dim partcodeValue As String = partcodeValues(i)
                                Dim methodFrom As String = methodfromm(i)
                                Dim methodTo As String = methodtoo(i)
                                Dim methodUnit As String = methodunits(i)

                                Dim queryuser As String = String.Empty
                                queryuser &= " SELECT nik FROM mt_master_user WHERE rfid = '" & Login.T_RFID.Text & "' "
                                Dim dt As DataTable = GetDataTDF(queryuser)
                                If dt.Rows.Count > 0 Then
                                    T_PIC_NIK.Text = dt.Rows(0)(0)
                                End If


                                Dim query As String = "INSERT INTO mt_master_machine (line_cd, line_desc, machine_cd, machine_name, part_name, unit_name, method_part, created_at, "
                                query &= " method_range_from, method_range_to, method_range_unit, part_cd, pic_input) VALUES "
                                query &= " ('" & T_LINE_CD.Text & "', '" & T_LINE_NAME.Text & "', '" & T_MACHINE_CD.Text & "', '" & C_MACHINE_NAME.Text & "', "
                                query &= " '" & partValue & "', '" & T_UNIT.Text & "', '" & methodname & "', GETDATE(), '" & methodFrom & "', '" & methodTo & "', "
                                query &= " '" & methodUnit & "', '" & partcodeValue & "', '" & T_PIC_NIK.Text & "') "
                                ExecuteQueryTDF(query)
                            Next
                            MsgBox("SUCCESSFULLY ADDED THE MACHINE", MsgBoxStyle.Information, "INFORMATION")

                            GetMachineData()
                        End If
                    End Using
                    con.Close()
                End Using
            End Using
        End If
    End Sub

    Private Sub B_SAVE_MAIN_Click(sender As Object, e As EventArgs) Handles B_SAVE_MAIN.Click
        If T_LINE_CD.Text = "" Or T_LINE_NAME.Text = "" Then
            MsgBox("PLEASE INPUT THE LINE!", MsgBoxStyle.Exclamation, "WARNING")
        ElseIf C_MACHINE_NAME.SelectedIndex = -1 Or T_MACHINE_CD.Text = "" Then
            MsgBox("PLEASE SELECT THE MACHINE!", MsgBoxStyle.Exclamation, "WARNING")
        ElseIf T_UNIT.Text = "" Then
            MsgBox("PLEASE INPUT THE UNIT", MsgBoxStyle.Exclamation, "WARNING")
        Else
            Dim ptCodeCheck As New List(Of String)
            Dim ptNameCheck As New List(Of String)
            Dim mtPartCheck As New List(Of String)
            Dim mtFromCheck As New List(Of String)
            Dim mtToCheck As New List(Of String)
            Dim mtUnitCheck As New List(Of String)

            Dim queryCheck As String = String.Empty
            queryCheck &= " SELECT * FROM mt_master_machine WHERE line_cd = '" & T_LINE_CD.Text & "' AND machine_cd = '" & T_MACHINE_CD.Text & "'  "
            queryCheck &= " AND unit_name = '" & T_UNIT.Text & "' "

            For Each ctrl As Control In P_PART_VISIBLE.Controls
                If TypeOf ctrl Is TextBox Then
                    Dim textBox As TextBox = DirectCast(ctrl, TextBox)
                    Dim textValue As String = textBox.Text

                    If ctrl.Name = "T_PART_CODE_MAIN" Then
                        Dim splitptcode As String() = textValue.Split(","c)
                        ptCodeCheck.AddRange(splitptcode)
                    ElseIf ctrl.Name = "T_PART_CHECK_MAIN" Then
                        Dim splitptname As String() = textValue.Split(","c)
                        ptNameCheck.AddRange(splitptname)
                    ElseIf ctrl.Name = "T_METHOD_CHECK_MAIN" Then
                        Dim splitmtpart As String() = textValue.Split(","c)
                        mtPartCheck.AddRange(splitmtpart)
                    ElseIf ctrl.Name = "T_RANGE_FROM_MAIN" Then
                        Dim splitmtfrom As String() = textValue.Split(","c)
                        mtFromCheck.AddRange(splitmtfrom)
                    ElseIf ctrl.Name = "T_RANGE_TO_MAIN" Then
                        Dim splitmtto As String() = textValue.Split(","c)
                        mtToCheck.AddRange(splitmtto)
                    ElseIf ctrl.Name = "T_RANGE_UNIT_MAIN" Then
                        Dim splitmtunit As String() = textValue.Split(","c)
                        mtUnitCheck.AddRange(splitmtunit)
                    End If
                End If
            Next

            If ptCodeCheck.Count > 0 Then
                Dim inClause As String = String.Join(", ", ptCodeCheck.Select(Function(code) $"'{code.Trim()}'"))
                queryCheck &= $" AND part_cd IN ({inClause}) "
            End If
            If ptNameCheck.Count > 0 Then
                Dim inClause As String = String.Join(", ", ptNameCheck.Select(Function(code) $"'{code.Trim()}'"))
                queryCheck &= $" AND part_name IN ({inClause}) "
            ElseIf ptNameCheck.Count = 0 Then
                queryCheck &= " AND part_name = '' "
            End If
            If mtPartCheck.Count > 0 Then
                Dim inClause As String = String.Join(", ", mtPartCheck.Select(Function(code) $"'{code.Trim()}'"))
                queryCheck &= $" AND method_part IN ({inClause}) "
            ElseIf mtPartCheck.Count = 0 Then
                queryCheck &= " AND method_part = '' "
            End If
            If mtFromCheck.Count > 0 Then
                Dim inClause As String = String.Join(", ", mtFromCheck.Select(Function(code) $"'{code.Trim()}'"))
                queryCheck &= $" OR method_range_from IN ({inClause}) "
            ElseIf mtFromCheck.Count = 0 Then
                queryCheck &= " OR method_range_from = '' "
            End If
            If mtToCheck.Count > 0 Then
                Dim inClause As String = String.Join(", ", mtToCheck.Select(Function(code) $"'{code.Trim()}'"))
                queryCheck &= $" AND method_range_to IN ({inClause}) "
            ElseIf mtToCheck.Count = 0 Then
                queryCheck &= " AND method_range_to = '' "
            End If
            If mtUnitCheck.Count > 0 Then
                Dim inClause As String = String.Join(", ", mtUnitCheck.Select(Function(code) $"'{code.Trim()}'"))
                queryCheck &= $" AND method_range_unit IN ({inClause}) "
            ElseIf mtUnitCheck.Count = 0 Then
                queryCheck &= " AND method_range_unit = '' "
            End If

            Using con As New SqlConnection(My.Settings.TDF)
                Using cmd As New SqlCommand(queryCheck, con)
                    con.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader
                        If reader.HasRows Then
                            MsgBox("THE MACHINE ALREADY INSERTED!", MsgBoxStyle.Critical, "WARNING")
                        Else
                            Dim partCode As String = ""
                            Dim partCheck As String = ""
                            Dim methodPart As String = ""
                            Dim methodFrom As String = ""
                            Dim methodTo As String = ""
                            Dim methodUnit As String = ""

                            Dim query As String = "INSERT INTO mt_master_machine (line_cd, line_desc, machine_cd, machine_name, part_cd, part_name, unit_name, created_at, pic_input, "
                            query &= "method_part, method_range_from, method_range_to, method_range_unit) VALUES"

                            For Each ctrl As Control In P_PART_VISIBLE.Controls

                                If TypeOf ctrl Is TextBox Then

                                    Dim textBox As TextBox = DirectCast(ctrl, TextBox)
                                    Dim textValue As String = textBox.Text

                                    Dim queryuser As String = String.Empty
                                    queryuser &= " SELECT nik FROM mt_master_user WHERE rfid = '" & Login.T_RFID.Text & "' "
                                    Dim dt As DataTable = GetDataTDF(queryuser)
                                    If dt.Rows.Count > 0 Then
                                        T_PIC_NIK.Text = dt.Rows(0)(0)
                                    End If

                                    If ctrl.Name = "T_PART_CODE_MAIN" Then
                                        partCode = textValue
                                        query &= "('" & T_LINE_CD.Text & "', '" & T_LINE_NAME.Text & "', '" & T_MACHINE_CD.Text & "', '" & C_MACHINE_NAME.Text & "', "
                                        query &= "'" & partCode & "', "
                                    ElseIf ctrl.Name = "T_PART_CHECK_MAIN" Then
                                        partCheck = textValue
                                        query &= "'" & partCheck & "', '" & T_UNIT.Text & "', GETDATE(), '" & T_PIC_NIK.Text & "', "
                                    ElseIf ctrl.Name = "T_METHOD_CHECK_MAIN" Then
                                        methodPart = textValue
                                        query &= "'" & methodPart & "', '', '', ''),"
                                    ElseIf ctrl.Name = "T_RANGE_FROM_MAIN" Then
                                        methodFrom = textValue
                                        query &= "'', '" & methodFrom & "', "
                                    ElseIf ctrl.Name = "T_RANGE_TO_MAIN" Then
                                        methodTo = textValue
                                        query &= "'" & methodTo & "', "
                                    ElseIf ctrl.Name = "T_RANGE_UNIT_MAIN" Then
                                        methodUnit = textValue
                                        query &= "'" & methodUnit & "'),"
                                    End If
                                End If
                            Next

                            query = query.TrimEnd(","c)

                            ExecuteQueryTDF(query)

                            MsgBox("SUCCESSFULLY ADDED THE MACHINE", MsgBoxStyle.Information, "INFORMATION")

                            GetMachineData()
                        End If
                    End Using
                    con.Close()
                End Using
            End Using
        End If
    End Sub

    Private Sub D_DATA_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles D_DATA.CellContentDoubleClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dim LineCd As String = D_DATA.Item(0, e.RowIndex).Value
        Dim MachineCd As String = D_DATA.Item(1, e.RowIndex).Value
        Dim UnitName As String = D_DATA.Item(3, e.RowIndex).Value
        Dim PartName As String = D_DATA.Item(5, e.RowIndex).Value
        Dim MethodName As String
        Dim MethodPart As String = D_DATA.Item(6, e.RowIndex).Value
        Dim MethodRangeFrom As String = D_DATA.Item(7, e.RowIndex).Value
        Dim MethodRangeTo As String = D_DATA.Item(8, e.RowIndex).Value
        Dim MethodRangeUnit As String = D_DATA.Item(9, e.RowIndex).Value

        If MethodPart = "" Then
            Dim DUD As New DialogUpdateDelete
            DUD.LineCode = LineCd
            DUD.MachineCode = MachineCd
            DUD.UnitName = UnitName
            DUD.PartName = PartName
            DUD.MethodName = MethodRangeFrom & " - " & MethodRangeTo & " " & MethodRangeUnit
            DUD.MethodPart = MethodPart
            DUD.MethodRangeFrom = MethodRangeFrom
            DUD.MethodRangeTo = MethodRangeTo
            DUD.MethodRangeUnit = MethodRangeUnit
            DUD.Show()
        Else
            Dim DUD As New DialogUpdateDelete
            DUD.LineCode = LineCd
            DUD.MachineCode = MachineCd
            DUD.UnitName = UnitName
            DUD.PartName = PartName
            DUD.MethodName = MethodPart
            DUD.MethodPart = MethodPart
            DUD.MethodRangeFrom = MethodRangeFrom
            DUD.MethodRangeTo = MethodRangeTo
            DUD.MethodRangeUnit = MethodRangeUnit
            DUD.Show()
        End If

    End Sub
    'Private Sub D_DATA_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles D_DATA.CellMouseDoubleClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
    '        Dim selectedRow = D_DATA.Item(7, e.RowIndex).Value
    '        MsgBox(selectedRow)
    '    End If
    'End Sub

    Private Sub B_METHOD_PART_1_Click_1(sender As Object, e As EventArgs) Handles B_METHOD_PART_1.Click
        B_METHOD_PART_1.SendToBack()
        B_METHOD_PART_1.Visible = "False"
        B_METHOD_RANGE_1.SendToBack()
        B_METHOD_RANGE_1.Visible = "False"
        L_METHOD_1.Visible = "True"
        T_METHOD_1.Visible = "True"
    End Sub

    Private Sub B_METHOD_RANGE_1_Click_1(sender As Object, e As EventArgs) Handles B_METHOD_RANGE_1.Click
        B_METHOD_PART_1.SendToBack()
        B_METHOD_PART_1.Visible = "False"
        B_METHOD_RANGE_1.SendToBack()
        B_METHOD_RANGE_1.Visible = "False"
        L_FROM_METHOD_1.Visible = "True"
        T_FROM_METHOD_1.Visible = "True"
        L_TO_METHOD_1.Visible = "True"
        T_TO_METHOD_1.Visible = "True"
        L_UNIT_METHOD_1.Visible = "True"
        T_UNIT_METHOD_1.Visible = "True"
    End Sub

    Private Sub B_METHOD_PART_2_Click(sender As Object, e As EventArgs) Handles B_METHOD_PART_2.Click
        B_METHOD_PART_2.SendToBack()
        B_METHOD_PART_2.Visible = "False"
        B_METHOD_RANGE_2.SendToBack()
        B_METHOD_RANGE_2.Visible = "False"
        L_METHOD_2.Visible = "True"
        T_METHOD_2.Visible = "True"
    End Sub

    Private Sub B_METHOD_RANGE_2_Click(sender As Object, e As EventArgs) Handles B_METHOD_RANGE_2.Click
        B_METHOD_PART_2.SendToBack()
        B_METHOD_PART_2.Visible = "False"
        B_METHOD_RANGE_2.SendToBack()
        B_METHOD_RANGE_2.Visible = "False"
        L_FROM_METHOD_2.Visible = "True"
        T_FROM_METHOD_2.Visible = "True"
        L_TO_METHOD_2.Visible = "True"
        T_TO_METHOD_2.Visible = "True"
        L_UNIT_METHOD_2.Visible = "True"
        T_UNIT_METHOD_2.Visible = "True"
    End Sub

    Private Sub B_METHOD_PART_3_Click(sender As Object, e As EventArgs) Handles B_METHOD_PART_3.Click
        B_METHOD_PART_3.SendToBack()
        B_METHOD_PART_3.Visible = "False"
        B_METHOD_RANGE_3.SendToBack()
        B_METHOD_RANGE_3.Visible = "False"
        L_METHOD_3.Visible = "True"
        T_METHOD_3.Visible = "True"
    End Sub

    Private Sub B_METHOD_RANGE_3_Click(sender As Object, e As EventArgs) Handles B_METHOD_RANGE_3.Click
        B_METHOD_PART_3.SendToBack()
        B_METHOD_PART_3.Visible = "False"
        B_METHOD_RANGE_3.SendToBack()
        B_METHOD_RANGE_3.Visible = "False"
        L_FROM_METHOD_3.Visible = "True"
        T_FROM_METHOD_3.Visible = "True"
        L_TO_METHOD_3.Visible = "True"
        T_TO_METHOD_3.Visible = "True"
        L_UNIT_METHOD_3.Visible = "True"
        T_UNIT_METHOD_3.Visible = "True"
    End Sub

    Private Sub B_METHOD_PART_4_Click(sender As Object, e As EventArgs) Handles B_METHOD_PART_4.Click
        B_METHOD_PART_4.SendToBack()
        B_METHOD_PART_4.Visible = "False"
        B_METHOD_RANGE_4.SendToBack()
        B_METHOD_RANGE_4.Visible = "False"
        L_METHOD_4.Visible = "True"
        T_METHOD_4.Visible = "True"
    End Sub

    Private Sub B_METHOD_RANGE_4_Click(sender As Object, e As EventArgs) Handles B_METHOD_RANGE_4.Click
        B_METHOD_PART_4.SendToBack()
        B_METHOD_PART_4.Visible = "False"
        B_METHOD_RANGE_4.SendToBack()
        B_METHOD_RANGE_4.Visible = "False"
        L_FROM_METHOD_4.Visible = "True"
        T_FROM_METHOD_4.Visible = "True"
        L_TO_METHOD_4.Visible = "True"
        T_TO_METHOD_4.Visible = "True"
        L_UNIT_METHOD_4.Visible = "True"
        T_UNIT_METHOD_4.Visible = "True"
    End Sub

    Private Sub B_METHOD_PART_5_Click(sender As Object, e As EventArgs) Handles B_METHOD_PART_5.Click
        B_METHOD_PART_5.SendToBack()
        B_METHOD_PART_5.Visible = "False"
        B_METHOD_RANGE_5.SendToBack()
        B_METHOD_RANGE_5.Visible = "False"
        L_METHOD_5.Visible = "True"
        T_METHOD_5.Visible = "True"
    End Sub

    Private Sub B_METHOD_RANGE_5_Click(sender As Object, e As EventArgs) Handles B_METHOD_RANGE_5.Click
        B_METHOD_PART_5.SendToBack()
        B_METHOD_PART_5.Visible = "False"
        B_METHOD_RANGE_5.SendToBack()
        B_METHOD_RANGE_5.Visible = "False"
        L_FROM_METHOD_5.Visible = "True"
        T_FROM_METHOD_5.Visible = "True"
        L_TO_METHOD_5.Visible = "True"
        T_TO_METHOD_5.Visible = "True"
        L_UNIT_METHOD_5.Visible = "True"
        T_UNIT_METHOD_5.Visible = "True"
    End Sub

    Private Sub B_CLEAR_MAIN_Click(sender As Object, e As EventArgs) Handles B_CLEAR_MAIN.Click
        txtClear()

        For Each ctrl As Control In P_PART_VISIBLE.Controls
            P_PART_VISIBLE.Controls.Remove(ctrl)
            'ctrl.Dispose()
        Next
    End Sub

    Private Sub B_BACK_Click(sender As Object, e As EventArgs) Handles B_BACK.Click
        Me.Close()
    End Sub

    Public Sub UpdateDataGridView(dataTable As DataTable)
        D_DATA.DataSource = dataTable
    End Sub
End Class