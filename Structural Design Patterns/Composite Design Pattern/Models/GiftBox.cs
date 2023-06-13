using Composite_Design_Pattern.Interfaces;

namespace Composite_Design_Pattern.Models;

public class GiftBox : IGiftComponent
{
    IList<IGiftComponent> _gifts;

    public GiftBox()
    {
        _gifts = new List<IGiftComponent>();
    }

    public int GetPrice()
    {
        int price = 0;

        foreach(var gift in _gifts)
        {
            price += gift.GetPrice();
        }

        return price;
    }

    public void AddGift(IGiftComponent gift)
    {
        _gifts.Add(gift);
    }

    public void RemoveGift(IGiftComponent gift)
    {
        _gifts.Remove(gift);
    }


}
