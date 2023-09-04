Public Class Form1
    Dim clascode As New Class_coding
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        clascode.switchpanel(Panel_Accueil, Accueil, Me)
    End Sub


    '=================== menu button===================
    Public Sub Btn_stock_Click(sender As Object, e As EventArgs) Handles Btn_stock.Click
        clascode.switchpanel(Panel_Accueil, Stock, Me)

    End Sub


    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs) Handles Btn_Accueil.Click

        clascode.switchpanel(Panel_Accueil, Accueil, Me)
    End Sub


    Public Sub btn_Depts_Click(sender As Object, e As EventArgs) Handles btn_Depts.Click
        clascode.switchpanel(Panel_Accueil, Depts, Me)
    End Sub

    Public Sub Btn_Selling_Click(sender As Object, e As EventArgs) Handles Btn_Selling.Click
        clascode.switchpanel(Panel_Accueil, Selling, Me)
    End Sub



    '=================================================================================
End Class
