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
        Me.btnRanNum = New System.Windows.Forms.Button()
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'btnRanNum
        '
        Me.btnRanNum.Location = New System.Drawing.Point(26, 12)
        Me.btnRanNum.Name = "btnRanNum"
        Me.btnRanNum.Size = New System.Drawing.Size(204, 23)
        Me.btnRanNum.TabIndex = 0
        Me.btnRanNum.Text = "Generate a Random Number from 1 - 25"
        Me.btnRanNum.UseVisualStyleBackColor = True
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Location = New System.Drawing.Point(26, 86)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(40, 13)
        Me.lblGuess.TabIndex = 1
        Me.lblGuess.Text = "Guess:"
        '
        'txtGuess
        '
        Me.txtGuess.Location = New System.Drawing.Point(95, 79)
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(135, 20)
        Me.txtGuess.TabIndex = 2
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(26, 141)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(154, 140)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 185)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.btnRanNum)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnRanNum As System.Windows.Forms.Button
    Friend WithEvents lblGuess As System.Windows.Forms.Label
    Friend WithEvents txtGuess As System.Windows.Forms.TextBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
