Public Class Form1

    Dim firstval As Double
    Dim secondval As Double
    Dim [operator] As String

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles one_btn.Click
        Txt_total_Text = Txt_total_Text & sender.text
        Dim firsval = Val(Txt_total_Text)

    End Sub
    Private Sub two_btn_Click(sender As Object, e As EventArgs) Handles two_btn.Click
        Txt_total_Text = Txt_total_Text & sender.text
    End Sub

    Private Sub three_btn_Click(sender As Object, e As EventArgs) Handles three_btn.Click
        Txt_total_Text = Txt_total_Text & sender.text
    End Sub

    Private Sub six_btn_Click(sender As Object, e As EventArgs) Handles six_btn.Click
        Txt_total_Text = Txt_total_Text & sender.text
    End Sub

    Private Sub eight_btn_Click(sender As Object, e As EventArgs) Handles eight_btn.Click
        Txt_total_Text = Txt_total_Text & sender.text
    End Sub

    Private Sub nine_btn_Click(sender As Object, e As EventArgs) Handles nine_btn.Click
        Txt_total_Text = Txt_total_Text & sender.text
    End Sub

    Private Sub seven_btn_Click(sender As Object, e As EventArgs) Handles seven_btn.Click
        Txt_total_Text = Txt_total_Text & sender.text
    End Sub

    Private Sub subraction_btn_Click(sender As Object, e As EventArgs) Handles subraction_btn.Click
        Txt_total_Text.Focus()

    End Sub

    Private Sub multiply_btn_Click(sender As Object, e As EventArgs) Handles multiply_btn.Click


    End Sub

    Private Sub divide_btn_Click(sender As Object, e As EventArgs) Handles divide_btn.Click

    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click

    End Sub

    Private Sub zeron_btn_Click(sender As Object, e As EventArgs) Handles zeron_btn.Click
        Txt_total_Text = Txt_total_Text & sender.text
    End Sub

    Private Sub equals_btn_Click(sender As Object, e As EventArgs) Handles equals_btn.Click
        Dim firstval = [Txt_total_Text]



    End Sub

    Private Sub addition_btn_Click(sender As Object, e As EventArgs) Handles addition_btn.Click
        Dim firstval = [Txt_total_Text]
    End Sub

    Private Sub five_btn_Click(sender As Object, e As EventArgs) Handles five_btn.Click
        Txt_total_Text = Txt_total_Text & sender.text
    End Sub
End Class
