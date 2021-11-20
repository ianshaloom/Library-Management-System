Imports System.Data.OleDb
Public Class manageBooks
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
        Dim query = "select * from BookTbl"
        Dim adapter As OleDbDataAdapter
        Dim cmd = New OleDbCommand(query, conn)
        adapter = New OleDbDataAdapter(cmd)
        Dim builder = New OleDbCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        BooksDGV.DataSource = ds.Tables(0)
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

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If BNameTb.Text = "" Or BAuthorTb.Text = "" Or BPublisherTb.Text = "" Or BPriceTb.Text = "" Or BQuantityTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            pro = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Theemain\Documents\LibraryVbDb.mdb"
            connstring = pro
            myconnection.ConnectionString = connstring
            myconnection.Open()
            command = "insert into BookTbl ([BkName],[BkAuthor],[BkPublisher],[BkPrice],[BkQuantity]) values ('" & BNameTb.Text & "','" & BAuthorTb.Text & "','" & BPublisherTb.Text & "'," & BPriceTb.Text & "," & BQuantityTb.Text & ")"

            Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
            cmd.Parameters.Add(New OleDbParameter("BkName", CType(BNameTb.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("BkAuthor", CType(BAuthorTb.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("BkPublisher", CType(BPublisherTb.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("BkPrice", CType(BPriceTb.Text, Int32)))
            cmd.Parameters.Add(New OleDbParameter("BkQuantity", CType(BQuantityTb.Text, Int32)))

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

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If BNameTb.Text = "" Or BAuthorTb.Text = "" Or BPublisherTb.Text = "" Or BPriceTb.Text = "" Or BQuantityTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            conn.Open()
            Dim query = "update BookTbl set BkName='" & BNameTb.Text & "',BkAuthor='" & BAuthorTb.Text & "',BkPublisher='" & BPublisherTb.Text & "',BkPrice=" & BPriceTb.Text & ",BkQuantity=" & BQuantityTb.Text & " where BkId=" & key & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Book Edited")
            conn.Close()
            DisplayBook()
            Reset()
        End If
    End Sub
    Dim key = 0
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            conn.Open()
            Dim query = "delete from BookTbl where BkId=" & key & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted")
            conn.Close()
            DisplayBook()
            Reset()
        End If
    End Sub

    Private Sub BooksDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BooksDGV.CellMouseClick
        Dim row As DataGridViewRow = BooksDGV.Rows(e.RowIndex)

        BNameTb.Text = row.Cells(1).Value.ToString
        BAuthorTb.Text = row.Cells(2).Value.ToString
        BPublisherTb.Text = row.Cells(3).Value.ToString
        BPriceTb.Text = row.Cells(4).Value.ToString
        BQuantityTb.Text = row.Cells(5).Value.ToString

        If BNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub Reset()
        BNameTb.Text = ""
        BAuthorTb.Text = ""
        BPublisherTb.Text = ""
        BPriceTb.Text = ""
        BQuantityTb.Text = ""
    End Sub
    Private Sub manageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub exitt_Click(sender As Object, e As EventArgs) Handles exitt.Click
        Dim obj As New mainMenu
        obj.Show()
        Me.Hide()
        obj.searchpanel.Visible = False
        obj.managepanel.Visible = True
        obj.librarypanel.Visible = False
    End Sub
End Class