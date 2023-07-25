## Definition

Template Method design pattern is a behavioral design pattern that defines the skeleton of an algorithm in a superclass, but lets subclasses override specific algorithm steps. You can use it to create flexible algorithms. It also prevents subclasses from modifying the algorithm in incompatible ways.

## Problem it solves

- Different classes have repeated code.

## When to use?

- When the algorithm has variant and invariant parts
- When localizing common behavior among classes is the goal
- When subclasses need to be controlled.

## Paritipants

- **AbstractClass** – This class contains the template method which defines the order and outline of an algorithm.
- **ConcreteClass** – This class speifies and refines the algorihtm by redefining or implementing the abstract operations defined in the parent class.

## UML

