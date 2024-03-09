Public Class Form1

    Dim firstval As Double
    Dim Secondval As Double
    Dim [Operator] As String



    Private Sub equal_btn_Click(sender As Object, e As EventArgs) Handles equal_btn.Click
        Dim Result As Double
        Secondval = Val(txt_total.Text)
        Select Case [Operator]
            Case = "+"
                Result = firstval + Secondval
                txt_total.Text = Result.ToString()
            Case = "-"
                Result = firstval - Secondval
                txt_total.Text = Result.ToString()
            Case = "*"
                Result = firstval * Secondval
                txt_total.Text = Result.ToString
            Case = "/"
                Result = firstval / Secondval
                txt_total.Text = Result.ToString

        End Select
    End Sub

    Private Sub multiplication_btn_Click(sender As Object, e As EventArgs) Handles multiplication_btn.Click
        [Operator] = "+"
        txt_total.Text = ""



    End Sub

    Private Sub one_btn_Click(sender As Object, e As EventArgs) Handles one_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub two_btn_Click(sender As Object, e As EventArgs) Handles two_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub three_btn_Click(sender As Object, e As EventArgs) Handles three_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub six_btn_Click(sender As Object, e As EventArgs) Handles six_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub five_btn_Click(sender As Object, e As EventArgs) Handles five_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub four_btn_Click(sender As Object, e As EventArgs) Handles four_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub nine_btn_Click(sender As Object, e As EventArgs) Handles nine_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub eight_btn_Click(sender As Object, e As EventArgs) Handles eight_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub seven_btn_Click(sender As Object, e As EventArgs) Handles seven_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub zero_btn_Click(sender As Object, e As EventArgs) Handles zero_btn.Click
        txt_total.Text = txt_total.Text & sender.Text
    End Sub

    Private Sub additon_btn_Click(sender As Object, e As EventArgs) Handles additon_btn.Click
        firstval = Val(txt_total.Text)
        txt_total.Focus()
        [Operator] = "+"
        txt_total.Text = "
"

    End Sub

    Private Sub dot_btn_Click(sender As Object, e As EventArgs) Handles dot_btn.Click
        txt_total.Focus()

    End Sub

    Private Sub dash_btn_Click(sender As Object, e As EventArgs) Handles dash_btn.Click
        txt_total.Text = txt_total.Text

    End Sub
End Class
