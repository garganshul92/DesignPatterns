using Null_Object_Design_Pattern.Interfaces;

namespace Null_Object_Design_Pattern.Models;

public class Coder : IEmployee
{
    private string _name;

    public Coder(string name)
    {   
        this._name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public bool IsNull()
    {
        return false;
    }
}
