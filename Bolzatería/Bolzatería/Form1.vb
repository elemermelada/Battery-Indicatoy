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

            If percent = 0.8 Then

                curbat = percent
                MsgBox("Battery at 80%")

            ElseIf percent = 0.3 Then

                curbat = percent
                MsgBox("Battery at 30%")

            End If

        End If

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick

        ContextMenuStrip1.Show(Cursor.Position)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click

        Me.Close()

    End Sub

    Private Sub BatteryLevelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BatteryLevelToolStripMenuItem.Click

        Dim power As PowerStatus = SystemInformation.PowerStatus
        Dim percent As Single = power.BatteryLifePercent

        MsgBox("Battery at " + percent.ToString)


    End Sub

End Class
