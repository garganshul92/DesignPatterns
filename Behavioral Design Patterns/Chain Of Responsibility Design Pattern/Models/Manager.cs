namespace Chain_Of_Responsibility_Design_Pattern.Models;

public class Manager : Approver
{
    public override void Approve(PurchaseItem item)
    {
        if (item.Price < 20000)
        {
            Console.WriteLine($"{item.ItemName} with Price {item.Price} was approved by Manager.");
        }
        else
        {
            _approver.Approve(item);
        }
    }
}
