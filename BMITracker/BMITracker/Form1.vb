﻿Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declare variables and get values
        Dim name As String = txtName.Text
        Dim height, weight, bmi As Single
        height = txtHeight.Text
        weight = txtWeight.Text

        'Convert height to M
        height = height / 100

        'Calculate BMI
        bmi = ((weight / height) / height)

        'Output
        lblBMI.Text = name & " your BMI is: " & bmi

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Open add new weight form
        'frmNew.Show()

    End Sub

    Private Sub btnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click

        Graph.Show()

    End Sub
End Class
