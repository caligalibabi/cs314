<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignment_2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalcBill = New System.Windows.Forms.Button()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.mtbPhone = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'btnCalcBill
        '
        Me.btnCalcBill.Location = New System.Drawing.Point(12, 144)
        Me.btnCalcBill.Name = "btnCalcBill"
        Me.btnCalcBill.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcBill.TabIndex = 0
        Me.btnCalcBill.Text = "Calculate Bill"
        Me.btnCalcBill.UseVisualStyleBackColor = True
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.Location = New System.Drawing.Point(12, 173)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(439, 147)
        Me.lstBill.TabIndex = 1
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(9, 26)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(54, 13)
        Me.lblCustomer.TabIndex = 2
        Me.lblCustomer.Text = "Customer:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(9, 54)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Phone:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(9, 79)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(38, 13)
        Me.lblHours.TabIndex = 4
        Me.lblHours.Text = "Hours:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Parts:"
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(69, 19)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomer.TabIndex = 6
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(69, 79)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 8
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(69, 105)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(100, 20)
        Me.txtParts.TabIndex = 9
        '
        'mtbPhone
        '
        Me.mtbPhone.Location = New System.Drawing.Point(69, 54)
        Me.mtbPhone.Name = "mtbPhone"
        Me.mtbPhone.Size = New System.Drawing.Size(100, 20)
        Me.mtbPhone.TabIndex = 10
        Me.mtbPhone.Text = "___-____"
        '
        'frmAssignment_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 429)
        Me.Controls.Add(Me.mtbPhone)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.lstBill)
        Me.Controls.Add(Me.btnCalcBill)
        Me.Name = "frmAssignment_2"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcBill As System.Windows.Forms.Button
    Friend WithEvents lstBill As System.Windows.Forms.ListBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents mtbPhone As System.Windows.Forms.MaskedTextBox

End Class
