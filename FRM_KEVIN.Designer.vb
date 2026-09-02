<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_KEVIN
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
        lblConsigna.Text = "TRABAJO PRACTICO - Contador de Vocales" & vbCrLf & vbCrLf &
            "El usuario escribe una palabra o frase. Al presionar el boton, contar cuantas vocales tiene" & vbCrLf &
            "(a, e, i, o, u) sin importar mayusculas o minusculas, y mostrar el total." & vbCrLf &
            "Pista: recorre el texto con For Each letra In txtEntrada.Text y usa ToLower." & vbCrLf &
            "Ejemplo: ""Casa"" tiene 2 vocales."
        ' 
        ' lblEntrada
        ' 
        lblEntrada.AutoSize = True
        lblEntrada.Font = New Font("Segoe UI", 11.25F)
        lblEntrada.Location = New Point(90, 190)
        lblEntrada.Name = "lblEntrada"
        lblEntrada.Size = New Size(120, 20)
        lblEntrada.TabIndex = 1
        lblEntrada.Text = "Texto:"
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
        btnAccion.Text = "CONTAR"
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
        ' FRM_KEVIN
        ' 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(btnAccion)
        Controls.Add(txtEntrada)
        Controls.Add(lblEntrada)
        Controls.Add(lblConsigna)
        Name = "FRM_KEVIN"
        Text = "FRM_KEVIN - Contar Vocales"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblConsigna As Label
    Friend WithEvents lblEntrada As Label
    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents btnAccion As Button
    Friend WithEvents lblResultado As Label
End Class
