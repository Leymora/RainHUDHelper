Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cPathTextBox.Text = My.Settings.cPath

    End Sub

    Private Sub cPathApplyButton_Click(sender As Object, e As EventArgs) Handles cPathApplyButton.Click

        My.Settings.cPath = cPathTextBox.Text

    End Sub
End Class
