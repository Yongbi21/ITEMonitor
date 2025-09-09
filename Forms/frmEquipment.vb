Public Class frmEquipment


    Private isNew As Boolean = False
    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")

#Region "Calling Function"
    Private Sub loadMain()
        Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "SELECT * FROM [ITEquipment]")
        If tbl.Rows.Count > 0 Then
            bsEquipment.DataSource = tbl
        Else
            bsEquipment.DataSource = Nothing
        End If

    End Sub




    Private Sub loadChangeCounter()
        Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "EXEC GetChangeCounterHistory")
        If tbl.Rows.Count > 0 Then
            bsChangeCounter.DataSource = tbl
        Else
            bsChangeCounter.DataSource = Nothing
        End If

    End Sub


    Private Sub loadChangeLocation()
        Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "EXEC GetChangeLocationHistory")
        If tbl.Rows.Count > 0 Then
            bsChangeLocation.DataSource = tbl
        Else
            bsChangeLocation.DataSource = Nothing
        End If

    End Sub



#End Region


    Private Sub frmEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMain()
        loadChangeCounter()
        loadChangeLocation()


        equipmentGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        equipmentGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        equipmentGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black

        ' Set initial state for editing controls
        tsEdit.Enabled = False
        tsSave.Enabled = False

        ' Set ToolTips for the ToolStrip buttons
        tsNew.ToolTipText = "Add a new area"
        tsEdit.ToolTipText = "Edit the selected area"
        tsSave.ToolTipText = "Save changes"
        tsClose.ToolTipText = "Close this form"

    End Sub




    Private Sub equipmentGridview_SelectionChanged(sender As Object, e As EventArgs)
        If equipmentGridView.SelectedRows.Count > 0 Then
            tsEdit.Enabled = True
            tsSave.Enabled = False
        Else
            tsEdit.Enabled = False
            tsSave.Enabled = False
        End If
    End Sub

    Private Sub equipmentGridview_Click(sender As Object, e As EventArgs)
        equipmentGridView.SelectAll()
    End Sub


    Private Sub tsClose_Click(sender As Object, e As EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        isNew = True
        TabControl2.SelectedTab = TabItem2Details
        tsSave.Enabled = True
        tsEdit.Enabled = False
        tsNew.Enabled = False

        ' We will create this sub next to clear and enable controls
        InitializeDetailsPanelForNew()
    End Sub

    Private Sub InitializeDetailsPanelForNew()
        ' Clear textboxes
        txtControlNo.Clear() ' Control No.
        txtMachineSerialNo.Clear() ' Machine Serial No.
        txtStore.Clear() ' Store
        txtBir.Clear() ' BIR Registered
        txtCounterUse.Clear() ' Counter Use
        txtPurchaseOrder.Clear() ' Purchase Order No.
        txtPermitNo.Clear() ' Permit No.
        txtCounterName.Clear() ' Counter Name

        ' Clear textboxes for Equipment Type, Location, and Area
        txtEquipmentType.Clear()
        txtEquipmentLocation.Clear()
        txtEquipmentArea.Clear()

        ' Enable textboxes for Equipment Type, Location, and Area
        txtEquipmentType.Enabled = True
        txtEquipmentLocation.Enabled = True
        txtEquipmentArea.Enabled = True

        ' Enable controls that are normally disabled
        Panel1.Enabled = True ' Enable the whole panel of controls
        txtControlNo.Enabled = True
        txtMachineSerialNo.Enabled = True
        txtStore.Enabled = True
        ' etc. for all input controls...

        ' Set focus to the first input field
        txtControlNo.Focus()
    End Sub


    ' Helper function to get name from ID
    Private Function GetNameFromId(tableName As String, idColumn As String, nameColumn As String, idValue As Object) As String
        If idValue Is DBNull.Value OrElse idValue Is Nothing Then
            Return ""
        End If

        Dim trimmedId = idValue.ToString().Trim()
        Dim query As String = $"SELECT {nameColumn} FROM [{tableName}] WHERE RTRIM(LTRIM({idColumn})) = '{trimmedId}'"

        Dim dt As DataTable = da.GetLoadData(dbName, query)

        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)(nameColumn).ToString()
        Else
            Return ""
        End If
    End Function

    ' New sub to update the equipment detail textboxes
    Private Sub UpdateEquipmentDetailTextBoxes() Handles bsEquipment.CurrentChanged
        If bsEquipment.Current IsNot Nothing Then
            Dim currentRow As DataRowView = CType(bsEquipment.Current, DataRowView)

            ' Get values from the current row
            Dim typeId As Object = currentRow("Type_Id")
            Dim locationId As Object = currentRow("Location_Id")
            Dim areaId As Object = currentRow("Equipment_Area_Id")
            Dim permitId As Object = currentRow("Permit_Id")
            Dim counterId As Object = currentRow("Counter_Id")
            Dim purchaseOrderId As Object = currentRow("Purchase_Order_Id")
            Dim controlNumber As Object = currentRow("Control_Number")
            Dim machineSerialNumber As Object = currentRow("Machine_Serial_Number")
            Dim store As Object = currentRow("Store")
            Dim isCounterUse As Object = currentRow("isCounter_Use")
            Dim isRegisterBir As Object = currentRow("isRegister_Bir")

            ' Populate textboxes that require lookups
            txtEquipmentType.Text = GetNameFromId("EquipmentType", "Type_Id", "Type_Name", typeId)
            txtEquipmentLocation.Text = GetNameFromId("EquipmentLocation", "Location_Id", "Location_Name", locationId)
            txtEquipmentArea.Text = GetNameFromId("EquipmentArea", "Area_Id", "Area_Name", areaId)
            txtPermitNo.Text = GetNameFromId("POSPermitNumber", "Permit_Id", "Permit_Number", permitId)
            txtCounterName.Text = GetNameFromId("POSCounterName", "Counter_Id", "Counter_Name", counterId)
            txtPurchaseOrder.Text = GetNameFromId("PurchaseOrder", "Purchase_Order_Id", "Purchase_Order_Number", purchaseOrderId)

            ' Populate textboxes with direct values
            txtControlNo.Text = controlNumber.ToString()
            txtMachineSerialNo.Text = machineSerialNumber.ToString()
            txtStore.Text = store.ToString()

            If isCounterUse IsNot DBNull.Value AndAlso CBool(isCounterUse) Then
                txtCounterUse.Text = "Yes"
            Else
                txtCounterUse.Text = "No"
            End If

            If isRegisterBir IsNot DBNull.Value AndAlso CBool(isRegisterBir) Then
                txtBir.Text = "Yes"
            Else
                txtBir.Text = "No"
            End If

        Else
            ' Clear all textboxes if no equipment is selected
            txtEquipmentType.Clear()
            txtEquipmentLocation.Clear()
            txtEquipmentArea.Clear()
            txtPermitNo.Clear()
            txtCounterName.Clear()
            txtPurchaseOrder.Clear()
            txtControlNo.Clear()
            txtMachineSerialNo.Clear()
            txtStore.Clear()
            txtCounterUse.Clear()
            txtBir.Clear()
        End If
    End Sub

    Private Sub equipmentGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles equipmentGridView.CellFormatting
        ' Check if this is one of the boolean columns
        Dim colName As String = equipmentGridView.Columns(e.ColumnIndex).Name
        If colName = "isCounter_Use" OrElse colName = "isRegister_Bir" Then
            If e.Value IsNot Nothing AndAlso e.Value IsNot DBNull.Value Then
                If CBool(e.Value) Then
                    e.Value = "Yes"
                Else
                    e.Value = "No"
                End If
                e.FormattingApplied = True
            End If
        End If
    End Sub
End Class