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
            .Name = TextBoxName.Text,
            .Email = TextBoxEmail.Text,
            .Phone = TextBoxPhone.Text,
            .GithubLink = TextBoxGithubLink.Text,
            .StopwatchTime = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        }
        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = Await httpClient.PostAsync("https://slidely.onrender.com/submit", content)
        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission successful")
        Else
            MessageBox.Show("Submission failed")
        End If
    End Sub


End Class
