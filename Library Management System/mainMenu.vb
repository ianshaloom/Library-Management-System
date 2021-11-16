Public Class mainMenu

    Private Sub exitt_Click(sender As Object, e As EventArgs) Handles exitt.Click
        Close()
    End Sub

    Private Sub SearchBook_Click(sender As Object, e As EventArgs) Handles SearchBook.Click
        bookSearch.Show()
        Me.Close()
    End Sub

    Private Sub SearchReader_Click(sender As Object, e As EventArgs) Handles SearchReader.Click
        readerSearch.Show()
        Me.Close()
    End Sub

    Private Sub IssueBook_Click(sender As Object, e As EventArgs) Handles IssueBook.Click
        Dim obj As New borrowBook
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub ReturnBook_Click(sender As Object, e As EventArgs) Handles ReturnBook.Click
        Dim obj As New returnBook
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub ManageBooks_Click(sender As Object, e As EventArgs) Handles ManageBooks.Click
        Dim obj As New manageBooks
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub ManageReaders_Click(sender As Object, e As EventArgs) Handles ManageReaders.Click
        Dim obj As New manageReaders
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
End Class
