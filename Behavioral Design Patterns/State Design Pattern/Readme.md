## Definition

The State pattern is a behavioral design pattern that allows an object to change its behavior based on its internal state. The pattern is used to create objects that represent various states and transitions between those states.

## Problem it solves

- Lot of conditions for change in behavior based on the state.
- Impact of adding new behavior is difficult and can cause lot of issues in existing application.

## When to use?

- You have an object that needs to have different behavior depending on its current state. Use it when the number of states is enormous, and your code frequently changes depending on the state.
- You can use the State pattern when you have a class filled with many conditions that control or alter how the class behaves according to the current values of the class fields. How you refactor to the State pattern is that you extract conditional branches into separate state classes. By doing that, you can separate the state-specific code from the main class.
- You can also use the State pattern if you have a lot of transitions between different classes’ states.

## Paritipants

- **Context** – defines an interface for clients to interact. It maintains references to concrete state objects, which you may use to define their current state.
- **State** – defines an interface for declaring what each concrete state should do.
- **Concrete State** – provides an implementation for the methods defined in the state.

## UML

