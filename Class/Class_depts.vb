Imports System.Data.SqlClient

Public Class Class_depts
    Public Sub Show_DGV(Num_Proc As String, code As Integer, DGV As DataGridView)

        Using cmd As New SqlCommand(Num_Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add(New SqlParameter("@code_fact", SqlDbType.Int)).Value = code

            Try
                cmd.ExecuteNonQuery()

                Dim dt As New DataTable
                dt.Clear()
                Dim da As New SqlClient.SqlDataAdapter(Num_Proc, sqlcon)

                da.Fill(dt)
                DGV.DataSource = dt.DefaultView
                MsgBox("تم إدراج البيانات بنجاح.")
            Catch ex As Exception
                MsgBox("حدث خطأ أثناء إدراج البيانات: " & ex.Message)
            End Try
        End Using


    End Sub



    Sub search_Name(Num_Proc As String, code As String, DGV As DataGridView)
        Dim dt As New DataTable
        Using cmd As New SqlCommand(Num_Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure

            ' Ajoutez le paramètre pour la procédure stockée
            cmd.Parameters.Add(New SqlParameter("@Num_customer", SqlDbType.NVarChar, 50)).Value = code

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

    Sub search_Code(Num_Proc As String, code As Integer, DGV As DataGridView)
        Dim dt As New DataTable
        Using cmd As New SqlCommand(Num_Proc, sqlcon)
            cmd.CommandType = CommandType.StoredProcedure

            ' Ajoutez le paramètre pour la procédure stockée
            cmd.Parameters.Add(New SqlParameter("@Code_fact", SqlDbType.Int)).Value = code

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
