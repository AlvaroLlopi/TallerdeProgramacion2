Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim regexStr As New Regex("^[a-zA-Z]+$") 'Expresion para validar los inputs de tipo texto
        Dim regexNum As New Regex("^[0-9]+$") 'Expresion para validar los inputs de tipo numero
        Dim resultado As DialogResult

        Dim cadena As String = TextBox2.Text
        Dim cadena1 As String = TextBox3.Text
        Label5.Text = String.Concat(cadena, " ", cadena1)

        If Not regexNum.IsMatch(TextBox1.Text) Or String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("El campo DNI no puede estar vacio y/o solo numeros", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not regexStr.IsMatch(TextBox2.Text) Or String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("El campo Apellido no puede estar vacio y/o solo letras", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not regexStr.IsMatch(TextBox3.Text) Then
            MessageBox.Show("El campo Nombre no puede estar vacio y/o solo letras", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not regexNum.IsMatch(TextBox4.Text) Or String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("El campo Telefono no puede estar vacio y/o solo numeros", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            resultado = MessageBox.Show("¿Seguro de que desea insertar un nuevo cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resultado = DialogResult.Yes Then
                MessageBox.Show("El Cliente: " & Label5.Text & " se ha guardado con exito", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim resultado1 As DialogResult
        Dim cadena As String = TextBox2.Text
        Dim cadena1 As String = TextBox3.Text
        Label5.Text = String.Concat(cadena, " ", cadena1)
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            resultado1 = MessageBox.Show("Estas a punto de eliminar el cliente: " & Label5.Text, "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Los campos estan vacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        If resultado1 = DialogResult.Yes Then
            MessageBox.Show("Se Elimino el cliente : " & Label5.Text, "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            PictureBox1.Image = My.Resources.perfilhombre2
        Else
            PictureBox1.Image = My.Resources.perfilmujer2
        End If
    End Sub

    Private Sub TDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If e.Handled Then
            MessageBox.Show("Por favor, ingresa solo números en este campo.", "Error DNI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
