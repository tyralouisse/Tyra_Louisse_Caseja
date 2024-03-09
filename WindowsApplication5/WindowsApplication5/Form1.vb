Public Class Form1
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim varname As String = "hello"
    '    Dim age As String = 20
    '    Const maxsize As Integer = 999

    '    Dim stringvar As String
    '    Dim intvar As Integer
    '    Dim booleanvar As Boolean
    '    Dim decimalvar As Decimal

    '    stringvar = "this is string"
    '    intvar = 345353
    '    booleanvar = False
    '    decimalvar = 34.365656


    '    'COMPARISON OPERATORS
    '    ' =
    '    If (1 = 1) Then
    '        MsgBox("true")
    '        If (45 <> 78) Then
    '            MsgBox("true")
    '        End If
    '        'greaterthan
    '        If (100 > 85) Then
    '            MsgBox("true")
    '        End If
    '        'lessthan
    '        If (35 < 65) Then
    '            MsgBox("true")
    '        End If
    '        'greaterthan equal
    '        If (100 <= 99) Then
    '            MsgBox("true")

    '        End If
    '        'logical operator
    '        'and
    '        Dim price As Integer = 25
    '        If price > 20 And price > 0 Then
    '            MsgBox("true")


    '            'or
    '            If price < 10 Or price Then
    '                MsgBox(price < 10 Or price > 0)
    '            End If


    '            If age = 10 Then
    '                    'true
    '                    MessageBox.Show("its true age is equal to 10")
    '                Else
    '                    'false
    '                    MessageBox.Show("its false,age is not equal to 10")
    '                End If


    '                If age = 10 Then
    '                    If age > 9 Then
    '                        'true
    '                        MessageBox.Show("its true age is equal to 10 greaterthan 9")

    '                        If age > 0 Then
    '                            'true 
    '                            MessageBox.Show("its true age is greater than 0")
    '                        End If
    '                    End If
    '                Else
    '                    If age > 11 Then
    '                       'false
    '                        MessageBox.Show("its false,age is not greater than 11")


    '                        Dim grade As Char
    '                        grade = "b"
    '                        Select Case grade
    '                            Case "a"
    '                                MessageBox.Show("excellent")
    '                            Case "b", "c"
    '                                MessageBox.Show("well done")
    '                                Case "d"
    '                                MessageBox.Show("you passed")
    '                            Case "f"
    '                                MessageBox.Show("better try again")
    '                            Case Else
    '                                MessageBox.Show("invalid grade")






    '                        End Select

    '                    End If
    '                End If

    '            End If



    '        End If


    'End Sub

    Private Sub BTN_EVALUATE_CLICK(sender As Object, e As EventArgs) Handles boton_EVALUATE.Click
        Dim age As Integer = Convert.ToDecimal(age_txtbox.Text)


        If age >= 100 Then
            MsgBox("dinosaur age")
        ElseIf age >= 90 Then
            MsgBox("century age")
        ElseIf age >= 80 Then
            MsgBox("grandfather age")
        ElseIf age >= 60 Then
            MsgBox("senior citizen")
        ElseIf age >= 45 Then
            MsgBox("middle age")
        ElseIf age >= 30 Then
            MsgBox("young")
        Else
            MsgBox("unknown age")

        End If
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles age_txtbox.TextChanged

    End Sub
End Class
