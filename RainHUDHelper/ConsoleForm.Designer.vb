<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsoleForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomColorValue = New System.Windows.Forms.Label()
        Me.dCustomColorValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CustomColor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "dCustomColor:"
        '
        'CustomColorValue
        '
        Me.CustomColorValue.AutoSize = True
        Me.CustomColorValue.Location = New System.Drawing.Point(87, 9)
        Me.CustomColorValue.Name = "CustomColorValue"
        Me.CustomColorValue.Size = New System.Drawing.Size(13, 13)
        Me.CustomColorValue.TabIndex = 2
        Me.CustomColorValue.Text = "0"
        '
        'dCustomColorValue
        '
        Me.dCustomColorValue.AutoSize = True
        Me.dCustomColorValue.Location = New System.Drawing.Point(87, 34)
        Me.dCustomColorValue.Name = "dCustomColorValue"
        Me.dCustomColorValue.Size = New System.Drawing.Size(13, 13)
        Me.dCustomColorValue.TabIndex = 3
        Me.dCustomColorValue.Text = "0"
        '
        'ConsoleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 196)
        Me.Controls.Add(Me.dCustomColorValue)
        Me.Controls.Add(Me.CustomColorValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ConsoleForm"
        Me.Text = "Console"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CustomColorValue As System.Windows.Forms.Label
    Friend WithEvents dCustomColorValue As System.Windows.Forms.Label
End Class
