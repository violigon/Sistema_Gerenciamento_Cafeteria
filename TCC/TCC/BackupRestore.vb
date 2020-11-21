Public Class BackupRestore
    Public Function Backup(ByVal strCaminho As String) As String
        Dim objCon As New conexaobd
        Dim strBackup As String

        strBackup = "backup database BDMaisCafe " & vbCrLf _
                    & "to disk = '" & strCaminho & "'" & vbCrLf _
                    & "with name = 'BACKUP_" & Date.Now & "'," & vbCrLf _
                    & "SKIP," & vbCrLf _
                    & "NOUNLOAD," & vbCrLf _
                    & "        STATS = 10"

        Backup = objCon.Backup(strBackup.ToString)

        Return Backup
    End Function

    Public Function Restore(ByVal strCaminho As String) As String
        Dim objCon As New conexaobd
        Dim strRestore As String

        Try


            'Apagar o banco antes de executar este processo
            strRestore = "EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = N'BDMaisCafe' USE [master] ALTER DATABASE  [BDMaisCafe] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE USE [master] DROP DATABASE [BDMaisCafe]" & vbCrLf _
                         & "RESTORE DATABASE BDMaisCafe " & vbCrLf _
                         & "from disk = '" & strCaminho & "'" & vbCrLf _
                         & "with REPLACE, STATS = 10 " & _
                         " USE BDMaisCafe"



            Restore = objCon.Restore(strRestore.ToString)

            Return Restore



        Catch ex As Exception
            MsgBox(Err.Number & " - " & Err.Description, MsgBoxStyle.Critical, "Erro!")

        End Try
        Return True
    End Function

End Class
