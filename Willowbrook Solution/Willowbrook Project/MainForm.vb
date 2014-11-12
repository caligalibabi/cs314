Public Class frmMain


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim Basic As Double
        Dim MonthlyDue As Double
        Dim Additional As Double
        Additional = 0
        Basic = Val(txtBasicFee.Text)
        If chkGolf.Checked Then
            Additional = Additional + 25
        End If
        If chkTennis.Checked Then
            Additional = Additional + 30
        End If
        If chkRacquetball.Checked Then
            Additional = Additional + 20
        End If
        MonthlyDue = Basic + Additional
        lblAdditional.Text = Additional.ToString()
        lblMonthlyDues.Text = MonthlyDue.ToString()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
