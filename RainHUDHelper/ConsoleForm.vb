Public Class ConsoleForm

    Private Sub ConsoleForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.CustomColor = 1 Then
            CustomColorValue.Text = 1

        ElseIf My.Settings.CustomColor = 0 Then
            CustomColorValue.Text = 0

        End If

        If My.Settings.dCustomColor = 1 Then
            dCustomColorValue.Text = 1

        ElseIf My.Settings.CustomColor = 0 Then
            dCustomColorValue.Text = 0

        End If


    End Sub
End Class