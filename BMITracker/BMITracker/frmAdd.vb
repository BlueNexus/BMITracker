Public Class frmAdd
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        'Get weight
        Dim weight As Single = txtWeight.Text

        'Close
        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Go back to main form
        Me.Close()

    End Sub
End Class