
using Strategy_Design_Pattern.Interfaces;

namespace Strategy_Design_Pattern.Models;

public class Context
{
    private ISortingStrategy _sortingStrategy;

    public Context(ISortingStrategy strategy)
    {
        _sortingStrategy = strategy;
    }
    public void SetStrategy(ISortingStrategy strategy)
    {
        _sortingStrategy = strategy;
    }

    public void Sort(int[] arr)
    {
        Console.WriteLine("Before Operation:");

        foreach(var el in arr)
        {
            Console.WriteLine(el);
        }

        _sortingStrategy.Sort(arr);

        Console.WriteLine("After Operation:");

        foreach (var el in arr)
        {
            Console.WriteLine(el);
        }
    }
}
