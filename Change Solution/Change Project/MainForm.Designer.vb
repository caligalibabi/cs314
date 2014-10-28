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
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblDollarsTxt = New System.Windows.Forms.Label()
        Me.lblDimesTxt = New System.Windows.Forms.Label()
        Me.lblNickelsTxt = New System.Windows.Forms.Label()
        Me.lblPenniesTxt = New System.Windows.Forms.Label()
        Me.lblQuartersTxt = New System.Windows.Forms.Label()
        Me.btnCalcChange = New System.Windows.Forms.Button()
        Me.btnClrScreen = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.amountOwedTxt = New System.Windows.Forms.Label()
        Me.amountPaidTxt = New System.Windows.Forms.Label()
        Me.changeDueTxt = New System.Windows.Forms.Label()
        Me.txtOwed = New System.Windows.Forms.TextBox()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDollars
        '
        Me.lblDollars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDollars.Location = New System.Drawing.Point(12, 139)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(48, 25)
        Me.lblDollars.TabIndex = 0
        '
        'lblQuarters
        '
        Me.lblQuarters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuarters.Location = New System.Drawing.Point(75, 139)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(48, 25)
        Me.lblQuarters.TabIndex = 1
        '
        'lblDimes
        '
        Me.lblDimes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDimes.Location = New System.Drawing.Point(140, 139)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(48, 25)
        Me.lblDimes.TabIndex = 2
        '
        'lblNickels
        '
        Me.lblNickels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNickels.Location = New System.Drawing.Point(203, 139)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(48, 25)
        Me.lblNickels.TabIndex = 3
        '
        'lblPennies
        '
        Me.lblPennies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPennies.Location = New System.Drawing.Point(270, 139)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(48, 25)
        Me.lblPennies.TabIndex = 4
        '
        'lblDollarsTxt
        '
        Me.lblDollarsTxt.Location = New System.Drawing.Point(12, 123)
        Me.lblDollarsTxt.Name = "lblDollarsTxt"
        Me.lblDollarsTxt.Size = New System.Drawing.Size(48, 16)
        Me.lblDollarsTxt.TabIndex = 5
        Me.lblDollarsTxt.Text = "Dollars:"
        '
        'lblDimesTxt
        '
        Me.lblDimesTxt.Location = New System.Drawing.Point(137, 123)
        Me.lblDimesTxt.Name = "lblDimesTxt"
        Me.lblDimesTxt.Size = New System.Drawing.Size(48, 16)
        Me.lblDimesTxt.TabIndex = 6
        Me.lblDimesTxt.Text = "Dimes:"
        '
        'lblNickelsTxt
        '
        Me.lblNickelsTxt.Location = New System.Drawing.Point(200, 123)
        Me.lblNickelsTxt.Name = "lblNickelsTxt"
        Me.lblNickelsTxt.Size = New System.Drawing.Size(48, 16)
        Me.lblNickelsTxt.TabIndex = 7
        Me.lblNickelsTxt.Text = "Nickels:"
        '
        'lblPenniesTxt
        '
        Me.lblPenniesTxt.Location = New System.Drawing.Point(267, 123)
        Me.lblPenniesTxt.Name = "lblPenniesTxt"
        Me.lblPenniesTxt.Size = New System.Drawing.Size(48, 16)
        Me.lblPenniesTxt.TabIndex = 8
        Me.lblPenniesTxt.Text = "Pennies:"
        '
        'lblQuartersTxt
        '
        Me.lblQuartersTxt.Location = New System.Drawing.Point(72, 123)
        Me.lblQuartersTxt.Name = "lblQuartersTxt"
        Me.lblQuartersTxt.Size = New System.Drawing.Size(48, 16)
        Me.lblQuartersTxt.TabIndex = 9
        Me.lblQuartersTxt.Text = "Quarters:"
        '
        'btnCalcChange
        '
        Me.btnCalcChange.Location = New System.Drawing.Point(216, 9)
        Me.btnCalcChange.Name = "btnCalcChange"
        Me.btnCalcChange.Size = New System.Drawing.Size(99, 28)
        Me.btnCalcChange.TabIndex = 10
        Me.btnCalcChange.Text = "Calculate Change"
        Me.btnCalcChange.UseVisualStyleBackColor = True
        '
        'btnClrScreen
        '
        Me.btnClrScreen.Location = New System.Drawing.Point(216, 43)
        Me.btnClrScreen.Name = "btnClrScreen"
        Me.btnClrScreen.Size = New System.Drawing.Size(99, 28)
        Me.btnClrScreen.TabIndex = 11
        Me.btnClrScreen.Text = "Clear Screen"
        Me.btnClrScreen.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(216, 77)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 28)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'amountOwedTxt
        '
        Me.amountOwedTxt.AutoSize = True
        Me.amountOwedTxt.Location = New System.Drawing.Point(12, 18)
        Me.amountOwedTxt.Name = "amountOwedTxt"
        Me.amountOwedTxt.Size = New System.Drawing.Size(75, 13)
        Me.amountOwedTxt.TabIndex = 13
        Me.amountOwedTxt.Text = "Amount owed:"
        '
        'amountPaidTxt
        '
        Me.amountPaidTxt.AutoSize = True
        Me.amountPaidTxt.Location = New System.Drawing.Point(12, 52)
        Me.amountPaidTxt.Name = "amountPaidTxt"
        Me.amountPaidTxt.Size = New System.Drawing.Size(70, 13)
        Me.amountPaidTxt.TabIndex = 14
        Me.amountPaidTxt.Text = "Amount Paid:"
        '
        'changeDueTxt
        '
        Me.changeDueTxt.AutoSize = True
        Me.changeDueTxt.Location = New System.Drawing.Point(12, 86)
        Me.changeDueTxt.Name = "changeDueTxt"
        Me.changeDueTxt.Size = New System.Drawing.Size(70, 13)
        Me.changeDueTxt.TabIndex = 15
        Me.changeDueTxt.Text = "Change Due:"
        '
        'txtOwed
        '
        Me.txtOwed.Location = New System.Drawing.Point(94, 17)
        Me.txtOwed.Name = "txtOwed"
        Me.txtOwed.Size = New System.Drawing.Size(60, 20)
        Me.txtOwed.TabIndex = 16
        '
        'txtPaid
        '
        Me.txtPaid.Location = New System.Drawing.Point(94, 52)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(60, 20)
        Me.txtPaid.TabIndex = 17
        '
        'lblChange
        '
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChange.Location = New System.Drawing.Point(94, 86)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(60, 19)
        Me.lblChange.TabIndex = 18
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 413)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtPaid)
        Me.Controls.Add(Me.txtOwed)
        Me.Controls.Add(Me.changeDueTxt)
        Me.Controls.Add(Me.amountPaidTxt)
        Me.Controls.Add(Me.amountOwedTxt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClrScreen)
        Me.Controls.Add(Me.btnCalcChange)
        Me.Controls.Add(Me.lblQuartersTxt)
        Me.Controls.Add(Me.lblPenniesTxt)
        Me.Controls.Add(Me.lblNickelsTxt)
        Me.Controls.Add(Me.lblDimesTxt)
        Me.Controls.Add(Me.lblDollarsTxt)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblDollars)
        Me.Name = "frmMain"
        Me.Text = "Change Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDollars As System.Windows.Forms.Label
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents lblDollarsTxt As System.Windows.Forms.Label
    Friend WithEvents lblDimesTxt As System.Windows.Forms.Label
    Friend WithEvents lblNickelsTxt As System.Windows.Forms.Label
    Friend WithEvents lblPenniesTxt As System.Windows.Forms.Label
    Friend WithEvents lblQuartersTxt As System.Windows.Forms.Label
    Friend WithEvents btnCalcChange As System.Windows.Forms.Button
    Friend WithEvents btnClrScreen As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents amountOwedTxt As System.Windows.Forms.Label
    Friend WithEvents amountPaidTxt As System.Windows.Forms.Label
    Friend WithEvents changeDueTxt As System.Windows.Forms.Label
    Friend WithEvents txtOwed As System.Windows.Forms.TextBox
    Friend WithEvents txtPaid As System.Windows.Forms.TextBox
    Friend WithEvents lblChange As System.Windows.Forms.Label

End Class
