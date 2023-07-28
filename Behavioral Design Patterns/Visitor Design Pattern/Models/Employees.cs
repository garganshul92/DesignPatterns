using Visitor_Design_Pattern.Interfaces;

namespace Visitor_Design_Pattern.Models;

public class Employees
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public void RemoveEmployee(Employee employee)
    {
        employees.Remove(employee);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (Employee employee in employees)
        {
            visitor.Visit(employee);
        }
    }
}
