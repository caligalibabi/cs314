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
    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtAmountOwed.KeyPress, txtAmountPaid.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

    End Sub
    Private Sub txtAmountOwed_Enter(sender As Object, e As EventArgs) Handles txtAmountOwed.Enter
        txtAmountOwed.SelectAll()
    End Sub
    Private Sub txtAmountPaid_Enter(sender As Object, e As EventArgs) Handles txtAmountPaid.Enter
        txtAmountPaid.SelectAll()
    End Sub

    Private Sub txtChange_TextChanged(sender As Object, e As EventArgs) Handles txtChange.TextChanged

    End Sub
    Private Sub txtChange_Enter(sender As Object, e As EventArgs) Handles txtChange.Enter
        txtChange.SelectAll()
    End Sub
End Class
