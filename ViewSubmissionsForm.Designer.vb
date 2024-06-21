Imports System.Reflection.Emit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        MainTableLayoutPanel = New TableLayoutPanel()
        NestedTableLayoutPanel = New TableLayoutPanel()
        nameLabel = New System.Windows.Forms.Label()
        emailLabel = New System.Windows.Forms.Label()
        phoneLabel = New System.Windows.Forms.Label()
        githubLabel = New System.Windows.Forms.Label()
        stopWatchLabel = New System.Windows.Forms.Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        NestedTableOfButtons = New TableLayoutPanel()
        btnPrevious = New Button()
        btnNext = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        FormLabel = New System.Windows.Forms.Label()
        MainTableLayoutPanel.SuspendLayout()
        NestedTableLayoutPanel.SuspendLayout()
        NestedTableOfButtons.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainTableLayoutPanel
        ' 
        MainTableLayoutPanel.ColumnCount = 1
        MainTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20.0F))
        MainTableLayoutPanel.Controls.Add(NestedTableLayoutPanel, 1, 0)
        MainTableLayoutPanel.Controls.Add(NestedTableOfButtons, 2, 0)
        MainTableLayoutPanel.Controls.Add(FormLabel, 0, 0)
        MainTableLayoutPanel.Location = New Point(10, 10)
        MainTableLayoutPanel.Name = "MainTableLayoutPanel"
        MainTableLayoutPanel.RowCount = 3
        MainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        MainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 70.0F))
        MainTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        MainTableLayoutPanel.Size = New Size(780, 507)
        MainTableLayoutPanel.TabIndex = 0
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
        NestedTableLayoutPanel.Controls.Add(stopWatchLabel, 0, 4)
        NestedTableLayoutPanel.Controls.Add(txtName, 1, 0)
        NestedTableLayoutPanel.Controls.Add(txtEmail, 1, 1)
        NestedTableLayoutPanel.Controls.Add(txtPhone, 1, 2)
        NestedTableLayoutPanel.Controls.Add(txtGitHubLink, 1, 3)
        NestedTableLayoutPanel.Controls.Add(txtStopwatchTime, 1, 4)
        NestedTableLayoutPanel.Location = New Point(3, 53)
        NestedTableLayoutPanel.Name = "NestedTableLayoutPanel"
        NestedTableLayoutPanel.RowCount = 5
        NestedTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        NestedTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        NestedTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        NestedTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        NestedTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        NestedTableLayoutPanel.RowStyles.Add(New RowStyle())
        NestedTableLayoutPanel.Size = New Size(774, 295)
        NestedTableLayoutPanel.TabIndex = 1
        ' 
        ' nameLabel
        ' 
        nameLabel.Anchor = AnchorStyles.Bottom
        nameLabel.AutoSize = True
        nameLabel.Font = New Font("Arial", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameLabel.Location = New Point(47, 32)
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
        emailLabel.Location = New Point(48, 91)
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
        phoneLabel.Location = New Point(8, 150)
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
        githubLabel.Location = New Point(23, 209)
        githubLabel.Margin = New Padding(2, 5, 2, 5)
        githubLabel.Name = "githubLabel"
        githubLabel.Size = New Size(107, 22)
        githubLabel.TabIndex = 6
        githubLabel.Text = "GitHub Link"
        githubLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' stopWatchLabel
        ' 
        stopWatchLabel.Anchor = AnchorStyles.Bottom
        stopWatchLabel.AutoSize = True
        stopWatchLabel.Font = New Font("Arial", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        stopWatchLabel.Location = New Point(4, 268)
        stopWatchLabel.Margin = New Padding(2, 5, 2, 5)
        stopWatchLabel.Name = "stopWatchLabel"
        stopWatchLabel.Size = New Size(145, 22)
        stopWatchLabel.TabIndex = 8
        stopWatchLabel.Text = "Stopwatch Time"
        stopWatchLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Bottom
        txtName.Location = New Point(214, 28)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(500, 27)
        txtName.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Bottom
        txtEmail.Location = New Point(214, 87)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(500, 27)
        txtEmail.TabIndex = 3
        ' 
        ' txtPhone
        ' 
        txtPhone.Anchor = AnchorStyles.Bottom
        txtPhone.Location = New Point(214, 146)
        txtPhone.Margin = New Padding(3, 4, 3, 4)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(500, 27)
        txtPhone.TabIndex = 5
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Anchor = AnchorStyles.Bottom
        txtGitHubLink.Location = New Point(214, 205)
        txtGitHubLink.Margin = New Padding(3, 4, 3, 4)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.ReadOnly = True
        txtGitHubLink.Size = New Size(500, 27)
        txtGitHubLink.TabIndex = 7
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Anchor = AnchorStyles.Bottom
        txtStopwatchTime.Location = New Point(214, 264)
        txtStopwatchTime.Margin = New Padding(3, 4, 3, 4)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(500, 27)
        txtStopwatchTime.TabIndex = 9
        ' 
        ' NestedTableOfButtons
        ' 
        NestedTableOfButtons.ColumnCount = 2
        NestedTableOfButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        NestedTableOfButtons.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        NestedTableOfButtons.Controls.Add(btnPrevious, 0, 0)
        NestedTableOfButtons.Controls.Add(btnNext, 1, 0)
        NestedTableOfButtons.Controls.Add(btnEdit, 0, 1)
        NestedTableOfButtons.Controls.Add(btnDelete, 1, 1)
        NestedTableOfButtons.Location = New Point(3, 407)
        NestedTableOfButtons.Name = "NestedTableOfButtons"
        NestedTableOfButtons.RowCount = 2
        NestedTableOfButtons.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        NestedTableOfButtons.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        NestedTableOfButtons.Size = New Size(774, 97)
        NestedTableOfButtons.TabIndex = 10
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnPrevious.FlatAppearance.BorderColor = Color.Black
        btnPrevious.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnPrevious.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrevious.Location = New Point(3, 4)
        btnPrevious.Margin = New Padding(3, 4, 3, 4)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(381, 40)
        btnPrevious.TabIndex = 10
        btnPrevious.Text = "Previous (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(173), CByte(216), CByte(230))
        btnNext.FlatAppearance.BorderColor = Color.Black
        btnNext.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnNext.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNext.Location = New Point(390, 4)
        btnNext.Margin = New Padding(3, 4, 3, 4)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(381, 40)
        btnNext.TabIndex = 11
        btnNext.Text = "Next (CTRL + N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnEdit.FlatAppearance.BorderColor = Color.Black
        btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEdit.Location = New Point(3, 52)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(381, 41)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Edit (CTRL + E)"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
        btnDelete.FlatAppearance.BorderColor = Color.Black
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Arial", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(390, 52)
        btnDelete.Margin = New Padding(3, 4, 3, 4)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(381, 41)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete (CTRL + D)"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' FormLabel
        ' 
        FormLabel.Anchor = AnchorStyles.Top
        FormLabel.AutoSize = True
        FormLabel.Font = New Font("Arial", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormLabel.Location = New Point(137, 20)
        FormLabel.Margin = New Padding(2, 20, 2, 2)
        FormLabel.Name = "FormLabel"
        FormLabel.Size = New Size(505, 27)
        FormLabel.TabIndex = 0
        FormLabel.Text = "Anil Solanki, Slidely Task 2 - View Submission"
        FormLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 562)
        Controls.Add(MainTableLayoutPanel)
        Margin = New Padding(3, 4, 3, 4)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        MainTableLayoutPanel.ResumeLayout(False)
        MainTableLayoutPanel.PerformLayout()
        NestedTableLayoutPanel.ResumeLayout(False)
        NestedTableLayoutPanel.PerformLayout()
        NestedTableOfButtons.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Private WithEvents MainTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Private WithEvents NestedTableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Private WithEvents NestedTableOfButtons As System.Windows.Forms.TableLayoutPanel
    Private WithEvents FormLabel As System.Windows.Forms.Label
    Friend WithEvents txtName As TextBox
    Private WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents txtEmail As TextBox
    Private WithEvents emailLabel As System.Windows.Forms.Label
    Friend WithEvents txtPhone As TextBox
    Private WithEvents phoneLabel As System.Windows.Forms.Label
    Friend WithEvents txtGitHubLink As TextBox
    Private WithEvents githubLabel As System.Windows.Forms.Label
    Friend WithEvents txtStopwatchTime As TextBox
    Private WithEvents stopWatchLabel As System.Windows.Forms.Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button

End Class
