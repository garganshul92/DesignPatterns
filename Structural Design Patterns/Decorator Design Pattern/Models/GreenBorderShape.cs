using Decorator_Design_Pattern.Interfaces;

namespace Decorator_Design_Pattern.Models;

public class GreenBorderShape : ShapeDecorator
{
    public GreenBorderShape(IShape shape) : base(shape)
    {
    }

    public override void Draw()
    {
        base.Draw();
        SetBorderColor();
    }

    private void SetBorderColor()
    {
        Console.WriteLine("Added BlackColor Border to the shape.");
    }
}
