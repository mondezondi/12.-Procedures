Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNumber, secondNumber As Integer
        firstNumber = Val(TextBox1.Text)
        secondNumber = Val(TextBox2.Text)

        Sum(firstNumber, secondNumber)

    End Sub

    Sub Sum(a As Integer, b As Integer)
        Dim total As Integer

        total = a + b

        TextBox3.Text = total
    End Sub
End Class

