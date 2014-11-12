<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblOrigPrice = New System.Windows.Forms.Label()
        Me.lblDiscRate = New System.Windows.Forms.Label()
        Me.txtOrigPrice = New System.Windows.Forms.TextBox()
        Me.lstBoxDiscRate = New System.Windows.Forms.ListBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblDiscountOf = New System.Windows.Forms.Label()
        Me.lblTotalPriceOut = New System.Windows.Forms.Label()
        Me.lblAfterDiscount = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOrigPrice
        '
        Me.lblOrigPrice.AutoSize = True
        Me.lblOrigPrice.Location = New System.Drawing.Point(12, 26)
        Me.lblOrigPrice.Name = "lblOrigPrice"
        Me.lblOrigPrice.Size = New System.Drawing.Size(72, 13)
        Me.lblOrigPrice.TabIndex = 0
        Me.lblOrigPrice.Text = "Original Price:"
        '
        'lblDiscRate
        '
        Me.lblDiscRate.AutoSize = True
        Me.lblDiscRate.Location = New System.Drawing.Point(12, 95)
        Me.lblDiscRate.Name = "lblDiscRate"
        Me.lblDiscRate.Size = New System.Drawing.Size(78, 13)
        Me.lblDiscRate.TabIndex = 1
        Me.lblDiscRate.Text = "Discount Rate:"
        '
        'txtOrigPrice
        '
        Me.txtOrigPrice.Location = New System.Drawing.Point(136, 23)
        Me.txtOrigPrice.Name = "txtOrigPrice"
        Me.txtOrigPrice.Size = New System.Drawing.Size(136, 20)
        Me.txtOrigPrice.TabIndex = 2
        '
        'lstBoxDiscRate
        '
        Me.lstBoxDiscRate.FormattingEnabled = True
        Me.lstBoxDiscRate.Location = New System.Drawing.Point(136, 50)
        Me.lstBoxDiscRate.Name = "lstBoxDiscRate"
        Me.lstBoxDiscRate.Size = New System.Drawing.Size(136, 95)
        Me.lstBoxDiscRate.TabIndex = 3
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(12, 162)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(61, 13)
        Me.lblTotalPrice.TabIndex = 4
        Me.lblTotalPrice.Text = "Total Price:"
        '
        'lblDiscountOf
        '
        Me.lblDiscountOf.AutoSize = True
        Me.lblDiscountOf.Location = New System.Drawing.Point(13, 207)
        Me.lblDiscountOf.Name = "lblDiscountOf"
        Me.lblDiscountOf.Size = New System.Drawing.Size(91, 13)
        Me.lblDiscountOf.TabIndex = 5
        Me.lblDiscountOf.Text = "After Discount Of:"
        '
        'lblTotalPriceOut
        '

        Me.lblTotalPriceOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPriceOut.Location = New System.Drawing.Point(136, 162)
        Me.lblTotalPriceOut.Name = "lblTotalPriceOut"
        Me.lblTotalPriceOut.Size = New System.Drawing.Size(41, 15)
        Me.lblTotalPriceOut.TabIndex = 6

        '
        'lblAfterDiscount
        '

        Me.lblAfterDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAfterDiscount.Location = New System.Drawing.Point(136, 207)
        Me.lblAfterDiscount.Name = "lblAfterDiscount"
        Me.lblAfterDiscount.Size = New System.Drawing.Size(41, 15)
        Me.lblAfterDiscount.TabIndex = 7

        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(183, 157)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(89, 65)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblAfterDiscount)
        Me.Controls.Add(Me.lblTotalPriceOut)
        Me.Controls.Add(Me.lblDiscountOf)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lstBoxDiscRate)
        Me.Controls.Add(Me.txtOrigPrice)
        Me.Controls.Add(Me.lblDiscRate)
        Me.Controls.Add(Me.lblOrigPrice)
        Me.Name = "frmMain"
        Me.Text = "Discount Warehouse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOrigPrice As System.Windows.Forms.Label
    Friend WithEvents lblDiscRate As System.Windows.Forms.Label
    Friend WithEvents txtOrigPrice As System.Windows.Forms.TextBox
    Friend WithEvents lstBoxDiscRate As System.Windows.Forms.ListBox
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblDiscountOf As System.Windows.Forms.Label
    Friend WithEvents lblTotalPriceOut As System.Windows.Forms.Label
    Friend WithEvents lblAfterDiscount As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button

End Class
