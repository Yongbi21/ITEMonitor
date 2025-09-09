Public Class frmLoadChangeLocation
    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")
    Private Const dbName As String = "ITEMonitordb"
    Public selectedArea As String

    ' Timer for delayed search to avoid excessive database calls
    Private WithEvents searchTimer As New Timer()

#Region "Calling Function"
    ' Modified to accept a search term and query the database
    Private Sub loadMain(Optional searchTerm As String = "")
        Try
            Dim tbl As New DataTable
            Dim query As String

            If String.IsNullOrWhiteSpace(searchTerm) Then
                ' If search term is empty, call the procedure without a parameter to get all records
                query = "EXEC GetChangeLocationHistory"
            Else
                ' If there is a search term, pass it to the stored procedure
                query = $"EXEC GetChangeLocationHistory @SearchTerm = '{searchTerm.Replace("'", "''")}'"
            End If

            tbl = da.GetLoadData(dbName, query)

            If tbl.Rows.Count > 0 Then
                bsChangeLocationLoad.DataSource = tbl
            Else
                bsChangeLocationLoad.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub frmLoadChangeLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            loadMain()

            DataGridViewX1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridViewX1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
            DataGridViewX1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black


            ' Configure the search timer
            searchTimer.Interval = 200 ' 400ms delay after user stops typing
            AddHandler searchTimer.Tick, AddressOf SearchTimer_Tick

        Catch ex As Exception
            MessageBox.Show("Error loading form: " & vbCrLf & ex.ToString(), "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' When the user types in the search box, reset and start the timer.
    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearchChange.TextChanged
        searchTimer.Stop()
        searchTimer.Start()
    End Sub

    ' When the timer ticks (i.e., the user has paused typing), perform the search.
    Private Sub SearchTimer_Tick(sender As Object, e As EventArgs)
        searchTimer.Stop()
        loadMain(txtSearchChange.Text)
    End Sub

    Private Sub DataGridViewX1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If bsChangeLocationLoad.Current IsNot Nothing Then
                selectedArea = CType(bsChangeLocationLoad.Current, DataRowView)("Change_Location_Id").ToString()
                Me.Close()
            End If
        End If
    End Sub

End Class
