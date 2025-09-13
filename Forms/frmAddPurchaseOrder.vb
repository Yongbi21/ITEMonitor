Imports System.Data
Imports System.Data.SqlClient

Public Class frmAddPurchaseOrder
    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")
    Private Const dbName As String = "ITEMonitordb"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Basic validation
            If String.IsNullOrWhiteSpace(txtPurchaseOrderNumber.Text) Then
                MessageBox.Show("Purchase Order Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim purchaseOrderDate As DateTime
            If Not DateTime.TryParse(txtPurchaseOrderDate.Text, purchaseOrderDate) Then
                MessageBox.Show("A valid Purchase Order Date is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim sqlParams As New List(Of SqlParameter)
            sqlParams.Add(New SqlParameter("@PurchaseOrderNumber", txtPurchaseOrderNumber.Text))
            sqlParams.Add(New SqlParameter("@InvoiceNumber", txtInvoiceNumber.Text))
            sqlParams.Add(New SqlParameter("@PurchaseOrderDate", purchaseOrderDate))

            Dim invoiceDate As DateTime
            If DateTime.TryParse(txtInvoiceDate.Text, invoiceDate) Then
                sqlParams.Add(New SqlParameter("@InvoiceDate", invoiceDate))
            Else
                sqlParams.Add(New SqlParameter("@InvoiceDate", DBNull.Value))
            End If

            sqlParams.Add(New SqlParameter("@SupplierNumber", txtSupplierNumber.Text))
            sqlParams.Add(New SqlParameter("@MemberName", tstSupplierName.Text))

            ' NOTE: This assumes a stored procedure named 'CreatePurchaseOrder' exists
            ' that takes the parameters above to create a new purchase order.
            If da.ExcuteSQLQuery(dbName, "AddPurchaseOrder", sqlParams) Then
                MessageBox.Show("Purchase order added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Failed to add purchase order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving purchase order:" & vbCrLf & ex.ToString(), "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs) Handles btnSearchSupplier.Click
        Using searchForm As New frmSearchSupplier()
            If searchForm.ShowDialog(Me) = DialogResult.OK Then
                txtSupplierNumber.Text = searchForm.SelectedSupplierNumber
                tstSupplierName.Text = searchForm.SelectedSupplierName
            End If
        End Using
    End Sub


End Class