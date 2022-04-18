Public Class Form1

    Dim relax As Boolean = False

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim power As PowerStatus = SystemInformation.PowerStatus
        Dim percent As Single = power.BatteryLifePercent
        Timer1.Enabled = True
        NotifyIcon1.Visible = True

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        Hide()  'stay hidden

        Dim power As PowerStatus = SystemInformation.PowerStatus
        Dim percent As Single = power.BatteryLifePercent
        Dim charge As Single = power.BatteryChargeStatus

        If Not relax Then                                               'enough time after last notify has passed

            If percent >= 0.8 And charge >= 8 Then                      'battery over 80% and charging (using status 7,8 and 9 as charging???)

                Timer2.Enabled = True
                relax = True
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
                NotifyIcon1.BalloonTipTitle = "Battery Indicator"
                NotifyIcon1.BalloonTipText = "Battery over " + (percent * 100).ToString + "%"
                NotifyIcon1.ShowBalloonTip(5000)

            ElseIf percent <= 0.3 And charge < 8 Then                   'battery under 30% and discharging

                Timer2.Enabled = True
                relax = True
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Warning
                NotifyIcon1.BalloonTipTitle = "Battery Indicator"
                NotifyIcon1.BalloonTipText = "Battery under " + (percent * 100).ToString + "%"
                NotifyIcon1.ShowBalloonTip(5000)

            End If

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Timer2.Enabled = False
        relax = False

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

    Private Sub ChargingStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChargingStatusToolStripMenuItem.Click

        Dim power As PowerStatus = SystemInformation.PowerStatus
        Dim charge As Single = power.BatteryChargeStatus

        If charge >= 8 Then    'really have no idea why this returns 9 instead of 8
            MsgBox("Battery charging: " + charge.ToString)
        Else
            MsgBox("Battery discharging: " + charge.ToString)
        End If

    End Sub
End Class
