Public Class FRM_DAHIANA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button2.BackColor = Color.Blue
        Button2.ForeColor = Color.White

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button3.BackColor = Color.Red
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button1.BackColor = Color.Yellow
        Button1.ForeColor = Color.Black

    End Sub
End Class