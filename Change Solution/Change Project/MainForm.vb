Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnCalcChange_Click(sender As Object, e As EventArgs) Handles btnCalcChange.Click
        Dim decOwed, decPaid, decChange As Decimal
        Dim intDollars, intQuarters, intDimes, intNickels, intPennies As Integer

        Decimal.TryParse(txtOwed.Text, decOwed)
        Decimal.TryParse(txtPaid.Text, decPaid)

        decChange = decPaid - decOwed
        intPennies = Convert.ToInt32(decChange * 100)

        intDollars = intPennies \ 100
        intPennies = intPennies - (intDollars * 100)

        intQuarters = intPennies \ 25
        intPennies = intPennies - (intQuarters * 25)

        intDimes = intPennies \ 10
        intPennies = intPennies - (intDimes * 10)

        intNickels = intPennies \ 5
        intPennies = intPennies - (intNickels * 5)

        lblChange.Text = Convert.ToString(decChange)
        lblDollars.Text = Convert.ToString(intDollars)
        lblQuarters.Text = Convert.ToString(intQuarters)
        lblDimes.Text = Convert.ToString(intDimes)
        lblNickels.Text = Convert.ToString(intNickels)
        lblPennies.Text = Convert.ToString(intPennies)

        txtOwed.Focus()



    End Sub

    Private Sub ClearControls(sender As Object, e As EventArgs) Handles txtOwed.TextChanged, txtPaid.TextChanged
        lblChange.Text = String.Empty
        lblDollars.Text = String.Empty
        lblQuarters.Text = String.Empty
        lblDimes.Text = String.Empty
        lblNickels.Text = String.Empty
        lblPennies.Text = String.Empty
    End Sub

    Private Sub btnClrScreen_Click(sender As Object, e As EventArgs) Handles btnClrScreen.Click
        txtOwed.Text = String.Empty
        txtPaid.Text = String.Empty
        lblChange.Text = String.Empty
        lblDollars.Text = String.Empty
        lblQuarters.Text = String.Empty
        lblDimes.Text = String.Empty
        lblNickels.Text = String.Empty
        lblPennies.Text = String.Empty

        txtOwed.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
