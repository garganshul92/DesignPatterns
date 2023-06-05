using System.Text;

namespace BuilderDesignPattern.Models;

public class Product
{
    IList<object> _parts;

    public Product()
    {
        _parts = new List<object>();
    }

    public void Add(string part)
    {
        _parts.Add(part);
    }

    public string ListParts()
    {
        StringBuilder str = new();

        foreach (var part in _parts)
        {
            str.Append(part).Append(',');
        }

        str.Length--;
        return $"Products Parts: {str}";
    }
}
