Public Class Depts
    Dim _Class_depts As New Class_depts
    Private Sub Depts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        _Class_depts.inserdata("search_code_fact", Val(TextBox3.Text), DGV1)


    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Show_DGV(DGV1, "SELECT_dept")
    End Sub
End Class