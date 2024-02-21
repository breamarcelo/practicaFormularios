Public Class DivisionControl
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, resultado As Integer
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Dim errorMsg As String = "Debe rellenar todos los campos"
            MessageBox.Show(errorMsg)
        Else
            num1 = TextBox1.Text
            num2 = TextBox2.Text
            If num2 = 0 Then
                Dim ceroMsg As String = "No es posible dividir entre cero (0)"
                MessageBox.Show(ceroMsg)
            Else
                resultado = num1 / num2
                Label1.Text = resultado
            End If
        End If
    End Sub
End Class
