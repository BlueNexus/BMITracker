Imports System.Data.OleDb

Public Class frmAdd

    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click


        'Get weight
        Dim weight As Double = txtWeight.Text

        'Connect to DB
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Andrew\Documents\College\BMITracker\BMITracker\BMITracker\Database.accdb"
        connString = provider
        myConnection.ConnectionString = connString
        myConnection.Open()
        MessageBox.Show("Success!")

        'Add new weight to DB
        Dim str As String
        str = "INSERT INTO Table1 ([Weight], [BMI]) VALUES ('" & weight & "','" & 3 & "');"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        cmd.ExecuteNonQuery()

        'Close
        myConnection.Close()

        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Go back to main form
        Me.Close()

    End Sub

    Private Sub frmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class