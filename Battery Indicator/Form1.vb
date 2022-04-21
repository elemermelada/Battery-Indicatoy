Imports System.Reflection

Public Class BatteryIndicator

    Public relax As Boolean = False
    Public settings As Object
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Load settings
        If System.IO.File.Exists("appsettings.json") Then       'if exists, read and load settings
            settings = Newtonsoft.Json.JsonConvert.DeserializeObject(System.IO.File.ReadAllText("appsettings.json"))
        Else                                                    'if not, create and load default
            settings = Newtonsoft.Json.JsonConvert.DeserializeObject("{logs: false, logFreq: 60, max: 0.8, min: 0.3}")
        End If

        'Apply settings
        applySettings()

        'Start app
        CheckStatusTimer.Enabled = True
        NotifyIcon.Visible = True

        'show infooo
        'infooo()

    End Sub

    Private Sub infooo()
        Dim log As String = ""
        Dim t As Type = GetType(System.Windows.Forms.PowerStatus)
        Dim pi As PropertyInfo() = t.GetProperties()
        Dim i As Integer
        For i = 0 To pi.Length - 1
            Dim propval As Object = pi(i).GetValue(SystemInformation.PowerStatus, Nothing)
            Log += ControlChars.CrLf + "    PowerStatus." + pi(i).Name + " is: " + propval.ToString()
        Next i
        MsgBox(log)
    End Sub

    Public Sub applySettings()

        'Log stuff
        SaveLogsTimer.Interval = settings("logFreq") * 1000
        SaveLogsTimer.Enabled = settings("logs")

        'Save settings
        System.IO.File.WriteAllText("appsettings.json", Newtonsoft.Json.JsonConvert.SerializeObject(settings))

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles CheckStatusTimer.Tick

        Hide()  'stay hidden

        Dim power As PowerStatus = SystemInformation.PowerStatus
        Dim percent As Single = power.BatteryLifePercent
        Dim charging As Single = power.PowerLineStatus

        If Not relax Then                                               'enough time after last notify has passed
            If percent >= settings("max") And charging = 1 Then                      'battery over 80% and charging (using status 7,8 and 9 as charging???)
                RelaxTimer.Enabled = True
                relax = True
                NotifyIcon.BalloonTipIcon = ToolTipIcon.Warning
                NotifyIcon.BalloonTipTitle = "Battery Indicator"
                NotifyIcon.BalloonTipText = "Battery over " + (percent * 100).ToString + "%"
                NotifyIcon.ShowBalloonTip(5000)
            ElseIf percent <= settings("min") And charging = 0 Then                   'battery under 30% and discharging
                RelaxTimer.Enabled = True
                relax = True
                NotifyIcon.BalloonTipIcon = ToolTipIcon.Warning
                NotifyIcon.BalloonTipTitle = "Battery Indicator"
                NotifyIcon.BalloonTipText = "Battery under " + (percent * 100).ToString + "%"
                NotifyIcon.ShowBalloonTip(5000)
            End If
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles RelaxTimer.Tick
        RelaxTimer.Enabled = False
        relax = False
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        Menu.Show(Cursor.Position)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitOption.Click
        Me.Close()
    End Sub

    Private Sub ChargingStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChargingStatusOption.Click

        Dim power As PowerStatus = SystemInformation.PowerStatus
        Dim percent As Single = power.BatteryLifePercent
        Dim charging As Single = power.PowerLineStatus

        If charging = 1 Then    'really have no idea why this returns 9 instead of 8
            MsgBox("Battery charging (id: " + charging.ToString + ")" + vbNewLine + vbNewLine + "Charge at: " + (percent * 100).ToString + "%")
        Else
            MsgBox("Battery discharging (id: " + charging.ToString + ")" + vbNewLine + vbNewLine + "Charge at: " + (percent * 100).ToString + "%")
        End If

    End Sub

    Private Sub SettingsOption_Click(sender As Object, e As EventArgs) Handles SettingsOption.Click
        EditSettings.Show()
    End Sub

    Private Sub SaveLogsTimer_Tick(sender As Object, e As EventArgs) Handles SaveLogsTimer.Tick

        Dim power As PowerStatus = SystemInformation.PowerStatus
        Dim percent As Single = power.BatteryLifePercent
        Dim charging As Single = power.PowerLineStatus

        Dim unix As Double = Int((DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds)

        If Not settings("logs") Then
            SaveLogsTimer.Enabled = False
        End If

        System.IO.File.AppendAllText("log.csv", vbNewLine + unix.ToString + ", " + percent.ToString + ", " + charging.ToString)

    End Sub

End Class
