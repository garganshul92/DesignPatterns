using Interpreter_Design_Pattern.Models;

namespace Interpreter_Design_Pattern.Interfaces;

public interface INumberExpression
{
    void Interpret(Context context);
}
