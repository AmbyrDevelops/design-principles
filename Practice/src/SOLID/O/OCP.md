# Open/Closed Principle (OCP)

- Software entities (classes, modules, functions, etc.) should be open for
extension but closed for modifications.
- Promotes the idea that existing code should be able to be extended with new
functionality without modifying source code.
- Encourages use of Abstraction & Polymorphism to achieve this goal.
- Allows code to be easily extended with inheritance or composition.

## What program does
- Defines Shape Types
- Defines an abstract Shape class 
- Defines concrete shape classes that provide their own implementation of the
CalculateArea method
- Newly added methods can inherit CalculateArea to modify based on their needs.