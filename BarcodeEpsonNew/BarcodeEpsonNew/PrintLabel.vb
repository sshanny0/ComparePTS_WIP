Imports System.Data.SqlClient
Imports ZXing

Public Class PrintLabel

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim queryCheck As String = String.Empty
        queryCheck &= "SELECT TOP 1 * FROM PCB_Prod_SrNo "
        queryCheck &= "WHERE Model = '" & cmb_model.Text & "' "
        'queryCheck &= "AND Assy_Cd = '" 'CHECK ASSY CODE DENGAN MODEL TERSEBUT APAKAH SUDAH ADA APA BELOM
        queryCheck &= "ORDER BY SR_COUNT DESC "

        Dim reader As ModSqlRaeder = getDataReaderTDF(queryCheck)
        If reader.sqlDataReader IsNot Nothing Then
            Dim queryModel As String = String.Empty
            queryModel &= "SELECT ModelDesc FROM PCB_Prod_Model "
            queryModel &= "WHERE ModelNo = '" & cmb_model.Text & "' "

            Dim dt As DataTable = GetDataTDF(queryModel)
            Dim ModelName As String = dt.Rows(0).Item("ModelDesc").ToString()

            If ModelName = "HK" Then
            ElseIf ModelName = "IF" Then
                'INSERT DENGAN SERIAL NUMBER TERAKHIR
                Dim queryInsert As String = String.Empty
                queryInsert &= "INSERT INTO PCB_Prod_SrNo (Sr_No, Sr_Count, Model, Assy_Cd, Created_At) "

            ElseIf ModelName = "SW" Then
            ElseIf ModelName = "MA" Then
            ElseIf ModelName = "Module Assy" Then
            End If
        End If
    End Sub

    Private Sub PrintLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim queryModel As String = String.Empty
        queryModel &= "SELECT * FROM PCB_Prod_Model"

        Dim dt As DataTable = GetDataTDF(queryModel)
        With cmb_model
            .DataSource = dt
            .ValueMember = "ModelNo"
            .DisplayMember = "ModelNo"
            .SelectedIndex = -1
        End With
    End Sub
End Class