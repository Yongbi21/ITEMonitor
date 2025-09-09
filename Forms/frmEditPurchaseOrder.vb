Imports System.Data
Imports System.Data.SqlClient

Public Class frmEditPurchaseOrder
    Private da As New clDataAceesV2("DEVJB\SQLEXPRESS", "SGCuser", "Syst3ms")
    Private Const dbName As String = "ITEMonitordb"
    Private _purchaseOrderId As String

    Public Sub New(purchaseOrderId As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _purchaseOrderId = purchaseOrderId
    End Sub

    Private Sub frmEditPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable date controls since they shouldn't be editable
        txtPurchaseOrderDate.Enabled = False
        txtInvoiceDate.Enabled = False

        ' Optional: Change the appearance of disabled controls
        txtPurchaseOrderDate.BackColor = SystemColors.Control
        txtInvoiceDate.BackColor = SystemColors.Control

        LoadPurchaseOrderData()
    End Sub

    Private Sub LoadPurchaseOrderData()
        Try
            Dim sqlParams As New List(Of SqlParameter)
            sqlParams.Add(New SqlParameter("@PurchaseOrderId", _purchaseOrderId))

            Dim dt As DataTable = da.GetDataTableFromSP(dbName, "GetPurchaseOrderById", sqlParams)

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtPurchaseOrderNumber.Text = row("PurchaseOrderNumber").ToString()
                txtInvoiceNumber.Text = row("InvoiceNumber").ToString()
                txtPurchaseOrderDate.Value = CDate(row("PurchaseOrderDate"))
                txtInvoiceDate.Value = CDate(row("InvoiceDate"))
                txtSupplierNumber.Text = row("SupplierNumber").ToString()
                txtMemberName.Text = row("MemberName").ToString()

                ' Set form title to show which PO we're editing
                Me.Text = $"Edit Purchase Order - {row("PurchaseOrderNumber")}"
            Else
                MessageBox.Show("Could not find purchase order data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading purchase order data:" & vbCrLf & ex.ToString(), "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            ' Basic validation
            If String.IsNullOrWhiteSpace(txtPurchaseOrderNumber.Text) Then
                MessageBox.Show("Purchase Order Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Create parameters for only the editable fields
            Dim sqlParams As New List(Of SqlParameter)
            sqlParams.Add(New SqlParameter("@PurchaseOrderId", _purchaseOrderId))
            sqlParams.Add(New SqlParameter("@PurchaseOrderNumber", txtPurchaseOrderNumber.Text.Trim()))
            sqlParams.Add(New SqlParameter("@InvoiceNumber", txtInvoiceNumber.Text.Trim()))
            sqlParams.Add(New SqlParameter("@SupplierNumber", txtSupplierNumber.Text.Trim()))
            sqlParams.Add(New SqlParameter("@MemberName", txtMemberName.Text.Trim()))

            Debug.WriteLine("Calling UpdatePurchaseOrder stored procedure...")

            ' Option 1: Try to get more information about what's happening
            Try
                Dim result As Boolean = da.ExcuteSQLQuery(dbName, "UpdatePurchaseOrder", sqlParams)
                Debug.WriteLine($"Stored procedure result: {result}")

                ' Check if the update actually worked by reloading the data
                Dim verifyParams As New List(Of SqlParameter)
                verifyParams.Add(New SqlParameter("@PurchaseOrderId", _purchaseOrderId))
                Dim verifyDt As DataTable = da.GetDataTableFromSP(dbName, "GetPurchaseOrderById", verifyParams)

                If verifyDt.Rows.Count > 0 Then
                    Dim row As DataRow = verifyDt.Rows(0)
                    Dim currentPONumber As String = row("PurchaseOrderNumber").ToString()

                    ' Check if our changes were actually saved
                    If currentPONumber.Equals(txtPurchaseOrderNumber.Text.Trim(), StringComparison.OrdinalIgnoreCase) Then
                        MessageBox.Show("Purchase order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                        Return
                    End If
                End If

                ' If we get here, something went wrong
                MessageBox.Show("Update may have failed. Please verify the changes were saved.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Catch innerEx As Exception
                Debug.WriteLine($"Inner Exception: {innerEx.ToString()}")
                MessageBox.Show("Error during update operation:" & vbCrLf & innerEx.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Catch ex As Exception
            MessageBox.Show("Error saving purchase order:" & vbCrLf & ex.ToString(), "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine($"Exception: {ex.ToString()}")
        End Try
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class