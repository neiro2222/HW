using Avalonia.Media;

namespace HW2;

public abstract class Shape
{
    protected static int Radius{get;set;}

    protected static int X{get;set;}
    protected static int Y{get;set;}
    
    protected static string Color{get;set;}
    
    static Shape()
    {   
        Radius = 0;
        Color = "black";
        X = 0;
        Y = 0;
    }

    public Shape(int x, int y, string color, int radius)
    {
        X = x;
        Y = y;
        Radius = radius;
        Color = color;
    }
    
    public abstract void Draw(DrawingContext drawingContext);
    
    
    
}