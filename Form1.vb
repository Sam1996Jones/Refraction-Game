Imports System.Drawing.Drawing2D
Public Class Form1
    Dim RadianAngle As Decimal
    Dim RefractiveIndexOne As Decimal
    Dim RefractiveIndexTwo As Decimal
    Dim RefractedAngle As Decimal
    Dim CriticalAngle As Decimal
    Dim TIR As Boolean = False
    Dim Validation As Boolean = True 'If set to false then the user will be able to change the inputs
    Dim ColourOfLight As Pen = Pens.Red 'Sets the default light colour to red 
    Dim LightRay As LightRay
    Dim Animation As Graphics
    Dim Rectangle As RectangleClass
    Dim Prism As PrismClass
    Dim SemiCircle As Semicircle
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'When the form loads buttons that will only be shown when other buttons are clicked will be hidden.
        Label_IndexMediumTwo.Hide()
        TextBox_RefractiveIndexMediumTwo.Hide()
        RadioButton_Plane.Checked = True
        CheckBox_MultipleRay.Hide()
        Label_SemiWidth.Hide()
        TextBox_SemiWidth.Hide()
        Label_SemiHeight.Hide()
        TextBox_semiHeight.Hide()
        AcceptButton = Button_ShowRefraction 'Allows the user to press enter to show refraction as well as clicking the button
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_RefractiveIndexShow.CheckedChanged
        HideAndShowForCheckBox()
    End Sub
    Private Sub Button_Questions_Click(sender As Object, e As EventArgs) Handles Button_Questions.Click
        QuestionWindow.Show() 'Opens the question window
    End Sub
    Private Sub ListBox_ColourOfLight_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_ColourOfLight.SelectedIndexChanged
        ColourOfLight = GetLightColour(ListBox_ColourOfLight.Text) ' Gets the colour of light as the user selects it in the listbox
    End Sub
    Private Sub Button_ShowRefraction_Click(sender As Object, e As EventArgs) Handles Button_ShowRefraction.Click
        Validation = True ' Sets validation to true for when the user alters their input
        CreateGraphicsForAnimation()
        SetRadianAngle()
        SetRefractiveIndex()
        SetCritAngle()
        SetTIR()
        SetRefractedAngle()
        If Validation = True Then 'If validation is true then one of the refractions will be simulated. If false then no refractions will be simulated and an error message will occur.
            If RadioButton_Rectangle.Checked = True Then 'Decides which refraction will be simulated.
                RefractionWithinRectangle()
            ElseIf RadioButton_Semi.Checked = True Then
                DrawRefractionWithinSemiCircle()
            ElseIf RadioButton_Prism.Checked = True Then
                If TextBox_IncidentAngle.Text < 20 Then 'if the user inputs data lower than 20 when the prism is selected an error message will occur (Used until math is fixed)
                    Validation = False
                Else
                    RefractionWithinPrism()
                End If
            ElseIf RadioButton_Plane.Checked = True Then
                DrawRefractionForPlane()
                LightRay.SetLine(Pens.SlateGray, 0, PictureBox_Refraction.Height / 2, PictureBox_Refraction.Width, PictureBox_Refraction.Height / 2) ' Uses the light ray class to draw a line to seperate the two mediums
                LightRay.Draw()
            End If
        End If
        If Validation = False Then
            FalseValdation()
        End If
        TextBox_IncidentAngle.Focus() 'This sends the cursor to the incident angle text box to allow them to change the text without moving the mouse to click there.
    End Sub

    Private Sub Button_ShowCritAngle_Click(sender As Object, e As EventArgs) Handles Button_ShowCritAngle.Click
        Validation = True
        SetPropertiesCritAngleButton()
        CreateGraphicsForAnimation()
        SetRefractiveIndex()
        SetCritAngle()
        If Validation = True Then 'if there are no errors then the critical angle will be simulated
            DrawCritAngle()
            TextBox_IncidentAngle.Text = Math.Round(ConvertToDegree(CriticalAngle), 2) ' This converts the angle back to degrees, as this is more familiar and sets the converted angle to 2 decimal places
        Else
            FalseValdation()
        End If
        RemoveRadioButton()
    End Sub
    ''' <summary>
    ''' Removes the value of the radio box and sets the value to the plane
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RemoveRadioButton()
        RadioButton_Plane.Checked = True 'Checks the radio button for the plane. This will remove the checked values for the other radio buttons
    End Sub

    ''' <summary>
    ''' Creates the graphics for animation and clears the current animation
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CreateGraphicsForAnimation()
        Animation = PictureBox_Refraction.CreateGraphics
        LightRay = New LightRay(PictureBox_Refraction)
        Rectangle = New RectangleClass(PictureBox_Refraction)
        Prism = New PrismClass(PictureBox_Refraction)
        SemiCircle = New Semicircle(PictureBox_Refraction)
        Animation.Clear(Color.FromArgb(24, 26, 10))  'Clears the previous refractions to draw the new one
    End Sub
    ''' <summary>
    ''' Hides and shows labels, and text boxes according to whether the tick box is selected
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub HideAndShowForCheckBox()
        If CheckBox_RefractiveIndexShow.Checked = True Then ' if the user wants to changed the refractive index of medium two then the textbox will be shown and the options that are not needed will be hidden.
            Label_IndexMediumTwo.Show()
            TextBox_RefractiveIndexMediumTwo.Show()
            Label_ColourOfLight.Hide()
            Label_Material.Hide()
            ListBox_ColourOfLight.Hide()
            ListBox_ColourOfLight.SelectedItem = "Red"     'Sets the colour of light to the default colour
            ListBox_Material.Hide()
            ListBox_Material.SelectedItem = "Fused silica"   'Sets the material to the default material
        Else
            Label_IndexMediumTwo.Hide()
            TextBox_RefractiveIndexMediumTwo.Hide()
            ListBox_ColourOfLight.Show()
            ListBox_Material.Show()
            Label_ColourOfLight.Show()
            Label_Material.Show()
        End If
    End Sub
    ''' <summary>
    ''' Draws the refraction of light throught a plane according to user inputs
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DrawRefractionForPlane()
        If Math.Round(RadianAngle, 2) = Math.Round(CriticalAngle, 2) Then 'If the user inputs the angle given for the critical angle, the crit angle will be drawn. otherwise draw the refraction dependant on if the angle is > the critical angle
            DrawCritAngle()
            Label_RefractedAngleText.Text = "90" 'sets the label of the refracted angle to 90 degrees
        Else
            DrawIncidentRay()
            If TIR = False Then 'if the critical angle is greater than the incident then the refracted ray will be drawn
                DrawRefractedRay()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Sets the refractive index of both mediums
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetRefractiveIndex()
        Try
            If TextBox_RefractiveIndexMediumOne.Text < 1 Or TextBox_RefractiveIndexMediumOne.Text >= 5 Then
                Validation = False
                SetBackground(TextBox_RefractiveIndexMediumOne, True)
            Else
                RefractiveIndexOne = TextBox_RefractiveIndexMediumOne.Text
            End If
        Catch ex As Exception
            Validation = False
            SetBackground(TextBox_RefractiveIndexMediumOne, True)
        End Try
        If CheckBox_RefractiveIndexShow.Checked = True Then
            Try 'If the user inputs a valid data type the indexs will be set to the default numbers.
                If TextBox_RefractiveIndexMediumTwo.Text < 1 Or TextBox_RefractiveIndexMediumTwo.Text >= 5 Then
                    Validation = False
                    SetBackground(TextBox_RefractiveIndexMediumTwo, True)
                End If
                RefractiveIndexTwo = TextBox_RefractiveIndexMediumTwo.Text
            Catch ex As Exception
                Validation = False
                SetBackground(TextBox_RefractiveIndexMediumTwo, True)
            End Try
        Else
            RefractiveIndexTwo = CauchyEquation(ListBox_Material.Text, ListBox_ColourOfLight.Text) 'Get the refractive index of medium two from cauchys equation
        End If
        If Validation = True Then
            SetBackground(TextBox_RefractiveIndexMediumOne, False)
            SetBackground(TextBox_RefractiveIndexMediumTwo, False)
        End If
    End Sub
    ''' <summary>
    ''' Sets the critical angle
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetCritAngle()
        Try
            CriticalAngle = CalculateCriticalAngle(RefractiveIndexOne, RefractiveIndexTwo)
        Catch ex As Exception
            Validation = False
        End Try
        If Validation = True Then
            Label_CritAngleTxt.Text = (Math.Round((ConvertToDegree(CriticalAngle)), 2)) 'Sets the crit angle to degree, rounds it to 2dp, then shows it to the user via a label
        End If
    End Sub
    ''' <summary>
    ''' Sets the refracted angle
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetRefractedAngle()
        Try
            RefractedAngle = CalcRefractedAngle(RadianAngle, RefractiveIndexOne, RefractiveIndexTwo)
        Catch ex As Exception
            Validation = False
        End Try
        If Validation = True Then
            SetRefractedAngleLabel()
        End If
    End Sub
    ''' <summary>
    ''' Sets the radian angle from the user's degree input.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetRadianAngle()
        Try
            If TextBox_IncidentAngle.Text < 1 Or TextBox_IncidentAngle.Text > 89 Then
                Validation = False
                SetBackground(TextBox_IncidentAngle, True)'If the user inputs an invalid data type then the background colour of the textbox will turn red to show them what they need to change
            End If
        Catch ex As Exception
            Validation = False
            SetBackground(TextBox_IncidentAngle, True)
        End Try
        If Validation = True Then 'if the validation is true then convert the angle
            RadianAngle = ConvertToRadian(TextBox_IncidentAngle.Text) 'sets the variable to the radian equivalent of the angle inputted in degrees
            TextBox_IncidentAngle.BackColor = Color.White
        End If
    End Sub
    ''' <summary>
    ''' Draws the incident light ray
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DrawIncidentRay()
        Dim HorizontalComponent As Decimal 'To use the angle to find the start x position
        HorizontalComponent = CalculateOpposite(RadianAngle, PictureBox_Refraction.Height / 2)
        LightRay.SetLine(ColourOfLight, (PictureBox_Refraction.Width / 2) - HorizontalComponent, PictureBox_Refraction.Height, PictureBox_Refraction.Width / 2, PictureBox_Refraction.Height / 2)
        LightRay.Draw()
        If TIR = True Then
            LightRay.SetLine(ColourOfLight, (PictureBox_Refraction.Width / 2), (PictureBox_Refraction.Height / 2), (PictureBox_Refraction.Width / 2) + HorizontalComponent, PictureBox_Refraction.Height)
            LightRay.Draw()
        End If
    End Sub

    ''' <summary>
    ''' Gets the colour of light from a user input and changes the colour of the line
    ''' </summary>
    ''' <param name="LightColour">User input for colour of light</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetLightColour(ByVal LightColour As String) As Pen
        Dim Colour As Pen
        If LightColour = "Violet" Then
            Colour = Pens.DarkViolet
        ElseIf LightColour = "Blue" Then
            Colour = Pens.LightBlue
        ElseIf LightColour = "Green" Then
            Colour = Pens.Green
        ElseIf LightColour = "Yellow" Then
            Colour = Pens.Yellow
        ElseIf LightColour = "Orange" Then
            Colour = Pens.DarkOrange
        ElseIf LightColour = "White" Then
            Colour = Pens.White
        Else
            Colour = Pens.Red
        End If
        Return Colour
    End Function
    ''' <summary>
    ''' Draws the refracted light ray
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DrawRefractedRay()
        Dim RefractedAngle As Decimal = CalcRefractedAngle(RadianAngle, RefractiveIndexOne, RefractiveIndexTwo)
        Dim HorizontalComponent As Decimal = CalculateOpposite(RefractedAngle, PictureBox_Refraction.Height / 2)
        LightRay.SetLine(ColourOfLight, (PictureBox_Refraction.Width / 2), (PictureBox_Refraction.Height / 2), (PictureBox_Refraction.Width / 2) + HorizontalComponent, 0)
        LightRay.Draw()
    End Sub
    ''' <summary>
    ''' Draws the critical angle 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DrawCritAngle()
        Dim Horizontal As Decimal = CalculateOpposite(CriticalAngle, PictureBox_Refraction.Height / 2)
        LightRay.SetLine(ColourOfLight, (PictureBox_Refraction.Width / 2) - Horizontal, PictureBox_Refraction.Height, PictureBox_Refraction.Width / 2, PictureBox_Refraction.Height / 2)
        LightRay.Draw()
        LightRay.SetLine(ColourOfLight, PictureBox_Refraction.Width / 2, PictureBox_Refraction.Height / 2, PictureBox_Refraction.Width, PictureBox_Refraction.Height / 2)
        LightRay.Draw()
    End Sub
    ''' <summary>
    ''' Sets the text within the labels for the angles
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetRefractedAngleLabel()
        If TIR = False Then
            Label_RefractedAngleText.Text = Math.Round(ConvertToDegree(RefractedAngle), 2)
        Else
            Label_RefractedAngleText.Text = TextBox_IncidentAngle.Text 'If the light is reflected then the label will be shown as the incident angle
        End If
    End Sub
    ''' <summary>
    ''' Sets the state of the TIR variable
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetTIR()
        If RadianAngle >= CriticalAngle Then  'If user input is greater than the critical angle then TIR will occur
            TIR = True
        Else
            TIR = False
        End If
    End Sub
    ''' <summary>
    ''' Sets the properties of check boxes and labels when the critical angle button is pressed
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetPropertiesCritAngleButton()
        If Validation = True Then
            Label_RefractedAngleText.Text = "90" 'When the critical angle button is clicked the refracted angle label is set to 90 degrees
        End If
    End Sub
    ''' <summary>
    ''' Sets the labels and shows an error message if validation is false
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub FalseValdation()
        If Validation = False Then
            MsgBox("Please enter valid numbers")
            Label_CritAngleTxt.Text = ""
            Label_RefractedAngleText.Text = ""
        End If
    End Sub
    ''' <summary>
    ''' Simulates the refraction within a rectangle
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RefractionWithinRectangle()
        Rectangle.GetCoordinates(PictureBox_Refraction.Width, PictureBox_Refraction.Height)
        Rectangle.Draw()
        DrawIncidentRay()
        If TIR = False Then
            DrawRefractionWithinRectangle()
        End If
        Label_RefractedAngleText.Text = "" 'Sets the refracted angle text to an empty string as there are multiple refractions
    End Sub
    ''' <summary>
    ''' Draws the refraction within the rectangle
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DrawRefractionWithinRectangle()
        Dim StartCoords As Point
        Dim EndCoords As Point
        Dim HorizontalComp As Decimal
        Dim VerticalComp As Decimal
        Dim collision As String = "" 'uses the collision to decide which way the light leaves the box
        Dim ReflectionAngle As Decimal = (Math.PI / 2) - RefractedAngle
        StartCoords.Y = PictureBox_Refraction.Height / 2
        StartCoords.X = PictureBox_Refraction.Width / 2

        HorizontalComp = 25
        VerticalComp = CalculateOpposite(ReflectionAngle, HorizontalComp)
        EndCoords.Y = StartCoords.Y - VerticalComp
        If EndCoords.Y > StartCoords.Y - 150 Then
            EndCoords.X = StartCoords.X + 25
            Rectangle.CollisionWithLight = "Right"
        Else
            VerticalComp = 150
            HorizontalComp = CalculateAdjacent(ReflectionAngle, VerticalComp)
            EndCoords.X = StartCoords.X + HorizontalComp
            EndCoords.Y = StartCoords.Y - 150
            Rectangle.CollisionWithLight = "Top"
            collision = "Left"
        End If
        LightRay.SetLine(ColourOfLight, StartCoords.X, StartCoords.Y, EndCoords.X, EndCoords.Y)
        LightRay.Draw()

        StartCoords.X = EndCoords.X
        StartCoords.Y = EndCoords.Y
        If (Math.PI / 2) - RefractedAngle < CriticalAngle Then  'If the refracted angle is less then the critical then the light will not reflect 
            HorizontalComp = (PictureBox_Refraction.Width / 2) + 25
            VerticalComp = CalculateOpposite(RadianAngle, HorizontalComp)
            EndCoords.X = PictureBox_Refraction.Width
            EndCoords.Y = StartCoords.Y - VerticalComp
            LightRay.SetLine(ColourOfLight, StartCoords.X, StartCoords.Y, EndCoords.X, EndCoords.Y)
            LightRay.Draw()
        Else
            Do Until Rectangle.CollisionWithLight = "Top"
                If Rectangle.CollisionWithLight = "Right" Then
                    HorizontalComp = 50
                    VerticalComp = CalculateOpposite(ReflectionAngle, HorizontalComp)
                    EndCoords.Y = StartCoords.Y - VerticalComp
                    If EndCoords.Y > PictureBox_Refraction.Height / 2 - 150 Then
                        EndCoords.X = StartCoords.X - 50
                        Rectangle.CollisionWithLight = "Left"
                    Else
                        VerticalComp = 150 - (PictureBox_Refraction.Height / 2 - StartCoords.Y)
                        HorizontalComp = CalculateAdjacent(ReflectionAngle, VerticalComp)
                        EndCoords.X = StartCoords.X - HorizontalComp
                        EndCoords.Y = StartCoords.Y - VerticalComp 'Top of box
                        Rectangle.CollisionWithLight = "Top"
                        collision = "Right"
                    End If
                    LightRay.SetLine(ColourOfLight, StartCoords.X, StartCoords.Y, EndCoords.X, EndCoords.Y)
                    LightRay.Draw()
                    StartCoords.X = EndCoords.X
                    StartCoords.Y = EndCoords.Y
                End If
                If Rectangle.CollisionWithLight = "Left" Then
                    HorizontalComp = 50
                    VerticalComp = CalculateOpposite(ReflectionAngle, HorizontalComp)
                    EndCoords.Y = StartCoords.Y - VerticalComp
                    If EndCoords.Y > PictureBox_Refraction.Height / 2 - 150 Then
                        EndCoords.X = StartCoords.X + 50
                        Rectangle.CollisionWithLight = "Right"
                    Else
                        VerticalComp = 150 - (PictureBox_Refraction.Height / 2 - StartCoords.Y)
                        HorizontalComp = CalculateAdjacent(ReflectionAngle, VerticalComp)
                        EndCoords.X = StartCoords.X + HorizontalComp
                        EndCoords.Y = StartCoords.Y - VerticalComp
                        Rectangle.CollisionWithLight = "Top"
                        collision = "Left"
                    End If
                    LightRay.SetLine(ColourOfLight, StartCoords.X, StartCoords.Y, EndCoords.X, EndCoords.Y)
                    LightRay.Draw()
                    StartCoords.X = EndCoords.X
                    StartCoords.Y = EndCoords.Y
                End If
            Loop
            HorizontalComp = CalculateAdjacent((Math.PI / 2) - RadianAngle, (PictureBox_Refraction.Height / 2) - 150)
            If collision = "Right" Then
                LightRay.SetLine(ColourOfLight, StartCoords.X, StartCoords.Y, StartCoords.X - HorizontalComp, 0)
            ElseIf collision = "Left" Then
                LightRay.SetLine(ColourOfLight, StartCoords.X, StartCoords.Y, StartCoords.X + HorizontalComp, 0)
            End If
            LightRay.Draw()
        End If
    End Sub
    ''' <summary>
    ''' Draws the refraction within the prism
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RefractionWithinPrism()
        Prism.GetCoordinates(PictureBox_Refraction.Width, PictureBox_Refraction.Height)
        Prism.Draw()
        IncidentForPrism()
        If TIR = False Then
            DrawRefractionWithinPrism()
        End If
        Label_RefractedAngleText.Text = ""
    End Sub
    ''' <summary>
    ''' Draws the incident light ray for the prism
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub IncidentForPrism()
        Dim LinePoints(1) As Point ' 0-start point 1-end point
        Dim HorizontalComponent As Decimal = (((200 * (Math.Sin(ConvertToRadian(60)))) / (Math.Sin((ConvertToRadian(120)) - RadianAngle))) * (Math.Sin(RadianAngle))) 'The horizontal component for drawing the angle from a fixed x point
        If ListBox_ColourOfLight.Text = "White" Then
            ColourOfLight = Pens.White
        End If
        LinePoints(0).Y = (PictureBox_Refraction.Height / 2) - (Prism.ReturnBoxheight / 2)
        LinePoints(0).X = PictureBox_Refraction.Width / 2 - 150
        LinePoints(1).X = (PictureBox_Refraction.Width / 2) - 300 ' Sets the x coordinate
        LinePoints(1).Y = ((PictureBox_Refraction.Height / 2) - (Prism.ReturnBoxheight)) + HorizontalComponent 'Sets a temp Y coordinate

        LinePoints(1).Y = LinePoints(1).Y + 6 'Sets the line slightly lower down the prism
        LinePoints(0).X = LinePoints(0).X - 3
        LinePoints(0).Y = LinePoints(0).Y + 6

        LightRay.SetLine(ColourOfLight, LinePoints(0).X, LinePoints(0).Y, LinePoints(1).X, LinePoints(1).Y)
        LightRay.Draw()
    End Sub
    ''' <summary>
    ''' Draws the refraction in the prism
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DrawRefractionWithinPrism()
        Dim Gradient1, Gradient2, Constant1, Constant2 As Decimal
        Dim StartX, StartY, EndX, EndY, TempX, TempY, StartXRefract, EndXRefract, StartYRefract, EndYRefract As Decimal 'Temp coords used to find the gradient and equation of the line. Y will be a fixed value whereby x will change according to user input
        Dim OutOfTriangleRefractionAngle As Decimal = CalcRefractedAngle((ConvertToRadian(30)) - RefractedAngle, RefractiveIndexTwo, RefractiveIndexOne)
        Dim Gradient(1) As Integer ' adds values to the start positions
        Dim T As Integer = 1 'used to loop throught the dispersion procedure
        Dim LoopBool As Boolean = False
        Dim TempStartX, TempStartY
        StartX = (PictureBox_Refraction.Width / 2 - 150)
        StartY = (PictureBox_Refraction.Height / 2 - (Prism.ReturnBoxheight) / 2)
        TempStartX = StartX - 3
        TempStartY = StartY + 6
        If ListBox_ColourOfLight.Text = "White" Then
            ColourOfLight = Pens.Red
            LoopBool = True
        End If
        Do
            If T = 7 Then
                LoopBool = False
            End If
            TempY = PictureBox_Refraction.Height
            StartX -= Gradient(1)
            StartY += Gradient(0)
            Gradient1 = ((PictureBox_Refraction.Height / 2) - (PictureBox_Refraction.Height / 2 - (Prism.ReturnBoxheight))) / ((PictureBox_Refraction.Width / 2) - (PictureBox_Refraction.Width / 2 - 100))
            Constant1 = (Gradient1 * -(PictureBox_Refraction.Width / 2)) + (PictureBox_Refraction.Height / 2)
            TempX = StartX + (Math.Tan(ConvertToRadian(60) + RefractedAngle)) * ((PictureBox_Refraction.Height) - StartY)
            Gradient2 = (TempY - StartY) / (TempX - StartX)
            Constant2 = (Gradient2 * -(TempX)) + (TempY)
            EndX = ((Constant2 - Constant1) / (Gradient1 - Gradient2))
            EndY = (Gradient2 * EndX) + Constant2
            LightRay.SetLine(ColourOfLight, TempStartX, TempStartY, EndX, EndY)
            LightRay.Draw()

            StartXRefract = EndX
            StartYRefract = EndY
            EndYRefract = ((PictureBox_Refraction.Height / 2) - Prism.ReturnBoxheight) + Gradient(0)
            TempX = (PictureBox_Refraction.Width / 2 - 100) + (100 / (Math.Sin(ConvertToRadian(30))))
            EndXRefract = (TempX + ((100 / Math.Cos(ConvertToRadian(30))) / Math.Sin(ConvertToRadian(30) - OutOfTriangleRefractionAngle))) + Gradient(1)
            LightRay.SetLine(ColourOfLight, StartXRefract, StartYRefract, EndXRefract, EndYRefract)
            LightRay.Draw()
            If ListBox_ColourOfLight.Text = "White" Then
                Dispersion(T)
                Gradient(0) = 2
                Gradient(1) = 1
                T = T + 1
            End If
        Loop While LoopBool = True
    End Sub

    Private Sub Dispersion(ByRef counter As Integer)
        Dim LightColour As String = "Red"
        If counter = 1 Then
            LightColour = "Red"
        ElseIf counter = 2 Then
            LightColour = "Orange"
        ElseIf counter = 3 Then
            LightColour = "Yellow"
        ElseIf counter = 4 Then
            LightColour = "Green"
        ElseIf counter = 5 Then
            LightColour = "Blue"
        ElseIf counter = 6 Then
            LightColour = "Violet"
        End If
        ColourOfLight = GetLightColour(LightColour)
        RefractiveIndexTwo = CauchyEquation(ListBox_Material.Text, LightColour)
        RefractedAngle = CalcRefractedAngle(RadianAngle, RefractiveIndexOne, RefractiveIndexTwo)
    End Sub

    Private Sub RadioButton_Prism_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Prism.CheckedChanged
        If RadioButton_Prism.Checked = True Then  'if the prism box is ticked then add the option to select white light, else remove the option to select white light
            ListBox_ColourOfLight.Items.Add("White")
        Else
            ListBox_ColourOfLight.Items.Remove("White")
        End If
    End Sub
    ''' <summary>
    ''' Sets and draws properties for semi
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DrawSemiCircle()
        Try
        If TextBox_semiHeight.Text < 0 Then
                Validation = False
                SetBackground(TextBox_semiHeight, True)
        End If
        If TextBox_SemiWidth.Text < 0 Then
                SetBackground(TextBox_SemiWidth, True)
            End If
            If TextBox_semiHeight.Text > PictureBox_Refraction.Height / 2 Then
                TextBox_semiHeight.Text = "100"
                MsgBox("The height is too big for the screen")
            End If
            If TextBox_SemiWidth.Text > PictureBox_Refraction.Width Then
                TextBox_SemiWidth.Text = "200"
                MsgBox("The width is too big for the screen")
            End If
        SemiCircle.GetCoordinates(PictureBox_Refraction.Width, PictureBox_Refraction.Height)
        If CheckBox_MultipleRay.Checked = True Then
            SemiCircle.SetProperties(TextBox_SemiWidth.Text, TextBox_semiHeight.Text)
        Else
            SemiCircle.SetProperties(TextBox_SemiWidth.Text, TextBox_SemiWidth.Text / 2)
            End If
            SemiCircle.Draw()
        Catch ex As Exception
            Validation = False
            SetBackground(TextBox_SemiWidth, True)
            SetBackground(TextBox_semiHeight, True)
        End Try
        If Validation = True Then
            SetBackground(TextBox_SemiWidth, False)
            SetBackground(TextBox_semiHeight, False)
        End If
    End Sub
    ''' <summary>
    ''' Draws the refraction in a semi circle
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DrawRefractionWithinSemiCircle()
        DrawSemiCircle()
        If Validation = True Then
            If CheckBox_MultipleRay.Checked = False Then
                DrawIncidentRay()
                If TIR = False Then
                    DrawRefractionForPlane() 'The refraction in a semi is the same for a plane
                End If
            ElseIf CheckBox_MultipleRay.Checked = True Then
                DrawTripleRefraction()
            End If
            Label_RefractedAngleText.Text = ""
        End If
    End Sub
    ''' <summary>
    ''' Draws three refractions within the semi circle
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub DrawTripleRefraction()
        LightRay.SetLine(ColourOfLight, PictureBox_Refraction.Width / 2, PictureBox_Refraction.Height, PictureBox_Refraction.Width / 2, 0) 'This ray is not refracted to it passes straight through
        LightRay.Draw() 'Draws the centre line
        Dim Radius As Integer = TextBox_SemiWidth.Text / 2
        Dim Height As Integer = TextBox_semiHeight.Text
        Dim XCoord As Decimal = PictureBox_Refraction.Width / 2 - (Radius / 2) 'Sets the value of first X coordinate
        Dim YCoord As Decimal ' The intersection coordinate
        Dim a As Integer = PictureBox_Refraction.Width / 2
        Dim b As Integer = PictureBox_Refraction.Height / 2
        Dim CircleConstant As Decimal = Radius ^ 2 - b ^ 2 - a ^ 2
        Dim EquatedConstant As Decimal
        Dim IncidentAngle_ As Decimal
        Dim RefractedAngle As Decimal
        Dim HorizontalComponent As Decimal
        Try
            For P = 1 To 2
                EquatedConstant = -((b ^ 2) + ((((XCoord ^ 2) + (-2 * a * XCoord) + (a ^ 2)) / (Radius ^ 2)) * (Height ^ 2)) - (Height ^ 2))
                YCoord = QuadraticFormula(1, (-2 * b), -EquatedConstant, True)
                If YCoord > PictureBox_Refraction.Height / 2 Then
                    YCoord = QuadraticFormula(1, -2 * b, -EquatedConstant, False)
                End If
                LightRay.SetLine(ColourOfLight, XCoord, PictureBox_Refraction.Height, XCoord, YCoord)
                LightRay.Draw()
                IncidentAngle_ = Math.Asin((PictureBox_Refraction.Width / 2 - XCoord) / (Radius))
                RefractedAngle = CalcRefractedAngle(IncidentAngle_, RefractiveIndexTwo, RefractiveIndexOne)
                HorizontalComponent = CalculateAdjacent((Math.PI / 2) - RefractedAngle, YCoord)
                LightRay.SetLine(ColourOfLight, XCoord, YCoord, XCoord + HorizontalComponent, 0)
                LightRay.Draw()
                XCoord = XCoord + Radius
            Next
        Catch ex As Exception 'if the calculations fail from user input then the screen is cleared and an error message appears
            Validation = False
            Animation.Clear(Color.FromArgb(24, 26, 10))
        End Try
    End Sub
    
    Private Sub RadioButton_Semi_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Semi.CheckedChanged
        If RadioButton_Semi.Checked = False Then
            CheckBox_MultipleRay.Checked = False
            CheckBox_MultipleRay.Hide()
            Label_SemiWidth.Hide()
            TextBox_SemiWidth.Hide()
        ElseIf RadioButton_Semi.Checked = True Then
            CheckBox_MultipleRay.Show()
            TextBox_SemiWidth.Show()
            Label_SemiWidth.Show()
        End If
    End Sub

    Private Sub CheckBox_MultipleRay_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_MultipleRay.CheckedChanged
        If CheckBox_MultipleRay.Checked = True Then
            Label_IncidentAngle.Hide()
            TextBox_IncidentAngle.Hide()
            Label_SemiHeight.Show()
            TextBox_semiHeight.Show()
        Else
            Label_IncidentAngle.Show()
            TextBox_IncidentAngle.Show()
            Label_SemiHeight.Hide()
            TextBox_semiHeight.Hide()
        End If
    End Sub

    Private Sub Button_Help_Click(sender As Object, e As EventArgs) Handles Button_Help.Click
        MsgBox("Select an incident angle, colour of light, material/change the refractive index, and select a shape to refract through. Press the refract button to simulate the refraction. Press the critical angle button to show the critical angle. Press the questions button to open up a new window where you can answer multiple choice questions")
    End Sub

    Private Sub Label_IncidentAngle_Click(sender As Object, e As EventArgs) Handles Label_IncidentAngle.Click

    End Sub
End Class
