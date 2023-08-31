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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        Button2 = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        Apellido = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        FechaNacimiento = New DataGridViewTextBoxColumn()
        Sexo = New DataGridViewTextBoxColumn()
        Eliminar = New DataGridViewButtonColumn()
        Saldo = New DataGridViewTextBoxColumn()
        Foto = New DataGridViewImageColumn()
        Ruta = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Font = New Font("Papyrus", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(69, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(366, 368)
        Panel1.TabIndex = 0
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(207, 106)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(141, 41)
        DateTimePicker1.TabIndex = 14
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.Black
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(118, 314)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 51)
        Button2.TabIndex = 12
        Button2.Text = "Agregar"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(118, 250)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(194, 41)
        TextBox4.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(118, 203)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(194, 41)
        TextBox3.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(25, 253)
        Button1.Name = "Button1"
        Button1.Size = New Size(77, 29)
        Button1.TabIndex = 9
        Button1.Text = "Foto"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(224, 160)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(88, 37)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "Mujer"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(111, 160)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(107, 37)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Hombre"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(166, 54)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(164, 41)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(166, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(164, 41)
        TextBox1.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 211)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 33)
        Label5.TabIndex = 4
        Label5.Text = "Saldo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 33)
        Label4.TabIndex = 3
        Label4.Text = "Sexo:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.System
        Label3.Location = New Point(25, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 33)
        Label3.TabIndex = 2
        Label3.Text = "Fecha Nacimiento:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 33)
        Label2.TabIndex = 1
        Label2.Text = "Apellido:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 33)
        Label1.TabIndex = 0
        Label1.Text = "Nombre:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(474, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(283, 291)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Apellido, Nombre, FechaNacimiento, Sexo, Eliminar, Saldo, Foto, Ruta})
        DataGridView1.Location = New Point(12, 427)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(845, 273)
        DataGridView1.TabIndex = 2
        ' 
        ' Apellido
        ' 
        Apellido.HeaderText = "Apellido"
        Apellido.Name = "Apellido"
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.Name = "Nombre"
        ' 
        ' FechaNacimiento
        ' 
        FechaNacimiento.HeaderText = "Fecha Nacimiento"
        FechaNacimiento.Name = "FechaNacimiento"
        ' 
        ' Sexo
        ' 
        Sexo.HeaderText = "Sexo"
        Sexo.Name = "Sexo"
        ' 
        ' Eliminar
        ' 
        Eliminar.HeaderText = "Eliminar"
        Eliminar.Name = "Eliminar"
        Eliminar.Resizable = DataGridViewTriState.True
        Eliminar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Saldo
        ' 
        Saldo.HeaderText = "Saldo"
        Saldo.Name = "Saldo"
        Saldo.ToolTipText = "Saldo"
        ' 
        ' Foto
        ' 
        Foto.HeaderText = "Foto"
        Foto.Name = "Foto"
        Foto.Resizable = DataGridViewTriState.True
        Foto.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Ruta
        ' 
        Ruta.HeaderText = "Ruta"
        Ruta.Name = "Ruta"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(862, 712)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Formuladrio con Grid"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Foto As DataGridViewImageColumn
    Friend WithEvents Ruta As DataGridViewTextBoxColumn
End Class
