<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadPurchaseOrder
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadPurchaseOrder))
        Me.bsPurchaseOrderLoad = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PurchaseOrder_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purchase_Order_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Purchase_Order_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Invoice_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Invoice_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supplier_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Member_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsSelect = New System.Windows.Forms.ToolStripButton()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.enterBtnPurchaseOrder = New System.Windows.Forms.Button()
        CType(Me.bsPurchaseOrderLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurchaseOrder_Id, Me.Purchase_Order_Number, Me.Purchase_Order_Date, Me.Invoice_Number, Me.Invoice_Date, Me.Supplier_Number, Me.Member_Name})
        Me.DataGridViewX1.DataSource = Me.bsPurchaseOrderLoad
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(12, 67)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.RowHeadersVisible = False
        Me.DataGridViewX1.Size = New System.Drawing.Size(928, 306)
        Me.DataGridViewX1.TabIndex = 38
        '
        'PurchaseOrder_Id
        '
        Me.PurchaseOrder_Id.DataPropertyName = "Purchase_Order_Id"
        Me.PurchaseOrder_Id.HeaderText = "Purchase Order Id"
        Me.PurchaseOrder_Id.Name = "PurchaseOrder_Id"
        Me.PurchaseOrder_Id.ReadOnly = True
        '
        'Purchase_Order_Number
        '
        Me.Purchase_Order_Number.DataPropertyName = "Purchase_Order_Number"
        Me.Purchase_Order_Number.HeaderText = "Purchase Order Number"
        Me.Purchase_Order_Number.Name = "Purchase_Order_Number"
        Me.Purchase_Order_Number.ReadOnly = True
        '
        'Purchase_Order_Date
        '
        Me.Purchase_Order_Date.DataPropertyName = "Purchase_Order_Date"
        Me.Purchase_Order_Date.HeaderText = "Purchase Order Date"
        Me.Purchase_Order_Date.Name = "Purchase_Order_Date"
        Me.Purchase_Order_Date.ReadOnly = True
        '
        'Invoice_Number
        '
        Me.Invoice_Number.DataPropertyName = "Invoice_Number"
        Me.Invoice_Number.HeaderText = "Invoice Number"
        Me.Invoice_Number.Name = "Invoice_Number"
        Me.Invoice_Number.ReadOnly = True
        '
        'Invoice_Date
        '
        Me.Invoice_Date.DataPropertyName = "Invoice_Date"
        Me.Invoice_Date.HeaderText = "Invoice Date"
        Me.Invoice_Date.Name = "Invoice_Date"
        Me.Invoice_Date.ReadOnly = True
        '
        'Supplier_Number
        '
        Me.Supplier_Number.DataPropertyName = "Supplier_Number"
        Me.Supplier_Number.HeaderText = "Supplier Number"
        Me.Supplier_Number.Name = "Supplier_Number"
        Me.Supplier_Number.ReadOnly = True
        '
        'Member_Name
        '
        Me.Member_Name.DataPropertyName = "Member_Name"
        Me.Member_Name.HeaderText = "Member Name"
        Me.Member_Name.Name = "Member_Name"
        Me.Member_Name.ReadOnly = True
        Me.Member_Name.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(83, 29)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(193, 20)
        Me.txtSearch.TabIndex = 37
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(21, 29)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(56, 19)
        Me.SearchLabel.TabIndex = 36
        Me.SearchLabel.Text = "Search:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSelect, Me.tsClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 389)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(952, 25)
        Me.ToolStrip1.TabIndex = 61
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsSelect
        '
        Me.tsSelect.Image = CType(resources.GetObject("tsSelect.Image"), System.Drawing.Image)
        Me.tsSelect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSelect.Name = "tsSelect"
        Me.tsSelect.Size = New System.Drawing.Size(58, 22)
        Me.tsSelect.Text = "Select"
        '
        'tsClose
        '
        Me.tsClose.Image = CType(resources.GetObject("tsClose.Image"), System.Drawing.Image)
        Me.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsClose.Name = "tsClose"
        Me.tsClose.Size = New System.Drawing.Size(56, 22)
        Me.tsClose.Text = "Close"
        '
        'enterBtnPurchaseOrder
        '
        Me.enterBtnPurchaseOrder.Location = New System.Drawing.Point(282, 28)
        Me.enterBtnPurchaseOrder.Name = "enterBtnPurchaseOrder"
        Me.enterBtnPurchaseOrder.Size = New System.Drawing.Size(75, 24)
        Me.enterBtnPurchaseOrder.TabIndex = 62
        Me.enterBtnPurchaseOrder.Text = "Enter"
        Me.enterBtnPurchaseOrder.UseVisualStyleBackColor = True
        '
        'frmLoadPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 414)
        Me.Controls.Add(Me.enterBtnPurchaseOrder)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.SearchLabel)
        Me.Name = "frmLoadPurchaseOrder"
        Me.Text = "Purchase Order Table"
        CType(Me.bsPurchaseOrderLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bsPurchaseOrderLoad As BindingSource
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PurchaseOrder_Id As DataGridViewTextBoxColumn
    Friend WithEvents Purchase_Order_Number As DataGridViewTextBoxColumn
    Friend WithEvents Purchase_Order_Date As DataGridViewTextBoxColumn
    Friend WithEvents Invoice_Number As DataGridViewTextBoxColumn
    Friend WithEvents Invoice_Date As DataGridViewTextBoxColumn
    Friend WithEvents Supplier_Number As DataGridViewTextBoxColumn
    Friend WithEvents Member_Name As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents SearchLabel As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsSelect As ToolStripButton
    Friend WithEvents tsClose As ToolStripButton
    Friend WithEvents enterBtnPurchaseOrder As Button
End Class
