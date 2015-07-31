Public Class frmMemberAction
    Private Sub frmMemberAction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectDatabase("tbMemberHistory", grdMemberAction)
        ShowDataInComboBox("tbMemberHistory", "MHID", txtID)
        setGridText("|ល.រ|ថ្ងៃចូលហាត់|ម៉ោងចូល|ម៉ោងចេញ|ម៉ោងសរុប|តំលៃក្នុង១ម៉ោង|សរុបប្រចាំថ្ងៃ", grdMemberAction)
        setGridWidth("|100|150|120|120|120|120|120", grdMemberAction)
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim id As Long = Me.SetAutoId
        Dim dbf As String = "MHID,Mem_id, Mem_date_in, Mem_time_in, Mem_time_out, Mem_count_time_perday, Mem_price_per_hour, Mem_total_per_day"
        Dim cnvalue As String = "('" & id & "','" & txtMemId.Text & "','" & dtpMemDateCheckIn.Value.Date & "','" & dtpMemTimeCheckIn.Text & "','" & dtpMemTimeCheckOut.Text & "','" & txtTotalTime.Text & "','" & CDbl(txtPriceTime.Text) & "','" & CDbl(txtTotalPerDay.Text) & "')"
        InsertDatabase("tbMemberHistory", dbf, cnvalue)
        RefreshDataGridView("tbMemberHistory", "MHID", grdMemberAction)
        ShowDataInComboBox("tbMemberHistory", "MHID", txtID)
        ClearForm(GroupBox1)
        ClearForm(GroupBox2)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RefreshDataGridView("tbMemberHistory", "MHID", grdMemberAction)
        ShowDataInComboBox("tbMemberHistory", "MHID", txtID)
        ClearForm(GroupBox1)
        ClearForm(GroupBox2)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim tf As String = "Mem_id= '" & txtMemId.Text & "', Mem_date_in= '" & dtpMemDateCheckIn.Value.Date & "', Mem_time_in= '" & dtpMemTimeCheckIn.Text & "', Mem_time_out= '" & dtpMemTimeCheckOut.Text & "', Mem_count_time_perday= '" & txtTotalTime.Text & "', Mem_price_per_hour= '" & CDbl(txtPriceTime.Text) & "', Mem_total_per_day= '" & CDbl(txtTotalPerDay.Text) & "'"
        UpdateDatabase("tbMemberHistory", "MHID", tf, txtID.Text)
        RefreshDataGridView("tbMemberHistory", "MHID", grdMemberAction)
        ShowDataInComboBox("tbMemberHistory", "MHID", txtID)
        ClearForm(GroupBox1)
        ClearForm(GroupBox2)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeleteDatabase("tbMemberHistory", "MHID", txtID.Text)
        RefreshDataGridView("tbMemberHistory", "MHID", grdMemberAction)
        ShowDataInComboBox("tbMemberHistory", "MHID", txtID)
        ClearForm(GroupBox1)
        ClearForm(GroupBox2)
    End Sub

    Private Sub grdMemberAction_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdMemberAction.CellClick
        Dim cn() As Control = {txtID, txtMemId, dtpMemDateCheckIn, dtpMemTimeCheckIn, dtpMemTimeCheckOut, txtTotalTime, txtPriceTime, txtTotalPerDay}
        ShowItemInControl(cn, grdMemberAction, 8)
    End Sub

    Private Sub frmMemberAction_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Show()
    End Sub

    Private Sub dtpMemTimeCheckOut_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpMemTimeCheckOut.ValueChanged
        txtPriceTime.Text = "0.25"
        GetCalculateTime(txtTotalTime, dtpMemTimeCheckIn, dtpMemTimeCheckOut)
        GetTotalAmount(txtTotalPerDay, txtTotalTime.Text, txtPriceTime.Text)
    End Sub

    Private Sub txtID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.SelectedIndexChanged
        SearchData("tbMemberHistory", "MHID", txtID.Text, grdMemberAction)
    End Sub
    Function SetAutoId()
        Dim Id As Long
        Id = Val(getSQLVAL("Select Max(MHID) from tbMemberHistory")) + 1
        Return Id
    End Function
End Class