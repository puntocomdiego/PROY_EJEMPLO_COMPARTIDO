<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DIEGO
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
        txtNombre = New TextBox()
        lblNombre = New Label()
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
        lblConsigna.Size = New Size(886, 120)
        lblConsigna.TabIndex = 1
        lblConsigna.Text = "TRABAJO PRACTICO - Saludo Personalizado" & vbCrLf & vbCrLf &
            "Ya tenes un boton que saluda. Ahora agregale un cuadro de texto (ya esta puesto: txtNombre)." & vbCrLf &
            "Modifica el codigo del boton para que salude a la persona por su nombre: si escribo ""Ana""," & vbCrLf &
            "el mensaje debe decir ""Hola, Ana!"". Si el cuadro esta vacio, mostrar ""Por favor escribi tu nombre""."
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI", 12F)
        lblNombre.Location = New Point(215, 160)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(80, 21)
        lblNombre.TabIndex = 2
        lblNombre.Text = "Nombre:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Font = New Font("Segoe UI", 12F)
        txtNombre.Location = New Point(320, 157)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(280, 29)
        txtNombre.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 20F)
        Button1.Location = New Point(215, 220)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(445, 117)
        Button1.TabIndex = 0
        Button1.Text = "HOLA"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FRM_DIEGO
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(txtNombre)
        Controls.Add(lblNombre)
        Controls.Add(lblConsigna)
        Controls.Add(Button1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FRM_DIEGO"
        Text = "FRM_DIEGO - Saludo Personalizado"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblConsigna As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
End Class
