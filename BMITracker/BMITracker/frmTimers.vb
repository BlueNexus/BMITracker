Public Class frmTimers
    Private Sub btnReturnToMain_Click(sender As Object, e As EventArgs) Handles btnReturnToMain.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub cbStartStop_CheckedChanged(sender As Object, e As EventArgs) Handles cbStartStop.CheckedChanged
        If cbStartStop.Checked = True And (lbltmr1.Text = "00" And lbltmr2.Text = "00") Then
            MessageBox.Show("Please select a time amount from the selection", "No Time Selected",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbStartStop.Checked = False
        ElseIf cbStartStop.Checked = True And (lbltmr1.Text > 0 Or lbltmr2.Text > 0) Then
            tmr1.Enabled = True
        ElseIf cbStartStop.Checked = False And tmr1.Enabled = True Then
            tmr1.Enabled = False
        End If
    End Sub

    Private Sub btn5min_Click(sender As Object, e As EventArgs) Handles btn5min.Click
        lbltmr1.Text = "05"
        lbltmr2.Text = "00"
    End Sub

    Private Sub btn10min_Click(sender As Object, e As EventArgs) Handles btn10min.Click
        lbltmr1.Text = "10"
        lbltmr2.Text = "00"
    End Sub

    Private Sub btn15min_Click(sender As Object, e As EventArgs) Handles btn15min.Click
        lbltmr1.Text = "15"
        lbltmr2.Text = "00"
    End Sub

    Private Sub btn20min_Click(sender As Object, e As EventArgs) Handles btn20min.Click
        lbltmr1.Text = "20"
        lbltmr2.Text = "00"
    End Sub

    Private Sub btn25min_Click(sender As Object, e As EventArgs) Handles btn25min.Click
        lbltmr1.Text = "25"
        lbltmr2.Text = "00"
    End Sub

    Private Sub btn30min_Click(sender As Object, e As EventArgs) Handles btn30min.Click
        lbltmr1.Text = "30"
        lbltmr2.Text = "00"
    End Sub

    Private Sub tmr1_Tick(sender As Object, e As EventArgs) Handles tmr1.Tick
        If lbltmr2.Text > 0 Then
            lbltmr2.Text = Val(lbltmr2.Text) - 1
            If lbltmr2.Text < 10 Then
                lbltmr2.Text = "0" & Val(lbltmr2.Text)
            End If
        ElseIf lbltmr2.Text = 0 And lbltmr1.Text > 0 Then
            lbltmr1.Text = Val(lbltmr1.Text) - 1
            lbltmr2.Text = 59
            If lbltmr1.Text < 10 Then
                lbltmr1.Text = "0" & Val(lbltmr1.Text)
            End If
        End If
    End Sub
End Class