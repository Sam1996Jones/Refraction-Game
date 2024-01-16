Imports System.Drawing.Drawing2D
Public Class LightRay
    Protected StartPoint, EndPoint As Point
    Protected LightColour As Pen
    Protected _animation As Graphics
    Public Sub New(ByVal animationbox As PictureBox)
        _animation = animationbox.CreateGraphics
        _animation.SmoothingMode = SmoothingMode.HighQuality
    End Sub
    ''' <summary>
    ''' Sets the properties of the line to be drawn
    ''' </summary>
    ''' <param name="_colour">The colour of light</param>
    ''' <param name="StartX">The x coordinate for the start of the line</param>
    ''' <param name="StartY">The y coordinate for the start of the line</param>
    ''' <param name="EndX">The x coordinate for the end of the line</param>
    ''' <param name="EndY">The y coordinate for the end of the line</param>
    ''' <remarks></remarks>
    Public Sub SetLine(ByVal _colour As Pen, ByVal StartX As Decimal, ByVal StartY As Decimal, ByVal EndX As Decimal, ByVal EndY As Decimal)
        LightColour = _colour
        StartPoint.X = StartX
        StartPoint.Y = StartY
        EndPoint.X = EndX
        EndPoint.Y = EndY
    End Sub
    ''' <summary>
    ''' Draws the ray of light
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Draw()
        _animation.DrawLine(LightColour, StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y)
    End Sub
End Class
