Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class New_Sale
    Private Sub Selling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DGV1.DataSource = Stock_initial.DGV.DataSource

        'Show_DGV(DGV1, " SelectNum_Selling")
        Show_DGV(DGV2, "SELECT_selling")
        GroupBox1.Enabled = False

    End Sub
    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        Selling_Load(sender, e)
    End Sub

    Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
        If e.RowIndex >= 0 Then

            txt_name.Text = DGV1.Rows(e.RowIndex).Cells(0).Value.ToString()
            txt_selling.Text = DGV1.Rows(e.RowIndex).Cells(1).Value.ToString()


        End If
    End Sub
    Dim _Class_selling As New Class_selling
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        _Class_selling.inserdata("ADD_selling", "SELECT_selling", DGV2, Val(txt_codefact.Text), txt_name.Text, Val(txt_selling.Text), Val(Txt_qty.Text), txt_num_cstmer.Text, date_shoping.Value.Date)
        txt_codefact.Text = CODE_GEN("selling", "Code_fact") + 1

    End Sub

    Private Sub btn_showall_Click(sender As Object, e As EventArgs) Handles btn_showall.Click

        Show_DGV(DGV2, "SELECT_sellingall")
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        _Class_selling.deleted("DELETE_Selling", "SELECT_selling", DGV2, Val(txt_codefact.Text))
    End Sub

    Private Sub DGV2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellClick
        If e.RowIndex >= 0 Then
            txt_codefact.Text = DGV2.Rows(e.RowIndex).Cells(0).Value.ToString()
            txt_name.Text = DGV2.Rows(e.RowIndex).Cells(1).Value.ToString()
            txt_num_cstmer.Text = DGV2.Rows(e.RowIndex).Cells(2).Value.ToString()
            Txt_qty.Text = DGV2.Rows(e.RowIndex).Cells(3).Value.ToString()
            txt_selling.Text = DGV2.Rows(e.RowIndex).Cells(4).Value.ToString()
            date_shoping.Value = Convert.ToDateTime(DGV2.Rows(e.RowIndex).Cells(6).Value)
        End If
    End Sub



    Sub up()

    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        GroupBox1.Enabled = True
        txt_codefact.Text = CODE_GEN("selling", "Code_fact") + 1
        txt_name.Text = ""
        txt_num_cstmer.Text = ""
        Txt_qty.Text = ""
        txt_selling.Text = ""
        date_shoping.Value = Today

    End Sub

    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        _Class_selling.UpdatDGV("ADD_selling", "SELECT_selling", DGV2, Val(txt_codefact.Text), txt_name.Text, Val(txt_selling.Text), Val(Txt_qty.Text), txt_num_cstmer.Text, date_shoping.Value.Date)


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        _Class_selling.search_name("SearchNum_Stock", TextBox4.Text, DGV1)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        txt_name.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        txt_selling.Enabled = True
    End Sub






End Class