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
        Me.PictureBox_Refraction = New System.Windows.Forms.PictureBox()
        Me.TextBox_IncidentAngle = New System.Windows.Forms.TextBox()
        Me.Label_IncidentAngle = New System.Windows.Forms.Label()
        Me.TextBox_RefractiveIndexMediumOne = New System.Windows.Forms.TextBox()
        Me.Label_IndexMediumOne = New System.Windows.Forms.Label()
        Me.TextBox_RefractiveIndexMediumTwo = New System.Windows.Forms.TextBox()
        Me.Label_IndexMediumTwo = New System.Windows.Forms.Label()
        Me.CheckBox_RefractiveIndexShow = New System.Windows.Forms.CheckBox()
        Me.Button_ShowRefraction = New System.Windows.Forms.Button()
        Me.Button_ShowCritAngle = New System.Windows.Forms.Button()
        Me.ListBox_ColourOfLight = New System.Windows.Forms.ListBox()
        Me.Label_ColourOfLight = New System.Windows.Forms.Label()
        Me.Button_Questions = New System.Windows.Forms.Button()
        Me.ListBox_Material = New System.Windows.Forms.ListBox()
        Me.Label_Material = New System.Windows.Forms.Label()
        Me.Label_CriticalAngle = New System.Windows.Forms.Label()
        Me.Label_CritAngleTxt = New System.Windows.Forms.Label()
        Me.Label_RefractedAngle = New System.Windows.Forms.Label()
        Me.Label_RefractedAngleText = New System.Windows.Forms.Label()
        Me.Button_Help = New System.Windows.Forms.Button()
        Me.RadioButton_Rectangle = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Prism = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Plane = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Semi = New System.Windows.Forms.RadioButton()
        Me.CheckBox_MultipleRay = New System.Windows.Forms.CheckBox()
        Me.TextBox_SemiWidth = New System.Windows.Forms.TextBox()
        Me.Label_SemiWidth = New System.Windows.Forms.Label()
        Me.Label_SemiHeight = New System.Windows.Forms.Label()
        Me.TextBox_semiHeight = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox_Refraction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_Refraction
        '
        Me.PictureBox_Refraction.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox_Refraction.Name = "PictureBox_Refraction"
        Me.PictureBox_Refraction.Size = New System.Drawing.Size(540, 627)
        Me.PictureBox_Refraction.TabIndex = 0
        Me.PictureBox_Refraction.TabStop = False
        '
        'TextBox_IncidentAngle
        '
        Me.TextBox_IncidentAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_IncidentAngle.Location = New System.Drawing.Point(564, 72)
        Me.TextBox_IncidentAngle.Name = "TextBox_IncidentAngle"
        Me.TextBox_IncidentAngle.Size = New System.Drawing.Size(143, 31)
        Me.TextBox_IncidentAngle.TabIndex = 1
        Me.TextBox_IncidentAngle.Text = "30"
        Me.TextBox_IncidentAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_IncidentAngle
        '
        Me.Label_IncidentAngle.AutoSize = True
        Me.Label_IncidentAngle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_IncidentAngle.ForeColor = System.Drawing.Color.White
        Me.Label_IncidentAngle.Location = New System.Drawing.Point(559, 44)
        Me.Label_IncidentAngle.Name = "Label_IncidentAngle"
        Me.Label_IncidentAngle.Size = New System.Drawing.Size(148, 25)
        Me.Label_IncidentAngle.TabIndex = 2
        Me.Label_IncidentAngle.Text = "Incident Angle"
        Me.Label_IncidentAngle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox_RefractiveIndexMediumOne
        '
        Me.TextBox_RefractiveIndexMediumOne.Location = New System.Drawing.Point(564, 196)
        Me.TextBox_RefractiveIndexMediumOne.Name = "TextBox_RefractiveIndexMediumOne"
        Me.TextBox_RefractiveIndexMediumOne.Size = New System.Drawing.Size(90, 20)
        Me.TextBox_RefractiveIndexMediumOne.TabIndex = 3
        Me.TextBox_RefractiveIndexMediumOne.Text = "1.00"
        Me.TextBox_RefractiveIndexMediumOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_IndexMediumOne
        '
        Me.Label_IndexMediumOne.ForeColor = System.Drawing.Color.White
        Me.Label_IndexMediumOne.Location = New System.Drawing.Point(561, 161)
        Me.Label_IndexMediumOne.Name = "Label_IndexMediumOne"
        Me.Label_IndexMediumOne.Size = New System.Drawing.Size(93, 32)
        Me.Label_IndexMediumOne.TabIndex = 4
        Me.Label_IndexMediumOne.Text = "Refractive index for medium one"
        Me.Label_IndexMediumOne.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox_RefractiveIndexMediumTwo
        '
        Me.TextBox_RefractiveIndexMediumTwo.Location = New System.Drawing.Point(705, 196)
        Me.TextBox_RefractiveIndexMediumTwo.Name = "TextBox_RefractiveIndexMediumTwo"
        Me.TextBox_RefractiveIndexMediumTwo.Size = New System.Drawing.Size(90, 20)
        Me.TextBox_RefractiveIndexMediumTwo.TabIndex = 5
        Me.TextBox_RefractiveIndexMediumTwo.Text = "1.50"
        Me.TextBox_RefractiveIndexMediumTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_IndexMediumTwo
        '
        Me.Label_IndexMediumTwo.ForeColor = System.Drawing.Color.White
        Me.Label_IndexMediumTwo.Location = New System.Drawing.Point(702, 161)
        Me.Label_IndexMediumTwo.Name = "Label_IndexMediumTwo"
        Me.Label_IndexMediumTwo.Size = New System.Drawing.Size(90, 32)
        Me.Label_IndexMediumTwo.TabIndex = 6
        Me.Label_IndexMediumTwo.Text = "Refractive index for medium two"
        Me.Label_IndexMediumTwo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CheckBox_RefractiveIndexShow
        '
        Me.CheckBox_RefractiveIndexShow.AutoSize = True
        Me.CheckBox_RefractiveIndexShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox_RefractiveIndexShow.ForeColor = System.Drawing.Color.White
        Me.CheckBox_RefractiveIndexShow.Location = New System.Drawing.Point(562, 127)
        Me.CheckBox_RefractiveIndexShow.Name = "CheckBox_RefractiveIndexShow"
        Me.CheckBox_RefractiveIndexShow.Size = New System.Drawing.Size(212, 17)
        Me.CheckBox_RefractiveIndexShow.TabIndex = 7
        Me.CheckBox_RefractiveIndexShow.Text = "Change refractive index for medium two"
        Me.CheckBox_RefractiveIndexShow.UseVisualStyleBackColor = True
        '
        'Button_ShowRefraction
        '
        Me.Button_ShowRefraction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_ShowRefraction.Location = New System.Drawing.Point(558, 600)
        Me.Button_ShowRefraction.Name = "Button_ShowRefraction"
        Me.Button_ShowRefraction.Size = New System.Drawing.Size(144, 39)
        Me.Button_ShowRefraction.TabIndex = 8
        Me.Button_ShowRefraction.Text = "Refract"
        Me.Button_ShowRefraction.UseVisualStyleBackColor = True
        '
        'Button_ShowCritAngle
        '
        Me.Button_ShowCritAngle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_ShowCritAngle.Location = New System.Drawing.Point(708, 600)
        Me.Button_ShowCritAngle.Name = "Button_ShowCritAngle"
        Me.Button_ShowCritAngle.Size = New System.Drawing.Size(125, 39)
        Me.Button_ShowCritAngle.TabIndex = 9
        Me.Button_ShowCritAngle.Text = "Show critical angle"
        Me.Button_ShowCritAngle.UseVisualStyleBackColor = True
        '
        'ListBox_ColourOfLight
        '
        Me.ListBox_ColourOfLight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListBox_ColourOfLight.FormattingEnabled = True
        Me.ListBox_ColourOfLight.Items.AddRange(New Object() {"Red", "Orange", "Yellow", "Green", "Blue", "Violet"})
        Me.ListBox_ColourOfLight.Location = New System.Drawing.Point(745, 252)
        Me.ListBox_ColourOfLight.Name = "ListBox_ColourOfLight"
        Me.ListBox_ColourOfLight.Size = New System.Drawing.Size(50, 95)
        Me.ListBox_ColourOfLight.TabIndex = 10
        '
        'Label_ColourOfLight
        '
        Me.Label_ColourOfLight.AutoSize = True
        Me.Label_ColourOfLight.ForeColor = System.Drawing.Color.White
        Me.Label_ColourOfLight.Location = New System.Drawing.Point(733, 236)
        Me.Label_ColourOfLight.Name = "Label_ColourOfLight"
        Me.Label_ColourOfLight.Size = New System.Drawing.Size(71, 13)
        Me.Label_ColourOfLight.TabIndex = 11
        Me.Label_ColourOfLight.Text = "Colour of light"
        '
        'Button_Questions
        '
        Me.Button_Questions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Questions.Location = New System.Drawing.Point(625, 555)
        Me.Button_Questions.Name = "Button_Questions"
        Me.Button_Questions.Size = New System.Drawing.Size(158, 39)
        Me.Button_Questions.TabIndex = 12
        Me.Button_Questions.Text = "Questions"
        Me.Button_Questions.UseVisualStyleBackColor = True
        '
        'ListBox_Material
        '
        Me.ListBox_Material.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListBox_Material.FormattingEnabled = True
        Me.ListBox_Material.Items.AddRange(New Object() {"Fused silica", "Borosilicate glass", "Hard crown glass", "Barium crown glass", "Barium flint glass", "Dense flint glass"})
        Me.ListBox_Material.Location = New System.Drawing.Point(564, 252)
        Me.ListBox_Material.Name = "ListBox_Material"
        Me.ListBox_Material.Size = New System.Drawing.Size(103, 82)
        Me.ListBox_Material.TabIndex = 13
        '
        'Label_Material
        '
        Me.Label_Material.AutoSize = True
        Me.Label_Material.ForeColor = System.Drawing.Color.White
        Me.Label_Material.Location = New System.Drawing.Point(591, 236)
        Me.Label_Material.Name = "Label_Material"
        Me.Label_Material.Size = New System.Drawing.Size(44, 13)
        Me.Label_Material.TabIndex = 14
        Me.Label_Material.Text = "Material"
        '
        'Label_CriticalAngle
        '
        Me.Label_CriticalAngle.AutoSize = True
        Me.Label_CriticalAngle.ForeColor = System.Drawing.Color.White
        Me.Label_CriticalAngle.Location = New System.Drawing.Point(702, 360)
        Me.Label_CriticalAngle.Name = "Label_CriticalAngle"
        Me.Label_CriticalAngle.Size = New System.Drawing.Size(70, 13)
        Me.Label_CriticalAngle.TabIndex = 15
        Me.Label_CriticalAngle.Text = "Critical angle:"
        '
        'Label_CritAngleTxt
        '
        Me.Label_CritAngleTxt.ForeColor = System.Drawing.Color.White
        Me.Label_CritAngleTxt.Location = New System.Drawing.Point(778, 360)
        Me.Label_CritAngleTxt.Name = "Label_CritAngleTxt"
        Me.Label_CritAngleTxt.Size = New System.Drawing.Size(55, 23)
        Me.Label_CritAngleTxt.TabIndex = 16
        '
        'Label_RefractedAngle
        '
        Me.Label_RefractedAngle.AutoSize = True
        Me.Label_RefractedAngle.ForeColor = System.Drawing.Color.White
        Me.Label_RefractedAngle.Location = New System.Drawing.Point(561, 360)
        Me.Label_RefractedAngle.Name = "Label_RefractedAngle"
        Me.Label_RefractedAngle.Size = New System.Drawing.Size(86, 13)
        Me.Label_RefractedAngle.TabIndex = 17
        Me.Label_RefractedAngle.Text = "Refracted angle:"
        '
        'Label_RefractedAngleText
        '
        Me.Label_RefractedAngleText.ForeColor = System.Drawing.Color.White
        Me.Label_RefractedAngleText.Location = New System.Drawing.Point(653, 360)
        Me.Label_RefractedAngleText.Name = "Label_RefractedAngleText"
        Me.Label_RefractedAngleText.Size = New System.Drawing.Size(43, 23)
        Me.Label_RefractedAngleText.TabIndex = 18
        '
        'Button_Help
        '
        Me.Button_Help.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Help.Location = New System.Drawing.Point(774, 13)
        Me.Button_Help.Name = "Button_Help"
        Me.Button_Help.Size = New System.Drawing.Size(58, 31)
        Me.Button_Help.TabIndex = 21
        Me.Button_Help.Text = "Help"
        Me.Button_Help.UseVisualStyleBackColor = True
        '
        'RadioButton_Rectangle
        '
        Me.RadioButton_Rectangle.AutoSize = True
        Me.RadioButton_Rectangle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Rectangle.ForeColor = System.Drawing.Color.White
        Me.RadioButton_Rectangle.Location = New System.Drawing.Point(701, 405)
        Me.RadioButton_Rectangle.Name = "RadioButton_Rectangle"
        Me.RadioButton_Rectangle.Size = New System.Drawing.Size(91, 17)
        Me.RadioButton_Rectangle.TabIndex = 22
        Me.RadioButton_Rectangle.TabStop = True
        Me.RadioButton_Rectangle.Text = "Add rectangle"
        Me.RadioButton_Rectangle.UseVisualStyleBackColor = True
        '
        'RadioButton_Prism
        '
        Me.RadioButton_Prism.AutoSize = True
        Me.RadioButton_Prism.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Prism.ForeColor = System.Drawing.Color.White
        Me.RadioButton_Prism.Location = New System.Drawing.Point(562, 428)
        Me.RadioButton_Prism.Name = "RadioButton_Prism"
        Me.RadioButton_Prism.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton_Prism.TabIndex = 23
        Me.RadioButton_Prism.TabStop = True
        Me.RadioButton_Prism.Text = "Add Prism"
        Me.RadioButton_Prism.UseVisualStyleBackColor = True
        '
        'RadioButton_Plane
        '
        Me.RadioButton_Plane.AutoSize = True
        Me.RadioButton_Plane.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Plane.ForeColor = System.Drawing.Color.White
        Me.RadioButton_Plane.Location = New System.Drawing.Point(562, 405)
        Me.RadioButton_Plane.Name = "RadioButton_Plane"
        Me.RadioButton_Plane.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton_Plane.TabIndex = 24
        Me.RadioButton_Plane.TabStop = True
        Me.RadioButton_Plane.Text = "Plane"
        Me.RadioButton_Plane.UseVisualStyleBackColor = True
        '
        'RadioButton_Semi
        '
        Me.RadioButton_Semi.AutoSize = True
        Me.RadioButton_Semi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton_Semi.ForeColor = System.Drawing.Color.White
        Me.RadioButton_Semi.Location = New System.Drawing.Point(701, 428)
        Me.RadioButton_Semi.Name = "RadioButton_Semi"
        Me.RadioButton_Semi.Size = New System.Drawing.Size(96, 17)
        Me.RadioButton_Semi.TabIndex = 25
        Me.RadioButton_Semi.TabStop = True
        Me.RadioButton_Semi.Text = "Add semi circle"
        Me.RadioButton_Semi.UseVisualStyleBackColor = True
        '
        'CheckBox_MultipleRay
        '
        Me.CheckBox_MultipleRay.AutoSize = True
        Me.CheckBox_MultipleRay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox_MultipleRay.ForeColor = System.Drawing.Color.White
        Me.CheckBox_MultipleRay.Location = New System.Drawing.Point(701, 451)
        Me.CheckBox_MultipleRay.Name = "CheckBox_MultipleRay"
        Me.CheckBox_MultipleRay.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox_MultipleRay.TabIndex = 26
        Me.CheckBox_MultipleRay.Text = "Multiple light ray"
        Me.CheckBox_MultipleRay.UseVisualStyleBackColor = True
        '
        'TextBox_SemiWidth
        '
        Me.TextBox_SemiWidth.Location = New System.Drawing.Point(748, 474)
        Me.TextBox_SemiWidth.Name = "TextBox_SemiWidth"
        Me.TextBox_SemiWidth.Size = New System.Drawing.Size(74, 20)
        Me.TextBox_SemiWidth.TabIndex = 27
        Me.TextBox_SemiWidth.Text = "200"
        Me.TextBox_SemiWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_SemiWidth
        '
        Me.Label_SemiWidth.AutoSize = True
        Me.Label_SemiWidth.ForeColor = System.Drawing.Color.White
        Me.Label_SemiWidth.Location = New System.Drawing.Point(702, 477)
        Me.Label_SemiWidth.Name = "Label_SemiWidth"
        Me.Label_SemiWidth.Size = New System.Drawing.Size(35, 13)
        Me.Label_SemiWidth.TabIndex = 28
        Me.Label_SemiWidth.Text = "Width"
        '
        'Label_SemiHeight
        '
        Me.Label_SemiHeight.AutoSize = True
        Me.Label_SemiHeight.ForeColor = System.Drawing.Color.White
        Me.Label_SemiHeight.Location = New System.Drawing.Point(702, 503)
        Me.Label_SemiHeight.Name = "Label_SemiHeight"
        Me.Label_SemiHeight.Size = New System.Drawing.Size(38, 13)
        Me.Label_SemiHeight.TabIndex = 29
        Me.Label_SemiHeight.Text = "Height"
        '
        'TextBox_semiHeight
        '
        Me.TextBox_semiHeight.Location = New System.Drawing.Point(748, 500)
        Me.TextBox_semiHeight.Name = "TextBox_semiHeight"
        Me.TextBox_semiHeight.Size = New System.Drawing.Size(74, 20)
        Me.TextBox_semiHeight.TabIndex = 30
        Me.TextBox_semiHeight.Text = "100"
        Me.TextBox_semiHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(845, 651)
        Me.Controls.Add(Me.TextBox_semiHeight)
        Me.Controls.Add(Me.Label_SemiHeight)
        Me.Controls.Add(Me.Label_SemiWidth)
        Me.Controls.Add(Me.TextBox_SemiWidth)
        Me.Controls.Add(Me.CheckBox_MultipleRay)
        Me.Controls.Add(Me.RadioButton_Semi)
        Me.Controls.Add(Me.RadioButton_Plane)
        Me.Controls.Add(Me.RadioButton_Prism)
        Me.Controls.Add(Me.RadioButton_Rectangle)
        Me.Controls.Add(Me.Button_Help)
        Me.Controls.Add(Me.Label_RefractedAngleText)
        Me.Controls.Add(Me.Label_RefractedAngle)
        Me.Controls.Add(Me.Label_CritAngleTxt)
        Me.Controls.Add(Me.Label_CriticalAngle)
        Me.Controls.Add(Me.Label_Material)
        Me.Controls.Add(Me.ListBox_Material)
        Me.Controls.Add(Me.Button_Questions)
        Me.Controls.Add(Me.Label_ColourOfLight)
        Me.Controls.Add(Me.ListBox_ColourOfLight)
        Me.Controls.Add(Me.Button_ShowCritAngle)
        Me.Controls.Add(Me.Button_ShowRefraction)
        Me.Controls.Add(Me.CheckBox_RefractiveIndexShow)
        Me.Controls.Add(Me.Label_IndexMediumTwo)
        Me.Controls.Add(Me.TextBox_RefractiveIndexMediumTwo)
        Me.Controls.Add(Me.Label_IndexMediumOne)
        Me.Controls.Add(Me.TextBox_RefractiveIndexMediumOne)
        Me.Controls.Add(Me.Label_IncidentAngle)
        Me.Controls.Add(Me.TextBox_IncidentAngle)
        Me.Controls.Add(Me.PictureBox_Refraction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Refraction"
        CType(Me.PictureBox_Refraction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox_Refraction As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox_IncidentAngle As System.Windows.Forms.TextBox
    Friend WithEvents Label_IncidentAngle As System.Windows.Forms.Label
    Friend WithEvents TextBox_RefractiveIndexMediumOne As System.Windows.Forms.TextBox
    Friend WithEvents Label_IndexMediumOne As System.Windows.Forms.Label
    Friend WithEvents TextBox_RefractiveIndexMediumTwo As System.Windows.Forms.TextBox
    Friend WithEvents Label_IndexMediumTwo As System.Windows.Forms.Label
    Friend WithEvents CheckBox_RefractiveIndexShow As System.Windows.Forms.CheckBox
    Friend WithEvents Button_ShowRefraction As System.Windows.Forms.Button
    Friend WithEvents Button_ShowCritAngle As System.Windows.Forms.Button
    Friend WithEvents ListBox_ColourOfLight As System.Windows.Forms.ListBox
    Friend WithEvents Label_ColourOfLight As System.Windows.Forms.Label
    Friend WithEvents Button_Questions As System.Windows.Forms.Button
    Friend WithEvents ListBox_Material As System.Windows.Forms.ListBox
    Friend WithEvents Label_Material As System.Windows.Forms.Label
    Friend WithEvents Label_CriticalAngle As System.Windows.Forms.Label
    Friend WithEvents Label_CritAngleTxt As System.Windows.Forms.Label
    Friend WithEvents Label_RefractedAngle As System.Windows.Forms.Label
    Friend WithEvents Label_RefractedAngleText As System.Windows.Forms.Label
    Friend WithEvents Button_Help As System.Windows.Forms.Button
    Friend WithEvents RadioButton_Rectangle As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Prism As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Plane As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Semi As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox_MultipleRay As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_SemiWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label_SemiWidth As System.Windows.Forms.Label
    Friend WithEvents Label_SemiHeight As System.Windows.Forms.Label
    Friend WithEvents TextBox_semiHeight As System.Windows.Forms.TextBox

End Class
