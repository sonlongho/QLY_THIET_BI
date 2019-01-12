<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_list_of_equipment
    Inherits DevComponents.DotNetBar.Office2007RibbonForm

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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.lblViewImage = New System.Windows.Forms.Label
        Me.cbbDepartment = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.btn_image = New DevComponents.DotNetBar.ButtonX
        Me.txt_comment = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.dtp_date_buy = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.cbb_status = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem5 = New DevComponents.Editors.ComboItem
        Me.ComboItem6 = New DevComponents.Editors.ComboItem
        Me.ComboItem7 = New DevComponents.Editors.ComboItem
        Me.ComboItem8 = New DevComponents.Editors.ComboItem
        Me.cbb_unit = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem1 = New DevComponents.Editors.ComboItem
        Me.ComboItem2 = New DevComponents.Editors.ComboItem
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.txt_brand = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.dtp_product = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.txt_made_in = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_price = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_name = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.cbbTypeOfEquipment = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.dtgvEmployees = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX
        Me.btnExit = New DevComponents.DotNetBar.ButtonX
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dtp_date_buy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.Top
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(509, 16)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(140, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "NHẬP THIẾT BỊ"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.GroupPanel1.Controls.Add(Me.lblViewImage)
        Me.GroupPanel1.Controls.Add(Me.cbbDepartment)
        Me.GroupPanel1.Controls.Add(Me.btn_image)
        Me.GroupPanel1.Controls.Add(Me.txt_comment)
        Me.GroupPanel1.Controls.Add(Me.dtp_date_buy)
        Me.GroupPanel1.Controls.Add(Me.cbb_status)
        Me.GroupPanel1.Controls.Add(Me.cbb_unit)
        Me.GroupPanel1.Controls.Add(Me.txt_brand)
        Me.GroupPanel1.Controls.Add(Me.dtp_product)
        Me.GroupPanel1.Controls.Add(Me.txt_made_in)
        Me.GroupPanel1.Controls.Add(Me.txt_price)
        Me.GroupPanel1.Controls.Add(Me.txt_name)
        Me.GroupPanel1.Controls.Add(Me.cbbTypeOfEquipment)
        Me.GroupPanel1.Controls.Add(Me.LabelX12)
        Me.GroupPanel1.Controls.Add(Me.LabelX13)
        Me.GroupPanel1.Controls.Add(Me.LabelX11)
        Me.GroupPanel1.Controls.Add(Me.LabelX14)
        Me.GroupPanel1.Controls.Add(Me.LabelX10)
        Me.GroupPanel1.Controls.Add(Me.LabelX8)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Location = New System.Drawing.Point(8, 51)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1136, 199)
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
        Me.GroupPanel1.TabIndex = 1
        Me.GroupPanel1.Text = "Thông tin thiết bị"
        '
        'lblViewImage
        '
        Me.lblViewImage.AutoSize = True
        Me.lblViewImage.BackColor = System.Drawing.Color.Transparent
        Me.lblViewImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblViewImage.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblViewImage.Location = New System.Drawing.Point(1062, 40)
        Me.lblViewImage.Name = "lblViewImage"
        Me.lblViewImage.Size = New System.Drawing.Size(54, 15)
        Me.lblViewImage.TabIndex = 14
        Me.lblViewImage.Text = "Xem ảnh"
        Me.lblViewImage.Visible = False
        '
        'cbbDepartment
        '
        Me.cbbDepartment.DisplayMember = "Text"
        Me.cbbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbDepartment.FormattingEnabled = True
        Me.cbbDepartment.ItemHeight = 21
        Me.cbbDepartment.Location = New System.Drawing.Point(136, 97)
        Me.cbbDepartment.Name = "cbbDepartment"
        Me.cbbDepartment.Size = New System.Drawing.Size(445, 27)
        Me.cbbDepartment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbbDepartment.TabIndex = 9
        '
        'btn_image
        '
        Me.btn_image.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_image.BackColor = System.Drawing.Color.Transparent
        Me.btn_image.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_image.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_image.ForeColor = System.Drawing.Color.Red
        Me.btn_image.Location = New System.Drawing.Point(915, 57)
        Me.btn_image.Name = "btn_image"
        Me.btn_image.Size = New System.Drawing.Size(198, 27)
        Me.btn_image.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_image.TabIndex = 8
        Me.btn_image.Text = "Chọn ảnh SP"
        '
        'txt_comment
        '
        '
        '
        '
        Me.txt_comment.Border.Class = "TextBoxBorder"
        Me.txt_comment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_comment.Location = New System.Drawing.Point(88, 135)
        Me.txt_comment.Name = "txt_comment"
        Me.txt_comment.Size = New System.Drawing.Size(1025, 27)
        Me.txt_comment.TabIndex = 13
        '
        'dtp_date_buy
        '
        '
        '
        '
        Me.dtp_date_buy.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtp_date_buy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_buy.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtp_date_buy.ButtonDropDown.Visible = True
        Me.dtp_date_buy.IsPopupCalendarOpen = False
        Me.dtp_date_buy.Location = New System.Drawing.Point(689, 102)
        '
        '
        '
        Me.dtp_date_buy.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtp_date_buy.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtp_date_buy.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtp_date_buy.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_buy.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtp_date_buy.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtp_date_buy.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtp_date_buy.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtp_date_buy.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtp_date_buy.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtp_date_buy.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtp_date_buy.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtp_date_buy.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_buy.MonthCalendar.DisplayMonth = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.dtp_date_buy.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtp_date_buy.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtp_date_buy.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtp_date_buy.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtp_date_buy.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtp_date_buy.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtp_date_buy.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_date_buy.MonthCalendar.TodayButtonVisible = True
        Me.dtp_date_buy.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtp_date_buy.Name = "dtp_date_buy"
        Me.dtp_date_buy.Size = New System.Drawing.Size(116, 27)
        Me.dtp_date_buy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtp_date_buy.TabIndex = 11
        Me.dtp_date_buy.Value = New Date(2019, 1, 3, 22, 47, 14, 0)
        '
        'cbb_status
        '
        Me.cbb_status.DisplayMember = "Text"
        Me.cbb_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_status.FormattingEnabled = True
        Me.cbb_status.ItemHeight = 21
        Me.cbb_status.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6, Me.ComboItem7, Me.ComboItem8})
        Me.cbb_status.Location = New System.Drawing.Point(963, 102)
        Me.cbb_status.Name = "cbb_status"
        Me.cbb_status.Size = New System.Drawing.Size(150, 27)
        Me.cbb_status.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbb_status.TabIndex = 12
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Mới"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Đang sử dụng"
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Hỏng "
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Thanh lý"
        '
        'cbb_unit
        '
        Me.cbb_unit.DisplayMember = "Text"
        Me.cbb_unit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbb_unit.FormattingEnabled = True
        Me.cbb_unit.ItemHeight = 21
        Me.cbb_unit.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4})
        Me.cbb_unit.Location = New System.Drawing.Point(686, 55)
        Me.cbb_unit.Name = "cbb_unit"
        Me.cbb_unit.Size = New System.Drawing.Size(119, 27)
        Me.cbb_unit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbb_unit.TabIndex = 7
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Cái"
        '
        'ComboItem2
        '
        Me.ComboItem2.Text = "Chiếc"
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Bộ"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Thùng"
        '
        'txt_brand
        '
        Me.txt_brand.AutoCompleteCustomSource.AddRange(New String() {"Samsung", "Sony", "Dell", "HP", "Canon", "TCL", "Intel", "Panasonic", "Toshiba", "Sharp", "Daikin"})
        Me.txt_brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_brand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txt_brand.Border.Class = "TextBoxBorder"
        Me.txt_brand.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_brand.Location = New System.Drawing.Point(367, 55)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(214, 27)
        Me.txt_brand.TabIndex = 6
        '
        'dtp_product
        '
        '
        '
        '
        Me.dtp_product.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtp_product.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_product.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtp_product.ButtonDropDown.Visible = True
        Me.dtp_product.IsPopupCalendarOpen = False
        Me.dtp_product.Location = New System.Drawing.Point(1003, 10)
        '
        '
        '
        Me.dtp_product.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtp_product.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtp_product.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtp_product.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_product.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtp_product.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtp_product.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtp_product.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtp_product.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtp_product.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtp_product.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtp_product.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtp_product.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_product.MonthCalendar.DisplayMonth = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.dtp_product.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtp_product.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtp_product.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtp_product.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtp_product.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtp_product.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtp_product.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtp_product.MonthCalendar.TodayButtonVisible = True
        Me.dtp_product.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtp_product.Name = "dtp_product"
        Me.dtp_product.Size = New System.Drawing.Size(110, 27)
        Me.dtp_product.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtp_product.TabIndex = 4
        '
        'txt_made_in
        '
        Me.txt_made_in.AutoCompleteCustomSource.AddRange(New String() {"Việt Nam", "Trung Quốc", "Thái Lan", "Malaysia", "Đài Loan", "Mỹ"})
        Me.txt_made_in.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_made_in.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txt_made_in.Border.Class = "TextBoxBorder"
        Me.txt_made_in.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_made_in.Location = New System.Drawing.Point(774, 10)
        Me.txt_made_in.Name = "txt_made_in"
        Me.txt_made_in.Size = New System.Drawing.Size(137, 27)
        Me.txt_made_in.TabIndex = 3
        '
        'txt_price
        '
        '
        '
        '
        Me.txt_price.Border.Class = "TextBoxBorder"
        Me.txt_price.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_price.Location = New System.Drawing.Point(88, 56)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(171, 27)
        Me.txt_price.TabIndex = 5
        '
        'txt_name
        '
        '
        '
        '
        Me.txt_name.Border.Class = "TextBoxBorder"
        Me.txt_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_name.Location = New System.Drawing.Point(375, 10)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(313, 27)
        Me.txt_name.TabIndex = 2
        '
        'cbbTypeOfEquipment
        '
        Me.cbbTypeOfEquipment.DisplayMember = "Text"
        Me.cbbTypeOfEquipment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbbTypeOfEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTypeOfEquipment.FormattingEnabled = True
        Me.cbbTypeOfEquipment.ItemHeight = 21
        Me.cbbTypeOfEquipment.Location = New System.Drawing.Point(88, 10)
        Me.cbbTypeOfEquipment.Name = "cbbTypeOfEquipment"
        Me.cbbTypeOfEquipment.Size = New System.Drawing.Size(171, 27)
        Me.cbbTypeOfEquipment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbbTypeOfEquipment.TabIndex = 1
        '
        'LabelX12
        '
        Me.LabelX12.AutoSize = True
        Me.LabelX12.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX12.BackgroundStyle.Class = ""
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.Location = New System.Drawing.Point(15, 134)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(63, 22)
        Me.LabelX12.TabIndex = 0
        Me.LabelX12.Text = "Ghi chú:"
        '
        'LabelX13
        '
        Me.LabelX13.AutoSize = True
        Me.LabelX13.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX13.BackgroundStyle.Class = ""
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.Location = New System.Drawing.Point(592, 102)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(79, 22)
        Me.LabelX13.TabIndex = 0
        Me.LabelX13.Text = "Ngày mua:"
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX11.BackgroundStyle.Class = ""
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.Location = New System.Drawing.Point(15, 56)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(67, 22)
        Me.LabelX11.TabIndex = 0
        Me.LabelX11.Text = "Giá mua:"
        '
        'LabelX14
        '
        Me.LabelX14.AutoSize = True
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX14.BackgroundStyle.Class = ""
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.Location = New System.Drawing.Point(15, 97)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(115, 22)
        Me.LabelX14.TabIndex = 0
        Me.LabelX14.Text = "Đơn vị sử dụng:"
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        Me.LabelX10.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX10.BackgroundStyle.Class = ""
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.Location = New System.Drawing.Point(822, 59)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(71, 22)
        Me.LabelX10.TabIndex = 0
        Me.LabelX10.Text = "Hình ảnh:"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX8.BackgroundStyle.Class = ""
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(824, 102)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(133, 22)
        Me.LabelX8.TabIndex = 0
        Me.LabelX8.Text = "Tình trạng thiết bị:"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(924, 14)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(71, 22)
        Me.LabelX7.TabIndex = 0
        Me.LabelX7.Text = "Ngày SX:"
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
        Me.LabelX6.Location = New System.Drawing.Point(593, 58)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(87, 22)
        Me.LabelX6.TabIndex = 0
        Me.LabelX6.Text = "Đơn vị tính:"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(274, 59)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(79, 22)
        Me.LabelX5.TabIndex = 0
        Me.LabelX5.Text = "Nhãn hiệu:"
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
        Me.LabelX4.Location = New System.Drawing.Point(703, 13)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(60, 22)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Nơi SX:"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(274, 12)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(87, 22)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Tên thiết bị:"
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
        Me.LabelX2.Location = New System.Drawing.Point(15, 11)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(66, 22)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Loại TB:"
        '
        'dtgvEmployees
        '
        Me.dtgvEmployees.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.col2, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvEmployees.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtgvEmployees.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dtgvEmployees.Location = New System.Drawing.Point(8, 290)
        Me.dtgvEmployees.Name = "dtgvEmployees"
        Me.dtgvEmployees.Size = New System.Drawing.Size(1134, 282)
        Me.dtgvEmployees.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "STT"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'col2
        '
        Me.col2.HeaderText = "Tên thiết bị"
        Me.col2.Name = "col2"
        Me.col2.Width = 300
        '
        'Column2
        '
        Me.Column2.HeaderText = "Ngày SX"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nơi SX"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 130
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nhãn hiệu"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Đơn vị tính"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "Giá mua"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Tình trạng"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "Hình ảnh"
        Me.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column8.Name = "Column8"
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column9
        '
        Me.Column9.HeaderText = "Ghi chú"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 150
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnAdd.Location = New System.Drawing.Point(908, 256)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(109, 28)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Thêm"
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnExit.Location = New System.Drawing.Point(1035, 256)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 28)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Thoát"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Image"
        '
        'frm_list_of_equipment
        '
        Me.ClientSize = New System.Drawing.Size(1159, 586)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dtgvEmployees)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LabelX1)
        Me.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_list_of_equipment"
        Me.Text = "frm_list_of_equipment"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.dtp_date_buy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dtgvEmployees As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_name As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbbTypeOfEquipment As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents dtp_product As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txt_made_in As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_price As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtp_date_buy As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents cbb_status As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbb_unit As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txt_brand As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txt_comment As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btn_image As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbbDepartment As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblViewImage As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
