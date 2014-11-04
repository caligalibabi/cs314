Public Class frmMain


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amountOwed, amountPaid, change As Double
        change = 0
        Double.TryParse(txtAmountOwed.Text, amountOwed)
        Double.TryParse(txtAmountPaid.Text, amountPaid)
        If (amountPaid < amountOwed) Then
            MessageBox.Show("Amount Paid is less than amount owed.")
        Else
            change = amountPaid - amountOwed

        End If
        txtChange.Text = change
        lblChange.Visible = True
        txtChange.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
