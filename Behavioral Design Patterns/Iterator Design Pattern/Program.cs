using Iterator_Design_Pattern.Interfaces;
using Iterator_Design_Pattern.Models;

EmployeeCollection employeeCollection = new EmployeeCollection();
employeeCollection.AddEmployee(new Employee(1, "Anshul"));
employeeCollection.AddEmployee(new Employee(2, "Ayush"));
employeeCollection.AddEmployee(new Employee(3, "Rohit"));

IEmployeeIterator iterator = new EmployeeIterator(employeeCollection);

for(var emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
{
    Console.WriteLine($"Employee Id: {emp.EmployeeId}, Employee Name: {emp.Name}");
}

Console.ReadKey();