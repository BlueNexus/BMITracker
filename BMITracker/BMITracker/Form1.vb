Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declare variables
        Dim name As String = txtName.Text
        Dim height, weight, bmi As Single

        'Validation
        If IsNumeric(txtHeight.Text) And IsNumeric(txtWeight.Text) Then

            height = txtHeight.Text
            weight = txtWeight.Text

            'Convert height to M
            height = height / 100

            'Calculate BMI
            bmi = ((weight / height) / height)

            'Output
            lblBMI.Text = name & " your BMI is: " & bmi
        Else
            'Give error if non numerics entered in height and weight
            MessageBox.Show("Enter a number into height and weight")
        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Exit
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Open add new weight form
        frmAdd.Show()

    End Sub

    Private Sub btnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click

        'Show graph
        Graph.Show()

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click

        'Hides the Main menu
        Me.Hide()
        'Load the Info Form
        Info.Show()

    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click

        'Show stats form
        StatsForm.Show()

    End Sub

    Private Sub btnTimers_Click(sender As Object, e As EventArgs) Handles btnTimers.Click

        'Hide this form, show timers
        Me.Hide()
        frmTimers.Show()

    End Sub
End Class
