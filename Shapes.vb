Imports System.Drawing.Drawing2D
Public Class Shapes
    Protected Coordinate As Point
    Protected LineColour As Pen = Pens.SlateGray
    Protected _animation As Graphics
    Protected BoxWidth As Integer = 50
    Protected BoxHeight As Integer = 150
    Public Sub New(ByVal animationBox As PictureBox)
        _animation = animationBox.CreateGraphics
        _animation.SmoothingMode = SmoothingMode.HighQuality
    End Sub
    ''' <summary>
    ''' Sets the coordinate of the shapes
    ''' </summary>
    ''' <param name="PictureBoxWidth">The width of the picture box </param>
    ''' <param name="PictureBoxHeight">The height of the picture box</param>
    ''' <remarks></remarks>
    Public Sub GetCoordinates(ByVal PictureBoxWidth As Decimal, ByVal PictureBoxHeight As Decimal)
        Coordinate.X = PictureBoxWidth / 2
        Coordinate.Y = PictureBoxHeight / 2
    End Sub
End Class
