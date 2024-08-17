Public Class Form1
    Dim intValue1 As Integer = 0
    Dim intValue2 As Integer = 0
    Dim decAnswer As Decimal = 0
    Dim strValue1 As String = ""
    Dim strValue2 As String = ""
    Dim intValid As Integer = 0
    Public Property Value1 As String
    Public Property Value2 As String

    Private Sub btnFindDecimal_Click(sender As Object, e As EventArgs) Handles btnFindDecimal.Click
        strValue1 = InputBox(" Please enter Value 1 ", " Value 1 ", 0)
        If MessageBox.Show(" The value entered was " & strValue1, " Validate Value 1 ", MessageBoxButtons.OKCancel) =
                Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show(" Value 1 was invalid ")
            Exit Sub
        End If

        strValue1 = InputBox(" Please enter Value 2 ", " Value 2 ", 0)
        If MessageBox.Show(" The vaue entered was " & strValue2, " Validate Value 2 ", MessageBoxButtons.OKCancel) =
                Windows.Forms.DialogResult.Cancel Then
            MessageBox.Show(" Value 2 was invalid ")
            Exit Sub
        End If

        Integer.TryParse(Value1, intValue1)
        Integer.TryParse(Value2, intValue2)
        If intValue2 > intValue1 Then
            MessageBox.Show(" Value 2: " & intValue2 & " was the highest ")
            decAnswer = intValue1 / intValue2
        Else
            MessageBox.Show(" Value 1: " & intValue1 & " was the highest ")
            decAnswer = intValue2 / intValue1
        End If
        MessageBox.Show(" The Decimal value = " &
            Math.Round(decAnswer, 2))

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the program
        Me.Close()
    End Sub
End Class
