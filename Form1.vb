Public Class Form1
    Const ConSuper As Decimal = 380.0
    Const ConAuto As Decimal = 275.0
    Const Con As Decimal = 209.0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGroup.Text = ""
        txtGroup.Focus()
        radOne.Select()
        lblCost.Text = ""
    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim decLevel As Decimal
        Dim decChoice As Decimal
        Dim decCost As Decimal

        If IsNumeric(txtGroup.Text) Then
            decLevel = Convert.ToDecimal(txtGroup.Text)

            If decLevel >= 1 And decLevel <= 20 Then
                If radOne.Checked Then
                    decChoice = ConSuper
                ElseIf radTwo.Checked Then
                    decChoice = ConAuto
                ElseIf radThree.Checked Then
                    decChoice = Con
                End If
                decCost = decChoice * decLevel
                lblCost.Text = decCost.ToString("C")
            Else
                MsgBox("You entered a number not in between 1 & 20")
                txtGroup.Text = ""
                txtGroup.Focus()
            End If
        Else
            MsgBox("You entered a value that is not numeric")
            txtGroup.Text = ""
            txtGroup.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroup.Text = ""
        txtGroup.Focus()
        radOne.Select()
        lblCost.Text = ""
    End Sub
End Class

