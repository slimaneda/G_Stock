Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Module conection

    Public sqlcon As New SqlClient.SqlConnection

    '================================ connecion to sqlserver===============================================
    Public Sub Open_connexion()
        If sqlcon.State = 1 Then sqlcon.Close() ''If a connection is open, close it
        Try
            sqlcon = New SqlConnection("Data Source=DESKTOP-08DDP07\SQLEXPRESS;Initial Catalog=g_stock;Integrated Security=True")
            sqlcon.Open()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    '======================================================================================================

    '================================= Code id  automotaique ==================================================
    Public Function CODE_GEN(TbL_name, ID_) As Integer
        CODE_GEN = 0
        Dim dt As New DataTable
        Dim da As New SqlClient.SqlDataAdapter("SELECT * FROM " & TbL_name & " ORDER BY " & ID_, sqlcon)
        da.Fill(dt)

        If dt.Rows.Count <> 0 Then
            Dim I = dt.Rows.Count - 1
            CODE_GEN = Val(dt.Rows(I).Item(ID_))
        End If

    End Function

    '======================================================================================================
    '================================= Show in  datagridview ==========================================================



    '======================================================================================================
    Public Sub Show_DGV(DGV As DataGridView, num_tbl As String)
        Open_connexion()

        Dim dt As New DataTable
        dt.Clear()
        Dim da As New SqlClient.SqlDataAdapter(num_tbl, sqlcon)


        da.Fill(dt)
        DGV.DataSource = dt.DefaultView
    End Sub



End Module
