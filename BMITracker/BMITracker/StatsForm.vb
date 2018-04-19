Public Class StatsForm
    Dim cmToM As String
    Dim Height As Integer


    Private Sub StatsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = Form1.txtName.Text
        lblWeight.Text = Form1.txtWeight.Text
        lblHeight.Text = Form1.txtHeight.Text

        Height = lblHeight.Text / 100
        cmToM = ((lblWeight.Text / Height) / Height)
        lblInfo.Text = ("Your BMI is " + cmToM)
        BMI.Items.Add("Underweight: < 18.5")
        BMI.Items.Add("Healthy: 18.5 - 24.9")
        BMI.Items.Add("Overweight: 25 - 29.9")
        BMI.Items.Add("Obese: 30 or <")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class