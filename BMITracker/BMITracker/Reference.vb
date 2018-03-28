Public Class Info
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Closes the current form
        Me.Hide()
        'Opens the main menu
        Form1.Show()
    End Sub
End Class