Public Class logIn
    Private Sub exitt_Click(sender As Object, e As EventArgs) Handles exitt.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Textbox1.Text = "" And Textbox2.Text = "" Then
            mainMenu.Show()
            Me.Hide()
            Textbox1.Text = ""
            Textbox2.Text = ""
            Textbox1.Focus()
        Else
            MsgBox("Sorry Incorrect Username and Password", MsgBoxStyle.OkOnly, "Invalid")
            Textbox1.Text = ""
            Textbox2.Text = ""
            Textbox1.Focus()
        End If
    End Sub
End Class
