namespace Template_Method_Design_Pattern.AbstractClasses;

public abstract class AbstractTeaMaker
{
    public void TeaMakingTemplate()
    {
        Console.WriteLine("Tea Making started...");

        AddWater();
        AddTeaLeaves();
        AddSugar();
        AddMilk();

        Console.WriteLine("Hey! Your tea is ready.");
    }

    protected abstract void AddTeaLeaves();
    protected void AddWater()
    {
        Console.WriteLine("Water added to boil");
    }
    protected void AddMilk()
    {
        Console.WriteLine("Milk added");
    }
    protected void AddSugar()
    {
        Console.WriteLine("Sugar Added");
    }
}
