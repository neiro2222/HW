using Avalonia.Controls;
using Avalonia.Media;
namespace HW2;

public class CustomControl: UserControl
{
    public override void Render(DrawingContext drawingContext)
    {


        Square square = new Square(300, 300, "", 50);
        square.Draw(drawingContext);
        Circle circle1 = new Circle(400, 300, "", 50);
        circle1.Draw(drawingContext);
        Triangle triangle1 = new Triangle(400, 300, "", 50);
        triangle1.Draw(drawingContext);
        Circle circle2 = new Circle(500, 300, "", 50);
        circle2.Draw(drawingContext);
        Square square2 = new Square(500, 300, "", 50);
        square2.Draw(drawingContext);
        Triangle triangle2 = new Triangle(500, 300, "", 50);
        triangle2.Draw(drawingContext);
    }
}