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
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lstBoxScore = New System.Windows.Forms.ListBox()
        Me.lblTotalScore = New System.Windows.Forms.Label()
        Me.totalScoreOut = New System.Windows.Forms.Label()
        Me.lblNumberScores = New System.Windows.Forms.Label()
        Me.numScoresOut = New System.Windows.Forms.Label()
        Me.lblAverageScore = New System.Windows.Forms.Label()
        Me.avgScoreOut = New System.Windows.Forms.Label()
        Me.btnRecordScore = New System.Windows.Forms.Button()
        Me.btnNextSkater = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(13, 13)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(38, 13)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "&Score:"
        '
        'lstBoxScore
        '
        Me.lstBoxScore.FormattingEnabled = True
        Me.lstBoxScore.Location = New System.Drawing.Point(16, 40)
        Me.lstBoxScore.Name = "lstBoxScore"
        Me.lstBoxScore.Size = New System.Drawing.Size(69, 173)
        Me.lstBoxScore.TabIndex = 1
        '
        'lblTotalScore
        '
        Me.lblTotalScore.AutoSize = True
        Me.lblTotalScore.Location = New System.Drawing.Point(112, 77)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(65, 13)
        Me.lblTotalScore.TabIndex = 2
        Me.lblTotalScore.Text = "Total Score:"
        '
        'totalScoreOut
        '
        Me.totalScoreOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalScoreOut.Location = New System.Drawing.Point(115, 90)
        Me.totalScoreOut.Name = "totalScoreOut"
        Me.totalScoreOut.Size = New System.Drawing.Size(75, 20)
        Me.totalScoreOut.TabIndex = 3
        '
        'lblNumberScores
        '
        Me.lblNumberScores.AutoSize = True
        Me.lblNumberScores.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNumberScores.Location = New System.Drawing.Point(112, 126)
        Me.lblNumberScores.Name = "lblNumberScores"
        Me.lblNumberScores.Size = New System.Drawing.Size(93, 13)
        Me.lblNumberScores.TabIndex = 4
        Me.lblNumberScores.Text = "Number of scores:"
        '
        'numScoresOut
        '
        Me.numScoresOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numScoresOut.Location = New System.Drawing.Point(115, 139)
        Me.numScoresOut.Name = "numScoresOut"
        Me.numScoresOut.Size = New System.Drawing.Size(75, 20)
        Me.numScoresOut.TabIndex = 5
        '
        'lblAverageScore
        '
        Me.lblAverageScore.AutoSize = True
        Me.lblAverageScore.Location = New System.Drawing.Point(112, 171)
        Me.lblAverageScore.Name = "lblAverageScore"
        Me.lblAverageScore.Size = New System.Drawing.Size(81, 13)
        Me.lblAverageScore.TabIndex = 6
        Me.lblAverageScore.Text = "Average Score:"
        '
        'avgScoreOut
        '
        Me.avgScoreOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.avgScoreOut.Location = New System.Drawing.Point(115, 184)
        Me.avgScoreOut.Name = "avgScoreOut"
        Me.avgScoreOut.Size = New System.Drawing.Size(75, 20)
        Me.avgScoreOut.TabIndex = 7
        '
        'btnRecordScore
        '
        Me.btnRecordScore.Location = New System.Drawing.Point(115, 40)
        Me.btnRecordScore.Name = "btnRecordScore"
        Me.btnRecordScore.Size = New System.Drawing.Size(82, 23)
        Me.btnRecordScore.TabIndex = 8
        Me.btnRecordScore.Text = "&Record Score"
        Me.btnRecordScore.UseVisualStyleBackColor = True
        '
        'btnNextSkater
        '
        Me.btnNextSkater.Location = New System.Drawing.Point(203, 40)
        Me.btnNextSkater.Name = "btnNextSkater"
        Me.btnNextSkater.Size = New System.Drawing.Size(91, 23)
        Me.btnNextSkater.TabIndex = 9
        Me.btnNextSkater.Text = "&Next Skater"
        Me.btnNextSkater.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 40)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 227)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNextSkater)
        Me.Controls.Add(Me.btnRecordScore)
        Me.Controls.Add(Me.avgScoreOut)
        Me.Controls.Add(Me.lblAverageScore)
        Me.Controls.Add(Me.numScoresOut)
        Me.Controls.Add(Me.lblNumberScores)
        Me.Controls.Add(Me.totalScoreOut)
        Me.Controls.Add(Me.lblTotalScore)
        Me.Controls.Add(Me.lstBoxScore)
        Me.Controls.Add(Me.lblScore)
        Me.Name = "frmMain"
        Me.Text = "Mills Skating Rink"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lstBoxScore As System.Windows.Forms.ListBox
    Friend WithEvents lblTotalScore As System.Windows.Forms.Label
    Friend WithEvents totalScoreOut As System.Windows.Forms.Label
    Friend WithEvents lblNumberScores As System.Windows.Forms.Label
    Friend WithEvents numScoresOut As System.Windows.Forms.Label
    Friend WithEvents lblAverageScore As System.Windows.Forms.Label
    Friend WithEvents avgScoreOut As System.Windows.Forms.Label
    Friend WithEvents btnRecordScore As System.Windows.Forms.Button
    Friend WithEvents btnNextSkater As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
