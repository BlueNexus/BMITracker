<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Graph
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.WeightChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnLoad = New System.Windows.Forms.Button()
        CType(Me.WeightChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WeightChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.WeightChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.WeightChart.Legends.Add(Legend1)
        Me.WeightChart.Location = New System.Drawing.Point(-2, -1)
        Me.WeightChart.Name = "WeightChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.WeightChart.Series.Add(Series1)
        Me.WeightChart.Size = New System.Drawing.Size(1020, 419)
        Me.WeightChart.TabIndex = 0
        Me.WeightChart.Text = "WeightChart"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(838, 424)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(163, 109)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Graph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 545)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.WeightChart)
        Me.Name = "Graph"
        Me.Text = "Graph"
        CType(Me.WeightChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WeightChart As DataVisualization.Charting.Chart
    Friend WithEvents btnLoad As Button
End Class
