Public Class frm_main
    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        cnn.Close()
        End
    End Sub

    Private Sub ButtonItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Application.OpenForms().OfType(Of frm_options).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Thiết lập tùy chọn", "options")
        'Binding frm_grant_rights to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_options, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonItem30_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem30.Click
        If Application.OpenForms().OfType(Of frm_user).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Thêm người dùng", "adduser")
        'Binding frm_users to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_user, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem32_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem32.Click
        If Application.OpenForms().OfType(Of frm_user_update).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        frm_user_update.btn_del.Visible = False
        cur_dock_tab = add_tab(Bar1, "Cập nhật người dùng", "updateUser")
        'Binding frm_user_update to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_user_update, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem33_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem33.Click
        If Application.OpenForms().OfType(Of frm_access_rights).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Quyền truy cập", "accessright")
        'Binding frm_access_rights to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_access_rights, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem34_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem34.Click
        If Application.OpenForms().OfType(Of frm_grant_rights).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Quyền truy cập", "accessright")
        'Binding frm_grant_rights to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_grant_rights, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem31.Click
        If Application.OpenForms().OfType(Of frm_department).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Thêm phòng khoa", "adddepartment")
        'Binding frm_users to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_department, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem44.Click
        If Application.OpenForms().OfType(Of frm_position).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Thêm chức vu", "addposition")
        'Binding frm_users to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_position, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem41.Click
        If Application.OpenForms().OfType(Of frm_employees).Any Then
            Exit Sub
        End If
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Thêm nhân viên", "addEmployees")
        'Binding frm_users to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_employees, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem8.Click
        'Kiểm tra xem đã thêm tab chưa
        If Application.OpenForms().OfType(Of frm_list_of_equipment).Any Then
            Exit Sub
        End If
        'Nêu chưa thêm thì thêm
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Thêm danh mục thiết bị", "addEquipment")
        'Binding frm_grant_rights to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_list_of_equipment, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem9.Click
        'Kiểm tra xem đã thêm tab chưa
        If Application.OpenForms().OfType(Of frm_list_of_equipment).Any Then
            Exit Sub
        End If
        'Nêu chưa thêm thì thêm
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Thêm danh mục thiết bị", "options")
        'Binding frm_grant_rights to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_list_of_equipment, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem10.Click
        'Kiểm tra xem đã thêm tab chưa
        If Application.OpenForms().OfType(Of frm_list_of_equipment).Any Then
            Exit Sub
        End If
        'Nêu chưa thêm thì thêm
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Thêm danh mục thiết bị", "options")
        'Binding frm_grant_rights to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_list_of_equipment, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        'Kiểm tra xem đã thêm tab chưa
        If Application.OpenForms().OfType(Of frm_type_of_equipment).Any Then
            Exit Sub
        End If
        'Nêu chưa thêm thì thêm
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Thêm loại thiết bị", "options")
        'Binding frm_grant_rights to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_type_of_equipment, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frm_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
        'frm_login.Hide()
    End Sub

    Private Sub RibbonControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub ButtonItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem46.Click
        If Application.OpenForms().OfType(Of frm_user_update).Any Then
            Exit Sub
        End If
        frm_user_update.lblCaption.Text = "XÓA NGƯỜI DÙNG"
        frm_user_update.txtUsername.ReadOnly = True
        frm_user_update.lblCaption.ForeColor = Color.Green
        frm_user_update.btn_edit.Visible = False
        frm_user_update.btn_del.Location = New Point(690, 107)
        Dim cur_dock_tab As Integer
        Me.Cursor = Cursors.WaitCursor
        'Add Tab
        cur_dock_tab = add_tab(Bar1, "Xóa người dùng", "deleteUser")
        'Binding frm_user_update to DockTab has just been added
        binding_form_to_docktab(Bar1, frm_user_update, cur_dock_tab)
        Me.Cursor = Cursors.Default
    End Sub
End Class