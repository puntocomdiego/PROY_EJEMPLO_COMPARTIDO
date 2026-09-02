<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_DAHIANA
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
        Button2 = New Button()
        Button3 = New Button()
        pnlLuz = New Panel()
        SuspendLayout()
        ' 
        ' lblConsigna
        ' 
        lblConsigna.BackColor = Color.LightYellow
        lblConsigna.BorderStyle = BorderStyle.FixedSingle
        lblConsigna.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular)
        lblConsigna.Location = New Point(12, 9)
        lblConsigna.Name = "lblConsigna"
        lblConsigna.Padding = New Padding(8)
        lblConsigna.Size = New Size(770, 115)
        lblConsigna.TabIndex = 3
        lblConsigna.Text = "TRABAJO PRACTICO - Semaforo" & vbCrLf & vbCrLf &
            "Ya sabes cambiar colores. Ahora hace un semaforo: los 3 botones se llaman ROJO, AMARILLO y VERDE." & vbCrLf &
            "Al presionar cada uno, el recuadro grande (pnlLuz) debe pintarse de ese color." & vbCrLf &
            "Pista: pnlLuz.BackColor = Color.Red   (y asi con cada boton)."
        ' 
        ' pnlLuz
        ' 
        pnlLuz.BorderStyle = BorderStyle.FixedSingle
        pnlLuz.Location = New Point(316, 150)
        pnlLuz.Name = "pnlLuz"
        pnlLuz.Size = New Size(160, 160)
        pnlLuz.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(60, 180)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 60)
        Button1.TabIndex = 0
        Button1.Text = "ROJO"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(590, 180)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 60)
        Button2.TabIndex = 1
        Button2.Text = "AMARILLO"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(316, 340)
        Button3.Name = "Button3"
        Button3.Size = New Size(160, 60)
        Button3.TabIndex = 2
        Button3.Text = "VERDE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' FRM_DAHIANA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pnlLuz)
        Controls.Add(lblConsigna)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "FRM_DAHIANA"
        Text = "FRM_DAHIANA - Semaforo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblConsigna As Label
    Friend WithEvents pnlLuz As Panel
End Class
