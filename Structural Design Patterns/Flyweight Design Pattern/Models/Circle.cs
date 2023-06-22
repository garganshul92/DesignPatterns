using Flyweight_Design_Pattern.Interfaces;

namespace Flyweight_Design_Pattern.Models;

public class Circle : IShape
{
    private int _radius;

    public Circle()
    {
        _radius = 5;
    }

    public void Draw()
    {
        Console.WriteLine($"This is a Circle of Radius: {_radius}");
    }
}
