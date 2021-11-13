Public Class mainMenu

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        searchpanel.Visible = True
        addpanel.Visible = False
        librarypanel.Visible = False
        managepanel.Visible = False
        addpanel.Visible = False
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        searchpanel.Visible = False
        addpanel.Visible = True
        librarypanel.Visible = False
        managepanel.Visible = False
        addpanel.Visible = False
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        searchpanel.Visible = False
        addpanel.Visible = False
        librarypanel.Visible = True
        managepanel.Visible = False
        addpanel.Visible = False
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        searchpanel.Visible = False
        addpanel.Visible = False
        librarypanel.Visible = False
        managepanel.Visible = True
        addpanel.Visible = False
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        searchpanel.Visible = False
        addpanel.Visible = False
        librarypanel.Visible = False
        managepanel.Visible = False
        addpanel.Visible = True
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        bookSearch.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        readerSearch.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        addBook.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        addReader.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        borrowBook.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        returnBook.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        manageBooks.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        manageReaders.Show()
        Me.Close()
    End Sub
End Class
