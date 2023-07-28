using Visitor_Design_Pattern.Interfaces;

namespace Visitor_Design_Pattern.Models;

public class VacationVisitor : IVisitor
{
    public void Visit(IElement element)
    {
        Employee employee = element as Employee;

        employee.Vacations += 1;

        Console.WriteLine($"{employee.Name}'s vacation days: {employee.Vacations}");
    }
}
