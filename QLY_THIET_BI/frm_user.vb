Public Class frm_user

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        'MessageBox.Show(Form1.Bar1.SelectedDockTab)
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items.RemoveAt(ba.SelectedDockTab)
        Me.Close()
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If String.Equals(Me.txt_pass.Text, Me.txt_pass2.Text) Then 'Mật khẩu khớp với nhau
            cmd.CommandText = "INSERT INTO TAI_KHOAN VALUES ('" & Me.txt_username.Text.Trim & "','" & Me.txt_pass.Text.Trim & "','" & Me.cbbEmployees.SelectedValue.ToString.Trim & "','" & Me.dtp_date_create.Value.Date.ToString("MM/dd/yyyy") & "',N'" & cbb_state.SelectedItem.ToString & "','')"
            cmd.Connection = cnn
            cmd.ExecuteNonQuery()
            MessageBox.Show("Đã thêm người dùng thành công!", "Thông báo")
        Else
            MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo")
            Exit Sub
        End If
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM TAI_KHOAN"
        rs = cmd.ExecuteReader
        dtgvUser.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgvUser.Rows.Add(stt, rs.GetString(0), rs.GetString(1), rs.GetDateTime(3).ToString("dd/MM/yyyy"), rs.GetString(4), rs.GetValue(5))
        End While
        rs.Close()
    End Sub

    Private Sub frm_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Điền dữ liệu vào combobox nhân viên
        Dim dtEmployees As New DataTable
        'Điền dữ liệu vào Combobox loại thiết bị
        cmd.CommandText = "SELECT * FROM NHAN_VIEN"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtEmployees.Load(rs)
        rs.Close()
        cbbEmployees.DataSource = dtEmployees
        cbbEmployees.DisplayMember = dtEmployees.Columns(2).ToString
        cbbEmployees.ValueMember = dtEmployees.Columns(0).ToString
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM TAI_KHOAN,NHAN_VIEN WHERE TAI_KHOAN.MA_NV=NHAN_VIEN.MA_NV"
        rs = cmd.ExecuteReader
        dtgvUser.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgvUser.Rows.Add(stt, rs.GetString(0), rs.GetString(1), rs.GetDateTime(3).ToString("dd/MM/yyyy"), rs.GetString(4), rs.GetString(5), rs.GetString(8))
        End While
        rs.Close()


    End Sub

    Private Sub txt_pass2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pass2.GotFocus
        Me.txt_pass2.SelectAll()
    End Sub

    Private Sub txt_pass2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pass2.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_pass2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pass2.LostFocus
        If Me.txt_pass.Text <> Me.txt_pass2.Text Then
            MessageBox.Show("Mật khẩu không khớp!", "Thông báo")
        End If
    End Sub

    Private Sub txt_username_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_username.GotFocus
        txt_username.SelectAll()
    End Sub

    Private Sub txt_pass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pass.GotFocus
        txt_pass.SelectAll()
    End Sub

    Private Sub txt_pass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pass.KeyPress
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub dtgvUser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvUser.CellContentClick

    End Sub

    Private Sub dtgvUser_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dtgvUser.CellFormatting
        If e.ColumnIndex = 2 And e.Value <> Nothing Then
            e.Value = New String("*", e.Value.ToString.Trim.Length)
        End If
    End Sub
End Class