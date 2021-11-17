Imports System.Data.OleDb
Public Class manageReaders
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim ds As New OleDbDataAdapter
    Dim con As New OleDbConnection
    Dim dt As New DataTable

    Dim conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Theemain\Documents\LibraryVbDb.mdb")
    Private Sub DisplayBook()
        conn.Open()
        Dim query = "select * from StudentTbl"
        Dim adapter As OleDbDataAdapter
        Dim cmd = New OleDbCommand(query, conn)
        adapter = New OleDbDataAdapter(cmd)
        Dim builder = New OleDbCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        StudentsDGV.DataSource = ds.Tables(0)
        conn.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
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

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If StNameTb.Text = "" Or CourseTb.Text = "" Or SemCb.Text = "" Or ContactTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            pro = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Theemain\Documents\LibraryVbDb.mdb"
            connstring = pro
            myconnection.ConnectionString = connstring
            myconnection.Open()
            command = "insert into StudentTbl ([StName],[StCourse],[StYearSem],[StContact]) values ('" & StNameTb.Text & "','" & CourseTb.Text & "','" & SemCb.Text & "'," & ContactTb.Text & ")"

            Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
            cmd.Parameters.Add(New OleDbParameter("StName", CType(StNameTb.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("StCourse", CType(CourseTb.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("StYearSem", CType(SemCb.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("StContact", CType(ContactTb.Text, String)))
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

    Private Sub Reset()
        StNameTb.Text = ""
        CourseTb.Text = ""
        SemCb.Text = ""
        ContactTb.Text = ""
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
    Dim key = 0
    Private Sub StudentsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles StudentsDGV.CellMouseClick
        Dim row As DataGridViewRow = StudentsDGV.Rows(e.RowIndex)

        StNameTb.Text = row.Cells(1).Value.ToString
        CourseTb.Text = row.Cells(2).Value.ToString
        SemCb.Text = row.Cells(3).Value.ToString
        ContactTb.Text = row.Cells(4).Value.ToString

        If StNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            conn.Open()
            Dim query = "delete from StudentTbl where StId=" & key & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Student Deleted")
            conn.Close()
            DisplayBook()
            Reset()
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If StNameTb.Text = "" Or CourseTb.Text = "" Or SemCb.Text = "" Or ContactTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            conn.Open()
            Dim query = "update StudentTbl set StName='" & StNameTb.Text & "',StCourse='" & CourseTb.Text & "',StYearSem='" & SemCb.Text & "',StContact=" & ContactTb.Text & "where BkId=" & key & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Book Edited")
            conn.Close()
            DisplayBook()
            Reset()
        End If
    End Sub

    Private Sub manageReaders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
    End Sub

End Class