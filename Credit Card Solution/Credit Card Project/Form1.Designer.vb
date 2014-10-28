<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.merchTxt = New System.Windows.Forms.TextBox()
        Me.restaurantTxt = New System.Windows.Forms.TextBox()
        Me.gasTxt = New System.Windows.Forms.TextBox()
        Me.travelEntTxt = New System.Windows.Forms.TextBox()
        Me.servicesSuperTxt = New System.Windows.Forms.TextBox()
        Me.merchLbl = New System.Windows.Forms.Label()
        Me.restaurantLbl = New System.Windows.Forms.Label()
        Me.gasLbl = New System.Windows.Forms.Label()
        Me.travelEntLbl = New System.Windows.Forms.Label()
        Me.servicesAndSupermarkets = New System.Windows.Forms.Label()
        Me.monthlyCharges = New System.Windows.Forms.Label()
        Me.yearlyCharges = New System.Windows.Forms.Label()
        Me.percentLbl = New System.Windows.Forms.Label()
        Me.annualPercentMerch = New System.Windows.Forms.Label()
        Me.annualPercentRestaurant = New System.Windows.Forms.Label()
        Me.annualPercentGas = New System.Windows.Forms.Label()
        Me.annualPercentTravelEnt = New System.Windows.Forms.Label()
        Me.annualPercentServSuper = New System.Windows.Forms.Label()
        Me.totalMonthlyCostOut = New System.Windows.Forms.Label()
        Me.totalYearlyCostOut = New System.Windows.Forms.Label()
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'merchTxt
        '
        Me.merchTxt.Location = New System.Drawing.Point(176, 36)
        Me.merchTxt.Name = "merchTxt"
        Me.merchTxt.Size = New System.Drawing.Size(100, 20)
        Me.merchTxt.TabIndex = 0
        '
        'restaurantTxt
        '
        Me.restaurantTxt.Location = New System.Drawing.Point(176, 88)
        Me.restaurantTxt.Name = "restaurantTxt"
        Me.restaurantTxt.Size = New System.Drawing.Size(100, 20)
        Me.restaurantTxt.TabIndex = 1
        '
        'gasTxt
        '
        Me.gasTxt.Location = New System.Drawing.Point(176, 135)
        Me.gasTxt.Name = "gasTxt"
        Me.gasTxt.Size = New System.Drawing.Size(100, 20)
        Me.gasTxt.TabIndex = 2
        '
        'travelEntTxt
        '
        Me.travelEntTxt.Location = New System.Drawing.Point(176, 187)
        Me.travelEntTxt.Name = "travelEntTxt"
        Me.travelEntTxt.Size = New System.Drawing.Size(100, 20)
        Me.travelEntTxt.TabIndex = 3
        '
        'servicesSuperTxt
        '
        Me.servicesSuperTxt.Location = New System.Drawing.Point(176, 247)
        Me.servicesSuperTxt.Name = "servicesSuperTxt"
        Me.servicesSuperTxt.Size = New System.Drawing.Size(100, 20)
        Me.servicesSuperTxt.TabIndex = 4
        '
        'merchLbl
        '
        Me.merchLbl.AutoSize = True
        Me.merchLbl.Location = New System.Drawing.Point(23, 39)
        Me.merchLbl.Name = "merchLbl"
        Me.merchLbl.Size = New System.Drawing.Size(71, 13)
        Me.merchLbl.TabIndex = 6
        Me.merchLbl.Text = "Merchandise:"
        '
        'restaurantLbl
        '
        Me.restaurantLbl.AutoSize = True
        Me.restaurantLbl.Location = New System.Drawing.Point(23, 88)
        Me.restaurantLbl.Name = "restaurantLbl"
        Me.restaurantLbl.Size = New System.Drawing.Size(62, 13)
        Me.restaurantLbl.TabIndex = 7
        Me.restaurantLbl.Text = "Restaurant:"
        '
        'gasLbl
        '
        Me.gasLbl.AutoSize = True
        Me.gasLbl.Location = New System.Drawing.Point(23, 135)
        Me.gasLbl.Name = "gasLbl"
        Me.gasLbl.Size = New System.Drawing.Size(51, 13)
        Me.gasLbl.TabIndex = 8
        Me.gasLbl.Text = "Gasoline:"
        '
        'travelEntLbl
        '
        Me.travelEntLbl.AutoSize = True
        Me.travelEntLbl.Location = New System.Drawing.Point(23, 187)
        Me.travelEntLbl.Name = "travelEntLbl"
        Me.travelEntLbl.Size = New System.Drawing.Size(110, 13)
        Me.travelEntLbl.TabIndex = 9
        Me.travelEntLbl.Text = "Travel/Entertainment:"
        '
        'servicesAndSupermarkets
        '
        Me.servicesAndSupermarkets.AutoSize = True
        Me.servicesAndSupermarkets.Location = New System.Drawing.Point(23, 250)
        Me.servicesAndSupermarkets.Name = "servicesAndSupermarkets"
        Me.servicesAndSupermarkets.Size = New System.Drawing.Size(140, 13)
        Me.servicesAndSupermarkets.TabIndex = 10
        Me.servicesAndSupermarkets.Text = "Services and Supermarkets:"
        '
        'monthlyCharges
        '
        Me.monthlyCharges.AutoSize = True
        Me.monthlyCharges.Location = New System.Drawing.Point(26, 291)
        Me.monthlyCharges.Name = "monthlyCharges"
        Me.monthlyCharges.Size = New System.Drawing.Size(116, 13)
        Me.monthlyCharges.TabIndex = 11
        Me.monthlyCharges.Text = "Total Monthly Charges:"
        '
        'yearlyCharges
        '
        Me.yearlyCharges.AutoSize = True
        Me.yearlyCharges.Location = New System.Drawing.Point(173, 291)
        Me.yearlyCharges.Name = "yearlyCharges"
        Me.yearlyCharges.Size = New System.Drawing.Size(108, 13)
        Me.yearlyCharges.TabIndex = 12
        Me.yearlyCharges.Text = "Total Yearly Charges:"
        '
        'percentLbl
        '
        Me.percentLbl.AutoSize = True
        Me.percentLbl.Location = New System.Drawing.Point(302, 9)
        Me.percentLbl.Name = "percentLbl"
        Me.percentLbl.Size = New System.Drawing.Size(152, 13)
        Me.percentLbl.TabIndex = 13
        Me.percentLbl.Text = "As Percantage of Annual Cost:"
        '
        'annualPercentMerch
        '
        Me.annualPercentMerch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.annualPercentMerch.Location = New System.Drawing.Point(356, 36)
        Me.annualPercentMerch.Name = "annualPercentMerch"
        Me.annualPercentMerch.Size = New System.Drawing.Size(37, 15)
        Me.annualPercentMerch.TabIndex = 14
        '
        'annualPercentRestaurant
        '
        Me.annualPercentRestaurant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.annualPercentRestaurant.Location = New System.Drawing.Point(356, 93)
        Me.annualPercentRestaurant.Name = "annualPercentRestaurant"
        Me.annualPercentRestaurant.Size = New System.Drawing.Size(41, 15)
        Me.annualPercentRestaurant.TabIndex = 15
        '
        'annualPercentGas
        '
        Me.annualPercentGas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.annualPercentGas.Location = New System.Drawing.Point(356, 140)
        Me.annualPercentGas.Name = "annualPercentGas"
        Me.annualPercentGas.Size = New System.Drawing.Size(41, 15)
        Me.annualPercentGas.TabIndex = 16
        '
        'annualPercentTravelEnt
        '
        Me.annualPercentTravelEnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.annualPercentTravelEnt.Location = New System.Drawing.Point(356, 194)
        Me.annualPercentTravelEnt.Name = "annualPercentTravelEnt"
        Me.annualPercentTravelEnt.Size = New System.Drawing.Size(41, 15)
        Me.annualPercentTravelEnt.TabIndex = 17
        '
        'annualPercentServSuper
        '
        Me.annualPercentServSuper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.annualPercentServSuper.Location = New System.Drawing.Point(356, 254)
        Me.annualPercentServSuper.Name = "annualPercentServSuper"
        Me.annualPercentServSuper.Size = New System.Drawing.Size(41, 15)
        Me.annualPercentServSuper.TabIndex = 18
        '
        'totalMonthlyCostOut
        '
        Me.totalMonthlyCostOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalMonthlyCostOut.Location = New System.Drawing.Point(29, 316)
        Me.totalMonthlyCostOut.Name = "totalMonthlyCostOut"
        Me.totalMonthlyCostOut.Size = New System.Drawing.Size(104, 32)
        Me.totalMonthlyCostOut.TabIndex = 19
        Me.totalMonthlyCostOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalYearlyCostOut
        '
        Me.totalYearlyCostOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalYearlyCostOut.Location = New System.Drawing.Point(176, 316)
        Me.totalYearlyCostOut.Name = "totalYearlyCostOut"
        Me.totalYearlyCostOut.Size = New System.Drawing.Size(105, 32)
        Me.totalYearlyCostOut.TabIndex = 20
        Me.totalYearlyCostOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'calcBtn
        '
        Me.calcBtn.Location = New System.Drawing.Point(301, 316)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(96, 32)
        Me.calcBtn.TabIndex = 21
        Me.calcBtn.Text = "Calculate"
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 427)
        Me.Controls.Add(Me.calcBtn)
        Me.Controls.Add(Me.totalYearlyCostOut)
        Me.Controls.Add(Me.totalMonthlyCostOut)
        Me.Controls.Add(Me.annualPercentServSuper)
        Me.Controls.Add(Me.annualPercentTravelEnt)
        Me.Controls.Add(Me.annualPercentGas)
        Me.Controls.Add(Me.annualPercentRestaurant)
        Me.Controls.Add(Me.annualPercentMerch)
        Me.Controls.Add(Me.percentLbl)
        Me.Controls.Add(Me.yearlyCharges)
        Me.Controls.Add(Me.monthlyCharges)
        Me.Controls.Add(Me.servicesAndSupermarkets)
        Me.Controls.Add(Me.travelEntLbl)
        Me.Controls.Add(Me.gasLbl)
        Me.Controls.Add(Me.restaurantLbl)
        Me.Controls.Add(Me.merchLbl)
        Me.Controls.Add(Me.servicesSuperTxt)
        Me.Controls.Add(Me.travelEntTxt)
        Me.Controls.Add(Me.gasTxt)
        Me.Controls.Add(Me.restaurantTxt)
        Me.Controls.Add(Me.merchTxt)
        Me.Name = "Form1"
        Me.Text = "Monthly Credit Card Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents merchTxt As System.Windows.Forms.TextBox
    Friend WithEvents restaurantTxt As System.Windows.Forms.TextBox
    Friend WithEvents gasTxt As System.Windows.Forms.TextBox
    Friend WithEvents travelEntTxt As System.Windows.Forms.TextBox
    Friend WithEvents servicesSuperTxt As System.Windows.Forms.TextBox
    Friend WithEvents merchLbl As System.Windows.Forms.Label
    Friend WithEvents restaurantLbl As System.Windows.Forms.Label
    Friend WithEvents gasLbl As System.Windows.Forms.Label
    Friend WithEvents travelEntLbl As System.Windows.Forms.Label
    Friend WithEvents servicesAndSupermarkets As System.Windows.Forms.Label
    Friend WithEvents monthlyCharges As System.Windows.Forms.Label
    Friend WithEvents yearlyCharges As System.Windows.Forms.Label
    Friend WithEvents percentLbl As System.Windows.Forms.Label
    Friend WithEvents annualPercentMerch As System.Windows.Forms.Label
    Friend WithEvents annualPercentRestaurant As System.Windows.Forms.Label
    Friend WithEvents annualPercentGas As System.Windows.Forms.Label
    Friend WithEvents annualPercentTravelEnt As System.Windows.Forms.Label
    Friend WithEvents annualPercentServSuper As System.Windows.Forms.Label
    Friend WithEvents totalMonthlyCostOut As System.Windows.Forms.Label
    Friend WithEvents totalYearlyCostOut As System.Windows.Forms.Label
    Friend WithEvents calcBtn As System.Windows.Forms.Button

End Class
