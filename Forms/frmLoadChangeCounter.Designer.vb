<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadChangeCounter
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
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.Change_Location_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseOrder_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Actual_CC_Datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IT_Equipment_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearchChange = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.bsChangeCounterLoad = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChangeCounterLoad, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Change_Location_Id, Me.Column2, Me.PurchaseOrder_Date, Me.Actual_CC_Datetime, Me.IT_Equipment_Id})
        Me.DataGridViewX1.DataSource = Me.bsChangeCounterLoad
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(12, 72)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.RowHeadersVisible = False
        Me.DataGridViewX1.Size = New System.Drawing.Size(725, 287)
        Me.DataGridViewX1.TabIndex = 55
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
        Me.IT_Equipment_Id.HeaderText = "IT Equipment"
        Me.IT_Equipment_Id.Name = "IT_Equipment_Id"
        Me.IT_Equipment_Id.ReadOnly = True
        '
        'txtSearchChange
        '
        Me.txtSearchChange.Location = New System.Drawing.Point(75, 33)
        Me.txtSearchChange.Name = "txtSearchChange"
        Me.txtSearchChange.Size = New System.Drawing.Size(144, 20)
        Me.txtSearchChange.TabIndex = 54
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(13, 32)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(56, 19)
        Me.SearchLabel.TabIndex = 53
        Me.SearchLabel.Text = "Search:"
        '
        'frmLoadChangeCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 371)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.txtSearchChange)
        Me.Controls.Add(Me.SearchLabel)
        Me.Name = "frmLoadChangeCounter"
        Me.Text = "Change Counter Table"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChangeCounterLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtSearchChange As TextBox
    Friend WithEvents SearchLabel As Label
    Friend WithEvents Change_Location_Id As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseOrder_Date As DataGridViewTextBoxColumn
    Friend WithEvents Actual_CC_Datetime As DataGridViewTextBoxColumn
    Friend WithEvents IT_Equipment_Id As DataGridViewTextBoxColumn
    Friend WithEvents bsChangeCounterLoad As BindingSource
End Class
