Public Class StatsForm
    Private Sub StatsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmToM As Single
        Dim Height As Single
        Dim Weight As Single
        Dim BMInum As Single
        lblName.Text = Form1.txtName.Text
        lblWeight.Text = Form1.txtWeight.Text
        lblHeight.Text = Form1.txtHeight.Text

        Height = lblHeight.Text
        Weight = lblWeight.Text
        cmToM = Height / 100
        BMInum = ((Weight / cmToM) / cmToM)

        If BMInum <= 18.4 Then
            lblInfo.Text = "Your BMI is " & BMInum & " Looks like you are underweight"
        ElseIf BMInum >= 18.5 Or BMInum <= 24.9 Then
            lblInfo.Text = "Your BMI is " & BMInum & " Looks like you are of healthy weight"
        ElseIf BMInum >= 25 Or BMInum <= 29.9 Then
            lblInfo.Text = "Your BMI is " & BMInum & " Looks like you are Overweight"
        ElseIf BMInum >= 30 Then
            lblInfo.Text = "Your BMI is " & BMInum & " Looks like you are Obese"
        End If
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