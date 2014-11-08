Public Class frmMain
    Dim num As Integer
    Dim guess As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRanNum.Click
        Dim i As New Random
        num = i.Next(1, 26)
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        guess = Val(txtGuess.Text)
        If num > guess Then
            MessageBox.Show("Guess Higher")
        ElseIf num < guess Then
            MessageBox.Show("Guess Lower")
        Else
            MessageBox.Show("You are correct. The random integer is " + num.ToString())
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
