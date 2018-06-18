Public Class frm_user

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        'MessageBox.Show(Form1.Bar1.SelectedDockTab)
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items.RemoveAt(frm_main.Bar1.SelectedDockTab)
        Me.Close()
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        cmd.CommandText = "INSERT INTO TAI_KHOAN VALUES ('" & Me.txt_username.Text.Trim & "','" & Me.txt_pass.Text.Trim & "',N'" & Me.txt_name.Text.Trim & "','" & Me.dtp_date_create.Value.Date.ToString("MM/dd/yyyy") & "','" & Me.txt_email.Text.Trim & "','" & Me.cbb_state.SelectedIndex & "','')"
        cmd.Connection = cnn
        cmd.ExecuteNonQuery()
        MessageBox.Show("Đã thêm người dùng thành công!", "Thông báo")
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM TAI_KHOAN"
        rs = cmd.ExecuteReader
        dtgv_user.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgv_user.Rows.Add(stt, rs.GetString(2), rs.GetString(0), rs.GetString(1), rs.GetValue(3).ToString("dd/MM/yyyy"), rs.GetString(4), rs.GetValue(5))
        End While
        rs.Close()
    End Sub

    Private Sub frm_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM TAI_KHOAN"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtgv_user.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgv_user.Rows.Add(stt, rs.GetString(2), rs.GetString(0), rs.GetString(1), rs.GetDateTime(3).ToString("dd/MM/yyyy"), rs.GetString(4), rs.GetValue(5))
        End While
        rs.Close()
    End Sub

    Private Sub txt_pass2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pass2.GotFocus
        Me.txt_pass2.SelectAll()
    End Sub

    Private Sub txt_pass2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pass2.LostFocus
        If Me.txt_pass.Text <> Me.txt_pass2.Text Then
            MessageBox.Show("Mật khẩu không khớp, vui lòng nhập lại", "Thông báo")
        End If
    End Sub

    Private Sub txt_name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_name.GotFocus
        txt_name.SelectAll()
    End Sub

    Private Sub txt_username_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_username.GotFocus
        txt_username.SelectAll()
    End Sub

    Private Sub txt_pass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pass.GotFocus
        txt_pass.SelectAll()
    End Sub

    Private Sub txt_email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_email.TextChanged
        txt_email.SelectAll()
    End Sub
End Class