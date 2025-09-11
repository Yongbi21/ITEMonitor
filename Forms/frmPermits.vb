Public Class Permits

    Private isNew As Boolean = False
    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")


#Region "Calling Function"
    Private Sub loadMain()
        Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "SELECT * FROM [POSPermitNumber]")
        If tbl.Rows.Count > 0 Then
            bsPermits.DataSource = tbl
        Else
            bsPermits.DataSource = Nothing
        End If

    End Sub
#End Region

    Private Sub frmPOSPermit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            loadMain()


            DataGridViewX1.Enabled = True
            DataGridViewX1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridViewX1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
            DataGridViewX1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
            ' --------------------------------------------

            ' Set initial state for editing controls
            tsEdit.Enabled = False
            tsSave.Enabled = False
            PermitsTextBox.Enabled = False

            ' Set ToolTips for the ToolStrip buttons
            tsNew.ToolTipText = "Add a new permit"
            tsEdit.ToolTipText = "Edit the selected permit"
            tsPrint.ToolTipText = "Print"
            tsSave.ToolTipText = "Save changes"
            tsClose.ToolTipText = "Close this form"
        Catch ex As Exception
            MessageBox.Show("Error loading POS Permits form:" & vbCrLf & ex.ToString(), "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridViewX1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewX1.SelectionChanged
        If DataGridViewX1.SelectedRows.Count > 0 Then
            ' If a row is selected, populate the textbox and enable the Edit button
            PermitsTextBox.Text = DataGridViewX1.SelectedRows(0).Cells("Column2").Value.ToString()
            tsEdit.Enabled = True
            tsSave.Enabled = False
            PermitsTextBox.Enabled = False
        Else
            ' If no row is selected, clear the textbox and disable buttons
            PermitsTextBox.Text = ""
            tsEdit.Enabled = False
            tsSave.Enabled = False
            PermitsTextBox.Enabled = False
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
        PermitsTextBox.Enabled = False
        PermitsTextBox.Text = ""

        ' Clear selection in DataGridView
        DataGridViewX1.ClearSelection()
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        Dim filter As String = ""
        If Not String.IsNullOrWhiteSpace(SearchBox.Text) Then
            filter = String.Format("Permit_Number LIKE '%{0}%'", SearchBox.Text.Replace("'", "''"))
        End If
        bsPermits.Filter = filter
    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If DataGridViewX1.SelectedRows.Count > 0 Then
            ' Get the ID from the selected row (it's in the first column)
            Dim permitId As String = DataGridViewX1.SelectedRows(0).Cells("Column1").Value.ToString()
            Dim newPermitNumber As String = PermitsTextBox.Text


            If String.IsNullOrWhiteSpace(newPermitNumber) Then
                MessageBox.Show("Permit name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                ' Create parameters for the Update stored procedure
                Dim sqlParams As New List(Of System.Data.SqlClient.SqlParameter)
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@permitId", permitId))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@PermitNumber", newPermitNumber))

                ' Call the existing data access function that takes parameters
                If da.ExcuteSQLQuery(dbName, "UpdatePermitNumber", sqlParams) Then
                    MessageBox.Show("Permit updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadMain() ' Refresh the grid
                Else
                    MessageBox.Show("Failed to update permit. The record may have been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred:" & vbCrLf & ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        ' Enable the textbox and the save button to allow editing.
        PermitsTextBox.Enabled = True
        tsSave.Enabled = True
        tsEdit.Enabled = False ' Disable the edit button while editing.
    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        isNew = True
        Dim newPermitNumber As String = Microsoft.VisualBasic.Interaction.InputBox("Enter the new permit number:", "Add New Permit")

        If Not String.IsNullOrWhiteSpace(newPermitNumber) Then
            Try
                ' 1. Create the list of parameters for the stored procedure
                Dim sqlParams As New List(Of System.Data.SqlClient.SqlParameter)

                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@PermitNumber", newPermitNumber))
                Dim newId As Boolean = da.ExecuteSPWithOutput1(dbName, "AddPermitNumber", sqlParams)

                ' 5. Check if it was successful
                If newId Then
                    MessageBox.Show(String.Format("New permit '{0}' added successfully with ID: {1}", newPermitNumber, newId), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadMain() ' Refresh the grid
                Else
                    MessageBox.Show("Failed to add new permit. The stored procedure did not return a new ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred:" & vbCrLf & ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        isNew = False
    End Sub


    Private Sub bsPermitsChange(sender As Object, e As EventArgs) Handles bsPermits.CurrentChanged
        If bsPermits.Count > 0 Then
            PermitsTextBox.Text = bsPermits.Current("Permit_Number")
        End If
    End Sub

End Class