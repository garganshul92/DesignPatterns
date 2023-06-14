using Decorator_Design_Pattern.Interfaces;

namespace Decorator_Design_Pattern.Models;

public class CircularShape : IShape
{
    public void Draw()
    {
        Console.WriteLine("Shape: Circular");
    }
}
