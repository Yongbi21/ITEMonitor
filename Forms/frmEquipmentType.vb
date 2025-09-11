Public Class frmEquipmentType

    Private isNew As Boolean = False
    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")

#Region "Calling Function"
    Private Sub loadMain()
        Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "SELECT * FROM [EquipmentType]")
        If tbl.Rows.Count > 0 Then
            bsEquipmentType.DataSource = tbl
        Else
            bsEquipmentType.DataSource = Nothing
        End If

    End Sub
#End Region


    Private Sub frmEquimentType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadMain()

        ' --- Force Grid to be Enabled and Selectable ---
        DataGridViewX1.Enabled = True
        DataGridViewX1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewX1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewX1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        ' --------------------------------------------

        ' Set initial state for editing controls
        tsEdit.Enabled = False
        tsSave.Enabled = False
        TypeTextBox.Enabled = False

        ' Set ToolTips for the ToolStrip buttons
        tsNew.ToolTipText = "Add a new equipment"
        tsEdit.ToolTipText = "Edit the selected equipment"
        tsPrint.ToolTipText = "Print"
        tsSave.ToolTipText = "Save changes"
        tsClose.ToolTipText = "Close this form"
    End Sub

    Private Sub DataGridViewX1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewX1.SelectionChanged
        If DataGridViewX1.SelectedRows.Count > 0 Then
            ' If a row is selected, populate the textbox and enable the Edit button
            TypeTextBox.Text = DataGridViewX1.SelectedRows(0).Cells("Column2").Value.ToString()
            tsEdit.Enabled = True
            tsSave.Enabled = False
            TypeTextBox.Enabled = False
        Else
            ' If no row is selected, clear the textbox and disable buttons
            TypeTextBox.Text = ""
            tsEdit.Enabled = False
            tsSave.Enabled = False
            TypeTextBox.Enabled = False
        End If
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
        TypeTextBox.Enabled = False
        TypeTextBox.Text = ""

        ' Clear selection in DataGridView
        DataGridViewX1.ClearSelection()
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        Dim filter As String = ""
        If Not String.IsNullOrWhiteSpace(SearchBox.Text) Then
            filter = String.Format("Type_Name LIKE '%{0}%'", SearchBox.Text.Replace("'", "''"))
        End If
        bsEquipmentType.Filter = filter
    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If DataGridViewX1.SelectedRows.Count > 0 Then
            ' Get the ID from the selected row (it's in the first column)
            Dim typeId As String = DataGridViewX1.SelectedRows(0).Cells("Column1").Value.ToString()
            Dim newEquipmentTypeName As String = TypeTextBox.Text

            If String.IsNullOrWhiteSpace(newEquipmentTypeName) Then
                MessageBox.Show("Equipment name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                ' Create parameters for the Update stored procedure
                Dim sqlParams As New List(Of System.Data.SqlClient.SqlParameter)
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@TypeId", typeId))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@TypeName", newEquipmentTypeName))

                ' Call the existing data access function that takes parameters
                If da.ExcuteSQLQuery(dbName, "UpdateEquipmentType", sqlParams) Then
                    MessageBox.Show("Equipment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadMain() ' Refresh the grid
                Else
                    MessageBox.Show("Failed to update Equipment. The record may have been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred:" & vbCrLf & ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        ' Enable the textbox and the save button to allow editing.
        TypeTextBox.Enabled = True
        tsSave.Enabled = True
        tsEdit.Enabled = False ' Disable the edit button while editing.
    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        isNew = True
        Dim newEquipmentTypeName As String = Microsoft.VisualBasic.Interaction.InputBox("Enter the new equipment name:", "Add New Equipment")

        If Not String.IsNullOrWhiteSpace(newEquipmentTypeName) Then
            Try
                ' 1. Create the list of parameters for the stored procedure
                Dim sqlParams As New List(Of System.Data.SqlClient.SqlParameter)

                ' 2. Add the INPUT parameter for the area name
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@TypeName", newEquipmentTypeName))

                ' 3. Add the OUTPUT parameter to receive the new ID. We must specify its type and size.
                Dim outParam As New System.Data.SqlClient.SqlParameter("@NewId", System.Data.SqlDbType.VarChar, 20)
                outParam.Direction = System.Data.ParameterDirection.Output
                sqlParams.Add(outParam)

                ' 4. Call the new data access function to execute the stored procedure
                Dim newId As String = da.ExecuteSPWithOutput(dbName, "AddEquipmentType", sqlParams)

                ' 5. Check if it was successful
                If Not String.IsNullOrEmpty(newId) Then
                    MessageBox.Show(String.Format("New equipment '{0}' added successfully with ID: {1}", newEquipmentTypeName, newId), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadMain() ' Refresh the grid
                Else
                    MessageBox.Show("Failed to add new equipment. The stored procedure did not return a new ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred:" & vbCrLf & ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        isNew = False
    End Sub



End Class