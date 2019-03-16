Public Class ColorChooser

    Private Sub ColorChooser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myRgbColor As New Color()
        myRgbColor = Color.FromArgb(My.Settings.HealthCustomColorR, My.Settings.HealthCustomColorG, My.Settings.HealthCustomColorB)
        ResultPanel.BackColor = myRgbColor

        RSlider.Value = My.Settings.HealthCustomColorR
        GSlider.Value = My.Settings.HealthCustomColorG
        BSlider.Value = My.Settings.HealthCustomColorB

        RedLabel.Text = "Red: " + RSlider.Value.ToString
        GreenLabel.Text = "Green: " + GSlider.Value.ToString
        BlueLabel.Text = "Blue: " + BSlider.Value.ToString

    End Sub

    Private Sub RSlider_Scroll(sender As Object, e As EventArgs) Handles RSlider.Scroll

        My.Settings.HealthCustomColorR = RSlider.Value
        My.Settings.HealthCustomColorG = GSlider.Value
        My.Settings.HealthCustomColorB = BSlider.Value

        RedLabel.Text = "Red: " + RSlider.Value.ToString
        GreenLabel.Text = "Green: " + GSlider.Value.ToString
        BlueLabel.Text = "Blue: " + BSlider.Value.ToString

        Dim myRgbColor As New Color()
        myRgbColor = Color.FromArgb(My.Settings.HealthCustomColorR, My.Settings.HealthCustomColorG, My.Settings.HealthCustomColorB)
        ResultPanel.BackColor = myRgbColor

    End Sub

    Private Sub GSlider_Scroll(sender As Object, e As EventArgs) Handles GSlider.Scroll
        My.Settings.HealthCustomColorR = RSlider.Value
        My.Settings.HealthCustomColorG = GSlider.Value
        My.Settings.HealthCustomColorB = BSlider.Value

        RedLabel.Text = "Red: " + RSlider.Value.ToString
        GreenLabel.Text = "Green: " + GSlider.Value.ToString
        BlueLabel.Text = "Blue: " + BSlider.Value.ToString

        Dim myRgbColor As New Color()
        myRgbColor = Color.FromArgb(My.Settings.HealthCustomColorR, My.Settings.HealthCustomColorG, My.Settings.HealthCustomColorB)
        ResultPanel.BackColor = myRgbColor
    End Sub

    Private Sub BSlider_Scroll(sender As Object, e As EventArgs) Handles BSlider.Scroll
        My.Settings.HealthCustomColorR = RSlider.Value
        My.Settings.HealthCustomColorG = GSlider.Value
        My.Settings.HealthCustomColorB = BSlider.Value

        RedLabel.Text = "Red: " + RSlider.Value.ToString
        GreenLabel.Text = "Green: " + GSlider.Value.ToString
        BlueLabel.Text = "Blue: " + BSlider.Value.ToString

        Dim myRgbColor As New Color()
        myRgbColor = Color.FromArgb(My.Settings.HealthCustomColorR, My.Settings.HealthCustomColorG, My.Settings.HealthCustomColorB)
        ResultPanel.BackColor = myRgbColor
    End Sub
End Class