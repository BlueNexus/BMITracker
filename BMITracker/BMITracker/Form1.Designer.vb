<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnGraph = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnFileSelect = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnFileSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTimers = New System.Windows.Forms.Button()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Weight in KG:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Height in cm"
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Location = New System.Drawing.Point(12, 81)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(85, 13)
        Me.lblBMI.TabIndex = 3
        Me.lblBMI.Text = "BMI Placeholder"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(16, 108)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 40)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add New Weight"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(16, 154)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(75, 40)
        Me.btnInfo.TabIndex = 5
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnGraph
        '
        Me.btnGraph.Location = New System.Drawing.Point(99, 108)
        Me.btnGraph.Name = "btnGraph"
        Me.btnGraph.Size = New System.Drawing.Size(75, 40)
        Me.btnGraph.TabIndex = 6
        Me.btnGraph.Text = "Graph"
        Me.btnGraph.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(99, 154)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(75, 40)
        Me.btnStats.TabIndex = 7
        Me.btnStats.Text = "Stats"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'btnFileSelect
        '
        Me.btnFileSelect.Location = New System.Drawing.Point(180, 110)
        Me.btnFileSelect.Name = "btnFileSelect"
        Me.btnFileSelect.Size = New System.Drawing.Size(75, 40)
        Me.btnFileSelect.TabIndex = 8
        Me.btnFileSelect.Text = "File Select"
        Me.btnFileSelect.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(180, 81)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 26)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnFileSave
        '
        Me.btnFileSave.Location = New System.Drawing.Point(180, 156)
        Me.btnFileSave.Name = "btnFileSave"
        Me.btnFileSave.Size = New System.Drawing.Size(75, 40)
        Me.btnFileSave.TabIndex = 10
        Me.btnFileSave.Text = "File Save"
        Me.btnFileSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(261, 156)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTimers
        '
        Me.btnTimers.Location = New System.Drawing.Point(261, 110)
        Me.btnTimers.Name = "btnTimers"
        Me.btnTimers.Size = New System.Drawing.Size(75, 40)
        Me.btnTimers.TabIndex = 12
        Me.btnTimers.Text = "Timers"
        Me.btnTimers.UseVisualStyleBackColor = True
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(99, 32)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 13
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(99, 55)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 14
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(99, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 241)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.btnTimers)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFileSave)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnFileSelect)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnGraph)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnGraph As Button
    Friend WithEvents btnStats As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnFileSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnTimers As Button
    Friend WithEvents btnFileSelect As Button
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtName As TextBox
End Class
