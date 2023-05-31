namespace ProtoType_Design_Pattern.Models;

public class StudentWithDeepCopy : ICloneable
{
    private int Age;
    public string Name;
    public Address Address;

    public StudentWithDeepCopy(string name, int age, Address address)
    {
        Age = age;
        Name = name;
        Address = address;
    }

    public void DisplayStudent()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address.City}");
    }

    public object Clone()
    {
        var obj = (StudentWithDeepCopy)MemberwiseClone();
        obj.Address = (Address)Address.Clone();
        return obj;
    }
}
