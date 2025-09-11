Imports CrystalDecisions.CrystalReports.Engine

Module userFunctions
    Public m_report As ReportDocument


    Public Sub viewRPT(Optional print_type As Boolean = False)
        If print_type Then
            Dim prd As New System.Drawing.Printing.PrintDocument

            m_report.PrintOptions.PrinterName = prd.PrinterSettings.PrinterName
            m_report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
            m_report.PrintToPrinter(1, False, 0, 0)

        Else

            frmReports.reportFormView.ShowPrintButton = True
            frmReports.reportFormView.Refresh()
            frmReports.reportFormView.ReportSource = m_report
            frmReports.reportFormView.Zoom(75)
            frmReports.reportFormView.Refresh()
            frmReports.reportFormView.ShowExportButton = True
            frmReports.TopMost = True
            frmReports.Show()
        End If
    End Sub

End Module
