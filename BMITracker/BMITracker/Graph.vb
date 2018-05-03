

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
        chrtGraph.Series.Add("BMI")
        chrtGraph.Series("Weight").ChartType = SeriesChartType.Line
        chrtGraph.Series("BMI").ChartType = SeriesChartType.Line

        'Connect to DB
        Dim Conn As OleDbConnection = New OleDbConnection
        'DO NOT EDIT THIS LINE
        Dim provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database.accdb"
        Conn.ConnectionString = provider
        Conn.Open()

        'Load table into variable
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT [Weight], [BMI] FROM [Table1]", Conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        'Loop through data
        While dr.Read
            'Update graph with current item
            chrtGraph.Series("Weight").Points.Add(dr("Weight").ToString())
            chrtGraph.Series("BMI").Points.Add(dr("BMI").ToString())
            'Close
        End While
        dr.Close()

    End Sub

    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class