Public Class FRM_DANIEL
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim numero As Integer

        numero = Val(TextBox1.Text)

        If numero Mod 2 = 0 Then
            Label1.Text = "el número " & numero & " es par"
        Else
            Label1.Text = "el número " & numero & " es impar"
        End If










    End Sub
End Class
