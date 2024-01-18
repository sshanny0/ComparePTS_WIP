Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class DialogUpdateDelete
    Public Property LineCode As String
    Public Property MachineCode As String
    Public Property UnitName As String
    Public Property PartName As String
    Public Property MethodName As String
    Public Property MethodPart As String
    Public Property MethodRangeFrom As String
    Public Property MethodRangeTo As String
    Public Property MethodRangeUnit As String

    Private Sub B_DELETE_Click(sender As Object, e As EventArgs) Handles B_DELETE.Click
        Dim DDD As New DialogDeleteDetail
        DDD.LineCode = LineCode
        DDD.MachineCode = MachineCode
        DDD.UnitName = UnitName
        DDD.PartName = PartName
        DDD.MethodName = MethodName
        DDD.MethodPart = MethodPart
        DDD.MethodRangeFrom = MethodRangeFrom
        DDD.MethodRangeTo = MethodRangeTo
        DDD.MethodRangeUnit = MethodRangeUnit
        DDD.Show()
    End Sub

    Private Sub B_UPDATE_Click(sender As Object, e As EventArgs) Handles B_UPDATE.Click
        Dim DUDT As New DialogUpdateDetail
        DUDT.LineCode = LineCode
        DUDT.MachineCode = MachineCode
        DUDT.UnitName = UnitName
        DUDT.PartName = PartName
        DUDT.MethodName = MethodName
        DUDT.MethodPart = MethodPart
        DUDT.MethodRangeFrom = MethodRangeFrom
        DUDT.MethodRangeTo = MethodRangeTo
        DUDT.MethodRangeUnit = MethodRangeUnit
        DUDT.Show()
    End Sub

    Private Sub B_CANCEL_Click(sender As Object, e As EventArgs) Handles B_CANCEL.Click
        Me.Close()
    End Sub

    Private Sub DialogUpdateDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        B_DELETE.Focus()
        TXT_INFO.Text = "


        LINE " & LineCode & ", MACHINE " & MachineCode & ", UNIT " & UnitName & ", PART " & PartName & ", METHOD " & MethodName & " "
    End Sub
End Class
