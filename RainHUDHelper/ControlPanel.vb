Public Class ControlPanel


    Private Sub ControlPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If My.Settings.CustomColor = 1 And My.Settings.WhichColor = "Health" Then
            RScroll.Value = My.Settings.R
            GScroll.Value = My.Settings.G
            BScroll.Value = My.Settings.B
            RV.Text = RScroll.Value
            GV.Text = GScroll.Value
            BV.Text = BScroll.Value

            ResultBox.BackColor = Color.FromArgb(My.Settings.R, My.Settings.G, My.Settings.B)


        ElseIf My.Settings.dCustomColor = 1 And My.Settings.WhichColor = "Death" Then
            RScroll.Value = My.Settings.dR
            GScroll.Value = My.Settings.dG
            BScroll.Value = My.Settings.dB
            RV.Text = RScroll.Value
            GV.Text = GScroll.Value
            BV.Text = BScroll.Value

            ResultBox.BackColor = Color.FromArgb(My.Settings.dR, My.Settings.dG, My.Settings.dB)

        ElseIf My.Settings.CustomColor = 0 And My.Settings.WhichColor = "Health" Then

            RScroll.Value = 0
            GScroll.Value = 0
            BScroll.Value = 0

            My.Settings.R = RScroll.Value
            My.Settings.G = GScroll.Value
            My.Settings.B = BScroll.Value
            RV.Text = RScroll.Value
            GV.Text = GScroll.Value
            BV.Text = BScroll.Value

            ResultBox.BackColor = Color.FromArgb(My.Settings.R, My.Settings.G, My.Settings.B)

        ElseIf My.Settings.dCustomColor = 0 And My.Settings.WhichColor = "Death" Then

            RScroll.Value = 0
            GScroll.Value = 0
            BScroll.Value = 0

            My.Settings.dR = RScroll.Value
            My.Settings.dG = GScroll.Value
            My.Settings.dB = BScroll.Value
            RV.Text = RScroll.Value
            GV.Text = GScroll.Value
            BV.Text = BScroll.Value

            ResultBox.BackColor = Color.FromArgb(My.Settings.dR, My.Settings.dG, My.Settings.dB)

        End If



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If My.Settings.WhichColor = "Health" Then
            My.Settings.R = RScroll.Value
            My.Settings.G = GScroll.Value
            My.Settings.B = BScroll.Value

            Form1.PHV_Text.ForeColor = Color.FromArgb(My.Settings.R, My.Settings.G, My.Settings.B)
            My.Settings.CustomColor = 1

            If My.Computer.FileSystem.FileExists(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res") Then

                Dim thefile2 As String = My.Settings.cPath + "\RainHUD\resource\clientscheme.res"
                Dim lines2() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\resource\clientscheme.res")

                lines2(194) = "		""CColor""		" + Label7.Text + RV.Text + Label5.Text + GV.Text + Label5.Text + BV.Text + Label5.Text + "255" + Label7.Text

                System.IO.File.WriteAllLines(thefile2, lines2)

                Dim thefile As String = My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res"
                Dim lines() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res")

                lines(74) = "		""fgcolor""		""CColor"""

                System.IO.File.WriteAllLines(thefile, lines)



            Else
                Form2.Show()
                Me.Enabled = False
            End If
        End If


        If My.Settings.WhichColor = "Death" Then

            If My.Computer.FileSystem.FileExists(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res") Then

                Dim thefile2 As String = My.Settings.cPath + "\RainHUD\resource\clientscheme.res"
                Dim lines2() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\resource\clientscheme.res")

                lines2(195) = "		""CColorD""		" + Label7.Text + RV.Text + Label5.Text + GV.Text + Label5.Text + BV.Text + Label5.Text + "255" + Label7.Text

                System.IO.File.WriteAllLines(thefile2, lines2)

                Dim thefile As String = My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res"
                Dim lines() As String = System.IO.File.ReadAllLines(My.Settings.cPath + "\RainHUD\resource\ui\hudplayerhealth.res")

                lines(16) = "		""HealthDeathWarningColor""		""CColorD"""

                System.IO.File.WriteAllLines(thefile, lines)

                My.Settings.dR = RScroll.Value
                My.Settings.dG = GScroll.Value
                My.Settings.dB = BScroll.Value
                Form1.DeathWarningPanel.BackColor = Color.FromArgb(My.Settings.dR, My.Settings.dG, My.Settings.dB)
                My.Settings.dCustomColor = 1


            Else
                Form2.Show()
                Me.Enabled = False
            End If
        End If



    End Sub

    Private Sub RScroll_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RScroll.Scroll
        RV.Text = RScroll.Value
        ResultBox.BackColor = Color.FromArgb(RV.Text, GV.Text, BV.Text)
    End Sub

    Private Sub GScroll_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GScroll.Scroll
        GV.Text = GScroll.Value
        ResultBox.BackColor = Color.FromArgb(RV.Text, GV.Text, BV.Text)
    End Sub

    Private Sub BScroll_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BScroll.Scroll
        BV.Text = BScroll.Value
        ResultBox.BackColor = Color.FromArgb(RV.Text, GV.Text, BV.Text)
    End Sub

    Private Sub AScroll_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AScroll.Scroll
        RScroll.Value = AScroll.Value
        GScroll.Value = AScroll.Value
        BScroll.Value = AScroll.Value
        RV.Text = AScroll.Value
        GV.Text = AScroll.Value
        BV.Text = AScroll.Value
        AV.Text = AScroll.Value
        ResultBox.BackColor = Color.FromArgb(My.Settings.R, My.Settings.G, My.Settings.B)
    End Sub

End Class