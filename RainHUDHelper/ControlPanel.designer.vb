<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPanel))
        Me.RedBox = New System.Windows.Forms.Panel()
        Me.GreenBox = New System.Windows.Forms.Panel()
        Me.BlueBox = New System.Windows.Forms.Panel()
        Me.ResultBox = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RScroll = New System.Windows.Forms.TrackBar()
        Me.GScroll = New System.Windows.Forms.TrackBar()
        Me.BScroll = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RV = New System.Windows.Forms.Label()
        Me.GV = New System.Windows.Forms.Label()
        Me.BV = New System.Windows.Forms.Label()
        Me.AV = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AScroll = New System.Windows.Forms.TrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.RScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RedBox
        '
        Me.RedBox.BackColor = System.Drawing.Color.Red
        Me.RedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RedBox.Location = New System.Drawing.Point(486, 9)
        Me.RedBox.Name = "RedBox"
        Me.RedBox.Size = New System.Drawing.Size(78, 64)
        Me.RedBox.TabIndex = 3
        '
        'GreenBox
        '
        Me.GreenBox.BackColor = System.Drawing.Color.Lime
        Me.GreenBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GreenBox.Location = New System.Drawing.Point(486, 103)
        Me.GreenBox.Name = "GreenBox"
        Me.GreenBox.Size = New System.Drawing.Size(78, 64)
        Me.GreenBox.TabIndex = 4
        '
        'BlueBox
        '
        Me.BlueBox.BackColor = System.Drawing.Color.Blue
        Me.BlueBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BlueBox.Location = New System.Drawing.Point(486, 196)
        Me.BlueBox.Name = "BlueBox"
        Me.BlueBox.Size = New System.Drawing.Size(78, 64)
        Me.BlueBox.TabIndex = 5
        '
        'ResultBox
        '
        Me.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ResultBox.Location = New System.Drawing.Point(251, 359)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.Size = New System.Drawing.Size(78, 64)
        Me.ResultBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 377)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Result:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(226, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 41)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Apply"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RScroll
        '
        Me.RScroll.Location = New System.Drawing.Point(12, 28)
        Me.RScroll.Maximum = 255
        Me.RScroll.Name = "RScroll"
        Me.RScroll.Size = New System.Drawing.Size(467, 45)
        Me.RScroll.TabIndex = 9
        Me.RScroll.TickFrequency = 10
        '
        'GScroll
        '
        Me.GScroll.Location = New System.Drawing.Point(12, 122)
        Me.GScroll.Maximum = 255
        Me.GScroll.Name = "GScroll"
        Me.GScroll.Size = New System.Drawing.Size(467, 45)
        Me.GScroll.TabIndex = 10
        Me.GScroll.TickFrequency = 10
        '
        'BScroll
        '
        Me.BScroll.Location = New System.Drawing.Point(13, 215)
        Me.BScroll.Maximum = 255
        Me.BScroll.Name = "BScroll"
        Me.BScroll.Size = New System.Drawing.Size(467, 45)
        Me.BScroll.TabIndex = 11
        Me.BScroll.TickFrequency = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Green:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(235, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Blue:"
        '
        'RV
        '
        Me.RV.AutoSize = True
        Me.RV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RV.Location = New System.Drawing.Point(277, 7)
        Me.RV.Name = "RV"
        Me.RV.Size = New System.Drawing.Size(18, 20)
        Me.RV.TabIndex = 15
        Me.RV.Text = "0"
        '
        'GV
        '
        Me.GV.AutoSize = True
        Me.GV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GV.Location = New System.Drawing.Point(277, 101)
        Me.GV.Name = "GV"
        Me.GV.Size = New System.Drawing.Size(18, 20)
        Me.GV.TabIndex = 16
        Me.GV.Text = "0"
        '
        'BV
        '
        Me.BV.AutoSize = True
        Me.BV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BV.Location = New System.Drawing.Point(277, 193)
        Me.BV.Name = "BV"
        Me.BV.Size = New System.Drawing.Size(18, 20)
        Me.BV.TabIndex = 17
        Me.BV.Text = "0"
        '
        'AV
        '
        Me.AV.AutoSize = True
        Me.AV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AV.Location = New System.Drawing.Point(276, 284)
        Me.AV.Name = "AV"
        Me.AV.Size = New System.Drawing.Size(18, 20)
        Me.AV.TabIndex = 21
        Me.AV.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(250, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "All:"
        '
        'AScroll
        '
        Me.AScroll.Location = New System.Drawing.Point(13, 307)
        Me.AScroll.Maximum = 255
        Me.AScroll.Name = "AScroll"
        Me.AScroll.Size = New System.Drawing.Size(467, 45)
        Me.AScroll.TabIndex = 19
        Me.AScroll.TickFrequency = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(486, 288)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(78, 64)
        Me.Panel1.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Red:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 377)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(571, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = """"
        '
        'ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(612, 497)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AScroll)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BV)
        Me.Controls.Add(Me.GV)
        Me.Controls.Add(Me.RV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BScroll)
        Me.Controls.Add(Me.GScroll)
        Me.Controls.Add(Me.RScroll)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.BlueBox)
        Me.Controls.Add(Me.GreenBox)
        Me.Controls.Add(Me.RedBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RGB Custom Color"
        CType(Me.RScroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GScroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BScroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AScroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RedBox As System.Windows.Forms.Panel
    Friend WithEvents GreenBox As System.Windows.Forms.Panel
    Friend WithEvents BlueBox As System.Windows.Forms.Panel
    Friend WithEvents ResultBox As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RScroll As System.Windows.Forms.TrackBar
    Friend WithEvents GScroll As System.Windows.Forms.TrackBar
    Friend WithEvents BScroll As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RV As System.Windows.Forms.Label
    Friend WithEvents GV As System.Windows.Forms.Label
    Friend WithEvents BV As System.Windows.Forms.Label
    Friend WithEvents AV As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AScroll As System.Windows.Forms.TrackBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
