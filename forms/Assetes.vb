Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Devices

Public Class Assetes
    Dim _Class_Stock As New Class_Stock


    Private Sub Stock_initial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Open_connexion()
        Show_DGV(DGV, "Select_Stock")
        '_Class_Stock.Show_data_DGV("Selectall", DGV)
        txt_name.Select()
        txt_code.Text = CODE_GEN("Stock", "code_item") + 1

    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick

        If e.RowIndex >= 0 Then

            txt_code.Text = DGV.Rows(e.RowIndex).Cells(0).Value.ToString()
            txt_name.Text = DGV.Rows(e.RowIndex).Cells(1).Value.ToString()
            txt_purchasing.Text = DGV.Rows(e.RowIndex).Cells(2).Value.ToString()
            txt_selling.Text = DGV.Rows(e.RowIndex).Cells(3).Value.ToString()

        End If
    End Sub



    '--------------search items --------
    Private Sub txt_nameitme_TextChanged(sender As Object, e As EventArgs) Handles txt_nameitme.TextChanged
        Show_DGV(DGV, "SELECT Code_item, Name_item,Pursh_price,Selling_price ,(Selling_price- Pursh_price) as Profil FROM Stock WHERE Name_item Like'%" & txt_nameitme.Text & "%'")

    End Sub



    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        txt_code.Text = CODE_GEN("Stock", "code_item") + 1
        txt_name.Text = ""
        txt_purchasing.Text = ""
        txt_selling.Text = ""
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        _Class_Stock.deleted("DELETE_Stock", DGV, Val(txt_code.Text))
        Show_DGV(DGV, "Select_Stock")
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        _Class_Stock.inserdata("ADD_Stock", DGV, Val(txt_code.Text), txt_name.Text, Val(txt_purchasing.Text), Val(txt_selling.Text))
        txt_code.Text = CODE_GEN("Stock", "code_item") + 1
        txt_name.Text = ""
        txt_purchasing.Text = ""
        txt_selling.Text = ""
        Show_DGV(DGV, "Select_Stock")
    End Sub

    Private Sub btn_modify_Click(sender As Object, e As EventArgs) Handles btn_modify.Click
        '_Class_Stock.UpdateDGV(txt_name.Text, Val(txt_purchasing.Text), Val(txt_selling.Text))
        _Class_Stock.UpdatDGV("Update_Stock", DGV, Val(txt_code.Text), txt_name.Text, Val(txt_purchasing.Text), Val(txt_selling.Text))
        Show_DGV(DGV, "Select_Stock")

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        btn_add_Click(sender, e)



    End Sub

    Private Sub btn_updating_Click(sender As Object, e As EventArgs) Handles btn_updating.Click
        Show_DGV(DGV, "Select_Stock")
        MsgBox("تم التحديث بنجاح")
    End Sub


End Class