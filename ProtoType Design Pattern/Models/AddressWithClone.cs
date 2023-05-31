namespace ProtoType_Design_Pattern.Models;

public class Address : ICloneable
{
    public string City;

    public Address(string city)
    {
        City = city;
    }

    public object Clone()
    {
        return MemberwiseClone();
    }
}
