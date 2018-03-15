Public Class Graph
    Dim weighttable As New DataTable

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles WeightChart.Click

    End Sub

    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        weighttable.Columns.Add("Weight", GetType(Integer))
        weighttable.Columns.Add("Time", GetType(Integer))
        weighttable.Rows.Add(0, 0)
        weighttable.Rows.Add(1000, 50)
        weighttable.Rows.Add(2000, 50)
        weighttable.Rows.Add(3000, 0)

        With WeightChart.ChartAreas(0)
            .AxisX.Minimum = 0
            .AxisX.Maximum = weighttable.Rows.Count() + 1
            .AxisY.Minimum = 0
            .AxisY.Maximum = 180
            .AxisY.Interval = 10
            .AxisX.Title = "Time"
            .AxisY.Title = "Weight"
        End With
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        With WeightChart.Series(0)
            .Points.DataBind(weighttable.DefaultView, "ID", "Weight", Nothing)
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .BorderWidth = 4
        End With
    End Sub
End Class