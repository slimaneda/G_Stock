

Public Class Form1


    Dim clascode As New Class_coding
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Open_connexion()
        clascode.switchpanel(Panel_Accueil, Accueil, Me)
    End Sub


    '=================== menu button===================
    Public Sub Btn_stock_Click(sender As Object, e As EventArgs) Handles Btn_stock.Click
        clascode.switchpanel(Panel_Accueil, Stock_initial, Me)

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
    Dim clr() As Color = {Color.Red, Color.BlueViolet, Color.Brown, Color.Sienna}
    Dim clrindex As Int16 = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.ForeColor = clr(clrindex)
        clrindex = (clrindex + 1) Mod clr.Length
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label1.RightToLeft += 1
    End Sub



    '=================================================================================
End Class
