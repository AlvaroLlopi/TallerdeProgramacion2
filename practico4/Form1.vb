Imports System.Security.Policy
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim List As ListBox = ListBox1()
        Dim num1 As Integer = TextBox1.Text
        Dim num2 As Integer = TextBox2.Text
        While (num1 <= num2)
            ListBox1.Items.Add(num1.ToString())
            num1 = num1 + 1
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Dim List As ListBox = ListBox1()
        Dim num1 As Integer = TextBox1.Text
        Dim num2 As Integer = TextBox2.Text
        Dim min As Integer
        While (num1 <= num2)
            min = num1
            If (min Mod 2 = 0) Then
                ListBox1.Items.Add(num1.ToString())
            End If
            num1 = num1 + 1
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Dim List As ListBox = ListBox1()
        Dim num1 As Integer = TextBox1.Text
        Dim num2 As Integer = TextBox2.Text
        Dim min As Integer
        While (num1 <= num2)
            min = num1
            If (min Mod 2 <> 0) Then
                ListBox1.Items.Add(num1.ToString())
            End If
            num1 = num1 + 1
        End While
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        Dim List As ListBox = ListBox1()
        Dim inicio As Integer
        Dim fin As Integer

        If Integer.TryParse(TextBox1.Text, inicio) AndAlso Integer.TryParse(TextBox2.Text, fin) Then
            ' Verifica que el valor de inicio sea menor o igual que el valor de fin
            If inicio <= fin Then
                For num As Integer = inicio To fin
                    If EsPrimo(num) Then
                        ListBox1.Items.Add(num.ToString())
                    End If
                Next
            Else
                MessageBox.Show("El valor de inicio debe ser menor o igual al valor de fin.")
            End If
        End If
    End Sub
    Function EsPrimo(numero As Integer) As Boolean
        If numero <= 1 Then
            Return False ' Los números menores o iguales a 1 no son primos
        End If

        For divisor As Integer = 2 To Math.Sqrt(numero)
            If numero Mod divisor = 0 Then
                Return False ' Si es divisible por otro número, no es primo
            End If
        Next

        Return True ' Si no fue divisible por ningún número, es primo
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        Chart1.Series.Clear()
        Chart1.Titles.Clear()
        Chart1.Legends.Clear()
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim series As New Series("Barras")
        series.ChartType = SeriesChartType.Bar



        ' Agregar los valores del ListBox a la serie
        For Each item As Object In ListBox1.Items
            Dim value As Double
            If Double.TryParse(item.ToString(), value) Then
                series.Points.AddXY($"Valor {value}", value)
            End If
        Next

        ' Limpiar el Chart y agregar la serie
        Chart1.Series.Clear()
        Chart1.Series.Add(series)

        ' Agregar leyenda y título
        Dim legend As New Legend()
        legend.Docking = Docking.Bottom
        Chart1.Legends.Add(legend)

        Chart1.Titles.Clear()
        Chart1.Titles.Add("Gráfico de Barras")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim textBox As TextBox = CType(sender, TextBox)
        Dim validInput As String = ""

        For Each c As Char In textBox.Text
            If Char.IsDigit(c) OrElse c = "." Then
                validInput += c
            End If
        Next

        textBox.Text = validInput
        textBox.SelectionStart = textBox.Text.Length
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim textBox As TextBox = CType(sender, TextBox)
        Dim validInput As String = ""

        For Each c As Char In textBox.Text
            If Char.IsDigit(c) OrElse c = "." Then
                validInput += c
            End If
        Next

        textBox.Text = validInput
        textBox.SelectionStart = textBox.Text.Length
    End Sub
End Class
