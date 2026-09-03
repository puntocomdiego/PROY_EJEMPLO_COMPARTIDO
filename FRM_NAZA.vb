Public Class FRM_NAZA
    Private Sub FRM_NAZA_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String = txtNombre.Text

        If nombre = "" Then
            MsgBox("¡Debes introducir tu nombre para recibir un saludo!")
        Else
            MsgBox("¡Hola, " & nombre & "!")
        End If
    End Sub
End Class