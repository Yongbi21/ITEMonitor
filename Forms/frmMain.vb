Public Class frmMain


    Private Sub OpenForm(newForm As Form)
        ' Close all other open forms except this one
        For Each f As Form In Application.OpenForms.Cast(Of Form).ToList()
            If f IsNot Me Then
                f.Close()
            End If
        Next
        newForm.Show()
    End Sub

    Private Sub ReferenceData_Click(sender As Object, e As EventArgs) Handles ReferenceData.Click

    End Sub

    Private Sub EquipmentButton(sender As Object, e As EventArgs) Handles Equipment.Click
        OpenForm(New frmEquipment())
    End Sub

    Private Sub PurchaseOrderButton(sender As Object, e As EventArgs) Handles PurchaseOrder.Click
        OpenForm(New frmPurchaseOrder())
    End Sub

    Private Sub PermitsButton(sender As Object, e As EventArgs) Handles POSPermit.Click
        OpenForm(New Permits())
    End Sub

    Private Sub EquipmentTypesButton(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        OpenForm(New frmEquipmentType())
    End Sub

    Private Sub EquipmentAreasButton(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        OpenForm(New frmEquipmentAreas())

    End Sub

    Private Sub EquipmentLocationsButton(sender As Object, e As EventArgs) Handles EquipmentLocation.Click
        OpenForm(New frmEquipmentLocations())

    End Sub

    Private Sub POSCounterButton(sender As Object, e As EventArgs) Handles POSCounter.Click
        OpenForm(New frmPOSCounters())

    End Sub

    Private Sub ChangeCounter_Button(sender As Object, e As EventArgs) Handles ChangeCounter.Click
        OpenForm(New frmChangeCounter())

    End Sub

    Private Sub ChangeLocation_Button(sender As Object, e As EventArgs) Handles ChangeLocation.Click
        OpenForm(New frmChangeLocation())

    End Sub





End Class