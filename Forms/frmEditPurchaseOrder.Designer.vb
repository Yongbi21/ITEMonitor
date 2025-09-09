<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditPurchaseOrder
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
        Me.txtInvoiceDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtPurchaseOrderDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSupplierNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMemberName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.txtInvoiceNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPurchaseOrderNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchLabel = New System.Windows.Forms.Label()
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPurchaseOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInvoiceDate
        '
        '
        '
        '
        Me.txtInvoiceDate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtInvoiceDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtInvoiceDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtInvoiceDate.ButtonDropDown.Visible = True
        Me.txtInvoiceDate.Location = New System.Drawing.Point(295, 176)
        '
        '
        '
        Me.txtInvoiceDate.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtInvoiceDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtInvoiceDate.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtInvoiceDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtInvoiceDate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtInvoiceDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtInvoiceDate.MonthCalendar.DisplayMonth = New Date(2025, 9, 1, 0, 0, 0, 0)
        Me.txtInvoiceDate.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtInvoiceDate.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtInvoiceDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtInvoiceDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtInvoiceDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtInvoiceDate.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtInvoiceDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtInvoiceDate.MonthCalendar.TodayButtonVisible = True
        Me.txtInvoiceDate.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txtInvoiceDate.Name = "txtInvoiceDate"
        Me.txtInvoiceDate.Size = New System.Drawing.Size(200, 20)
        Me.txtInvoiceDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtInvoiceDate.TabIndex = 84
        '
        'txtPurchaseOrderDate
        '
        '
        '
        '
        Me.txtPurchaseOrderDate.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtPurchaseOrderDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPurchaseOrderDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtPurchaseOrderDate.ButtonDropDown.Visible = True
        Me.txtPurchaseOrderDate.Location = New System.Drawing.Point(36, 176)
        '
        '
        '
        Me.txtPurchaseOrderDate.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtPurchaseOrderDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtPurchaseOrderDate.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtPurchaseOrderDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPurchaseOrderDate.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtPurchaseOrderDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtPurchaseOrderDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtPurchaseOrderDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtPurchaseOrderDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtPurchaseOrderDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtPurchaseOrderDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtPurchaseOrderDate.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtPurchaseOrderDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPurchaseOrderDate.MonthCalendar.DisplayMonth = New Date(2025, 9, 1, 0, 0, 0, 0)
        Me.txtPurchaseOrderDate.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtPurchaseOrderDate.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtPurchaseOrderDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtPurchaseOrderDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtPurchaseOrderDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtPurchaseOrderDate.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtPurchaseOrderDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPurchaseOrderDate.MonthCalendar.TodayButtonVisible = True
        Me.txtPurchaseOrderDate.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txtPurchaseOrderDate.Name = "txtPurchaseOrderDate"
        Me.txtPurchaseOrderDate.Size = New System.Drawing.Size(200, 20)
        Me.txtPurchaseOrderDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtPurchaseOrderDate.TabIndex = 83
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(276, 294)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 82
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(163, 294)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 23)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 81
        Me.btnSave.Text = "Save"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(191, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 23)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Edit Purchase Order"
        '
        'txtSupplierNumber
        '
        '
        '
        '
        Me.txtSupplierNumber.Border.Class = "TextBoxBorder"
        Me.txtSupplierNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSupplierNumber.Location = New System.Drawing.Point(39, 250)
        Me.txtSupplierNumber.Name = "txtSupplierNumber"
        Me.txtSupplierNumber.Size = New System.Drawing.Size(197, 20)
        Me.txtSupplierNumber.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(291, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Member Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 19)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Supplier Number:"
        '
        'txtMemberName
        '
        '
        '
        '
        Me.txtMemberName.Border.Class = ""
        Me.txtMemberName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMemberName.Location = New System.Drawing.Point(295, 250)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(197, 20)
        Me.txtMemberName.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(291, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Invoice Date:"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(35, 148)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(148, 19)
        Me.label.TabIndex = 74
        Me.label.Text = "Purchase Order Date:"
        '
        'txtInvoiceNumber
        '
        '
        '
        '
        Me.txtInvoiceNumber.Border.Class = "TextBoxBorder"
        Me.txtInvoiceNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(295, 107)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(197, 20)
        Me.txtInvoiceNumber.TabIndex = 73
        '
        'txtPurchaseOrderNumber
        '
        '
        '
        '
        Me.txtPurchaseOrderNumber.Border.Class = "TextBoxBorder"
        Me.txtPurchaseOrderNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPurchaseOrderNumber.Location = New System.Drawing.Point(39, 107)
        Me.txtPurchaseOrderNumber.Name = "txtPurchaseOrderNumber"
        Me.txtPurchaseOrderNumber.Size = New System.Drawing.Size(197, 20)
        Me.txtPurchaseOrderNumber.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Invoice Number:"
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(35, 79)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(168, 19)
        Me.SearchLabel.TabIndex = 70
        Me.SearchLabel.Text = "Purchase Order Number:"
        '
        'frmEditPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 353)
        Me.Controls.Add(Me.txtInvoiceDate)
        Me.Controls.Add(Me.txtPurchaseOrderDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSupplierNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMemberName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txtInvoiceNumber)
        Me.Controls.Add(Me.txtPurchaseOrderNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchLabel)
        Me.Name = "frmEditPurchaseOrder"
        Me.Text = "Purchase Order"
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPurchaseOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInvoiceDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtPurchaseOrderDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSupplierNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMemberName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As Label
    Friend WithEvents label As Label
    Friend WithEvents txtInvoiceNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPurchaseOrderNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchLabel As Label
End Class
