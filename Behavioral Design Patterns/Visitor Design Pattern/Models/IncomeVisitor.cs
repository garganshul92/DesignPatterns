using Visitor_Design_Pattern.Interfaces;

namespace Visitor_Design_Pattern.Models;

public class IncomeVisitor : IVisitor
{
    public void Visit(IElement element)
    {
        Employee employee = element as Employee;

        employee.Salary = 1.10*employee.Salary;

        Console.WriteLine($"{employee.Name}'s new salary: {employee.Salary}");
    }
}
