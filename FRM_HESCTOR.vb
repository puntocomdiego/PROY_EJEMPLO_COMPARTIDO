Public Class FRM_HESCTOR






    Private Sub BtnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        If txtEntrada.Text >= 120 Then
            MsgBox("No se puede ingresar un valor mayor a 120")
            Return
        End If
        If CInt(txtEntrada.Text) - 18 Then
            lblResultado.Text = "MENOR"
            lblResultado.ForeColor = Color.Red

        End If
        If CInt(TXTEntrada.Text) >= 18 Then
            lblResultado.Text = "MAYOR"
            lblResultado.ForeColor = Color.Green

        End If
    End Sub

    Private Sub lblResultado_Click(sender As Object, e As EventArgs) Handles lblResultado.Click

    End Sub
End Class
