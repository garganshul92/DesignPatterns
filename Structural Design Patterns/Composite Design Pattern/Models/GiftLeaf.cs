using Composite_Design_Pattern.Interfaces;

namespace Composite_Design_Pattern.Models;

public class GiftLeaf : IGiftComponent
{
    private int _price;

    public GiftLeaf(int price)
    {
        _price = price;
    }

    public void AddGift(IGiftComponent gift)
    {
        throw new NotImplementedException("No Gift can be added in the leaf.");
    }

    public int GetPrice()
    {
        return _price;
    }

    public void RemoveGift(IGiftComponent gift)
    {
        throw new NotImplementedException("No Gift can be removed in the leaf.");
    }
}
