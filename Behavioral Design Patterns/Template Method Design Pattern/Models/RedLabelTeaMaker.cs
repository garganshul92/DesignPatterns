using Template_Method_Design_Pattern.AbstractClasses;

namespace Template_Method_Design_Pattern.Models;

public class RedLabelTeaMaker : AbstractTeaMaker
{
    protected override void AddTeaLeaves()
    {
        Console.WriteLine("Added some Red Label tea leaves");
    }
}
