<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_JORGE
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
        lblContador = New Label()
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
        lblConsigna.Text = "TRABAJO PRACTICO - Contador de Clicks" & vbCrLf & vbCrLf &
            "Ya tenes un boton. Ahora hace que cada vez que se presione, sume 1 a un contador" & vbCrLf &
            "y muestre el total en la etiqueta ""lblContador"" (ej: ""Clicks: 5"")." & vbCrLf &
            "Pista: declara una variable de clase (Dim cuenta As Integer) FUERA del Sub del boton" & vbCrLf &
            "para que no se reinicie en cada click."
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(128, 170)
        Button1.Name = "Button1"
        Button1.Size = New Size(221, 106)
        Button1.TabIndex = 0
        Button1.Text = "Presiona"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblContador
        ' 
        lblContador.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblContador.Location = New Point(400, 190)
        lblContador.Name = "lblContador"
        lblContador.Size = New Size(300, 50)
        lblContador.TabIndex = 2
        lblContador.Text = "Clicks: 0"
        ' 
        ' FRM_JORGE
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblContador)
        Controls.Add(lblConsigna)
        Controls.Add(Button1)
        Name = "FRM_JORGE"
        Text = "FRM_JORGE - Contador de Clicks"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblConsigna As Label
    Friend WithEvents lblContador As Label
End Class
