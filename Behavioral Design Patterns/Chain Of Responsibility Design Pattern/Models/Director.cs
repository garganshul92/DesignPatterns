namespace Chain_Of_Responsibility_Design_Pattern.Models;

public class Director : Approver
{
    public override void Approve(PurchaseItem item)
    {
        if (item.Price < 50000)
        {
            Console.WriteLine($"{item.ItemName} with Price {item.Price} was approved by Director");
        }
        else
        {
            Console.WriteLine("This item can't be approved.");
        }
    }
}
