Imports System.Drawing.Drawing2D
Public Class Semicircle
    Inherits Shapes
    ''' <summary>
    ''' Constructor for semi circle
    ''' </summary>
    ''' <param name="Animationbox"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Animationbox As PictureBox)
        MyBase.New(Animationbox)
    End Sub
    ''' <summary>
    ''' Sets the properties
    ''' </summary>
    ''' <param name="Width">The width of the semi circle</param>
    ''' <param name="Height_">The hieght of the semi circle</param>
    ''' <remarks></remarks>
    Sub SetProperties(ByVal Width As Integer, ByVal Height_ As Integer)
        BoxWidth = Width / 2
        BoxHeight = Height_
    End Sub
    ''' <summary>
    ''' Draws the semi
    ''' </summary>
    ''' <remarks></remarks>
    Sub Draw()
        _animation.DrawArc(LineColour, Coordinate.X - BoxWidth, Coordinate.Y - BoxHeight, (BoxWidth * 2), BoxHeight * 2, 180, 180)
        _animation.DrawLine(LineColour, Coordinate.X - BoxWidth, Coordinate.Y, Coordinate.X + BoxWidth, Coordinate.Y)
    End Sub
End Class
