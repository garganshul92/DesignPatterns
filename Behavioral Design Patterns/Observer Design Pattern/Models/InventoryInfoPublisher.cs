using Observer_Design_Pattern.Interfaces;

namespace Observer_Design_Pattern.Models;

public class InventoryInfoPublisher : Publisher
{
    public int inventoryCount;

    public void UpdateInventory(int inventoryCount)
    {
        this.inventoryCount = inventoryCount;
        Notify();
    }

    public void Buy(int inventoryCount)
    {
        this.inventoryCount -= inventoryCount;
        Notify();
    }
}
