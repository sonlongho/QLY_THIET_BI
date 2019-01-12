<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_department
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
        Me.dtgv_department = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.txt_comment = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_phone = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.dtp_date_create = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.btn_close = New DevComponents.DotNetBar.ButtonX
        Me.txt_email = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.btn_add = New DevComponents.DotNetBar.ButtonX
        Me.txt_address = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.txt_name = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        CType(Me.dtgv_department, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dtp_date_create, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgv_department
        '
        Me.dtgv_department.AllowUserToAddRows = False
        Me.dtgv_department.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dtgv_department.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgv_department.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtgv_department.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dtgv_department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgv_department.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.col2, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgv_department.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgv_department.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dtgv_department.Location = New System.Drawing.Point(4, 223)
        Me.dtgv_department.Name = "dtgv_department"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgv_department.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgv_department.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgv_department.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgv_department.Size = New System.Drawing.Size(916, 265)
        Me.dtgv_department.TabIndex = 9
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
        Me.Column1.HeaderText = "Tên phòng khoa"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 180
        '
        'col2
        '
        Me.col2.HeaderText = "Địa chỉ"
        Me.col2.Name = "col2"
        Me.col2.Width = 247
        '
        'Column2
        '
        Me.Column2.HeaderText = "Số ĐT"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "Ngày thành lập "
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 130
        '
        'Column4
        '
        Me.Column4.HeaderText = "Ghi chú"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 180
        '
        'Column5
        '
        Me.Column5.HeaderText = "MaPK"
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        Me.Column5.Width = 110
        '
        'GroupPanel1
        '
        Me.GroupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.txt_comment)
        Me.GroupPanel1.Controls.Add(Me.txt_phone)
        Me.GroupPanel1.Controls.Add(Me.dtp_date_create)
        Me.GroupPanel1.Controls.Add(Me.btn_close)
        Me.GroupPanel1.Controls.Add(Me.txt_email)
        Me.GroupPanel1.Controls.Add(Me.btn_add)
        Me.GroupPanel1.Controls.Add(Me.txt_address)
        Me.GroupPanel1.Controls.Add(Me.txt_name)
        Me.GroupPanel1.Controls.Add(Me.LabelX7)
        Me.GroupPanel1.Controls.Add(Me.LabelX6)
        Me.GroupPanel1.Controls.Add(Me.LabelX5)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel1.Location = New System.Drawing.Point(4, 43)
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
        Me.GroupPanel1.TabIndex = 16
        Me.GroupPanel1.Text = "Thông tin phòng khoa"
        '
        'txt_comment
        '
        '
        '
        '
        Me.txt_comment.Border.Class = "TextBoxBorder"
        Me.txt_comment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_comment.Location = New System.Drawing.Point(153, 95)
        Me.txt_comment.Name = "txt_comment"
        Me.txt_comment.Size = New System.Drawing.Size(500, 27)
        Me.txt_comment.TabIndex = 6
        '
        'txt_phone
        '
        '
        '
        '
        Me.txt_phone.Border.Class = "TextBoxBorder"
        Me.txt_phone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_phone.Location = New System.Drawing.Point(153, 53)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(156, 27)
        Me.txt_phone.TabIndex = 4
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
        Me.dtp_date_create.Location = New System.Drawing.Point(743, 53)
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
        Me.dtp_date_create.Size = New System.Drawing.Size(138, 27)
        Me.dtp_date_create.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtp_date_create.TabIndex = 5
        Me.dtp_date_create.Value = New Date(2018, 6, 15, 0, 0, 0, 0)
        '
        'btn_close
        '
        Me.btn_close.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_close.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn_close.Location = New System.Drawing.Point(789, 95)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(92, 28)
        Me.btn_close.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_close.TabIndex = 8
        Me.btn_close.Text = "Thoát"
        '
        'txt_email
        '
        '
        '
        '
        Me.txt_email.Border.Class = "TextBoxBorder"
        Me.txt_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_email.Location = New System.Drawing.Point(401, 53)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(198, 27)
        Me.txt_email.TabIndex = 4
        '
        'btn_add
        '
        Me.btn_add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_add.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btn_add.Location = New System.Drawing.Point(673, 95)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(92, 28)
        Me.btn_add.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btn_add.TabIndex = 7
        Me.btn_add.Text = "Thêm"
        '
        'txt_address
        '
        '
        '
        '
        Me.txt_address.Border.Class = "TextBoxBorder"
        Me.txt_address.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_address.Location = New System.Drawing.Point(401, 10)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(480, 27)
        Me.txt_address.TabIndex = 2
        '
        'txt_name
        '
        Me.txt_name.AutoCompleteCustomSource.AddRange(New String() {"Khoa ", "Phòng "})
        Me.txt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        '
        '
        '
        Me.txt_name.Border.Class = "TextBoxBorder"
        Me.txt_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txt_name.Location = New System.Drawing.Point(153, 11)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(156, 27)
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
        Me.LabelX7.Location = New System.Drawing.Point(332, 57)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(53, 23)
        Me.LabelX7.TabIndex = 0
        Me.LabelX7.Text = "Email:"
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
        Me.LabelX6.Location = New System.Drawing.Point(622, 57)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(115, 23)
        Me.LabelX6.TabIndex = 0
        Me.LabelX6.Text = "Ngày thành lập:"
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
        Me.LabelX5.Location = New System.Drawing.Point(31, 99)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(76, 23)
        Me.LabelX5.TabIndex = 0
        Me.LabelX5.Text = "Ghi chú:"
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
        Me.LabelX4.Location = New System.Drawing.Point(31, 57)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(105, 23)
        Me.LabelX4.TabIndex = 0
        Me.LabelX4.Text = "Số điện thoại:"
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
        Me.LabelX3.Location = New System.Drawing.Point(332, 15)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(56, 23)
        Me.LabelX3.TabIndex = 0
        Me.LabelX3.Text = "Địa chỉ:"
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
        Me.LabelX2.Location = New System.Drawing.Point(31, 14)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(123, 23)
        Me.LabelX2.TabIndex = 0
        Me.LabelX2.Text = "Tên phòng khoa:"
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
        Me.LabelX1.Location = New System.Drawing.Point(365, 3)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(194, 25)
        Me.LabelX1.TabIndex = 18
        Me.LabelX1.Text = "THÊM PHÒNG KHOA"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'frm_department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(924, 490)
        Me.Controls.Add(Me.dtgv_department)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.LabelX1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_department"
        Me.Text = "phongban"
        CType(Me.dtgv_department, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dtp_date_create, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgv_department As DevComponents.DotNetBar.Controls.DataGridViewX
    Private WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents txt_phone As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents dtp_date_create As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Private WithEvents btn_close As DevComponents.DotNetBar.ButtonX
    Private WithEvents txt_email As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents btn_add As DevComponents.DotNetBar.ButtonX
    Private WithEvents txt_address As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents txt_name As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txt_comment As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
