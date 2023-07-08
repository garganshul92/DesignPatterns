using Iterator_Design_Pattern.Models;

namespace Iterator_Design_Pattern.Interfaces;

public interface IEmployeeCollection
{
    IEmployeeIterator GetIterator();
    void AddEmployee(Employee employee);
    Employee GetEmployee(int index);
}
