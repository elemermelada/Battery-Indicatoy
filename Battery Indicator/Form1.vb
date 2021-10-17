Public Class Form1

    Dim curbat As Double = 0

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim power As PowerStatus = SystemInformation.PowerStatus
        Dim percent As Single = power.BatteryLifePercent
        curbat = percent
        Timer1.Enabled = True
        NotifyIcon1.Visible = True

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Hide()

        Dim power As PowerStatus = SystemInformation.PowerStatus
        Dim percent As Single = power.BatteryLifePercent

        If Not curbat = percent Then

            If percent = 0.8 And percent > curbat Then

                curbat = percent
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
                NotifyIcon1.BalloonTipTitle = "Battery Indicator"
                NotifyIcon1.BalloonTipText = "Battery at 80%"
                NotifyIcon1.ShowBalloonTip(5000)

            ElseIf percent = 0.3 And percent < curbat Then

                curbat = percent
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
                NotifyIcon1.BalloonTipTitle = "Battery Indicator"
                NotifyIcon1.BalloonTipText = "Battery at 30%"
                NotifyIcon1.ShowBalloonTip(5000)

            End If

        End If

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick

        ContextMenuStrip1.Show(Cursor.Position)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub

    Private Sub BatteryStatusToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BatteryStatusToolStripMenuItem.Click

        Dim power As PowerStatus = SystemInformation.PowerStatus
        Dim percent As Single = power.BatteryLifePercent

        MsgBox("Battery at " + percent.ToString)


    End Sub

End Class
