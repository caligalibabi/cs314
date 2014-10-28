Public Class Form1


    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click
        Dim merchExpenses As Decimal = CDec(merchTxt.Text)
        Dim restaurantExpenses As Decimal = CDec(restaurantTxt.Text)
        Dim gasExpenses As Decimal = CDec(gasTxt.Text)
        Dim serviceAndSuperExpenses As Decimal = CDec(servicesSuperTxt.Text)
        Dim travelAndEntertainmentExpenses As Decimal = CDec(travelEntTxt.Text)
        Dim oneMonthCost, oneYearCost, merchPercent, restaurantPercent,
            gasPercent, travelEntPercent, servicesSuperPercent As Decimal

        oneMonthCost = merchExpenses + restaurantExpenses + gasExpenses +
            serviceAndSuperExpenses + travelAndEntertainmentExpenses
        totalMonthlyCostOut.Text = oneMonthCost
        oneYearCost = oneMonthCost * 12
        totalYearlyCostOut.Text = oneYearCost
        annualPercentMerch.Text = ((merchExpenses * 12) / oneYearCost) * 100
        annualPercentRestaurant.Text = ((restaurantExpenses * 12) / oneYearCost) * 100
        annualPercentGas.Text = ((gasExpenses * 12) / oneYearCost) * 100
        annualPercentTravelEnt.Text = ((travelAndEntertainmentExpenses * 12) / oneYearCost) * 100
        annualPercentServSuper.Text = ((serviceAndSuperExpenses * 12) / oneYearCost) * 100


    End Sub
End Class
