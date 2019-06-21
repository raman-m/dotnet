## OOD functionality reusage mechanisms & techniques
- *1st.* **Class inheritance.** This is “white-box” reuse mechanism, because subclass knows about parent class internal implementations/definitions etc.
- *2nd.* **Object composition.** This is “black-box” reuse mechanism, because subclass doesn’t see internals of parent classes.
- *3rd.* **Type parametrization, Generics, Templates.** This is “algorithm” reuse mechanism.

## Principles of Object-Oriented Design (OOD)
### GoF definitions
> 1st. __Program to an interface, not an implementation.__

**Design rule**: Declare variables to be an interface or an abstract class.

> 2nd. __Favor object composition over class inheritance.__

Inheritance breaks encapsulation! 

**Design rule**: Use **Delegation** as a way of making composition. In delegation, *two* objects are involved in handling a request: a
receiving object delegates operations to its **delegate**.
