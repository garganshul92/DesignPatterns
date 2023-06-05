using BuilderDesignPattern.Interfaces;
using BuilderDesignPattern.Models;

namespace BuilderDesignPattern.ConcreteBuilders;

public class ConcreteBuilder2 : IBuilder
{
    Product _product = new Product();

    public ConcreteBuilder2()
    {
        this.Reset();
    }

    public void BuildPartA()
    {
        _product.Add("PartA2");
    }

    public void BuildPartB()
    {
        _product.Add("PartB2");
    }

    public void BuildPartC()
    {
        _product.Add("PartC2");
    }

    private void Reset()
    {
        this._product = new Product();
    }

    public Product GetProduct()
    {
        Product product = this._product;

        this.Reset();

        return product;
    }
}
