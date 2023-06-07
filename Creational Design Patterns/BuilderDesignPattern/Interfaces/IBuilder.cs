using BuilderDesignPattern.Models;

namespace BuilderDesignPattern.Interfaces;

public interface IBuilder
{
    public void BuildPartA();
    public void BuildPartB();
    public void BuildPartC();
    public Product GetProduct();
}
