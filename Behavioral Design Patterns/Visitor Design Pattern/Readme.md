## Definition

The Visitor design pattern is a behavioral pattern where a visitor object is used to perform operations on other objects. Use the visitor design pattern when adding new operations to an already existing object.

## Problem it solves

- Addition of new funcitonalities to object without altering the object structure.

## When to use?

- You need to perform multiple unique operations on an object structure.
- When an object structure needs to remain unchanged, but you need to implement new features.
- When it’s acceptable to expose an object structure’s operations or internal state.

## Paritipants

- **Visitor** – declares a Visit operation for each class of ConcreteElement in the object structure. The operation's name and signature identifies the class that sends the Visit request to the visitor. That lets the visitor determine the concrete class of the element being visited. Then the visitor can access the elements directly through its particular interface
- **ConcreteVisitor** – implements each operation declared by Visitor. Each operation implements a fragment of the algorithm defined for the corresponding class or object in the structure. ConcreteVisitor provides the context for the algorithm and stores its local state. This state often accumulates results during the traversal of the structure.
- **Element** - defines an Accept operation that takes a visitor as an argument.
- **ConcreteElement** - implements an Accept operation that takes a visitor as an argument
- **ObjectStructure** -
	- can enumerate its elements
	- may provide a high-level interface to allow the visitor to visit its elements
	- may either be a Composite (pattern) or a collection such as a list or a set

## UML




