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
        Me.radBusiness = New System.Windows.Forms.RadioButton()
        Me.radResidential = New System.Windows.Forms.RadioButton()
        Me.lblPremChannels = New System.Windows.Forms.Label()
        Me.lblConnections = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.totalDueOut = New System.Windows.Forms.Label()
        Me.lstPremium = New System.Windows.Forms.ListBox()
        Me.lstConnections = New System.Windows.Forms.ListBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'radBusiness
        '
        Me.radBusiness.AutoSize = true
        Me.radBusiness.Location = New System.Drawing.Point(32, 26)
        Me.radBusiness.Name = "radBusiness"
        Me.radBusiness.Size = New System.Drawing.Size(67, 17)
        Me.radBusiness.TabIndex = 0
        Me.radBusiness.TabStop = true
        Me.radBusiness.Text = "&Business"
        Me.radBusiness.UseVisualStyleBackColor = true
        '
        'radResidential
        '
        Me.radResidential.AutoSize = true
        Me.radResidential.Location = New System.Drawing.Point(32, 50)
        Me.radResidential.Name = "radResidential"
        Me.radResidential.Size = New System.Drawing.Size(77, 17)
        Me.radResidential.TabIndex = 1
        Me.radResidential.TabStop = true
        Me.radResidential.Text = "&Residential"
        Me.radResidential.UseVisualStyleBackColor = true
        '
        'lblPremChannels
        '
        Me.lblPremChannels.AutoSize = true
        Me.lblPremChannels.Location = New System.Drawing.Point(143, 26)
        Me.lblPremChannels.Name = "lblPremChannels"
        Me.lblPremChannels.Size = New System.Drawing.Size(97, 13)
        Me.lblPremChannels.TabIndex = 2
        Me.lblPremChannels.Text = "&Premium Channels:"
        '
        'lblConnections
        '
        Me.lblConnections.AutoSize = true
        Me.lblConnections.Location = New System.Drawing.Point(248, 26)
        Me.lblConnections.Name = "lblConnections"
        Me.lblConnections.Size = New System.Drawing.Size(69, 13)
        Me.lblConnections.TabIndex = 3
        Me.lblConnections.Text = "&Connections:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = true
        Me.lblTotal.Location = New System.Drawing.Point(29, 127)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(57, 13)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total Due:"
        '
        'totalDueOut
        '
        Me.totalDueOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalDueOut.Location = New System.Drawing.Point(32, 140)
        Me.totalDueOut.Name = "totalDueOut"
        Me.totalDueOut.Size = New System.Drawing.Size(87, 30)
        Me.totalDueOut.TabIndex = 5
        '
        'lstPremium
        '
        Me.lstPremium.FormattingEnabled = true
        Me.lstPremium.Location = New System.Drawing.Point(146, 50)
        Me.lstPremium.Name = "lstPremium"
        Me.lstPremium.Size = New System.Drawing.Size(81, 69)
        Me.lstPremium.TabIndex = 6
        '
        'lstConnections
        '
        Me.lstConnections.FormattingEnabled = true
        Me.lstConnections.Location = New System.Drawing.Point(251, 50)
        Me.lstConnections.Name = "lstConnections"
        Me.lstConnections.Size = New System.Drawing.Size(76, 69)
        Me.lstConnections.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(146, 136)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(96, 34)
        Me.btnCalc.TabIndex = 8
        Me.btnCalc.Text = "Calculate &Total"
        Me.btnCalc.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(251, 136)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 34)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 218)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lstConnections)
        Me.Controls.Add(Me.lstPremium)
        Me.Controls.Add(Me.totalDueOut)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblConnections)
        Me.Controls.Add(Me.lblPremChannels)
        Me.Controls.Add(Me.radResidential)
        Me.Controls.Add(Me.radBusiness)
        Me.Name = "frmMain"
        Me.Text = "Cable Direct"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents radBusiness As System.Windows.Forms.RadioButton
    Friend WithEvents radResidential As System.Windows.Forms.RadioButton
    Friend WithEvents lblPremChannels As System.Windows.Forms.Label
    Friend WithEvents lblConnections As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents totalDueOut As System.Windows.Forms.Label
    Friend WithEvents lstPremium As System.Windows.Forms.ListBox
    Friend WithEvents lstConnections As System.Windows.Forms.ListBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
