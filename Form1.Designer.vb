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
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Text = "Anil Solanki, Slidely Task 2 - Slidely Form App"
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(Me.ClientSize.Width / 2, 100)
        Me.Label1.Name = "LabelTitle"
        Me.Label1.Size = New System.Drawing.Size(400, 27)
        Me.Label1.TabIndex = 0

        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' btnViewSubmissions
        ' 
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.FromArgb(255, 255, 192)
        Me.btnViewSubmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewSubmissions.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnViewSubmissions.Location = New Point(200, 188)
        btnViewSubmissions.Margin = New Padding(3, 4, 3, 4)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(400, 62)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = True
        Me.btnViewSubmissions.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnViewSubmissions.FlatAppearance.BorderSize = 1
        Me.btnViewSubmissions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(224, 224, 224)
        Me.btnViewSubmissions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.btnViewSubmissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        ' 
        ' btnCreateSubmission
        ' 
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.FromArgb(173, 216, 230)
        Me.btnCreateSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateSubmission.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateSubmission.Location = New System.Drawing.Point(50, 120)
        btnCreateSubmission.Location = New Point(200, 312)
        btnCreateSubmission.Margin = New Padding(3, 4, 3, 4)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(400, 62)
        btnCreateSubmission.TabIndex = 2
        btnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnCreateSubmission.UseVisualStyleBackColor = True
        Me.btnCreateSubmission.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCreateSubmission.FlatAppearance.BorderSize = 1
        Me.btnCreateSubmission.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(224, 224, 224)
        Me.btnCreateSubmission.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240)


        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 562)
        Controls.Add(Label1)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Slidely Form App"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents Label1 As Label

End Class
