## Definition

The Observer design pattern is a software design pattern in which an object, called the subject, maintains a list of its dependents, called observers. When the subject changes state, it notifies its observers. The Observer design pattern is useful when you have objects that need to be notified of changes in another object.

The Observer design pattern is a behavioral pattern that defines a one-to-many relationship between objects, such that one object (the subject) can notify other objects (the observers) of changes to its state. It is often used in event-driven programming, where an event can trigger a change in state in one or more other objects.

## Problem it solves


## When to use?

- When other objects must reflect changes to one object.
- When there is a high chance of adding new observers in the future while keeping the code changes at a minimum.
- When you do not know the number of observers in advance, and they need to change dynamically.

## Paritipants

- **Subject**: Subject refers to the service which the observers will observe and any change in whose state will impact the observers. It is an interface or an abstract class with defined methods to add, remove and notify the subscribers.
- **ConcreteSubject**: The ConcreteSubject is responsible for keeping track of the Subject’s state and notifying the observers about any change in it.
- **Observer** – An interface that updates the status of observers.
- **ConcreteObserver** – Implements the Observer interface and changes the observers’ state with the Subject’s state.

## UML
![image](https://github.com/garganshul92/DesignPatterns/assets/42866822/7c3289e2-7b85-410f-837c-cda1a8a1d8db)
