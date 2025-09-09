<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddPurchaseOrder
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
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPurchaseOrderNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtInvoiceNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMemberName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSupplierNumber = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.txtPurchaseOrderDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.txtInvoiceDate = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        CType(Me.txtPurchaseOrderDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.Location = New System.Drawing.Point(37, 71)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(168, 19)
        Me.SearchLabel.TabIndex = 51
        Me.SearchLabel.Text = "Purchase Order Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Invoice Number:"
        '
        'txtPurchaseOrderNumber
        '
        '
        '
        '
        Me.txtPurchaseOrderNumber.Border.Class = "TextBoxBorder"
        Me.txtPurchaseOrderNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPurchaseOrderNumber.Location = New System.Drawing.Point(41, 99)
        Me.txtPurchaseOrderNumber.Name = "txtPurchaseOrderNumber"
        Me.txtPurchaseOrderNumber.Size = New System.Drawing.Size(197, 20)
        Me.txtPurchaseOrderNumber.TabIndex = 55
        '
        'txtInvoiceNumber
        '
        '
        '
        '
        Me.txtInvoiceNumber.Border.Class = "TextBoxBorder"
        Me.txtInvoiceNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(297, 99)
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(197, 20)
        Me.txtInvoiceNumber.TabIndex = 56
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(37, 140)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(148, 19)
        Me.label.TabIndex = 57
        Me.label.Text = "Purchase Order Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(293, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Invoice Date:"
        '
        'txtMemberName
        '
        '
        '
        '
        Me.txtMemberName.Border.Class = ""
        Me.txtMemberName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMemberName.Location = New System.Drawing.Point(297, 242)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.Size = New System.Drawing.Size(197, 20)
        Me.txtMemberName.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 19)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Supplier Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(293, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Member Name:"
        '
        'txtSupplierNumber
        '
        '
        '
        '
        Me.txtSupplierNumber.Border.Class = "TextBoxBorder"
        Me.txtSupplierNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSupplierNumber.Location = New System.Drawing.Point(41, 242)
        Me.txtSupplierNumber.Name = "txtSupplierNumber"
        Me.txtSupplierNumber.Size = New System.Drawing.Size(197, 20)
        Me.txtSupplierNumber.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(193, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 23)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Add Purchase Order"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Location = New System.Drawing.Point(165, 286)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 23)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSave.TabIndex = 66
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Location = New System.Drawing.Point(278, 286)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 23)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnCancel.TabIndex = 67
        Me.btnCancel.Text = "Cancel"
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
        Me.txtPurchaseOrderDate.Location = New System.Drawing.Point(38, 168)
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
        Me.txtPurchaseOrderDate.TabIndex = 68
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
        Me.txtInvoiceDate.Location = New System.Drawing.Point(297, 168)
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
        Me.txtInvoiceDate.TabIndex = 69
        '
        'frmAddPurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 332)
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
        Me.Name = "frmAddPurchaseOrder"
        Me.Text = "Purchase Order"
        CType(Me.txtPurchaseOrderDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPurchaseOrderNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtInvoiceNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMemberName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSupplierNumber As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtPurchaseOrderDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents txtInvoiceDate As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
