# Fragile Base Class Problem

## Using composition over inheritance

- The Fragile Base Class Problem is a software design issue that arises in OOP
when changes made to a base class can inadvertently break the functionality of
derived classes.
- This problem occurs due to tight coupling between base and derived classes in
inheritance hierarchies.

1. Inheritance Coupling: Inheritance creates a strong coupling between the base
class (superclass) and derived classes (subclasses).  Any changes made to the
base class can potentially affect the behavior of all derived classes.

2. Limited Extensibility: The Fragile Base Class Problem limits the
extensibility of sofware systems, as modifications to the base class can become
increasingly risky and costly over time. Developers may avoid making necessary
changes due to the fear of breaking existing functionality -- Brittle software.

- Mitigation Strategies: To mitigate the Fragile Base Problem, software
developers can use design principles the Open/Closed principle a.k.a OCP and
dependency inversion principle a.k.a DIP, a well as design patterns like
Composition over Inheritance. These approaches promote loose coupling,
ecapsulation, and modular design, reducing the impact of changes in base classes.