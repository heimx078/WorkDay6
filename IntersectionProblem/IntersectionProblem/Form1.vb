Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        ' Read the input from the user
        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        ' All input must be numbers
        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) _
                And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If

        ' Convert to double
        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        ' Please write your code here...

        Dim result As String
        If (B < C) Or (D < A) Then
            result = "No intersection"
        Else
            Dim begPoint As Double
            begPoint = Math.Max(A, C)

            Dim endPoint As Double
            endpoint = Math.Min(B, D)

            result = "the intersection is from " & begPoint & " to " & endPoint


        End If

        txtResult.Text = result

    End Sub

End Class
