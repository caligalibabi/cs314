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
        Me.lblAmountOwed = New System.Windows.Forms.Label()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.txtAmountOwed = New System.Windows.Forms.TextBox()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAmountOwed
        '
        Me.lblAmountOwed.AutoSize = True
        Me.lblAmountOwed.Location = New System.Drawing.Point(21, 51)
        Me.lblAmountOwed.Name = "lblAmountOwed"
        Me.lblAmountOwed.Size = New System.Drawing.Size(77, 13)
        Me.lblAmountOwed.TabIndex = 0
        Me.lblAmountOwed.Text = "Amount Owed:"
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.Location = New System.Drawing.Point(21, 86)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(70, 13)
        Me.lblAmountPaid.TabIndex = 1
        Me.lblAmountPaid.Text = "Amount Paid:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(21, 114)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(47, 13)
        Me.lblChange.TabIndex = 2
        Me.lblChange.Text = "Change:"
        '
        'txtAmountOwed
        '
        Me.txtAmountOwed.Location = New System.Drawing.Point(104, 51)
        Me.txtAmountOwed.Name = "txtAmountOwed"
        Me.txtAmountOwed.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountOwed.TabIndex = 3
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Location = New System.Drawing.Point(104, 83)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(100, 20)
        Me.txtAmountPaid.TabIndex = 4
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(104, 114)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(100, 20)
        Me.txtChange.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 86)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 171)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.txtAmountPaid)
        Me.Controls.Add(Me.txtAmountOwed)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblAmountPaid)
        Me.Controls.Add(Me.lblAmountOwed)
        Me.Name = "Form1"
        Me.Text = "Change Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAmountOwed As System.Windows.Forms.Label
    Friend WithEvents lblAmountPaid As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents txtAmountOwed As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountPaid As System.Windows.Forms.TextBox
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
