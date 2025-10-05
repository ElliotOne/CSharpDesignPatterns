# C# Design Patterns (Gang of Four)

## Overview

This repository is a hands-on collection of small C# console projects that demonstrate the 23 "Gang of Four" (GoF) design patterns. Each pattern is implemented in its own folder (or project) and contains a minimal, readable example and a `Program.cs` you can run to see the pattern in action.

The patterns are organized into the three canonical categories:

- Creational: patterns that deal with object creation mechanisms, trying to create objects in a manner suitable to the situation.
- Structural: patterns that deal with object composition and the relationships between entities.
- Behavioral: patterns that are concerned with algorithms and the assignment of responsibilities between objects.

This repository is intended for learners and engineers who want clear, concise examples of each pattern in idiomatic C#.

## How to use

1. Clone the repository:

   git clone https://github.com/ElliotOne/CSharpDesignPatterns.git

2. Open the solution `CSharpDesignPatterns.sln` in Visual Studio or your preferred C# IDE.

3. Locate the pattern you want to explore by following the folder mapping below.

4. Build and run the project (many are console apps) to observe the example in action.

## Patterns (by category)

### Creational Patterns

1. Abstract Factory
   - Folder: `Creational/AbstractFactory`
   - Files: `AbstractFactory.cs`, `AbstractProductA.cs`, `AbstractProductB.cs`, `ConcreteFactoryA.cs`, `ConcreteFactoryB.cs`, `ProductA1.cs`, `ProductA2.cs`, `ProductB1.cs`, `ProductB2.cs`, `Client.cs`, `Program.cs`
   - Summary: Creates families of related objects without specifying their concrete classes. Demonstrates switching concrete factories to produce different product families.

2. Builder
   - Folder: `Creational/Builder`
   - Summary: Separates construction of a complex object from its representation. Use builder + director to assemble objects step-by-step.

3. Factory Method
   - Folder: `Creational/FactoryMethod`
   - Summary: Defines an interface for creating an object, but lets subclasses decide which class to instantiate.

4. Prototype
   - Folder: `Creational/Prototype`
   - Summary: Create new objects by copying an existing object (cloning), useful for costly-to-create instances.

5. Singleton
   - Folder: `Creational/Singleton`
   - Summary: Ensures a class has only one instance and provides a global point of access to it.

### Structural Patterns

1. Adapter
   - Folder: `Structural/Adapter`
   - Summary: Converts the interface of a class into another interface clients expect. Allows incompatible interfaces to work together.

2. Bridge
   - Folder: `Structural/Bridge`
   - Summary: Decouple an abstraction from its implementation so the two can vary independently.

3. Composite
   - Folder: `Structural/Composite`
   - Summary: Compose objects into tree structures to represent part-whole hierarchies. Lets clients treat individual objects and compositions uniformly.

4. Decorator
   - Folder: `Structural/Decorator`
   - Summary: Attach additional responsibilities to an object dynamically. Provides a flexible alternative to subclassing for extending functionality.

5. Facade
   - Folder: `Structural/Facade`
   - Summary: Provide a unified interface to a set of interfaces in a subsystem. Simplifies usage for clients.

6. Flyweight
   - Folder: `Structural/Flyweight`
   - Summary: Use sharing to support large numbers of fine-grained objects efficiently.

7. Proxy
   - Folder: `Structural/Proxy`
   - Summary: Provide a surrogate or placeholder for another object to control access to it.

### Behavioral Patterns

1. Chain of Responsibility
   - Folder: `Behavioral/ChainOfResponsibility`
   - Files: `Handler.cs`, `ConcreteHandlerA.cs`, `ConcreteHandlerB.cs`, `ConcreteHandlerC.cs`, `Program.cs`
   - Summary: Pass a request along a chain of handlers. Each handler decides either to process the request or pass it to the next handler.

2. Command
   - Folder: `Behavioral/Command`
   - Files: `Command.cs`, `ConcreteCommand.cs`, `Invoker.cs`, `Receiver.cs`, `Program.cs`
   - Summary: Encapsulate a request as an object, allowing parameterization of clients with different requests, queueing or logging requests, and supporting undoable operations.

3. Interpreter
   - Folder: `Behavioral/Interpreter`
   - Files: `AbstractExpression.cs`, `TerminalExpression.cs`, `NonTerminalExpression.cs`, `Context.cs`, `Program.cs`
   - Summary: Define a representation for a grammar and an interpreter that uses the representation to interpret sentences in the language.

4. Iterator
   - Folder: `Behavioral/Iterator`
   - Files: `Iterator.cs`, `Aggregate.cs`, `ConcreteAggregate.cs`, `ConcreteIterator.cs`, `Program.cs`
   - Summary: Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

5. Mediator
   - Folder: `Behavioral/Mediator`
   - Files: `Mediator.cs`, `ConcreteMediator.cs`, `Colleague.cs`, `ConcreteColleagueA.cs`, `ConcreteColleagueB.cs`, `Program.cs`
   - Summary: Define an object that encapsulates how a set of objects interact, promoting loose coupling by preventing objects from referring to each other explicitly.

6. Memento
   - Folder: `Behavioral/Memento`
   - Files: `Memento.cs`, `Originator.cs`, `Caretaker.cs`, `Program.cs`
   - Summary: Capture and externalize an object's internal state so the object can be restored to this state later, without violating encapsulation.

7. Observer
   - Folder: `Behavioral/Observer`
   - Files: `Observer.cs`, `Subject.cs`, `ConcreteObserver.cs`, `ConcreteSubject.cs`, `Program.cs`
   - Summary: Define a one-to-many dependency so that when one object changes state, all its dependents are notified and updated automatically.

8. State
   - Folder: `Behavioral/State`
   - Files: `State.cs`, `ConcreteStateA.cs`, `ConcreteStateB.cs`, `Context.cs`, `Program.cs`
   - Summary: Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.

9. Strategy
   - Folder: `Behavioral/Strategy`
   - Files: `Strategy.cs`, `ConcreteStrategyA.cs`, `ConcreteStrategyB.cs`, `ConcreteStrategyC.cs`, `Context.cs`, `Program.cs`
   - Summary: Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

10. Template Method
    - Folder: `Behavioral/TemplateMethod`
    - Files: `TemplateMethod.cs`, `AbstractClass.cs`, `ConcreteClassA.cs`, `ConcreteClassB.cs`, `Program.cs`
    - Summary: Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing its structure.

11. Visitor
    - Folder: `Behavioral/Visitor`
    - Files: `Visitor.cs`, `Element.cs`, `ConcreteElementA.cs`, `ConcreteElementB.cs`, `ConcreteVisitorA.cs`, `ConcreteVisitorB.cs`, `ObjectStructure.cs`, `Program.cs`
    - Summary: Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.

## Notes and edges

- Folder names and file lists above reflect the current repository layout. Some pattern folders include a full console project (`.csproj`) while others are single-file examples — both approaches aim for clarity.
- Many examples include a `Program.cs` that demonstrates a simple scenario to run and observe outputs.
- Feel free to open issues or submit PRs to improve examples, add more comments, or include additional variants.

## Contributing

- Open an issue to suggest a pattern improvement or new example.
- Fork the repository, make your changes, and open a pull request with a clear description of your changes.

## License

This repository is licensed under the terms in the `LICENSE` file.
