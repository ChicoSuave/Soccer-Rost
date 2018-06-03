<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Roster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Roster))
        Me.playergroupBox = New System.Windows.Forms.GroupBox()
        Me.positiontextBox = New System.Windows.Forms.TextBox()
        Me.numbertextBox = New System.Windows.Forms.TextBox()
        Me.nametextBox = New System.Windows.Forms.TextBox()
        Me.positionlabel = New System.Windows.Forms.Label()
        Me.numberLabel = New System.Windows.Forms.Label()
        Me.Namelabel = New System.Windows.Forms.Label()
        Me.statsgroupBox = New System.Windows.Forms.GroupBox()
        Me.goalsUpDown = New System.Windows.Forms.NumericUpDown()
        Me.assistsUpDown = New System.Windows.Forms.NumericUpDown()
        Me.statuscomboBox = New System.Windows.Forms.ComboBox()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.assistslabel = New System.Windows.Forms.Label()
        Me.Goalslabel = New System.Windows.Forms.Label()
        Me.enterPlayerbutton = New System.Windows.Forms.Button()
        Me.showRosterbutton = New System.Windows.Forms.Button()
        Me.BonusTotalLabel = New System.Windows.Forms.Label()
        Me.totalPlayersLabel = New System.Windows.Forms.Label()
        Me.playercountLabel = New System.Windows.Forms.Label()
        Me.totalbonusLabel = New System.Windows.Forms.Label()
        Me.rosterListBox = New System.Windows.Forms.ListBox()
        Me.playergroupBox.SuspendLayout()
        Me.statsgroupBox.SuspendLayout()
        CType(Me.goalsUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.assistsUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playergroupBox
        '
        Me.playergroupBox.BackColor = System.Drawing.Color.White
        Me.playergroupBox.Controls.Add(Me.positiontextBox)
        Me.playergroupBox.Controls.Add(Me.numbertextBox)
        Me.playergroupBox.Controls.Add(Me.nametextBox)
        Me.playergroupBox.Controls.Add(Me.positionlabel)
        Me.playergroupBox.Controls.Add(Me.numberLabel)
        Me.playergroupBox.Controls.Add(Me.Namelabel)
        Me.playergroupBox.Location = New System.Drawing.Point(29, 12)
        Me.playergroupBox.Name = "playergroupBox"
        Me.playergroupBox.Size = New System.Drawing.Size(198, 100)
        Me.playergroupBox.TabIndex = 1
        Me.playergroupBox.TabStop = False
        Me.playergroupBox.Text = "Player"
        '
        'positiontextBox
        '
        Me.positiontextBox.Location = New System.Drawing.Point(62, 71)
        Me.positiontextBox.Name = "positiontextBox"
        Me.positiontextBox.Size = New System.Drawing.Size(117, 20)
        Me.positiontextBox.TabIndex = 3
        Me.positiontextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numbertextBox
        '
        Me.numbertextBox.Location = New System.Drawing.Point(62, 45)
        Me.numbertextBox.Name = "numbertextBox"
        Me.numbertextBox.Size = New System.Drawing.Size(117, 20)
        Me.numbertextBox.TabIndex = 2
        Me.numbertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nametextBox
        '
        Me.nametextBox.Location = New System.Drawing.Point(62, 16)
        Me.nametextBox.Name = "nametextBox"
        Me.nametextBox.Size = New System.Drawing.Size(117, 20)
        Me.nametextBox.TabIndex = 1
        Me.nametextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'positionlabel
        '
        Me.positionlabel.AutoSize = True
        Me.positionlabel.Location = New System.Drawing.Point(6, 77)
        Me.positionlabel.Name = "positionlabel"
        Me.positionlabel.Size = New System.Drawing.Size(44, 13)
        Me.positionlabel.TabIndex = 0
        Me.positionlabel.Text = "Position"
        Me.positionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numberLabel
        '
        Me.numberLabel.AutoSize = True
        Me.numberLabel.Location = New System.Drawing.Point(6, 48)
        Me.numberLabel.Name = "numberLabel"
        Me.numberLabel.Size = New System.Drawing.Size(47, 13)
        Me.numberLabel.TabIndex = 0
        Me.numberLabel.Text = "Number:"
        Me.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Namelabel
        '
        Me.Namelabel.AutoSize = True
        Me.Namelabel.Location = New System.Drawing.Point(6, 19)
        Me.Namelabel.Name = "Namelabel"
        Me.Namelabel.Size = New System.Drawing.Size(38, 13)
        Me.Namelabel.TabIndex = 0
        Me.Namelabel.Text = "Name:"
        Me.Namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'statsgroupBox
        '
        Me.statsgroupBox.BackColor = System.Drawing.Color.White
        Me.statsgroupBox.Controls.Add(Me.goalsUpDown)
        Me.statsgroupBox.Controls.Add(Me.assistsUpDown)
        Me.statsgroupBox.Controls.Add(Me.statuscomboBox)
        Me.statsgroupBox.Controls.Add(Me.statusLabel)
        Me.statsgroupBox.Controls.Add(Me.assistslabel)
        Me.statsgroupBox.Controls.Add(Me.Goalslabel)
        Me.statsgroupBox.Location = New System.Drawing.Point(348, 12)
        Me.statsgroupBox.Name = "statsgroupBox"
        Me.statsgroupBox.Size = New System.Drawing.Size(200, 100)
        Me.statsgroupBox.TabIndex = 2
        Me.statsgroupBox.TabStop = False
        Me.statsgroupBox.Text = "Statistics"
        '
        'goalsUpDown
        '
        Me.goalsUpDown.Location = New System.Drawing.Point(73, 17)
        Me.goalsUpDown.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.goalsUpDown.Name = "goalsUpDown"
        Me.goalsUpDown.Size = New System.Drawing.Size(109, 20)
        Me.goalsUpDown.TabIndex = 4
        Me.goalsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'assistsUpDown
        '
        Me.assistsUpDown.Location = New System.Drawing.Point(73, 44)
        Me.assistsUpDown.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.assistsUpDown.Name = "assistsUpDown"
        Me.assistsUpDown.Size = New System.Drawing.Size(109, 20)
        Me.assistsUpDown.TabIndex = 5
        Me.assistsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'statuscomboBox
        '
        Me.statuscomboBox.BackColor = System.Drawing.Color.White
        Me.statuscomboBox.DisplayMember = "1"
        Me.statuscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statuscomboBox.FormattingEnabled = True
        Me.statuscomboBox.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.statuscomboBox.Items.AddRange(New Object() {"Active", "Back-up", "Injured"})
        Me.statuscomboBox.Location = New System.Drawing.Point(73, 71)
        Me.statuscomboBox.MaxDropDownItems = 3
        Me.statuscomboBox.Name = "statuscomboBox"
        Me.statuscomboBox.Size = New System.Drawing.Size(109, 21)
        Me.statuscomboBox.TabIndex = 6
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Location = New System.Drawing.Point(6, 73)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(40, 13)
        Me.statusLabel.TabIndex = 0
        Me.statusLabel.Text = "Status:"
        Me.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'assistslabel
        '
        Me.assistslabel.AutoSize = True
        Me.assistslabel.Location = New System.Drawing.Point(6, 46)
        Me.assistslabel.Name = "assistslabel"
        Me.assistslabel.Size = New System.Drawing.Size(42, 13)
        Me.assistslabel.TabIndex = 0
        Me.assistslabel.Text = "Assists:"
        Me.assistslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Goalslabel
        '
        Me.Goalslabel.AutoSize = True
        Me.Goalslabel.Location = New System.Drawing.Point(6, 19)
        Me.Goalslabel.Name = "Goalslabel"
        Me.Goalslabel.Size = New System.Drawing.Size(37, 13)
        Me.Goalslabel.TabIndex = 0
        Me.Goalslabel.Text = "Goals:"
        Me.Goalslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'enterPlayerbutton
        '
        Me.enterPlayerbutton.AutoSize = True
        Me.enterPlayerbutton.BackColor = System.Drawing.Color.White
        Me.enterPlayerbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.enterPlayerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.enterPlayerbutton.Location = New System.Drawing.Point(64, 131)
        Me.enterPlayerbutton.Name = "enterPlayerbutton"
        Me.enterPlayerbutton.Size = New System.Drawing.Size(113, 23)
        Me.enterPlayerbutton.TabIndex = 7
        Me.enterPlayerbutton.Text = "Enter Player"
        Me.enterPlayerbutton.UseVisualStyleBackColor = False
        '
        'showRosterbutton
        '
        Me.showRosterbutton.AutoSize = True
        Me.showRosterbutton.BackColor = System.Drawing.Color.White
        Me.showRosterbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.showRosterbutton.Enabled = False
        Me.showRosterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.showRosterbutton.Location = New System.Drawing.Point(399, 131)
        Me.showRosterbutton.Name = "showRosterbutton"
        Me.showRosterbutton.Size = New System.Drawing.Size(113, 23)
        Me.showRosterbutton.TabIndex = 8
        Me.showRosterbutton.Text = "Roster"
        Me.showRosterbutton.UseVisualStyleBackColor = False
        '
        'BonusTotalLabel
        '
        Me.BonusTotalLabel.AutoSize = True
        Me.BonusTotalLabel.BackColor = System.Drawing.Color.White
        Me.BonusTotalLabel.Location = New System.Drawing.Point(355, 359)
        Me.BonusTotalLabel.Name = "BonusTotalLabel"
        Me.BonusTotalLabel.Size = New System.Drawing.Size(67, 13)
        Me.BonusTotalLabel.TabIndex = 0
        Me.BonusTotalLabel.Text = "Bonus Total:"
        Me.BonusTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalPlayersLabel
        '
        Me.totalPlayersLabel.AutoSize = True
        Me.totalPlayersLabel.BackColor = System.Drawing.Color.White
        Me.totalPlayersLabel.Location = New System.Drawing.Point(27, 359)
        Me.totalPlayersLabel.Name = "totalPlayersLabel"
        Me.totalPlayersLabel.Size = New System.Drawing.Size(71, 13)
        Me.totalPlayersLabel.TabIndex = 0
        Me.totalPlayersLabel.Text = "Total Players:"
        Me.totalPlayersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'playercountLabel
        '
        Me.playercountLabel.BackColor = System.Drawing.Color.White
        Me.playercountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.playercountLabel.Location = New System.Drawing.Point(95, 353)
        Me.playercountLabel.Name = "playercountLabel"
        Me.playercountLabel.Size = New System.Drawing.Size(58, 25)
        Me.playercountLabel.TabIndex = 0
        Me.playercountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalbonusLabel
        '
        Me.totalbonusLabel.BackColor = System.Drawing.Color.White
        Me.totalbonusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalbonusLabel.Location = New System.Drawing.Point(428, 353)
        Me.totalbonusLabel.Name = "totalbonusLabel"
        Me.totalbonusLabel.Size = New System.Drawing.Size(58, 25)
        Me.totalbonusLabel.TabIndex = 0
        Me.totalbonusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rosterListBox
        '
        Me.rosterListBox.FormattingEnabled = True
        Me.rosterListBox.HorizontalScrollbar = True
        Me.rosterListBox.Location = New System.Drawing.Point(30, 177)
        Me.rosterListBox.Name = "rosterListBox"
        Me.rosterListBox.Size = New System.Drawing.Size(519, 173)
        Me.rosterListBox.TabIndex = 9
        Me.rosterListBox.TabStop = False
        '
        'Roster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(579, 393)
        Me.Controls.Add(Me.rosterListBox)
        Me.Controls.Add(Me.showRosterbutton)
        Me.Controls.Add(Me.enterPlayerbutton)
        Me.Controls.Add(Me.statsgroupBox)
        Me.Controls.Add(Me.BonusTotalLabel)
        Me.Controls.Add(Me.totalbonusLabel)
        Me.Controls.Add(Me.playercountLabel)
        Me.Controls.Add(Me.totalPlayersLabel)
        Me.Controls.Add(Me.playergroupBox)
        Me.Name = "Roster"
        Me.Text = "Soccer Roster"
        Me.playergroupBox.ResumeLayout(False)
        Me.playergroupBox.PerformLayout()
        Me.statsgroupBox.ResumeLayout(False)
        Me.statsgroupBox.PerformLayout()
        CType(Me.goalsUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.assistsUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents playergroupBox As System.Windows.Forms.GroupBox
    Private WithEvents positiontextBox As System.Windows.Forms.TextBox
    Private WithEvents numbertextBox As System.Windows.Forms.TextBox
    Private WithEvents nametextBox As System.Windows.Forms.TextBox
    Private WithEvents positionlabel As System.Windows.Forms.Label
    Private WithEvents numberLabel As System.Windows.Forms.Label
    Private WithEvents Namelabel As System.Windows.Forms.Label
    Private WithEvents statsgroupBox As System.Windows.Forms.GroupBox
    Private WithEvents goalsUpDown As System.Windows.Forms.NumericUpDown
    Private WithEvents assistsUpDown As System.Windows.Forms.NumericUpDown
    Private WithEvents statuscomboBox As System.Windows.Forms.ComboBox
    Private WithEvents statusLabel As System.Windows.Forms.Label
    Private WithEvents assistslabel As System.Windows.Forms.Label
    Private WithEvents Goalslabel As System.Windows.Forms.Label
    Private WithEvents enterPlayerbutton As System.Windows.Forms.Button
    Private WithEvents showRosterbutton As System.Windows.Forms.Button
    Private WithEvents BonusTotalLabel As System.Windows.Forms.Label
    Private WithEvents totalPlayersLabel As System.Windows.Forms.Label
    Private WithEvents playercountLabel As System.Windows.Forms.Label
    Private WithEvents totalbonusLabel As System.Windows.Forms.Label
    Friend WithEvents rosterListBox As System.Windows.Forms.ListBox
End Class
