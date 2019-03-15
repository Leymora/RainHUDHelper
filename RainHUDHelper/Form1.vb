Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cPathTextBox.Text = My.Settings.cPath
        HealthCustomColorCB.Checked.Equals(My.Settings.HealthCustomColorCB_Checked)

    End Sub

    Private Sub cPathApplyButton_Click(sender As Object, e As EventArgs) Handles cPathApplyButton.Click

        My.Settings.cPath = cPathTextBox.Text

    End Sub

    Private Sub AACButton_Click(sender As Object, e As EventArgs) Handles AACButton.Click

        WarningText.Visible = False

    End Sub

    Private Sub HealthCustomColorCB_CheckedChanged(sender As Object, e As EventArgs) Handles HealthCustomColorCB.CheckedChanged

        WarningText.Visible = True
        If HealthCustomColorCB.CheckState = False Then
            My.Settings.HealthCustomColorCB_Checked = False
        End If
        If HealthCustomColorCB.CheckState = True Then
            My.Settings.HealthCustomColorCB_Checked = True
        End If

    End Sub

    Private Sub DWCustomColorCB_CheckedChanged(sender As Object, e As EventArgs) Handles DWCustomColorCB.CheckedChanged

        WarningText.Visible = True

    End Sub
End Class
