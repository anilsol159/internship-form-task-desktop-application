Imports System.Xml

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MainTableLayoutPanel = New TableLayoutPanel()
        Timer1 = New Timer()
        FormLabel = New Label()
        NestedTableLayoutPanel = New TableLayoutPanel()
        nameLabel = New Label()
        emailLabel = New Label()
        phoneLabel = New Label()
        githubLabel = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        NestedTableStopWatchPanel = New TableLayoutPanel()
        btnToggleStopwatch = New Button()
        lblStopwatchTime = New Label()
        btnSubmit = New Button()
        MainTableLayoutPanel.SuspendLayout()
        NestedTableLayoutPanel.SuspendLayout()
        NestedTableStopWatchPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainTableLayoutPanel
        ' 
        MainTableLayoutPanel.ColumnCount = 1
        MainTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20.0F))
        MainTableLayoutPanel.Controls.Add(FormLabel, 0, 0)
        MainTableLayoutPanel.Controls.Add(NestedTableLayoutPanel, 0, 1)
        MainTableLayoutPanel.Controls.Add(NestedTableStopWatchPanel, 0, 2)
        MainTableLayoutPanel.Controls.Add(btnSubmit, 0, 3)
        MainTableLayoutPanel.Location = New Point(10, 10)
        MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        MainTableLayoutPanel.RowCount = 4
        MainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        MainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        MainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        MainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        MainTableLayoutPanel.Size = New Size(780, 507)
        MainTableLayoutPanel.TabIndex = 0
        ' 
        ' FormLabel
        ' 
        FormLabel.Anchor = AnchorStyles.Top
        FormLabel.AutoSize = True
        FormLabel.Font = New Font("Arial", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormLabel.Location = New Point(128, 20)
        FormLabel.Margin = New Padding(2, 20, 2, 2)
        FormLabel.Name = "FormLabel"
        FormLabel.Size = New Size(524, 27)
        FormLabel.TabIndex = 0
        FormLabel.Text = "Anil Solanki, Slidely Task 2 - Create Submission"
        FormLabel.TextAlign = ContentAlignment.MiddleCenter

        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        ' 
        ' NestedTableLayoutPanel
        ' 
        NestedTableLayoutPanel.ColumnCount = 2
        NestedTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        NestedTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80.0F))
        NestedTableLayoutPanel.Controls.Add(nameLabel, 0, 0)
        NestedTableLayoutPanel.Controls.Add(emailLabel, 0, 1)
        NestedTableLayoutPanel.Controls.Add(phoneLabel, 0, 2)
        NestedTableLayoutPanel.Controls.Add(githubLabel, 0, 3)
        NestedTableLayoutPanel.Controls.Add(txtName, 1, 0)
        NestedTableLayoutPanel.Controls.Add(txtEmail, 1, 1)
        NestedTableLayoutPanel.Controls.Add(txtPhone, 1, 2)
        NestedTableLayoutPanel.Controls.Add(txtGitHubLink, 1, 3)
        NestedTableLayoutPanel.Location = New Point(3, 53)
        NestedTableLayoutPanel.Name = "NestedTableLayoutPanel"
        NestedTableLayoutPanel.RowCount = 4
        NestedTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        NestedTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        NestedTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        NestedTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        NestedTableLayoutPanel.RowStyles.Add(New RowStyle())
        NestedTableLayoutPanel.Size = New Size(774, 247)
        NestedTableLayoutPanel.TabIndex = 1
        ' 
        ' nameLabel
        ' 
        nameLabel.Anchor = AnchorStyles.Bottom
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Arial", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameLabel.Location = New Point(47, 34)
        nameLabel.Margin = New Padding(2, 5, 2, 5)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(60, 22)
        nameLabel.TabIndex = 0
        nameLabel.Text = "Name"
        nameLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' emailLabel
        ' 
        emailLabel.Anchor = AnchorStyles.Bottom
        emailLabel.AutoSize = True
        emailLabel.Font = New Font("Arial", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailLabel.Location = New Point(48, 95)
        emailLabel.Margin = New Padding(2, 5, 2, 5)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(57, 22)
        emailLabel.TabIndex = 2
        emailLabel.Text = "Email"
        emailLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' phoneLabel
        ' 
        phoneLabel.Anchor = AnchorStyles.Bottom
        phoneLabel.AutoSize = True
        phoneLabel.Font = New Font("Arial", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        phoneLabel.Location = New Point(8, 156)
        phoneLabel.Margin = New Padding(2, 5, 2, 5)
        phoneLabel.Name = "phoneLabel"
        phoneLabel.Size = New Size(137, 22)
        phoneLabel.TabIndex = 4
        phoneLabel.Text = "Phone Number"
        phoneLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' githubLabel
        ' 
        githubLabel.Anchor = AnchorStyles.Bottom
        githubLabel.AutoSize = True
        githubLabel.Font = New Font("Arial", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        githubLabel.Location = New Point(23, 220)
        githubLabel.Margin = New Padding(2, 5, 2, 5)
        githubLabel.Name = "githubLabel"
        githubLabel.Size = New Size(107, 22)
        githubLabel.TabIndex = 6
        githubLabel.Text = "GitHub Link"
        githubLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Bottom
        txtName.Location = New Point(214, 30)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(500, 27)
        txtName.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Bottom
        txtEmail.Location = New Point(214, 91)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(500, 27)
        txtEmail.TabIndex = 7
        ' 
        ' txtPhone
        ' 
        txtPhone.Anchor = AnchorStyles.Bottom
        txtPhone.Location = New Point(214, 152)
        txtPhone.Margin = New Padding(3, 4, 3, 4)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(500, 27)
        txtPhone.TabIndex = 7
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Anchor = AnchorStyles.Bottom
        txtGitHubLink.Location = New Point(214, 216)
        txtGitHubLink.Margin = New Padding(3, 4, 3, 4)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(500, 27)
        txtGitHubLink.TabIndex = 7
        ' 
        ' NestedTableStopWatchPanel
        ' 
        NestedTableStopWatchPanel.ColumnCount = 2
        NestedTableStopWatchPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        NestedTableStopWatchPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        NestedTableStopWatchPanel.Controls.Add(btnToggleStopwatch, 0, 0)
        NestedTableStopWatchPanel.Controls.Add(lblStopwatchTime, 1, 0)
        NestedTableStopWatchPanel.Location = New Point(3, 306)
        NestedTableStopWatchPanel.Name = "NestedTableStopWatchPanel"
        NestedTableStopWatchPanel.RowCount = 1
        NestedTableStopWatchPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        NestedTableStopWatchPanel.Size = New Size(774, 85)
        NestedTableStopWatchPanel.TabIndex = 1
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Anchor = AnchorStyles.Bottom
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnToggleStopwatch.FlatAppearance.BorderColor = Color.Black
        btnToggleStopwatch.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnToggleStopwatch.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnToggleStopwatch.FlatStyle = FlatStyle.Flat
        btnToggleStopwatch.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToggleStopwatch.Location = New Point(5, 30)
        btnToggleStopwatch.Margin = New Padding(3, 4, 3, 4)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(377, 51)
        btnToggleStopwatch.TabIndex = 0
        btnToggleStopwatch.Text = "Toggle Stopwatch (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.Anchor = AnchorStyles.Bottom
        lblStopwatchTime.BackColor = Color.FromArgb(CByte(211), CByte(255), CByte(192))
        lblStopwatchTime.FlatStyle = FlatStyle.Flat
        lblStopwatchTime.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStopwatchTime.Location = New Point(476, 30)
        lblStopwatchTime.Margin = New Padding(3, 4, 3, 4)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(209, 51)
        lblStopwatchTime.TabIndex = 6
        lblStopwatchTime.Text = "00:00:00"
        lblStopwatchTime.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        btnSubmit.BackColor = Color.FromArgb(CByte(173), CByte(216), CByte(230))
        btnSubmit.FlatAppearance.BorderColor = Color.Black
        btnSubmit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnSubmit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(124, 408)
        btnSubmit.Margin = New Padding(3, 4, 3, 4)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(532, 95)
        btnSubmit.TabIndex = 1
        btnSubmit.Text = "Submit (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 562)
        Controls.Add(MainTableLayoutPanel)
        Margin = New Padding(3, 4, 3, 4)
        Name = "CreateSubmissionForm"
        Text = "Create Submission"
        MainTableLayoutPanel.ResumeLayout(False)
        MainTableLayoutPanel.PerformLayout()
        NestedTableLayoutPanel.ResumeLayout(False)
        NestedTableLayoutPanel.PerformLayout()
        NestedTableStopWatchPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents MainTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Private WithEvents NestedTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Private WithEvents NestedTableStopWatchPanel As System.Windows.Forms.TableLayoutPanel
    Private WithEvents FormLabel As System.Windows.Forms.Label
    Private WithEvents nameLabel As System.Windows.Forms.Label
    Private WithEvents emailLabel As System.Windows.Forms.Label
    Private WithEvents phoneLabel As System.Windows.Forms.Label
    Private WithEvents githubLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button

End Class
