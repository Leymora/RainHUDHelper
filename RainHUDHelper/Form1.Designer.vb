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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.SettingsPage = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PathTextBox = New System.Windows.Forms.TextBox()
        Me.ColorsPage = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeathWarningPanel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PHV_Text = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB = New System.Windows.Forms.Button()
        Me.MB = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HVPic = New System.Windows.Forms.PictureBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CuNo = New System.Windows.Forms.RadioButton()
        Me.CuYes = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.SettingsPage.SuspendLayout()
        Me.ColorsPage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HVPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.SettingsPage)
        Me.TabControl1.Controls.Add(Me.ColorsPage)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(746, 445)
        Me.TabControl1.TabIndex = 2
        '
        'SettingsPage
        '
        Me.SettingsPage.BackColor = System.Drawing.SystemColors.Control
        Me.SettingsPage.Controls.Add(Me.Button1)
        Me.SettingsPage.Controls.Add(Me.Label3)
        Me.SettingsPage.Controls.Add(Me.Label2)
        Me.SettingsPage.Controls.Add(Me.PathTextBox)
        Me.SettingsPage.Location = New System.Drawing.Point(4, 22)
        Me.SettingsPage.Name = "SettingsPage"
        Me.SettingsPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SettingsPage.Size = New System.Drawing.Size(738, 419)
        Me.SettingsPage.TabIndex = 0
        Me.SettingsPage.Text = "Settings"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(308, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(169, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(425, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "(Default path:  C:\Program Files\Steam\steamapps\common\Team Fortress 2\tf\custom" & _
            ")"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = """Custom"" folder path:"
        '
        'PathTextBox
        '
        Me.PathTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PathTextBox.Location = New System.Drawing.Point(6, 39)
        Me.PathTextBox.Name = "PathTextBox"
        Me.PathTextBox.Size = New System.Drawing.Size(726, 27)
        Me.PathTextBox.TabIndex = 0
        '
        'ColorsPage
        '
        Me.ColorsPage.Controls.Add(Me.Label6)
        Me.ColorsPage.Controls.Add(Me.DeathWarningPanel)
        Me.ColorsPage.Controls.Add(Me.Label5)
        Me.ColorsPage.Controls.Add(Me.Button5)
        Me.ColorsPage.Controls.Add(Me.Button3)
        Me.ColorsPage.Controls.Add(Me.Button4)
        Me.ColorsPage.Controls.Add(Me.Label4)
        Me.ColorsPage.Controls.Add(Me.Button2)
        Me.ColorsPage.Controls.Add(Me.PHV_Text)
        Me.ColorsPage.Controls.Add(Me.Label1)
        Me.ColorsPage.Controls.Add(Me.GB)
        Me.ColorsPage.Controls.Add(Me.MB)
        Me.ColorsPage.Controls.Add(Me.PictureBox1)
        Me.ColorsPage.Controls.Add(Me.HVPic)
        Me.ColorsPage.Location = New System.Drawing.Point(4, 22)
        Me.ColorsPage.Name = "ColorsPage"
        Me.ColorsPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ColorsPage.Size = New System.Drawing.Size(738, 419)
        Me.ColorsPage.TabIndex = 1
        Me.ColorsPage.Text = "Colors"
        Me.ColorsPage.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(167, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Current color"
        '
        'DeathWarningPanel
        '
        Me.DeathWarningPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeathWarningPanel.Location = New System.Drawing.Point(135, 217)
        Me.DeathWarningPanel.Name = "DeathWarningPanel"
        Me.DeathWarningPanel.Size = New System.Drawing.Size(26, 25)
        Me.DeathWarningPanel.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(277, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "(NOTE: The preview picture doesn't change color)"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(426, 166)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(82, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "Custom Color"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(283, 166)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Gold"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(338, 166)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Magenta"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(137, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Death Warning Color:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(397, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Custom Color"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PHV_Text
        '
        Me.PHV_Text.AutoSize = True
        Me.PHV_Text.Font = New System.Drawing.Font("OldStyle 1", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHV_Text.Location = New System.Drawing.Point(10, 14)
        Me.PHV_Text.Name = "PHV_Text"
        Me.PHV_Text.Size = New System.Drawing.Size(72, 51)
        Me.PHV_Text.TabIndex = 6
        Me.PHV_Text.Text = "175"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Player Health Color:"
        '
        'GB
        '
        Me.GB.Location = New System.Drawing.Point(235, 35)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(49, 23)
        Me.GB.TabIndex = 2
        Me.GB.Text = "Gold"
        Me.GB.UseVisualStyleBackColor = True
        '
        'MB
        '
        Me.MB.Location = New System.Drawing.Point(290, 35)
        Me.MB.Name = "MB"
        Me.MB.Size = New System.Drawing.Size(60, 23)
        Me.MB.TabIndex = 3
        Me.MB.Text = "Magenta"
        Me.MB.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.DeathWarning_Image
        Me.PictureBox1.Location = New System.Drawing.Point(3, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 128)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'HVPic
        '
        Me.HVPic.Image = Global.WindowsApplication1.My.Resources.Resources.PHC_Background
        Me.HVPic.Location = New System.Drawing.Point(3, 6)
        Me.HVPic.Name = "HVPic"
        Me.HVPic.Size = New System.Drawing.Size(86, 83)
        Me.HVPic.TabIndex = 5
        Me.HVPic.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Button6)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.CuNo)
        Me.TabPage1.Controls.Add(Me.CuYes)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(738, 419)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Overrides"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(269, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 17)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Yes"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(278, 134)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.TauntMenuColorOFF2
        Me.PictureBox2.Location = New System.Drawing.Point(321, 71)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(303, 136)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(268, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Team Colored Backgrond in Taunt Menu:"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(628, 384)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 29)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Apply Changes"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(176, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Yes   No"
        '
        'CuNo
        '
        Me.CuNo.AutoSize = True
        Me.CuNo.Location = New System.Drawing.Point(217, 40)
        Me.CuNo.Name = "CuNo"
        Me.CuNo.Size = New System.Drawing.Size(14, 13)
        Me.CuNo.TabIndex = 7
        Me.CuNo.UseVisualStyleBackColor = True
        '
        'CuYes
        '
        Me.CuYes.AutoSize = True
        Me.CuYes.Location = New System.Drawing.Point(186, 40)
        Me.CuYes.Name = "CuYes"
        Me.CuYes.Size = New System.Drawing.Size(14, 13)
        Me.CuYes.TabIndex = 6
        Me.CuYes.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Center Übercharge meter:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(25, 461)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(588, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "You have unsaved overrides! Please press the ""Apply Changes"" button in the Overri" & _
            "des tab."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 458)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 22)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "D"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(770, 483)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "RainHUD"
        Me.TabControl1.ResumeLayout(False)
        Me.SettingsPage.ResumeLayout(False)
        Me.SettingsPage.PerformLayout()
        Me.ColorsPage.ResumeLayout(False)
        Me.ColorsPage.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HVPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents SettingsPage As System.Windows.Forms.TabPage
    Friend WithEvents ColorsPage As System.Windows.Forms.TabPage
    Friend WithEvents GB As System.Windows.Forms.Button
    Friend WithEvents MB As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HVPic As System.Windows.Forms.PictureBox
    Friend WithEvents PHV_Text As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DeathWarningPanel As System.Windows.Forms.Panel
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents CuYes As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CuNo As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
