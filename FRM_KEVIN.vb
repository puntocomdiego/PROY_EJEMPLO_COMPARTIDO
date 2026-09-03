Public Class FRM_KEVIN

    ' ============================================================
    '  TP: contar cuantas vocales tiene el texto.
    '  Pista: For Each c As Char In txtEntrada.Text.ToLower ...
    ' ============================================================

    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click

        ' TODO (alumno): escribir aqui tu codigo.

    End Sub

    Private Sub FRM_KEVIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnContar_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        ' Variables necesarias
        Dim totalVocales As Integer = 0
        Dim textoIngresado As String = txtEntrada.Text.ToLower()

        ' Recorremos cada carácter del texto
        For Each letra As Char In textoIngresado
            ' Comprobamos si el carácter es una vocal
            If letra = "a" OrElse letra = "e" OrElse letra = "i" OrElse letra = "o" OrElse letra = "u" Then
                totalVocales += 1
            End If
        Next

        ' Mostramos el resultado
        MessageBox.Show("El texto tiene " & totalVocales & " vocales.", "Resultado")
    End Sub
End Class
