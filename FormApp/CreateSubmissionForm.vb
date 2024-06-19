Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private httpClient As HttpClient = New HttpClient()

    Private Sub ButtonToggleStopwatch_Click(sender As Object, e As EventArgs) Handles ButtonToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        LabelStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Dim submission As New Submission With {
            .name = TextBoxName.Text,
            .email = TextBoxEmail.Text,
            .phone = TextBoxPhone.Text,
            .github_link = TextBoxGithubLink.Text,
            .stopwatch_time = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        }
        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = Await httpClient.PostAsync("http://localhost:3000/submit", content)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission successful")
        Else
            MessageBox.Show("Submission failed")
        End If
    End Sub
End Class

Public Class Submission
    Public name As String
    Public email As String
    Public phone As String
    Public github_link As String
    Public stopwatch_time As String
End Class
