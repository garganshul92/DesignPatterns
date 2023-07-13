using System;
namespace Memento_Design_Pattern.Models;

public class Memento
{
    private int _state;

    public Memento(int state)
    {
        _state = state;
    }

    public int State
    {
        get { return _state; }
    }
}
