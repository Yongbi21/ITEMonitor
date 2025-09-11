Public Class frmEquipmentAreas

    Private isNew As Boolean = False
    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")

#Region "Calling Function"
    Private Sub loadMain()
        Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "SELECT * FROM [EquipmentArea]")
        If tbl.Rows.Count > 0 Then
            bsEquipmentArea.DataSource = tbl
        Else
            bsEquipmentArea.DataSource = Nothing
        End If

    End Sub
#End Region



    Private Sub frmEquipmentAreas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        AreasTextBox.Enabled = False

        ' Set ToolTips for the ToolStrip buttons
        tsNew.ToolTipText = "Add a new area"
        tsEdit.ToolTipText = "Edit the selected area"
        tsPrint.ToolTipText = "Print"
        tsSave.ToolTipText = "Save changes"
        tsClose.ToolTipText = "Close this form"
    End Sub

    Private Sub DataGridViewX1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewX1.SelectionChanged
        If DataGridViewX1.SelectedRows.Count > 0 Then
            ' If a row is selected, populate the textbox and enable the Edit button
            AreasTextBox.Text = DataGridViewX1.SelectedRows(0).Cells("Column2").Value.ToString()
            tsEdit.Enabled = True
            tsSave.Enabled = False
            AreasTextBox.Enabled = False
        Else
            ' If no row is selected, clear the textbox and disable buttons
            AreasTextBox.Text = ""
            tsEdit.Enabled = False
            tsSave.Enabled = False
            AreasTextBox.Enabled = False
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
        AreasTextBox.Enabled = False
        AreasTextBox.Text = ""

        ' Clear selection in DataGridView
        DataGridViewX1.ClearSelection()
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        Dim filter As String = ""
        If Not String.IsNullOrWhiteSpace(SearchBox.Text) Then
            filter = String.Format("Area_Name LIKE '%{0}%'", SearchBox.Text.Replace("'", "''"))
        End If
        bsEquipmentArea.Filter = filter
    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If DataGridViewX1.SelectedRows.Count > 0 Then
            ' Get the ID from the selected row (it's in the first column)
            Dim areaId As String = DataGridViewX1.SelectedRows(0).Cells("Column1").Value.ToString()
            Dim newAreaName As String = AreasTextBox.Text

            If String.IsNullOrWhiteSpace(newAreaName) Then
                MessageBox.Show("Area name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                ' Create parameters for the Update stored procedure
                Dim sqlParams As New List(Of System.Data.SqlClient.SqlParameter)
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@AreaId", areaId))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@AreaName", newAreaName))

                ' Call the existing data access function that takes parameters
                If da.ExcuteSQLQuery(dbName, "UpdateEquipmentArea", sqlParams) Then
                    MessageBox.Show("Area updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadMain() ' Refresh the grid
                Else
                    MessageBox.Show("Failed to update area. The record may have been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred:" & vbCrLf & ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        ' Enable the textbox and the save button to allow editing.
        AreasTextBox.Enabled = True
        tsSave.Enabled = True
        tsEdit.Enabled = False ' Disable the edit button while editing.
    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        isNew = True
        Dim newAreaName As String = Microsoft.VisualBasic.Interaction.InputBox("Enter the new area name:", "Add New Area")

        If Not String.IsNullOrWhiteSpace(newAreaName) Then
            Try
                ' 1. Create the list of parameters for the stored procedure
                Dim sqlParams As New List(Of System.Data.SqlClient.SqlParameter)

                ' 2. Add the INPUT parameter for the area name
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@AreaName", newAreaName))

                ' 3. Add the OUTPUT parameter to receive the new ID. We must specify its type and size.
                Dim outParam As New System.Data.SqlClient.SqlParameter("@NewId", System.Data.SqlDbType.VarChar, 20)
                outParam.Direction = System.Data.ParameterDirection.Output
                sqlParams.Add(outParam)

                ' 4. Call the new data access function to execute the stored procedure
                Dim newId As String = da.ExecuteSPWithOutput(dbName, "AddEquipmentArea", sqlParams)

                ' 5. Check if it was successful
                If Not String.IsNullOrEmpty(newId) Then
                    MessageBox.Show(String.Format("New area '{0}' added successfully with ID: {1}", newAreaName, newId), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadMain() ' Refresh the grid
                Else
                    MessageBox.Show("Failed to add new area. The stored procedure did not return a new ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred:" & vbCrLf & ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        isNew = False
    End Sub


    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub
End Class