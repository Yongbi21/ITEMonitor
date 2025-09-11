<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeLocation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeLocation))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bsChangeLocation = New System.Windows.Forms.BindingSource(Me.components)
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsCancel = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cbFromLocation = New System.Windows.Forms.ComboBox()
        Me.txtITEquipmentSearch = New System.Windows.Forms.TextBox()
        Me.btnSearchITEquipment = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChangeLocation = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.cbToLocation = New System.Windows.Forms.ComboBox()
        Me.Change_Location_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseOrder_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actual_CL_Datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IT_Equipment_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.bsChangeLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bsChangeLocation
        '
        '
        'tsNew
        '
        Me.tsNew.Image = CType(resources.GetObject("tsNew.Image"), System.Drawing.Image)
        Me.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(51, 22)
        Me.tsNew.Text = "New"
        '
        'tsEdit
        '
        Me.tsEdit.Image = CType(resources.GetObject("tsEdit.Image"), System.Drawing.Image)
        Me.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(47, 22)
        Me.tsEdit.Text = "Edit"
        '
        'tsSave
        '
        Me.tsSave.Enabled = False
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(51, 22)
        Me.tsSave.Text = "Save"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.ToolStripSeparator1, Me.tsEdit, Me.ToolStripSeparator2, Me.tsSave, Me.ToolStripSeparator3, Me.tsCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 425)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(764, 25)
        Me.ToolStrip1.TabIndex = 39
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsCancel
        '
        Me.tsCancel.Image = CType(resources.GetObject("tsCancel.Image"), System.Drawing.Image)
        Me.tsCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCancel.Name = "tsCancel"
        Me.tsCancel.Size = New System.Drawing.Size(63, 22)
        Me.tsCancel.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(609, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 40
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Change_Location_Id, Me.Column2, Me.PurchaseOrder_Date, Me.Actual_CL_Datetime, Me.IT_Equipment_Id})
        Me.DataGridViewX1.DataSource = Me.bsChangeLocation
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(12, 89)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.RowHeadersVisible = False
        Me.DataGridViewX1.Size = New System.Drawing.Size(730, 294)
        Me.DataGridViewX1.TabIndex = 41
        '
        'cbFromLocation
        '
        Me.cbFromLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFromLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFromLocation.FormattingEnabled = True
        Me.cbFromLocation.Location = New System.Drawing.Point(429, 54)
        Me.cbFromLocation.Name = "cbFromLocation"
        Me.cbFromLocation.Size = New System.Drawing.Size(147, 21)
        Me.cbFromLocation.TabIndex = 42
        '
        'txtITEquipmentSearch
        '
        Me.txtITEquipmentSearch.Location = New System.Drawing.Point(89, 52)
        Me.txtITEquipmentSearch.Name = "txtITEquipmentSearch"
        Me.txtITEquipmentSearch.Size = New System.Drawing.Size(146, 20)
        Me.txtITEquipmentSearch.TabIndex = 44
        '
        'btnSearchITEquipment
        '
        Me.btnSearchITEquipment.Location = New System.Drawing.Point(12, 50)
        Me.btnSearchITEquipment.Name = "btnSearchITEquipment"
        Me.btnSearchITEquipment.Size = New System.Drawing.Size(75, 24)
        Me.btnSearchITEquipment.TabIndex = 45
        Me.btnSearchITEquipment.Text = "Search"
        Me.btnSearchITEquipment.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(425, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "From Location:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(590, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 19)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "To Location:"
        '
        'txtChangeLocation
        '
        Me.txtChangeLocation.Enabled = False
        Me.txtChangeLocation.Location = New System.Drawing.Point(272, 55)
        Me.txtChangeLocation.Name = "txtChangeLocation"
        Me.txtChangeLocation.Size = New System.Drawing.Size(137, 20)
        Me.txtChangeLocation.TabIndex = 38
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(272, 28)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(137, 19)
        Me.SearchLabel.TabIndex = 37
        Me.SearchLabel.Text = "Change Location Id:"
        '
        'cbToLocation
        '
        Me.cbToLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbToLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbToLocation.FormattingEnabled = True
        Me.cbToLocation.Location = New System.Drawing.Point(592, 54)
        Me.cbToLocation.Name = "cbToLocation"
        Me.cbToLocation.Size = New System.Drawing.Size(146, 21)
        Me.cbToLocation.TabIndex = 43
        '
        'Change_Location_Id
        '
        Me.Change_Location_Id.DataPropertyName = "Change_Location_Id"
        Me.Change_Location_Id.HeaderText = "Change Location Id"
        Me.Change_Location_Id.Name = "Change_Location_Id"
        Me.Change_Location_Id.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "From_Location"
        Me.Column2.HeaderText = "From Location"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'PurchaseOrder_Date
        '
        Me.PurchaseOrder_Date.DataPropertyName = "To_Location"
        Me.PurchaseOrder_Date.HeaderText = "To Location"
        Me.PurchaseOrder_Date.Name = "PurchaseOrder_Date"
        Me.PurchaseOrder_Date.ReadOnly = True
        '
        'Actual_CL_Datetime
        '
        Me.Actual_CL_Datetime.DataPropertyName = "Actual_Change_Location_Datetime"
        Me.Actual_CL_Datetime.HeaderText = "Actual Change Location Datetime"
        Me.Actual_CL_Datetime.Name = "Actual_CL_Datetime"
        Me.Actual_CL_Datetime.ReadOnly = True
        '
        'IT_Equipment_Id
        '
        Me.IT_Equipment_Id.DataPropertyName = "IT_Equipment_Id"
        Me.IT_Equipment_Id.HeaderText = "Control No."
        Me.IT_Equipment_Id.Name = "IT_Equipment_Id"
        Me.IT_Equipment_Id.ReadOnly = True
        '
        'frmChangeLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearchITEquipment)
        Me.Controls.Add(Me.txtITEquipmentSearch)
        Me.Controls.Add(Me.cbToLocation)
        Me.Controls.Add(Me.cbFromLocation)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtChangeLocation)
        Me.Controls.Add(Me.SearchLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangeLocation"
        Me.Text = "Change Location"
        CType(Me.bsChangeLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsChangeLocation As BindingSource
    Friend WithEvents tsNew As ToolStripButton
    Friend WithEvents tsEdit As ToolStripButton
    Friend WithEvents tsSave As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsCancel As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cbFromLocation As ComboBox
    Friend WithEvents txtITEquipmentSearch As TextBox
    Friend WithEvents btnSearchITEquipment As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    'Friend WithEvents SearchBox As Label
    Friend WithEvents txtChangeLocation As TextBox
    Friend WithEvents SearchLabel As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents cbToLocation As ComboBox
    Friend WithEvents Change_Location_Id As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseOrder_Date As DataGridViewTextBoxColumn
    Friend WithEvents Actual_CL_Datetime As DataGridViewTextBoxColumn
    Friend WithEvents IT_Equipment_Id As DataGridViewTextBoxColumn
End Class
