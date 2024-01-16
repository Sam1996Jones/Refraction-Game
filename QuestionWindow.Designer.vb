<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionWindow
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
        Me.Button_NextQ = New System.Windows.Forms.Button()
        Me.RadioButton_Option1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Option2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Option3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Option4 = New System.Windows.Forms.RadioButton()
        Me.PictureBox_QPicture = New System.Windows.Forms.PictureBox()
        Me.ProgressBar_QNumber = New System.Windows.Forms.ProgressBar()
        Me.Label_Questions = New System.Windows.Forms.Label()
        Me.Button_PreviousQ = New System.Windows.Forms.Button()
        CType(Me.PictureBox_QPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_NextQ
        '
        Me.Button_NextQ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_NextQ.Location = New System.Drawing.Point(255, 329)
        Me.Button_NextQ.Name = "Button_NextQ"
        Me.Button_NextQ.Size = New System.Drawing.Size(122, 60)
        Me.Button_NextQ.TabIndex = 0
        Me.Button_NextQ.Text = "Next Question"
        Me.Button_NextQ.UseVisualStyleBackColor = True
        '
        'RadioButton_Option1
        '
        Me.RadioButton_Option1.AutoSize = True
        Me.RadioButton_Option1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Option1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Option1.Location = New System.Drawing.Point(12, 115)
        Me.RadioButton_Option1.Name = "RadioButton_Option1"
        Me.RadioButton_Option1.Size = New System.Drawing.Size(197, 35)
        Me.RadioButton_Option1.TabIndex = 1
        Me.RadioButton_Option1.TabStop = True
        Me.RadioButton_Option1.Text = "RadioButton1"
        Me.RadioButton_Option1.UseVisualStyleBackColor = True
        '
        'RadioButton_Option2
        '
        Me.RadioButton_Option2.AutoSize = True
        Me.RadioButton_Option2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Option2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Option2.Location = New System.Drawing.Point(12, 156)
        Me.RadioButton_Option2.Name = "RadioButton_Option2"
        Me.RadioButton_Option2.Size = New System.Drawing.Size(197, 35)
        Me.RadioButton_Option2.TabIndex = 2
        Me.RadioButton_Option2.TabStop = True
        Me.RadioButton_Option2.Text = "RadioButton2"
        Me.RadioButton_Option2.UseVisualStyleBackColor = True
        '
        'RadioButton_Option3
        '
        Me.RadioButton_Option3.AutoSize = True
        Me.RadioButton_Option3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Option3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Option3.Location = New System.Drawing.Point(12, 197)
        Me.RadioButton_Option3.Name = "RadioButton_Option3"
        Me.RadioButton_Option3.Size = New System.Drawing.Size(197, 35)
        Me.RadioButton_Option3.TabIndex = 3
        Me.RadioButton_Option3.TabStop = True
        Me.RadioButton_Option3.Text = "RadioButton3"
        Me.RadioButton_Option3.UseVisualStyleBackColor = True
        '
        'RadioButton_Option4
        '
        Me.RadioButton_Option4.AutoSize = True
        Me.RadioButton_Option4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Option4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Option4.Location = New System.Drawing.Point(12, 238)
        Me.RadioButton_Option4.Name = "RadioButton_Option4"
        Me.RadioButton_Option4.Size = New System.Drawing.Size(197, 35)
        Me.RadioButton_Option4.TabIndex = 4
        Me.RadioButton_Option4.TabStop = True
        Me.RadioButton_Option4.Text = "RadioButton4"
        Me.RadioButton_Option4.UseVisualStyleBackColor = True
        '
        'PictureBox_QPicture
        '
        Me.PictureBox_QPicture.Location = New System.Drawing.Point(383, 41)
        Me.PictureBox_QPicture.Name = "PictureBox_QPicture"
        Me.PictureBox_QPicture.Size = New System.Drawing.Size(337, 348)
        Me.PictureBox_QPicture.TabIndex = 5
        Me.PictureBox_QPicture.TabStop = False
        '
        'ProgressBar_QNumber
        '
        Me.ProgressBar_QNumber.Cursor = System.Windows.Forms.Cursors.No
        Me.ProgressBar_QNumber.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.ProgressBar_QNumber.Location = New System.Drawing.Point(620, 12)
        Me.ProgressBar_QNumber.MarqueeAnimationSpeed = 500
        Me.ProgressBar_QNumber.Maximum = 10
        Me.ProgressBar_QNumber.Name = "ProgressBar_QNumber"
        Me.ProgressBar_QNumber.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar_QNumber.Step = 1
        Me.ProgressBar_QNumber.TabIndex = 6
        Me.ProgressBar_QNumber.Value = 1
        '
        'Label_Questions
        '
        Me.Label_Questions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Questions.Location = New System.Drawing.Point(9, 12)
        Me.Label_Questions.Name = "Label_Questions"
        Me.Label_Questions.Size = New System.Drawing.Size(368, 100)
        Me.Label_Questions.TabIndex = 7
        Me.Label_Questions.Text = "Label1"
        '
        'Button_PreviousQ
        '
        Me.Button_PreviousQ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_PreviousQ.Location = New System.Drawing.Point(12, 329)
        Me.Button_PreviousQ.Name = "Button_PreviousQ"
        Me.Button_PreviousQ.Size = New System.Drawing.Size(122, 60)
        Me.Button_PreviousQ.TabIndex = 8
        Me.Button_PreviousQ.Text = "Previous"
        Me.Button_PreviousQ.UseVisualStyleBackColor = True
        '
        'QuestionWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 401)
        Me.Controls.Add(Me.Button_PreviousQ)
        Me.Controls.Add(Me.Label_Questions)
        Me.Controls.Add(Me.ProgressBar_QNumber)
        Me.Controls.Add(Me.RadioButton_Option4)
        Me.Controls.Add(Me.RadioButton_Option3)
        Me.Controls.Add(Me.RadioButton_Option2)
        Me.Controls.Add(Me.RadioButton_Option1)
        Me.Controls.Add(Me.Button_NextQ)
        Me.Controls.Add(Me.PictureBox_QPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "QuestionWindow"
        Me.Text = "Questions"
        CType(Me.PictureBox_QPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_NextQ As System.Windows.Forms.Button
    Friend WithEvents RadioButton_Option1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Option2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Option3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Option4 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox_QPicture As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar_QNumber As System.Windows.Forms.ProgressBar
    Friend WithEvents Label_Questions As System.Windows.Forms.Label
    Friend WithEvents Button_PreviousQ As System.Windows.Forms.Button
End Class
