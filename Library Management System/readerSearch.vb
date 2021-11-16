Imports System.Data.OleDb
Public Class readerSearch
    Dim con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Resources\LibraryVbDb.mdb")
    Public Sub FilterData(valueToSearch As String)
        'SELECT * From Users WHERE CONCAT(fname, lname, age) like '%F%'
        Dim searchQuery As String = "SELECT * From StudentTbl WHERE StName like '%" & valueToSearch & "%'"

        Dim command As New OleDbCommand(searchQuery, con)
        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        BooksDGV.DataSource = table

    End Sub
    Private Sub exitt_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub readerSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        FilterData(SearchTb.text)
    End Sub

    Private Sub SearchTb_OnTextChange(sender As Object, e As EventArgs) Handles SearchTb.OnTextChange
        FilterData(SearchTb.text)
    End Sub
End Class