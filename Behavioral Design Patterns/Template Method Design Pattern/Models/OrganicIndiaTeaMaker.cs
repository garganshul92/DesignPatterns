using Template_Method_Design_Pattern.AbstractClasses;

namespace Template_Method_Design_Pattern.Models;

public class OrganicIndiaTeaMaker : AbstractTeaMaker
{
    protected override void AddTeaLeaves()
    {
        Console.WriteLine("Added some Organic India tea leaves");
    }
}
