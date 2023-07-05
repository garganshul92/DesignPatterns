using Interpreter_Design_Pattern.Interfaces;
using System.Text;

namespace Interpreter_Design_Pattern.Models;

public class HindiNumberExpression : INumberExpression
{
    string[] numbers = new string[10]
    {
        "Shunya",
        "Ek",
        "Do",
        "Teen",
        "Chaar",
        "Paanch",
        "Cheh",
        "Saat",
        "Aath",
        "No"
    };
    public void Interpret(Context context)
    {
        StringBuilder sb = new StringBuilder();

        int num = context.Number;

        while (num > 0)
        {
            int digit = num % 10;
            num = num / 10;

            sb.Insert(0, numbers[digit]).Insert(0, " ");
        }

        context.IntepretedResult = sb.ToString();
    }
}
