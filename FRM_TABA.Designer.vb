<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_TABA
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        Timer1 = New Timer(components)
        Label2 = New Label()
        Button1 = New Button()
        Timer2 = New Timer(components)
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 21)
        Label1.TabIndex = 0
        Label1.Text = "Bienvenido al proyecto de Tabaré"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.persona_caminando
        PictureBox1.Location = New Point(300, 500)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(209, 199)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(30, 415)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(50, 397)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 3
        Label2.Text = "Velocidad"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(689, 415)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 23)
        Button1.TabIndex = 4
        Button1.Text = "Desaparecio :("
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 10
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(689, 10)
        Button2.Name = "Button2"
        Button2.Size = New Size(99, 48)
        Button2.TabIndex = 5
        Button2.Text = "Hola"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FRM_TABA
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "FRM_TABA"
        Text = "FRM_TABA"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button2 As Button
End Class
