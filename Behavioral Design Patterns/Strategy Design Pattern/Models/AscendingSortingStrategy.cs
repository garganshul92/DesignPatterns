using Strategy_Design_Pattern.Interfaces;

namespace Strategy_Design_Pattern.Models;

public class AscendingSortingStrategy : ISortingStrategy
{
    public void Sort(int[] arr)
    {
        Array.Sort(arr);
    }
}
