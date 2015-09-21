<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmdConnect = New System.Windows.Forms.Button()
        Me.CmdSend = New System.Windows.Forms.Button()
        Me.TxtMessage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CmdConnect
        '
        Me.CmdConnect.Location = New System.Drawing.Point(147, 24)
        Me.CmdConnect.Name = "CmdConnect"
        Me.CmdConnect.Size = New System.Drawing.Size(80, 31)
        Me.CmdConnect.TabIndex = 0
        Me.CmdConnect.Text = "Connect"
        Me.CmdConnect.UseVisualStyleBackColor = True
        '
        'CmdSend
        '
        Me.CmdSend.Location = New System.Drawing.Point(339, 62)
        Me.CmdSend.Name = "CmdSend"
        Me.CmdSend.Size = New System.Drawing.Size(81, 31)
        Me.CmdSend.TabIndex = 1
        Me.CmdSend.Text = "Send"
        Me.CmdSend.UseVisualStyleBackColor = True
        '
        'TxtMessage
        '
        Me.TxtMessage.Location = New System.Drawing.Point(12, 68)
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.Size = New System.Drawing.Size(309, 20)
        Me.TxtMessage.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 135)
        Me.Controls.Add(Me.TxtMessage)
        Me.Controls.Add(Me.CmdSend)
        Me.Controls.Add(Me.CmdConnect)
        Me.Name = "Form1"
        Me.Text = "Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdConnect As System.Windows.Forms.Button
    Friend WithEvents CmdSend As System.Windows.Forms.Button
    Friend WithEvents TxtMessage As System.Windows.Forms.TextBox

End Class
