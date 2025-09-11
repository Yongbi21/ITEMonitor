<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.SideBar1 = New DevComponents.DotNetBar.SideBar()
        Me.EquipmentPanel1 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.Equipment = New DevComponents.DotNetBar.ButtonItem()
        Me.PurchaseOrder = New DevComponents.DotNetBar.ButtonItem()
        Me.POSPermit = New DevComponents.DotNetBar.ButtonItem()
        Me.ChangeLocation = New DevComponents.DotNetBar.ButtonItem()
        Me.ChangeCounter = New DevComponents.DotNetBar.ButtonItem()
        Me.ReferenceData = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.EquipmentLocation = New DevComponents.DotNetBar.ButtonItem()
        Me.POSCounter = New DevComponents.DotNetBar.ButtonItem()
        Me.SuspendLayout()
        '
        'SideBar1
        '
        Me.SideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar
        Me.SideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None
        Me.SideBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideBar1.ExpandedPanel = Me.EquipmentPanel1
        Me.SideBar1.Location = New System.Drawing.Point(0, 0)
        Me.SideBar1.Name = "SideBar1"
        Me.SideBar1.Panels.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.EquipmentPanel1})
        Me.SideBar1.Size = New System.Drawing.Size(155, 450)
        Me.SideBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SideBar1.TabIndex = 0
        Me.SideBar1.Text = "SideBar1"
        '
        'EquipmentPanel1
        '
        Me.EquipmentPanel1.FontBold = True
        Me.EquipmentPanel1.Name = "EquipmentPanel1"
        Me.EquipmentPanel1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Equipment, Me.PurchaseOrder, Me.POSPermit, Me.ChangeLocation, Me.ChangeCounter, Me.ReferenceData})
        Me.EquipmentPanel1.Text = "Equipment Monitoring"
        '
        'Equipment
        '
        Me.Equipment.FontBold = True
        Me.Equipment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.Equipment.Name = "Equipment"
        Me.Equipment.Text = "Equipment"
        '
        'PurchaseOrder
        '
        Me.PurchaseOrder.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.PurchaseOrder.FontBold = True
        Me.PurchaseOrder.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.PurchaseOrder.Name = "PurchaseOrder"
        Me.PurchaseOrder.Text = "Purchase Order"
        '
        'POSPermit
        '
        Me.POSPermit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.POSPermit.FontBold = True
        Me.POSPermit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.POSPermit.Name = "POSPermit"
        Me.POSPermit.Text = "Permits"
        '
        'ChangeLocation
        '
        Me.ChangeLocation.FontBold = True
        Me.ChangeLocation.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ChangeLocation.Name = "ChangeLocation"
        Me.ChangeLocation.Text = "Change Location"
        '
        'ChangeCounter
        '
        Me.ChangeCounter.FontBold = True
        Me.ChangeCounter.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ChangeCounter.Name = "ChangeCounter"
        Me.ChangeCounter.Text = "Change Counter"
        '
        'ReferenceData
        '
        Me.ReferenceData.AutoExpandOnClick = True
        Me.ReferenceData.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ReferenceData.FontBold = True
        Me.ReferenceData.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ReferenceData.Name = "ReferenceData"
        Me.ReferenceData.PopupSide = DevComponents.DotNetBar.ePopupSide.Right
        Me.ReferenceData.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem2, Me.EquipmentLocation, Me.POSCounter})
        Me.ReferenceData.Text = "Reference Data"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Equipment Types"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Equipment Areas"
        '
        'EquipmentLocation
        '
        Me.EquipmentLocation.Name = "EquipmentLocation"
        Me.EquipmentLocation.Text = "Equipment Locations"
        '
        'POSCounter
        '
        Me.POSCounter.Name = "POSCounter"
        Me.POSCounter.Text = "POS Counters"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SideBar1)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "Equipment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SideBar1 As DevComponents.DotNetBar.SideBar
    Friend WithEvents EquipmentPanel1 As DevComponents.DotNetBar.SideBarPanelItem
    Public WithEvents Equipment As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PurchaseOrder As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents POSPermit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ReferenceData As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents EquipmentLocation As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents POSCounter As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ChangeLocation As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ChangeCounter As DevComponents.DotNetBar.ButtonItem
End Class
