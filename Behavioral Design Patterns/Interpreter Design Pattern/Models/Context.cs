
namespace Interpreter_Design_Pattern.Models;

public class Context
{
    public int Number { get; set; }

    public string IntepretedResult { get; set; }

    public Context(int num)
    {
        Number = num;
    }
}
