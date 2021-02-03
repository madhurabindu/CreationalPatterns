# Factory pattern
In Factory pattern, we create object without exposing the creation logic to client and the client use the same common interface to create new type of object.
<br/>As in this example, moving of your client to a new configuration mechanism over the life of the software does not affect the client code. 
<br/>Adding of new config mechnism only needs adding of a new code and making change in one single method.

## UML Diagram
![plot](./factory.gif)

## Mapping the design pattern UML to Example
| File/Class Name| Mapping UML Class Name  |
| :-----: | :-: |
| AppMain\Program.cs | main() function, invoker of client |
| BaseInterfaces\IConfig.cs| Product |
| RepoFactory/ConfigRepoFactory.cs | Creator |
| RepoFactory/CSVRepoFactory.cs| ConcreteCreator1|
| RepoFactory/XMLRepoFactory.cs| ConcreteCreator2|
| RepoFactory/JsonRepoFactory.cs| ConcreteCreator3|
| CSVConfig/CSVConfig.cs| ConcreteProduct1|
| XMLCOnfig/XMLConfig.cs| ConcreteProduct2|
| JSONConfig/JsonConfig.cs| ConcreteProduct3|


## Useful References
- [https://sourcemaking.com/design_patterns/factory_method](https://sourcemaking.com/design_patterns/factory_method)
- [https://www.dofactory.com/net/factory-method-design-pattern](https://www.dofactory.com/net/factory-method-design-pattern)
- [https://refactoring.guru/design-patterns/factory-method](https://refactoring.guru/design-patterns/factory-method)
