Public Class frm_position

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items(9).Visible = False
        If frm_main.Bar1.SelectedDockTab.ToString() = -1 Then 'Neu khong con tab nao mo thi an luon bar
            frm_main.Bar1.Visible = False
        End If
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim position_code As String = ""
        Dim intCode As Integer = 1
        cmd.CommandText = "SELECT MA_CV FROM CHUC_VU ORDER BY MA_CV"
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
            position_code &= "CV0" & intCode.ToString
        Else
            position_code &= "CV" & intCode.ToString
        End If
        'Thêm Chức vụ
        cmd.CommandText = "INSERT INTO CHUC_VU VALUES ('" & position_code & "',N'" & Me.txt_name.Text.Trim & "',N'" & Me.txt_comment.Text.Trim & "')"
        cmd.Connection = cnn
        cmd.ExecuteNonQuery()
        MessageBox.Show("Đã thêm chức vụ thành công!", "Thông báo")
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM CHUC_VU"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtgv_position.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgv_position.Rows.Add(stt, rs.GetString(1), rs.GetString(2))
        End While
        rs.Close()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items.RemoveAt(ba.SelectedDockTab)
        Me.Close()
    End Sub

    Private Sub frm_position_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM CHUC_VU"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtgv_position.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgv_position.Rows.Add(stt, rs.GetString(1), rs.GetString(2))
        End While
        rs.Close()
    End Sub
End Class