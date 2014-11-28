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
        Me.txtIdInput = New System.Windows.Forms.TextBox()
        Me.txtNumSoldInput = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNumSold = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFullTimeOut = New System.Windows.Forms.Label()
        Me.lblPartTimeOut = New System.Windows.Forms.Label()
        Me.lblNewCarsOut = New System.Windows.Forms.Label()
        Me.lblUsedCarsOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(116, 58)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 58)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtIdInput
        '
        Me.txtIdInput.Location = New System.Drawing.Point(116, 32)
        Me.txtIdInput.Name = "txtIdInput"
        Me.txtIdInput.Size = New System.Drawing.Size(74, 20)
        Me.txtIdInput.TabIndex = 2
        '
        'txtNumSoldInput
        '
        Me.txtNumSoldInput.Location = New System.Drawing.Point(197, 32)
        Me.txtNumSoldInput.Name = "txtNumSoldInput"
        Me.txtNumSoldInput.Size = New System.Drawing.Size(75, 20)
        Me.txtNumSoldInput.TabIndex = 3
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(116, 13)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(21, 13)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = "ID:"
        '
        'lblNumSold
        '
        Me.lblNumSold.AutoSize = True
        Me.lblNumSold.Location = New System.Drawing.Point(194, 13)
        Me.lblNumSold.Name = "lblNumSold"
        Me.lblNumSold.Size = New System.Drawing.Size(69, 13)
        Me.lblNumSold.TabIndex = 5
        Me.lblNumSold.Text = "&Number sold:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cars sold by full-time employees:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cars sold by part-time employees:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cars sold by new car employees:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cars sold by used car employees:"
        '
        'lblFullTimeOut
        '

        Me.lblFullTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullTimeOut.Location = New System.Drawing.Point(188, 131)
        Me.lblFullTimeOut.Name = "lblFullTimeOut"
        Me.lblFullTimeOut.Size = New System.Drawing.Size(41, 15)
        Me.lblFullTimeOut.TabIndex = 10

        '
        'lblPartTimeOut
       
        Me.lblPartTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPartTimeOut.Location = New System.Drawing.Point(188, 161)
        Me.lblPartTimeOut.Name = "lblPartTimeOut"
        Me.lblPartTimeOut.Size = New System.Drawing.Size(41, 15)
        Me.lblPartTimeOut.TabIndex = 11

        '
        'lblNewCarsOut
        '

        Me.lblNewCarsOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNewCarsOut.Location = New System.Drawing.Point(188, 192)
        Me.lblNewCarsOut.Name = "lblNewCarsOut"
        Me.lblNewCarsOut.Size = New System.Drawing.Size(41, 15)
        Me.lblNewCarsOut.TabIndex = 12

        '
        'lblUsedCarsOut
        '

        Me.lblUsedCarsOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUsedCarsOut.Location = New System.Drawing.Point(188, 226)
        Me.lblUsedCarsOut.Name = "lblUsedCarsOut"
        Me.lblUsedCarsOut.Size = New System.Drawing.Size(41, 15)
        Me.lblUsedCarsOut.TabIndex = 13

        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblUsedCarsOut)
        Me.Controls.Add(Me.lblNewCarsOut)
        Me.Controls.Add(Me.lblPartTimeOut)
        Me.Controls.Add(Me.lblFullTimeOut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNumSold)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtNumSoldInput)
        Me.Controls.Add(Me.txtIdInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "frmMain"
        Me.Text = "Huntington Motors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtIdInput As System.Windows.Forms.TextBox
    Friend WithEvents txtNumSoldInput As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblNumSold As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFullTimeOut As System.Windows.Forms.Label
    Friend WithEvents lblPartTimeOut As System.Windows.Forms.Label
    Friend WithEvents lblNewCarsOut As System.Windows.Forms.Label
    Friend WithEvents lblUsedCarsOut As System.Windows.Forms.Label

End Class
