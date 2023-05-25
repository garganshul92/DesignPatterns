using Interface;

namespace Models;

public class ProductA : IProduct
{
    public void GetProductInfo()
    {
        Console.WriteLine("Hey! I am Product A");
    }
}