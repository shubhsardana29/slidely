<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ButtonViewSubmissions = New Button()
        ButtonCreateSubmission = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' ButtonViewSubmissions
        ' 
        ButtonViewSubmissions.BackColor = SystemColors.Info
        ButtonViewSubmissions.Location = New Point(293, 140)
        ButtonViewSubmissions.Name = "ButtonViewSubmissions"
        ButtonViewSubmissions.Size = New Size(200, 40)
        ButtonViewSubmissions.TabIndex = 0
        ButtonViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        ButtonViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' ButtonCreateSubmission
        ' 
        ButtonCreateSubmission.BackColor = SystemColors.GradientActiveCaption
        ButtonCreateSubmission.Location = New Point(293, 211)
        ButtonCreateSubmission.Name = "ButtonCreateSubmission"
        ButtonCreateSubmission.Size = New Size(200, 40)
        ButtonCreateSubmission.TabIndex = 1
        ButtonCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        ButtonCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(262, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(261, 15)
        Label1.TabIndex = 2
        Label1.Text = "Shubh Sardana, Slidely Task 2 - Slidely Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(ButtonCreateSubmission)
        Controls.Add(ButtonViewSubmissions)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonViewSubmissions As Button
    Friend WithEvents ButtonCreateSubmission As Button
    Friend WithEvents Label1 As Label

End Class
