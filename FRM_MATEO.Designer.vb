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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MATEO))
        lblConsigna = New Label()
        Button1 = New Button()
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        lblNum1 = New Label()
        lblNum2 = New Label()
        lblResultado = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' lblConsigna
        ' 
        lblConsigna.BackColor = Color.LightYellow
        lblConsigna.BorderStyle = BorderStyle.FixedSingle
        lblConsigna.Font = New Font("Segoe UI", 9.75F)
        lblConsigna.Location = New Point(12, 12)
        lblConsigna.Name = "lblConsigna"
        lblConsigna.Padding = New Padding(8)
        lblConsigna.Size = New Size(770, 120)
        lblConsigna.TabIndex = 1
        lblConsigna.Text = resources.GetString("lblConsigna.Text")
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(148, 250)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 50)
        Button1.TabIndex = 0
        Button1.Text = "Sumar +"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtNum1
        ' 
        txtNum1.Font = New Font("Segoe UI", 12F)
        txtNum1.Location = New Point(260, 157)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(150, 29)
        txtNum1.TabIndex = 3
        ' 
        ' txtNum2
        ' 
        txtNum2.Font = New Font("Segoe UI", 12F)
        txtNum2.Location = New Point(260, 202)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(150, 29)
        txtNum2.TabIndex = 5
        ' 
        ' lblNum1
        ' 
        lblNum1.AutoSize = True
        lblNum1.Font = New Font("Segoe UI", 12F)
        lblNum1.Location = New Point(150, 160)
        lblNum1.Name = "lblNum1"
        lblNum1.Size = New Size(84, 21)
        lblNum1.TabIndex = 2
        lblNum1.Text = "Numero 1:"
        ' 
        ' lblNum2
        ' 
        lblNum2.AutoSize = True
        lblNum2.Font = New Font("Segoe UI", 12F)
        lblNum2.Location = New Point(150, 205)
        lblNum2.Name = "lblNum2"
        lblNum2.Size = New Size(84, 21)
        lblNum2.TabIndex = 4
        lblNum2.Text = "Numero 2:"
        ' 
        ' lblResultado
        ' 
        lblResultado.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblResultado.Location = New Point(150, 320)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(500, 40)
        lblResultado.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.Location = New Point(260, 250)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 50)
        Button2.TabIndex = 7
        Button2.Text = "Restar -"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Button3.Font = New Font("Segoe UI", 12F)
        Button3.Location = New Point(372, 250)
        Button3.Name = "Button3"
        Button3.Size = New Size(105, 50)
        Button3.TabIndex = 8
        Button3.Text = "Multiplicar x"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button4.Font = New Font("Segoe UI", 12F)
        Button4.Location = New Point(501, 250)
        Button4.Name = "Button4"
        Button4.Size = New Size(86, 50)
        Button4.TabIndex = 9
        Button4.Text = "Dividir %"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' FRM_MATEO
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
