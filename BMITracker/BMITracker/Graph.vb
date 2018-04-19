


Imports System.Windows.Forms.DataVisualization.Charting
Public Class Graph

    Dim datset As New DataSet()
    Dim weighttable As New DatabaseDataSet.Table1DataTable()
    Dim adapter = New DatabaseDataSetTableAdapters.Table1TableAdapter()
    Const MAX_HUMAN_WEIGHT = 442

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles WeightChart.Click
    End Sub

    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet2.Table1' table. You can move, or remove it, as needed.
        'weighttable = DatabaseDataSet2.Table1.CopyToDataTable()
        WeightChart.DataSource = weighttable
        weighttable.Columns.Add("Time", GetType(Integer))
        weighttable.Rows.Add(0, 0)
        weighttable.Rows.Add(1000, 50)
        weighttable.Rows.Add(2000, 50)
        weighttable.Rows.Add(3000, 0)

        With WeightChart.ChartAreas(0)
            .AxisX.Minimum = -1
            .AxisX.Maximum = weighttable.Rows.Count() + 1
            .AxisY.Minimum = 0
            .AxisY.Maximum = MAX_HUMAN_WEIGHT
            .AxisY.Interval = 10
            .AxisX.Title = "Time"
            .AxisY.Title = "Weight"
        End With

    End Sub


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        adapter.Fill(weighttable)
        weighttable.AcceptChanges()
        With WeightChart.Series(0)

            .Points.DataBind(weighttable.DefaultView, "ID", "Weight", Nothing)
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .BorderWidth = 4
        End With
    End Sub
End Class