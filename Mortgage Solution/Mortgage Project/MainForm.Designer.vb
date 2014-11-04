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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.grossIncomeTxt = New System.Windows.Forms.Label()
        Me.grossIncomeInput = New System.Windows.Forms.TextBox()
        Me.mortgageRangeTxt = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lowRangeOutput = New System.Windows.Forms.TextBox()
        Me.highRangeOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(228, 101)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'grossIncomeTxt
        '
        Me.grossIncomeTxt.AutoSize = True
        Me.grossIncomeTxt.Location = New System.Drawing.Point(12, 105)
        Me.grossIncomeTxt.Name = "grossIncomeTxt"
        Me.grossIncomeTxt.Size = New System.Drawing.Size(75, 13)
        Me.grossIncomeTxt.TabIndex = 1
        Me.grossIncomeTxt.Text = "Gross Income:"
        '
        'grossIncomeInput
        '
        Me.grossIncomeInput.Location = New System.Drawing.Point(93, 104)
        Me.grossIncomeInput.Name = "grossIncomeInput"
        Me.grossIncomeInput.Size = New System.Drawing.Size(100, 20)
        Me.grossIncomeInput.TabIndex = 2
        '
        'mortgageRangeTxt
        '
        Me.mortgageRangeTxt.AutoSize = True
        Me.mortgageRangeTxt.Location = New System.Drawing.Point(12, 146)
        Me.mortgageRangeTxt.Name = "mortgageRangeTxt"
        Me.mortgageRangeTxt.Size = New System.Drawing.Size(90, 13)
        Me.mortgageRangeTxt.TabIndex = 3
        Me.mortgageRangeTxt.Text = "Mortgage Range:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(191, 150)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(16, 13)
        Me.lblTo.TabIndex = 4
        Me.lblTo.Text = "to"
        '
        'lowRangeOutput
        '
        Me.lowRangeOutput.Location = New System.Drawing.Point(108, 143)
        Me.lowRangeOutput.Name = "lowRangeOutput"
        Me.lowRangeOutput.Size = New System.Drawing.Size(77, 20)
        Me.lowRangeOutput.TabIndex = 5
        '
        'highRangeOutput
        '
        Me.highRangeOutput.Location = New System.Drawing.Point(213, 143)
        Me.highRangeOutput.Name = "highRangeOutput"
        Me.highRangeOutput.Size = New System.Drawing.Size(90, 20)
        Me.highRangeOutput.TabIndex = 6
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 268)
        Me.Controls.Add(Me.highRangeOutput)
        Me.Controls.Add(Me.lowRangeOutput)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.mortgageRangeTxt)
        Me.Controls.Add(Me.grossIncomeInput)
        Me.Controls.Add(Me.grossIncomeTxt)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmMain"
        Me.Text = "Mortgage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents grossIncomeTxt As System.Windows.Forms.Label
    Friend WithEvents grossIncomeInput As System.Windows.Forms.TextBox
    Friend WithEvents mortgageRangeTxt As System.Windows.Forms.Label
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lowRangeOutput As System.Windows.Forms.TextBox
    Friend WithEvents highRangeOutput As System.Windows.Forms.TextBox

End Class
