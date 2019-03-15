

Public Class Form1

    Private Sub GB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GB.Click

        My.Settings.CustomColor = 0

        If My.Computer.FileSystem.FileExists(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res") Then

            Dim thefile As String = My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res"
            Dim lines() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res")

            lines(74) = "		""fgcolor""		""QuestGold"""

            System.IO.File.WriteAllLines(thefile, lines)

            PHV_Text.ForeColor = Color.FromArgb(208, 147, 75)
            My.Settings.CurrentHVColor = "Gold"

        Else
            Form2.Show()
            Me.Enabled = False
        End If
    End Sub

    Private Sub MB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MB.Click

        My.Settings.CustomColor = 0

        If My.Computer.FileSystem.FileExists(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res") Then

            Dim thefile As String = My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res"
            Dim lines() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res")

            lines(74) = "		""fgcolor""		""ForTesting_Magenta"""

            System.IO.File.WriteAllLines(thefile, lines)

            PHV_Text.ForeColor = Color.FromArgb(255, 0, 255)
            My.Settings.CurrentHVColor = "Magenta"

        Else
            Form2.Show()
            Me.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.cPath = PathTextBox.Text
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PHV_Text.Parent = HVPic
        PathTextBox.Text = My.Settings.cPath

        If My.Settings.CustomColor = 1 Then
            My.Settings.CurrentHVColor = "None"
            PHV_Text.ForeColor = Color.FromArgb(My.Settings.R, My.Settings.G, My.Settings.B)
        End If


        If My.Settings.CurrentHVColor = "Magenta" Then
            PHV_Text.ForeColor = Color.FromArgb(255, 0, 255)

        ElseIf My.Settings.CurrentHVColor = "Gold" Then
            PHV_Text.ForeColor = Color.FromArgb(208, 147, 75)

        ElseIf My.Settings.CurrentHVColor = "None" Then


        End If



        If My.Settings.dCustomColor = 1 Then
            My.Settings.CurrentDWColor = "None"
            DeathWarningPanel.BackColor = Color.FromArgb(My.Settings.dR, My.Settings.dG, My.Settings.dB)

        End If


        If My.Settings.CurrentDWColor = "Magenta" Then
            DeathWarningPanel.BackColor = Color.FromArgb(255, 0, 255)

        ElseIf My.Settings.CurrentDWColor = "Gold" Then
            DeathWarningPanel.BackColor = Color.FromArgb(208, 147, 75)

        ElseIf My.Settings.CurrentDWColor = "None" Then


        End If


        If My.Settings.CenterUberCharge = 0 Then

            CuYes.Checked = False
            CuNo.Checked = True

        ElseIf My.Settings.CenterUberCharge = 1 Then

            CuYes.Checked = True
            CuNo.Checked = False

        End If

        If My.Settings.TauntColor = "No" Then

            CheckBox1.CheckState = CheckState.Unchecked

        ElseIf My.Settings.TauntColor = "Yes" Then

            CheckBox1.CheckState = CheckState.Checked

        End If

        Label9.Visible = False

        Label10.Visible = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If My.Computer.FileSystem.FileExists(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res") Then
            My.Settings.WhichColor = "Health"

            ControlPanel.Show()
        Else
            Form2.Show()
            Me.Enabled = False
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If My.Computer.FileSystem.FileExists(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res") Then

            Dim thefile As String = My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res"
            Dim lines() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res")

            lines(16) = "		""HealthDeathWarningColor""	""QuestGold"""

            System.IO.File.WriteAllLines(thefile, lines)

            DeathWarningPanel.BackColor = Color.FromArgb(208, 147, 75)
            My.Settings.CurrentDWColor = "Gold"
            My.Settings.dCustomColor = 0
        Else
            Form2.Show()
            Me.Enabled = False
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If My.Computer.FileSystem.FileExists(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res") Then

            Dim thefile As String = My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res"
            Dim lines() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res")

            lines(16) = "		""HealthDeathWarningColor""	""ForTesting_Magenta"""

            System.IO.File.WriteAllLines(thefile, lines)

            DeathWarningPanel.BackColor = Color.FromArgb(255, 0, 255)
            My.Settings.CurrentDWColor = "Magenta"
            My.Settings.dCustomColor = 0
        Else
            Form2.Show()
            Me.Enabled = False

        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If My.Computer.FileSystem.FileExists(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res") Then

            My.Settings.WhichColor = "Death"
            ControlPanel.Show()
        Else
            Form2.Show()
            Me.Enabled = False
        End If

    End Sub

    Private Sub PHV_Text_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PHV_Text.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CuYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuYes.CheckedChanged
        If CuYes.Checked = True Then
            CuNo.Checked = False
            Label9.ForeColor = Color.Red
            Label9.Visible = True

        End If


    End Sub

    Private Sub CuNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuNo.CheckedChanged
        If CuNo.Checked = True Then
            CuYes.Checked = False
            Label9.ForeColor = Color.Red
            Label9.Visible = True

        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If My.Computer.FileSystem.FileExists(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res") Then


            If CuYes.Checked = True Then

                Dim thefile3 As String = My.Settings.cPath + "\RainHUD\scripts\hudlayout.res"
                Dim lines3() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\scripts\hudlayout.res")

                lines3(75) = "		""xpos""			""355""	[$WIN32]"
                lines3(76) = "		""ypos""			""375""	[$WIN32]"

                System.IO.File.WriteAllLines(thefile3, lines3)

                My.Settings.CenterUberCharge = 1


            ElseIf CuNo.Checked = True Then

                Dim thefile3 As String = My.Settings.cPath + "\RainHUD\scripts\hudlayout.res"
                Dim lines3() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\scripts\hudlayout.res")

                lines3(75) = "		""xpos""			""560""	[$WIN32]"
                lines3(76) = "		""ypos""			""400""	[$WIN32]"

                System.IO.File.WriteAllLines(thefile3, lines3)

                My.Settings.CenterUberCharge = 0

            End If

            If My.Settings.TauntColor = "No" Then

                Dim thefile4 As String = My.Settings.cPath + "\RainHUD\resource\ui\hudmenutauntselection.res"
                Dim lines4() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\resource\ui\hudmenutauntselection.res")

                lines4(27) = "		""visible"" 		""0"""

                System.IO.File.WriteAllLines(thefile4, lines4)

            End If

            If My.Settings.TauntColor = "Yes" Then

                Dim thefile4 As String = My.Settings.cPath + "\RainHUD\resource\ui\hudmenutauntselection.res"
                Dim lines4() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\resource\ui\hudmenutauntselection.res")

                lines4(27) = "		""visible"" 		""1"""

                System.IO.File.WriteAllLines(thefile4, lines4)

            End If

            Label9.Visible = False


        Else
            Form2.Show()
            Me.Enabled = False
        End If

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        ConsoleForm.Show()
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = CheckState.Checked Then

            My.Settings.TauntColor = "Yes"
            PictureBox2.Image = WindowsApplication1.My.Resources.Resources.TauntMenuColorON2

            Label9.ForeColor = Color.Red
            Label9.Visible = True

        ElseIf CheckBox1.CheckState = CheckState.Unchecked Then

            My.Settings.TauntColor = "No"
            PictureBox2.Image = WindowsApplication1.My.Resources.Resources.TauntMenuColorOFF2

            Label9.ForeColor = Color.Red
            Label9.Visible = True

        End If

    End Sub
End Class
