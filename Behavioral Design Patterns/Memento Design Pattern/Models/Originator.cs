namespace Memento_Design_Pattern.Models;

public class Originator
{
    private int _state;

    public int State
    {
        get { return _state; }
        set 
        { 
            _state = value;
            Console.WriteLine($"The state set to {_state}");
        }
    }

    public Memento CreateMemento()
    {
        return new Memento( _state );
    }

    public void RestoreMemento(Memento memento )
    {
        Console.WriteLine("The previous state was:");
        State = memento.State;
    }

}
