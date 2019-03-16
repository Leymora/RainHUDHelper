Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cPathTextBox.Text = My.Settings.cPath
        HealthCustomColorCB.CheckState = My.Settings.HealthCustomColorCB_Checked
        DWCustomColorCB.CheckState = My.Settings.DWCustomColorCB_Checked
        WarningText.Visible = False

    End Sub

    Private Sub cPathApplyButton_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub AACButton_Click(sender As Object, e As EventArgs) Handles AACButton.Click

        WarningText.Visible = False

        'Apply Everything
        My.Settings.cPath = cPathTextBox.Text

    End Sub

    Private Sub HealthCustomColorCB_CheckedChanged(sender As Object, e As EventArgs) Handles HealthCustomColorCB.CheckedChanged

        My.Settings.HealthCustomColorCB_Checked = HealthCustomColorCB.CheckState

    End Sub

    Private Sub DWCustomColorCB_CheckedChanged(sender As Object, e As EventArgs) Handles DWCustomColorCB.CheckedChanged

        My.Settings.DWCustomColorCB_Checked = DWCustomColorCB.CheckState

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        WarningText.Visible = True
        cPathTextBox.Text = "C:\Program Files\steam\steamapps\common\Team Fortress 2\tf\custom"

    End Sub

    Private Sub cPathTextBox_TextChanged(sender As Object, e As EventArgs) Handles cPathTextBox.TextChanged

        WarningText.Visible = True

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If WarningText.Visible = True Then
            Dim result As Integer = MessageBox.Show("You have unsaved changes. Are you sure you want to close RainHUDHelper?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If result = DialogResult.No Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ColorChooser.Show()

    End Sub
End Class
