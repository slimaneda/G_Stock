Public Class Dashboard












    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FMain.Btn_stock_Click(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FMain.Btn_Selling_Click(sender, e)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FMain.btn_Depts_Click(sender, e)
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msgPrint As MsgBoxResult = MessageBox.Show("Do you wante to close the program ", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If msgPrint = MsgBoxResult.Yes Then
            End
        Else
            Return
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class