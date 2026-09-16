Public Class FRM_DIEGO

    ' ============================================================
    '  TP: que el saludo use el nombre escrito en txtNombre.
    '  Pista: MsgBox("Hola, " & txtNombre.Text & "!")
    '  No olvides el caso en que el cuadro este vacio.
    ' ============================================================

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNombre.Text = "" Then
            MsgBox("Hola, mundo!")
        Else
            MsgBox("Hola, " & txtNombre.Text & "!")
        End If

    End Sub
End Class
