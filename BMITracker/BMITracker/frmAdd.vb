Imports System.Data.OleDb

Public Class frmAdd

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click


        'Get weight
        Dim weight As Single = txtWeight.Text

        'Update database
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        dataFile = "C\Database.accdb"
        connString = provider & dataFile
        myConnection.ConnectionString = connString
        myConnection.Open()
        Dim str As String
        str = "Update [Table1] set [weight] = '" & txtWeight.Text & "' Where [ID] = 1"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)

        'Close
        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Go back to main form
        Me.Close()

    End Sub

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class