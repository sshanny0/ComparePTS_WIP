Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_assy.Select()
    End Sub
    Private Sub btn_assy_Click(sender As Object, e As EventArgs) Handles btn_assy.Click
        Assy.Show()
        Me.Hide()
    End Sub

    Private Sub btn_hk_Click(sender As Object, e As EventArgs) Handles btn_hk.Click
        CodeHK.Show()
        Me.Hide()
    End Sub

    Private Sub btn_if_Click(sender As Object, e As EventArgs) Handles btn_if.Click
        CodeIF.Show()
        Me.Hide()
    End Sub

    Private Sub btn_sw_Click(sender As Object, e As EventArgs) Handles btn_sw.Click
        CodeSW.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ma_Click(sender As Object, e As EventArgs) Handles btn_ma.Click
        CodeMA.Show()
        Me.Hide()
    End Sub

    Private Sub btn_pbm_Click(sender As Object, e As EventArgs) Handles btn_pbm.Click
        PBMQRCode.Show()
        Me.Hide()
    End Sub
End Class