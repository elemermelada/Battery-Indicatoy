<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatteryIndicator
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BatteryIndicator))
        Me.CheckStatusTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargingStatusOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelaxTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SaveLogsTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckStatusTimer
        '
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "Battery Indicator"
        Me.NotifyIcon.Visible = True
        '
        'Menu
        '
        Me.Menu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitOption, Me.ChargingStatusOption, Me.SettingsOption})
        Me.Menu.Name = "ContextMenuStrip1"
        Me.Menu.Size = New System.Drawing.Size(183, 76)
        '
        'ExitOption
        '
        Me.ExitOption.Name = "ExitOption"
        Me.ExitOption.Size = New System.Drawing.Size(182, 24)
        Me.ExitOption.Text = "Exit"
        '
        'ChargingStatusOption
        '
        Me.ChargingStatusOption.Name = "ChargingStatusOption"
        Me.ChargingStatusOption.Size = New System.Drawing.Size(182, 24)
        Me.ChargingStatusOption.Text = "Charging Status"
        '
        'SettingsOption
        '
        Me.SettingsOption.Name = "SettingsOption"
        Me.SettingsOption.Size = New System.Drawing.Size(182, 24)
        Me.SettingsOption.Text = "Settings"
        '
        'RelaxTimer
        '
        Me.RelaxTimer.Interval = 60000
        '
        'SaveLogsTimer
        '
        Me.SaveLogsTimer.Interval = 60000
        '
        'BatteryIndicator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(148, 0)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BatteryIndicator"
        Me.Menu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckStatusTimer As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents Menu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitOption As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelaxTimer As Timer
    Friend WithEvents ChargingStatusOption As ToolStripMenuItem
    Friend WithEvents SettingsOption As ToolStripMenuItem
    Friend WithEvents SaveLogsTimer As Timer
End Class
