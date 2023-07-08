using Iterator_Design_Pattern.Interfaces;

namespace Iterator_Design_Pattern.Models;

public class EmployeeIterator : IEmployeeIterator
{
    EmployeeCollection employeeCollection;
    int index;

    public EmployeeIterator(EmployeeCollection employeeCollection)
    {
        this.employeeCollection = employeeCollection;
        index = 0;
    }
    public bool IsCompleted => index >= employeeCollection.Count;

    public Employee First()
    {
        index = 0;
        return employeeCollection.GetEmployee(index);
    }

    public Employee? Next()
    {
        index++;

        if (IsCompleted)
        {
            return null;
        }
        else
        {
            return employeeCollection.GetEmployee(index);
        }
    }
}
