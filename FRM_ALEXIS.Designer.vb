<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ALEXIS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        lblCedula = New Label()
        txtCedula = New TextBox()
        btnValidar = New Button()
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
        lblConsigna.Text = "TRABAJO PRACTICO - Validacion de Cedula de Identidad (Uruguay)" & vbCrLf & vbCrLf &
            "Programa el boton VALIDAR para verificar si la cedula es correcta usando el digito verificador." & vbCrLf &
            "1) Tomar los primeros 7 digitos.  2) Multiplicarlos por la serie 2,9,8,7,6,3,4 y sumar los resultados." & vbCrLf &
            "3) Digito verificador = (10 - (suma Mod 10)) Mod 10.  4) Comparar con el 8vo digito ingresado." & vbCrLf &
            "Mostrar en la etiqueta ""CEDULA VALIDA"" (verde) o ""CEDULA INVALIDA"" (rojo). Validar que tenga 8 digitos."
        ' 
        ' lblCedula
        ' 
        lblCedula.AutoSize = True
        lblCedula.Font = New Font("Segoe UI", 11.25F)
        lblCedula.Location = New Point(120, 190)
        lblCedula.Name = "lblCedula"
        lblCedula.Size = New Size(130, 20)
        lblCedula.TabIndex = 1
        lblCedula.Text = "Cedula (8 digitos):"
        ' 
        ' txtCedula
        ' 
        txtCedula.Font = New Font("Segoe UI", 11.25F)
        txtCedula.Location = New Point(270, 187)
        txtCedula.MaxLength = 8
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(200, 27)
        txtCedula.TabIndex = 2
        ' 
        ' btnValidar
        ' 
        btnValidar.Font = New Font("Segoe UI", 11.25F)
        btnValidar.Location = New Point(320, 240)
        btnValidar.Name = "btnValidar"
        btnValidar.Size = New Size(160, 45)
        btnValidar.TabIndex = 3
        btnValidar.Text = "VALIDAR"
        btnValidar.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblResultado.Location = New Point(120, 310)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(560, 40)
        lblResultado.TabIndex = 4
        lblResultado.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FRM_ALEXIS
        ' 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(btnValidar)
        Controls.Add(txtCedula)
        Controls.Add(lblCedula)
        Controls.Add(lblConsigna)
        Name = "FRM_ALEXIS"
        Text = "FRM_ALEXIS - Validacion de Cedula"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblConsigna As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents btnValidar As Button
    Friend WithEvents lblResultado As Label
End Class
