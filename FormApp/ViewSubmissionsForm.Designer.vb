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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ButtonEdit = New Button()
        ButtonDelete = New Button()
        SuspendLayout()
        ' 
        ' ButtonPrevious
        ' 
        ButtonPrevious.BackColor = SystemColors.Info
        ButtonPrevious.Location = New Point(288, 304)
        ButtonPrevious.Name = "ButtonPrevious"
        ButtonPrevious.Size = New Size(89, 41)
        ButtonPrevious.TabIndex = 0
        ButtonPrevious.Text = "PREVIOUS (CTRL + P)"
        ButtonPrevious.UseVisualStyleBackColor = False
        ' 
        ' ButtonNext
        ' 
        ButtonNext.BackColor = SystemColors.GradientActiveCaption
        ButtonNext.Location = New Point(399, 304)
        ButtonNext.Name = "ButtonNext"
        ButtonNext.Size = New Size(89, 41)
        ButtonNext.TabIndex = 1
        ButtonNext.Text = "NEXT  ( CTRL + N)"
        ButtonNext.UseVisualStyleBackColor = False
        ' 
        ' TextBoxName
        ' 
        TextBoxName.BackColor = SystemColors.ScrollBar
        TextBoxName.Location = New Point(288, 90)
        TextBoxName.Name = "TextBoxName"
        TextBoxName.Size = New Size(200, 23)
        TextBoxName.TabIndex = 2
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.BackColor = SystemColors.ScrollBar
        TextBoxEmail.Location = New Point(288, 130)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(200, 23)
        TextBoxEmail.TabIndex = 3
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.BackColor = SystemColors.ScrollBar
        TextBoxPhone.Location = New Point(288, 170)
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(200, 23)
        TextBoxPhone.TabIndex = 4
        ' 
        ' TextBoxGithubLink
        ' 
        TextBoxGithubLink.BackColor = SystemColors.ScrollBar
        TextBoxGithubLink.Location = New Point(288, 218)
        TextBoxGithubLink.Name = "TextBoxGithubLink"
        TextBoxGithubLink.Size = New Size(200, 23)
        TextBoxGithubLink.TabIndex = 5
        ' 
        ' TextBoxStopwatchTime
        ' 
        TextBoxStopwatchTime.BackColor = SystemColors.ScrollBar
        TextBoxStopwatchTime.Location = New Point(288, 259)
        TextBoxStopwatchTime.Name = "TextBoxStopwatchTime"
        TextBoxStopwatchTime.Size = New Size(200, 23)
        TextBoxStopwatchTime.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(263, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 15)
        Label1.TabIndex = 7
        Label1.Text = "Shubh Sardana, Slidely Task 2 - View Submisions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(166, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 8
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(166, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 9
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(166, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 10
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(166, 221)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 15)
        Label5.TabIndex = 11
        Label5.Text = "Github link for task 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(166, 262)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 15)
        Label6.TabIndex = 12
        Label6.Text = "Stopwatch Time"
        ' 
        ' ButtonEdit
        ' 
        ButtonEdit.Location = New Point(288, 369)
        ButtonEdit.Name = "ButtonEdit"
        ButtonEdit.Size = New Size(89, 23)
        ButtonEdit.TabIndex = 13
        ButtonEdit.Text = "Edit"
        ButtonEdit.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Location = New Point(399, 369)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(89, 23)
        ButtonDelete.TabIndex = 14
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonDelete)
        Controls.Add(ButtonEdit)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonDelete As Button
End Class
