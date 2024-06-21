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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' TextBoxName
        ' 
        TextBoxName.Location = New Point(326, 130)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(200, 23)
        TextBoxName.TabIndex = 0
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(326, 170)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(200, 23)
        TextBoxEmail.TabIndex = 1
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.Location = New Point(326, 210)
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(200, 23)
        TextBoxPhone.TabIndex = 2
        ' 
        ' TextBoxGithubLink
        ' 
        TextBoxGithubLink.Location = New Point(326, 253)
        TextBoxGithubLink.Name = "TextBoxGithubLink"
        TextBoxGithubLink.Size = New Size(200, 23)
        TextBoxGithubLink.TabIndex = 3
        ' 
        ' LabelStopwatchTime
        ' 
        LabelStopwatchTime.AutoSize = True
        LabelStopwatchTime.BackColor = SystemColors.ScrollBar
        LabelStopwatchTime.Location = New Point(466, 311)
        LabelStopwatchTime.Name = "LabelStopwatchTime"
        LabelStopwatchTime.Size = New Size(49, 15)
        LabelStopwatchTime.TabIndex = 4
        LabelStopwatchTime.Text = "00:00:00"
        ' 
        ' ButtonToggleStopwatch
        ' 
        ButtonToggleStopwatch.BackColor = SystemColors.Info
        ButtonToggleStopwatch.Location = New Point(242, 300)
        ButtonToggleStopwatch.Name = "ButtonToggleStopwatch"
        ButtonToggleStopwatch.Size = New Size(203, 37)
        ButtonToggleStopwatch.TabIndex = 5
        ButtonToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        ButtonToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' ButtonSubmit
        ' 
        ButtonSubmit.BackColor = SystemColors.GradientActiveCaption
        ButtonSubmit.Location = New Point(326, 356)
        ButtonSubmit.Name = "ButtonSubmit"
        ButtonSubmit.Size = New Size(200, 34)
        ButtonSubmit.TabIndex = 6
        ButtonSubmit.Text = " SUBMIT  (CTRL + S)"
        ButtonSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(287, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 15)
        Label1.TabIndex = 7
        Label1.Text = "Shubh Sardana , Slidely Task-2 - Create Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(207, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 8
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(207, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 9
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(204, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 10
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(204, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 15)
        Label5.TabIndex = 11
        Label5.Text = "Github link for task 2"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
