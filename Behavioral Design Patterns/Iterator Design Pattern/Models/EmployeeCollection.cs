using Iterator_Design_Pattern.Interfaces;

namespace Iterator_Design_Pattern.Models;

public class EmployeeCollection : IEmployeeCollection
{
    List<Employee> employees;

    public EmployeeCollection()
    {
        employees = new List<Employee>();
    }

    public IEmployeeIterator GetIterator()
    {
        return new EmployeeIterator(this);
    }

    public int Count {  get { return employees.Count; } }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public Employee GetEmployee(int index)
    {
        return employees[index];
    }
}
