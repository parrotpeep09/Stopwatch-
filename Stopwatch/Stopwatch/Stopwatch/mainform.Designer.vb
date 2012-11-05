<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblShowElapsed = New System.Windows.Forms.Label()
        Me.lblLapTime1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(101, 33)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 28)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Stopwatch"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(101, 80)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(100, 28)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop Stopwatch"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblShowElapsed
        '
        Me.lblShowElapsed.AutoSize = True
        Me.lblShowElapsed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowElapsed.Location = New System.Drawing.Point(147, 154)
        Me.lblShowElapsed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblShowElapsed.Name = "lblShowElapsed"
        Me.lblShowElapsed.Size = New System.Drawing.Size(2, 19)
        Me.lblShowElapsed.TabIndex = 2
        '
        'lblLapTime1
        '
        Me.lblLapTime1.AutoSize = True
        Me.lblLapTime1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLapTime1.Location = New System.Drawing.Point(147, 198)
        Me.lblLapTime1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLapTime1.Name = "lblLapTime1"
        Me.lblLapTime1.Size = New System.Drawing.Size(2, 19)
        Me.lblLapTime1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 254)
        Me.Controls.Add(Me.lblLapTime1)
        Me.Controls.Add(Me.lblShowElapsed)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mainform"
        Me.Text = "Stopwatch Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lblShowElapsed As System.Windows.Forms.Label
    Friend WithEvents lblLapTime1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
