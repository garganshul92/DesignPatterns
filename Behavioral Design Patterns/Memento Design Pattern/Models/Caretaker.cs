﻿namespace Memento_Design_Pattern.Models;

public class Caretaker
{
    private Memento _memento;

    public Memento Memento
    {
        get { return _memento; }
        set { _memento = value; }
    }
}
