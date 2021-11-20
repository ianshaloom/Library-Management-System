Public Class esplash
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            logIn.Show()
            Me.Hide()
        Else
            ProgressBar1.Value = ProgressBar1.Value + 2
        End If
    End Sub
End Class