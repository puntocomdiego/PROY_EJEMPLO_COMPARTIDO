Public Class FRM_DAIANA

    Dim etapa As Integer = 1

    Private Sub FRM_DAHIANA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''--SECUNDARIOS--
        'Panel1.BackColor = Color.Green
        'Panel1.Visible = False

        'Panel2.BackColor = Color.Purple
        'Panel2.Visible = False

        'Panel3.BackColor = Color.Orange
        'Panel3.Visible = False

        ''-- TERCIARIOS--

        'Panel4.BackColor = Color.OrangeRed
        'Panel4.Visible = False

        'Panel5.BackColor = Color.DarkOrange
        'Panel5.Visible = False


        'Panel6.BackColor = Color.YellowGreen
        'Panel6.Visible = False

        'Panel7.BackColor = Color.LightSeaGreen
        'Panel7.Visible = False


        'Panel8.BackColor = Color.MediumPurple
        'Panel8.Visible = False

        'Panel9.BackColor = Color.MediumVioletRed
        'Panel9.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button2.BackColor = Color.Blue
        Button2.ForeColor = Color.White
        Button2.Visible = True

        Button1.Text = " "

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button3.BackColor = Color.Red
        Button3.ForeColor = Color.White
        Button3.Visible = True

        Button2.Text = " "
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button1.BackColor = Color.Yellow

        Button3.Text = " "

        Button4.Visible = True

        Panel1.Visible = True
        Panel2.Visible = True
        Panel3.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            If etapa = 1 Then

                '---SECUNDARIOS--
                Panel1.BackColor = Color.Green
                Panel2.BackColor = Color.Purple
                Panel3.BackColor = Color.Orange

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