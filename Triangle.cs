using Avalonia;
using Avalonia.Media;
using System;

namespace HW2;

public class Triangle : Shape
{
    public Triangle(int x, int y, string color, int radius)
        : base(x, y, color, radius){}
    
    public override void Draw(DrawingContext drawingContext)
    {
        Pen pen = new Pen(Brushes.Aqua, 2);
        Brush brush = new SolidColorBrush(Colors.Black);
        
        double side = Radius * Math.Sqrt(3);
        
        Point[] points = [new Point(X, Y + Radius),
            new Point((int)(X + side / 2), Y - Radius / 2),
            new Point((int)(X - side / 2), Y - Radius / 2),
            new Point(X, Y + Radius)];
        
        PolylineGeometry geom = new PolylineGeometry(points, true);
        
        drawingContext.DrawGeometry(brush, pen, geom);
        Console.WriteLine("Drawing Triangle");
    }
}