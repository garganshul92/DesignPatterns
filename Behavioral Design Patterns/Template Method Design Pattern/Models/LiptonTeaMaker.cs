using Template_Method_Design_Pattern.AbstractClasses;

namespace Template_Method_Design_Pattern.Models;

public class LiptonTeaMaker : AbstractTeaMaker
{
    protected override void AddTeaLeaves()
    {
        Console.WriteLine("Added some Lipton tea leaves");
    }
}
