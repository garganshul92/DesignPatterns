## Definition

The Memento design pattern creates a snapshot of the internal state of an object at any instant of time and makes it available for access externally. A Memento is an object that captures another object’s state, the Originator. 

## Problem it solves

Sometimes in an application, you need to resort to your previous selection, undo your current move or want to restore the original state. This is impossible unless you have a snapshot of the previous state.

However, the internal state of an object remains inaccessible most of the time to preserve the encapsulation and reliability of the application. The solution to this issue is the Memento Design Pattern.

## When to use?

- When you need a state later
- When Direct communication would break encapsulation.
- When you need to keep track of increments

## Paritipants

Originator: The Originator is the one that can write its state to the Memento and pass it to the Caretaker when needed

Memento: Memento is the copy that the Originator generates after specific intervals so it can revert back to it.

CareTaker: The mechanism that asks for the Memento, safeguards it, and passes it back to the Originator to restore its original state. It cannot access the internal state of the object. In other words, it sees a narrow interface to the Memento, having only the ability to pass the Memento.

## UML


