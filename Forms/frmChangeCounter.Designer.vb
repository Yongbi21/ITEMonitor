<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeCounter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangeCounter))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsCancel = New System.Windows.Forms.ToolStripButton()
        Me.ITEquipment = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.findBtnChangeCounter = New System.Windows.Forms.Button()
        Me.txtEquipmentId = New System.Windows.Forms.TextBox()
        Me.cbToCounter = New System.Windows.Forms.ComboBox()
        Me.cbFromCounter = New System.Windows.Forms.ComboBox()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.bsChangeCounter = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.txtChangeCounter = New System.Windows.Forms.TextBox()
        Me.Change_Location_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseOrder_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actual_CC_Datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IT_Equipment_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChangeCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsCancel
        '
        Me.tsCancel.Image = CType(resources.GetObject("tsCancel.Image"), System.Drawing.Image)
        Me.tsCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCancel.Name = "tsCancel"
        Me.tsCancel.Size = New System.Drawing.Size(63, 22)
        Me.tsCancel.Text = "Cancel"
        '
        'ITEquipment
        '
        Me.ITEquipment.AutoSize = True
        Me.ITEquipment.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ITEquipment.Location = New System.Drawing.Point(521, 26)
        Me.ITEquipment.Name = "ITEquipment"
        Me.ITEquipment.Size = New System.Drawing.Size(98, 19)
        Me.ITEquipment.TabIndex = 60
        Me.ITEquipment.Text = "IT Equipment:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(340, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "To Counter:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "From Counter:"
        '
        'findBtnChangeCounter
        '
        Me.findBtnChangeCounter.Location = New System.Drawing.Point(677, 52)
        Me.findBtnChangeCounter.Name = "findBtnChangeCounter"
        Me.findBtnChangeCounter.Size = New System.Drawing.Size(75, 24)
        Me.findBtnChangeCounter.TabIndex = 57
        Me.findBtnChangeCounter.Text = "Find"
        Me.findBtnChangeCounter.UseVisualStyleBackColor = True
        '
        'txtEquipmentId
        '
        Me.txtEquipmentId.Location = New System.Drawing.Point(525, 53)
        Me.txtEquipmentId.Name = "txtEquipmentId"
        Me.txtEquipmentId.Size = New System.Drawing.Size(146, 20)
        Me.txtEquipmentId.TabIndex = 56
        '
        'cbToCounter
        '
        Me.cbToCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbToCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbToCounter.FormattingEnabled = True
        Me.cbToCounter.Location = New System.Drawing.Point(342, 52)
        Me.cbToCounter.Name = "cbToCounter"
        Me.cbToCounter.Size = New System.Drawing.Size(146, 21)
        Me.cbToCounter.TabIndex = 55
        '
        'cbFromCounter
        '
        Me.cbFromCounter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFromCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFromCounter.FormattingEnabled = True
        Me.cbFromCounter.Location = New System.Drawing.Point(179, 52)
        Me.cbFromCounter.Name = "cbFromCounter"
        Me.cbFromCounter.Size = New System.Drawing.Size(147, 21)
        Me.cbFromCounter.TabIndex = 54
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
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Change_Location_Id, Me.Column2, Me.PurchaseOrder_Date, Me.Actual_CC_Datetime, Me.IT_Equipment_Id})
        Me.DataGridViewX1.DataSource = Me.bsChangeCounter
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(22, 91)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.RowHeadersVisible = False
        Me.DataGridViewX1.Size = New System.Drawing.Size(730, 294)
        Me.DataGridViewX1.TabIndex = 53
        '
        'bsChangeCounter
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(359, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 52
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.ToolStripSeparator1, Me.tsEdit, Me.ToolStripSeparator2, Me.tsSave, Me.ToolStripSeparator3, Me.tsCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 425)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsNew
        '
        Me.tsNew.Image = CType(resources.GetObject("tsNew.Image"), System.Drawing.Image)
        Me.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(51, 22)
        Me.tsNew.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsEdit
        '
        Me.tsEdit.Image = CType(resources.GetObject("tsEdit.Image"), System.Drawing.Image)
        Me.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(47, 22)
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
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(51, 22)
        Me.tsSave.Text = "Save"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(22, 26)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(133, 19)
        Me.SearchLabel.TabIndex = 49
        Me.SearchLabel.Text = "Change Counter Id:"
        '
        'txtChangeCounter
        '
        Me.txtChangeCounter.Enabled = False
        Me.txtChangeCounter.Location = New System.Drawing.Point(22, 53)
        Me.txtChangeCounter.Name = "txtChangeCounter"
        Me.txtChangeCounter.Size = New System.Drawing.Size(137, 20)
        Me.txtChangeCounter.TabIndex = 50
        '
        'Change_Location_Id
        '
        Me.Change_Location_Id.DataPropertyName = "Change_Counter_Id"
        Me.Change_Location_Id.HeaderText = "Change Counter Id"
        Me.Change_Location_Id.Name = "Change_Location_Id"
        Me.Change_Location_Id.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "From_Counter"
        Me.Column2.HeaderText = "From Counter"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'PurchaseOrder_Date
        '
        Me.PurchaseOrder_Date.DataPropertyName = "To_Counter"
        Me.PurchaseOrder_Date.HeaderText = "To Counter"
        Me.PurchaseOrder_Date.Name = "PurchaseOrder_Date"
        Me.PurchaseOrder_Date.ReadOnly = True
        '
        'Actual_CC_Datetime
        '
        Me.Actual_CC_Datetime.DataPropertyName = "Actual_Change_Counter_Datetime"
        Me.Actual_CC_Datetime.HeaderText = "Actual Change Counter Datetime"
        Me.Actual_CC_Datetime.Name = "Actual_CC_Datetime"
        Me.Actual_CC_Datetime.ReadOnly = True
        '
        'IT_Equipment_Id
        '
        Me.IT_Equipment_Id.DataPropertyName = "IT_Equipment_Id"
        Me.IT_Equipment_Id.HeaderText = "IT Equipment Id"
        Me.IT_Equipment_Id.Name = "IT_Equipment_Id"
        Me.IT_Equipment_Id.ReadOnly = True
        '
        'frmChangeCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ITEquipment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.findBtnChangeCounter)
        Me.Controls.Add(Me.txtEquipmentId)
        Me.Controls.Add(Me.cbToCounter)
        Me.Controls.Add(Me.cbFromCounter)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtChangeCounter)
        Me.Controls.Add(Me.SearchLabel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangeCounter"
        Me.Text = "Change Counter"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChangeCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsCancel As ToolStripButton
    Friend WithEvents ITEquipment As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents findBtnChangeCounter As Button
    Friend WithEvents txtEquipmentId As TextBox
    Friend WithEvents cbToCounter As ComboBox
    Friend WithEvents cbFromCounter As ComboBox
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsNew As ToolStripButton
    Friend WithEvents tsEdit As ToolStripButton
    Friend WithEvents tsSave As ToolStripButton
    Friend WithEvents bsChangeCounter As BindingSource
    Friend WithEvents SearchLabel As Label
    Friend WithEvents txtChangeCounter As TextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Change_Location_Id As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseOrder_Date As DataGridViewTextBoxColumn
    Friend WithEvents Actual_CC_Datetime As DataGridViewTextBoxColumn
    Friend WithEvents IT_Equipment_Id As DataGridViewTextBoxColumn
End Class
