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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.WeightChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet2 = New BMITracker.DatabaseDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter1 = New BMITracker.DatabaseDataSetTableAdapters.Table1TableAdapter()
        CType(Me.WeightChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WeightChart
        '
        Me.WeightChart.BackColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.WeightChart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.WeightChart.Legends.Add(Legend3)
        Me.WeightChart.Location = New System.Drawing.Point(-1, -1)
        Me.WeightChart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.WeightChart.Name = "WeightChart"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.WeightChart.Series.Add(Series3)
        Me.WeightChart.Size = New System.Drawing.Size(510, 218)
        Me.WeightChart.TabIndex = 0
        Me.WeightChart.Text = "WeightChart"
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(419, 220)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(82, 57)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView1.DataSource = Me.Table1BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(140, 189)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(120, 78)
        Me.DataGridView1.TabIndex = 2
        Me.DataGridView1.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Weight"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BMI"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BMI"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Table1BindingSource1
        '
        Me.Table1BindingSource1.DataMember = "Table1"
        Me.Table1BindingSource1.DataSource = Me.DatabaseDataSet2
        '
        'DatabaseDataSet2
        '
        Me.DatabaseDataSet2.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        '
        'Table1TableAdapter1
        '
        Me.Table1TableAdapter1.ClearBeforeFill = True
        '
        'Graph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BMITracker.My.Resources.Resources.FreeVector_Circuit_Tree_Vector
        Me.ClientSize = New System.Drawing.Size(512, 300)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.WeightChart)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(528, 339)
        Me.Name = "Graph"
        Me.Text = "Graph"
        CType(Me.WeightChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WeightChart As DataVisualization.Charting.Chart
    Friend WithEvents btnLoad As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DatabaseDataSetBindingSource As BindingSource
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As DatabaseDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BMIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatabaseDataSet1 As DatabaseDataSet
    Friend WithEvents DatabaseDataSet2 As DatabaseDataSet
    Friend WithEvents Table1BindingSource1 As BindingSource
    Friend WithEvents Table1TableAdapter1 As DatabaseDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
