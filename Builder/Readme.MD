# Builder Pattern (Creational Pattern)

## Overview
The Builder pattern is a Creational Design Pattern which helps in constructing a complex object from simple objects using step-by-step approach.
The Builder object based on some parameters makes a decision of how to construct and setup these parts to form the complex object.

## Intent
- Remove new operator from through out the code
- Separate the construction of a complex object from its representation
- SAme construction code (Builder) creates different representations of a particular kind of object

## UML Diagram
![plot](./builder_1.gif)

## Code Example

## Mapping the UML classes to Example code

## Points to Remember
- A complex builder could internally use other creational patterns like Factory Method, Prototype of abstract factory.
- Usually designs start with a Factory method. As the system evolves the design evolves into either Abstract Factory or Builder or sometimes Builder which internally uses Abstract Factory for construction of its representation.
- Be aware: Builders can be anti-pattern if used unnecessarily. 

## Resources
- https://sourcemaking.com/design_patterns/builder
- https://refactoring.guru/design-patterns/builder
- https://blog.tratif.com/2017/11/17/builder-pattern-revisited/
- https://quinngil.com/2019/12/17/builders-as-an-antipattern/
