Public Class frmAssignment_2

    Private Sub btnCalcBill_Click(sender As Object, e As EventArgs) Handles btnCalcBill.Click
        Dim Customer, Phone As String
        Dim Hours, Parts As Double

        If txtCustomer.Text = "" Or txtHours.Text = "" Or txtParts.Text = "" Then
            MessageBox.Show("Please fill in all of the boxes", "Error", _
            MessageBoxButtons.OK, _
            MessageBoxIcon.Exclamation)
        Else
            Dim prompt, title As String
            Dim service_date As Date
            prompt = "Enter date of services"
            title = "Date of services"
            service_date = InputBox(prompt, title)
            service_date = service_date.AddDays(30)
            Customer = CStr(txtCustomer.Text)
            Phone = CStr(mtbPhone.Text)
            Hours = CDbl(txtHours.Text)
            Parts = CDbl(txtParts.Text)
            lstBill.Items.Clear()
            lstBill.Items.Add("Customer: " & Customer)
            lstBill.Items.Add("Phone: " & Phone)
            lstBill.Items.Add("Hours: " & Hours)
            lstBill.Items.Add("Parts: " & Parts)
            lstBill.Items.Add("Total Bill: " & Hours * 35 + Parts * 0.05)
        End If
    End Sub
    Private Sub mtbPhone_MaskInputRejected(sender As Object, e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles mtbPhone.MaskInputRejected
        Dim Phone As String = "555 - 5555"
    End Sub
End Class
