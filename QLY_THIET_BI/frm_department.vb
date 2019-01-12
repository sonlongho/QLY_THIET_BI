Public Class frm_department

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items(10).Visible = False
        If frm_main.Bar1.SelectedDockTab.ToString() = -1 Then 'Neu khong con tab nao mo thi an luon bar
            frm_main.Bar1.Visible = False
        End If
        Me.Close()
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        'Tạo mã phòng khoa
        Dim departmentName As String = ""
        Dim departmentCode As String = ""
        Dim str As String = ""
        Dim intCode As Integer = 1
        cmd.CommandText = "SELECT MA_PB FROM PHONG_BAN ORDER BY MA_PB"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        If rs.HasRows Then
            While rs.Read
                intCode = CInt(rs.GetString(0).Substring(2, 2)) + 1
            End While
        End If
        rs.Close()
        'Tao ma
        departmentName = Me.txt_name.Text.Trim
        If departmentName.Split(" ")(0) = "Khoa" Then
            departmentCode = "KH"
        Else
            departmentCode = "PH"
        End If
        If intCode < 10 Then
            departmentCode &= "0" & intCode.ToString
        Else
            departmentCode &= intCode.ToString
        End If

        cmd.CommandText = "INSERT INTO PHONG_BAN VALUES ('" & departmentCode & "',N'" & departmentName & "',N'" & Me.txt_address.Text.Trim & "','" & Me.txt_phone.Text.Trim & "','" & Me.txt_email.Text.Trim & "','" & Me.dtp_date_create.Value.Date.ToString("MM/dd/yyyy") & "','" & Me.txt_comment.Text.Trim & "')"
        cmd.Connection = cnn
        cmd.ExecuteNonQuery()
        MessageBox.Show("Đã thêm phòng ban thành công!", "Thông báo")
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM PHONG_BAN"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtgv_department.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgv_department.Rows.Add(stt, rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetDateTime(5).ToString("dd/MM/yyyy"), rs.GetValue(5))
        End While
        rs.Close()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        'MessageBox.Show(Form1.Bar1.SelectedDockTab)
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items.RemoveAt(ba.SelectedDockTab)
        Me.Close()
    End Sub

    Private Sub frm_department_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM PHONG_BAN"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtgv_department.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgv_department.Rows.Add(stt, rs.GetString(1), rs.GetString(2), rs.GetString(3), rs.GetString(4), rs.GetDateTime(5).ToString("dd/MM/yyyy"), rs.GetValue(5))
        End While
        rs.Close()
    End Sub
End Class