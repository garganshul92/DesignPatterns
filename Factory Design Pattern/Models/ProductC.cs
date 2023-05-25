using Interface;

namespace Models;

public class ProductC : IProduct
{
    public void GetProductInfo()
    {
        Console.WriteLine("Hey! I am Product C");
    }
}