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
        Me.AACButton = New System.Windows.Forms.Button()
        Me.cPathApplyButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cPathTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.HealthCustomColorCB = New System.Windows.Forms.CheckBox()
        Me.DWCustomColorCB = New System.Windows.Forms.CheckBox()
        Me.WarningText = New System.Windows.Forms.Label()
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
        Me.TabPage1.Controls.Add(Me.AACButton)
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
        'AACButton
        '
        Me.AACButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AACButton.Location = New System.Drawing.Point(607, 364)
        Me.AACButton.Name = "AACButton"
        Me.AACButton.Size = New System.Drawing.Size(154, 29)
        Me.AACButton.TabIndex = 4
        Me.AACButton.Text = "Apply All Changes"
        Me.AACButton.UseVisualStyleBackColor = True
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
        'cPathTextBox
        '
        Me.cPathTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cPathTextBox.Location = New System.Drawing.Point(165, 29)
        Me.cPathTextBox.Name = "cPathTextBox"
        Me.cPathTextBox.Size = New System.Drawing.Size(515, 22)
        Me.cPathTextBox.TabIndex = 1
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DWCustomColorCB)
        Me.TabPage2.Controls.Add(Me.HealthCustomColorCB)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(767, 399)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Colors"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(253, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Edit Custom Color"
        Me.Button2.UseVisualStyleBackColor = True
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Edit Custom Color"
        Me.Button1.UseVisualStyleBackColor = True
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
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(767, 399)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Overrides"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'HealthCustomColorCB
        '
        Me.HealthCustomColorCB.AutoSize = True
        Me.HealthCustomColorCB.Location = New System.Drawing.Point(92, 39)
        Me.HealthCustomColorCB.Name = "HealthCustomColorCB"
        Me.HealthCustomColorCB.Size = New System.Drawing.Size(110, 17)
        Me.HealthCustomColorCB.TabIndex = 8
        Me.HealthCustomColorCB.Text = "Use Custom Color"
        Me.HealthCustomColorCB.UseVisualStyleBackColor = True
        '
        'DWCustomColorCB
        '
        Me.DWCustomColorCB.AutoSize = True
        Me.DWCustomColorCB.Location = New System.Drawing.Point(137, 108)
        Me.DWCustomColorCB.Name = "DWCustomColorCB"
        Me.DWCustomColorCB.Size = New System.Drawing.Size(110, 17)
        Me.DWCustomColorCB.TabIndex = 9
        Me.DWCustomColorCB.Text = "Use Custom Color"
        Me.DWCustomColorCB.UseVisualStyleBackColor = True
        '
        'WarningText
        '
        Me.WarningText.AutoSize = True
        Me.WarningText.ForeColor = System.Drawing.Color.Red
        Me.WarningText.Location = New System.Drawing.Point(391, 441)
        Me.WarningText.Name = "WarningText"
        Me.WarningText.Size = New System.Drawing.Size(397, 13)
        Me.WarningText.TabIndex = 1
        Me.WarningText.Text = "You have unsaved changes! Go to the Settings tab and press ""Apply All Changes"""
        Me.WarningText.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 461)
        Me.Controls.Add(Me.WarningText)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(816, 500)
        Me.MinimumSize = New System.Drawing.Size(816, 500)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RainHUDHelper"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents AACButton As Button
    Friend WithEvents HealthCustomColorCB As CheckBox
    Friend WithEvents DWCustomColorCB As CheckBox
    Friend WithEvents WarningText As Label
End Class
