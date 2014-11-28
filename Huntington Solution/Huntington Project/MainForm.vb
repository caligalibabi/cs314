Public Class frmMain


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intNumSold As Integer
        Dim strSalesId As String
        Dim intFullTimeSales As Integer
        Dim intPartTimeSales As Integer
        Dim intNewCars As Integer
        Dim intUsedCars As Integer

        strSalesId = txtIdInput.Text
        intNumSold = txtNumSoldInput.Text

        If strSalesId.Substring(0, 1) = 1 Then
            intNewCars = intNumSold
            lblNewCarsOut.Text = intNewCars
            If strSalesId.Substring(3, 1).ToUpper = "F" Then
                intFullTimeSales = intNumSold
                lblFullTimeOut.Text = intFullTimeSales
            ElseIf strSalesId.Substring(3, 1).ToUpper = "P" Then
                intPartTimeSales = intNumSold
                lblPartTimeOut.Text = intPartTimeSales
            End If
        ElseIf strSalesId.Substring(0, 1) = 2 Then
            intUsedCars = intNumSold
            lblUsedCarsOut.Text = intUsedCars
            If strSalesId.Substring(3, 1).ToUpper = "F" Then
                intFullTimeSales = intNumSold
                lblFullTimeOut.Text = intFullTimeSales
            ElseIf strSalesId.Substring(3, 1).ToUpper = "P" Then
                intPartTimeSales = intNumSold
                lblPartTimeOut.Text = intPartTimeSales
            End If
        End If





    End Sub
End Class
