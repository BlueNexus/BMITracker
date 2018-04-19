Imports Microsoft.VisualBasic

Public Class dbfunc

    Public Shared Function add_to_table(ByRef target As String, ByVal weight As Integer, ByVal bmi As Integer)
        Dim success = True
        Try
            Using cn As New OleDb.OleDbConnection With {.ConnectionString = target}
                Using cmd As New OleDb.OleDbCommand With {.Connection = cn}
                    cmd.CommandText = "INSERT INTO Table1 (Weight, BMI) VALUES (@weight, @3);"
                    cmd.Parameters.AddWithValue("@weight", weight)
                    cmd.Parameters.AddWithValue("@3", bmi)
                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            success = False
        End Try
        Return success
    End Function
End Class
