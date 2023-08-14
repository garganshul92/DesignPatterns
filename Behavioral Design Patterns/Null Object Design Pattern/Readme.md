## Definition

The Null object pattern is a design pattern that simplifies the use of dependencies that can be undefined. This is achieved by using instances of a concrete class that implements a known interface, instead of null references.

## Problem it solves

- Checking null references at multiple places

## When to use?

- We should use the Null Object Pattern when a Client would otherwise check for null just to skip execution or perform a default action.

## Paritipants

- **Client**: This class has a dependency that may or may not be required. Where no functionality is required in the dependency, it will execute the methods of a null object.
- **DependencyBase**: This abstract class is the base class for the various available dependencies that the Client may use. This is also the base class for the null object class. Where the base class provides no shared functionality, it may be replaced with an interface.
- **Dependency** – This class is a functional dependency that may be used by the Client.
- **NullObject** – This is the null object class that can be used as a dependency by the Client. It contains no functionality but implements all of the members defined by the DependencyBase abstract class.

## UML

![image](https://github.com/garganshul92/DesignPatterns/assets/42866822/9d4a71fd-60f5-440a-94d3-bf45d28f1781)
