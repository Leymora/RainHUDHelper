<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cPathTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cPathApplyButton = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HCRadioButtonDefault = New System.Windows.Forms.RadioButton()
        Me.HCRadioButtonCustomColor = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DWRadioButtonCustomColor = New System.Windows.Forms.RadioButton()
        Me.DWRadioButtonDefault = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AAOButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(775, 425)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AAOButton)
        Me.TabPage1.Controls.Add(Me.cPathApplyButton)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cPathTextBox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(767, 399)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.DWRadioButtonCustomColor)
        Me.TabPage2.Controls.Add(Me.DWRadioButtonDefault)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.HCRadioButtonCustomColor)
        Me.TabPage2.Controls.Add(Me.HCRadioButtonDefault)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(767, 399)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Colors"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "(Default: C:\Program Files\steam\steamapps\common\Team Fortress 2\tf\custom)"
        '
        'cPathTextBox
        '
        Me.cPathTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cPathTextBox.Location = New System.Drawing.Point(165, 29)
        Me.cPathTextBox.Name = "cPathTextBox"
        Me.cPathTextBox.Size = New System.Drawing.Size(515, 22)
        Me.cPathTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Path to TF2 custom folder:"
        '
        'cPathApplyButton
        '
        Me.cPathApplyButton.Location = New System.Drawing.Point(686, 28)
        Me.cPathApplyButton.Name = "cPathApplyButton"
        Me.cPathApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.cPathApplyButton.TabIndex = 3
        Me.cPathApplyButton.Text = "Apply"
        Me.cPathApplyButton.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(767, 399)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Overrides"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Health Color:"
        '
        'HCRadioButtonDefault
        '
        Me.HCRadioButtonDefault.AutoSize = True
        Me.HCRadioButtonDefault.Location = New System.Drawing.Point(91, 27)
        Me.HCRadioButtonDefault.Name = "HCRadioButtonDefault"
        Me.HCRadioButtonDefault.Size = New System.Drawing.Size(59, 17)
        Me.HCRadioButtonDefault.TabIndex = 1
        Me.HCRadioButtonDefault.Text = "Default"
        Me.HCRadioButtonDefault.UseVisualStyleBackColor = True
        '
        'HCRadioButtonCustomColor
        '
        Me.HCRadioButtonCustomColor.AutoSize = True
        Me.HCRadioButtonCustomColor.Location = New System.Drawing.Point(91, 50)
        Me.HCRadioButtonCustomColor.Name = "HCRadioButtonCustomColor"
        Me.HCRadioButtonCustomColor.Size = New System.Drawing.Size(87, 17)
        Me.HCRadioButtonCustomColor.TabIndex = 2
        Me.HCRadioButtonCustomColor.TabStop = True
        Me.HCRadioButtonCustomColor.Text = "Custom Color"
        Me.HCRadioButtonCustomColor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Edit Custom Color"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(229, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Edit Custom Color"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DWRadioButtonCustomColor
        '
        Me.DWRadioButtonCustomColor.AutoSize = True
        Me.DWRadioButtonCustomColor.Location = New System.Drawing.Point(136, 120)
        Me.DWRadioButtonCustomColor.Name = "DWRadioButtonCustomColor"
        Me.DWRadioButtonCustomColor.Size = New System.Drawing.Size(87, 17)
        Me.DWRadioButtonCustomColor.TabIndex = 6
        Me.DWRadioButtonCustomColor.TabStop = True
        Me.DWRadioButtonCustomColor.Text = "Custom Color"
        Me.DWRadioButtonCustomColor.UseVisualStyleBackColor = True
        '
        'DWRadioButtonDefault
        '
        Me.DWRadioButtonDefault.AutoSize = True
        Me.DWRadioButtonDefault.Location = New System.Drawing.Point(136, 97)
        Me.DWRadioButtonDefault.Name = "DWRadioButtonDefault"
        Me.DWRadioButtonDefault.Size = New System.Drawing.Size(59, 17)
        Me.DWRadioButtonDefault.TabIndex = 5
        Me.DWRadioButtonDefault.TabStop = True
        Me.DWRadioButtonDefault.Text = "Default"
        Me.DWRadioButtonDefault.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Death Warning Color:"
        '
        'AAOButton
        '
        Me.AAOButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AAOButton.Location = New System.Drawing.Point(607, 364)
        Me.AAOButton.Name = "AAOButton"
        Me.AAOButton.Size = New System.Drawing.Size(154, 29)
        Me.AAOButton.TabIndex = 4
        Me.AAOButton.Text = "Apply All Options"
        Me.AAOButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RainHUDHelper"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cPathTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cPathApplyButton As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents HCRadioButtonDefault As RadioButton
    Friend WithEvents HCRadioButtonCustomColor As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DWRadioButtonCustomColor As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents AAOButton As Button
    Friend WithEvents DWRadioButtonDefault As RadioButton
End Class
