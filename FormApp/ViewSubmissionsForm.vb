Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private httpClient As HttpClient = New HttpClient()

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Dim response As HttpResponseMessage = Await httpClient.GetAsync("https://slidely.onrender.com/read?index=" & index)
        If response.IsSuccessStatusCode Then
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(responseBody)

            TextBoxName.Text = submission.name
            TextBoxEmail.Text = submission.email
            TextBoxPhone.Text = submission.phone
            TextBoxGithubLink.Text = submission.GithubLink
            TextBoxStopwatchTime.Text = submission.StopwatchTime
        Else
            MessageBox.Show("Submission not found")
        End If
    End Function

    Private Async Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        currentIndex += 1
        Await LoadSubmission(currentIndex)
    End Sub

    ' Event handler for the Edit button
    Private Async Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim submission As New Submission With {
            .name = TextBoxName.Text,
            .email = TextBoxEmail.Text,
            .phone = TextBoxPhone.Text,
            .GithubLink = TextBoxGithubLink.Text,
            .StopwatchTime = TextBoxStopwatchTime.Text
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = Await httpClient.PutAsync("https://slidely.onrender.com/update?index=" & currentIndex, content)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission updated successfully")
        Else
            MessageBox.Show("Failed to update submission")
        End If
    End Sub

    ' Event handler for the Delete button
    Private Async Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim response As HttpResponseMessage = Await httpClient.DeleteAsync("https://slidely.onrender.com/delete?index=" & currentIndex)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission deleted successfully")
            If currentIndex > 0 Then
                currentIndex -= 1
            End If
            Await LoadSubmission(currentIndex)
        Else
            MessageBox.Show("Failed to delete submission")
        End If
    End Sub

    Private Async Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            If currentIndex > 0 Then
                currentIndex -= 1
                Await LoadSubmission(currentIndex)
            End If
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            currentIndex += 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub
End Class
