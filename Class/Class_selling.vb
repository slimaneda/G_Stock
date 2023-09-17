Imports System.Data.SqlClient

Public Class Class_selling

    Private cmd As New SqlCommand
    Private dt As New DataTable
    Sub inserdata(Num_Proc As String, Num_select As String, DGV As DataGridView, code As Integer, name As String, selling As Double, qty As Integer, cstmer As String, datfact As Date)

        If Not CodeItemExists(code) Then
            Using cmd As New SqlCommand(Num_Proc, sqlcon)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add(New SqlParameter("@code_fact", SqlDbType.Int)).Value = code
                cmd.Parameters.Add(New SqlParameter("@Num_item", SqlDbType.NVarChar, 50)).Value = name
                cmd.Parameters.Add(New SqlParameter("@Selling_price", SqlDbType.Decimal, 18, 3)).Value = selling
                cmd.Parameters.Add(New SqlParameter("@Qty", SqlDbType.Decimal, 18, 3)).Value = qty
                cmd.Parameters.Add(New SqlParameter("@Num_customer", SqlDbType.NVarChar, 50)).Value = cstmer
                cmd.Parameters.Add(New SqlParameter("@date_fct", SqlDbType.Date)).Value = datfact



                Try
                    cmd.ExecuteNonQuery()
                    Show_DGV(DGV, Num_select)
                    MsgBox("تم إدراج البيانات بنجاح.")
                Catch ex As Exception
                    MsgBox("حدث خطأ أثناء إدراج البيانات: " & ex.Message)
                End Try
            End Using
        Else
            MsgBox("  موجود مسبقًا في الجدول ولا يمكن إعادة إدراجه code fact")
        End If

    End Sub

    '--------------------- update ------------------------------


    Sub UpdatDGV(Num_Proc As String, Num_select As String, DGV As DataGridView, code_fact As Integer, name As String, selling As Double, qty As Integer, cstmer As String, datfact As Date)
        ' تحقق من وجود code_fact قبل الإدراج
        If CodeItemExists(code_fact) Then
            Using cmd As New SqlCommand(Num_Proc, sqlcon)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add(New SqlParameter("@code_fact", SqlDbType.Int)).Value = code_fact ' تم تغيير المعلمة هنا
                cmd.Parameters.Add(New SqlParameter("@Num_item", SqlDbType.NVarChar, 50)).Value = name
                cmd.Parameters.Add(New SqlParameter("@Selling_price", SqlDbType.Decimal, 18, 3)).Value = selling
                cmd.Parameters.Add(New SqlParameter("@Qty", SqlDbType.Decimal, 18, 3)).Value = qty
                cmd.Parameters.Add(New SqlParameter("@Num_customer", SqlDbType.NVarChar, 50)).Value = cstmer
                cmd.Parameters.Add(New SqlParameter("@date_fct", SqlDbType.Date)).Value = datfact

                Try
                    cmd.ExecuteNonQuery()
                    Show_DGV(DGV, Num_select)
                    MsgBox("تم تعديل البيانات بنجاح.")
                Catch ex As Exception
                    MsgBox("حدث خطأ أثناء تعديل البيانات: " & ex.Message)
                End Try
            End Using
        Else
            MsgBox("   الرقم المصفوفة غير محدد . المرجو تحديده  لتتمكن من التديل عليه ")
        End If
    End Sub



    ' -----------------تحقق من وجود code_item في الجدول
    Function CodeItemExists(code_fact As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM selling WHERE code_fact = @code_fact"
        Using cmd As New SqlCommand(query, sqlcon)
            cmd.Parameters.Add(New SqlParameter("@code_fact", SqlDbType.Int)).Value = code_fact
            Dim count As Integer = CInt(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function


    '---------------- delete data -------------------
    Public Sub deleted(Num_Proc As String, Num_select As String, DGV As DataGridView, code_fct As Integer)

        cmd = New SqlCommand(Num_Proc, sqlcon)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@code_fact", SqlDbType.Int)).Value = code_fct

        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DGV.DataSource = dt.DefaultView

        Show_DGV(DGV, Num_select)



    End Sub


    '---------------- search item---------------
    Sub search_name(Num_Proc As String, name As String, DGV As DataGridView)
        Dim dt As New DataTable
        Using cmd As New SqlCommand(Num_Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure

            ' Ajoutez le paramètre pour la procédure stockée
            cmd.Parameters.Add(New SqlParameter("@Num_item", SqlDbType.NVarChar, 50)).Value = name

            Try
                ' Créez un DataAdapter pour remplir le DataTable
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)

                ' Définissez la source de données du DataGridView
                DGV.DataSource = dt.DefaultView

            Catch ex As Exception
                MsgBox("حدث خطأ أثناء إدراج البيانات: " & ex.Message)
            End Try
        End Using
    End Sub





End Class
