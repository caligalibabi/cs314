<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lblEuroTxt = New System.Windows.Forms.Label()
        Me.lblFrancText = New System.Windows.Forms.Label()
        Me.lblRandTxt = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.lblFranc = New System.Windows.Forms.Label()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.lblDollarTxt = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtUsd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblEuroTxt
        '
        Me.lblEuroTxt.AutoSize = True
        Me.lblEuroTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEuroTxt.Location = New System.Drawing.Point(14, 110)
        Me.lblEuroTxt.Name = "lblEuroTxt"
        Me.lblEuroTxt.Size = New System.Drawing.Size(39, 16)
        Me.lblEuroTxt.TabIndex = 0
        Me.lblEuroTxt.Text = "&Euro:"
        '
        'lblFrancText
        '
        Me.lblFrancText.AutoSize = True
        Me.lblFrancText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrancText.Location = New System.Drawing.Point(186, 110)
        Me.lblFrancText.Name = "lblFrancText"
        Me.lblFrancText.Size = New System.Drawing.Size(78, 16)
        Me.lblFrancText.TabIndex = 1
        Me.lblFrancText.Text = "Swiss &franc:"
        '
        'lblRandTxt
        '
        Me.lblRandTxt.AutoSize = True
        Me.lblRandTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandTxt.Location = New System.Drawing.Point(349, 110)
        Me.lblRandTxt.Name = "lblRandTxt"
        Me.lblRandTxt.Size = New System.Drawing.Size(119, 16)
        Me.lblRandTxt.TabIndex = 2
        Me.lblRandTxt.Text = "South African &rand:"
        '
        'lblEuro
        '
        Me.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuro.Location = New System.Drawing.Point(17, 126)
        Me.lblEuro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(147, 27)
        Me.lblEuro.TabIndex = 8
        Me.lblEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFranc
        '
        Me.lblFranc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFranc.Location = New System.Drawing.Point(189, 126)
        Me.lblFranc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFranc.Name = "lblFranc"
        Me.lblFranc.Size = New System.Drawing.Size(147, 27)
        Me.lblFranc.TabIndex = 9
        Me.lblFranc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRand
        '
        Me.lblRand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRand.Location = New System.Drawing.Point(352, 126)
        Me.lblRand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(147, 27)
        Me.lblRand.TabIndex = 10
        Me.lblRand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDollarTxt
        '
        Me.lblDollarTxt.AutoSize = True
        Me.lblDollarTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollarTxt.Location = New System.Drawing.Point(14, 46)
        Me.lblDollarTxt.Name = "lblDollarTxt"
        Me.lblDollarTxt.Size = New System.Drawing.Size(105, 16)
        Me.lblDollarTxt.TabIndex = 11
        Me.lblDollarTxt.Text = "American &dollar:"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(189, 50)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(115, 35)
        Me.btnConvert.TabIndex = 13
        Me.btnConvert.Text = "&Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(352, 50)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 35)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtUsd
        '
        Me.txtUsd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsd.Location = New System.Drawing.Point(17, 65)
        Me.txtUsd.Name = "txtUsd"
        Me.txtUsd.Size = New System.Drawing.Size(100, 20)
        Me.txtUsd.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 180)
        Me.Controls.Add(Me.txtUsd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblDollarTxt)
        Me.Controls.Add(Me.lblRand)
        Me.Controls.Add(Me.lblFranc)
        Me.Controls.Add(Me.lblEuro)
        Me.Controls.Add(Me.lblRandTxt)
        Me.Controls.Add(Me.lblFrancText)
        Me.Controls.Add(Me.lblEuroTxt)
        Me.Name = "Form1"
        Me.Text = "Currency Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEuroTxt As System.Windows.Forms.Label
    Friend WithEvents lblFrancText As System.Windows.Forms.Label
    Friend WithEvents lblRandTxt As System.Windows.Forms.Label
    Friend WithEvents lblEuro As System.Windows.Forms.Label
    Friend WithEvents lblFranc As System.Windows.Forms.Label
    Friend WithEvents lblRand As System.Windows.Forms.Label
    Friend WithEvents lblDollarTxt As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtUsd As System.Windows.Forms.TextBox

End Class
