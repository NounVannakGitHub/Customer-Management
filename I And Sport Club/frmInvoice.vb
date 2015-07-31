Public Class frmInvoice
    Private Sub btnGymShowInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGymShowInv.Click
        Dim path As String = System.IO.File.ReadAllText(Application.StartupPath & "\rptGymInv.txt")
        ShowReport(crptGymInv, dtpGymInv, path, "Date")
    End Sub

    Private Sub btnBallShowInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBallShowInv.Click
        Dim path As String = System.IO.File.ReadAllText(Application.StartupPath & "\rptBallInv.txt")
        ShowReport(crptBallInv, dtpBallInv, path, "BallAmount")
    End Sub

    Private Sub btnMemShowInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemShowInv.Click
        Dim path As String = System.IO.File.ReadAllText(Application.StartupPath & "\rptMemInv.txt")
        Dim control() As String = {txtMemIdInv.Text, dptDateStart.Value.Date, dtpDateEnd.Value.Date}
        Dim pf() As String = {"MemId", "DateIn", "DateOut"}
        ShowCrystalReport(crptMemInv, path, control, pf)
        'ShowReport(crptMemInv, dtpDateEnd, path, "DateOut")
    End Sub

    Private Sub frmInvoice_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Show()
    End Sub
End Class