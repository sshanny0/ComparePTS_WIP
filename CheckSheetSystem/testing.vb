
Public Class testing
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AddNewTextBox()
        AddNewLabel()
        AddNewButton()
    End Sub


    Public Sub AddNewTextBox()
        Dim TextBoxTextToCheckDynamic As String = "TextBox" & (Panel1.Controls.OfType(Of TextBox)().Count + 1).ToString()

        If Not Panel1.Controls.OfType(Of TextBox)().Any(Function(txt) txt.Text = TextBoxTextToCheckDynamic) Then
            Dim textbox As New TextBox
            Panel1.Controls.Add(textbox)

            textbox.Left = 114

            If Panel1.Controls.OfType(Of TextBox)().Count = 1 Then
                textbox.Top = 1 * 30 ' Jika ini label pertama
            Else
                ' Gunakan nilai yang sesuai untuk label selanjutnya
                textbox.Top = (Panel1.Controls.OfType(Of TextBox)().Count - 1) * 35 + Panel1.Controls.OfType(Of Button)().Count * 45
            End If

            textbox.Text = TextBoxTextToCheckDynamic
        End If
    End Sub

    Public Sub AddNewLabel()
        Dim labelTextToCheckDynamic As String = "Label" & (Panel1.Controls.OfType(Of Label)().Count + 1).ToString()

        If Not Panel1.Controls.OfType(Of Label)().Any(Function(lbl) lbl.Text = labelTextToCheckDynamic) Then
            Dim label As New Label
            Panel1.Controls.Add(label)

            label.Left = 21

            If Panel1.Controls.OfType(Of Label)().Count = 1 Then
                label.Top = 1 * 30 ' Jika ini label pertama
            Else
                ' Gunakan nilai yang sesuai untuk label selanjutnya
                label.Top = (Panel1.Controls.OfType(Of Label)().Count - 1) * 35 + Panel1.Controls.OfType(Of Button)().Count * 45
            End If

            label.Text = labelTextToCheckDynamic
        End If
    End Sub

    Public Sub AddNewButton()
        Dim ButtonTextToCheckDynamic As String = "Button" & (Panel1.Controls.OfType(Of Button)().Count + 1).ToString()

        If Not Panel1.Controls.OfType(Of Button)().Any(Function(btn) btn.Text = ButtonTextToCheckDynamic) Then
            Dim button As New Button
            Panel1.Controls.Add(button)

            button.Left = 21

            If Panel1.Controls.OfType(Of Button)().Count = 1 Then
                button.Top = 1 * 52 ' Jika ini tombol pertama
            Else
                ' Gunakan nilai yang sesuai untuk tombol selanjutnya
                button.Top = (Panel1.Controls.OfType(Of Button)().Count - 1) * 45 + Panel1.Controls.OfType(Of Label)().Count * 35
            End If

            button.Text = ButtonTextToCheckDynamic
        End If
    End Sub

    Private Sub testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class