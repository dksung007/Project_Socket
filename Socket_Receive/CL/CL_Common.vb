Public Class CL_Common
    Public UIConfig As UIConfig = Nothing

    Public Const P_CONFIG_FILE_PATH As String = "\Config.xml"



    Public Shared Function readXMLConfig(ByVal FilePath As String, ByVal SectionName As String,
                                     ByVal ValueName As String, Optional ByVal DefaultValue As String = "") As String
        Dim ds As New Data.DataSet
        Dim dt As Data.DataTable = Nothing
        Dim strRetValue As String = DefaultValue

        Try
            ds.ReadXml(FilePath)
            dt = ds.Tables(SectionName)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Try
                    strRetValue = dt.Rows(0).Item(ValueName)
                Catch ex As Exception
                    strRetValue = DefaultValue
                End Try
            End If
            Return strRetValue

        Catch ex As Exception
            Debug.Print("[readXMLConfig] Error: " & ex.Message)
            Return ""
        End Try
    End Function

    Public Shared Function saveXMLConfig(ByVal FilePath As String, ByVal SectionName As String,
                                        ByVal ValueName As String, ByVal Value As String) As Boolean
        Dim ds As New DataSet

        Try
            ds.ReadXml(FilePath)
            If ds.Tables(SectionName).Columns.Contains(ValueName) = False Then
                ds.Tables(SectionName).Columns.Add(ValueName)
            End If
            ds.Tables(SectionName).Rows(0).Item(ValueName) = Value

            ds.WriteXml(FilePath)
            Return True

        Catch ex As Exception
            Debug.Print("[saveXMLConfig] Error: " & ex.Message)
            Return False
        End Try
    End Function


End Class
