<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_NAZA
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
        components = New System.ComponentModel.Container
        lblConsigna = New Label()
        lblEntrada = New Label()
        txtEntrada = New TextBox()
        btnAccion = New Button()
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
        lblConsigna.Size = New Size(776, 135)
        lblConsigna.TabIndex = 0
        lblConsigna.Text = "TRABAJO PRACTICO - Numero Primo" & vbCrLf & vbCrLf &
            "El usuario ingresa un numero entero. Al presionar el boton, mostrar si es PRIMO o NO PRIMO." & vbCrLf &
            "Recorda: un numero primo solo se divide por 1 y por si mismo (ej: 2,3,5,7,11...)." & vbCrLf &
            "Pista: usa un For desde 2 hasta numero-1 y verifica con Mod si hay algun divisor exacto." & vbCrLf &
            "Validar que sea un numero entero mayor a 1."
        ' 
        ' lblEntrada
        ' 
        lblEntrada.AutoSize = True
        lblEntrada.Font = New Font("Segoe UI", 11.25F)
        lblEntrada.Location = New Point(90, 190)
        lblEntrada.Name = "lblEntrada"
        lblEntrada.Size = New Size(120, 20)
        lblEntrada.TabIndex = 1
        lblEntrada.Text = "Numero:"
        ' 
        ' txtEntrada
        ' 
        txtEntrada.Font = New Font("Segoe UI", 11.25F)
        txtEntrada.Location = New Point(320, 187)
        txtEntrada.Name = "txtEntrada"
        txtEntrada.Size = New Size(200, 27)
        txtEntrada.TabIndex = 2
        ' 
        ' btnAccion
        ' 
        btnAccion.Font = New Font("Segoe UI", 11.25F)
        btnAccion.Location = New Point(320, 240)
        btnAccion.Name = "btnAccion"
        btnAccion.Size = New Size(200, 45)
        btnAccion.TabIndex = 3
        btnAccion.Text = "COMPROBAR"
        btnAccion.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblResultado.Location = New Point(90, 310)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(620, 40)
        lblResultado.TabIndex = 4
        lblResultado.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FRM_NAZA
        ' 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(btnAccion)
        Controls.Add(txtEntrada)
        Controls.Add(lblEntrada)
        Controls.Add(lblConsigna)
        Name = "FRM_NAZA"
        Text = "FRM_NAZA - Numero Primo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblConsigna As Label
    Friend WithEvents lblEntrada As Label
    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents btnAccion As Button
    Friend WithEvents lblResultado As Label
End Class
