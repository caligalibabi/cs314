Public Class frmMain

    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click
        Dim loanCost As Decimal = CDec(loanPaymentTxt.Text)
        Dim insuranceCost As Decimal = CDec(insurancePaymentTxt.Text)
        Dim oilCost As Decimal = CDec(oilChangeTxt.Text)
        Dim maintenanceCost As Decimal = CDec(maintenanceTxt.Text)
        Dim carWashCost As Decimal = CDec(carWashTxt.Text)
        Dim gasCost As Decimal = CDec(gasTxt.Text)
        Dim oneMonthCost, oneYearCost As Decimal

        oneMonthCost = loanCost + insuranceCost + oilCost + maintenanceCost + carWashCost + gasCost
        monthlyCostOut.Text = oneMonthCost
        oneYearCost = oneMonthCost * 12
        yearlyCostOut.Text = oneYearCost


    End Sub
End Class
