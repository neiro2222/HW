using System;
using Avalonia;
using Avalonia.Media;

namespace HW2;

public class Circle : Shape
{
    public Circle(int x, int y, string color, int radius)
        : base(x, y, color, radius){}
    
    public override void Draw(DrawingContext drawingContext)
    {
        Pen pen = new Pen(Brushes.Aqua, 2);
        Brush brush = new SolidColorBrush(Colors.Black);
        
        drawingContext.DrawEllipse(brush, pen, new Point(X, Y), Radius, Radius);
        Console.WriteLine("Drawing Circle");
    }
}