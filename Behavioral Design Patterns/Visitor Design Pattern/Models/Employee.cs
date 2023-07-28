using Visitor_Design_Pattern.Interfaces;

namespace Visitor_Design_Pattern.Models;

public class Employee : IElement
{
    private string name;
    private double salary;
    private int vacations;

    public Employee(string name, int salary, int vacations)
    {
        this.name = name;
        this.salary = salary;
        this.vacations = vacations;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public double Salary
    {
        get
        {
            return salary;
        }
        set
        {
            salary = value;
        }
    }

    public int Vacations
    {
        get
        {
            return vacations;
        }
        set
        {
            vacations = value;
        }
    }
}
