Public Class frmLoadPermitNumber

    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")
    Private Const dbName As String = "ITEMonitordb"
    Public selectedPermitId As String
    Public selectedPermitNumber As String
    Public selectedPermitDate As String


    ' Timer for delayed search to avoid excessive database calls
    Private WithEvents searchTimer As New Timer()

#Region "Calling Function"
    Private Sub loadMain()
        Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "SELECT * FROM [POSPermitNumber]")
        If tbl.Rows.Count > 0 Then
            bsPermitLoad.DataSource = tbl
        Else
            bsPermitLoad.DataSource = Nothing
        End If

    End Sub
#End Region

    Private Sub frmLoadPermitNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            loadMain()

            DataGridViewX1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridViewX1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
            DataGridViewX1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black


        Catch ex As Exception
            MessageBox.Show("Error loading form: " & vbCrLf & ex.ToString(), "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewX1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewX1.KeyDown
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            e.SuppressKeyPress = True
            SelectAndClose()
        End If
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim filter As String = ""
        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
            filter = String.Format("Permit_Number LIKE '%{0}%'", txtSearch.Text.Replace("'", "''"))
        End If
        bsPermitLoad.Filter = filter
    End Sub


    Private Sub SelectAndClose()
        If bsPermitLoad.Current IsNot Nothing Then
            Dim currentRow As DataRowView = CType(bsPermitLoad.Current, DataRowView)
            selectedPermitId = currentRow("Permit_Id").ToString()
            selectedPermitNumber = currentRow("Permit_Number").ToString()
            selectedPermitDate = currentRow("Permit_Date")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub tsSelect_Click(sender As Object, e As EventArgs) Handles tsSelect.Click
        SelectAndClose()
    End Sub

    Private Sub enterBtnCounter_Click(sender As Object, e As EventArgs) Handles enterBtnCounter.Click
        SelectAndClose()
    End Sub

    Private Sub DataGridViewX1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewX1.DoubleClick
        SelectAndClose()
    End Sub

    Private Sub tsClose_Click(sender As Object, e As EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub


End Class


