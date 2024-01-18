Public Class DialogWarning
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Enabled = True
        Main.txtClear()
        Me.Close()
    End Sub
End Class