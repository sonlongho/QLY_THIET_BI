Public Class frm_user_update
    Dim username As String
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items.RemoveAt(ba.SelectedDockTab)
        Me.Close()
    End Sub

    Private Sub frm_user_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub dtgvUser_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dtgvUser.CellFormatting
        If e.ColumnIndex = 2 And e.Value <> Nothing Then
            e.Value = New String("*", e.Value.ToString.Trim.Length)
        End If
    End Sub

    Private Sub dtgvUser_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgvUser.CurrentCellChanged
        If Not dtgvUser.CurrentCell Is Nothing Then
            Me.txtUsername.Text = dtgvUser.CurrentRow.Cells(1).Value.ToString.Trim
            username = Me.txtUsername.Text
            Me.txt_pass.Text = dtgvUser.CurrentRow.Cells(2).Value.ToString.Trim
            Me.txt_pass2.Text = dtgvUser.CurrentRow.Cells(2).Value.ToString.Trim
            Me.dtp_date_create.Value = Me.dtgvUser.CurrentRow.Cells(3).Value
            Me.cbb_state.Text = Me.dtgvUser.CurrentRow.Cells(4).Value
            Me.txtComment.Text = Me.dtgvUser.CurrentRow.Cells(5).Value
            Me.cbbEmployees.Text = dtgvUser.CurrentRow.Cells(6).Value.ToString.Trim
        End If


    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        If Me.txt_pass.Text <> Me.txt_pass2.Text Then
            MessageBox.Show("Mật khẩu không khớp!", "Thông báo")
            Exit Sub
        End If
        cmd.CommandText = "UPDATE TAI_KHOAN SET USERNAME='" & Me.txtUsername.Text.Trim & "',PASSWORD='" & Me.txt_pass.Text & "',NGAY_TAO='" & Me.dtp_date_create.Value.Date.ToString("MM/dd/yyyy") & "',TRANG_THAI=N'" & cbb_state.SelectedItem.ToString & "',GHI_CHU=N'" & Me.txtComment.Text.ToString & "' WHERE USERNAME='" & username & "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Đã cập nhật thông tin người dùng!", "Thông báo")
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

    Private Sub dtgvUser_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvUser.CellContentClick

    End Sub

    Private Sub txt_pass2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pass2.LostFocus
        If Me.txt_pass.Text <> Me.txt_pass2.Text Then
            MessageBox.Show("Mật khẩu không khớp!", "Thông báo")
        End If
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        cmd.CommandText = "DELETE FROM TAI_KHOAN WHERE USERNAME='" & Me.txtUsername.Text.Trim & "'"
        cmd.Connection = cnn
        cmd.ExecuteNonQuery()
        MessageBox.Show("Đã xóa người dùng!", "Thông báo")
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
End Class