using Flyweight_Design_Pattern.Interfaces;

namespace Flyweight_Design_Pattern.Models;

public class ShapeFactory
{
    private Dictionary<string, IShape> _shapeCache = new Dictionary<string, IShape>();

    public IShape GetShape(string type)
    {
        IShape shape = null;

        if (_shapeCache.ContainsKey(type)){
            shape = _shapeCache[type];
        }
        else
        {
            switch (type)
            {
                case "rectangle":
                    {
                        shape = new Rectangle();
                        break;
                    }
                case "circle":
                    {
                        shape = new Circle();
                        break;
                    }
            }

            _shapeCache.Add(type, shape);
        }

        return shape;
    }

    public void GetNumberOfObjects()
    {
        Console.WriteLine($"Number of objects created: {_shapeCache.Count}");
    }

}
