
Imports System.Drawing
Imports System.Runtime.InteropServices.JavaScript.JSType
Public Class FRM_DANIEL
    Dim numero As Integer = 0



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim numero As Integer

        numero = Val(TextBox1.Text)

        If TextBox1.Text = "" Then
            MsgBox("Por favor ingrese un número")
            Exit Sub

        End If



        If numero Mod 2 = 0 Then
            Label1.Text = "el número " & numero & " es par"
        Else
            Label1.Text = "el número " & numero & " es impar"
        End If










    End Sub

    Private Sub FRM_DANIEL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        Dim numero As Integer
        Dim rojo As Integer
        Dim verde As Integer
        Dim azul As Integer

        numero = Random.Shared.Next(0, 16777216)

        rojo = numero Mod 256
        verde = (numero \ 256) Mod 256
        azul = (numero \ 65536) Mod 256

        Label3.BackColor = Color.FromArgb(rojo, verde, azul)





    End Sub
End Class
