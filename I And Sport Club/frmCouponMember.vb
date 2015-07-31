Public Class frmCouponMember

    Private Sub TabPage2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Enter
        ConnectDatabase("tbFootballCoupon", grdFootball)
        ShowDataInComboBox("tbFootballCoupon", "FID", txtBallId)
        setGridText("|ថ្ងៃចូល|ទំហំតារាង|ម៉ោងចូល|ម៉ោងចេញ|ម៉ោងសរុប|តំលៃក្នុង១ម៉ោង|សរុបតំលៃ", grdFootball)
        setGridWidth("|180|120|120|120|120|120|120", grdFootball)
    End Sub

    Private Sub TabPage1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Enter
        ConnectDatabase("tbGymCoupon", grdGym)
        ShowDataInComboBox("tbGymCoupon", "GID", txtId)
        setGridText("|ថ្ងៃចូល|ម៉ោងចូល|ម៉ោងចេញ|ម៉ោងសរុប|តំលៃក្នុង១ម៉ោង|សរុបតំលៃ", grdGym)
        setGridWidth("|180|150|150|120|120|120", grdGym)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RefreshDataGridView("tbGymCoupon", "GID", grdGym)
        ShowDataInComboBox("tbGymCoupon", "GID", txtId)
        ClearForm(GroupBox1)
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim id As Long = SetAutoId1()
        Dim dbf As String = "GID,Gym_date_in, Gym_time_in, Gym_time_out, Gym_count_time, Gym_price_per_hour, Gym_total"
        Dim cnvalue As String = "('" & id & "','" & dtpDateCheckIn.Value.Date & "','" & dtpTimeCheckIn.Text & "','" & dtpTimeCheckOut.Text & "','" & txtTotalTime.Text & "','" & CDbl(txtTimePrice.Text) & "','" & CDbl(txtAmount.Text) & "')"
        InsertDatabase("tbGymCoupon", dbf, cnvalue)
        RefreshDataGridView("tbGymCoupon", "GID", grdGym)
        ShowDataInComboBox("tbGymCoupon", "GID", txtId)
        ClearForm(GroupBox1)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim tf As String = "Gym_date_in='" & CDate(dtpDateCheckIn.Value.Date) & "', Gym_time_in= '" & dtpTimeCheckIn.Text & "', Gym_time_out='" & dtpTimeCheckOut.Text & "', Gym_count_time='" & txtTotalTime.Text & "', Gym_price_per_hour='" & CDbl(txtTimePrice.Text) & "', Gym_total='" & CDbl(txtAmount.Text) & "'"
        UpdateDatabase("tbGymCoupon", "GID", tf, txtId.Text)
        RefreshDataGridView("tbGymCoupon", "GID", grdGym)
        ShowDataInComboBox("tbGymCoupon", "GID", txtId)
        ClearForm(GroupBox1)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeleteDatabase("tbGymCoupon", "GID", txtId.Text)
        RefreshDataGridView("tbGymCoupon", "GID", grdGym)
        ShowDataInComboBox("tbGymCoupon", "GID", txtId)
        ClearForm(GroupBox1)
    End Sub

    Private Sub grdGym_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGym.CellClick
        Dim cn() As Control = {txtId, dtpDateCheckIn, dtpTimeCheckIn, dtpTimeCheckOut, txtTotalTime, txtTimePrice, txtAmount}
        ShowItemInControl(cn, grdGym, 7)
    End Sub

    Private Sub cboFieldType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFieldType.SelectedIndexChanged
        SelectFieldSize(cboFieldType, txtBallTimePrice)
    End Sub

    Private Sub btnBallNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBallNew.Click
        RefreshDataGridView("tbFootballCoupon", "FID", grdFootball)
        ShowDataInComboBox("tbFootballCoupon", "FID", txtBallId)
        ClearForm(GroupBox4)
    End Sub

    Private Sub btnBallInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBallInsert.Click
        Dim id As Long = SetAutoId()
        Dim dbf As String = "FID,Bal_date_in, Bal_fieldtype, Bal_time_in, Bal_time_out, Bal_time_total, Bal_price_per_hour, Bal_total"
        Dim cnvalue As String = "('" & id & "','" & dtpBallDateIn.Value.Date & "',N'" & cboFieldType.Text & "','" & dtpBallTimeCheckIn.Text & "','" & dtpBallTimeCheckOut.Text & "','" & txtBallTotalTime.Text & "','" & CDbl(txtBallTimePrice.Text) & "','" & CDbl(txtBallAmount.Text) & "')"
        InsertDatabase("tbFootballCoupon", dbf, cnvalue)
        RefreshDataGridView("tbFootballCoupon", "FID", grdFootball)
        ShowDataInComboBox("tbFootballCoupon", "FID", txtBallId)
        ClearForm(GroupBox4)
    End Sub

    Private Sub btnBallUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBallUpdate.Click
        Dim tf As String = "Bal_date_in = '" & CDate(dtpBallDateIn.Value.Date) & "', Bal_fieldtype = N'" & cboFieldType.Text & "', Bal_time_in = '" & dtpBallTimeCheckIn.Text & "', Bal_time_out = '" & dtpBallTimeCheckOut.Text & "', Bal_time_total = '" & txtBallTotalTime.Text & "', Bal_price_per_hour = '" & CDbl(txtBallTimePrice.Text) & "', Bal_total = '" & CDbl(txtBallAmount.Text) & "'"
        UpdateDatabase("tbFootballCoupon", "FID", tf, txtBallId.Text)
        RefreshDataGridView("tbFootballCoupon", "FID", grdFootball)
        ShowDataInComboBox("tbFootballCoupon", "FID", txtBallId)
        ClearForm(GroupBox4)
    End Sub

    Private Sub btnBallDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBallDelete.Click
        DeleteDatabase("tbFootballCoupon", "FID", txtBallId.Text)
        RefreshDataGridView("tbFootballCoupon", "FID", grdFootball)
        ShowDataInComboBox("tbFootballCoupon", "FID", txtBallId)
        ClearForm(GroupBox4)
    End Sub

    Private Sub grdFootball_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFootball.CellClick
        Dim cn() As Control = {txtBallId, dtpBallDateIn, cboFieldType, dtpBallTimeCheckIn, dtpBallTimeCheckOut, txtBallTotalTime, txtBallTimePrice, txtBallAmount}
        ShowItemInControl(cn, grdFootball, 8)
    End Sub

    Private Sub frmCouponMember_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Show()
    End Sub

    Private Sub dtpBallTimeCheckOut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpBallTimeCheckOut.ValueChanged
        GetCalculateTime(txtBallTotalTime, dtpBallTimeCheckIn, dtpBallTimeCheckOut)
        GetTotalAmount(txtBallAmount, txtBallTotalTime.Text, txtBallTimePrice.Text)
    End Sub

    Private Sub dtpTimeCheckOut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTimeCheckOut.ValueChanged
        txtTimePrice.Text = "0.25"
        GetCalculateTime(txtTotalTime, dtpTimeCheckIn, dtpTimeCheckOut)
        GetTotalAmount(txtAmount, txtTotalTime.Text, txtTimePrice.Text)
    End Sub

    Private Sub txtId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.SelectedIndexChanged
        SearchData("tbGymCoupon", "GID", txtId.Text, grdGym)
    End Sub

    Private Sub txtBallId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBallId.SelectedIndexChanged
        SearchData("tbFootballCoupon", "FID", txtBallId.Text, grdFootball)
    End Sub
    Function SetAutoId()
        Dim Id As Long
        Id = Val(getSQLVAL("Select Max(FID) from tbFootballCoupon")) + 1
        Return Id
    End Function
    Function SetAutoId1()
        Dim Id As Long
        Id = Val(getSQLVAL("Select Max(GID) from tbGymCoupon")) + 1
        Return Id
    End Function
End Class