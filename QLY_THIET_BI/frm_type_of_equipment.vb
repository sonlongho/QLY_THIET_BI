Public Class frm_type_of_equipment

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items(4).Visible = False
        If frm_main.Bar1.SelectedDockTab.ToString() = -1 Then 'Neu khong con tab nao mo thi an luon bar
            frm_main.Bar1.Visible = False
        End If
        Me.Close()
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim type_code As String = ""
        Dim check As Boolean = True
        cmd.CommandText = "SELECT MA_LOAI FROM LOAI_TB ORDER BY MA_LOAI"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        If rs.HasRows Then
            While rs.Read
                If String.Equals(rs.GetString(0).Trim, Me.txt_code.Text.Trim) Then 'Compare case-sensitive
                    check = False
                    Exit While
                End If
            End While
        End If
        rs.Close()
        If check = False Then
            MessageBox.Show("Trùng mã loại!", "Thông báo")
            Exit Sub
        End If
        'Thêm Chức vụ
        cmd.CommandText = "INSERT INTO LOAI_TB VALUES ('" & Me.txt_code.Text.Trim & "',N'" & Me.txt_name.Text.Trim & "',N'" & Me.txt_comment.Text.Trim & "')"
        cmd.Connection = cnn
        cmd.ExecuteNonQuery()
        MessageBox.Show("Đã thêm loại thiết bị thành công!", "Thông báo")
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM LOAI_TB"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtgv_position.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgv_position.Rows.Add(stt, rs.GetString(0), rs.GetString(1), rs.GetString(2))
        End While
        rs.Close()
    End Sub

    Private Sub txt_code_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_code.GotFocus
        'Tạo mã
        Dim type_code As String
        type_code = CreateCode(Me.txt_name.Text)
        Me.txt_code.Text = type_code
    End Sub

    Private Sub txt_code_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_code.TextChanged

    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items.RemoveAt(ba.SelectedDockTab)
        Me.Close()
    End Sub

    Private Sub frm_type_of_equipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM LOAI_TB"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtgv_position.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgv_position.Rows.Add(stt, rs.GetString(0), rs.GetString(1), rs.GetString(2))
        End While
        rs.Close()
    End Sub
End Class