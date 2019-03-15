Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = My.Settings.cPath

        If Label2.Width <= Label1.Width Then

            Me.Width = Label1.Width + 23

        Else
            Me.Width = Label2.Width + 23

        End If



    End Sub

    Private Sub Form2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Enabled = True
        ControlPanel.Enabled = True
    End Sub
End Class