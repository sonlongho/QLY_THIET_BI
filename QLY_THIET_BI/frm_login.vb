Public Class frm_login

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Me.Cursor = Cursors.WaitCursor
        cmd.CommandText = "SELECT * FROM TAI_KHOAN WHERE USERNAME='" & Me.txtUsername.Text.Trim & "'"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        If rs.HasRows Then 'Có username này trong cơ sở dữ liệu
            While rs.Read
                'Kiểm tra trạng thái của tài khoản
                If String.Equals(rs.GetString(4).Trim, "Vô hiệu") Then
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("Tài khoản này đã bị vô hiệu hóa.", "Thông báo")
                    rs.Close()
                    Exit Sub
                ElseIf String.Equals(rs.GetString(4).Trim, "Tạm dừng") Then
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("Tài khoản này đang tạm dừng hoạt động, vui lòng kích hoạt tài khoản.", "Thông báo")
                    rs.Close()
                    Exit Sub
                Else 'Tài khoản đang hoạt động
                    'Kiểm tra xem có nhập đúng mật khẩu không
                    If String.Equals(Me.txtPassword.Text.Trim, rs.GetString(1).Trim) Then
                        userCode = rs.GetString(2).Trim
                        rs.Close()
                        frm_main.Show()
                        Me.Cursor = Cursors.Default
                        Me.Close()
                        Exit Sub
                    Else 'Không đúng mật khẩu
                        Me.Cursor = Cursors.Default
                        MessageBox.Show("Nhập lại mật khẩu", "Thông báo!")
                        Exit Sub
                    End If
                End If
            End While
        Else
            rs.Close()
        End If
    End Sub

    Private Sub frm_login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cnn.Open()
    End Sub

    Private Sub bntExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntExit.Click
        End
    End Sub
End Class
