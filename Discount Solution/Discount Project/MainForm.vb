Public Class frmMain
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstBoxDiscRate.Items.Add("10%")
        lstBoxDiscRate.Items.Add("15%")
        lstBoxDiscRate.Items.Add("20%")
        lstBoxDiscRate.Items.Add("25%")
        lstBoxDiscRate.Items.Add("30%")
        lstBoxDiscRate.Items.Add("35%")
        lstBoxDiscRate.Items.Add("40%")
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim curItem As String = lstBoxDiscRate.SelectedItem.ToString()
        Dim origPrice As Decimal = txtOrigPrice.Text
        lblAfterDiscount.Text = curItem
        If curItem = "10%" Then
            lblTotalPriceOut.Text = origPrice - (origPrice * 0.1)
        ElseIf curItem = "15%" Then
            lblTotalPriceOut.Text = origPrice - (origPrice * 0.15)
        ElseIf curItem = "20%" Then
            lblTotalPriceOut.Text = origPrice - (origPrice * 0.2)
        ElseIf curItem = "25%" Then
            lblTotalPriceOut.Text = origPrice - (origPrice * 0.25)
        ElseIf curItem = "30%" Then
            lblTotalPriceOut.Text = origPrice - (origPrice * 0.3)
        ElseIf curItem = "35%" Then
            lblTotalPriceOut.Text = origPrice - (origPrice * 0.35)
        ElseIf curItem = "40%" Then
            lblTotalPriceOut.Text = origPrice - (origPrice * 0.4)
        End If
    End Sub
End Class
