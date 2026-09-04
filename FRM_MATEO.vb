Public Class FRM_MATEO

    ' ============================================================
    '  TP: sumar txtNum1 + txtNum2 y mostrar en lblResultado.
    '  Pista: Dim r As Double = CDbl(txtNum1.Text) + CDbl(txtNum2.Text)
    '         lblResultado.Text = "Resultado: " & r
    ' ============================================================

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If IsNumeric(txtNum1.Text) And IsNumeric(txtNum2.Text) Then
            Dim num1 As Double = txtNum1.Text
            Dim num2 As Double = txtNum2.Text
            Dim resultado = num1 + num2
            lblResultado.Text = "Resultado: " & resultado.ToString
        Else
            MessageBox.Show("Por favor, ingrese números válidos en ambos campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If IsNumeric(txtNum1.Text) And IsNumeric(txtNum2.Text) Then
            Dim num1 As Double = txtNum1.Text
            Dim num2 As Double = txtNum2.Text
            Dim resultado = num1 - num2
            lblResultado.Text = "Resultado: " & resultado.ToString
        Else
            MessageBox.Show("Por favor, ingrese números válidos en ambos campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If IsNumeric(txtNum1.Text) And IsNumeric(txtNum2.Text) Then
            Dim num1 As Double = txtNum1.Text
            Dim num2 As Double = txtNum2.Text
            Dim resultado = num1 * num2
            lblResultado.Text = "Resultado: " & resultado.ToString
        Else
            MessageBox.Show("Por favor, ingrese números válidos en ambos campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If IsNumeric(txtNum1.Text) And IsNumeric(txtNum2.Text) Then
            Dim num1 As Double = txtNum1.Text
            Dim num2 As Double = txtNum2.Text
            Dim resultado = num1 / num2
            lblResultado.Text = "Resultado: " & resultado.ToString
        Else
            MessageBox.Show("Por favor, ingrese números válidos en ambos campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtNum1_GotFocus(sender As Object, e As EventArgs) Handles txtNum1.GotFocus
        txtNum1.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNum1_LostFocus(sender As Object, e As EventArgs) Handles txtNum1.LostFocus
        txtNum1.BackColor = Color.White
    End Sub

    Private Sub txtNum2_GotFocus(sender As Object, e As EventArgs) Handles txtNum2.GotFocus
        txtNum2.BackColor = Color.LightYellow
    End Sub

    Private Sub txtNum2_LostFocus(sender As Object, e As EventArgs) Handles txtNum2.LostFocus
        txtNum2.BackColor = Color.White
    End Sub
End Class
