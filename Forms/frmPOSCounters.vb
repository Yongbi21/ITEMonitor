Public Class frmPOSCounters

    Private isNew As Boolean = False
    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")
    Private dsrpt As New dsReports
    Private t As New DataTable
    Private r As DataRow

#Region "Calling Function"
    Private Sub loadMain()
        Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "SELECT * FROM [POSCounterName]")
        If tbl.Rows.Count > 0 Then
            bsCounter.DataSource = tbl
        Else
            bsCounter.DataSource = Nothing
        End If

    End Sub
#End Region

    Private Sub frmPOSCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            CountersTextBox.Enabled = False

            ' Set ToolTips for the ToolStrip buttons
            tsNew.ToolTipText = "Add a new counter"
            tsEdit.ToolTipText = "Edit the selected counter"
            tsPrint.ToolTipText = "Print"
            tsSave.ToolTipText = "Save changes"
            tsClose.ToolTipText = "Close this form"
        Catch ex As Exception
            MessageBox.Show("Error loading POS Counters form:" & vbCrLf & ex.ToString(), "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DataGridViewX1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewX1.SelectionChanged
        If DataGridViewX1.SelectedRows.Count > 0 Then
            ' If a row is selected, populate the textbox and enable the Edit button
            CountersTextBox.Text = DataGridViewX1.SelectedRows(0).Cells("Counter_Name").Value.ToString()
            tsEdit.Enabled = True
            tsSave.Enabled = False
            CountersTextBox.Enabled = False
        Else
            ' If no row is selected, clear the textbox and disable buttons
            CountersTextBox.Text = ""
            tsEdit.Enabled = False
            tsSave.Enabled = False
            CountersTextBox.Enabled = False
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
        CountersTextBox.Enabled = False
        CountersTextBox.Text = ""

        ' Clear selection in DataGridView
        DataGridViewX1.ClearSelection()
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        Dim filter As String = ""
        If Not String.IsNullOrWhiteSpace(SearchBox.Text) Then
            filter = String.Format("Counter_Name LIKE '%{0}%'", SearchBox.Text.Replace("'", "''"))
        End If
        bsCounter.Filter = filter
    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If DataGridViewX1.SelectedRows.Count > 0 Then
            ' Get the ID from the selected row (it's in the first column)
            Dim counterId As String = DataGridViewX1.SelectedRows(0).Cells("Column1").Value.ToString()
            Dim newCounterName As String = CountersTextBox.Text

            If String.IsNullOrWhiteSpace(newCounterName) Then
                MessageBox.Show("Counter name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                ' Create parameters for the Update stored procedure
                Dim sqlParams As New List(Of System.Data.SqlClient.SqlParameter)
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@counterId", counterId))
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@CounterName", newCounterName))

                ' Call the existing data access function that takes parameters
                If da.ExcuteSQLQuery(dbName, "UpdatePOSCounter", sqlParams) Then
                    MessageBox.Show("Counter updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadMain() ' Refresh the grid
                Else
                    MessageBox.Show("Failed to update counter. The record may have been deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred:" & vbCrLf & ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        ' Enable the textbox and the save button to allow editing.
        CountersTextBox.Enabled = True
        tsSave.Enabled = True
        tsEdit.Enabled = False ' Disable the edit button while editing.
    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        isNew = True
        Dim newCounterName As String = Microsoft.VisualBasic.Interaction.InputBox("Enter the new location name:", "Add New Counter")

        If Not String.IsNullOrWhiteSpace(newCounterName) Then
            Try
                ' 1. Create the list of parameters for the stored procedure
                Dim sqlParams As New List(Of System.Data.SqlClient.SqlParameter)

                ' 2. Add the INPUT parameter for the area name
                sqlParams.Add(New System.Data.SqlClient.SqlParameter("@CounterName", newCounterName))

                ' 3. Add the OUTPUT parameter to receive the new ID. We must specify its type and size.
                Dim outParam As New System.Data.SqlClient.SqlParameter("@NewId", System.Data.SqlDbType.VarChar, 20)
                outParam.Direction = System.Data.ParameterDirection.Output
                sqlParams.Add(outParam)

                ' 4. Call the new data access function to execute the stored procedure
                Dim newId As String = da.ExecuteSPWithOutput(dbName, "AddPOSCounterName", sqlParams)

                ' 5. Check if it was successful
                If Not String.IsNullOrEmpty(newId) Then
                    MessageBox.Show(String.Format("New counter '{0}' added successfully with ID: {1}", newCounterName, newId), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    loadMain() ' Refresh the grid
                Else
                    MessageBox.Show("Failed to add new counter. The stored procedure did not return a new ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred:" & vbCrLf & ex.ToString(), "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        isNew = False
    End Sub


    Private Sub tsPrint_Click(sender As Object, e As EventArgs) Handles tsPrint.Click
        dsrpt.Tables("POS Counters").Clear()
        dsrpt.Tables("POS Counters").AcceptChanges()
        t = dsrpt.Tables("POS Counters")



        With bsCounter
            If .Count <= 0 Then
                Return
            End If

            .MoveFirst()

            For i As Integer = 0 To .Count - 1
                r = t.NewRow
                r("Counter_Id") = .Current("Counter_Id")
                r("Counter_Name") = .Current("Counter_Name")
                t.Rows.Add(r)
                .MoveNext()
            Next

            m_report = New posCounterReport
            m_report.SetDataSource(dsrpt)
            viewRPT()

        End With
    End Sub

End Class