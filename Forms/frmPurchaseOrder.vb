Public Class frmPurchaseOrder

    Private isNew As Boolean = False
    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")
    Private Const dbName As String = "ITEMonitordb"

#Region "Calling Function"
    Private Sub loadMain()
        Dim tbl As New DataTable

        tbl = da.GetLoadData(dbName, "SELECT * FROM [PurchaseOrder] ORDER BY Purchase_Order_Number")
        If tbl.Rows.Count > 0 Then
            bsPurchaseOrder.DataSource = tbl
        Else
            bsPurchaseOrder.DataSource = Nothing
        End If
    End Sub
#End Region

    Private Sub frmPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            loadMain()

            DataGridViewX1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridViewX1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
            DataGridViewX1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black

            ' Bind DataGridView columns to DB fields

            ' Initial control states
            tsEdit.Enabled = True
            tsSave.Enabled = False

            ' Tooltips
            tsNew.ToolTipText = "Add a new purchase order"
            tsEdit.ToolTipText = "Edit the selected purchase order"
            tsSave.ToolTipText = "Save changes"
            tsClose.ToolTipText = "Close this form"

        Catch ex As Exception
            MessageBox.Show("Error loading Purchase Order form:" & vbCrLf & ex.ToString(), "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewX1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewX1.SelectionChanged
        If DataGridViewX1.SelectedRows.Count > 0 Then
            tsEdit.Enabled = True
            tsSave.Enabled = False
        Else
            tsEdit.Enabled = False
            tsSave.Enabled = False
        End If
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        Dim filter As String = ""
        If Not String.IsNullOrWhiteSpace(SearchBox.Text) Then
            filter = String.Format("Purchase_Order_Number LIKE '%{0}%'", SearchBox.Text.Replace("'", "''"))
        End If
        bsPurchaseOrder.Filter = filter
    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        Using addForm As New frmAddPurchaseOrder()
            If addForm.ShowDialog() = DialogResult.OK Then
                loadMain()
            End If
        End Using
    End Sub

    Private Sub EditSelectedPurchaseOrder()
        If DataGridViewX1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewX1.SelectedRows(0)
            Dim purchaseOrderId As String = String.Empty
            Dim idColumnName As String = "PurchaseOrder_Id" ' The name we are looking for

            ' Step 1: Check if the column exists
            If Not DataGridViewX1.Columns.Contains(idColumnName) Then
                ' Check for the other possible name, just in case
                If DataGridViewX1.Columns.Contains("PurchaseOrderId") Then
                    idColumnName = "PurchaseOrderId"
                Else
                    Dim columnNames As New System.Text.StringBuilder()
                    For Each col As DataGridViewColumn In DataGridViewX1.Columns
                        columnNames.AppendLine(col.Name)
                    Next
                    MessageBox.Show("Fatal Error: The grid is missing the required ID column ('Purchase_Order_Id' or 'PurchaseOrderID')." & vbCrLf & vbCrLf & "Available columns:" & vbCrLf & columnNames.ToString(), "Column Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If

            ' Step 2: Get the value from the cell
            Dim cellValue As Object = selectedRow.Cells(idColumnName).Value

            ' Step 3: Check if the value is null
            If IsDBNull(cellValue) Then
                MessageBox.Show("The selected row has no value in the '" & idColumnName & "' column.", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            purchaseOrderId = Convert.ToString(cellValue)

            ' Step 4: Check if the string is empty
            If String.IsNullOrEmpty(purchaseOrderId) Then
                MessageBox.Show("The Purchase Order ID for the selected row is an empty string.", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' If all checks pass, open the edit form
            Using editForm As New frmEditPurchaseOrder(purchaseOrderId)
                If editForm.ShowDialog() = DialogResult.OK Then
                    loadMain()
                End If
            End Using
        Else
            MessageBox.Show("Please select a purchase order to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        EditSelectedPurchaseOrder()
    End Sub


    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If DataGridViewX1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewX1.SelectedRows(0)
            Dim purchaseOrderId As String = Convert.ToString(selectedRow.Cells("PurchaseOrder_Id").Value)
            Dim newPurchaseOrderNumber As String = Convert.ToString(selectedRow.Cells("Purchase_Order_Number").Value)

            If String.IsNullOrWhiteSpace(newPurchaseOrderNumber) Then
                MessageBox.Show("Purchase order number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                Dim sqlParams As New List(Of SqlClient.SqlParameter)
                sqlParams.Add(New SqlClient.SqlParameter("@PurchaseOrderId", purchaseOrderId))
                sqlParams.Add(New SqlClient.SqlParameter("@PurchaseOrderNumber", newPurchaseOrderNumber))
                sqlParams.Add(New SqlClient.SqlParameter("@InvoiceNumber", Convert.ToString(selectedRow.Cells("Invoice_Number").Value)))
                sqlParams.Add(New SqlClient.SqlParameter("@InvoiceDate", Convert.ToDateTime(selectedRow.Cells("Invoice_Date").Value)))
                sqlParams.Add(New SqlClient.SqlParameter("@SupplierNumber", Convert.ToString(selectedRow.Cells("Supplier_Number").Value)))
                sqlParams.Add(New SqlClient.SqlParameter("@MemberName", Convert.ToString(selectedRow.Cells("Member_Name").Value)))

                If da.ExcuteSQLQuery(dbName, "UpdatePurchaseOrder", sqlParams) Then
                    MessageBox.Show("Purchase order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to update purchase order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error updating purchase order:" & vbCrLf & ex.ToString(), "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                DataGridViewX1.ReadOnly = True
                DataGridViewX1.Columns("Purchase_Order_Number").ReadOnly = True
                tsSave.Enabled = False
                tsEdit.Enabled = True
                loadMain()
            End Try

        End If
    End Sub


    Private Sub tsClose_Click(sender As Object, e As EventArgs) Handles tsClose.Click
        Me.Close()
    End Sub

End Class
