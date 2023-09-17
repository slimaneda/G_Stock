Public Class The_Sales
    Dim _Class_depts As New Class_depts


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        _Class_depts.search_Code("SearchCode_Selling", Val(TextBox3.Text), DGV1)


    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Show_DGV(DGV1, "Selectname_Selling")
    End Sub

    Private Sub Depts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_DGV(dgv2, "SelectCustumer_Selling")
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

        _Class_depts.search_Name("SearchName_Selling", TextBox5.Text, DGV2)
    End Sub
End Class