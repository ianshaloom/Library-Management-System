Public Class mainMenu

    Private Sub exitt_Click(sender As Object, e As EventArgs) Handles exitt.Click
        Dim obj As New logIn
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub SearchBook_Click(sender As Object, e As EventArgs)
        bookSearch.Show()
        Me.Close()
    End Sub

    Private Sub SearchReader_Click(sender As Object, e As EventArgs)
        readerSearch.Show()
        Me.Close()
    End Sub

    Private Sub IssueBook_Click(sender As Object, e As EventArgs)
        Dim obj As New borrowBook
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        searchpanel.Visible = True
        librarypanel.Visible = False
        managepanel.Visible = False
    End Sub

    Private Sub libraryBtn_Click(sender As Object, e As EventArgs) Handles libraryBtn.Click
        searchpanel.Visible = False
        librarypanel.Visible = True
        managepanel.Visible = False
    End Sub

    Private Sub manageBtn_Click(sender As Object, e As EventArgs) Handles manageBtn.Click
        searchpanel.Visible = False
        librarypanel.Visible = False
        managepanel.Visible = True
    End Sub

    Private Sub reportsBtn_Click(sender As Object, e As EventArgs) Handles reportsBtn.Click
        searchpanel.Visible = False
        librarypanel.Visible = False
        managepanel.Visible = False
    End Sub

    Private Sub SearchBook_Click_1(sender As Object, e As EventArgs) Handles SearchBook.Click
        Dim obj As New bookSearch
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub SearchReader_Click_1(sender As Object, e As EventArgs) Handles SearchReader.Click
        Dim obj As New readerSearch
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub bookregister_Click(sender As Object, e As EventArgs) Handles bookregister.Click
        Dim obj As New manageBooks
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub userregister_Click(sender As Object, e As EventArgs) Handles userregister.Click
        Dim obj As New manageReaders
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Dim obj As New borrowBook
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim obj As New returnBook
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub booksreport_Click(sender As Object, e As EventArgs) Handles booksreport.Click
        Dim obj As New booksReport
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub readersreport_Click(sender As Object, e As EventArgs) Handles readersreport.Click
        Dim obj As New readersReport
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub issuedreport_Click(sender As Object, e As EventArgs) Handles issuedreport.Click
        Dim obj As New IssuedBooksReport
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub returnedreport_Click(sender As Object, e As EventArgs) Handles returnedreport.Click
        Dim obj As New returnedBooksReportvb
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub duereport_Click(sender As Object, e As EventArgs) Handles duereport.Click
        Dim obj As New booksdue
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub incomereport_Click(sender As Object, e As EventArgs) Handles incomereport.Click
        Dim obj As New incomereport
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
