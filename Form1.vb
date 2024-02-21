Public Class Form1
    Private Sub sumBtn_Click(sender As Object, e As EventArgs) Handles sumBtn.Click
        SumaControl1.Show()
        DiferenciaControl1.Hide()
        ProductoControl1.Hide()
        DivisionControl1.Hide()
        PotenciaControl1.Hide()
        sumBtn.BackColor = Color.IndianRed
        difBtn.BackColor = Color.Transparent
        prodBtn.BackColor = Color.Transparent
        divBtn.BackColor = Color.Transparent
        potBtn.BackColor = Color.Transparent
    End Sub

    Private Sub difBtn_Click(sender As Object, e As EventArgs) Handles difBtn.Click
        SumaControl1.Hide()
        DiferenciaControl1.Show()
        ProductoControl1.Hide()
        DivisionControl1.Hide()
        PotenciaControl1.Hide()
        sumBtn.BackColor = Color.Transparent
        difBtn.BackColor = Color.IndianRed
        prodBtn.BackColor = Color.Transparent
        divBtn.BackColor = Color.Transparent
        potBtn.BackColor = Color.Transparent
    End Sub

    Private Sub prodBtn_Click(sender As Object, e As EventArgs) Handles prodBtn.Click
        SumaControl1.Hide()
        DiferenciaControl1.Hide()
        ProductoControl1.Show()
        DivisionControl1.Hide()
        PotenciaControl1.Hide()
        sumBtn.BackColor = Color.Transparent
        difBtn.BackColor = Color.Transparent
        prodBtn.BackColor = Color.IndianRed
        divBtn.BackColor = Color.Transparent
        potBtn.BackColor = Color.Transparent
    End Sub

    Private Sub divBtn_Click(sender As Object, e As EventArgs) Handles divBtn.Click
        SumaControl1.Hide()
        DiferenciaControl1.Hide()
        ProductoControl1.Hide()
        DivisionControl1.Show()
        PotenciaControl1.Hide()
        sumBtn.BackColor = Color.Transparent
        difBtn.BackColor = Color.Transparent
        prodBtn.BackColor = Color.Transparent
        divBtn.BackColor = Color.IndianRed
        potBtn.BackColor = Color.Transparent
    End Sub

    Private Sub potBtn_Click(sender As Object, e As EventArgs) Handles potBtn.Click
        SumaControl1.Hide()
        DiferenciaControl1.Hide()
        ProductoControl1.Hide()
        DivisionControl1.Hide()
        PotenciaControl1.Show()
        sumBtn.BackColor = Color.Transparent
        difBtn.BackColor = Color.Transparent
        prodBtn.BackColor = Color.Transparent
        divBtn.BackColor = Color.Transparent
        potBtn.BackColor = Color.IndianRed
    End Sub
End Class
