namespace Composite_Design_Pattern.Interfaces;

public interface IGiftComponent
{
    int GetPrice();

    void AddGift(IGiftComponent gift);

    void RemoveGift(IGiftComponent gift);
}
