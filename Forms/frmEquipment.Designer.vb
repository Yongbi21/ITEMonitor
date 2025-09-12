<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEquipment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEquipment))
        Me.TabControl2 = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.equipmentGridView = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.bsEquipment = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabItem1Main = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.DataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.From_Counter_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.To_Counter_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsChangeCounter = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Change_Location_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.From_Location_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.To_Location_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actual_CL_Datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IT_Equipment_Id_Change_Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsChangeLocation = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbEquipmentArea = New System.Windows.Forms.ComboBox()
        Me.cbEquipmentLocation = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbEquipmentType = New System.Windows.Forms.ComboBox()
        Me.cbCounter = New System.Windows.Forms.ComboBox()
        Me.cbBir = New System.Windows.Forms.ComboBox()
        Me.findBtnPurchaseOrderNo = New System.Windows.Forms.Button()
        Me.findBtnPermitNo = New System.Windows.Forms.Button()
        Me.findBtnCounter = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPurchaseOrder = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPermitNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCounterName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStore = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMachineSerialNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtControlNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabItem2Details = New DevComponents.DotNetBar.TabItem(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsPrint = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsPrintSticker = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsPrintList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.IT_Equipment_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Machine_Serial_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isRegister_Bir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipment_Area_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Counter_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purchase_Order_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Created_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.equipmentGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChangeCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChangeLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.CanReorderTabs = True
        Me.TabControl2.ColorScheme.TabBackground = System.Drawing.Color.White
        Me.TabControl2.Controls.Add(Me.TabControlPanel1)
        Me.TabControl2.Controls.Add(Me.TabControlPanel2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.FixedTabSize = New System.Drawing.Size(590, 30)
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabControl2.SelectedTabIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1260, 560)
        Me.TabControl2.TabIndex = 4
        Me.TabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox
        Me.TabControl2.Tabs.Add(Me.TabItem1Main)
        Me.TabControl2.Tabs.Add(Me.TabItem2Details)
        Me.TabControl2.Text = "TabControl2"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.equipmentGridView)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 36)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1260, 524)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 2
        Me.TabControlPanel1.TabItem = Me.TabItem1Main
        '
        'equipmentGridView
        '
        Me.equipmentGridView.AllowUserToAddRows = False
        Me.equipmentGridView.AllowUserToDeleteRows = False
        Me.equipmentGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.equipmentGridView.AutoGenerateColumns = False
        Me.equipmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.equipmentGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IT_Equipment_Id, Me.Machine_Serial_Number, Me.isRegister_Bir, Me.Type_Id, Me.Equipment_Area_Id, Me.Counter_Id, Me.Location_Id, Me.Purchase_Order_Date, Me.Created_Date})
        Me.equipmentGridView.DataSource = Me.bsEquipment
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.equipmentGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.equipmentGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.equipmentGridView.Location = New System.Drawing.Point(12, 29)
        Me.equipmentGridView.Name = "equipmentGridView"
        Me.equipmentGridView.ReadOnly = True
        Me.equipmentGridView.RowHeadersVisible = False
        Me.equipmentGridView.Size = New System.Drawing.Size(1226, 480)
        Me.equipmentGridView.TabIndex = 36
        '
        'bsEquipment
        '
        '
        'TabItem1Main
        '
        Me.TabItem1Main.AttachedControl = Me.TabControlPanel1
        Me.TabItem1Main.Name = "TabItem1Main"
        Me.TabItem1Main.Text = "Main"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.DataGridViewX2)
        Me.TabControlPanel2.Controls.Add(Me.DataGridViewX1)
        Me.TabControlPanel2.Controls.Add(Me.Label8)
        Me.TabControlPanel2.Controls.Add(Me.Label15)
        Me.TabControlPanel2.Controls.Add(Me.Label1)
        Me.TabControlPanel2.Controls.Add(Me.Panel1)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 36)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(1260, 524)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 3
        Me.TabControlPanel2.TabItem = Me.TabItem2Details
        '
        'DataGridViewX2
        '
        Me.DataGridViewX2.AllowUserToAddRows = False
        Me.DataGridViewX2.AllowUserToDeleteRows = False
        Me.DataGridViewX2.AutoGenerateColumns = False
        Me.DataGridViewX2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewX2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.From_Counter_Id, Me.To_Counter_Id, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DataGridViewX2.DataSource = Me.bsChangeCounter
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX2.Location = New System.Drawing.Point(621, 315)
        Me.DataGridViewX2.Name = "DataGridViewX2"
        Me.DataGridViewX2.ReadOnly = True
        Me.DataGridViewX2.RowHeadersVisible = False
        Me.DataGridViewX2.Size = New System.Drawing.Size(627, 150)
        Me.DataGridViewX2.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Change_Counter_Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Change Counter Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'From_Counter_Id
        '
        Me.From_Counter_Id.DataPropertyName = "From_Counter_Id"
        Me.From_Counter_Id.HeaderText = "From Counter"
        Me.From_Counter_Id.Name = "From_Counter_Id"
        Me.From_Counter_Id.ReadOnly = True
        '
        'To_Counter_Id
        '
        Me.To_Counter_Id.DataPropertyName = "To_Counter_Id"
        Me.To_Counter_Id.HeaderText = "To Counter"
        Me.To_Counter_Id.Name = "To_Counter_Id"
        Me.To_Counter_Id.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Actual_Change_Counter_Datetime"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Actual Change Counter Datetime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IT_Equipment_Id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Control No."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Change_Location_Id, Me.From_Location_Id, Me.To_Location_Id, Me.Actual_CL_Datetime, Me.IT_Equipment_Id_Change_Location})
        Me.DataGridViewX1.DataSource = Me.bsChangeLocation
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(12, 315)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.RowHeadersVisible = False
        Me.DataGridViewX1.Size = New System.Drawing.Size(584, 150)
        Me.DataGridViewX1.TabIndex = 25
        '
        'Change_Location_Id
        '
        Me.Change_Location_Id.DataPropertyName = "Change_Location_Id"
        Me.Change_Location_Id.HeaderText = "Change Location Id"
        Me.Change_Location_Id.Name = "Change_Location_Id"
        Me.Change_Location_Id.ReadOnly = True
        '
        'From_Location_Id
        '
        Me.From_Location_Id.DataPropertyName = "From_Location_Id"
        Me.From_Location_Id.HeaderText = "From Location"
        Me.From_Location_Id.Name = "From_Location_Id"
        Me.From_Location_Id.ReadOnly = True
        '
        'To_Location_Id
        '
        Me.To_Location_Id.DataPropertyName = "To_Location_Id"
        Me.To_Location_Id.HeaderText = "To Location"
        Me.To_Location_Id.Name = "To_Location_Id"
        Me.To_Location_Id.ReadOnly = True
        '
        'Actual_CL_Datetime
        '
        Me.Actual_CL_Datetime.DataPropertyName = "Actual_Change_Location_Datetime"
        Me.Actual_CL_Datetime.HeaderText = "Actual Change Location Datetime"
        Me.Actual_CL_Datetime.Name = "Actual_CL_Datetime"
        Me.Actual_CL_Datetime.ReadOnly = True
        '
        'IT_Equipment_Id_Change_Location
        '
        Me.IT_Equipment_Id_Change_Location.DataPropertyName = "IT_Equipment_Id"
        Me.IT_Equipment_Id_Change_Location.HeaderText = "Control No."
        Me.IT_Equipment_Id_Change_Location.Name = "IT_Equipment_Id_Change_Location"
        Me.IT_Equipment_Id_Change_Location.ReadOnly = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(617, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 24)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Change Counter"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Maroon
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(43, 279)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(153, 24)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Change Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(140, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cbEquipmentArea)
        Me.Panel1.Controls.Add(Me.cbEquipmentLocation)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbEquipmentType)
        Me.Panel1.Controls.Add(Me.cbCounter)
        Me.Panel1.Controls.Add(Me.cbBir)
        Me.Panel1.Controls.Add(Me.findBtnPurchaseOrderNo)
        Me.Panel1.Controls.Add(Me.findBtnPermitNo)
        Me.Panel1.Controls.Add(Me.findBtnCounter)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPurchaseOrder)
        Me.Panel1.Controls.Add(Me.txtPermitNo)
        Me.Panel1.Controls.Add(Me.txtCounterName)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtStore)
        Me.Panel1.Controls.Add(Me.txtMachineSerialNo)
        Me.Panel1.Controls.Add(Me.txtControlNo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(117, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 230)
        Me.Panel1.TabIndex = 0
        '
        'cbEquipmentArea
        '
        Me.cbEquipmentArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEquipmentArea.Enabled = False
        Me.cbEquipmentArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEquipmentArea.FormattingEnabled = True
        Me.cbEquipmentArea.Location = New System.Drawing.Point(433, 181)
        Me.cbEquipmentArea.Name = "cbEquipmentArea"
        Me.cbEquipmentArea.Size = New System.Drawing.Size(189, 21)
        Me.cbEquipmentArea.TabIndex = 70
        '
        'cbEquipmentLocation
        '
        Me.cbEquipmentLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEquipmentLocation.Enabled = False
        Me.cbEquipmentLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEquipmentLocation.FormattingEnabled = True
        Me.cbEquipmentLocation.Location = New System.Drawing.Point(430, 137)
        Me.cbEquipmentLocation.Name = "cbEquipmentLocation"
        Me.cbEquipmentLocation.Size = New System.Drawing.Size(189, 21)
        Me.cbEquipmentLocation.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Store:"
        '
        'cbEquipmentType
        '
        Me.cbEquipmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEquipmentType.Enabled = False
        Me.cbEquipmentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEquipmentType.FormattingEnabled = True
        Me.cbEquipmentType.Location = New System.Drawing.Point(430, 92)
        Me.cbEquipmentType.Name = "cbEquipmentType"
        Me.cbEquipmentType.Size = New System.Drawing.Size(189, 21)
        Me.cbEquipmentType.TabIndex = 67
        '
        'cbCounter
        '
        Me.cbCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCounter.Enabled = False
        Me.cbCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCounter.FormattingEnabled = True
        Me.cbCounter.Location = New System.Drawing.Point(136, 154)
        Me.cbCounter.Name = "cbCounter"
        Me.cbCounter.Size = New System.Drawing.Size(189, 21)
        Me.cbCounter.TabIndex = 66
        '
        'cbBir
        '
        Me.cbBir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBir.Enabled = False
        Me.cbBir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBir.FormattingEnabled = True
        Me.cbBir.Location = New System.Drawing.Point(429, 44)
        Me.cbBir.Name = "cbBir"
        Me.cbBir.Size = New System.Drawing.Size(189, 21)
        Me.cbBir.TabIndex = 65
        '
        'findBtnPurchaseOrderNo
        '
        Me.findBtnPurchaseOrderNo.Location = New System.Drawing.Point(929, 149)
        Me.findBtnPurchaseOrderNo.Name = "findBtnPurchaseOrderNo"
        Me.findBtnPurchaseOrderNo.Size = New System.Drawing.Size(75, 24)
        Me.findBtnPurchaseOrderNo.TabIndex = 60
        Me.findBtnPurchaseOrderNo.Text = "Find"
        Me.findBtnPurchaseOrderNo.UseVisualStyleBackColor = True
        '
        'findBtnPermitNo
        '
        Me.findBtnPermitNo.Location = New System.Drawing.Point(929, 101)
        Me.findBtnPermitNo.Name = "findBtnPermitNo"
        Me.findBtnPermitNo.Size = New System.Drawing.Size(75, 24)
        Me.findBtnPermitNo.TabIndex = 59
        Me.findBtnPermitNo.Text = "Find"
        Me.findBtnPermitNo.UseVisualStyleBackColor = True
        '
        'findBtnCounter
        '
        Me.findBtnCounter.Location = New System.Drawing.Point(929, 53)
        Me.findBtnCounter.Name = "findBtnCounter"
        Me.findBtnCounter.Size = New System.Drawing.Size(75, 24)
        Me.findBtnCounter.TabIndex = 58
        Me.findBtnCounter.Text = "Find"
        Me.findBtnCounter.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(427, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Equipment Type:"
        '
        'txtPurchaseOrder
        '
        Me.txtPurchaseOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtPurchaseOrder.Border.Class = "TextBoxBorder"
        Me.txtPurchaseOrder.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPurchaseOrder.Enabled = False
        Me.txtPurchaseOrder.Location = New System.Drawing.Point(744, 152)
        Me.txtPurchaseOrder.Name = "txtPurchaseOrder"
        Me.txtPurchaseOrder.ReadOnly = True
        Me.txtPurchaseOrder.Size = New System.Drawing.Size(179, 20)
        Me.txtPurchaseOrder.TabIndex = 29
        '
        'txtPermitNo
        '
        Me.txtPermitNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtPermitNo.Border.Class = "TextBoxBorder"
        Me.txtPermitNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPermitNo.Enabled = False
        Me.txtPermitNo.Location = New System.Drawing.Point(744, 103)
        Me.txtPermitNo.Name = "txtPermitNo"
        Me.txtPermitNo.ReadOnly = True
        Me.txtPermitNo.Size = New System.Drawing.Size(179, 20)
        Me.txtPermitNo.TabIndex = 28
        '
        'txtCounterName
        '
        Me.txtCounterName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtCounterName.Border.Class = "TextBoxBorder"
        Me.txtCounterName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCounterName.Enabled = False
        Me.txtCounterName.Location = New System.Drawing.Point(744, 55)
        Me.txtCounterName.Name = "txtCounterName"
        Me.txtCounterName.ReadOnly = True
        Me.txtCounterName.Size = New System.Drawing.Size(179, 20)
        Me.txtCounterName.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(741, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 17)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Purchase Order No.:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(741, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Permit No.:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(741, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Counter Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(429, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Equipment Area:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(428, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Equipment Location:"
        '
        'txtStore
        '
        Me.txtStore.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtStore.Border.Class = "TextBoxBorder"
        Me.txtStore.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtStore.Enabled = False
        Me.txtStore.Location = New System.Drawing.Point(136, 116)
        Me.txtStore.Name = "txtStore"
        Me.txtStore.ReadOnly = True
        Me.txtStore.Size = New System.Drawing.Size(189, 20)
        Me.txtStore.TabIndex = 17
        '
        'txtMachineSerialNo
        '
        Me.txtMachineSerialNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtMachineSerialNo.Border.Class = "TextBoxBorder"
        Me.txtMachineSerialNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMachineSerialNo.Enabled = False
        Me.txtMachineSerialNo.Location = New System.Drawing.Point(135, 77)
        Me.txtMachineSerialNo.Name = "txtMachineSerialNo"
        Me.txtMachineSerialNo.ReadOnly = True
        Me.txtMachineSerialNo.Size = New System.Drawing.Size(190, 20)
        Me.txtMachineSerialNo.TabIndex = 16
        '
        'txtControlNo
        '
        Me.txtControlNo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        '
        '
        '
        Me.txtControlNo.Border.Class = "TextBoxBorder"
        Me.txtControlNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtControlNo.Enabled = False
        Me.txtControlNo.Location = New System.Drawing.Point(135, 42)
        Me.txtControlNo.Name = "txtControlNo"
        Me.txtControlNo.ReadOnly = True
        Me.txtControlNo.Size = New System.Drawing.Size(190, 20)
        Me.txtControlNo.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Counter Use:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(426, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "BIR Registered:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Machine Serial No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Control No.:"
        '
        'TabItem2Details
        '
        Me.TabItem2Details.AttachedControl = Me.TabControlPanel2
        Me.TabItem2Details.Name = "TabItem2Details"
        Me.TabItem2Details.Text = "Details"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.ToolStripSeparator1, Me.tsEdit, Me.ToolStripSeparator2, Me.tsSave, Me.ToolStripSeparator3, Me.tsPrint, Me.ToolStripSeparator4, Me.tsClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 560)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1260, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsNew
        '
        Me.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(35, 22)
        Me.tsNew.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsEdit
        '
        Me.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(31, 22)
        Me.tsEdit.Text = "Edit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsSave
        '
        Me.tsSave.Enabled = False
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(35, 22)
        Me.tsSave.Text = "Save"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsPrint
        '
        Me.tsPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsPrintSticker, Me.tsPrintList})
        Me.tsPrint.Image = CType(resources.GetObject("tsPrint.Image"), System.Drawing.Image)
        Me.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrint.Name = "tsPrint"
        Me.tsPrint.Size = New System.Drawing.Size(61, 22)
        Me.tsPrint.Text = "Print"
        '
        'tsPrintSticker
        '
        Me.tsPrintSticker.Name = "tsPrintSticker"
        Me.tsPrintSticker.Size = New System.Drawing.Size(180, 22)
        Me.tsPrintSticker.Text = "Print Sticker"
        '
        'tsPrintList
        '
        Me.tsPrintList.Name = "tsPrintList"
        Me.tsPrintList.Size = New System.Drawing.Size(180, 22)
        Me.tsPrintList.Text = "Print List"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsClose
        '
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Size = New System.Drawing.Size(40, 22)
        Me.tsClose.Text = "Close"
        '
        'IT_Equipment_Id
        '
        Me.IT_Equipment_Id.DataPropertyName = "IT_Equipment_Id"
        Me.IT_Equipment_Id.HeaderText = "Control No."
        Me.IT_Equipment_Id.Name = "IT_Equipment_Id"
        Me.IT_Equipment_Id.ReadOnly = True
        '
        'Machine_Serial_Number
        '
        Me.Machine_Serial_Number.DataPropertyName = "Machine_Serial_Number"
        Me.Machine_Serial_Number.HeaderText = "Machine Serial No."
        Me.Machine_Serial_Number.Name = "Machine_Serial_Number"
        Me.Machine_Serial_Number.ReadOnly = True
        '
        'isRegister_Bir
        '
        Me.isRegister_Bir.DataPropertyName = "isRegister_Bir"
        Me.isRegister_Bir.HeaderText = "BIR Registered"
        Me.isRegister_Bir.Name = "isRegister_Bir"
        Me.isRegister_Bir.ReadOnly = True
        '
        'Type_Id
        '
        Me.Type_Id.DataPropertyName = "Type_Name"
        Me.Type_Id.HeaderText = "Type Name"
        Me.Type_Id.Name = "Type_Id"
        Me.Type_Id.ReadOnly = True
        Me.Type_Id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Equipment_Area_Id
        '
        Me.Equipment_Area_Id.DataPropertyName = "Area_Name"
        Me.Equipment_Area_Id.HeaderText = "Area Name"
        Me.Equipment_Area_Id.Name = "Equipment_Area_Id"
        Me.Equipment_Area_Id.ReadOnly = True
        '
        'Counter_Id
        '
        Me.Counter_Id.DataPropertyName = "Counter_Name"
        Me.Counter_Id.HeaderText = "Counter Name"
        Me.Counter_Id.Name = "Counter_Id"
        Me.Counter_Id.ReadOnly = True
        '
        'Location_Id
        '
        Me.Location_Id.DataPropertyName = "Location_Name"
        Me.Location_Id.HeaderText = "Location Name"
        Me.Location_Id.Name = "Location_Id"
        Me.Location_Id.ReadOnly = True
        '
        'Purchase_Order_Date
        '
        Me.Purchase_Order_Date.DataPropertyName = "Purchase_Order_Date1"
        Me.Purchase_Order_Date.HeaderText = "Purchase Order Date"
        Me.Purchase_Order_Date.Name = "Purchase_Order_Date"
        Me.Purchase_Order_Date.ReadOnly = True
        '
        'Created_Date
        '
        Me.Created_Date.DataPropertyName = "Created_Date"
        Me.Created_Date.HeaderText = "Created Date"
        Me.Created_Date.Name = "Created_Date"
        Me.Created_Date.ReadOnly = True
        '
        'frmEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 585)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEquipment"
        Me.Text = "Equipment Details"
        CType(Me.TabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        CType(Me.equipmentGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TabControlPanel2.PerformLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChangeCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChangeLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl2 As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem1Main As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents TabItem2Details As DevComponents.DotNetBar.TabItem
    Friend WithEvents bsEquipment As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents bsChangeLocation As BindingSource
    Friend WithEvents bsChangeCounter As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsNew As ToolStripButton
    Friend WithEvents tsEdit As ToolStripButton
    Friend WithEvents tsSave As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsClose As ToolStripButton
    Friend WithEvents equipmentGridView As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Purchase_Order_Id As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents cbEquipmentType As ComboBox
    Friend WithEvents cbCounter As ComboBox
    Friend WithEvents cbBir As ComboBox
    Friend WithEvents findBtnPurchaseOrderNo As Button
    Friend WithEvents findBtnPermitNo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPurchaseOrder As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPermitNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCounterName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtStore As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMachineSerialNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtControlNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbEquipmentArea As ComboBox
    Friend WithEvents cbEquipmentLocation As ComboBox
    Friend WithEvents DataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Change_Location_Id As DataGridViewTextBoxColumn
    Friend WithEvents From_Location_Id As DataGridViewTextBoxColumn
    Friend WithEvents To_Location_Id As DataGridViewTextBoxColumn
    Friend WithEvents Actual_CL_Datetime As DataGridViewTextBoxColumn
    Friend WithEvents IT_Equipment_Id_Change_Location As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents findBtnCounter As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents From_Counter_Id As DataGridViewTextBoxColumn
    Friend WithEvents To_Counter_Id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents tsPrint As ToolStripDropDownButton
    Friend WithEvents tsPrintSticker As ToolStripMenuItem
    Friend WithEvents tsPrintList As ToolStripMenuItem
    Friend WithEvents IT_Equipment_Id As DataGridViewTextBoxColumn
    Friend WithEvents Machine_Serial_Number As DataGridViewTextBoxColumn
    Friend WithEvents isRegister_Bir As DataGridViewTextBoxColumn
    Friend WithEvents Type_Id As DataGridViewTextBoxColumn
    Friend WithEvents Equipment_Area_Id As DataGridViewTextBoxColumn
    Friend WithEvents Counter_Id As DataGridViewTextBoxColumn
    Friend WithEvents Location_Id As DataGridViewTextBoxColumn
    Friend WithEvents Purchase_Order_Date As DataGridViewTextBoxColumn
    Friend WithEvents Created_Date As DataGridViewTextBoxColumn
End Class