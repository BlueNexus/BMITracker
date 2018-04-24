<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTimers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.components = New System.ComponentModel.Container()
        Me.btn5min = New System.Windows.Forms.Button()
        Me.btn10min = New System.Windows.Forms.Button()
        Me.btn15min = New System.Windows.Forms.Button()
        Me.btn20min = New System.Windows.Forms.Button()
        Me.btn25min = New System.Windows.Forms.Button()
        Me.btn30min = New System.Windows.Forms.Button()
        Me.btnReturnToMain = New System.Windows.Forms.Button()
        Me.lbltmr1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltmr2 = New System.Windows.Forms.Label()
        Me.cbStartStop = New System.Windows.Forms.CheckBox()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btn5min
        '
        Me.btn5min.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn5min.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btn5min.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn5min.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5min.Location = New System.Drawing.Point(13, 13)
        Me.btn5min.Name = "btn5min"
        Me.btn5min.Size = New System.Drawing.Size(143, 32)
        Me.btn5min.TabIndex = 0
        Me.btn5min.Text = "5 Minutes"
        Me.btn5min.UseVisualStyleBackColor = False
        '
        'btn10min
        '
        Me.btn10min.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn10min.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn10min.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn10min.Location = New System.Drawing.Point(13, 51)
        Me.btn10min.Name = "btn10min"
        Me.btn10min.Size = New System.Drawing.Size(143, 32)
        Me.btn10min.TabIndex = 1
        Me.btn10min.Text = "10 Minutes"
        Me.btn10min.UseVisualStyleBackColor = False
        '
        'btn15min
        '
        Me.btn15min.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn15min.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn15min.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn15min.Location = New System.Drawing.Point(13, 89)
        Me.btn15min.Name = "btn15min"
        Me.btn15min.Size = New System.Drawing.Size(143, 32)
        Me.btn15min.TabIndex = 2
        Me.btn15min.Text = "15 Minutes"
        Me.btn15min.UseVisualStyleBackColor = False
        '
        'btn20min
        '
        Me.btn20min.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn20min.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn20min.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn20min.Location = New System.Drawing.Point(13, 127)
        Me.btn20min.Name = "btn20min"
        Me.btn20min.Size = New System.Drawing.Size(143, 32)
        Me.btn20min.TabIndex = 3
        Me.btn20min.Text = "20 Minutes"
        Me.btn20min.UseVisualStyleBackColor = False
        '
        'btn25min
        '
        Me.btn25min.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn25min.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn25min.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn25min.Location = New System.Drawing.Point(13, 165)
        Me.btn25min.Name = "btn25min"
        Me.btn25min.Size = New System.Drawing.Size(143, 32)
        Me.btn25min.TabIndex = 4
        Me.btn25min.Text = "25 Minutes"
        Me.btn25min.UseVisualStyleBackColor = False
        '
        'btn30min
        '
        Me.btn30min.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn30min.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn30min.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn30min.Location = New System.Drawing.Point(13, 203)
        Me.btn30min.Name = "btn30min"
        Me.btn30min.Size = New System.Drawing.Size(143, 32)
        Me.btn30min.TabIndex = 17
        Me.btn30min.Text = "30 Minutes"
        Me.btn30min.UseVisualStyleBackColor = False
        '
        'btnReturnToMain
        '
        Me.btnReturnToMain.BackColor = System.Drawing.Color.SteelBlue
        Me.btnReturnToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnToMain.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnToMain.Location = New System.Drawing.Point(12, 249)
        Me.btnReturnToMain.Name = "btnReturnToMain"
        Me.btnReturnToMain.Size = New System.Drawing.Size(144, 32)
        Me.btnReturnToMain.TabIndex = 18
        Me.btnReturnToMain.Text = "Home"
        Me.btnReturnToMain.UseVisualStyleBackColor = False
        '
        'lbltmr1
        '
        Me.lbltmr1.AutoSize = True
        Me.lbltmr1.BackColor = System.Drawing.Color.Transparent
        Me.lbltmr1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbltmr1.Font = New System.Drawing.Font("Maiandra GD", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltmr1.Location = New System.Drawing.Point(249, 51)
        Me.lbltmr1.Name = "lbltmr1"
        Me.lbltmr1.Size = New System.Drawing.Size(66, 45)
        Me.lbltmr1.TabIndex = 19
        Me.lbltmr1.Text = "00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 45)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = ":"
        '
        'lbltmr2
        '
        Me.lbltmr2.AutoSize = True
        Me.lbltmr2.BackColor = System.Drawing.Color.Transparent
        Me.lbltmr2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbltmr2.Font = New System.Drawing.Font("Maiandra GD", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltmr2.Location = New System.Drawing.Point(332, 51)
        Me.lbltmr2.Name = "lbltmr2"
        Me.lbltmr2.Size = New System.Drawing.Size(66, 45)
        Me.lbltmr2.TabIndex = 21
        Me.lbltmr2.Text = "00"
        '
        'cbStartStop
        '
        Me.cbStartStop.Appearance = System.Windows.Forms.Appearance.Button
        Me.cbStartStop.AutoSize = True
        Me.cbStartStop.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cbStartStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbStartStop.Font = New System.Drawing.Font("Maiandra GD", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStartStop.Location = New System.Drawing.Point(220, 117)
        Me.cbStartStop.Name = "cbStartStop"
        Me.cbStartStop.Size = New System.Drawing.Size(251, 67)
        Me.cbStartStop.TabIndex = 27
        Me.cbStartStop.Text = "Start/Stop"
        Me.cbStartStop.UseVisualStyleBackColor = False
        '
        'tmr1
        '
        Me.tmr1.Interval = 1000
        '
        'frmTimers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.BMITracker.My.Resources.Resources.FreeVector_Circuit_Tree_Vector
        Me.ClientSize = New System.Drawing.Size(487, 287)
        Me.Controls.Add(Me.cbStartStop)
        Me.Controls.Add(Me.lbltmr2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltmr1)
        Me.Controls.Add(Me.btnReturnToMain)
        Me.Controls.Add(Me.btn30min)
        Me.Controls.Add(Me.btn25min)
        Me.Controls.Add(Me.btn20min)
        Me.Controls.Add(Me.btn15min)
        Me.Controls.Add(Me.btn10min)
        Me.Controls.Add(Me.btn5min)
        Me.Name = "frmTimers"
        Me.Text = "Timers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn5min As Button
    Friend WithEvents btn10min As Button
    Friend WithEvents btn15min As Button
    Friend WithEvents btn20min As Button
    Friend WithEvents btn25min As Button
    Friend WithEvents btn30min As Button
    Friend WithEvents btnReturnToMain As Button
    Friend WithEvents lbltmr1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbltmr2 As Label
    Friend WithEvents cbStartStop As CheckBox
    Friend WithEvents tmr1 As Timer
End Class
