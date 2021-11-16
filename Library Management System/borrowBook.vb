Imports System.Data.OleDb
Public Class borrowBook
    Dim con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Resources\LibraryVbDb.mdb")
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
    Private Sub FillStudent()
        con.open()
        Dim query = "select * from StudentTbl"
        Dim cmd As New OleDbCommand(query, con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        StIdCb.DataSource = Tbl
        StIdCb.DisplayMember = "StId"
        StIdCb.ValueMember = "StId"
        con.close()
    End Sub
    Private Sub FillBook()
        con.open()
        Dim query = "select * from BookTbl"
        Dim cmd As New OleDbCommand(query, con)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        BkIdCb.DataSource = Tbl
        BkIdCb.DisplayMember = "BkId"
        BkIdCb.ValueMember = "BkId"
        con.close()
    End Sub
    Private Sub GetStudent()
        con.open()
        Dim query = "select * from StudentTbl where StId=" & StIdCb.SelectedValue.ToString() & ""
        Dim cmd As New OleDbCommand(query, con)
        Dim dt As New DataTable
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            StNameTb.Text = "" + reader(1).ToString()
        End While
        con.close()
    End Sub
    Private Sub GetBookName()
        con.open()
        Dim query = "select * from BookTbl where BkId=" & BkIdCb.SelectedValue.ToString() & ""
        Dim cmd As New OleDbCommand(query, con)
        Dim dt As New DataTable
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            BkNameTb.Text = "" + reader(1).ToString()
        End While
        con.close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim obj As New mainMenu
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub exitt_Click(sender As Object, e As EventArgs) Handles exitt.Click
        Application.Exit()
    End Sub

    Private Sub borrowBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
        FillStudent()
        FillBook()
    End Sub

    Private Sub StIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles StIdCb.SelectionChangeCommitted
        GetStudent()
    End Sub

    Private Sub BkIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles BkIdCb.SelectionChangeCommitted
        GetBookName()
    End Sub
    Dim Num = 0
    Private Sub CountBook()
        con.open()
        Dim query = "select Count(*) from IssueTbl where StId=" & StIdCb.SelectedValue.ToString() & ""
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, con)
        Num = cmd.ExecuteScalar
        con.Close()
    End Sub
    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        CountBook()
        If StNameTb.Text = "" Or BkNameTb.Text = "" Or StIdCb.SelectedIndex = -1 Or BkIdCb.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        ElseIf Num = 5 Then
            MsgBox("No more than 5 Books Issued")
        Else
            Try
                con.Open()
                Dim query = "Insert Into IssueTbl(StId,StName,BookId,BookName,IssueDate) values(" & StIdCb.SelectedValue.ToString() & ",'" & StNameTb.Text & "'," & BkIdCb.SelectedValue.ToString() & ",'" & BkNameTb.Text & "','" & IDateCb.Value.Date & "')"
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Book Issued")
                con.Close()
                DisplayBook()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Reset()
        BkNameTb.Text = ""
        StNameTb.Text = ""
        StIdCb.SelectedIndex = -1
        BkIdCb.SelectedIndex = -1
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
    Dim key = 0
    Private Sub IssueDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles IssueDGV.CellMouseClick
        Dim row As DataGridViewRow = IssueDGV.Rows(e.RowIndex)
        StIdCb.SelectedValue = row.Cells(1).Value.ToString
        StNameTb.Text = row.Cells(2).Value.ToString
        BkIdCb.SelectedValue = row.Cells(3).Value.ToString
        BkNameTb.Text = row.Cells(4).Value.ToString
        IDateCb.Text = row.Cells(5).Value.ToString

        If StNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If StNameTb.Text = "" Or BkNameTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query = "Update IssueTbl set StId=" & StIdCb.SelectedValue.ToString() & ",StName='" & StNameTb.Text & "',BookId=" & BkIdCb.SelectedValue.ToString() & ",BookName='" & BkNameTb.Text & "',IssueDate='" & IDateCb.Value.Date & "' where INum=" & key & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Issue Edited")
            con.Close()
            DisplayBook()
            Reset()
        End If
    End Sub
End Class