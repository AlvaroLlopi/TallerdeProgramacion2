﻿Imports System.Net.Mime.MediaTypeNames

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        TextBox4 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Button3 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 0
        Label1.Text = "*DNI:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 1
        Label2.Text = "*Apellido:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(28, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 2
        Label3.Text = "*Nombre:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(28, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 15)
        Label4.TabIndex = 3
        Label4.Text = "Nombre y Apellido: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(159, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 15)
        Label5.TabIndex = 4
        Label5.Text = "Modificar"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(143, 74)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(143, 127)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(143, 179)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.Image = My.Resources.Resources.salvar
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(27, 526)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 73)
        Button1.TabIndex = 8
        Button1.Text = "Guardar"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Image = My.Resources.Resources.hombre_Eliminar
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(234, 526)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 73)
        Button2.TabIndex = 9
        Button2.Text = "Eliminar"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(27, 65)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(272, 411)
        Panel1.TabIndex = 10
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(156, 335)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(85, 19)
        CheckBox3.TabIndex = 17
        CheckBox3.Text = "Mastercard"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(156, 310)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(47, 19)
        CheckBox2.TabIndex = 16
        CheckBox2.Text = "Visa"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(156, 285)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 19)
        CheckBox1.TabIndex = 15
        CheckBox1.Text = "Naranja"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(143, 227)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(28, 286)
        Label8.Name = "Label8"
        Label8.Size = New Size(113, 15)
        Label8.TabIndex = 13
        Label8.Text = "Tarjetas De Creditos:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(28, 235)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 15)
        Label7.TabIndex = 12
        Label7.Text = "*Telefono:"
        ' 
        ' Label6
        ' 
        Label6.AutoEllipsis = True
        Label6.AutoSize = True
        Label6.ForeColor = Color.DodgerBlue
        Label6.Location = New Point(249, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 15)
        Label6.TabIndex = 15
        Label6.Text = "Nuevo Cliente"
        ' 
        ' Button3
        ' 
        Button3.Image = My.Resources.Resources.salir
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(572, 526)
        Button3.Name = "Button3"
        Button3.Size = New Size(125, 73)
        Button3.TabIndex = 12
        Button3.Text = "Salir"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(439, 327)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(55, 19)
        RadioButton1.TabIndex = 13
        RadioButton1.TabStop = True
        RadioButton1.Text = "Varon"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(575, 327)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(56, 19)
        RadioButton2.TabIndex = 14
        RadioButton2.TabStop = True
        RadioButton2.Text = "Mujer"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.perfilhombre1
        PictureBox1.Location = New Point(470, 142)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(133, 134)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(750, 650)
        Controls.Add(PictureBox1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Button3)
        Controls.Add(Label6)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pequeño Formulario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
