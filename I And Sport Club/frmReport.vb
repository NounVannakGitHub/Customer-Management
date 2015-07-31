Public Class frmReport
    Private Sub btnShowMemberReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowMemberReport.Click
        Dim path As String = System.IO.File.ReadAllText(Application.StartupPath & "\rptMemberReport.txt")
        ShowNormalReport(crptMemberReport, path)
    End Sub

    Private Sub btnShowIncomeReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowIncomeReport.Click
        Dim path As String = System.IO.File.ReadAllText(Application.StartupPath & "\rptIncome.txt")
        Dim control() As String = {dtpIncomeDateFrom.Value.Date, dtpIncomeDateTo.Value.Date}
        Dim pf() As String = {"DateFrom", "DateTo"}
        ShowCrystalReport(crptIncomeReport, path, control, pf)
    End Sub

    Private Sub btnGymReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGymReport.Click
        Dim path As String = System.IO.File.ReadAllText(Application.StartupPath & "\rptGymIncome.txt")
        Dim control() As String = {dtpGymReportDateFrom.Value.Date, dtpGymReportDateTo.Value.Date}
        Dim pf() As String = {"DateFrom", "DateTo"}
        ShowCrystalReport(crptGymReport, path, control, pf)
    End Sub

    Private Sub btnBallReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBallReport.Click
        Dim path As String = System.IO.File.ReadAllText(Application.StartupPath & "\rptBallIncome.txt")
        Dim control() As String = {dtpBallReportFrom.Value.Date, dtpBallReportTo.Value.Date}
        Dim pf() As String = {"DateFrom", "DateTo"}
        ShowCrystalReport(crptBallReport, path, control, pf)
    End Sub

    Private Sub frmReport_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Show()
    End Sub
End Class