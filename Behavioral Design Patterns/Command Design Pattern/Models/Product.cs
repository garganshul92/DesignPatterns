namespace Command_Design_Pattern.Models;

public class Product
{
    public string Name { get; set; }

    public int Price { get; set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public void IncreasePrice(int price)
    {
        Price += price;
        Console.WriteLine($"Price for product: {Name} is increased by {price}. The new price is {Price}");
    }

    public void DecreasePrice(int price)
    {
        Price -= price;
        Console.WriteLine($"Price for product: {Name} is increased by {price}. The new price is {Price}");
    }
}
