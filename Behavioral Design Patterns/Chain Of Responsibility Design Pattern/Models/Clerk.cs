namespace Chain_Of_Responsibility_Design_Pattern.Models;

public class Clerk : Approver
{
    public override void Approve(PurchaseItem item)
    {
        if (item.Price < 10000)
        {
            Console.WriteLine($"{item.ItemName} with Price {item.Price} was approved by Clerk");
        }
        else
        {
            _approver.Approve(item);
        }
    }
}
