Public Class frmMain
    Dim intTotalScore As Integer = "0"
    Dim intNumScores As Integer = "0"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        For intScore As Integer = 0 To 10 Step 1
            lstBoxScore.Items.Add(intScore.ToString())
        Next intScore
        lstBoxScore.SelectedItem = "0"
    End Sub

    Private Sub btnRecordScore_Click(sender As Object, e As EventArgs) Handles btnRecordScore.Click
        Dim intScore As Integer
        Dim avgScore As Decimal

        intScore = lstBoxScore.SelectedIndex
        intTotalScore = intTotalScore + lstBoxScore.SelectedIndex

        intNumScores = intNumScores + 1
        avgScore = intTotalScore / intNumScores

        totalScoreOut.Text = intTotalScore.ToString
        numScoresOut.Text = intNumScores.ToString
        avgScoreOut.Text = avgScore.ToString

    End Sub


    Private Sub btnNextSkater_Click(sender As Object, e As EventArgs) Handles btnNextSkater.Click
        intTotalScore = 0
        intNumScores = 0

        totalScoreOut.Text = String.Empty
        numScoresOut.Text = String.Empty
        avgScoreOut.Text = String.Empty
        lstBoxScore.SelectedItem = "0"
        lstBoxScore.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
