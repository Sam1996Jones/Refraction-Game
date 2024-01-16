Imports System.Drawing.Drawing2D
Public Class PrismClass
    Inherits Shapes
    ''' <summary>
    ''' Constructor for prism
    ''' </summary>
    ''' <param name="animationbox"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal animationbox As PictureBox)
        MyBase.New(animationbox)
        BoxHeight = 200 * Math.Sin(60 * (Math.PI / 180))  'Sets the boxheight so that the all the sides will be 10
        BoxWidth = 200
    End Sub
    Public Sub Draw()
        Dim TriPoints(2) As Point
        TriPoints(0).X = Coordinate.X - 200
        TriPoints(0).Y = Coordinate.Y
        TriPoints(1).X = Coordinate.X - 100
        TriPoints(1).Y = Coordinate.Y - BoxHeight
        TriPoints(2).X = Coordinate.X
        TriPoints(2).Y = Coordinate.Y
        _animation.DrawPolygon(LineColour, TriPoints)
    End Sub
    ''' <summary>
    ''' Returns the height
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ReturnBoxheight() As Integer
        Return BoxHeight
    End Function
End Class
