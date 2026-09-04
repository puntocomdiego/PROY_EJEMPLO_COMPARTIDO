Public Class FRM_JORGE
    Dim cuenta As Integer = 0
    ' ============================================================
    '  TP: contar los clicks y mostrarlos en lblContador.
    '  Pista: declara aca abajo (nivel de clase) la variable contadora.
    '         Dim cuenta As Integer = 0
    ' ============================================================

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cuenta = cuenta + 1   ' <-- reemplaza por tu logica de contador
        lblContador.Text = "Clicks: " & cuenta
    End Sub

    Private Sub FRM_JORGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
