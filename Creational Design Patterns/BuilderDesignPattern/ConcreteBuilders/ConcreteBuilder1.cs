using BuilderDesignPattern.Interfaces;
using BuilderDesignPattern.Models;

namespace BuilderDesignPattern.ConcreteBuilders;

public class ConcreteBuilder1 : IBuilder
{ 
    Product _product = new();

    public ConcreteBuilder1()
    {
        this.Reset();
    }

    public void BuildPartA()
    {
        _product.Add("PartA1");
    }

    public void BuildPartB()
    {
        _product.Add("PartB1");
    }

    public void BuildPartC()
    {
        _product.Add("PartC1");
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
