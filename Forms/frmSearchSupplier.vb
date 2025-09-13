Public Class frmSearchSupplier

    Private da As New clDataAceesV2("192.168.17.1", "SGCuser", "Syst3ms")
    Private Const dbSupplier As String = "SGCPROFILE"
    Public SelectedSupplierNumber As String
    Public SelectedSupplierName As String

#Region "Calling Function"
    Private Sub loadMain(Optional filter As String = "")

        Dim tbl As New DataTable
        Dim sql As String = "SELECT RTrim(LTrim(Str(SUPPLY_NO))) As SUPPLY_NO, SUPPLY_NAME FROM [EXPSUPPL]"

        tbl = da.GetLoadData(dbSupplier, sql)
        If tbl.Rows.Count > 0 Then
            bsSupplier.DataSource = tbl
        Else
            bsSupplier.DataSource = Nothing
        End If
    End Sub
#End Region


    Private Sub frmSearchSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            loadMain()

            DataGridViewX1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridViewX1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
            DataGridViewX1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black


            tsClose.ToolTipText = "Close this form"
            tsSelect.ToolTipText = "Selects the current supplier and closes this form"


        Catch ex As Exception
            MessageBox.Show("Error loading Supplier form:" & vbCrLf & ex.ToString(), "Form Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SelectSupplier()
        If bsSupplier.Current IsNot Nothing Then
            Dim selectedRow As DataRowView = CType(bsSupplier.Current, DataRowView)
            SelectedSupplierNumber = selectedRow("SUPPLY_NO").ToString()
            SelectedSupplierName = selectedRow("SUPPLY_NAME").ToString()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Please select a supplier.", "No Supplier Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tsSelect_Click(sender As Object, e As EventArgs) Handles tsSelect.Click
        SelectSupplier()
    End Sub


    Private Sub tsClose_Click(sender As Object, e As EventArgs) Handles tsClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        bsSupplier.Filter = "SUPPLY_NO LIKE '%" & txtSearch.Text & "%' OR SUPPLY_NAME LIKE '%" & txtSearch.Text & "%'"

    End Sub

    Private Sub DataGridViewX1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridViewX1.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            SelectSupplier()
        End If

    End Sub
End Class