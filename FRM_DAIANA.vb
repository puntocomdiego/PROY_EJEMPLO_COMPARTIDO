Public Class FRM_DAIANA

    Dim etapa As Byte = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button2.BackColor = Color.Blue
        Button2.ForeColor = Color.White
        Button2.Visible = True

        Button1.Visible = False
        Button1.Text = " "
        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button3.BackColor = Color.Red
        Button3.ForeColor = Color.White
        Button3.Visible = True

        Button2.Text = " "
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button1.BackColor = Color.Yellow
        Button1.Visible = True

        Button3.Text = " "
        Button3.Enabled = False

        Button4.Visible = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            If etapa = 1 Then

                '---SECUNDARIOS--
                Panel1.BackColor = Color.Green
                Panel2.BackColor = Color.Purple
                Panel3.BackColor = Color.Orange

                Panel1.Visible = True
                Panel2.Visible = True
                Panel3.Visible = True


                Panel4.Visible = True
                Panel5.Visible = True

                Panel6.Visible = True
                Panel7.Visible = True

                Panel8.Visible = True
                Panel9.Visible = True

                etapa = 2


            ElseIf etapa = 2 Then

                '--TERCIARIOS--
                Panel4.BackColor = Color.OrangeRed
                Panel5.BackColor = Color.DarkOrange

                Panel6.BackColor = Color.YellowGreen
                Panel7.BackColor = Color.LightSeaGreen

                Panel8.BackColor = Color.MediumPurple
                Panel9.BackColor = Color.MediumVioletRed

                Button4.Visible = False

            End If

        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Try

            For Each ctrl As Control In Me.Controls

                If TypeOf ctrl Is Panel Then
                    ctrl.BackColor = Color.Transparent
                    ctrl.Visible = False
                End If
            Next

            If Button4.Visible = True Then
                Button4.Visible = False
            End If

            Button1.BackColor = SystemColors.Control
            Button2.BackColor = SystemColors.Control
            Button3.BackColor = SystemColors.Control

            Button1.Text = "CLICK!"

            Button2.Visible = False
            Button3.Visible = False
            etapa = 1

            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True


        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim result As DialogResult = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

End Class