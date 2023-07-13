using Memento_Design_Pattern.Models;

Originator origin = new Originator();
Random rand = new Random(100000);
origin.State = rand.Next();

// Creating a Memento
Caretaker caretaker = new Caretaker();
caretaker.Memento = origin.CreateMemento();

// Changing the state 
origin.State = rand.Next();

// Restoring the state
origin.RestoreMemento(caretaker.Memento);
