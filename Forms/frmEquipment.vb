Public Class frmEquipment


    Private isNew As Boolean = False
    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")

#Region "Calling Function"
    Private Sub loadMain()
        Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "EXEC GetITEquipmentDetails")
        If tbl.Rows.Count > 0 Then
            bsEquipment.DataSource = tbl
        Else
            bsEquipment.DataSource = Nothing
        End If

    End Sub




    Private Sub loadChangeCounter(Optional itEquipmentId As String = Nothing)
        Dim tbl As New DataTable
        Dim query As String

        If String.IsNullOrWhiteSpace(itEquipmentId) Then
            query = "EXEC GetChangeCounterHistory"
        Else
            query = $"EXEC GetChangeCounterHistory @SearchTerm = '{itEquipmentId}'"
        End If

        tbl = da.GetLoadData(dbName, query)
        If tbl.Rows.Count > 0 Then
            bsChangeCounter.DataSource = tbl
        Else
            bsChangeCounter.DataSource = Nothing
        End If

    End Sub


    Private Sub loadChangeLocation(Optional itEquipmentId As String = Nothing)
        Dim tbl As New DataTable
        Dim query As String

        If String.IsNullOrWhiteSpace(itEquipmentId) Then
            query = "EXEC GetChangeLocationHistory"
        Else
            query = $"EXEC GetChangeLocationHistory @SearchTerm = '{itEquipmentId}'"
        End If
        tbl = da.GetLoadData(dbName, query)
        If tbl.Rows.Count > 0 Then
            bsChangeLocation.DataSource = tbl
        Else
            bsChangeLocation.DataSource = Nothing
        End If

    End Sub

