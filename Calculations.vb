Module Calculations
    ''' <summary>
    ''' Calculates the refractive index using cauchy's equation
    ''' </summary>
    ''' <param name="Material">The material through which the light is refracted through</param>
    ''' <param name="LightColour">The colour of light</param>
    ''' <returns>The refractive index of the medium</returns>
    ''' <remarks></remarks>
    Function CauchyEquation(ByVal Material As String, ByVal LightColour As String) As Decimal
        Dim RefractiveIndexMediumTwo As Decimal
        Dim Wavelength As Single = GetWavelength(LightColour)
        Dim ConsantB As Decimal = GetB(Material)
        Dim constantC As Decimal = GetC(Material)
        RefractiveIndexMediumTwo = ConsantB + (constantC / (Wavelength ^ 2))
        Return RefractiveIndexMediumTwo
    End Function
    ''' <summary>
    ''' Gets the constant B
    ''' </summary>
    ''' <param name="Material">The material</param>
    ''' <returns>The constant value for B</returns>
    ''' <remarks></remarks>
    Function GetB(ByVal Material As String) As Decimal
        Dim B As Decimal
        If Material = "Borosilicate glass" Then
            B = 1.5046
        ElseIf Material = "Hard crown glass" Then
            B = 1.522
        ElseIf Material = "Barium crown glass" Then
            B = 1.569
        ElseIf Material = "Barium flint glass" Then
            B = 1.67
        ElseIf Material = "Dense flint glass" Then
            B = 1.728
        Else
            B = 1.458
        End If
        Return B
    End Function
    ''' <summary>
    ''' Gets the value for the constant C
    ''' </summary>
    ''' <param name="Material">The user entered material</param>
    ''' <returns>The value for C</returns>
    ''' <remarks></remarks>
    Function GetC(ByVal Material As String) As Decimal
        Dim C As Decimal
        If Material = "Borosilicate glass" Then
            C = 0.0042
        ElseIf Material = "Hard crown glass" Then
            C = 0.00459
        ElseIf Material = "Barium crown glass" Then
            C = 0.00531
        ElseIf Material = "Barium flint glass" Then
            C = 0.00743
        ElseIf Material = "Dense flint glass" Then
            C = 0.01342
        Else
            C = 0.00354
        End If
        Return C
    End Function
    ''' <summary>
    ''' Gets the wavelenght of light
    ''' </summary>
    ''' <param name="ColourofLight">The colour of light</param>
    ''' <returns>The value of the wavelength</returns>
    ''' <remarks></remarks>
    Function GetWavelength(ByVal ColourofLight As String) As Single
        Dim Wavelength As Single
        If ColourofLight = "Yellow" Then
            Wavelength = 0.6
        ElseIf ColourofLight = "Orange" Then
            Wavelength = 0.63
        ElseIf ColourofLight = "Green" Then
            Wavelength = 0.55
        ElseIf ColourofLight = "Blue" Then
            Wavelength = 0.47
        ElseIf ColourofLight = "Violet" Then
            Wavelength = 0.4
        Else
            Wavelength = 0.66
        End If
        Return Wavelength
    End Function
    ''' <summary>
    ''' Calculates the angle of refraction
    ''' </summary>
    ''' <param name="IncidentAngle">The incident angle (IN RADIANS)</param>
    ''' <param name="RefractiveIndexMed1">The refractive index of the first medium</param>
    ''' <param name="refractiveIndexMed2">The refractive index of the second medium</param>
    ''' <returns>The refracted angle in radians</returns>
    ''' <remarks></remarks>
    Function CalcRefractedAngle(ByVal IncidentAngle As Decimal, ByVal RefractiveIndexMed1 As Decimal, ByVal refractiveIndexMed2 As Decimal) As Decimal
        Dim RefractedAngle As Decimal
        RefractedAngle = Math.Asin((RefractiveIndexMed1 * Math.Sin(IncidentAngle)) / refractiveIndexMed2)
        Return RefractedAngle
    End Function
    ''' <summary>
    ''' Calculates the critical angle
    ''' </summary>
    ''' <param name="IndexMedium1">Refractive index of the first medium</param>
    ''' <param name="indexMedium2">The refractive index of the second medium</param>
    ''' <returns>The critical angle in radians</returns>
    ''' <remarks></remarks>
    Function CalculateCriticalAngle(ByVal IndexMedium1 As Decimal, ByVal indexMedium2 As Decimal) As Decimal
        Dim CritAngle As Decimal
        If IndexMedium1 < indexMedium2 Then
            CritAngle = Math.Asin(IndexMedium1 / indexMedium2)
        Else
            CritAngle = Math.Asin(indexMedium2 / IndexMedium1)
        End If
        Return CritAngle
    End Function
    ''' <summary>
    ''' Calculates the adjacent side of a right angled triangle
    ''' </summary>
    ''' <param name="Angle">The angle</param>
    ''' <param name="OppositeSide">The length of the opposide side</param>
    ''' <returns>The length of the adjacent side</returns>
    ''' <remarks></remarks>
    Function CalculateAdjacent(ByVal Angle As Decimal, ByVal OppositeSide As Decimal) As Decimal
        Dim Adjacent As Decimal
        'Tan0 = o/a
        Adjacent = OppositeSide / (Math.Tan(Angle))
        Return Adjacent
    End Function
    ''' <summary>
    ''' Calculates the legth of the opposite side in a right angled triangle
    ''' </summary>
    ''' <param name="Angle">The angle in radians</param>
    ''' <param name="AdjacentSide">The length of the adjacent side</param>
    ''' <returns>The length of the opposite side</returns>
    ''' <remarks></remarks>
    Function CalculateOpposite(ByVal Angle As Decimal, ByVal AdjacentSide As Decimal) As Decimal
        Dim Opposite As Decimal
        Opposite = AdjacentSide * (Math.Tan(Angle))
        Return Opposite
    End Function
    ''' <summary>
    ''' Converts an angle to radians
    ''' </summary>
    ''' <param name="DegreeAngle">The angle in degrees</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ConvertToRadian(ByVal DegreeAngle As Decimal) As Decimal
        Dim RadAngle As Decimal = DegreeAngle * (Math.PI / 180)
        Return RadAngle
    End Function
    ''' <summary>
    ''' Converts a radian angle to degree
    ''' </summary>
    ''' <param name="RadianAngle">The radian angle</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ConvertToDegree(ByVal RadianAngle As Decimal) As Decimal
        Dim DegreeAngle As Decimal = RadianAngle * (180 / Math.PI)
        Return DegreeAngle
    End Function
    ''' <summary>
    ''' Uses the quadritic formula to find a result for x
    ''' </summary>
    ''' <param name="a">a</param>
    ''' <param name="b">b</param>
    ''' <param name="c">c</param>
    ''' <param name="AddRoot">To add the root pass true, else pass false to subtract</param>
    ''' <returns>The value for x</returns>
    ''' <remarks></remarks>
    Function QuadraticFormula(ByVal a As Decimal, ByVal b As Decimal, ByVal c As Decimal, ByVal AddRoot As Boolean) As Decimal
        Dim x As Decimal
        If AddRoot = True Then
            x = (-b + Math.Sqrt((b ^ 2) - (4 * a * c))) / (2 * a)
        ElseIf AddRoot = False Then
            x = (-b - Math.Sqrt((b ^ 2) - (4 * a * c))) / (2 * a)
        End If
        Return x
    End Function
    ''' <summary>
    ''' Randomly swaps the question numbers around
    ''' </summary>
    ''' <param name="QuestionOrder">The question number array</param>
    ''' <remarks></remarks>
    Sub newQorder(ByRef QuestionOrder() As Integer)
        Dim RandomNumber1, RandomNumber2 As Integer
        Dim TempQnum As Integer
        Randomize()
        For x = 0 To 9
            RandomNumber1 = (9 * Rnd())
            RandomNumber2 = (9 * Rnd())
            If RandomNumber1 = RandomNumber2 Then
                If RandomNumber1 = 0 Then
                    RandomNumber1 += 1
                    If RandomNumber1 = 9 Then
                        RandomNumber1 -= 1
                    End If
                End If
            End If
            TempQnum = QuestionOrder(RandomNumber1)
            QuestionOrder(RandomNumber1) = QuestionOrder(RandomNumber2)
            QuestionOrder(RandomNumber2) = TempQnum
        Next
    End Sub
    ''' <summary>
    ''' Sets the background color of a textbox to red if an error occurs. If there is no error sets the back colour to white
    ''' </summary>
    ''' <param name="Textbox_">The name of the textbox</param>
    ''' <param name="Error_">If there is an error. Ie TRUE for an error will change the background to red</param>
    ''' <remarks></remarks>
    Sub SetBackground(ByRef Textbox_ As TextBox, ByVal Error_ As Boolean)
        If Error_ = True Then
            Textbox_.BackColor = Color.Red
        Else
            Textbox_.BackColor = Color.White
        End If
    End Sub
End Module
