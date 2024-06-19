Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set KeyPreview to True to capture key events
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle keyboard shortcuts
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ButtonViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ButtonCreateSubmission.PerformClick()
        End If
    End Sub

    Private Sub ButtonViewSubmissions_Click(sender As Object, e As EventArgs) Handles ButtonViewSubmissions.Click
        ' Show ViewSubmissionsForm when the button is clicked
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub ButtonCreateSubmission_Click(sender As Object, e As EventArgs) Handles ButtonCreateSubmission.Click
        ' Show CreateSubmissionForm when the button is clicked
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

End Class
