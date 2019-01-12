<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user_update
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btn_del = New DevComponents.DotNetBar.ButtonX
        Me.lblCaption = New DevComponents.DotNetBar.LabelX
        Me.btn_edit = New DevComponents.DotNetBar.ButtonX
        Me.btn_close = New DevComponents.DotNetBar.ButtonX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cbbEmployees = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.txt_pass2 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cbb_state = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.dtp_date_create = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.txt_pass = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.dtgvUser = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPass = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.txtComment = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txtUsername = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dtp_date_create, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_del
        '
        Me.btn_del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_del.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_del.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_del.ForeColor = System.Drawing.Color.Navy
        Me.btn_del.Location = New System.Drawing.Point(690, 90)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(92, 28)
        Me.btn_del.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_del.TabIndex = 0
        Me.btn_del.Text = "Xóa"
        '
        'lblCaption
        '
        Me.lblCaption.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.lblCaption.BackgroundStyle.Class = ""
        Me.lblCaption.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCaption.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.ForeColor = System.Drawing.Color.Teal
        Me.lblCaption.Location = New System.Drawing.Point(312, 24)
        Me.lblCaption.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(316, 22)
        Me.lblCaption.TabIndex = 3
        Me.lblCaption.Text = "CẬP NHẬT THÔNG TIN NGƯỜI DÙNG"
        Me.lblCaption.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'btn_edit
        '
        Me.btn_edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_edit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_edit.ForeColor = System.Drawing.Color.Navy
        Me.btn_edit.Location = New System.Drawing.Point(690, 107)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(92, 28)
        Me.btn_edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_edit.TabIndex = 0
        Me.btn_edit.Text = "Cập nhật"
        '
        'btn_close
        '
        Me.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.ForeColor = System.Drawing.Color.Navy
        Me.btn_close.Location = New System.Drawing.Point(788, 107)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(92, 28)
        Me.btn_close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_close.TabIndex = 0
        Me.btn_close.Text = "Thoát"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txtUsername)
        Me.GroupPanel1.Controls.Add(Me.txtComment)
        Me.GroupPanel1.Controls.Add(Me.cbbEmployees)
        Me.GroupPanel1.Controls.Add(Me.btn_del)
        Me.GroupPanel1.Controls.Add(Me.txt_pass2)
        Me.GroupPanel1.Controls.Add(Me.cbb_state)
        Me.GroupPanel1.Controls.Add(Me.btn_edit)
        Me.GroupPanel1.Controls.Add(Me.dtp_date_create)
        Me.GroupPanel1.Controls.Add(Me.btn_close)
        Me.GroupPanel1.Controls.Add(Me.txt_pass)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(13, 68)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(916, 173)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 6
        Me.GroupPanel1.Text = "Thông tin người dùng"
        '
        'cbbEmployees
        '
        Me.cbbEmployees.DisplayMember = "Text"
        Me.cbbEmployees.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbbEmployees.Enabled = False
        Me.cbbEmployees.FormattingEnabled = True
        Me.cbbEmployees.ItemHeight = 21
        Me.cbbEmployees.Location = New System.Drawing.Point(118, 15)
        Me.cbbEmployees.Name = "cbbEmployees"
        Me.cbbEmployees.PreventEnterBeep = True
        Me.cbbEmployees.Size = New System.Drawing.Size(333, 27)
        Me.cbbEmployees.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbbEmployees.TabIndex = 10
        '
        'txt_pass2
        '
        '
        '
        '
        Me.txt_pass2.Border.Class = "TextBoxBorder"
        Me.txt_pass2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_pass2.Location = New System.Drawing.Point(446, 57)
        Me.txt_pass2.Name = "txt_pass2"
        Me.txt_pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass2.Size = New System.Drawing.Size(159, 27)
        Me.txt_pass2.TabIndex = 4
        '
        'cbb_state
        '
        Me.cbb_state.DisplayMember = "Text"
        Me.cbb_state.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbb_state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_state.FormattingEnabled = True
        Me.cbb_state.ItemHeight = 21
        Me.cbb_state.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3})
        Me.cbb_state.Location = New System.Drawing.Point(118, 107)
        Me.cbb_state.Name = "cbb_state"
        Me.cbb_state.Size = New System.Drawing.Size(148, 27)
        Me.cbb_state.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbb_state.TabIndex = 7
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Hoạt động"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Vô hiệu"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Tạm dừng"
        '
        'dtp_date_create
        '
        '
        '
        '
        Me.dtp_date_create.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtp_date_create.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_create.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtp_date_create.ButtonDropDown.Visible = True
        Me.dtp_date_create.CustomFormat = "dd/mm/yyyy"
        Me.dtp_date_create.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dtp_date_create.IsPopupCalendarOpen = False
        Me.dtp_date_create.Location = New System.Drawing.Point(725, 57)
        '
        '
        '
        Me.dtp_date_create.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtp_date_create.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtp_date_create.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtp_date_create.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_create.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtp_date_create.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtp_date_create.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtp_date_create.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtp_date_create.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtp_date_create.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtp_date_create.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtp_date_create.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtp_date_create.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_create.MonthCalendar.DisplayMonth = New Date(2018, 5, 1, 0, 0, 0, 0)
        Me.dtp_date_create.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtp_date_create.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtp_date_create.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtp_date_create.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtp_date_create.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtp_date_create.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtp_date_create.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_create.MonthCalendar.ShowWeekNumbers = True
        Me.dtp_date_create.MonthCalendar.TodayButtonVisible = True
        Me.dtp_date_create.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtp_date_create.Name = "dtp_date_create"
        Me.dtp_date_create.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtp_date_create.Size = New System.Drawing.Size(155, 27)
        Me.dtp_date_create.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtp_date_create.TabIndex = 5
        Me.dtp_date_create.Value = New Date(2018, 6, 15, 0, 0, 0, 0)
        '
        'txt_pass
        '
        '
        '
        '
        Me.txt_pass.Border.Class = "TextBoxBorder"
        Me.txt_pass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_pass.Location = New System.Drawing.Point(118, 57)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pass.Size = New System.Drawing.Size(148, 27)
        Me.txt_pass.TabIndex = 3
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX6.Location = New System.Drawing.Point(621, 61)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(70, 22)
        Me.LabelX6.TabIndex = 0
        Me.LabelX6.Text = "Ngày tạo:"
        '
        'LabelX5
        '
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX5.Location = New System.Drawing.Point(31, 111)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(86, 23)
        Me.LabelX5.TabIndex = 0
        Me.LabelX5.Text = "Trạng thái:"
        '
        'LabelX8
        '
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX8.Location = New System.Drawing.Point(31, 61)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(86, 23)
        Me.LabelX8.TabIndex = 0
        Me.LabelX8.Text = "Mật khẩu:"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(289, 61)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(142, 22)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Xác nhận mật khẩu:"
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(472, 16)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(123, 23)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Tên người dùng:"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(31, 14)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(79, 22)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Nhân viên:"
        '
        'dtgvUser
        '
        Me.dtgvUser.AllowUserToAddRows = False
        Me.dtgvUser.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dtgvUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvUser.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtgvUser.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.col2, Me.colPass, Me.Column3, Me.Column5, Me.Column1, Me.Column4})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvUser.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgvUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dtgvUser.Location = New System.Drawing.Point(13, 244)
        Me.dtgvUser.Name = "dtgvUser"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgvUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgvUser.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgvUser.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgvUser.Size = New System.Drawing.Size(916, 265)
        Me.dtgvUser.TabIndex = 11
        '
        'Column6
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "STT"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 50
        '
        'col2
        '
        Me.col2.HeaderText = "Tên người dùng"
        Me.col2.Name = "col2"
        Me.col2.Width = 350
        '
        'colPass
        '
        DataGridViewCellStyle3.Format = "*"
        Me.colPass.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPass.HeaderText = "Mật khẩu"
        Me.colPass.Name = "colPass"
        Me.colPass.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPass.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Ngày tạo"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 130
        '
        'Column5
        '
        Me.Column5.HeaderText = "Trạng thái"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 130
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ghi chú"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Ten_NV"
        Me.Column4.Name = "Column4"
        Me.Column4.Visible = False
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(289, 111)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(63, 22)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Ghi chú:"
        '
        'txtComment
        '
        '
        '
        '
        Me.txtComment.Border.Class = "TextBoxBorder"
        Me.txtComment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtComment.Location = New System.Drawing.Point(358, 107)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(247, 27)
        Me.txtComment.TabIndex = 11
        '
        'txtUsername
        '
        '
        '
        '
        Me.txtUsername.Border.Class = "TextBoxBorder"
        Me.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsername.Location = New System.Drawing.Point(601, 15)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(279, 27)
        Me.txtUsername.TabIndex = 12
        '
        'frm_user_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 528)
        Me.Controls.Add(Me.dtgvUser)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.lblCaption)
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_user_update"
        Me.Text = "frm_user_update"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.dtp_date_create, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_del As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblCaption As DevComponents.DotNetBar.LabelX
    Friend WithEvents btn_edit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btn_close As DevComponents.DotNetBar.ButtonX
    Private WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents cbbEmployees As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents txt_pass2 As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents cbb_state As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Private WithEvents dtp_date_create As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents txt_pass As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEventsdtgvUser As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents dtgvUser As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtComment As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUsername As DevComponents.DotNetBar.Controls.TextBoxX
End Class
