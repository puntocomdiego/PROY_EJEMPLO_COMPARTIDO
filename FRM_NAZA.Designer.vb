<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_NAZA
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_NAZA))
        txtNombre = New TextBox()
        lblNombre = New Label()
        lblConsigna = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Font = New Font("Segoe UI", 12F)
        txtNombre.Location = New Point(321, 168)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(280, 34)
        txtNombre.TabIndex = 6
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI", 12F)
        lblNombre.Location = New Point(216, 171)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(89, 28)
        lblNombre.TabIndex = 5
        lblNombre.Text = "Nombre:"
        ' 
        ' lblConsigna
        ' 
        lblConsigna.BackColor = Color.LightYellow
        lblConsigna.BorderStyle = BorderStyle.FixedSingle
        lblConsigna.Font = New Font("Segoe UI", 9.75F)
        lblConsigna.Location = New Point(12, 9)
        lblConsigna.Name = "lblConsigna"
        lblConsigna.Padding = New Padding(8)
        lblConsigna.Size = New Size(886, 142)
        lblConsigna.TabIndex = 4
        lblConsigna.Text = resources.GetString("lblConsigna.Text")
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(339, 267)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 47)
        Button1.TabIndex = 7
        Button1.Text = "Hola"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FRM_NAZA
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1267, 478)
        Controls.Add(Button1)
        Controls.Add(txtNombre)
        Controls.Add(lblNombre)
        Controls.Add(lblConsigna)
        Name = "FRM_NAZA"
        Text = "FRM_NAZA"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblConsigna As Label
    Friend WithEvents Button1 As Button
End Class
