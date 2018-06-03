<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Player
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Player))
      Me.fiveYearSalaryListBox = New System.Windows.Forms.ListBox()
      Me.worthLabel = New System.Windows.Forms.Label()
      Me.networthLabel = New System.Windows.Forms.Label()
      Me.SuspendLayout()
      '
      'fiveYearSalaryListBox
      '
      Me.fiveYearSalaryListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.fiveYearSalaryListBox.FormattingEnabled = True
      Me.fiveYearSalaryListBox.Location = New System.Drawing.Point(12, 5)
      Me.fiveYearSalaryListBox.Name = "fiveYearSalaryListBox"
      Me.fiveYearSalaryListBox.Size = New System.Drawing.Size(203, 93)
      Me.fiveYearSalaryListBox.TabIndex = 0
      '
      'worthLabel
      '
      Me.worthLabel.AutoSize = True
      Me.worthLabel.BackColor = System.Drawing.Color.White
      Me.worthLabel.Location = New System.Drawing.Point(9, 108)
      Me.worthLabel.Name = "worthLabel"
      Me.worthLabel.Size = New System.Drawing.Size(93, 13)
      Me.worthLabel.TabIndex = 1
      Me.worthLabel.Text = "5 Year Net Worth:"
      '
      'networthLabel
      '
      Me.networthLabel.BackColor = System.Drawing.Color.White
      Me.networthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.networthLabel.Location = New System.Drawing.Point(122, 103)
      Me.networthLabel.Name = "networthLabel"
      Me.networthLabel.Size = New System.Drawing.Size(93, 23)
      Me.networthLabel.TabIndex = 1
      Me.networthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Player
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
      Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.ClientSize = New System.Drawing.Size(227, 135)
      Me.Controls.Add(Me.networthLabel)
      Me.Controls.Add(Me.worthLabel)
      Me.Controls.Add(Me.fiveYearSalaryListBox)
      Me.Name = "Player"
      Me.Text = "5 Yr Projection"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents fiveYearSalaryListBox As System.Windows.Forms.ListBox
    Friend WithEvents worthLabel As System.Windows.Forms.Label
    Friend WithEvents networthLabel As System.Windows.Forms.Label
End Class
