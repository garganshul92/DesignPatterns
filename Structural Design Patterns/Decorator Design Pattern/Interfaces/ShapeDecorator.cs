namespace Decorator_Design_Pattern.Interfaces;

public abstract class ShapeDecorator : IShape
{
    private IShape _shape;

    public ShapeDecorator(IShape shape)
    {
        _shape = shape;
    }

    public virtual void Draw()
    {
        _shape.Draw();
    }
}
