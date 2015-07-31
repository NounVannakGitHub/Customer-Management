Public Class frmRegisterMember

    Private Sub frmRegisterMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectDatabase("tbMember;", grdMember)
        ShowDataInComboBox("tbMember", "Mem_id", cboMemId)
        RefreshDataGridView("tbMember", "Mem_id", grdMember)
        setGridText("ល.រ|គោត្តនាម|នាម|ភេទ|លេខទូរស័ព្ទ|អាស័យដ្ឋាន|ថ្ងៃចូលជាសមាជិក", grdMember)
        setGridWidth("80|150|150|80|120|200|130", grdMember)
        SetAutoId()
    End Sub
    Sub SetAutoId()
        Dim Id As Long
        Id = Val(getSQLVAL("Select Max(Mem_id) from tbMember")) + 1
        txtMemId.Text = Format(Id)
        txtMemId.Focus()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim ct As String
        ct = "(" & txtMemId.Text & ",N'" & txtLName.Text & "',N'" & txtFName.Text & "',N'" & cboGender.Text & "',N'" & txtMemTel.Text & "',N'" & txtMemAddr.Text & "','" & dtpMem.Value.Date & "')"
        InsertDatabase("tbMember", "Mem_id, Mem_lname, Mem_fname, Mem_gender, Mem_tel, Mem_addr, Mem_date_register", ct)
        RefreshDataGridView("tbMember", "Mem_id", grdMember)
        ShowDataInComboBox("tbMember", "Mem_id", cboMemId)
        ClearForm(GroupBox1)
        SetAutoId()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim tf As String = "Mem_lname= N'" & txtLName.Text & "',Mem_fname= N'" & txtFName.Text & "',Mem_gender= N'" & cboGender.Text & "',Mem_tel= N'" & txtMemTel.Text & "',Mem_addr= N'" & txtMemAddr.Text & "',Mem_date_register= '" & dtpMem.Value.Date & "'"
        UpdateDatabase("tbMember", "Mem_id", tf, txtMemId.Text)
        RefreshDataGridView("tbMember", "Mem_id", grdMember)
        ShowDataInComboBox("tbMember", "Mem_id", cboMemId)
        ClearForm(GroupBox1)
        SetAutoId()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeleteDatabase("tbMember", "Mem_id", txtMemId.Text)
        RefreshDataGridView("tbMember", "Mem_id", grdMember)
        ShowDataInComboBox("tbMember", "Mem_id", cboMemId)
        ClearForm(GroupBox1)
        SetAutoId()
    End Sub

    Private Sub grdMember_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdMember.CellClick
        Dim ctr() As Control = {txtMemId, txtLName, txtFName, cboGender, txtMemTel, txtMemAddr, dtpMem}
        Dim j As Integer = 6
        ShowItemInControl(ctr, grdMember, j)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RefreshDataGridView("tbMember", "Mem_id", grdMember)
        ShowDataInComboBox("tbMember", "Mem_id", cboMemId)
        ClearForm(GroupBox1)
        SetAutoId()
    End Sub

    Private Sub frmRegisterMember_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Show()
    End Sub

    Private Sub cboMemId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMemId.SelectedIndexChanged
        SearchData("tbMember", "Mem_id", cboMemId.Text, grdMember)
    End Sub
End Class
