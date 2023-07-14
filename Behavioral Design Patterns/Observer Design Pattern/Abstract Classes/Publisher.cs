namespace Observer_Design_Pattern.Interfaces;

public abstract class Publisher
{
    private List<ISubscriber> _subscribers = new List<ISubscriber>();

    public void Subscribe(ISubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void Notify()
    {
        foreach (ISubscriber subscriber in _subscribers)
        {
            subscriber.Update();
        }
    }
}
