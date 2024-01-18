Imports System.Data.SqlClient

Public Class Main

    Function ExecuteQueryTDF(ByVal stringQuery)
        Dim sqlcon = New SqlConnection(My.Settings.TDF)
        sqlcon.Open()
        Dim com = New SqlCommand(stringQuery, sqlcon)

        Try
            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqlcon.Close()
    End Function

    Private Sub txt_main_input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_main_input.KeyPress
        If e.KeyChar = "@" Then
            txt_assy_c.Focus()
        Else
            Me.Enabled = False
            DialogWarning.Show()
        End If
    End Sub

    Private Sub txt_assy_c_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_assy_c.KeyPress
        If e.KeyChar = "@" Then
            e.Handled = True ' Mengabaikan karakter '@' agar tidak ditampilkan di txt_assy_c

            If txt_mil_no.Text.Length > 0 Then
                Dim mil_no = txt_mil_no.Text.Substring(0, txt_mil_no.Text.Length - 1)
                txt_mil_no.Text = mil_no
            End If

            txt_mil_no.Focus() ' Memindahkan fokus ke txt_mil_no
            txt_mil_no.SelectionStart = txt_mil_no.Text.Length ' Menentukan posisi kursor di akhir teks
        End If
    End Sub

    Private Sub txt_mil_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mil_no.KeyPress
        If e.KeyChar = "@" Then
            e.Handled = True ' Mengabaikan karakter '@' agar tidak ditampilkan di txt_assy_c

            If txt_line.Text.Length > 0 Then
                Dim mil_no = txt_line.Text.Substring(0, txt_line.Text.Length - 1)
                txt_line.Text = mil_no
            End If

            txt_line.Focus() ' Memindahkan fokus ke txt_line
            txt_line.SelectionStart = txt_line.Text.Length ' Menentukan posisi kursor di akhir teks
        End If
    End Sub

    Private Sub txt_line_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_line.KeyPress
        If e.KeyChar = "@" Then
            e.Handled = True ' Mengabaikan karakter '@' agar tidak ditampilkan di txt_assy_c

            If txt_model.Text.Length > 0 Then
                Dim mil_no = txt_model.Text.Substring(0, txt_model.Text.Length - 1)
                txt_model.Text = mil_no
            End If

            txt_model.Focus() ' Memindahkan fokus ke txt_model
            txt_model.SelectionStart = txt_model.Text.Length ' Menentukan posisi kursor di akhir teks
        End If
    End Sub

    Private Sub txt_model_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_model.KeyPress
        If e.KeyChar = "@" Then
            e.Handled = True ' Mengabaikan karakter '@' agar tidak ditampilkan di txt_assy_c

            If txt_ref_no.Text.Length > 0 Then
                txt_ref_no.Text = txt_ref_no.Text.Substring(0, txt_ref_no.Text.Length - 1)
            End If

            txt_ref_no.Focus()
            txt_ref_no.SelectionStart = txt_ref_no.Text.Length ' Menentukan posisi kursor di akhir teks
        End If
    End Sub

    Private Sub txt_ref_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ref_no.KeyPress
        If e.KeyChar = "@" Then
            e.Handled = True ' Mengabaikan karakter '@' agar tidak ditampilkan di txt_assy_c

            If txt_job_number.Text.Length > 0 Then
                txt_job_number.Text = txt_job_number.Text.Substring(0, txt_job_number.Text.Length - 1)
            End If

            txt_job_number.Focus()
            txt_job_number.SelectionStart = txt_job_number.Text.Length ' Menentukan posisi kursor di akhir teks
        End If
    End Sub

    Private Sub txt_job_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_job_number.KeyPress
        If e.KeyChar = "@" Then
            e.Handled = True ' Mengabaikan karakter '@' agar tidak ditampilkan di txt_assy_c

            If txt_seq.Text.Length > 0 Then
                txt_seq.Text = txt_seq.Text.Substring(0, txt_seq.Text.Length - 1)
            End If

            txt_seq.Focus()
            txt_seq.SelectionStart = txt_seq.Text.Length ' Menentukan posisi kursor di akhir teks
        End If
    End Sub

    Private Sub txt_seq_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_seq.KeyDown
        If e.KeyCode = Keys.Enter Then
            N_QTY.Select()
        End If
    End Sub

    Private Sub INPUT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_main_input.Select()
    End Sub
    Public Sub txtClear()
        For Each txt In {txt_assy_c, txt_job_number, txt_line, txt_main_input, txt_mil_no, txt_model, txt_ref_no, txt_seq}
            txt.Clear()
        Next
        N_QTY.Value = 0
        txt_main_input.Select()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_SAVE.Click
        If txt_main_input.Text = "" Then
            MsgBox("PLEASE SCAN QR CODE FIRST!", MsgBoxStyle.Exclamation, "WARNING")
            txt_main_input.Select()
        ElseIf N_QTY.Value = 0 Then
            MsgBox("QUANTITY CANNOT BE BLANK!", MsgBoxStyle.Exclamation, "WARNING")
            N_QTY.Select()
        Else

            Dim queryCheck As String = String.Empty
            queryCheck &= " SELECT * FROM WIP_AUTO_MOUNTING WHERE ref_no = '" & txt_ref_no.Text & "' "

            Using con As New SqlConnection(My.Settings.TDF)
                Using cmd As New SqlCommand(queryCheck, con)
                    con.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader
                        If reader.HasRows Then
                            MsgBox("DATA IS EXIST!", MsgBoxStyle.Critical, "ERROR")
                            txtClear()

                        Else
                            Dim stringQuery As String = " INSERT INTO WIP_AUTO_MOUNTING (assy_code, lot_no, line, model, ref_no, job_number, seq, created_at, qty) 
                            VALUES (UPPER('" & txt_assy_c.Text & "'), UPPER('" & txt_mil_no.Text & "'), UPPER('" & txt_line.Text & "'), UPPER('" & txt_model.Text & "'), '" & txt_ref_no.Text & "', 
                            UPPER('" & txt_job_number.Text & "'), '" & txt_seq.Text & "', GETDATE(), '" & N_QTY.Text & "') "

                            ExecuteQueryTDF(stringQuery)
                            MsgBox("SUCCESSFULLY ADDED!", MsgBoxStyle.Information, "INFORMATION")
                            txtClear()
                        End If
                    End Using
                    con.Close()
                End Using
            End Using
        End If
    End Sub


End Class
