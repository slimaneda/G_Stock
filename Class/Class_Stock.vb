Imports System.Data.SqlClient

Public Class Class_Stock
    Private cmd As New SqlCommand
    Private dt As New DataTable


    Public Sub deleted(Num_Proc As String, dgv As DataGridView, code As Integer)
        cmd = New SqlCommand(Num_Proc, sqlcon)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@Code_item", SqlDbType.Int)).Value = code
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgv.DataSource = dt.DefaultView
    End Sub


    Public Sub Show_data_DGV(Num_Proc As String, DGV As DataGridView)
        cmd = New SqlCommand(Num_Proc, sqlcon)
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DGV.DataSource = dt.DefaultView
    End Sub


    '------------------- inserdata ------------------------------
    Sub inserdata(Num_Proc As String, DGV As DataGridView, code As Integer, name As String, Pursh As Double, selling As Double, Optional profil As Double = 0)
        ' تحقق من وجود code_item قبل الإدراج
        If Not CodeItemExists(code) Then
            Using cmd As New SqlCommand(Num_Proc, sqlcon)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@Code_item", SqlDbType.Int)).Value = code
                cmd.Parameters.Add(New SqlParameter("@Name_item", SqlDbType.NVarChar, 50)).Value = name
                cmd.Parameters.Add(New SqlParameter("@Pursh_price", SqlDbType.Decimal, 18, 3)).Value = Pursh
                cmd.Parameters.Add(New SqlParameter("@Selling_price", SqlDbType.Decimal, 18, 3)).Value = selling
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("تم إدراج البيانات بنجاح.")
                Catch ex As Exception
                    MsgBox("حدث خطأ أثناء إدراج البيانات: " & ex.Message)
                End Try
            End Using
        Else
            MsgBox("  موجود مسبقًا في الجدول ولا يمكن إعادة إدراجه code item")
        End If
    End Sub



    ' -----------------تحقق من وجود code_item في الجدول
    Function CodeItemExists(code As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Stock WHERE Code_item = @Code_item"
        Using cmd As New SqlCommand(query, sqlcon)
            cmd.Parameters.Add(New SqlParameter("@Code_item", SqlDbType.Int)).Value = code
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    '------------------------ Updata      ----------------------------
    Sub UpdatDGV(Num_Proc As String, DGV As DataGridView, code As Integer, name As String, Pursh As Double, selling As Double, Optional profil As Double = 0)
        ' تحقق من وجود code_item قبل الإدراج
        If CodeItemExists(code) Then
            Using cmd As New SqlCommand(Num_Proc, sqlcon)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add(New SqlParameter("@Code_item", SqlDbType.Int)).Value = code
                cmd.Parameters.Add(New SqlParameter("@Name_item", SqlDbType.NVarChar, 50)).Value = name
                cmd.Parameters.Add(New SqlParameter("@Pursh_price", SqlDbType.Decimal, 18, 3)).Value = Pursh
                cmd.Parameters.Add(New SqlParameter("@Selling_price", SqlDbType.Decimal, 18, 3)).Value = selling
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("تم تعديل البيانات بنجاح.")
                Catch ex As Exception
                    MsgBox("حدث خطأ أثناء تعديل البيانات: " & ex.Message)
                End Try
            End Using
        Else
            MsgBox("   الرقم المصفوفة غير محدد . المرجو تحديده  لتتمكن من التديل عليه ")
        End If
    End Sub



End Class
