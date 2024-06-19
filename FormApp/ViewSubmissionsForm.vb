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
        Dim response As HttpResponseMessage = Await httpClient.GetAsync("http://localhost:3000/read?index=" & index)
        If response.IsSuccessStatusCode Then
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(responseBody)

            TextBoxName.Text = submission.name
            TextBoxEmail.Text = submission.email
            TextBoxPhone.Text = submission.phone
            TextBoxGithubLink.Text = submission.github_link
            TextBoxStopwatchTime.Text = submission.stopwatch_time
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

Public Class Submission
    Public name As String
    Public email As String
    Public phone As String
    Public github_link As String
    Public stopwatch_time As String
End Class
