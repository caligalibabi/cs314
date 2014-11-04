Public Class frmMain


    Private Sub grossIncomeInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grossIncomeInput.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim income As Double
        Dim mortgageLow, mortgageHigh As Double
        Double.TryParse(grossIncomeInput.Text, income)
        mortgageLow = income * 2
        mortgageHigh = income * 2.5
        lowRangeOutput.Text = CStr(mortgageLow)
        highRangeOutput.Text = CStr(mortgageHigh)
        lowRangeOutput.Visible = True
        highRangeOutput.Visible = True
        mortgageRangeTxt.Visible = True
        lblTo.Visible = True

    End Sub
End Class