#End Region


    Private Sub frmEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBoxes
        cbBir.Items.Add("Yes")
        cbBir.Items.Add("No")
        cbCounter.Items.Add("Yes")
        cbCounter.Items.Add("No")

        cbEquipmentType.DataSource = da.GetLoadData(dbName, "SELECT Type_Id, Type_Name FROM EquipmentType")
        cbEquipmentType.DisplayMember = "Type_Name"
        cbEquipmentType.ValueMember = "Type_Id"

        cbEquipmentLocation.DataSource = da.GetLoadData(dbName, "SELECT Location_Id, Location_Name FROM EquipmentLocation")
        cbEquipmentLocation.DisplayMember = "Location_Name"
        cbEquipmentLocation.ValueMember = "Location_Id"

        cbEquipmentArea.DataSource = da.GetLoadData(dbName, "SELECT Area_Id, Area_Name FROM EquipmentArea")
        cbEquipmentArea.DisplayMember = "Area_Name"
        cbEquipmentArea.ValueMember = "Area_Id"

        loadMain()
        loadChangeCounter(Nothing)
        loadChangeLocation(Nothing)
        'SetEnableCtrls(False)

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

        SetFindButtonsVisibility(False)

    End Sub




    Private Sub equipmentGridview_SelectionChanged(sender As Object, e As EventArgs) Handles equipmentGridView.SelectionChanged
        If equipmentGridView.SelectedRows.Count > 0 Then
            tsEdit.Enabled = True
            tsSave.Enabled = False

            Dim selectedITEquipmentId As String = equipmentGridView.SelectedRows(0).Cells("IT_Equipment_Id").Value.ToString()
            loadChangeLocation(selectedITEquipmentId)
            loadChangeCounter(selectedITEquipmentId)
        Else
            tsEdit.Enabled = False
            tsSave.Enabled = False

            loadChangeLocation(Nothing)
            loadChangeCounter(Nothing)
        End If
    End Sub

    Private Sub equipmentGridview_Click(sender As Object, e As EventArgs)
        equipmentGridView.SelectAll()
    End Sub


    Private Sub tsClose_Click(sender As Object, e As EventArgs) Handles tsClose.Click
        ' Refresh the data from the database
        loadMain()

        ' Reset form state
        isNew = False
        tsSave.Enabled = False
        tsEdit.Enabled = False
        tsNew.Enabled = True

        ' Make textbox read-only again
        txtControlNo.Enabled = False
        txtControlNo.ReadOnly = False
        txtMachineSerialNo.Enabled = False
        txtMachineSerialNo.ReadOnly = False
        txtStore.Enabled = False
        txtStore.ReadOnly = False
        cbBir.Enabled = False
        cbCounter.Enabled = False
        cbEquipmentType.Enabled = False
        cbEquipmentLocation.Enabled = False
        cbEquipmentArea.Enabled = False
        txtPurchaseOrder.Enabled = False
        txtPurchaseOrder.ReadOnly = False
        txtPermitNo.Enabled = False
        txtPermitNo.ReadOnly = False
        txtCounterName.Enabled = False
        txtCounterName.ReadOnly = False
        ' Clear selection in DataGridView
        DataGridViewX1.ClearSelection()
        SetFindButtonsVisibility(False)

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        isNew = True
        TabControl2.SelectedTab = TabItem2Details
        tsSave.Enabled = True
        tsEdit.Enabled = False
        tsNew.Enabled = False

        'SetEnableCtrls(isNew)

        ' We will create this sub next to clear and enable controls
        InitializeDetailsPanelForNew()

        SetFindButtonsVisibility(True)
    End Sub

    ' Make the code shorter using this condition
    'Private Sub SetEnableCtrls(isEnable As Boolean)
    '    For Each ctrl As Control In Panel1.Controls
    '        ctrl.Enabled = isEnable
    '    Next
    'End Sub

    Private Sub InitializeDetailsPanelForNew()
        ' Clear textboxes
        txtControlNo.Text = "Default"
        txtMachineSerialNo.Clear()
        txtStore.Clear()
        cbBir.SelectedIndex = -1
        cbCounter.SelectedIndex = -1
        cbEquipmentType.SelectedIndex = -1
        cbEquipmentLocation.SelectedIndex = -1
        cbEquipmentArea.SelectedIndex = -1
        txtPurchaseOrder.Clear()
        txtPermitNo.Clear()
        txtCounterName.Clear()

        ' Enable and make textboxes writable
        Panel1.Enabled = True
        txtControlNo.Enabled = False
        txtMachineSerialNo.Enabled = True
        txtMachineSerialNo.ReadOnly = False
        txtStore.Enabled = True
        txtStore.ReadOnly = False
        cbBir.Enabled = True
        cbCounter.Enabled = True
        cbEquipmentType.Enabled = True
        cbEquipmentLocation.Enabled = True
        cbEquipmentArea.Enabled = True
        txtPurchaseOrder.Enabled = True
        txtPurchaseOrder.ReadOnly = False
        txtPermitNo.Enabled = True
        txtPermitNo.ReadOnly = False
        txtCounterName.Enabled = True
        txtCounterName.ReadOnly = False

        ' Set focus to the first input field
        txtMachineSerialNo.Focus()
    End Sub


    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        If equipmentGridView.SelectedRows.Count > 0 Then
            isNew = False
            TabControl2.SelectedTab = TabItem2Details
            tsSave.Enabled = True
            tsEdit.Enabled = False
            tsNew.Enabled = False

            ' Enable controls for editing
            Panel1.Enabled = True
            txtControlNo.Enabled = False ' Cannot edit control number
            txtMachineSerialNo.Enabled = True
            txtMachineSerialNo.ReadOnly = False
            txtStore.Enabled = True
            txtStore.ReadOnly = False
            cbBir.Enabled = True
            cbCounter.Enabled = True
            cbEquipmentType.Enabled = True
            cbEquipmentLocation.Enabled = True
            cbEquipmentArea.Enabled = True
            txtPurchaseOrder.Enabled = True
            txtPurchaseOrder.ReadOnly = False
            txtPermitNo.Enabled = True
            txtPermitNo.ReadOnly = False
            txtCounterName.Enabled = True
            txtCounterName.ReadOnly = False

            SetFindButtonsVisibility(True)

            txtMachineSerialNo.Focus()
        End If
    End Sub


    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If isNew Then
            Try
                Dim sqlParams As New List(Of System.Data.SqlClient.SqlParameter)

                ' NOTE: Assuming the find buttons populate the Tag property of the textboxes with the selected IDs.
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@ControlNumber", txtControlNo.Text))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@MachineSerialNumber", txtMachineSerialNo.Text))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@Store", txtStore.Text))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@isCounterUse", If(cbCounter.SelectedItem IsNot Nothing AndAlso cbCounter.SelectedItem.ToString() = "Yes", 1, 0)))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@isRegisterBir", If(cbBir.SelectedItem IsNot Nothing AndAlso cbBir.SelectedItem.ToString() = "Yes", 1, 0)))

                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@CounterId", If(txtCounterName.Tag IsNot Nothing, txtCounterName.Tag, DBNull.Value)))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@TypeId", cbEquipmentType.SelectedValue))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@LocationId", cbEquipmentLocation.SelectedValue))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@AreaId", cbEquipmentArea.SelectedValue))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@PermitId", If(txtPermitNo.Tag IsNot Nothing, txtPermitNo.Tag, DBNull.Value)))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@PurchaseOrderId", If(txtPurchaseOrder.Tag IsNot Nothing, txtPurchaseOrder.Tag, DBNull.Value)))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@CreatedDate", DateTime.Now))


                Dim outParam As New System.Data.SqlClient.SqlParameter("@NewId", System.Data.SqlDbType.NVarChar, 50)
                outParam.Direction = System.Data.ParameterDirection.Output
                sqlParams.Add(outParam)

                Dim newId As String = da.ExecuteSPWithOutput(dbName, "AddITEquipment", sqlParams)

                If Not String.IsNullOrEmpty(newId) Then
                    MessageBox.Show("New equipment added successfully with ID: " & newId, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadMain() ' Refresh the grid
                    TabControl2.SelectedTab = TabItem1Main ' Switch back to the main tab
                    tsSave.Enabled = False
                    tsEdit.Enabled = False
                    tsNew.Enabled = True
                    SetFindButtonsVisibility(False)
                Else
                    MessageBox.Show("Failed to add new equipment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' UPDATE existing record using INLINE SQL
            Try
                If bsEquipment.Current Is Nothing Then
                    MessageBox.Show("No equipment selected to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Dim currentRow As DataRowView = CType(bsEquipment.Current, DataRowView)
                Dim equipmentId As String = currentRow("IT_Equipment_Id").ToString()

                ' Construct the inline SQL UPDATE statement
                Dim sqlQuery As String = "UPDATE ITEquipment SET " &
                                         "Machine_Serial_Number = @MachineSerialNumber, " &
                                         "Store = @Store, " &
                                         "isCounter_Use = @isCounterUse, " &
                                         "isRegister_Bir = @isRegisterBir, " &
                                         "Counter_Id = @CounterId, " &
                                         "Type_Id = @TypeId, " &
                                         "Location_Id = @LocationId, " &
                                         "Equipment_Area_Id = @AreaId, " &
                                         "Permit_Id = @PermitId, " &
                                         "Purchase_Order_Id = @PurchaseOrderId " &
                                         "WHERE IT_Equipment_Id = @ITEquipmentId"

                Dim sqlParams As New List(Of System.Data.SqlClient.SqlParameter)

                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@ITEquipmentId", equipmentId))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@MachineSerialNumber", txtMachineSerialNo.Text))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@Store", txtStore.Text))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@isCounterUse", If(cbCounter.SelectedItem IsNot Nothing AndAlso cbCounter.SelectedItem.ToString() = "Yes", 1, 0)))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@isRegisterBir", If(cbBir.SelectedItem IsNot Nothing AndAlso cbBir.SelectedItem.ToString() = "Yes", 1, 0)))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@CounterId", If(txtCounterName.Tag IsNot Nothing, txtCounterName.Tag, DBNull.Value)))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@TypeId", cbEquipmentType.SelectedValue))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@LocationId", cbEquipmentLocation.SelectedValue))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@AreaId", cbEquipmentArea.SelectedValue))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@PermitId", If(txtPermitNo.Tag IsNot Nothing, txtPermitNo.Tag, DBNull.Value)))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@PurchaseOrderId", If(txtPurchaseOrder.Tag IsNot Nothing, txtPurchaseOrder.Tag, DBNull.Value)))

                ' This assumes a method 'ExecuteNonQuery(query, params)' exists in your data access class
                ' that executes an inline SQL command and returns the number of affected rows.
                Dim affectedRows As Integer = da.ExecuteNonQuery(dbName, sqlQuery, sqlParams)

                If affectedRows > 0 Then
                    MessageBox.Show("Equipment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadMain() ' Refresh the grid
                    TabControl2.SelectedTab = TabItem1Main ' Switch back to the main tab
                    tsSave.Enabled = False
                    tsEdit.Enabled = False ' It will be enabled by selection changed
                    tsNew.Enabled = True
                    SetFindButtonsVisibility(False)
                Else
                    MessageBox.Show("Failed to update equipment. Maybe the record was deleted by another user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while saving: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SetFindButtonsVisibility(isVisible As Boolean)
        findBtnCounter.Visible = isVisible
        findBtnPermitNo.Visible = isVisible
        findBtnPurchaseOrderNo.Visible = isVisible
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
            Dim machineSerialNumber As Object = currentRow("Machine_Serial_Number")
            Dim store As Object = currentRow("Store")
            Dim isCounterUse As Object = currentRow("isCounter_Use")
            Dim isRegisterBir As Object = currentRow("isRegister_Bir")

            ' Populate textboxes that require lookups
            cbEquipmentType.Text = GetNameFromId("EquipmentType", "Type_Id", "Type_Name", typeId)
            cbEquipmentLocation.Text = GetNameFromId("EquipmentLocation", "Location_Id", "Location_Name", locationId)
            cbEquipmentArea.Text = GetNameFromId("EquipmentArea", "Area_Id", "Area_Name", areaId)
            txtPermitNo.Text = GetNameFromId("POSPermitNumber", "Permit_Id", "Permit_Number", permitId)
            txtCounterName.Text = GetNameFromId("POSCounterName", "Counter_Id", "Counter_Name", counterId)
            txtPurchaseOrder.Text = GetNameFromId("PurchaseOrder", "Purchase_Order_Id", "Purchase_Order_Number", purchaseOrderId)

            ' Populate textboxes with direct values 
            txtControlNo.Text = currentRow("IT_Equipment_Id").ToString()
            txtMachineSerialNo.Text = machineSerialNumber.ToString()
            txtStore.Text = store.ToString()

            If isCounterUse IsNot DBNull.Value AndAlso CBool(isCounterUse) Then
                cbCounter.SelectedItem = "Yes"
            Else
                cbCounter.SelectedItem = "No"
            End If

            If isRegisterBir IsNot DBNull.Value AndAlso CBool(isRegisterBir) Then
                cbBir.SelectedItem = "Yes"
            Else
                cbBir.SelectedItem = "No"
            End If

        Else
            ' Clear all textboxes if no equipment is selected
            txtPermitNo.Clear()
            txtCounterName.Clear()
            txtPurchaseOrder.Clear()
            txtControlNo.Clear()
            txtMachineSerialNo.Clear()
            txtStore.Clear()
            cbCounter.SelectedIndex = -1
            cbBir.SelectedIndex = -1
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

    Private Sub DataGridViewX1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewX1.CellFormatting
        Dim dgv As DataGridView = CType(sender, DataGridView)
        ' Check if this is the From_Location_Id or To_Location_Id column and not the header row
        If e.RowIndex >= 0 AndAlso (dgv.Columns(e.ColumnIndex).Name = "From_Location_Id" OrElse dgv.Columns(e.ColumnIndex).Name = "To_Location_Id") Then
            If e.Value IsNot Nothing AndAlso e.Value IsNot DBNull.Value Then
                ' Get the ID from the cell
                Dim locationId = e.Value

                ' Get the name using the helper function
                Dim locationName As String = GetNameFromId("EquipmentLocation", "Location_Id", "Location_Name", locationId)

                ' If a name was found, display it
                If Not String.IsNullOrEmpty(locationName) Then
                    e.Value = locationName
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub

    Private Sub DataGridViewX2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        Dim dgv As DataGridView = CType(sender, DataGridView)
        ' Check if this is the From_Counter_Id or To_Counter_Id column and not the header row
        If e.RowIndex >= 0 AndAlso (dgv.Columns(e.ColumnIndex).Name = "From_Counter_Id" OrElse dgv.Columns(e.ColumnIndex).Name = "To_Counter_Id") Then
            If e.Value IsNot Nothing AndAlso e.Value IsNot DBNull.Value Then
                ' Get the ID from the cell
                Dim counterId = e.Value

                ' Get the name using the helper function
                Dim counterName As String = GetNameFromId("POSCounterName", "Counter_Id", "Counter_Name", counterId)

                ' If a name was found, display it
                If Not String.IsNullOrEmpty(counterName) Then
                    e.Value = counterName
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub





    Private Sub findBtnCounter_Click(sender As Object, e As EventArgs) Handles findBtnCounter.Click
        Using frm As New frmLoadCounter
            If frm.ShowDialog(Me) = DialogResult.OK Then
                txtCounterName.Text = frm.selectedAreaName
                txtCounterName.Tag = frm.selectedArea
            End If
        End Using
    End Sub

    Private Sub findBtnPermitNo_Click(sender As Object, e As EventArgs) Handles findBtnPermitNo.Click
        Using frm As New frmLoadPermitNumber
            If frm.ShowDialog(Me) = DialogResult.OK Then
                txtPermitNo.Text = frm.selectedPermitNumber
                txtPermitNo.Tag = frm.selectedPermitId
            End If
        End Using
    End Sub

    Private Sub findBtnPurchaseOrderNo_Click(sender As Object, e As EventArgs) Handles findBtnPurchaseOrderNo.Click

        Using frm As New frmLoadPurchaseOrder
            If frm.ShowDialog(Me) = DialogResult.OK Then
                txtPurchaseOrder.Text = frm.selectedPurchaseOrderNumber
                txtPurchaseOrder.Tag = frm.selectedPurchaseOrderId
            End If
        End Using

    End Sub


End Class
