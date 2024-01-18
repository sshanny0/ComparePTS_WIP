Imports System.Reflection
Imports ZXing
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'BARCODE
        'Dim barcodegen As New BarcodeWriter
        'barcodegen.Format = BarcodeFormat.CODE_128
        'PictureBox1.Image = barcodegen.Write(TextBox1.Text)

        'QRCODE
        'Dim qrcode As New BarcodeWriter
        'qrcode.Format = BarcodeFormat.QR_CODE
        'PictureBox1.Image = qrcode.Write(TextBox1.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''MODULE ASSY
        'Dim strYear As String = Today.Year
        'strYear = strYear.Substring(strYear.Length - 1)

        'Dim strMonth As String = Today.Month
        'If strMonth = "10" Then
        '    strMonth = "X"
        'ElseIf strMonth = "11" Then
        '    strMonth = "Y"
        'ElseIf strMonth = "12" Then
        '    strMonth = "Z"
        'End If

        'For counter = Convert.ToInt32(TextBox1.Text) To 99 To 99999
        '    'MsgBox("981" + strYear + strMonth + counter.ToString("00000"))
        'Next

        ''MODULE HK (BELUM ADA LOOPING PLUS HURUF DIDEPANNYA)
        'Dim queryFactory As String = String.Empty
        'queryFactory &= "SELECT fcode FROM PCB_Prod_Factory "
        'queryFactory &= "WHERE fdesc = 'PT. KAI'"

        'Dim dt As DataTable = GetDataTDF(queryFactory)
        'Dim codeFac As String = dt.Rows(0).Item("fcode").ToString()

        'Dim a As Char = "a"
        'a = Chr(Asc(a) + 1)
        'MsgBox(a)
    End Sub
End Class