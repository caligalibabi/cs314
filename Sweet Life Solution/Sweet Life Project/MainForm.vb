Public Class frmMain


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim salesTax As Double
        Dim subTotal As Double
        subTotal = 0
        If radioGlazed.Checked Or radioSugar.Checked Then
            subTotal += 0.65
        ElseIf radioChocolate.Checked Then
            subTotal += 0.85
        ElseIf radioFilled.Checked Then
            subTotal += 1.0
        End If

        If radioCappuccino.Checked Then
            subTotal += 1.8
        ElseIf radioRegular.Checked Then
            subTotal += 2.5
        End If
        salesTax = subTotal * 0.03
        salesTaxOut.Text = FormatCurrency(subTotal * salesTax)
        subTotalOut.Text = FormatCurrency(subTotal)
        totalDueOut.Text = FormatCurrency(subTotal + salesTax)



    End Sub
End Class
