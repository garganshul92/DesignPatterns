namespace Iterator_Design_Pattern.Models;

public class Employee
{
    public int EmployeeId { get; set; }

    public string Name { get; set; }

    public Employee(int empId, string name)
    {
        EmployeeId = empId;
        Name = name;
    }
}
