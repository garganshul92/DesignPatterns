using Interface;

namespace Models;

public class ProductB : IProduct
{
    public void GetProductInfo()
    {
        Console.WriteLine("Hey! I am Product B");
    }
}