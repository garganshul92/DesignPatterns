## Definition

The Strategy design pattern is a behavioral pattern that allows an algorithm to be selected at runtime. This is useful when an application uses different strategies for different objects or when the strategy needs to be dynamically selected at runtime based on input data.

Also known as Policy Design Pattern.

## Problem it solves

- Need to change the algorithm at runtime.
- Handle multiple algorithms
- 

## When to use?

- Many related classes differentiate only in behavior. You have one common interface but different classes with different behavior.
- You need different variations of an algorithm.
- An algorithm uses data that should be hidden from clients.

## Paritipants

- **Context** – maintains the reference to a Strategy object.
- **State** – defines an interface common to all strategy implementations.
- **Concrete State** – implements the Strategy interface.

## UML

![image](https://github.com/garganshul92/DesignPatterns/assets/42866822/b062bd11-8a4a-45e7-a0d7-db1987c1a83f)

