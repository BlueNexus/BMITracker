Public Class Info
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Closes the current form
        Me.Hide()
        'Opens the main menu
        Form1.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Process.Start("https://www.healthline.com/nutrition/44-healthy-low-carb-foods")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Process.Start("https://www.mensfitness.com/weight-loss/burn-fat-fast/100-ways-burn-fat-fast")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            Process.Start("https://www.bodybuilding.com/fun/brewster26.htm")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Try
            Process.Start("https://www.muscleandfitness.com/nutrition/meal-plans/28-days-lean-meal-plan")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Try
            Process.Start("https://www.healthline.com/nutrition/how-to-lose-weight-as-fast-as-possible")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Try
            Process.Start("https://www.mensfitness.com/nutrition/what-to-eat/5-best-diets-losing-weight-and-burning-fat")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Try
            Process.Start("https://www.mensfitness.com/nutrition/what-to-eat/new-year-new-you-4-week-fat-burning-meal-plan")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Try
            Process.Start("https://www.goodhousekeeping.com/health/diet-nutrition/advice/g781/belly-fat-foods/")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Try
            Process.Start("https://www.muscleandfitness.com/nutrition/meal-plans/build-muscle-stay-lean-meal-plan")
        Catch ex As Exception
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub
End Class