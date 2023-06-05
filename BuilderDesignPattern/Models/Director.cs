using BuilderDesignPattern.Interfaces;

namespace BuilderDesignPattern.Models;

public class Director
{
    private IBuilder _builder;

    public Director(IBuilder builder)
    {
        _builder = builder;
    }

    public Product GetMVPProduct()
    {
        _builder.BuildPartA();
        return _builder.GetProduct();
    }

    public Product GetFullProduct()
    {
        _builder.BuildPartA();
        _builder.BuildPartB();
        _builder.BuildPartC();
        return _builder.GetProduct();
    }
}
