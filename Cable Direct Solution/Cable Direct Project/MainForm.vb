Public Class frmMain
    Private Function CalcResidentTotalDue() As Double
        Const dblRESIDENT_PROCESSING As Double = 4.5
        Const dblRESIDENT_BASIC As Double = 30
        Const dblRESIDENT_PREMIUM As Double = 5
        Dim intPremiumChannels As Integer
        Dim dblCharge As Double

        lstConnections.SelectedIndex = 0

        Integer.TryParse(lstPremium.SelectedItem.ToString, intPremiumChannels)

        dblCharge = dblRESIDENT_PROCESSING + dblRESIDENT_BASIC + dblRESIDENT_PREMIUM * intPremiumChannels

        Return dblCharge
    End Function
    Private Function CalcBusinessTotalDue() As Double
        Const dblBUSINESS_PROCESSING As Double = 16.5
        Const dblBUSINESS_FIRST10_CONS As Double = 80
        Const dblBUSINESS_ADDITIONAL_CONS As Double = 4
        Const dblBUSINESS_PREMIUM_CHANNEL As Double = 50
        Dim intConnections As Integer
        Dim intPremiumChannels As Integer
        Dim dblBusinessBasic As Double
        Dim dblCharge As Double

        Integer.TryParse(lstConnections.SelectedItem.ToString, intConnections)

        If intConnections = 0 Then
            MessageBox.Show("Number of connections must be greater than 0.", "Cable (Theifs) Direct")
        Else
            Integer.TryParse(lstPremium.SelectedItem.ToString, intPremiumChannels)
            If intConnections <= 10 Then
                dblBusinessBasic = dblBUSINESS_FIRST10_CONS
            Else
                dblBusinessBasic = dblBUSINESS_FIRST10_CONS + (intConnections - 10) * dblBUSINESS_ADDITIONAL_CONS

            End If
            dblCharge = dblBUSINESS_PROCESSING + dblBusinessBasic + dblBUSINESS_PREMIUM_CHANNEL * intPremiumChannels
        End If

        Return dblCharge
        
    End Function


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblTotalDue As Double

        If radResidential.Checked Then
            dblTotalDue = CalcResidentTotalDue()
        Else
            dblTotalDue = CalcBusinessTotalDue()
        End If
        totalDueOut.Text = dblTotalDue.ToString("C2")
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dialogButton As DialogResult

        dialogButton = MessageBox.Show("Your bill was not high enough are you sure you don't want anymore useless channels?", "Cable (Theifs) Direct",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Exclamation,
                                       MessageBoxDefaultButton.Button1)
        If dialogButton = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        For intPremiumChannel As Integer = 0 To 20
            lstPremium.Items.Add(intPremiumChannel.ToString)
        Next intPremiumChannel

        For intConnections As Integer = 0 To 100
            lstConnections.Items.Add(intConnections.ToString)

        Next intConnections
        lstPremium.SelectedIndex = 0
        lstConnections.SelectedIndex = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
