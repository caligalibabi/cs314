Public Class MainForm

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim usDollars = txtUsd.Text
        lblEuro.Text = usDollars * 0.79
        lblFranc.Text = usDollars * 0.091
        lblRand.Text = usDollars * 0.95

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
