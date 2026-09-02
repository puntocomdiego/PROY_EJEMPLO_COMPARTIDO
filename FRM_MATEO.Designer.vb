<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MATEO
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblConsigna = New Label()
        Button1 = New Button()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        lblNum1 = New Label()
        lblNum2 = New Label()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' lblConsigna
        ' 
        lblConsigna.BackColor = Color.LightYellow
        lblConsigna.BorderStyle = BorderStyle.FixedSingle
        lblConsigna.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular)
        lblConsigna.Location = New Point(12, 12)
        lblConsigna.Name = "lblConsigna"
        lblConsigna.Padding = New Padding(8)
        lblConsigna.Size = New Size(770, 120)
        lblConsigna.TabIndex = 1
        lblConsigna.Text = "TRABAJO PRACTICO - Sumar dos numeros" & vbCrLf & vbCrLf &
            "Hay dos cuadros de texto (txtNum1 y txtNum2). Programa el boton para que sume los dos" & vbCrLf &
            "numeros ingresados y muestre el resultado en la etiqueta ""lblResultado""." & vbCrLf &
            "Validar con IsNumeric que ambos sean numeros; si no, mostrar un aviso." & vbCrLf &
            "Extra (opcional): agrega botones para restar, multiplicar y dividir."
        ' 
        ' lblNum1
        ' 
        lblNum1.AutoSize = True
        lblNum1.Font = New Font("Segoe UI", 12F)
        lblNum1.Location = New Point(150, 160)
        lblNum1.Name = "lblNum1"
        lblNum1.Size = New Size(80, 21)
        lblNum1.TabIndex = 2
        lblNum1.Text = "Numero 1:"
        ' 
        ' txtNum1
        ' 
        txtNum1.Font = New Font("Segoe UI", 12F)
        txtNum1.Location = New Point(260, 157)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(150, 29)
        txtNum1.TabIndex = 3
        ' 
        ' lblNum2
        ' 
        lblNum2.AutoSize = True
        lblNum2.Font = New Font("Segoe UI", 12F)
        lblNum2.Location = New Point(150, 205)
        lblNum2.Name = "lblNum2"
        lblNum2.Size = New Size(80, 21)
        lblNum2.TabIndex = 4
        lblNum2.Text = "Numero 2:"
        ' 
        ' txtNum2
        ' 
        txtNum2.Font = New Font("Segoe UI", 12F)
        txtNum2.Location = New Point(260, 202)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(150, 29)
        txtNum2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(260, 250)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 50)
        Button1.TabIndex = 0
        Button1.Text = "SUMAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblResultado.Location = New Point(150, 320)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(500, 40)
        lblResultado.TabIndex = 6
        ' 
        ' FRM_MATEO
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(txtNum2)
        Controls.Add(lblNum2)
        Controls.Add(txtNum1)
        Controls.Add(lblNum1)
        Controls.Add(lblConsigna)
        Controls.Add(Button1)
        Name = "FRM_MATEO"
        Text = "FRM_MATEO - Calculadora"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblConsigna As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblResultado As Label
End Class
