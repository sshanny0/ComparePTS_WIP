Public Class MainMenu
    Private Sub MainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Show()
        Login.T_RFID.Clear()
        Login.T_RFID.Select()
        Me.Hide()
    End Sub
    Private Sub B_DAILY_MAINTENANCE_Click(sender As Object, e As EventArgs) Handles B_DAILY_MAINTENANCE.Click
        Dim f As New MainDailyMaintenance
        f.Show()
        f.T_LINE_CD.Select()
    End Sub

    Private Sub B_MASTER_MACHINE_Click(sender As Object, e As EventArgs) Handles B_MASTER_MACHINE.Click
        Dim f As New MasterMachine
        f.Show
        f.T_LINE_CD.Select()
    End Sub

    Private Sub B_MAINTENANCE_REPORT_Click(sender As Object, e As EventArgs) Handles B_MAINTENANCE_REPORT.Click
        Dim f As New MainMenuReport
        f.Show()
    End Sub

    Private Sub B_DAILY_CHECK_Click(sender As Object, e As EventArgs) Handles B_DAILY_CHECK.Click
        'Dim f As MachineCheck
        MachineCheck.Show()
    End Sub
End Class