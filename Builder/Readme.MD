# Builder Pattern (Creational Pattern)

## Overview
In classes that have a lot of fields you oftentimes end up with many constructors as you might need objects using different field combinations. This pattern enables a more readable object creation and let’s you specify the fields that are actually needed. 

The Builder pattern is a Creational Design Pattern which helps in constructing a complex object from simple objects using step-by-step approach.

The pattern allows you to create different flavors of an object while avoiding constructor pollution. This pattern is useful when there could be several flavors of an object. Or when there are a lot of steps involved in creation of an object.
## Intent
- Remove new operator from through out the code
- Separate the construction of a complex object from its representation
- SAme construction code (Builder) creates different representations of a particular kind of object

## UML Diagram
![plot](./builder_1.gif)

## Code Example
https://ronnieschaniel.medium.com/object-oriented-design-patterns-explained-using-practical-examples-84807445b092
https://ronnieschaniel.medium.com/object-oriented-design-patterns-explained-using-practical-examples-84807445b092

## Mapping the UML classes to Example code

## Points to Remember
- The key difference from the factory pattern is that; factory pattern is to be used when the creation is a one step process while builder pattern is to be used when the creation is a multi step process.
- A complex builder could internally use other creational patterns like Factory Method, Prototype of abstract factory.
- Usually designs start with a Factory method. As the system evolves the design evolves into either Abstract Factory or Builder or sometimes Builder which internally uses Abstract Factory for construction of its representation.
- Be aware: Builders can be anti-pattern if used unnecessarily. 

## Resources
- https://sourcemaking.com/design_patterns/builder
- https://refactoring.guru/design-patterns/builder
- https://blog.tratif.com/2017/11/17/builder-pattern-revisited/
- https://quinngil.com/2019/12/17/builders-as-an-antipattern/
