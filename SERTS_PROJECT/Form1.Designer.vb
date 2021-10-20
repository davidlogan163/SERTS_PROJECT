<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Show_Files = New System.Windows.Forms.Button()
        Me.playButton = New System.Windows.Forms.Button()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.resumeButton = New System.Windows.Forms.Button()
        Me.pauseButton = New System.Windows.Forms.Button()
        Me.selectFiles = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.File_List = New System.Windows.Forms.ListBox()
        Me.loadFiles = New System.Windows.Forms.Button()
        Me.ComResultTextBox = New System.Windows.Forms.TextBox()
        Me.Disconnect = New System.Windows.Forms.Button()
        Me.Connect = New System.Windows.Forms.Button()
        Me.ComListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Show_Files
        '
        Me.Show_Files.Location = New System.Drawing.Point(341, 63)
        Me.Show_Files.Name = "Show_Files"
        Me.Show_Files.Size = New System.Drawing.Size(75, 23)
        Me.Show_Files.TabIndex = 0
        Me.Show_Files.Text = "Load Files"
        Me.Show_Files.UseVisualStyleBackColor = True
        '
        'playButton
        '
        Me.playButton.Location = New System.Drawing.Point(164, 157)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(75, 23)
        Me.playButton.TabIndex = 1
        Me.playButton.Text = "Play"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'stopButton
        '
        Me.stopButton.Location = New System.Drawing.Point(282, 157)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(75, 23)
        Me.stopButton.TabIndex = 2
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'resumeButton
        '
        Me.resumeButton.Location = New System.Drawing.Point(393, 156)
        Me.resumeButton.Name = "resumeButton"
        Me.resumeButton.Size = New System.Drawing.Size(75, 23)
        Me.resumeButton.TabIndex = 3
        Me.resumeButton.Text = "Resume"
        Me.resumeButton.UseVisualStyleBackColor = True
        '
        'pauseButton
        '
        Me.pauseButton.Location = New System.Drawing.Point(508, 156)
        Me.pauseButton.Name = "pauseButton"
        Me.pauseButton.Size = New System.Drawing.Size(75, 23)
        Me.pauseButton.TabIndex = 4
        Me.pauseButton.Text = "Pause"
        Me.pauseButton.UseVisualStyleBackColor = True
        '
        'selectFiles
        '
        Me.selectFiles.Location = New System.Drawing.Point(74, 241)
        Me.selectFiles.Name = "selectFiles"
        Me.selectFiles.Size = New System.Drawing.Size(75, 23)
        Me.selectFiles.TabIndex = 6
        Me.selectFiles.Text = "Select"
        Me.selectFiles.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 337)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Currently Playing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(480, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Time Remaining"
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM4"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(164, 353)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 17)
        Me.ListBox1.TabIndex = 10
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(463, 353)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 17)
        Me.ListBox2.TabIndex = 11
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(164, 186)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(419, 136)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'File_List
        '
        Me.File_List.FormattingEnabled = True
        Me.File_List.Location = New System.Drawing.Point(164, 185)
        Me.File_List.Name = "File_List"
        Me.File_List.Size = New System.Drawing.Size(433, 134)
        Me.File_List.TabIndex = 12
        '
        'loadFiles
        '
        Me.loadFiles.Location = New System.Drawing.Point(341, 63)
        Me.loadFiles.Name = "loadFiles"
        Me.loadFiles.Size = New System.Drawing.Size(75, 23)
        Me.loadFiles.TabIndex = 0
        Me.loadFiles.Text = "Load Files"
        Me.loadFiles.UseVisualStyleBackColor = True
        '
        'ComResultTextBox
        '
        Me.ComResultTextBox.Location = New System.Drawing.Point(10, 107)
        Me.ComResultTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ComResultTextBox.Name = "ComResultTextBox"
        Me.ComResultTextBox.Size = New System.Drawing.Size(167, 20)
        Me.ComResultTextBox.TabIndex = 16
        Me.ComResultTextBox.Text = "ComResultTextBox"
        '
        'Disconnect
        '
        Me.Disconnect.Location = New System.Drawing.Point(72, 84)
        Me.Disconnect.Margin = New System.Windows.Forms.Padding(2)
        Me.Disconnect.Name = "Disconnect"
        Me.Disconnect.Size = New System.Drawing.Size(70, 19)
        Me.Disconnect.TabIndex = 15
        Me.Disconnect.Text = "Disconnect"
        Me.Disconnect.UseVisualStyleBackColor = True
        '
        'Connect
        '
        Me.Connect.Location = New System.Drawing.Point(11, 84)
        Me.Connect.Margin = New System.Windows.Forms.Padding(2)
        Me.Connect.Name = "Connect"
        Me.Connect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Connect.Size = New System.Drawing.Size(56, 19)
        Me.Connect.TabIndex = 14
        Me.Connect.Text = "Connect"
        Me.Connect.UseVisualStyleBackColor = True
        '
        'ComListBox
        '
        Me.ComListBox.FormattingEnabled = True
        Me.ComListBox.Location = New System.Drawing.Point(11, 11)
        Me.ComListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ComListBox.Name = "ComListBox"
        Me.ComListBox.Size = New System.Drawing.Size(91, 69)
        Me.ComListBox.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComResultTextBox)
        Me.Controls.Add(Me.Disconnect)
        Me.Controls.Add(Me.Connect)
        Me.Controls.Add(Me.ComListBox)
        Me.Controls.Add(Me.File_List)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.selectFiles)
        Me.Controls.Add(Me.pauseButton)
        Me.Controls.Add(Me.resumeButton)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.playButton)
        Me.Controls.Add(Me.Show_Files)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Show_Files As Button
    Friend WithEvents playButton As Button
    Friend WithEvents stopButton As Button
    Friend WithEvents resumeButton As Button
    Friend WithEvents pauseButton As Button
    Friend WithEvents selectFiles As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents File_List As ListBox
    Friend WithEvents loadFiles As Button
    Friend WithEvents ComResultTextBox As TextBox
    Friend WithEvents Disconnect As Button
    Friend WithEvents Connect As Button
    Friend WithEvents ComListBox As ListBox
End Class
