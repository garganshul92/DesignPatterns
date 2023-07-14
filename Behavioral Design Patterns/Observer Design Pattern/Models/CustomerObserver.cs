using Observer_Design_Pattern.Interfaces;

namespace Observer_Design_Pattern.Models;

public class CustomerObserver : ISubscriber
{
    InventoryInfoPublisher _publisher;
    private string _name;

    public CustomerObserver(InventoryInfoPublisher publisher, string name)
    {
        _publisher = publisher;
        _name = name;
        _publisher.Subscribe(this);
    }

    public void Update()
    {
        if(_publisher.inventoryCount > 10)
        {
            Console.WriteLine($"{_name}: There are {_publisher.inventoryCount} in stock. I can get one tomorrow");
        }
        else if(_publisher.inventoryCount > 5) {
            Console.WriteLine($"{_name}: There are {_publisher.inventoryCount} in stock. I can get it after office too.");
        }
        else
        {
            Console.WriteLine($"{_name}: There are {_publisher.inventoryCount} in stock. I should leave to get one.");
        }
    }

    public void Buy(int count) 
    {
        Console.WriteLine($"{_name}: Yay! I got {count}");

        _publisher.Buy(count);
        _publisher.Unsubscribe(this);
    }
}
