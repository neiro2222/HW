using System;
using Avalonia;
using Avalonia.Media;

namespace HW2;

public class Square : Shape
{
    public Square(int x, int y, string color, int radius)
        : base(x, y, color, radius){}

    public override void Draw(DrawingContext drawingContext)
    {
        Pen pen = new Pen(Brushes.Aqua, 2);
        Brush brush = new SolidColorBrush(Colors.Black);
        
        double side = Radius * Math.Sqrt(2);
        
        drawingContext.DrawRectangle(brush, pen, new Rect(X - side / 2, Y - side / 2, side, side));
        Console.WriteLine("Drawing Square");
    }

}