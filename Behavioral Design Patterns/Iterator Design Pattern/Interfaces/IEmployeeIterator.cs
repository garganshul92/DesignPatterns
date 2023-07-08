using Iterator_Design_Pattern.Models;

namespace Iterator_Design_Pattern.Interfaces;

public interface IEmployeeIterator
{
    Employee First();
    Employee? Next();
    bool IsCompleted { get; }
}
