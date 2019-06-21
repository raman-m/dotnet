## OOD functionality reusage mechanisms & techniques
- *1st.* **Class inheritance.** This is “white-box” reuse mechanism, because subclass knows about parent class internal implementations/definitions etc.
- *2nd.* **Object composition.** This is “black-box” reuse mechanism, because subclass doesn’t see internals of parent classes.
- *3rd.* **Parameterized Types<sup>1</sup>, Generics<sup>2</sup>, Templates<sup>3</sup>.** This is “algorithm” reuse mechanism.
> <sup>1</sup>Parameterized Types is the term of Java: *A parameterized type is an instantiation of a generic type with actual type arguments.*

> <sup>2</sup>Generics are also known as *Generic Type* in Java, and often used in .NET, C#.

> <sup>3</sup>Templates is the term of C++.

## Principles of Object-Oriented Design (OOD)
### GoF definitions
> 1st. __Program to an interface, not an implementation.__

**Design rule**: Declare variables to be an interface or an abstract class.

> 2nd. __Favor object composition over class inheritance.__

Inheritance breaks encapsulation! 

**Design rule**: Use **Delegation** as a way of making composition. In delegation, *two* objects are involved in handling a request: a
receiving object delegates operations to its **delegate**.
