

Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Graph

    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Const MAX_HUMAN_WEIGHT = 442



    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        'Create graph series for weight
        chrtGraph.Series.Add("Weight")
        chrtGraph.Series("Weight").ChartType = SeriesChartType.Line

        'Connect to DB
        Dim Conn As OleDbConnection = New OleDbConnection
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
        Dim dataFile = "C:\Users\Andrew\Documents\College\BMITracker\BMITracker\BMITracker\Database.accdb" ' Change it to your Access Database location
        Conn.ConnectionString = provider & dataFile
        Conn.Open()

        'Load table into variable
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT [Weight] FROM [Table1]", Conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        'Loop through data
        While dr.Read
            'Update graph with current item
            chrtGraph.Series("Weight").Points.Add(dr("Weight").ToString)
            'Close
        End While
        dr.Close()

    End Sub
End Class