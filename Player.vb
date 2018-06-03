Public Class Player

    ' declare variables to store imported data
    Public Property totalPoints As Double
    Public Property bonusPay As Decimal

    Private Sub Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' declare variables to store data
        Dim yearCount As Integer = 1
        Dim bonusPerYear As Decimal
      Dim netWorth As Decimal

      ' add header to list box
      fiveYearSalaryListBox.Items.Add(vbTab & "Year" & vbTab & "Salary")

        ' loop
        Do Until yearCount > 5

         'calculate bonus by year
         bonusPerYear = CDec(totalPoints * bonusPay * yearCount + 30000)
         ' add bonus to listbox
         fiveYearSalaryListBox.Items.Add(vbTab & yearCount & vbTab & String.Format("{0:C}", bonusPerYear))

            netWorth += bonusPerYear

            yearCount += 1 ' year increment
        Loop

        networthLabel.Text = String.Format("{0:C}", netWorth)
    End Sub ' Player_Load

End Class ' Player
