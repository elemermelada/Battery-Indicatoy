<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSettings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaxBattery = New System.Windows.Forms.NumericUpDown()
        Me.MinBattery = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveLogs = New System.Windows.Forms.CheckBox()
        Me.LogFreq = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.MaxBattery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinBattery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Max Battery %"
        '
        'MaxBattery
        '
        Me.MaxBattery.Location = New System.Drawing.Point(115, 16)
        Me.MaxBattery.Name = "MaxBattery"
        Me.MaxBattery.Size = New System.Drawing.Size(106, 22)
        Me.MaxBattery.TabIndex = 2
        '
        'MinBattery
        '
        Me.MinBattery.Location = New System.Drawing.Point(115, 47)
        Me.MinBattery.Name = "MinBattery"
        Me.MinBattery.Size = New System.Drawing.Size(106, 22)
        Me.MinBattery.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Min Battery %"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Log Freq. (s)"
        '
        'SaveLogs
        '
        Me.SaveLogs.AutoSize = True
        Me.SaveLogs.Location = New System.Drawing.Point(15, 78)
        Me.SaveLogs.Name = "SaveLogs"
        Me.SaveLogs.Size = New System.Drawing.Size(94, 20)
        Me.SaveLogs.TabIndex = 6
        Me.SaveLogs.Text = "Save Logs"
        Me.SaveLogs.UseVisualStyleBackColor = True
        '
        'LogFreq
        '
        Me.LogFreq.Location = New System.Drawing.Point(115, 107)
        Me.LogFreq.Maximum = New Decimal(New Integer() {3600000, 0, 0, 0})
        Me.LogFreq.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.LogFreq.Name = "LogFreq"
        Me.LogFreq.Size = New System.Drawing.Size(106, 22)
        Me.LogFreq.TabIndex = 7
        Me.LogFreq.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(115, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EditSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 187)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LogFreq)
        Me.Controls.Add(Me.SaveLogs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MinBattery)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MaxBattery)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EditSettings"
        Me.Text = "EditSettings"
        CType(Me.MaxBattery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinBattery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogFreq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MaxBattery As NumericUpDown
    Friend WithEvents MinBattery As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveLogs As CheckBox
    Friend WithEvents LogFreq As NumericUpDown
    Friend WithEvents Button1 As Button
End Class
