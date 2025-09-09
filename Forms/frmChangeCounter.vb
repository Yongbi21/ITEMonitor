Public Class frmChangeCounter

    Private isNew As Boolean = False
        Private isEditing As Boolean = False
        Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")
        Private Const dbName As String = "ITEMonitordb"


#Region "Calling Function"
        Private Sub loadMain()
            Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "EXEC GetChangeCounterHistory")
        If tbl.Rows.Count > 0 Then
            bsChangeCounter.DataSource = tbl
        Else
            bsChangeCounter.DataSource = Nothing
        End If
            SetUIState(False)

        End Sub

        Private Sub loadCounters()
            Try
            Dim locationTable = da.GetLoadData(dbName, "SELECT Counter_Id, Counter_Name FROM POSCounterName ORDER BY Counter_Name")

            ' Load From Location combo
            cbFromCounter.DataSource = locationTable.Copy()
            cbFromCounter.DisplayMember = "Counter_Name"
            cbFromCounter.ValueMember = "Counter_Id"

            ' Load To Location combo  
            cbToCounter.DataSource = locationTable.Copy()
            cbToCounter.DisplayMember = "Counter_Name"
            cbToCounter.ValueMember = "Counter_Id"

        Catch ex As Exception
            MessageBox.Show("Error loading locations: " & ex.Message)
        End Try
    End Sub

    Private Sub btnChangeCounter_Click(sender As Object, e As EventArgs) Handles findBtnChangeCounter.Click
        With frmLoadChangeCounter
            .ShowDialog()
            txtChangeCounter.Text = .selectedArea
        End With

    End Sub

#End Region

    Private Sub SetUIState(isEditingState As Boolean)
        isEditing = isEditingState

        tsNew.Enabled = Not isEditingState
        tsEdit.Enabled = Not isEditingState AndAlso bsChangeCounter.Count > 0
        tsSave.Enabled = isEditingState
        tsCancel.Enabled = isEditingState

        txtEquipmentId.Enabled = isEditingState
        cbFromCounter.Enabled = isEditingState
        cbToCounter.Enabled = isEditingState
        DataGridViewX1.Enabled = Not isEditingState
    End Sub


    Private Sub frmChangeCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            loadMain()
            loadCounters()

            DataGridViewX1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridViewX1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
            DataGridViewX1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black

            ' Set ToolTips for the ToolStrip buttons
            tsNew.ToolTipText = "Add a new change counter"
            tsEdit.ToolTipText = "Edit the selected change counter"
            tsSave.ToolTipText = "Save changes"
            tsCancel.ToolTipText = "Cancel changes"

        Catch ex As Exception
            MessageBox.Show("Error loading Change Counter form:" & vbCrLf & ex.ToString(), "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        isNew = True
        bsChangeCounter.AddNew()
        SetUIState(True)
        txtChangeCounter.Text = "Default"
    End Sub
    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        isNew = False

        ' Tell the BindingSource to begin editing current row
        If bsChangeCounter.Current IsNot Nothing Then
            CType(bsChangeCounter.Current, DataRowView).BeginEdit()
        End If

        SetUIState(True)
    End Sub


    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If Not ValidateInput() Then Return

        Try
            Dim fromCounterId = cbFromCounter.SelectedValue.ToString()
            Dim toCounterId = cbToCounter.SelectedValue.ToString()
            Dim equipmentId = txtEquipmentId.Text
            Dim query As String

            If isNew Then
                Dim changeDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                query = $"EXEC AddChangeCounter @FromCounterId = '{fromCounterId}', @ToCounterId = '{toCounterId}', @ActualChangeCounterDateTime = '{changeDateTime}', @ITEquipmentId = '{equipmentId}'"
                da.ExcuteSQLQuery(dbName, query)
                MessageBox.Show("Successfully added new record.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else ' isEditing
                Dim changeCounterId = GetSafeString(CType(bsChangeCounter.Current, DataRowView)("Change_Counter_Id"))
                query = $"UPDATE ChangeCounter SET From_Counter_Id = '{fromCounterId}', To_Counter_Id = '{toCounterId}', IT_Equipment_Id = '{equipmentId}' WHERE Change_Counter_Id = '{changeCounterId}'"
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
            bsChangeCounter.CancelEdit()

            ' Reset flags
            isNew = False
            isEditing = False

            ' Refresh UI
            SetUIState(False)
            bsChangeCounterChange(Nothing, Nothing)

            MessageBox.Show("Changes cancelled.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error cancelling changes: " & ex.Message, "Cancel Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Function ValidateInput() As Boolean
        If cbFromCounter.SelectedValue Is Nothing Then
            MessageBox.Show("From Counter is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cbToCounter.SelectedValue Is Nothing Then
            MessageBox.Show("To Counter is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(txtEquipmentId.Text) Then
            MessageBox.Show("IT Equipment is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub bsChangeCounterChange(sender As Object, e As EventArgs) Handles bsChangeCounter.CurrentChanged
        If Not isEditing AndAlso bsChangeCounter.Count > 0 AndAlso bsChangeCounter.Current IsNot Nothing Then
            Dim currentRow = CType(bsChangeCounter.Current, DataRowView)
            cbFromCounter.SelectedValue = GetSafeString(currentRow("From_Counter_Id"))
            cbToCounter.SelectedValue = GetSafeString(currentRow("To_Counter_Id"))
            txtChangeCounter.Text = GetSafeString(currentRow("Change_Counter_Id"))
            txtEquipmentId.Text = GetSafeString(currentRow("IT_Equipment_Id"))
        ElseIf bsChangeCounter.Count = 0 Then
            txtChangeCounter.Text = ""
            txtEquipmentId.Text = ""
            cbFromCounter.SelectedIndex = -1
            cbToCounter.SelectedIndex = -1
        End If

        tsEdit.Enabled = bsChangeCounter.Count > 0 And Not isEditing
    End Sub

    Private Function GetSafeString(value As Object) As String
        If IsDBNull(value) OrElse value Is Nothing Then
            Return ""
        Else
            Return value.ToString()
        End If
    End Function


End Class

