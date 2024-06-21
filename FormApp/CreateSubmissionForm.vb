Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()
    Private httpClient As HttpClient = New HttpClient()
    Private WithEvents TimerStopwatch As New Timer()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerStopwatch.Interval = 1000 ' 1 second
        TimerStopwatch.Start()
    End Sub

    Private Sub ButtonToggleStopwatch_Click(sender As Object, e As EventArgs) Handles ButtonToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            ButtonToggleStopwatch.Text = "Start Stopwatch"
        Else
            stopwatch.Start()
            ButtonToggleStopwatch.Text = "Stop Stopwatch"
        End If
    End Sub

    Private Sub TimerStopwatch_Tick(sender As Object, e As EventArgs) Handles TimerStopwatch.Tick
        LabelStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        If ValidateForm() Then
            Dim submission As New Submission With {
                .name = TextBoxName.Text,
                .email = TextBoxEmail.Text,
                .phone = TextBoxPhone.Text,
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
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        If String.IsNullOrEmpty(TextBoxName.Text) OrElse
           String.IsNullOrEmpty(TextBoxEmail.Text) OrElse
           String.IsNullOrEmpty(TextBoxPhone.Text) OrElse
           String.IsNullOrEmpty(TextBoxGithubLink.Text) Then
            MessageBox.Show("Please fill in all fields")
            Return False
        End If
        Return True
    End Function
End Class
