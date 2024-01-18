Public Class MainMenuReport
    Private Sub B_DAILY_MAINTENANCE_Click(sender As Object, e As EventArgs) Handles B_DAILY_MAINTENANCE.Click
        Dim f As New DailyReport
        f.Show()
    End Sub

    Private Sub B_WEEK_MAINTENANCE_Click(sender As Object, e As EventArgs) Handles B_WEEK_MAINTENANCE.Click
        Dim f As New WeekReport
        f.Show()
    End Sub

    Private Sub B_MONTH_MAINTENANCE_Click(sender As Object, e As EventArgs) Handles B_MONTH_MAINTENANCE.Click
        Dim f As New MonthlyReport
        f.Show()
        f.T_LINE_CD.Select()
    End Sub

    Private Sub B_BACK_Click_1(sender As Object, e As EventArgs) Handles B_BACK.Click
        Me.Close()
    End Sub
End Class