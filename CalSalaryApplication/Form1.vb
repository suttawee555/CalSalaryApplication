Public Class Form1
    Dim Salary As Integer
    Dim OT As Integer
    Dim OTSalary As Integer
    Dim TotalSalary As Integer
    Dim NetSalary As Integer
    Dim Vat As Single
    Const OTrate As Integer = 200
    Const Vatrate As Single = 0.07
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Salary = TextBox1.Text
        OT = TextBox2.Text
        OTSalary = OT * OTrate
        TotalSalary = Salary + OTSalary
        TextBox3.Text = OTSalary
        TextBox4.Text = TotalSalary
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Vat = TotalSalary * Vatrate
        NetSalary = TotalSalary - Vat
        TextBox5.Text = Vat
        TextBox6.Text = NetSalary
    End Sub
End Class
