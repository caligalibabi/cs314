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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDoughnutChoice = New System.Windows.Forms.Label()
        Me.radioGlazed = New System.Windows.Forms.RadioButton()
        Me.radioSugar = New System.Windows.Forms.RadioButton()
        Me.radioChocolate = New System.Windows.Forms.RadioButton()
        Me.radioFilled = New System.Windows.Forms.RadioButton()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.subTotalOut = New System.Windows.Forms.Label()
        Me.salesTaxOut = New System.Windows.Forms.Label()
        Me.totalDueOut = New System.Windows.Forms.Label()
        Me.radioCappuccino = New System.Windows.Forms.RadioButton()
        Me.radioRegular = New System.Windows.Forms.RadioButton()
        Me.radioNone = New System.Windows.Forms.RadioButton()
        Me.lblCoffeeChoice = New System.Windows.Forms.Label()
        Me.grpBoxCoffee = New System.Windows.Forms.GroupBox()
        Me.grpBoxDoughnut = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxCoffee.SuspendLayout()
        Me.grpBoxDoughnut.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Sweet_Life_Project.My.Resources.Resources.DonutCoffee
        Me.PictureBox1.Location = New System.Drawing.Point(130, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblDoughnutChoice
        '
        Me.lblDoughnutChoice.AutoSize = True
        Me.lblDoughnutChoice.Location = New System.Drawing.Point(5, 8)
        Me.lblDoughnutChoice.Name = "lblDoughnutChoice"
        Me.lblDoughnutChoice.Size = New System.Drawing.Size(94, 13)
        Me.lblDoughnutChoice.TabIndex = 1
        Me.lblDoughnutChoice.Text = "Doughnut choices"
        '
        'radioGlazed
        '
        Me.radioGlazed.AutoSize = True
        Me.radioGlazed.Location = New System.Drawing.Point(12, 24)
        Me.radioGlazed.Name = "radioGlazed"
        Me.radioGlazed.Size = New System.Drawing.Size(58, 17)
        Me.radioGlazed.TabIndex = 3
        Me.radioGlazed.TabStop = True
        Me.radioGlazed.Text = "&Glazed"
        Me.radioGlazed.UseVisualStyleBackColor = True
        '
        'radioSugar
        '
        Me.radioSugar.AutoSize = True
        Me.radioSugar.Location = New System.Drawing.Point(12, 47)
        Me.radioSugar.Name = "radioSugar"
        Me.radioSugar.Size = New System.Drawing.Size(53, 17)
        Me.radioSugar.TabIndex = 4
        Me.radioSugar.TabStop = True
        Me.radioSugar.Text = "&Sugar"
        Me.radioSugar.UseVisualStyleBackColor = True
        '
        'radioChocolate
        '
        Me.radioChocolate.AutoSize = True
        Me.radioChocolate.Location = New System.Drawing.Point(12, 70)
        Me.radioChocolate.Name = "radioChocolate"
        Me.radioChocolate.Size = New System.Drawing.Size(73, 17)
        Me.radioChocolate.TabIndex = 5
        Me.radioChocolate.TabStop = True
        Me.radioChocolate.Text = "C&hocolate"
        Me.radioChocolate.UseVisualStyleBackColor = True
        '
        'radioFilled
        '
        Me.radioFilled.AutoSize = True
        Me.radioFilled.Location = New System.Drawing.Point(12, 93)
        Me.radioFilled.Name = "radioFilled"
        Me.radioFilled.Size = New System.Drawing.Size(49, 17)
        Me.radioFilled.TabIndex = 6
        Me.radioFilled.TabStop = True
        Me.radioFilled.Text = "&Filled"
        Me.radioFilled.UseVisualStyleBackColor = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Location = New System.Drawing.Point(161, 150)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubTotal.TabIndex = 10
        Me.lblSubTotal.Text = "Subtotal:"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(161, 167)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(57, 13)
        Me.lblSalesTax.TabIndex = 11
        Me.lblSalesTax.Text = "Sales Tax:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Location = New System.Drawing.Point(161, 187)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(57, 13)
        Me.lblTotalDue.TabIndex = 12
        Me.lblTotalDue.Text = "Total Due:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(130, 216)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 13
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(211, 216)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'subTotalOut
        '
        Me.subTotalOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subTotalOut.Location = New System.Drawing.Point(236, 149)
        Me.subTotalOut.Name = "subTotalOut"
        Me.subTotalOut.Size = New System.Drawing.Size(50, 15)
        Me.subTotalOut.TabIndex = 15
        Me.subTotalOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'salesTaxOut
        '
        Me.salesTaxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.salesTaxOut.Location = New System.Drawing.Point(236, 167)
        Me.salesTaxOut.Name = "salesTaxOut"
        Me.salesTaxOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.salesTaxOut.Size = New System.Drawing.Size(50, 15)
        Me.salesTaxOut.TabIndex = 16
        Me.salesTaxOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalDueOut
        '
        Me.totalDueOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalDueOut.Location = New System.Drawing.Point(236, 187)
        Me.totalDueOut.Name = "totalDueOut"
        Me.totalDueOut.Size = New System.Drawing.Size(50, 15)
        Me.totalDueOut.TabIndex = 17
        Me.totalDueOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radioCappuccino
        '
        Me.radioCappuccino.AutoSize = True
        Me.radioCappuccino.Location = New System.Drawing.Point(13, 72)
        Me.radioCappuccino.Name = "radioCappuccino"
        Me.radioCappuccino.Size = New System.Drawing.Size(82, 17)
        Me.radioCappuccino.TabIndex = 9
        Me.radioCappuccino.TabStop = True
        Me.radioCappuccino.Text = "Ca&ppuccino"
        Me.radioCappuccino.UseVisualStyleBackColor = True
        '
        'radioRegular
        '
        Me.radioRegular.AutoSize = True
        Me.radioRegular.Location = New System.Drawing.Point(13, 49)
        Me.radioRegular.Name = "radioRegular"
        Me.radioRegular.Size = New System.Drawing.Size(62, 17)
        Me.radioRegular.TabIndex = 8
        Me.radioRegular.TabStop = True
        Me.radioRegular.Text = "&Regular"
        Me.radioRegular.UseVisualStyleBackColor = True
        '
        'radioNone
        '
        Me.radioNone.AutoSize = True
        Me.radioNone.Location = New System.Drawing.Point(13, 26)
        Me.radioNone.Name = "radioNone"
        Me.radioNone.Size = New System.Drawing.Size(51, 17)
        Me.radioNone.TabIndex = 7
        Me.radioNone.TabStop = True
        Me.radioNone.Text = "&None"
        Me.radioNone.UseVisualStyleBackColor = True
        '
        'lblCoffeeChoice
        '
        Me.lblCoffeeChoice.AutoSize = True
        Me.lblCoffeeChoice.Location = New System.Drawing.Point(6, 10)
        Me.lblCoffeeChoice.Name = "lblCoffeeChoice"
        Me.lblCoffeeChoice.Size = New System.Drawing.Size(78, 13)
        Me.lblCoffeeChoice.TabIndex = 2
        Me.lblCoffeeChoice.Text = "Coffee choices"
        '
        'grpBoxCoffee
        '
        Me.grpBoxCoffee.Controls.Add(Me.radioCappuccino)
        Me.grpBoxCoffee.Controls.Add(Me.radioRegular)
        Me.grpBoxCoffee.Controls.Add(Me.radioNone)
        Me.grpBoxCoffee.Controls.Add(Me.lblCoffeeChoice)
        Me.grpBoxCoffee.Location = New System.Drawing.Point(6, 136)
        Me.grpBoxCoffee.Name = "grpBoxCoffee"
        Me.grpBoxCoffee.Size = New System.Drawing.Size(109, 103)
        Me.grpBoxCoffee.TabIndex = 18
        Me.grpBoxCoffee.TabStop = False
        '
        'grpBoxDoughnut
        '
        Me.grpBoxDoughnut.Controls.Add(Me.radioFilled)
        Me.grpBoxDoughnut.Controls.Add(Me.radioChocolate)
        Me.grpBoxDoughnut.Controls.Add(Me.radioSugar)
        Me.grpBoxDoughnut.Controls.Add(Me.radioGlazed)
        Me.grpBoxDoughnut.Controls.Add(Me.lblDoughnutChoice)
        Me.grpBoxDoughnut.Location = New System.Drawing.Point(7, 5)
        Me.grpBoxDoughnut.Name = "grpBoxDoughnut"
        Me.grpBoxDoughnut.Size = New System.Drawing.Size(108, 130)
        Me.grpBoxDoughnut.TabIndex = 19
        Me.grpBoxDoughnut.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 423)
        Me.Controls.Add(Me.grpBoxDoughnut)
        Me.Controls.Add(Me.grpBoxCoffee)
        Me.Controls.Add(Me.totalDueOut)
        Me.Controls.Add(Me.salesTaxOut)
        Me.Controls.Add(Me.subTotalOut)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMain"
        Me.Text = "Sweet Life Shoppe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxCoffee.ResumeLayout(False)
        Me.grpBoxCoffee.PerformLayout()
        Me.grpBoxDoughnut.ResumeLayout(False)
        Me.grpBoxDoughnut.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDoughnutChoice As System.Windows.Forms.Label
    Friend WithEvents radioGlazed As System.Windows.Forms.RadioButton
    Friend WithEvents radioSugar As System.Windows.Forms.RadioButton
    Friend WithEvents radioChocolate As System.Windows.Forms.RadioButton
    Friend WithEvents radioFilled As System.Windows.Forms.RadioButton
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblSalesTax As System.Windows.Forms.Label
    Friend WithEvents lblTotalDue As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents subTotalOut As System.Windows.Forms.Label
    Friend WithEvents salesTaxOut As System.Windows.Forms.Label
    Friend WithEvents totalDueOut As System.Windows.Forms.Label
    Friend WithEvents radioCappuccino As System.Windows.Forms.RadioButton
    Friend WithEvents radioRegular As System.Windows.Forms.RadioButton
    Friend WithEvents radioNone As System.Windows.Forms.RadioButton
    Friend WithEvents lblCoffeeChoice As System.Windows.Forms.Label
    Friend WithEvents grpBoxCoffee As System.Windows.Forms.GroupBox
    Friend WithEvents grpBoxDoughnut As System.Windows.Forms.GroupBox

End Class
