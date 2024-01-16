Imports System.Drawing.Drawing2D
Public Class RectangleClass
    Inherits Shapes
    Public CollisionWithLight As String = ""
    ''' <summary>
    ''' Constructor for rectangle
    ''' </summary>
    ''' <param name="Animationbox"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Animationbox As PictureBox)
        MyBase.New(Animationbox)
    End Sub
    Sub Draw()
        _animation.DrawRectangle(LineColour, Coordinate.X - 25, Coordinate.Y - BoxHeight, BoxWidth, BoxHeight)
    End Sub
End Class
