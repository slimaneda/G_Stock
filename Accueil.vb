Public Class Accueil

    Private Sub txt_stock_Click(sender As Object, e As EventArgs) Handles txt_stock.Click

        Form1.Btn_stock_Click(sender, e)
    End Sub


    Private Sub txt_dept_Click(sender As Object, e As EventArgs) Handles txt_dept.Click
        Form1.btn_Depts_Click(sender, e)
    End Sub




    Private Sub txt_sellitms_Click(sender As Object, e As EventArgs) Handles txt_sellitms.Click
        Form1.Btn_Selling_Click(sender, e)
    End Sub
End Class