namespace Chain_Of_Responsibility_Design_Pattern.Models;

public class PurchaseItem
{
    public string ItemName { get; set; }
    public int Price { get; set; }

    public PurchaseItem(string itemName, int price)
    {
        ItemName = itemName;
        Price = price;
    }
}
