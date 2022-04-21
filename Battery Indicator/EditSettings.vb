Public Class EditSettings
    Dim settings As Object
    Private Sub EditSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load settings
        MinBattery.Value = Int(BatteryIndicator.settings("min") * 100)
        MaxBattery.Value = Int(BatteryIndicator.settings("max") * 100)
        LogFreq.Value = Int(BatteryIndicator.settings("logFreq"))

        SaveLogs.Checked = BatteryIndicator.settings("logs")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        BatteryIndicator.settings("min") = MinBattery.Value / 100
        BatteryIndicator.settings("max") = MaxBattery.Value / 100
        BatteryIndicator.settings("logFreq") = LogFreq.Value
        BatteryIndicator.settings("logs") = SaveLogs.Checked

        BatteryIndicator.applySettings()
        Me.Close()

    End Sub
End Class