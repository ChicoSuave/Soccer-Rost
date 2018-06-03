Public Class Roster

    ' player array
    Dim players(10, 7) As String

   ' declare variables that store user input
   Dim playercount As Integer = 0
   Dim goals As Integer
   Dim assists As Integer
   Dim status As String
   Dim totalPay As Decimal
   Dim points As Double

    ' declare constants
    Const PAY As Decimal = 500
    Const GAMES As Integer = 38

    Private Sub enterPlayerbutton_Click(sender As Object, e As EventArgs) Handles enterPlayerbutton.Click

        ' declare variables and store input data
        Dim name As String = StrConv(nametextBox.Text, VbStrConv.ProperCase)
        Dim number As String = numbertextBox.Text
        Dim position As String = StrConv(positiontextBox.Text, VbStrConv.ProperCase)


        ' get user input
        goals = CInt(goalsUpDown.Value)
        assists = CInt(assistsUpDown.Value)
        points = calculatePoints(goals, assists)

        ' check statuscombobox index
        Select Case statuscomboBox.SelectedIndex
            Case 0
                status = "Active"
            Case 1
                status = "Back-up"
            Case 2
                status = "Injured"
        End Select


        ' check user input, display message if need or update array accordingly 
        If nametextBox.Text = String.Empty Then
            MessageBox.Show("Please enter the players name", "No name entered", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error)
            nametextBox.Focus()
        ElseIf numbertextBox.Text = String.Empty Then
            MessageBox.Show("Please enter the players number", "No number entered", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error)
            numbertextBox.Focus()
        ElseIf positiontextBox.Text = String.Empty Then
            MessageBox.Show("Please enter the players position", "No position entered", MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            positiontextBox.Focus()
        ElseIf CInt(numbertextBox.Text) < 0 Or CInt(numbertextBox.Text) > 99 Then
            MessageBox.Show("Please enter a number between 0 and 99", "Invalid Number", MessageBoxButtons.OK,
                             MessageBoxIcon.Information)
            numbertextBox.Focus()
        Else

         'update array
         players(playercount, 0) = name.PadRight(15)
         players(playercount, 1) = number.PadLeft(2)
         players(playercount, 2) = position
         players(playercount, 3) = CStr(goals)
         players(playercount, 4) = CStr(assists)
         players(playercount, 5) = CStr(points)
         players(playercount, 6) = status
         players(playercount, 7) = calculateBonus(points)


         playercount += 1 ' playercount increment
         clearFields() ' call method to clear input boxes


         ' display message when player successfullly entered
         MessageBox.Show("Player successfully entered", "Confirmation", MessageBoxButtons.OK,
                             MessageBoxIcon.Information)

         'limit number of players
         If playercount = players.GetUpperBound(0) + 1 Then
            playergroupBox.Enabled = False
            statsgroupBox.Enabled = False
            enterPlayerbutton.Enabled = False
         End If

         showRosterbutton.Enabled = True ' enable roster button
            statuscomboBox.SelectedIndex = -1 ' reset statuscombobox to no index
        End If
    End Sub 'enterPlayerbutton_Click

    ' handles roster button click event
    Private Sub showRosterbutton_Click(sender As Object, e As EventArgs) Handles showRosterbutton.Click

        rosterListBox.Items.Clear() ' clear rosterlistbox

        ' header
        rosterListBox.Items.Add("Player".PadRight(15) & vbTab & "Number" & vbTab & "Position" & vbTab &
                            "Goals".PadRight(1) & vbTab & "Assists".PadRight(1) & vbTab &
                            "Points" & vbTab & "Status" & vbTab & "Bonus")
        ' iterate through players array
        For player As Integer = 0 To playercount - 1
            Dim output As String = players(player, 0)
            For stat As Integer = 1 To players.GetUpperBound(1)
                output &= vbTab & players(player, stat)
            Next
            rosterListBox.Items.Add(output) ' add output to rosterlistbox
        Next

        ' display player count and total team pay
        playercountLabel.Text = CStr(playercount)
        totalbonusLabel.Text = String.Format("{0:C}", totalPay)

      enterPlayerbutton.Enabled = True ' diable enter player button
   End Sub ' showRosterbutton_Click

    'handles numbertextbox keydown event
    Private Sub numbertextbox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles _
                            numbertextBox.KeyDown

        ' declare boolean variable to store key event
        Dim response As Boolean

        '
        Select Case e.KeyCode ' check key input
            Case Keys.D0 To Keys.D9
                response = True
            Case Else
                ' display message if invalid input is detected
                MessageBox.Show("Enter numbers only", " Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                numbertextBox.Clear()
        End Select
    End Sub 'numbertextbox_KeyDown

    'handles goalsUpDown keydown event
    Private Sub goalsUpDown_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles _
                           goalsUpDown.KeyDown

        ' declare boolean variable to store key event
        Dim response As Boolean

        Select Case e.KeyCode ' check key input
            Case Keys.D0 To Keys.D9
                response = True
            Case Keys.Up, Keys.Down, Keys.Left, Keys.Right
                response = True
            Case Else
                ' display message if invalid input is detected
                MessageBox.Show("Enter numbers only", " Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                numbertextBox.Clear()
        End Select
    End Sub ' goalsUpDown_KeyDown

    'handles assistsUpDown keydown event
    Private Sub assistsUpDown_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles _
                           assistsUpDown.KeyDown
        ' declare boolean variable to store key event
        Dim response As Boolean

        Select Case e.KeyCode 'check key input
            Case Keys.D0 To Keys.D9
                response = True
            Case Keys.Up, Keys.Down, Keys.Left, Keys.Right
                response = True
            Case Else
                ' display message if invalid input is detected
                MessageBox.Show("Enter numbers only", " Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                numbertextBox.Clear()
        End Select
    End Sub ' assistsUpDown_KeyDown

    ' clear input boxes method
    Private Sub clearFields()
        'clear textbox
        'reset updown 
        nametextBox.Clear()
        numbertextBox.Clear()
        positiontextBox.Clear()
        goalsUpDown.Value = 0
        assistsUpDown.Value = 0
    End Sub 'clearFields

    ' calculate points
    Function calculatePoints(ByVal scored As Integer, ByVal passes As Integer) As Integer

        'declare variable to store points
        Dim points As Integer

        'conver data to integer
        points = CInt(scored * 2.5 + passes * 1.5)

        Return points 'return data
    End Function 'calculatePoints

   ' calculate bonus
   Function calculateBonus(ByVal totalpoints As Double) As String

      ' declare variabls to store data
      Dim check As Decimal
      Dim output As String

      ' convert and calculate data
      check = CDec(totalpoints) * PAY

      ' format data
      output = String.Format("{0:C}", check)

      totalPay += check ' update total team pay

      Return output ' return data
   End Function ' calculateBonus

   ' bring up second form when new index it selected
   Private Sub rosterListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rosterListBox.SelectedIndexChanged

        Player.Close() ' close player form if open

        If rosterListBox.SelectedIndex = 0 Then ' do nothing if header is selected

        ElseIf rosterListBox.SelectedIndex > 0 Then ' open player form if selected index greater than 0

            ' pass points data from player array and const PAY
            Player.totalPoints = CDbl(players(rosterListBox.SelectedIndex - 1, 5))
            Player.bonusPay = PAY
            Player.Show() ' show form

        End If
    End Sub
End Class ' rosterListBox_SelectedIndexChanged
