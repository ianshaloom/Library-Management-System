Imports System.Data.OleDb
Public Class borrowBook
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim ds As New OleDbDataAdapter
    Dim con As New OleDbConnection
    Dim dt As New DataTable

    Dim conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DELL\Documents\LibraryVbDb.mdb")




    Private Sub FillStudent()
        conn.Open()
        Dim query = "select * from StudentTbl"
        Dim cmd As New OleDbCommand(query, conn)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        StIdCb.DataSource = Tbl
        StIdCb.DisplayMember = "StudentID"
        StIdCb.ValueMember = "StudentID"
        conn.Close()
    End Sub
    Private Sub GetBookName()
        conn.open()
        Dim query = "select * from BookTbl where BkId=" & BkIdCb.SelectedValue.ToString() & ""
        Dim cmd As New OleDbCommand(query, conn)
        Dim dt As New DataTable
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            BkNameTb.Text = "" + reader(1).ToString()
        End While
        conn.Close()
    End Sub
    Private Sub GetStudent()
        conn.Open()
        Dim query = "select * from StudentTbl where StudentID=" & StIdCb.SelectedValue.ToString() & ""
        Dim cmd As New OleDbCommand(query, conn)
        Dim dt As New DataTable
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            StNameTb.Text = "" + "" + reader(2).ToString()
        End While
        conn.Close()
    End Sub
    Private Sub FillBook()
        conn.Open()
        Dim query = "select * from BookTbl"
        Dim cmd As New OleDbCommand(query, conn)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        BkIdCb.DataSource = Tbl
        BkIdCb.DisplayMember = "BkId"
        BkIdCb.ValueMember = "BkId"
        conn.Close()
    End Sub
    Private Sub CountBook()
        conn.open()
        Dim query = "select Count(*) from IssueTbl where StId=" & StIdCb.SelectedValue.ToString() & ""
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, conn)
        Num = cmd.ExecuteScalar
        conn.Close()
    End Sub




    Private Sub DisplayBook()
        conn.Open()
        Dim query = "select * from IssueTbl"
        Dim adapter As OleDbDataAdapter
        Dim cmd = New OleDbCommand(query, conn)
        adapter = New OleDbDataAdapter(cmd)
        Dim builder = New OleDbCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        IssueDGV.DataSource = ds.Tables(0)
        conn.Close()
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub exitt_Click(sender As Object, e As EventArgs) Handles exitt.Click
        Dim obj As New mainMenu
        obj.Show()
        Me.Hide()
        obj.searchpanel.Visible = False
        obj.managepanel.Visible = False
        obj.librarypanel.Visible = True
    End Sub
    Private Sub borrowBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
        FillBook()
        FillStudent()
    End Sub

    Private Sub StIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles StIdCb.SelectionChangeCommitted
        GetStudent()
    End Sub

    Private Sub BkIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles BkIdCb.SelectionChangeCommitted
        GetBookName()
    End Sub
    Dim Num = 0
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
            conn.Open()
            Dim query = "Update IssueTbl set StId=" & StIdCb.SelectedValue.ToString() & ",StName='" & StNameTb.Text & "',BookId=" & BkIdCb.SelectedValue.ToString() & ",BookName='" & BkNameTb.Text & "',IssueDate='" & IDateCb.Value.Date & "' where INum=" & key & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Issue Edited")
            conn.Close()
            DisplayBook()
            Reset()
        End If
    End Sub

    Private Sub SubmitBtn_Click(sender As Object, e As EventArgs) Handles SubmitBtn.Click
        CountBook()
        If StNameTb.Text = "" Or BkNameTb.Text = "" Or BkIdCb.Text = "" Or StIdCb.Text = "" Then
            MsgBox("Missing Information")

        ElseIf Num = 5 Then
            MsgBox("More than 5 Books Borrowed")
            Reset()
        Else

            pro = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\DELL\Documents\LibraryVbDb.mdb"
            connstring = pro
            myconnection.ConnectionString = connstring
            myconnection.Open()
            command = "insert into IssueTbl ([StId],[StName],[BookId],[BookName],[IssueDate]) values (" & StIdCb.Text & ",'" & StNameTb.Text & "'," & BkIdCb.Text & ",'" & BkNameTb.Text & "','" & IDateCb.Text & "')"

            Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)

            cmd.Parameters.Add(New OleDbParameter("StId", CType(StIdCb.Text, Int32)))
            cmd.Parameters.Add(New OleDbParameter("StName", CType(StNameTb.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("BookId", CType(BkIdCb.Text, Int32)))
            cmd.Parameters.Add(New OleDbParameter("BookName", CType(BkNameTb.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("IssueDate", CType(IDateCb.Text, String)))

            MsgBox("Record Saved")
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myconnection.Close()

                DisplayBook()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim obj As New mainMenu
        obj.Show()
        Me.Hide()
    End Sub
End Class