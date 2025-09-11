<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadPermitNumber
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadPermitNumber))
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.bsPermitLoad = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsSelect = New System.Windows.Forms.ToolStripButton()
        Me.tsClose = New System.Windows.Forms.ToolStripButton()
        Me.enterBtnCounter = New System.Windows.Forms.Button()
        Me.Permit_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Permit_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Permit_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPermitLoad, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Permit_Id, Me.Permit_Number, Me.Permit_Date})
        Me.DataGridViewX1.DataSource = Me.bsPermitLoad
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(12, 69)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.RowHeadersVisible = False
        Me.DataGridViewX1.Size = New System.Drawing.Size(482, 303)
        Me.DataGridViewX1.TabIndex = 40
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(73, 28)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(198, 20)
        Me.txtSearch.TabIndex = 38
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(11, 28)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(56, 19)
        Me.SearchLabel.TabIndex = 37
        Me.SearchLabel.Text = "Search:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSelect, Me.tsClose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 388)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(506, 25)
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
        'enterBtnCounter
        '
        Me.enterBtnCounter.Location = New System.Drawing.Point(273, 27)
        Me.enterBtnCounter.Name = "enterBtnCounter"
        Me.enterBtnCounter.Size = New System.Drawing.Size(75, 24)
        Me.enterBtnCounter.TabIndex = 62
        Me.enterBtnCounter.Text = "Enter"
        Me.enterBtnCounter.UseVisualStyleBackColor = True
        '
        'Permit_Id
        '
        Me.Permit_Id.DataPropertyName = "Permit_Id"
        Me.Permit_Id.HeaderText = "Permit ID"
        Me.Permit_Id.Name = "Permit_Id"
        Me.Permit_Id.ReadOnly = True
        '
        'Permit_Number
        '
        Me.Permit_Number.DataPropertyName = "Permit_Number"
        Me.Permit_Number.HeaderText = "Permit Number"
        Me.Permit_Number.Name = "Permit_Number"
        Me.Permit_Number.ReadOnly = True
        '
        'Permit_Date
        '
        Me.Permit_Date.DataPropertyName = "Permit_Date"
        Me.Permit_Date.HeaderText = "Permit Date"
        Me.Permit_Date.Name = "Permit_Date"
        Me.Permit_Date.ReadOnly = True
        '
        'frmLoadPermitNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 413)
        Me.Controls.Add(Me.enterBtnCounter)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.SearchLabel)
        Me.Name = "frmLoadPermitNumber"
        Me.Text = "Permit Number Table"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPermitLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents SearchLabel As Label
    Friend WithEvents bsPermitLoad As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsSelect As ToolStripButton
    Friend WithEvents tsClose As ToolStripButton
    Friend WithEvents enterBtnCounter As Button
    Friend WithEvents Permit_Id As DataGridViewTextBoxColumn
    Friend WithEvents Permit_Number As DataGridViewTextBoxColumn
    Friend WithEvents Permit_Date As DataGridViewTextBoxColumn
End Class
