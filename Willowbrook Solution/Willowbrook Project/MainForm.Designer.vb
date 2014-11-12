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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtBasicFee = New System.Windows.Forms.TextBox()
        Me.lblBasicFee = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.lblAdditional = New System.Windows.Forms.Label()
        Me.lblMonthlyDues = New System.Windows.Forms.Label()
        Me.chkGolf = New System.Windows.Forms.CheckBox()
        Me.chkTennis = New System.Windows.Forms.CheckBox()
        Me.chkRacquetball = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 226)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(146, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtBasicFee
        '
        Me.txtBasicFee.Location = New System.Drawing.Point(23, 37)
        Me.txtBasicFee.Name = "txtBasicFee"
        Me.txtBasicFee.Size = New System.Drawing.Size(100, 20)
        Me.txtBasicFee.TabIndex = 2
        '
        'lblBasicFee
        '
        Me.lblBasicFee.AutoSize = True
        Me.lblBasicFee.Location = New System.Drawing.Point(23, 18)
        Me.lblBasicFee.Name = "lblBasicFee"
        Me.lblBasicFee.Size = New System.Drawing.Size(57, 13)
        Me.lblBasicFee.TabIndex = 3
        Me.lblBasicFee.Text = "Basic Fee:"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Location = New System.Drawing.Point(23, 83)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(56, 13)
        Me.lblAdd.TabIndex = 4
        Me.lblAdd.Text = "Additional:"
        '
        'lblMonthly
        '
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.Location = New System.Drawing.Point(23, 140)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(75, 13)
        Me.lblMonthly.TabIndex = 5
        Me.lblMonthly.Text = "Monthly Dues:"
        '
        'lblAdditional
        '

        Me.lblAdditional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdditional.Location = New System.Drawing.Point(23, 106)
        Me.lblAdditional.Name = "lblAdditional"
        Me.lblAdditional.Size = New System.Drawing.Size(41, 15)
        Me.lblAdditional.TabIndex = 6
        Me.lblAdditional.Text = ""
        '
        'lblMonthlyDues
        '
        Me.lblMonthlyDues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyDues.Location = New System.Drawing.Point(23, 165)
        Me.lblMonthlyDues.Name = "lblMonthlyDues"
        Me.lblMonthlyDues.Size = New System.Drawing.Size(41, 15)
        Me.lblMonthlyDues.TabIndex = 7
        Me.lblMonthlyDues.Text = ""
        '
        'chkGolf
        '
        Me.chkGolf.AutoSize = True
        Me.chkGolf.Location = New System.Drawing.Point(146, 83)
        Me.chkGolf.Name = "chkGolf"
        Me.chkGolf.Size = New System.Drawing.Size(45, 17)
        Me.chkGolf.TabIndex = 11
        Me.chkGolf.Text = "Golf"
        Me.chkGolf.UseVisualStyleBackColor = True
        '
        'chkTennis
        '
        Me.chkTennis.AutoSize = True
        Me.chkTennis.Location = New System.Drawing.Point(146, 106)
        Me.chkTennis.Name = "chkTennis"
        Me.chkTennis.Size = New System.Drawing.Size(58, 17)
        Me.chkTennis.TabIndex = 12
        Me.chkTennis.Text = "Tennis"
        Me.chkTennis.UseVisualStyleBackColor = True
        '
        'chkRacquetball
        '
        Me.chkRacquetball.AutoSize = True
        Me.chkRacquetball.Location = New System.Drawing.Point(146, 136)
        Me.chkRacquetball.Name = "chkRacquetball"
        Me.chkRacquetball.Size = New System.Drawing.Size(83, 17)
        Me.chkRacquetball.TabIndex = 13
        Me.chkRacquetball.Text = "Racquetball"
        Me.chkRacquetball.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.chkRacquetball)
        Me.Controls.Add(Me.chkTennis)
        Me.Controls.Add(Me.chkGolf)
        Me.Controls.Add(Me.lblMonthlyDues)
        Me.Controls.Add(Me.lblAdditional)
        Me.Controls.Add(Me.lblMonthly)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblBasicFee)
        Me.Controls.Add(Me.txtBasicFee)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtBasicFee As System.Windows.Forms.TextBox
    Friend WithEvents lblBasicFee As System.Windows.Forms.Label
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblMonthly As System.Windows.Forms.Label
    Friend WithEvents lblAdditional As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyDues As System.Windows.Forms.Label
    Friend WithEvents chkGolf As System.Windows.Forms.CheckBox
    Friend WithEvents chkTennis As System.Windows.Forms.CheckBox
    Friend WithEvents chkRacquetball As System.Windows.Forms.CheckBox

End Class
