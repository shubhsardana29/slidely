Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private httpClient As HttpClient = New HttpClient()

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Dim response As HttpResponseMessage = Await httpClient.GetAsync("https://slidely.onrender.com/read?index=" & index)
        If response.IsSuccessStatusCode Then
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(responseBody)

            TextBoxName.Text = submission.name
            TextBoxEmail.Text = submission.email
            TextBoxPhone.Text = submission.Phone
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
End Class

