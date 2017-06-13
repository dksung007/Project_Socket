Imports System.IO

Public Class CL_Write_Log
    Public Const P_LOG_FILE_PATH As String = "\Log"
    Public Const B_LOG_FILE_PATH As String = "\BroadcastLog"
    Public Shared Sub writeLog(ByVal message As String)
        Try
            Dim strFile As String = String.Empty
            Dim strPath As String = Application.StartupPath & P_LOG_FILE_PATH & "\" & Now.ToString("yyyyMM")

        If Not Directory.Exists(strPath) Then
            Dim di As DirectoryInfo = Directory.CreateDirectory(strPath)
        End If

        strFile = strPath & "\" & Now.ToString("yyyyMMdd") & ".log"

        My.Computer.FileSystem.WriteAllText(strFile,
                                                     Now.ToString("yyyyMMddHHmmss") & " : " & message & vbNewLine,
                                                    True)

        Catch ex As Exception
        Debug.Print("[writeLog] Error: " & ex.Message)
        End Try
    End Sub

    Public Shared Sub CreateLog(ByVal message As String)
        Try
            Dim strFile As String = String.Empty
            Dim strPath As String = Application.StartupPath & B_LOG_FILE_PATH & "\" & Now.ToString("yyyyMM")

            If Not Directory.Exists(strPath) Then
                Dim di As DirectoryInfo = Directory.CreateDirectory(strPath)
            End If

            strFile = strPath & "\" & Now.ToString("yyyyMMddHHmmss") & ".log"

            My.Computer.FileSystem.WriteAllText(strFile, message & vbNewLine, True)

        Catch ex As Exception
            Debug.Print("[CreateLog] Error: " & ex.Message)
        End Try
    End Sub

End Class
