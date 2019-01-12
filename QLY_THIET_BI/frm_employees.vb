Public Class frm_employees

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dtDepartment As New DataTable
        Dim dtPosition As New DataTable
        'Điền dữ liệu vào Combobox Phòng ban
        cmd.CommandText = "SELECT * FROM PHONG_BAN"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtDepartment.Load(rs)
        rs.Close()
        cbb_department.DataSource = dtDepartment
        cbb_department.DisplayMember = dtDepartment.Columns(1).ToString
        cbb_department.ValueMember = dtDepartment.Columns(0).ToString
        'Điền dữ liệu vào Combobox Chức vụ
        cmd.CommandText = "SELECT * FROM CHUC_VU"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtPosition.Load(rs)
        rs.Close()
        cbbPosition.DataSource = dtPosition
        cbbPosition.DisplayMember = dtPosition.Columns(1).ToString
        cbbPosition.ValueMember = dtPosition.Columns(0).ToString
        'Fill dữ liệu vào DatagrirdView
        cmd.CommandText = "SELECT * FROM NHAN_VIEN"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtgv_employees.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgv_employees.Rows.Add(stt, rs.GetString(2), rs.GetString(3), rs.GetDateTime(4).ToString("MM/dd/yyyy"), rs.GetString(5), rs.GetString(6), rs.GetString(7), rs.GetString(8), rs.GetString(0), rs.GetString(1))
        End While
        rs.Close()
    End Sub
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items(11).Visible = False
        If frm_main.Bar1.SelectedDockTab.ToString() = -1 Then 'Neu khong con tab nao mo thi an luon bar
            frm_main.Bar1.Visible = False
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        'Tạo mã nhân viên
        Dim employee_code As String = ""
        Dim str As String = ""
        Dim intCode As Integer = 1
        cmd.CommandText = "SELECT MA_NV FROM NHAN_VIEN ORDER BY MA_NV"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        If rs.HasRows Then
            While rs.Read
                intCode = CInt(rs.GetString(0).Substring(2, 2)) + 1
            End While
        End If
        rs.Close()
        'Tạo mã
        If intCode < 10 Then
            employee_code &= "NV0" & intCode.ToString
        Else
            employee_code &= "NV" & intCode.ToString
        End If
        'Thêm Chức vụ
        cmd.CommandText = "INSERT INTO NHAN_VIEN VALUES ('" & employee_code & "','" & Me.cbb_department.SelectedValue.ToString.Trim & "',N'" & Me.txt_name.Text.Trim & "',N'" & Me.cbb_sex.Text.Trim & "','" & Me.dtp_date_of_birth.Value.Date.ToString("MM/dd/yyyy") & "',N'" & Me.txt_place_of_birth.Text.Trim & "',N'" & Me.txt_address.Text.Trim & "','" & Me.txt_email.Text.Trim & "','" & Me.txt_phone.Text.Trim & "')"
        cmd.Connection = cnn
        cmd.ExecuteNonQuery()
        MessageBox.Show("Đã thêm nhân viên thành công!", "Thông báo")
        'Thêm chức vụ của nhân viên vào bảng NV_CHUC_VU
        cmd.CommandText = "INSERT INTO NV_CHUC_VU VALUES ('" & employee_code & "','" & Me.cbbPosition.SelectedValue.ToString.Trim & "',N'')"
        cmd.Connection = cnn
        cmd.ExecuteNonQuery()

        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM NHAN_VIEN"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtgv_employees.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgv_employees.Rows.Add(stt, rs.GetString(2), rs.GetString(3), rs.GetDateTime(4).ToString("MM/dd/yyyy"), rs.GetString(5), rs.GetString(6), rs.GetString(7), rs.GetString(8), rs.GetString(0), rs.GetString(1))
        End While
        rs.Close()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items.RemoveAt(ba.SelectedDockTab)
        Me.Close()
    End Sub

    Private Sub cbbPosition_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbPosition.MouseHover
        tt.SetToolTip(cbbPosition, cbbPosition.Text)
    End Sub

    Private Sub cbbPosition_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbPosition.SelectedIndexChanged

    End Sub
End Class