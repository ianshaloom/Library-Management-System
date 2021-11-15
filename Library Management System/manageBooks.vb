Imports System.Data.OleDb
Public Class manageBooks
    Dim con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Resources\LibraryVbDb.mdb")
    Private Sub DisplayBook()
        con.Open()
        Dim query = "select * from BookTbl"
        Dim adapter As OleDbDataAdapter
        Dim cmd = New OleDbCommand(query, con)
        adapter = New OleDbDataAdapter(cmd)
        Dim builder = New OleDbCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        BooksDGV.DataSource = ds.Tables(0)
        con.close()
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
        Close()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If BNameTb.Text = "" Or BAuthorTb.Text = "" Or BPublisherTb.Text = "" Or BPriceTb.Text = "" Or BQuantityTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query = "Insert Into BookTbl(BkName,BkAuthor,BkPublisher,BkPrice,BkQuantity) values('" & BNameTb.Text & "','" & BAuthorTb.Text & "','" & BPublisherTb.Text & "'," & BPriceTb.Text & "," & BQuantityTb.Text & ")"
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Saved")
            con.Close()
            DisplayBook()
            Reset()
        End If
    End Sub

    Private Sub manageBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
    End Sub
    Private Sub Reset()
        BNameTb.Text = ""
        BAuthorTb.Text = ""
        BPublisherTb.Text = ""
        BPriceTb.Text = ""
        BQuantityTb.Text = ""
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
    Dim key = 0
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

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query = "delete from BookTbl where BkId=" & key & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted")
            con.Close()
            DisplayBook()
            Reset()
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If BNameTb.Text = "" Or BAuthorTb.Text = "" Or BPublisherTb.Text = "" Or BPriceTb.Text = "" Or BQuantityTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            con.Open()
            Dim query = "update BookTbl set BkName='" & BNameTb.Text & "',BkAuthor='" & BAuthorTb.Text & "',BkPublisher='" & BPublisherTb.Text & "',BkPrice=" & BPriceTb.Text & ",BkQuantity=" & BQuantityTb.Text & " where BkId=" & key & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Edited")
            con.Close()
            DisplayBook()
            Reset()
        End If
    End Sub
End Class