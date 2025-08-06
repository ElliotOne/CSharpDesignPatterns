# CSharp Design Patterns

This project is a comprehensive collection of **Design Patterns** implemented in **C#** using separate Console Projects. It’s organized into three major categories as defined by the **Gang of Four (GoF)**: **Creational**, **Structural**, and **Behavioral**.

Each pattern is demonstrated with clear, isolated examples to help you understand their purpose, structure, and use cases.

## 📁 Folder Structure

1. [Creational Patterns](#1-creational-patterns)
2. [Structural Patterns](#2-structural-patterns)
3. [Behavioral Patterns](#3-behavioral-patterns)

## 1. Creational Patterns

Creational patterns deal with object creation mechanisms. They aim to create objects in a manner that is suitable to the situation, abstracting the instantiation process.

1. [**Abstract Factory**](./Creational/AbstractFactory) – Creates families of related or dependent objects without specifying their concrete classes.
2. [**Builder**](./Creational/Builder) – Separates the construction of a complex object from its representation.
3. [**Factory Method**](./Creational/FactoryMethod) – Defines an interface for creating an object but lets subclasses decide which class to instantiate.
4. [**Prototype**](./Creational/Prototype) – Creates new objects by copying an existing object (prototype).
5. [**Singleton**](./Creational/Singleton) – Ensures a class has only one instance and provides a global point of access to it.

## 2. Structural Patterns

Structural patterns deal with object composition and typically help ensure that if one part of a system changes, the entire structure doesn't need to do the same.

1. [**Adapter**](./Structural/Adapter) – Converts the interface of a class into another interface clients expect.
2. [**Bridge**](./Structural/Bridge) – Decouples an abstraction from its implementation so that the two can vary independently.
3. [**Composite**](./Structural/Composite) – Composes objects into tree structures to represent part-whole hierarchies.
4. [**Decorator**](./Structural/Decorator) – Adds new responsibilities to an object dynamically.
5. [**Facade**](./Structural/Facade) – Provides a unified interface to a set of interfaces in a subsystem.
6. [**Flyweight**](./Structural/Flyweight) – Reduces the cost of creating and manipulating a large number of similar objects.
7. [**Proxy**](./Structural/Proxy) – Provides a surrogate or placeholder for another object to control access to it.

## 3. Behavioral Patterns

Behavioral patterns are concerned with algorithms and the assignment of responsibilities between objects.

1. [**Chain of Responsibility**](./Behavioral/ChainOfResponsibility) – Passes a request along a chain of handlers.
2. [**Command**](./Behavioral/Command) – Encapsulates a request as an object, thereby allowing for parameterization and queuing.
3. [**Interpreter**](./Behavioral/Interpreter) – Implements a grammar interpreter for a language.
4. [**Iterator**](./Behavioral/Iterator) – Provides a way to access elements of a collection sequentially without exposing its underlying representation.
5. [**Mediator**](./Behavioral/Mediator) – Defines an object that encapsulates how a set of objects interact.
6. [**Memento**](./Behavioral/Memento) – Captures and restores an object’s internal state without violating encapsulation.
7. [**Observer**](./Behavioral/Observer) – Defines a one-to-many dependency between objects.
8. [**State**](./Behavioral/State) – Allows an object to alter its behavior when its internal state changes.
9. [**Strategy**](./Behavioral/Strategy) – Defines a family of algorithms and makes them interchangeable.
10. [**Template Method**](./Behavioral/TemplateMethod) – Defines the skeleton of an algorithm in a method, deferring some steps to subclasses.
11. [**Visitor**](./Behavioral/Visitor) – Represents an operation to be performed on the elements of an object structure.

## 🚀 Getting Started

Each pattern is implemented as a **console project**. You can run them individually to understand their behavior.

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)

### Running a Pattern Example
```bash
cd Creational/Singleton
dotnet run
```

## License
This project is open-source and available under the MIT License.
