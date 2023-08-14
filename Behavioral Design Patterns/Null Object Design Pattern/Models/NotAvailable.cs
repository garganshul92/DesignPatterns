using Null_Object_Design_Pattern.Interfaces;

namespace Null_Object_Design_Pattern.Models;

public class NotAvailable : IEmployee
{
    public string GetName()
    {
        return "Not Available";
    }

    public bool IsNull()
    {
        return true;
    }
}
