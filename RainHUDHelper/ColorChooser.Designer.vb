<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorChooser
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
        Me.RSlider = New System.Windows.Forms.TrackBar()
        Me.RedLabel = New System.Windows.Forms.Label()
        Me.GreenLabel = New System.Windows.Forms.Label()
        Me.ResultPanel = New System.Windows.Forms.Panel()
        Me.GSlider = New System.Windows.Forms.TrackBar()
        Me.BSlider = New System.Windows.Forms.TrackBar()
        Me.BlueLabel = New System.Windows.Forms.Label()
        CType(Me.RSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RSlider
        '
        Me.RSlider.LargeChange = 15
        Me.RSlider.Location = New System.Drawing.Point(12, 49)
        Me.RSlider.Maximum = 255
        Me.RSlider.Minimum = 1
        Me.RSlider.Name = "RSlider"
        Me.RSlider.Size = New System.Drawing.Size(401, 45)
        Me.RSlider.SmallChange = 5
        Me.RSlider.TabIndex = 0
        Me.RSlider.TickFrequency = 10
        Me.RSlider.Value = 1
        '
        'RedLabel
        '
        Me.RedLabel.AutoSize = True
        Me.RedLabel.Location = New System.Drawing.Point(192, 33)
        Me.RedLabel.Name = "RedLabel"
        Me.RedLabel.Size = New System.Drawing.Size(27, 13)
        Me.RedLabel.TabIndex = 3
        Me.RedLabel.Text = "Red"
        '
        'GreenLabel
        '
        Me.GreenLabel.AutoSize = True
        Me.GreenLabel.Location = New System.Drawing.Point(189, 95)
        Me.GreenLabel.Name = "GreenLabel"
        Me.GreenLabel.Size = New System.Drawing.Size(36, 13)
        Me.GreenLabel.TabIndex = 5
        Me.GreenLabel.Text = "Green"
        '
        'ResultPanel
        '
        Me.ResultPanel.BackColor = System.Drawing.Color.Black
        Me.ResultPanel.Location = New System.Drawing.Point(164, 230)
        Me.ResultPanel.Name = "ResultPanel"
        Me.ResultPanel.Size = New System.Drawing.Size(103, 100)
        Me.ResultPanel.TabIndex = 8
        '
        'GSlider
        '
        Me.GSlider.LargeChange = 15
        Me.GSlider.Location = New System.Drawing.Point(13, 111)
        Me.GSlider.Maximum = 255
        Me.GSlider.Minimum = 1
        Me.GSlider.Name = "GSlider"
        Me.GSlider.Size = New System.Drawing.Size(401, 45)
        Me.GSlider.SmallChange = 5
        Me.GSlider.TabIndex = 9
        Me.GSlider.TickFrequency = 10
        Me.GSlider.Value = 1
        '
        'BSlider
        '
        Me.BSlider.LargeChange = 15
        Me.BSlider.Location = New System.Drawing.Point(12, 172)
        Me.BSlider.Maximum = 255
        Me.BSlider.Minimum = 1
        Me.BSlider.Name = "BSlider"
        Me.BSlider.Size = New System.Drawing.Size(401, 45)
        Me.BSlider.SmallChange = 5
        Me.BSlider.TabIndex = 11
        Me.BSlider.TickFrequency = 10
        Me.BSlider.Value = 1
        '
        'BlueLabel
        '
        Me.BlueLabel.AutoSize = True
        Me.BlueLabel.Location = New System.Drawing.Point(192, 156)
        Me.BlueLabel.Name = "BlueLabel"
        Me.BlueLabel.Size = New System.Drawing.Size(28, 13)
        Me.BlueLabel.TabIndex = 10
        Me.BlueLabel.Text = "Blue"
        '
        'ColorChooser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 342)
        Me.Controls.Add(Me.BSlider)
        Me.Controls.Add(Me.BlueLabel)
        Me.Controls.Add(Me.GSlider)
        Me.Controls.Add(Me.ResultPanel)
        Me.Controls.Add(Me.GreenLabel)
        Me.Controls.Add(Me.RedLabel)
        Me.Controls.Add(Me.RSlider)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(442, 381)
        Me.MinimumSize = New System.Drawing.Size(442, 381)
        Me.Name = "ColorChooser"
        Me.Text = "Color Chooser"
        CType(Me.RSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSlider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RSlider As TrackBar
    Friend WithEvents RedLabel As Label
    Friend WithEvents GreenLabel As Label
    Friend WithEvents ResultPanel As Panel
    Friend WithEvents GSlider As TrackBar
    Friend WithEvents BSlider As TrackBar
    Friend WithEvents BlueLabel As Label
End Class
