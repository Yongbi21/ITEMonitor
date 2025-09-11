<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.reportFormView = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'reportFormView
        '
        Me.reportFormView.ActiveViewIndex = -1
        Me.reportFormView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportFormView.Cursor = System.Windows.Forms.Cursors.Default
        Me.reportFormView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportFormView.Location = New System.Drawing.Point(0, 0)
        Me.reportFormView.Name = "reportFormView"
        Me.reportFormView.Size = New System.Drawing.Size(800, 450)
        Me.reportFormView.TabIndex = 0
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.reportFormView)
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents reportFormView As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
