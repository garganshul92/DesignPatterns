using Null_Object_Design_Pattern.Interfaces;

namespace Null_Object_Design_Pattern.Models;

public class EmployeesData
{
    static IList<string> _employees = new List<string>() { "Ayush", "Anshul", "Rohit" };

    public static IEmployee GetEmployee(string name)
    {
        if (_employees.Contains(name))
        {
            return new Coder(name);
        }

        return new NotAvailable();
    }
}
