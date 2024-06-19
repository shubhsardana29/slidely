<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ButtonPrevious = New Button()
        ButtonNext = New Button()
        TextBoxName = New TextBox()
        TextBoxEmail = New TextBox()
        TextBoxPhone = New TextBox()
        TextBoxGithubLink = New TextBox()
        TextBoxStopwatchTime = New TextBox()
        SuspendLayout()
        ' 
        ' ButtonPrevious
        ' 
        ButtonPrevious.Location = New Point(50, 258)
        ButtonPrevious.Name = "ButtonPrevious"
        ButtonPrevious.Size = New Size(75, 23)
        ButtonPrevious.TabIndex = 0
        ButtonPrevious.Text = "Previous"
        ButtonPrevious.UseVisualStyleBackColor = True
        ' 
        ' ButtonNext
        ' 
        ButtonNext.Location = New Point(175, 258)
        ButtonNext.Name = "ButtonNext"
        ButtonNext.Size = New Size(75, 23)
        ButtonNext.TabIndex = 1
        ButtonNext.Text = "Next"
        ButtonNext.UseVisualStyleBackColor = True
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(50, 50)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(200, 23)
        TextBoxName.TabIndex = 2
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(50, 90)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(200, 23)
        TextBoxEmail.TabIndex = 3
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.Location = New Point(50, 130)
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(200, 23)
        TextBoxPhone.TabIndex = 4
        ' 
        ' TextBoxGithubLink
        ' 
        TextBoxGithubLink.Location = New Point(50, 170)
        TextBoxGithubLink.Name = "TextBoxGithubLink"
        TextBoxGithubLink.Size = New Size(200, 23)
        TextBoxGithubLink.TabIndex = 5
        ' 
        ' TextBoxStopwatchTime
        ' 
        TextBoxStopwatchTime.Location = New Point(50, 218)
        TextBoxStopwatchTime.Name = "TextBoxStopwatchTime"
        TextBoxStopwatchTime.Size = New Size(200, 23)
        TextBoxStopwatchTime.TabIndex = 6
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBoxStopwatchTime)
        Controls.Add(TextBoxGithubLink)
        Controls.Add(TextBoxPhone)
        Controls.Add(TextBoxEmail)
        Controls.Add(TextBoxName)
        Controls.Add(ButtonNext)
        Controls.Add(ButtonPrevious)
        Name = "ViewSubmissionsForm"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonPrevious As Button
    Friend WithEvents ButtonNext As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents TextBoxGithubLink As TextBox
    Friend WithEvents TextBoxStopwatchTime As TextBox
End Class
