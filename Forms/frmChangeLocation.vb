Public Class frmChangeLocation

    Private isNew As Boolean = False
    Private isEditing As Boolean = False
    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")
    Private Const dbName As String = "ITEMonitordb"


#Region "Calling Function"
    Private Sub loadMain()
        Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "EXEC GetChangeLocationHistory")
        If tbl.Rows.Count > 0 Then
            bsChangeLocation.DataSource = tbl
        Else
            bsChangeLocation.DataSource = Nothing
        End If
        SetUIState(False)

    End Sub

    Private Sub loadLocations()
        Try
            Dim locationTable = da.GetLoadData(dbName, "SELECT Location_Id, Location_Name FROM EquipmentLocation ORDER BY Location_Name")

            ' Load From Location combo
            cbFromLocation.DataSource = locationTable.Copy()
            cbFromLocation.DisplayMember = "Location_Name"
            cbFromLocation.ValueMember = "Location_Id"

            ' Load To Location combo  
            cbToLocation.DataSource = locationTable.Copy()
            cbToLocation.DisplayMember = "Location_Name"
            cbToLocation.ValueMember = "Location_Id"

        Catch ex As Exception
            MessageBox.Show("Error loading locations: " & ex.Message)
        End Try
    End Sub

    Private Sub btnFindChangeLoc_Click(sender As Object, e As EventArgs) Handles findBtnChangeLoc.Click
        With frmLoadChangeLocation
            .ShowDialog()
            txtChangeLocation.Text = .selectedArea
        End With
    End Sub

#End Region

    Private Sub SetUIState(isEditingState As Boolean)
        isEditing = isEditingState

        tsNew.Enabled = Not isEditingState
        tsEdit.Enabled = Not isEditingState AndAlso bsChangeLocation.Count > 0
        tsSave.Enabled = isEditingState
        tsCancel.Enabled = isEditingState

        txtEquipmentId.Enabled = isEditingState
        cbFromLocation.Enabled = isEditingState
        cbToLocation.Enabled = isEditingState
        DataGridViewX1.Enabled = Not isEditingState
    End Sub


    Private Sub frmChangeLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            loadMain()
            loadLocations()

            DataGridViewX1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridViewX1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
            DataGridViewX1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black

            ' Set ToolTips for the ToolStrip buttons
            tsNew.ToolTipText = "Add a new change location"
            tsEdit.ToolTipText = "Edit the selected change location"
            tsSave.ToolTipText = "Save changes"
            tsCancel.ToolTipText = "Cancel changes"

        Catch ex As Exception
            MessageBox.Show("Error loading Change Location form:" & vbCrLf & ex.ToString(), "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        isNew = True
        bsChangeLocation.AddNew()
        SetUIState(True)
        txtChangeLocation.Text = "Default"
    End Sub
    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        isNew = False

        ' Tell the BindingSource to begin editing current row
        If bsChangeLocation.Current IsNot Nothing Then
            CType(bsChangeLocation.Current, DataRowView).BeginEdit()
        End If

        SetUIState(True)
    End Sub


    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If Not ValidateInput() Then Return

        Try
            Dim fromLocationId = cbFromLocation.SelectedValue.ToString()
            Dim toLocationId = cbToLocation.SelectedValue.ToString()
            Dim equipmentId = txtEquipmentId.Text
            Dim query As String

            If isNew Then
                Dim changeDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                query = $"EXEC AddChangeLocation @FromLocationId = '{fromLocationId}', @ToLocationId = '{toLocationId}', @ActualChangeLocationDateTime = '{changeDateTime}', @ITEquipmentId = '{equipmentId}'"
                da.ExcuteSQLQuery(dbName, query)
                MessageBox.Show("Successfully added new record.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else ' isEditing
                Dim changeLocationId = GetSafeString(CType(bsChangeLocation.Current, DataRowView)("Change_Location_Id"))
                query = $"UPDATE ChangeLocation SET From_Location_Id = '{fromLocationId}', To_Location_Id = '{toLocationId}', IT_Equipment_Id = '{equipmentId}' WHERE Change_Location_Id = '{changeLocationId}'"
                da.ExcuteSQLQuery(dbName, query)
                MessageBox.Show("Successfully updated record.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            loadMain()
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsCancel_Click(sender As Object, e As EventArgs) Handles tsCancel.Click
        Try
            ' Cancel any changes on the current record
            bsChangeLocation.CancelEdit()

            ' Reset flags
            isNew = False
            isEditing = False

            ' Refresh UI
            SetUIState(False)
            bsChangeLocationChange(Nothing, Nothing)

            MessageBox.Show("Changes cancelled.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error cancelling changes: " & ex.Message, "Cancel Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Function ValidateInput() As Boolean
        If cbFromLocation.SelectedValue Is Nothing Then
            MessageBox.Show("From Location is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cbToLocation.SelectedValue Is Nothing Then
            MessageBox.Show("To Location is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtEquipmentId.Text) Then
            MessageBox.Show("IT Equipment is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub bsChangeLocationChange(sender As Object, e As EventArgs) Handles bsChangeLocation.CurrentChanged
        If Not isEditing AndAlso bsChangeLocation.Count > 0 AndAlso bsChangeLocation.Current IsNot Nothing Then
            Dim currentRow = CType(bsChangeLocation.Current, DataRowView)
            cbFromLocation.SelectedValue = GetSafeString(currentRow("From_Location_Id"))
            cbToLocation.SelectedValue = GetSafeString(currentRow("To_Location_Id"))
            txtChangeLocation.Text = GetSafeString(currentRow("Change_Location_Id"))
            txtEquipmentId.Text = GetSafeString(currentRow("IT_Equipment_Id"))
        ElseIf bsChangeLocation.Count = 0 Then
            txtChangeLocation.Text = ""
            txtEquipmentId.Text = ""
            cbFromLocation.SelectedIndex = -1
            cbToLocation.SelectedIndex = -1
        End If

        tsEdit.Enabled = bsChangeLocation.Count > 0 And Not isEditing
    End Sub

    Private Function GetSafeString(value As Object) As String
        If IsDBNull(value) OrElse value Is Nothing Then
            Return ""
        Else
            Return value.ToString()
        End If
    End Function

End Class