Imports System.Data.OleDb
Public Class returnBook
    Dim con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Theemain\Documents\LibraryVbDb.mdb")
    Private Sub DisplayBook()
        con.Open()
        Dim query = "select * from IssueTbl"
        Dim adapter As OleDbDataAdapter
        Dim cmd = New OleDbCommand(query, con)
        adapter = New OleDbDataAdapter(cmd)
        Dim builder = New OleDbCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        IssueDGV.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Private Sub DisplayReturnedBook()
        con.Open()
        Dim query = "select * from ReturnTbl"
        Dim adapter As OleDbDataAdapter
        Dim cmd = New OleDbCommand(query, con)
        adapter = New OleDbDataAdapter(cmd)
        Dim builder = New OleDbCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ReturnDGV.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Private Sub exitt_Click(sender As Object, e As EventArgs) Handles exitt.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim obj As New mainMenu
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub returnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
        DisplayReturnedBook()
    End Sub
    Dim key = 0
    Private Sub IssueDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles IssueDGV.CellMouseClick
        Dim row As DataGridViewRow = IssueDGV.Rows(e.RowIndex)
        StIdCb.Text = row.Cells(1).Value.ToString
        StNameTb.Text = row.Cells(2).Value.ToString
        BkIdCb.Text = row.Cells(3).Value.ToString
        BkNameTb.Text = row.Cells(4).Value.ToString
        IssueDate.Text = row.Cells(5).Value.ToString
        If StNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Dim fine As Integer
    Private Sub CalcBtn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click
        Dim Dif As TimeSpan
        Dif = ReturnedDate.Value.Date - IssueDate.Value.Date
        Dim Days = Dif.Days
        If Days <= 5 Then
            fine = 0
            FineTb.Text = "No Fine"
        Else
            fine = Days - 5
            FineTb.Text = "Kshs" + Convert.ToString(fine * 100)
        End If
    End Sub
    Private Sub RemoveFromIssue()
        Try
            con.Open()
            Dim query = "delete from IssueTbl where INum=" & key & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Issue Removed")
            con.Close()
            'DisplayBook()
            'Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If StNameTb.Text = "" Or BkNameTb.Text = "" Or FineTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.Open()
                Dim query = "Insert Into ReturnTbl(StId,StName,BookId,BookName,IssueDate,ReturnDate,Fine) values(" & StIdCb.Text & ",'" & StNameTb.Text & "'," & BkIdCb.Text & ",'" & BkNameTb.Text & "','" & IssueDate.Value.Date & "','" & ReturnedDate.Value.Date & "'," & fine & ")"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Book Returned")
                con.Close()
                RemoveFromIssue()
                DisplayReturnedBook()
                DisplayBook()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Reset()
        StIdCb.SelectedIndex = -1
        BkIdCb.SelectedIndex = -1
        StNameTb.Text = ""
        BkNameTb.Text = ""
        FineTb.Text = ""
        key = 0
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
End Class