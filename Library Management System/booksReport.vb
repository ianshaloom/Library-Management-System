Imports System.Data.OleDb
Public Class booksReport
    Dim con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Theemain\Documents\LibraryVbDb.mdb")
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
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private bitmap As Bitmap

    Private Sub iPrint()
        Dim height As Integer = BooksDGV.Height
        BooksDGV.Height = BooksDGV.RowCount * BooksDGV.RowTemplate.Height
        bitmap = New Bitmap(Me.BooksDGV.Width, Me.BooksDGV.Height)
        BooksDGV.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.BooksDGV.Width, Me.BooksDGV.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        BooksDGV.Height = height
    End Sub
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        iPrint()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub

    Private Sub returnedBooksReportvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
    End Sub

    Private Sub exitt_Click(sender As Object, e As EventArgs) Handles exitt.Click
        Dim obj As New mainMenu
        obj.Show()
        Me.Hide()
        obj.searchpanel.Visible = False
        obj.managepanel.Visible = False
        obj.librarypanel.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class