Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.cPath = PathTextBoxIntro.Text
        Form1.Show()
        Me.Hide()
    End Sub
End Class