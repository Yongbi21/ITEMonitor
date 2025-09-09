Module Module1
    Public dbName As String = "ITEMonitordb"
    Public Sub frmshow(ByRef form As System.Windows.Forms.Form, ByRef frmMother As System.Windows.Forms.Form)
        form.MdiParent = frmMother
        form.Show()
        Dim nloc As New Point(0, 0)
        form.Location = nloc
    End Sub

End Module
