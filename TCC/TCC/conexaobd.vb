Imports System.Data.SqlClient
Imports System.Xml

Public Class conexaobd
    Public objconn As New SqlClient.SqlConnection
    Public dados As New SqlClient.SqlCommand
    Public strConexao As String = "Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True"

    Public Function Conectar(ByVal strCon As String) As SqlClient.SqlConnection 'OleDb.OleDbConnection
        With objconn

            .ConnectionString = strCon
            Try
                .Open()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With
        Return objconn
    End Function

    Public Sub Desconectar()
        Try
            objconn.Close()
            objconn.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function Backup(ByVal str_sql As String) As String

        objconn = Conectar(strConexao)

        With dados
            .CommandText = str_sql.ToString
            .CommandTimeout = 9999
            .CommandType = CommandType.Text
            .Connection = objconn
            Try
                .ExecuteNonQuery()
                Return "Backup Efetuado Com Sucesso!"
            Catch ex As Exception
                Return CStr(MessageBox.Show(ex.Message))
            Finally
                dados.Dispose()
                Desconectar()
            End Try
        End With
    End Function

    Public Function Restore(ByVal str_sql As String) As String
        objconn = Conectar("Data Source=CAROL-PC\SQLSERVERPC;Initial Catalog=BDMaisCafe;Integrated Security=True")

        With dados
            .CommandText = str_sql.ToString
            .CommandTimeout = 9999
            .CommandType = CommandType.Text
            .Connection = objconn
            Try
                .ExecuteNonQuery()
                Return "Restore Efetuado Com Sucesso!"
            Catch ex As Exception
                Return CStr(MessageBox.Show(ex.Message))
            Finally
                dados.Dispose()
                Desconectar()
            End Try
        End With
    End Function
End Class