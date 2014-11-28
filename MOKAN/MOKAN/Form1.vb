Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MOKANDataSet1.GeneralInfo' table. You can move, or remove it, as needed.
        Me.GeneralInfoTableAdapter.Fill(Me.MOKANDataSet1.GeneralInfo)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
