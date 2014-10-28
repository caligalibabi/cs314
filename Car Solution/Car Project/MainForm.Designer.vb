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
        Me.loanPaymentTxt = New System.Windows.Forms.TextBox()
        Me.insurancePaymentTxt = New System.Windows.Forms.TextBox()
        Me.oilChangeTxt = New System.Windows.Forms.TextBox()
        Me.maintenanceTxt = New System.Windows.Forms.TextBox()
        Me.carWashTxt = New System.Windows.Forms.TextBox()
        Me.gasTxt = New System.Windows.Forms.TextBox()
        Me.loanPaymentLbl = New System.Windows.Forms.Label()
        Me.insuranceLbl = New System.Windows.Forms.Label()
        Me.oilChangeLbl = New System.Windows.Forms.Label()
        Me.maintenanceLbl = New System.Windows.Forms.Label()
        Me.carWashLbl = New System.Windows.Forms.Label()
        Me.gasLbl = New System.Windows.Forms.Label()
        Me.monthlyCostOut = New System.Windows.Forms.Label()
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.yearlyCostOut = New System.Windows.Forms.Label()
        Me.monthCostLbl = New System.Windows.Forms.Label()
        Me.yearlyCostLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'loanPaymentTxt
        '
        Me.loanPaymentTxt.Location = New System.Drawing.Point(119, 6)
        Me.loanPaymentTxt.Name = "loanPaymentTxt"
        Me.loanPaymentTxt.Size = New System.Drawing.Size(100, 20)
        Me.loanPaymentTxt.TabIndex = 0
        '
        'insurancePaymentTxt
        '
        Me.insurancePaymentTxt.Location = New System.Drawing.Point(119, 46)
        Me.insurancePaymentTxt.Name = "insurancePaymentTxt"
        Me.insurancePaymentTxt.Size = New System.Drawing.Size(100, 20)
        Me.insurancePaymentTxt.TabIndex = 1
        '
        'oilChangeTxt
        '
        Me.oilChangeTxt.Location = New System.Drawing.Point(119, 85)
        Me.oilChangeTxt.Name = "oilChangeTxt"
        Me.oilChangeTxt.Size = New System.Drawing.Size(100, 20)
        Me.oilChangeTxt.TabIndex = 2
        '
        'maintenanceTxt
        '
        Me.maintenanceTxt.Location = New System.Drawing.Point(119, 127)
        Me.maintenanceTxt.Name = "maintenanceTxt"
        Me.maintenanceTxt.Size = New System.Drawing.Size(100, 20)
        Me.maintenanceTxt.TabIndex = 3
        '
        'carWashTxt
        '
        Me.carWashTxt.Location = New System.Drawing.Point(119, 169)
        Me.carWashTxt.Name = "carWashTxt"
        Me.carWashTxt.Size = New System.Drawing.Size(100, 20)
        Me.carWashTxt.TabIndex = 4
        '
        'gasTxt
        '
        Me.gasTxt.Location = New System.Drawing.Point(119, 209)
        Me.gasTxt.Name = "gasTxt"
        Me.gasTxt.Size = New System.Drawing.Size(100, 20)
        Me.gasTxt.TabIndex = 5
        '
        'loanPaymentLbl
        '
        Me.loanPaymentLbl.AutoSize = True
        Me.loanPaymentLbl.Location = New System.Drawing.Point(12, 9)
        Me.loanPaymentLbl.Name = "loanPaymentLbl"
        Me.loanPaymentLbl.Size = New System.Drawing.Size(78, 13)
        Me.loanPaymentLbl.TabIndex = 6
        Me.loanPaymentLbl.Text = "Loan Payment:"
        '
        'insuranceLbl
        '
        Me.insuranceLbl.AutoSize = True
        Me.insuranceLbl.Location = New System.Drawing.Point(12, 49)
        Me.insuranceLbl.Name = "insuranceLbl"
        Me.insuranceLbl.Size = New System.Drawing.Size(101, 13)
        Me.insuranceLbl.TabIndex = 7
        Me.insuranceLbl.Text = "Insurance Payment:"
        '
        'oilChangeLbl
        '
        Me.oilChangeLbl.AutoSize = True
        Me.oilChangeLbl.Location = New System.Drawing.Point(12, 92)
        Me.oilChangeLbl.Name = "oilChangeLbl"
        Me.oilChangeLbl.Size = New System.Drawing.Size(62, 13)
        Me.oilChangeLbl.TabIndex = 8
        Me.oilChangeLbl.Text = "Oil Change:"
        '
        'maintenanceLbl
        '
        Me.maintenanceLbl.AutoSize = True
        Me.maintenanceLbl.Location = New System.Drawing.Point(12, 134)
        Me.maintenanceLbl.Name = "maintenanceLbl"
        Me.maintenanceLbl.Size = New System.Drawing.Size(72, 13)
        Me.maintenanceLbl.TabIndex = 9
        Me.maintenanceLbl.Text = "Maintenance:"
        '
        'carWashLbl
        '
        Me.carWashLbl.AutoSize = True
        Me.carWashLbl.Location = New System.Drawing.Point(12, 172)
        Me.carWashLbl.Name = "carWashLbl"
        Me.carWashLbl.Size = New System.Drawing.Size(68, 13)
        Me.carWashLbl.TabIndex = 10
        Me.carWashLbl.Text = "Car Washes:"
        '
        'gasLbl
        '
        Me.gasLbl.AutoSize = True
        Me.gasLbl.Location = New System.Drawing.Point(12, 212)
        Me.gasLbl.Name = "gasLbl"
        Me.gasLbl.Size = New System.Drawing.Size(29, 13)
        Me.gasLbl.TabIndex = 11
        Me.gasLbl.Text = "Gas:"
        '
        'monthlyCostOut
        '
        Me.monthlyCostOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.monthlyCostOut.Location = New System.Drawing.Point(15, 301)
        Me.monthlyCostOut.Name = "monthlyCostOut"
        Me.monthlyCostOut.Size = New System.Drawing.Size(93, 35)
        Me.monthlyCostOut.TabIndex = 12
        '
        'calcBtn
        '
        Me.calcBtn.Location = New System.Drawing.Point(144, 250)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(75, 23)
        Me.calcBtn.TabIndex = 13
        Me.calcBtn.Text = "Calculate"
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'yearlyCostOut
        '
        Me.yearlyCostOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.yearlyCostOut.Location = New System.Drawing.Point(119, 301)
        Me.yearlyCostOut.Name = "yearlyCostOut"
        Me.yearlyCostOut.Size = New System.Drawing.Size(86, 35)
        Me.yearlyCostOut.TabIndex = 14
        '
        'monthCostLbl
        '
        Me.monthCostLbl.AutoSize = True
        Me.monthCostLbl.Location = New System.Drawing.Point(12, 288)
        Me.monthCostLbl.Name = "monthCostLbl"
        Me.monthCostLbl.Size = New System.Drawing.Size(71, 13)
        Me.monthCostLbl.TabIndex = 15
        Me.monthCostLbl.Text = "Monthly Cost:"
        '
        'yearlyCostLbl
        '
        Me.yearlyCostLbl.AutoSize = True
        Me.yearlyCostLbl.Location = New System.Drawing.Point(116, 288)
        Me.yearlyCostLbl.Name = "yearlyCostLbl"
        Me.yearlyCostLbl.Size = New System.Drawing.Size(63, 13)
        Me.yearlyCostLbl.TabIndex = 16
        Me.yearlyCostLbl.Text = "Yearly Cost:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 375)
        Me.Controls.Add(Me.yearlyCostLbl)
        Me.Controls.Add(Me.monthCostLbl)
        Me.Controls.Add(Me.yearlyCostOut)
        Me.Controls.Add(Me.calcBtn)
        Me.Controls.Add(Me.monthlyCostOut)
        Me.Controls.Add(Me.gasLbl)
        Me.Controls.Add(Me.carWashLbl)
        Me.Controls.Add(Me.maintenanceLbl)
        Me.Controls.Add(Me.oilChangeLbl)
        Me.Controls.Add(Me.insuranceLbl)
        Me.Controls.Add(Me.loanPaymentLbl)
        Me.Controls.Add(Me.gasTxt)
        Me.Controls.Add(Me.carWashTxt)
        Me.Controls.Add(Me.maintenanceTxt)
        Me.Controls.Add(Me.oilChangeTxt)
        Me.Controls.Add(Me.insurancePaymentTxt)
        Me.Controls.Add(Me.loanPaymentTxt)
        Me.Name = "frmMain"
        Me.Text = "Monthly Car Expenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loanPaymentTxt As System.Windows.Forms.TextBox
    Friend WithEvents insurancePaymentTxt As System.Windows.Forms.TextBox
    Friend WithEvents oilChangeTxt As System.Windows.Forms.TextBox
    Friend WithEvents maintenanceTxt As System.Windows.Forms.TextBox
    Friend WithEvents carWashTxt As System.Windows.Forms.TextBox
    Friend WithEvents gasTxt As System.Windows.Forms.TextBox
    Friend WithEvents loanPaymentLbl As System.Windows.Forms.Label
    Friend WithEvents insuranceLbl As System.Windows.Forms.Label
    Friend WithEvents oilChangeLbl As System.Windows.Forms.Label
    Friend WithEvents maintenanceLbl As System.Windows.Forms.Label
    Friend WithEvents carWashLbl As System.Windows.Forms.Label
    Friend WithEvents gasLbl As System.Windows.Forms.Label
    Friend WithEvents monthlyCostOut As System.Windows.Forms.Label
    Friend WithEvents calcBtn As System.Windows.Forms.Button
    Friend WithEvents yearlyCostOut As System.Windows.Forms.Label
    Friend WithEvents monthCostLbl As System.Windows.Forms.Label
    Friend WithEvents yearlyCostLbl As System.Windows.Forms.Label

End Class
