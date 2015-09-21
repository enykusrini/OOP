Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class TCPControl
    Public Event MessageReceived(sender As TCPControl, Data As String)

    'server config
    Public ServerIP As IPAddress = IPAddress.Parse("192.168.43.169")
    Public ServerPort As Integer = 64555
    Public Server As TcpListener

    Private CommThread As Thread
    Public IsListening As Boolean = True

    'client
    Private Client As TcpClient
    Private ClientData As StreamReader

    Public Sub New()
        Server = New TcpListener(ServerIP, ServerPort)
        Server.Start()

        CommThread = New Thread(New ThreadStart(AddressOf Listening))
        CommThread.Start()
    End Sub

    Private Sub Listening()
        'listener loop
        Do Until IsListening = False
            'accept incoming connection
            If Server.Pending = True Then
                Client = Server.AcceptTcpClient
                ClientData = New StreamReader(Client.GetStream)
            End If

            'raise event for incoming message
            Try
                RaiseEvent MessageReceived(Me, ClientData.ReadLine)
            Catch ex As Exception

            End Try

            'reduce cpu usage
            Thread.Sleep(100)
        Loop
    End Sub

End Class
