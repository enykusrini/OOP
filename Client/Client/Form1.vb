Public Class Form1
    Private Client As TCPControl

    Private Sub CmdConnect_Click(sender As Object, e As EventArgs) Handles CmdConnect.Click
        Client = New TCPControl("192.168.43.169", 64555)
        If Client.Client.Connected Then CmdConnect.Text = "Connected"
    End Sub

    Private Sub CmdSend_Click(sender As Object, e As EventArgs) Handles CmdSend.Click
        SendMessage()
        TxtMessage.Clear()
        TxtMessage.Focus()
    End Sub

    Private Sub SendMessage()
        If Client.Client.Connected = True Then Client.Send(TxtMessage.Text)
    End Sub

    Private Sub TxtMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtMessage.KeyDown
        If e.KeyCode = Keys.Enter Then SendMessage()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Client.Client.Connected = True Then
            Client.DataStream.Close()
            Client.Client.Close()
        End If
    End Sub

End Class
