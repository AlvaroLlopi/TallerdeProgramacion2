Imports Microsoft.VisualBasic.Logging
Imports System.Security.Policy
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
            Dim imagePath As String = openFileDialog.FileName
            TextBox4.Text = imagePath
        End If
    End Sub

    Function SexoHM() As String
        Dim a As String
        If RadioButton1.Checked Then
            a = "Hombre"
        Else
            a = "Mujer"
        End If
        Return a
    End Function

    Function fechaNacimient() As String
        Dim fecha As String
        fecha = DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year
        Return fecha
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim regexStr As New Regex("^[a-zA-Z]+$") 'Expresion para validar los inputs de tipo texto
        Dim regexNum As New Regex("^[0-9]+$") 'Expresion para validar los inputs de tipo numero
        Dim resultado As DialogResult

        If Not regexStr.IsMatch(TextBox1.Text) Or String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("El campo Nombre no puede estar vacio y/o solo letras", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not regexStr.IsMatch(TextBox2.Text) Or String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("El campo Apellido no puede estar vacio y/o solo letras", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not regexNum.IsMatch(TextBox3.Text) Then
            MessageBox.Show("El campo Saldo no puede estar vacio y/o solo numeros", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            resultado = MessageBox.Show("¿Seguro de que desea insertar un nuevo cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.Yes Then
                Dim apellidonombre As String = TextBox2.Text + " " + TextBox1.Text
                MessageBox.Show("El Cliente: " & apellidonombre & " se ha guardado con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim apellido As String = TextBox2.Text
                Dim nombre As String = TextBox1.Text
                Dim fecha As String = fechaNacimient()
                Dim Sexo As String = SexoHM()
                Dim saldo As Double = TextBox3.Text
                Dim ruta As String = TextBox4.Text
                Eliminar.HeaderText = "Eliminar"
                Eliminar.Text = "Eliminar"
                Eliminar.UseColumnTextForButtonValue = True
                Foto.ImageLayout = DataGridViewImageCellLayout.Stretch

                DataGridView1.Rows.Add(apellido, nombre, fecha, Sexo, Eliminar.Text, saldo, PictureBox1.Image, ruta)

            End If
        End If

    End Sub



    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
        Dim saldoColumnIndex As Integer = DataGridView1.Columns("Saldo").Index

        ' Obtener el valor de saldo de la columna saldo
        Dim saldoValue As Double = CDbl(DataGridView1.Rows(e.RowIndex).Cells(saldoColumnIndex).Value)
        ' Cambiar el color de fondo de la fila si el saldo es negativo
        If saldoValue < 50 Then
            DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red
        Else
            DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White ' Cambiar el color del texto a blanco
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DataGridView1.Columns("Eliminar").Index Then
            DataGridView1.Rows.RemoveAt(e.RowIndex)
        End If

    End Sub
End Class
