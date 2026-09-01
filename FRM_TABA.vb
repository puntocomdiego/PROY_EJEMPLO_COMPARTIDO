Public Class FRM_TABA


    Private Sub FRM_TABA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        PictureBox1.Location = New Point(300, 125)
        PictureBox1.Image = My.Resources.personacaminando_ezgif_com_reverse
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Location = New Point(PictureBox1.Location.X + Val(TextBox1.Text), PictureBox1.Location.Y)

        If PictureBox1.Location.X > Me.Width Then
            PictureBox1.Location = New Point(Me.Width * -1, PictureBox1.Location.Y)
        End If


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        PictureBox1.Location = New Point(300, 500)
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - 1)
        If PictureBox1.Location.Y = 120 Then
            Timer2.Stop()
            Timer1.Start()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Volve a tu formulario.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class