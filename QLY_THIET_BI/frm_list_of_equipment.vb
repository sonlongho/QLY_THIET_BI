Imports System.Data.SqlClient
Imports System.IO
Public Class frm_list_of_equipment

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'MessageBox.Show(Form1.Bar1.SelectedDockTab)
        Dim ba As DevComponents.DotNetBar.Bar
        ba = Me.Owner.Controls(0).Controls(0)
        ba.Items.RemoveAt(ba.SelectedDockTab)
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'MessageBox.Show(OpenFileDialog1.FileName)
        Dim equipmentCode As String = ""
        Dim departmentCode As String = ""
        Dim typeOfElementCode As String = ""
        Dim intCode As Integer = 1
        'Tạo mã thiết bị
        equipmentCode = Me.cbbTypeOfEquipment.SelectedValue.ToString.Trim
        equipmentCode &= Me.dtp_date_buy.Value.Year.ToString.Substring(2, 2)
        cmd.CommandText = "SELECT MA_TB FROM THIET_BI WHERE MA_TB LIKE '" & equipmentCode & "%' ORDER BY MA_TB"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        If rs.HasRows Then
            While rs.Read
                intCode = CInt(rs.GetString(0).Substring(5, 2)) + 1
            End While
        End If
        rs.Close()
        'Tạo mã
        If intCode < 10 Then
            equipmentCode &= "0" & intCode.ToString
        Else
            equipmentCode &= intCode.ToString
        End If
        'Thêm Thiết bị
        departmentCode = Me.cbbDepartment.SelectedValue.Trim
        typeOfElementCode = Me.cbbTypeOfEquipment.SelectedValue.Trim
        'Chuyển image sang dữliệu lưu được trong SQL server
        Dim raw As Byte()
        Dim imgData As New SqlParameter("@photo", SqlDbType.Image)
        If btn_image.Text.ToString.Contains("Chọn ảnh SP") Then
            imgData.Value = DBNull.Value
        Else
            Dim br As BinaryReader = New BinaryReader(System.IO.File.OpenRead(OpenFileDialog1.FileName))
            raw = br.ReadBytes(br.BaseStream.Length)
            imgData.Value = raw
        End If
        cmd.CommandText = "INSERT INTO THIET_BI VALUES ('" & equipmentCode & "','" & departmentCode & "','" & typeOfElementCode & "',N'" & Me.txt_name.Text.Trim & "','" & Me.dtp_product.Value.Date.ToString("MM/dd/yyyy") & "',N'" & Me.txt_made_in.Text.Trim & "',N'" & Me.txt_brand.Text.Trim & "',N'" & Me.cbb_unit.Text.Trim & "',N'" & Me.cbb_status.Text.Trim & "',@photo," & CDec(Me.txt_price.Text) & ",N'')"
        cmd.Connection = cnn
        cmd.Parameters.Add(imgData)
        cmd.ExecuteNonQuery()
        'Thêm dữ liệu vào bảng NHAP_THIET_BI
        cmd.CommandText = "INSERT INTO NHAP_THIET_BI VALUES ('" & userCode & "','" & equipmentCode & "','" & Me.dtp_product.Value.Date.ToString("MM/dd/yyyy") & "',N'" & Me.txt_comment.Text.Trim & "')"
        cmd.Connection = cnn
        cmd.ExecuteNonQuery()
        MessageBox.Show("Đã thêm thiết bị thành công!", "Thông báo")
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM THIET_BI"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtgvEmployees.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1
            dtgvEmployees.Rows.Add(stt, rs.GetString(3), rs.GetDateTime(4).ToString("dd/MM/yyyy"), rs.GetString(4), rs.GetString(6), rs.GetString(7), rs.GetValue(10), rs.GetString(8), rs.GetString(9), rs.GetString(11))
        End While
        rs.Close()
    End Sub


    Private Sub txt_price_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_price.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_price_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_price.Leave
        Dim price As Double
        If Me.txt_price.Text = "" Then
            Me.txt_price.Text = 0
        End If
        price = txt_price.Text
        txt_price.Text = CStr(price.ToString("#,##0.00"))
        'MessageBox.Show(txt_price.Text * 9)
    End Sub

    Private Sub frm_list_of_equipment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtTypeOfEquipment As New DataTable
        Dim dtDepartment As New DataTable
        'Điền dữ liệu vào Combobox loại thiết bị
        cmd.CommandText = "SELECT * FROM LOAI_TB"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtTypeOfEquipment.Load(rs)
        rs.Close()
        cbbTypeOfEquipment.DataSource = dtTypeOfEquipment
        cbbTypeOfEquipment.DisplayMember = dtTypeOfEquipment.Columns(1).ToString
        cbbTypeOfEquipment.ValueMember = dtTypeOfEquipment.Columns(0).ToString
        'Điền dữ liệu vào Combobox loại thiết bị
        cmd.CommandText = "SELECT * FROM PHONG_BAN"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtDepartment.Load(rs)
        rs.Close()
        cbbDepartment.DataSource = dtDepartment
        cbbDepartment.DisplayMember = dtDepartment.Columns(1).ToString
        cbbDepartment.ValueMember = dtDepartment.Columns(0).ToString
        'Fill data to Datagirdview
        cmd.CommandText = "SELECT * FROM THIET_BI"
        cmd.Connection = cnn
        rs = cmd.ExecuteReader
        dtgvEmployees.Rows.Clear()
        Dim stt As Integer = 0
        While rs.Read
            stt = stt + 1

            If Not IsDBNull(rs.GetValue(9)) Then
                Dim byteBLOBData(rs.GetBytes(9, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                rs.GetBytes(9, 0, byteBLOBData, 0, byteBLOBData.Length)
                Dim imgStream As New MemoryStream(byteBLOBData)
                dtgvEmployees.Rows.Add(stt, rs.GetString(3), rs.GetDateTime(4).ToString("dd/MM/yyyy"), rs.GetString(5), rs.GetString(6), rs.GetString(7), rs.GetValue(10), rs.GetString(8), Image.FromStream(imgStream, True), rs.GetString(11))
            Else
                dtgvEmployees.Rows.Add(stt, rs.GetString(3), rs.GetDateTime(4).ToString("dd/MM/yyyy"), rs.GetString(5), rs.GetString(6), rs.GetString(7), rs.GetValue(10), rs.GetString(8), DBNull.Value, rs.GetString(11))

            End If
        End While
        rs.Close()
    End Sub

    Private Sub btn_image_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_image.Click
        'MessageBox.Show(OpenFileDialog1.FileName)
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.Contains("Image") Then 'Không chọn file nào
            Me.btn_image.Text = "Chọn ảnh SP"
            Me.lblViewImage.Visible = False
        Else
            Me.btn_image.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            Me.lblViewImage.Visible = True
        End If
        'Dim imageData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
        'Dim ms As New MemoryStream(imageData, 0, imageData.Length)
        'cmd.CommandText = "SELECT HINH_ANH FROM THIET_BI WHERE MA_TB='AIR1901'"
        'ms.Write(imageData, 0, imageData.Length)
    End Sub

    Private Sub lblViewImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblViewImage.Click
        'MessageBox.Show(OpenFileDialog1.FileName)
        If Not Me.btn_image.Text.ToString.Contains("Chọn ảnh SP") Then 'Chưa có ảnh nào đang chọn
            Dim f As New Form
            f.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            f.BackgroundImageLayout = ImageLayout.Zoom
            f.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            f.StartPosition = FormStartPosition.CenterScreen
            f.Show()
        End If
    End Sub

    Private Sub txt_price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_price.TextChanged

    End Sub

    Private Sub dtgvEmployees_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgvEmployees.CellContentClick
        If TypeOf (dtgvEmployees.CurrentCell.Value) Is System.Drawing.Bitmap Then
            Dim Picture As Image = dtgvEmployees.CurrentCell.Value
            Dim f As New Form
            f.BackgroundImage = Picture
            f.BackgroundImageLayout = ImageLayout.Zoom
            f.StartPosition = FormStartPosition.CenterScreen
            f.Width = Picture.Width
            f.Height = Picture.Height
            f.ShowDialog()
        End If

    End Sub
End Class