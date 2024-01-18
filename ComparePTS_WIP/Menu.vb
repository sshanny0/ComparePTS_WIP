Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub B_INPUT_Click(sender As Object, e As EventArgs) Handles B_INPUT.Click
        Dim f As New Main
        Main.Show()
    End Sub

    Private Sub B_REPORT_Click(sender As Object, e As EventArgs) Handles B_REPORT.Click
        Dim f As New Report_2
        f.Show()
    End Sub

    Private Sub B_DETAIL_Click(sender As Object, e As EventArgs) Handles B_DETAIL.Click
        Dim f As New Detail
        f.Show()
    End Sub
End Class