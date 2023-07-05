using Interpreter_Design_Pattern.Interfaces;
using Interpreter_Design_Pattern.Models;

Console.WriteLine("Please enter the number you want to interpret");
int numberToInterpret =  Convert.ToInt32(Console.ReadLine());

Context context = new Context(numberToInterpret);
INumberExpression expression1 = new EnglishNumbersExpression();

expression1.Interpret(context);
Console.WriteLine($"English interpretation of number {context.Number} is {context.IntepretedResult}");

INumberExpression expression2 = new HindiNumberExpression();

expression2.Interpret(context);
Console.WriteLine($"Hindi interpretation of number {context.Number} is {context.IntepretedResult}");

Console.ReadLine();