using Decorator_Design_Pattern.Interfaces;

namespace Decorator_Design_Pattern.Models;

public class RectangularShape : IShape
{
    public void Draw()
    {
        Console.WriteLine("Shape: Rectangular");
    }
}
