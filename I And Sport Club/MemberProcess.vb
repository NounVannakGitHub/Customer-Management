Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms
Imports CrystalActiveXReportViewerLib13
Imports AxCrystalActiveXReportViewerLib13
Module MemberProcess
    Dim con As OleDb.OleDbConnection
    Dim cmd As OleDb.OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Public Sub ConnectDatabase(ByVal table As String, ByVal Grd As DataGridView)
        Try
            Dim sql As String = "select * from " & table
            Dim ConnectionStr As String = System.IO.File.ReadAllText(Application.StartupPath & "\Connection.txt")
            con = New OleDb.OleDbConnection(ConnectionStr)
            con.Open()
            cmd = New OleDb.OleDbCommand(sql, con)
            da = New OleDb.OleDbDataAdapter(cmd)
            da.Fill(ds, table)
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            Dim T As New DataTable
            da.Fill(T)
            grd.DataSource = T

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub setGridText(ByVal HD As String, ByVal grd As DataGridView)
        Dim HT() As String
        HT = HD.Split("|")
        Dim i As Integer
        For i = 0 To UBound(HT)
            grd.Columns(i).HeaderText = HT(i)
        Next
    End Sub
    Sub setGridWidth(ByVal HD As String, ByVal grd As DataGridView)
        Dim HT() As String
        HT = HD.Split("|")
        Dim i As Integer
        For i = 0 To UBound(HT)
            grd.Columns(i).Width = Val(HT(i))
        Next
    End Sub
    Sub ClearForm(ByVal F As Object)
        Dim c As Control
        For Each c In F.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Function getSQLVAL(ByVal SQL As String) As String
        con.Open()
        cmd = New OleDb.OleDbCommand(SQL, con)
        Dim DR As OleDb.OleDbDataReader
        DR = cmd.ExecuteReader
        Dim rt As String = ""
        If DR.Read Then
            rt = DR(0).ToString
        End If
        DR.Close()
        cmd.Dispose()
        cmd = Nothing
        con.Close()
        Return rt
    End Function
    Sub InsertDatabase(ByVal table As String, ByVal dbf As String, ByVal ctvalue As String)
        Try
            con.Open()
            Dim sql As String
            Dim sql2 As String
            sql2 = "select * from " & table
            sql = "insert into " & table & " (" & dbf & ") values" & ctvalue
            cmd = New OleDb.OleDbCommand(sql2, con)
            cmd.Connection = con
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cmd.Clone()
            MessageBox.Show("ទិន្នន័យត្រូវបានបញ្ចូលរួចរាល់", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("ទិន្នន័យមិនត្រូវបានបញ្ចូល" & ex.Message, "បរាជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
          con.Close()
    End Sub
    Sub RefreshDataGridView(ByVal table As String, ByVal df As String, ByVal grd As DataGridView)
        Try
            con.Open()
            Dim sql As String
            sql = "select * from " & table & " order by " & df
            da = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            grd.DataSource = dt
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Sub SearchData(ByVal table As String, ByVal df As String, ByVal value As String, ByVal grd As DataGridView)
        Try
            con.Open()
            Dim sql = "select * from " & table & " where " & df & " = " & value
            da = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            grd.DataSource = dt
            con.Close()
        Catch ex As Exception
            con.Close()
        End Try
    End Sub
    Sub ShowDataInComboBox(ByVal table As String, ByVal id As String, ByVal cbo As ComboBox)
        Try
            con.Open()
            Dim sql As String = "select " & id & " from " & table
            cmd = New OleDb.OleDbCommand(sql, con)
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            cbo.Items.Clear()
            While dr.Read
                cbo.Items.Add(dr(0).ToString)
            End While
            dr.Close()
            cmd.Dispose()
            cmd = Nothing
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Sub UpdateDatabase(ByVal table As String, ByVal dbf As String, ByVal tf As String, ByVal f As String)
        Try
            con.Open()
            Dim sql As String = "update " & table & " set " & tf & " where " & dbf & " = " & f
            cmd = New OleDb.OleDbCommand
            cmd.Connection = con
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cmd.Clone()
            MessageBox.Show("ទិន្នន័យត្រូវបានកែប្រែរួចរាល់", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("ទិន្នន័យមិនត្រូវបានកែប្រែ" & ex.Message, "បរាជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub
    Sub DeleteDatabase(ByVal table As String, ByVal tf As String, ByVal f As String)
        Try
            con.Open()
            Dim sql2 As String = "select * from " & table
            Dim sql As String = "delete from " & table & " where " & tf & " = " & f
            cmd = New OleDb.OleDbCommand(sql2, con)
            cmd.Connection = con
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cmd.Clone()
            MessageBox.Show("ទិន្នន័យត្រូវបានលុបរួចរាល់", "ជោគជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("ទិន្នន័យមិនត្រូវបានលុប" & ex.Message, "បរាជ័យ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub
    Sub ShowItemInControl(ByVal cn() As Control, ByVal grd As DataGridView, ByVal j As Integer)
        Dim i As Integer
        Dim a As Integer
        i = grd.CurrentRow.Index
        Try
            For a = 0 To j
                cn(a).Text = grd.Item(a, i).Value
            Next
        Catch ex As Exception
        End Try
    End Sub
    Sub GetCalculateTime(ByVal txt As TextBox, ByVal TimeIn As DateTimePicker, ByVal TimeOut As DateTimePicker)
        Try
            Dim TIN As DateTime = TimeIn.Value
            Dim TOUT As DateTime = TimeOut.Value
            Dim diff As System.TimeSpan = TOUT.Subtract(TIN)
            Dim Hour As Double = CDbl(diff.Hours)
            Dim Min As Double = CDbl(diff.Minutes) / 100
            If Min = 0.59 Then
                Hour = Hour + 1
                Min = 0
                txt.Text = Hour + Min
            Else
                txt.Text = Hour + Min
            End If

        Catch ex As Exception

        End Try

    End Sub
    Sub GetTotalAmount(ByVal txt As TextBox, ByVal totaltime As String, ByVal price As String)
        Try
            Dim TT As Double = CDbl(totaltime)
            Dim PR As Double = CDbl(price)
            Dim Total As Double = TT * PR
            txt.Text = FormatCurrency(Total)
        Catch ex As Exception

        End Try      
    End Sub
    Sub SelectFieldSize(ByVal cbo As ComboBox, ByVal txt As TextBox)
        Try
            If cbo.SelectedIndex = 0 Then
                txt.Text = FormatCurrency(15)
            Else
                txt.Text = FormatCurrency(28)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub ShowReport(ByVal rpt As CrystalReportViewer, ByVal dpt As DateTimePicker, ByVal path As String, ByVal pf As String)
        Try
            Dim cryPrt As New ReportDocument
            cryPrt.Load(path)
            Dim crParamerFieldDefinitions As ParameterFieldDefinitions
            Dim crParamerFieldDefinition As ParameterFieldDefinition
            Dim crParamerValues As New ParameterValues
            Dim crParameterDiscreteValue As New ParameterDiscreteValue

            crParameterDiscreteValue.Value = dpt.Value.Date
            crParamerFieldDefinitions = cryPrt.DataDefinition.ParameterFields
            crParamerFieldDefinition = crParamerFieldDefinitions.Item(pf)
            crParamerValues = crParamerFieldDefinition.CurrentValues
            crParamerValues.Clear()
            crParamerValues.Add(crParameterDiscreteValue)
            crParamerFieldDefinition.ApplyCurrentValues(crParamerValues)
            cryPrt.SetDatabaseLogon("sa", "223238")
            rpt.ReportSource = cryPrt
            rpt.Refresh()
        Catch ex As Exception
            MsgBox("Error load report" & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Sub ShowNormalReport(ByVal crpt As CrystalReportViewer, ByVal path As String)
        Try
            Dim cryRpt As New ReportDocument
            cryRpt.Load(path)
            cryRpt.SetDatabaseLogon("sa", "223238")
            crpt.ReportSource = cryRpt
            crpt.Refresh()
        Catch ex As Exception

        End Try

    End Sub
    Sub ShowCrystalReport(ByVal crpt As CrystalReportViewer, ByVal path As String, ByVal control() As String, ByVal pf() As String)
        Try
            Dim report As New ReportDocument
            Dim i As Integer
            report.Load(path)
            For i = 0 To UBound(pf)
                report.SetParameterValue(pf(i), control(i))
            Next
            report.SetDatabaseLogon("sa", "223238")
            crpt.ReportSource = report
            crpt.Refresh()
        Catch ex As Exception

        End Try
    End Sub
    Function SetAutoId(ByVal dbf As String, ByVal table As String)
        Dim Id As Long
        Try
            Id = Val(getSQLVAL("Select Max('" & dbf & "') from '" & table & "'")) + 1
        Catch ex As Exception
        End Try
        Return Id
    End Function
End Module

