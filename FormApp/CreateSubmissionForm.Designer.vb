<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        TextBoxName = New TextBox()
        TextBoxEmail = New TextBox()
        TextBoxPhone = New TextBox()
        TextBoxGithubLink = New TextBox()
        LabelStopwatchTime = New Label()
        ButtonToggleStopwatch = New Button()
        ButtonSubmit = New Button()
        SuspendLayout()
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(50, 50)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(200, 23)
        TextBoxName.TabIndex = 0
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(50, 90)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(200, 23)
        TextBoxEmail.TabIndex = 1
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.Location = New Point(50, 130)
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(200, 23)
        TextBoxPhone.TabIndex = 2
        ' 
        ' TextBoxGithubLink
        ' 
        TextBoxGithubLink.Location = New Point(50, 170)
        TextBoxGithubLink.Name = "TextBoxGithubLink"
        TextBoxGithubLink.Size = New Size(200, 23)
        TextBoxGithubLink.TabIndex = 3
        ' 
        ' LabelStopwatchTime
        ' 
        LabelStopwatchTime.AutoSize = True
        LabelStopwatchTime.Location = New Point(50, 210)
        LabelStopwatchTime.Name = "LabelStopwatchTime"
        LabelStopwatchTime.Size = New Size(49, 15)
        LabelStopwatchTime.TabIndex = 4
        LabelStopwatchTime.Text = "00:00:00"
        ' 
        ' ButtonToggleStopwatch
        ' 
        ButtonToggleStopwatch.Location = New Point(50, 250)
        ButtonToggleStopwatch.Name = "ButtonToggleStopwatch"
        ButtonToggleStopwatch.Size = New Size(75, 23)
        ButtonToggleStopwatch.TabIndex = 5
        ButtonToggleStopwatch.Text = "Start/Stop"
        ButtonToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.Location = New Point(150, 250)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(75, 23)
        ButtonSubmit.TabIndex = 6
        ButtonSubmit.Text = "Button1"
        ButtonSubmit.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonSubmit)
        Controls.Add(ButtonToggleStopwatch)
        Controls.Add(LabelStopwatchTime)
        Controls.Add(TextBoxGithubLink)
        Controls.Add(TextBoxPhone)
        Controls.Add(TextBoxEmail)
        Controls.Add(TextBoxName)
        Name = "CreateSubmissionForm"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents TextBoxGithubLink As TextBox
    Friend WithEvents LabelStopwatchTime As Label
    Friend WithEvents ButtonToggleStopwatch As Button
    Friend WithEvents ButtonSubmit As Button
End Class
