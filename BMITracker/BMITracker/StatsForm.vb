Public Class StatsForm
    Private Sub StatsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Declare variables
        Dim cmToM As Single
        Dim Height As Single
        Dim Weight As Single
        Dim BMInum As Single

        'Load data into variables
        lblName.Text = Form1.txtName.Text
        Weight = Form1.txtWeight.Text
        Height = Form1.txtHeight.Text

        lblHeight.Text = Height & "CM"
        lblWeight.Text = Weight & "KG"

        'Calc BMI
        cmToM = Height / 100
        BMInum = ((Weight / cmToM) / cmToM)

        'This if block checks where your BMI is and shows the resulting weight bracket
        If BMInum <= 18.4 Then
            lblInfo.Text = "Your BMI is " & BMInum & " Looks like you are underweight"
        ElseIf BMInum >= 18.5 Or BMInum <= 24.9 Then
            lblInfo.Text = "Your BMI is " & BMInum & " Looks like you are of healthy weight"
        ElseIf BMInum >= 25 Or BMInum <= 29.9 Then
            lblInfo.Text = "Your BMI is " & BMInum & " Looks like you are Overweight"
        ElseIf BMInum >= 30 Then
            lblInfo.Text = "Your BMI is " & BMInum & " Looks like you are Obese"
        End If

        'Display generic weight advice
        BMI.Items.Add("Underweight: < 18.5")
        BMI.Items.Add("Healthy: 18.5 - 24.9")
        BMI.Items.Add("Overweight: 25 - 29.9")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Home button returns to main form
        Form1.Show()
        Me.Close()

    End Sub
End Class