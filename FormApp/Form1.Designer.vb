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
        SuspendLayout()
        ' 
        ' ButtonViewSubmissions
        ' 
        ButtonViewSubmissions.Location = New Point(50, 50)
        ButtonViewSubmissions.Name = "ButtonViewSubmissions"
        ButtonViewSubmissions.Size = New Size(200, 40)
        ButtonViewSubmissions.TabIndex = 0
        ButtonViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        ButtonViewSubmissions.UseVisualStyleBackColor = True
        ' 
        ' ButtonCreateSubmission
        ' 
        ButtonCreateSubmission.Location = New Point(50, 100)
        ButtonCreateSubmission.Name = "ButtonCreateSubmission"
        ButtonCreateSubmission.Size = New Size(200, 40)
        ButtonCreateSubmission.TabIndex = 1
        ButtonCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        ButtonCreateSubmission.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonCreateSubmission)
        Controls.Add(ButtonViewSubmissions)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ButtonViewSubmissions As Button
    Friend WithEvents ButtonCreateSubmission As Button

End Class
