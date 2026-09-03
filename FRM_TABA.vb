Public Class FRM_TABA

    Dim moviendose As String = "si"
    Dim velocidad As Integer = 1

    Private Sub FRM_TABA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        PictureBox1.Location = New Point(300, 125)
        PictureBox1.Image = My.Resources.personacaminando_ezgif_com_reverse
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        PictureBox1.Location = New Point(PictureBox1.Location.X + velocidad, PictureBox1.Location.Y)

        If PictureBox1.Location.X > Me.Width Then
            PictureBox1.Location = New Point(Me.Width * -1, PictureBox1.Location.Y)
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        PictureBox1.Location = New Point(300, 500)
        PictureBox1.Image = My.Resources.pngtree_silhouette_of_a_stylish_man_standing_for_fashion_and_concept_art_png_image_20790357
        Button4.Enabled = False
        Button1.Enabled = False
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y - 1)

        If PictureBox1.Location.Y = 120 Then
            Timer2.Stop()
            Button4.Enabled = True
            Button1.Enabled = True

            If moviendose = "si" Then
                Timer1.Start()
                PictureBox1.Image = My.Resources.personacaminando_ezgif_com_reverse
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Volve a tu formulario.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Chr(Asc(e.KeyChar)) = Chr(Keys.Enter) Then
            If comprobacion() = False Then
                Exit Sub
            End If
            velocidad = Val(TextBox1.Text)
        End If


        If InStr("1234567890" & Chr(8), e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If moviendose = "si" Then
            Timer1.Stop()
            moviendose = "no"
            PictureBox1.Image = My.Resources.pngtree_silhouette_of_a_stylish_man_standing_for_fashion_and_concept_art_png_image_20790357
            Button4.Text = "Seguí"
        Else
            Timer1.Start()
            moviendose = "si"
            PictureBox1.Image = My.Resources.personacaminando_ezgif_com_reverse
            Button4.Text = "SUFICIENTE"
        End If
    End Sub

    Function comprobacion() As Boolean
        If TextBox1.Text = "" And TextBox1.Focused = False Then
            TextBox1.Text = "1"
            Return False
        End If

        If Val(TextBox1.Text) > 20 Then
            TextBox1.Text = "20"
            MsgBox("El valor maximo permitido es 20.")
            Return False
        End If

        If Val(TextBox1.Text) < 0 Then
            TextBox1.Text = "1"
            MsgBox("No se permiten numeros negativos. (¿Como hiciste para agregar uno siquiera?)")
            Return False
        End If

        Return True

    End Function

    'Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter


    '    If comprobacion() = False Then
    '        Exit Sub
    '    End If

    '    velocidad = Val(TextBox1.Text)

    'End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If comprobacion() = False Then
            Exit Sub
        End If
    End Sub
End Class