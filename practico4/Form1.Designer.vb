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
        Dim ChartArea2 As DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        ListBox1 = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Chart1 = New DataVisualization.Charting.Chart()
        Button6 = New Button()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(424, 41)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(251, 124)
        ListBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 15)
        Label1.TabIndex = 1
        Label1.Text = "Desde:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 2
        Label2.Text = "Hasta:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(423, 10)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 3
        Label3.Text = "Lista de Numeros:"
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = Color.Blue
        Button1.Location = New Point(264, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(108, 22)
        Button1.TabIndex = 4
        Button1.Text = "Generar Funcion"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(108, 54)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(108, 122)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(264, 113)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 23)
        Button2.TabIndex = 7
        Button2.Text = "Numeros Pares"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(256, 153)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 23)
        Button3.TabIndex = 8
        Button3.Text = "Numeros Impares"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(264, 199)
        Button4.Name = "Button4"
        Button4.Size = New Size(105, 23)
        Button4.TabIndex = 9
        Button4.Text = "Numeros Primos"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(283, 53)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 10
        Button5.Text = "Limpiar"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Chart1
        ' 
        ChartArea2.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Chart1.Legends.Add(Legend2)
        Chart1.Location = New Point(403, 219)
        Chart1.Name = "Chart1"
        Chart1.Palette = DataVisualization.Charting.ChartColorPalette.Bright
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Chart1.Series.Add(Series2)
        Chart1.Size = New Size(311, 135)
        Chart1.TabIndex = 11
        Chart1.Text = "Chart1"
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(264, 272)
        Button6.Name = "Button6"
        Button6.Size = New Size(101, 23)
        Button6.TabIndex = 12
        Button6.Text = "Generar Grafico"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button6)
        Controls.Add(Chart1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Formulario4"
        TransparencyKey = Color.Blue
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Button6 As Button
End Class
