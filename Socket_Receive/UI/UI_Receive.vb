Public Class UI_Receive
    Private _port As Integer = 9100
    Private iSockets As Integer = 0
    Private sRequestID As String

    Private Sub UI_Receive_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AxWinsock1.LocalPort = _port
        Text = AxWinsock1.LocalIP & ":" & AxWinsock1.LocalPort
        KeyPreview = True
        add_log("Start to Port Listening : " & AxWinsock1.LocalPort)
        AxWinsock1.Listen()

    End Sub

    Private Sub AxWinsock1_DataArrival(sender As Object, e As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles AxWinsock1.DataArrival
        add_log(" Received: Data from " & AxWinsock1().RemoteHostIP & "(" & sRequestID & ")")
        Dim strData As Object = vbNullString
        Dim i As Integer
        Dim tstring As String = String.Empty
        AxWinsock1.GetData(strData)
        For i = 0 To UBound(strData)
            tstring = tstring + Chr(strData(i))
        Next
        LB_Data.Items.Add(Now & tstring)
        If LB_Data.Items.Count > 0 Then LB_Data.SelectedIndex = LB_Data.Items.Count - 1

    End Sub

    Private Sub AxWinsock1_CloseEvent(sender As Object, e As EventArgs) Handles AxWinsock1.CloseEvent
        lbl_status.Text = "Status : " + "Disconnect Server"
        add_log(lbl_status.Text)
    End Sub

    Private Sub AxWinsock1_ConnectionRequest(sender As Object, e As AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEvent) Handles AxWinsock1.ConnectionRequest
        If AxWinsock1.CtlState <> MSWinsockLib.StateConstants.sckConnected Then
            add_log("Connection request id " & e.requestID & " from " & AxWinsock1().RemoteHostIP)
            sRequestID = e.requestID
            iSockets = iSockets + 1
            AxWinsock1.Close()
            lbl_status.Text = "Status : " + "Connected Server"
            AxWinsock1.LocalPort = _port
            AxWinsock1.Accept(e.requestID)
            lbl_request_connect.Text = "Connection Request : " & iSockets & " Time"
            add_log(lbl_status.Text)
        End If
    End Sub

    Private Sub add_log(ByVal _msg As String)
        LB_Log.Items.Add(Now & " " & _msg)
        If LB_Log.Items.Count > 0 Then _
             LB_Log.SelectedIndex = LB_Log.Items.Count - 1
    End Sub

End Class