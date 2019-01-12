<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_employees
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dtgv_employees = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.cbbPosition = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.txt_phone = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cbb_sex = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.cbb_department = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.txt_place_of_birth = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.dtp_date_of_birth = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.btn_close = New DevComponents.DotNetBar.ButtonX
        Me.txt_email = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btn_add = New DevComponents.DotNetBar.ButtonX
        Me.txt_address = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_name = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dtgv_employees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dtp_date_of_birth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgv_employees
        '
        Me.dtgv_employees.AllowUserToAddRows = False
        Me.dtgv_employees.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dtgv_employees.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv_employees.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtgv_employees.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dtgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_employees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.col2, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8, Me.Column9})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_employees.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv_employees.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dtgv_employees.Location = New System.Drawing.Point(12, 223)
        Me.dtgv_employees.Name = "dtgv_employees"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgv_employees.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgv_employees.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgv_employees.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgv_employees.Size = New System.Drawing.Size(1067, 265)
        Me.dtgv_employees.TabIndex = 11
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.cbbPosition)
        Me.GroupPanel1.Controls.Add(Me.txt_phone)
        Me.GroupPanel1.Controls.Add(Me.cbb_sex)
        Me.GroupPanel1.Controls.Add(Me.cbb_department)
        Me.GroupPanel1.Controls.Add(Me.txt_place_of_birth)
        Me.GroupPanel1.Controls.Add(Me.dtp_date_of_birth)
        Me.GroupPanel1.Controls.Add(Me.btn_close)
        Me.GroupPanel1.Controls.Add(Me.txt_email)
        Me.GroupPanel1.Controls.Add(Me.btn_add)
        Me.GroupPanel1.Controls.Add(Me.txt_address)
        Me.GroupPanel1.Controls.Add(Me.txt_name)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX9)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX10)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(9, 43)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1070, 173)
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
        Me.GroupPanel1.TabIndex = 13
        Me.GroupPanel1.Text = "Thông tin nhân viên"
        '
        'cbbPosition
        '
        Me.cbbPosition.DisplayMember = "Text"
        Me.cbbPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbPosition.DropDownWidth = 250
        Me.cbbPosition.FormattingEnabled = True
        Me.cbbPosition.ItemHeight = 21
        Me.cbbPosition.Location = New System.Drawing.Point(694, 100)
        Me.cbbPosition.Name = "cbbPosition"
        Me.cbbPosition.Size = New System.Drawing.Size(134, 27)
        Me.cbbPosition.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbbPosition.TabIndex = 11
        '
        'txt_phone
        '
        '
        '
        '
        Me.txt_phone.Border.Class = "TextBoxBorder"
        Me.txt_phone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_phone.Location = New System.Drawing.Point(112, 100)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(144, 27)
        Me.txt_phone.TabIndex = 7
        '
        'cbb_sex
        '
        Me.cbb_sex.DisplayMember = "Text"
        Me.cbb_sex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbb_sex.FormattingEnabled = True
        Me.cbb_sex.ItemHeight = 21
        Me.cbb_sex.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
        Me.cbb_sex.Location = New System.Drawing.Point(431, 15)
        Me.cbb_sex.Name = "cbb_sex"
        Me.cbb_sex.Size = New System.Drawing.Size(88, 27)
        Me.cbb_sex.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbb_sex.TabIndex = 2
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Nam"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Nữ"
        '
        'cbb_department
        '
        Me.cbb_department.DisplayMember = "Text"
        Me.cbb_department.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cbb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_department.FormattingEnabled = True
        Me.cbb_department.ItemHeight = 21
        Me.cbb_department.Location = New System.Drawing.Point(354, 100)
        Me.cbb_department.Name = "cbb_department"
        Me.cbb_department.Size = New System.Drawing.Size(237, 27)
        Me.cbb_department.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbb_department.TabIndex = 8
        '
        'txt_place_of_birth
        '
        Me.txt_place_of_birth.AutoCompleteCustomSource.AddRange(New String() {"Long An", "Đồng Tháp", "An Giang", "Tiền Giang", "Kiên Giang", "Bến Tre", "Vĩnh Long", "Thành phố Cần Thơ", "Trà Vinh", "Hậu Giang", "Sóc Trăng", "Bạc Liêu", "Cà Mau"})
        Me.txt_place_of_birth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_place_of_birth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txt_place_of_birth.Border.Class = "TextBoxBorder"
        Me.txt_place_of_birth.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_place_of_birth.Location = New System.Drawing.Point(852, 15)
        Me.txt_place_of_birth.Name = "txt_place_of_birth"
        Me.txt_place_of_birth.Size = New System.Drawing.Size(196, 27)
        Me.txt_place_of_birth.TabIndex = 4
        '
        'dtp_date_of_birth
        '
        '
        '
        '
        Me.dtp_date_of_birth.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtp_date_of_birth.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_of_birth.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtp_date_of_birth.ButtonDropDown.Visible = True
        Me.dtp_date_of_birth.CustomFormat = "dd/mm/yyyy"
        Me.dtp_date_of_birth.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dtp_date_of_birth.IsPopupCalendarOpen = False
        Me.dtp_date_of_birth.Location = New System.Drawing.Point(622, 17)
        '
        '
        '
        Me.dtp_date_of_birth.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtp_date_of_birth.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtp_date_of_birth.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtp_date_of_birth.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_of_birth.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtp_date_of_birth.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtp_date_of_birth.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtp_date_of_birth.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtp_date_of_birth.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtp_date_of_birth.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtp_date_of_birth.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtp_date_of_birth.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtp_date_of_birth.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_of_birth.MonthCalendar.DisplayMonth = New Date(2018, 5, 1, 0, 0, 0, 0)
        Me.dtp_date_of_birth.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtp_date_of_birth.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtp_date_of_birth.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtp_date_of_birth.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtp_date_of_birth.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtp_date_of_birth.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtp_date_of_birth.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_of_birth.MonthCalendar.ShowWeekNumbers = True
        Me.dtp_date_of_birth.MonthCalendar.TodayButtonVisible = True
        Me.dtp_date_of_birth.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtp_date_of_birth.Name = "dtp_date_of_birth"
        Me.dtp_date_of_birth.Size = New System.Drawing.Size(136, 27)
        Me.dtp_date_of_birth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtp_date_of_birth.TabIndex = 3
        Me.dtp_date_of_birth.Value = New Date(2018, 6, 15, 0, 0, 0, 0)
        '
        'btn_close
        '
        Me.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(956, 100)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(92, 28)
        Me.btn_close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_close.TabIndex = 10
        Me.btn_close.Text = "Thoát"
        '
        'txt_email
        '
        '
        '
        '
        Me.txt_email.Border.Class = "TextBoxBorder"
        Me.txt_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_email.Location = New System.Drawing.Point(622, 57)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(426, 27)
        Me.txt_email.TabIndex = 6
        '
        'btn_add
        '
        Me.btn_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_add.Location = New System.Drawing.Point(852, 100)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(92, 28)
        Me.btn_add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_add.TabIndex = 9
        Me.btn_add.Text = "Thêm"
        '
        'txt_address
        '
        '
        '
        '
        Me.txt_address.Border.Class = "TextBoxBorder"
        Me.txt_address.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_address.Location = New System.Drawing.Point(112, 57)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(407, 27)
        Me.txt_address.TabIndex = 5
        '
        'txt_name
        '
        '
        '
        '
        Me.txt_name.Border.Class = "TextBoxBorder"
        Me.txt_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_name.Location = New System.Drawing.Point(112, 15)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(225, 27)
        Me.txt_name.TabIndex = 1
        '
        'LabelX7
        '
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX7.Location = New System.Drawing.Point(534, 60)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(53, 23)
        Me.LabelX7.TabIndex = 0
        Me.LabelX7.Text = "Email:"
        '
        'LabelX9
        '
        Me.LabelX9.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX9.Location = New System.Drawing.Point(354, 17)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(71, 23)
        Me.LabelX9.TabIndex = 0
        Me.LabelX9.Text = "Giới tính:"
        '
        'LabelX6
        '
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX6.Location = New System.Drawing.Point(534, 18)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(82, 23)
        Me.LabelX6.TabIndex = 0
        Me.LabelX6.Text = "Ngày sinh:"
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
        Me.LabelX5.Location = New System.Drawing.Point(31, 101)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(61, 23)
        Me.LabelX5.TabIndex = 0
        Me.LabelX5.Text = "Số ĐT:"
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
        Me.LabelX8.Location = New System.Drawing.Point(30, 60)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(62, 23)
        Me.LabelX8.TabIndex = 0
        Me.LabelX8.Text = "Địa chỉ:"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(781, 17)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(65, 23)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Nơi sinh:"
        '
        'LabelX10
        '
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX10.Location = New System.Drawing.Point(610, 101)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(65, 23)
        Me.LabelX10.TabIndex = 0
        Me.LabelX10.Text = "Chức vụ:"
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
        Me.LabelX3.Location = New System.Drawing.Point(268, 101)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(82, 23)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Phòng ban:"
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(31, 17)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Họ và tên:"
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.Teal
        Me.LabelX1.Location = New System.Drawing.Point(461, 3)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(171, 25)
        Me.LabelX1.TabIndex = 15
        Me.LabelX1.Text = "THÊM NHÂN VIÊN"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
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
        'Column1
        '
        Me.Column1.HeaderText = "Họ và tên"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 180
        '
        'col2
        '
        Me.col2.HeaderText = "Giới tính"
        Me.col2.Name = "col2"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Ngày sinh"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nơi sinh"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Địa chỉ"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "Email"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 180
        '
        'Column7
        '
        Me.Column7.HeaderText = "Số ĐT"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "MaCV"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        Me.Column8.Width = 140
        '
        'Column9
        '
        Me.Column9.HeaderText = "MaPB"
        Me.Column9.Name = "Column9"
        Me.Column9.Visible = False
        '
        'frm_employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1092, 490)
        Me.Controls.Add(Me.dtgv_employees)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LabelX1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_employees"
        Me.Text = "Them nhan vien"
        CType(Me.dtgv_employees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dtp_date_of_birth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgv_employees As DevComponents.DotNetBar.Controls.DataGridViewX
    Private WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents txt_place_of_birth As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents dtp_date_of_birth As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents btn_close As DevComponents.DotNetBar.ButtonX
    Private WithEvents txt_email As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents btn_add As DevComponents.DotNetBar.ButtonX
    Private WithEvents txt_address As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txt_name As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_phone As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbb_sex As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbb_department As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents cbbPosition As DevComponents.DotNetBar.Controls.ComboBoxEx
    Private WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
