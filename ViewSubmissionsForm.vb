Imports System.Net
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub LoadSubmission(index As Integer)
        Try
            Dim client As New WebClient()
            Dim response As String = client.DownloadString($"http://localhost:3000/read?index={index}")
            Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(response)

            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhone.Text = submission.phone
            txtGitHubLink.Text = submission.github_link
            txtStopwatchTime.Text = submission.stopwatch_time
        Catch ex As WebException
            If CType(ex.Response, HttpWebResponse).StatusCode = HttpStatusCode.NotFound Then
                MessageBox.Show("No more Entries available.")
                currentIndex -= 1 ' Revert to the last valid index
            Else
                MessageBox.Show("An error occurred while loading the submission.")
            End If
        End Try
    End Sub

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadSubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.E Then
            btnEdit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        End If
    End Sub

    Private Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class



    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Dim client As New WebClient()
            client.Headers(HttpRequestHeader.ContentType) = "application/json"

            Dim submission As New Submission With {
                .name = txtName.Text,
                .email = txtEmail.Text,
                .phone = txtPhone.Text,
                .github_link = txtGitHubLink.Text,
                .stopwatch_time = txtStopwatchTime.Text
            }

            Dim json As String = JsonConvert.SerializeObject(submission)
            client.UploadString($"http://localhost:3000/edit?index={currentIndex}", "PUT", json)
            MessageBox.Show("It just got updated with the same data. Sorry I was lacking time so, I couldn't applied a good approach to edit the entry.")
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the submission.")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim client As New WebClient()
            client.Headers(HttpRequestHeader.ContentType) = "application/json"

            client.UploadString($"http://localhost:3000/delete?index={currentIndex}", "DELETE", "")
            MessageBox.Show("Submission deleted successfully.")
            currentIndex = Math.Max(0, currentIndex - 1) ' Go to the previous index if possible
            LoadSubmission(currentIndex)
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the submission.")
        End Try
    End Sub
End Class
