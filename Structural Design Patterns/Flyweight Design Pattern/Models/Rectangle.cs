
using Flyweight_Design_Pattern.Interfaces;

namespace Flyweight_Design_Pattern.Models;

public class Rectangle : IShape
{
    private int _length;
    private int _breadth;
    public Rectangle()
    {
        _length = 10;
        _breadth = 20;
    }
    public void Draw()
    {
        Console.WriteLine($"This is a rectangle of sides: Length={_length}, Breadth={_breadth}");
    }
}
