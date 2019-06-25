## Design Patterns
> Design patterns codify general solutions to common problems.

### GoF Design Patterns
There are 23 design patterns.

**Abstract Factory**. Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

**Adapter**. Convert the interface of a class into another interface clients expect.
Adapter lets classes work together that couldn't otherwise because of incompat ibleinterfaces.

Bridge(1 51 ) Decouple an abstractio n from its implementation so that the two c an vary
independently.

Builder (97) Separate the construction of a complex object from its representation so
that the same construction process can create different representations.

Chain of Responsibility (223) Avo id coupling the sender of a request to its receiver by
giving more than one object a chance to handle the request. Chain the receiving
objects and pass the request along the chain until an obje ct handles it.

Command ( 233) Encapsulate a request as an object, thereby letting you parameterize
clients with different requests, queue or log requests, and support undoable
operations.

Composite( 163) Compose obje cts into tree structures to represent part-whole hierarchies.
Composite lets clients treat individual objects and compositions of objects
uniformly.

Decorator( 175 ) Att achadditional responsibilitie s to an obj ectdynamically. Decorators
provide a flexible alternative to subclassing for extending functionality.

Facade( 185 ) Provide a unified interface to a set of interfaces in a subsystem. Facade
defines a higher-level interf acethat makes the subsystem easier to use.

Factory Method( 107) Define an interfa ce for creating an object, but let subcl asses decide
which class to instantiate. Factory Method lets a cl ass defer instantiation to
subclasses.

Flyweight (195 ) Use sharing to support large numbers of fine-grained objects efficiently.

Interpreter (243) Given a language, define a represention for its grammar along with
an interpreter that uses the representation to interpret sent ences in the language.

Iterator (257) Provide a way to access the elements of an aggregate object sequentially
without exposi ng its underlying representation.

Mediator (273) Define an object that encapsulates how a set of objects interact. Mediator
promotes l oose coupling by keeping objects from referring to each other
explicitly, and it lets you vary their interaction independently.

Memento ( 283) Without violating encapsulation, capture and externalize an object's
internal state so that the object ca n be restored to this state later.
Observer (293) Define a one-to-many dependency between objects so that when one
object changes state, all its dependents are notified and upda tedautomatically.

Prototype( 117 ) Specify the kinds of obj ectsto crea te using a prototypi cal instance, and
create new obj ectsby copying this prototype.

Proxy (207) Provide a surrogate or placeholder for another object to control access to
it.

Singleton (127 ) Ensure a class only has one instance, and provide a global point of
access to it.

State ( 305 ) Allow an object to alter its behavior when its internal state changes. The
object will appear to change its cl ass.

Strategy( 315 ) Define a family of algorithms, encapsulate each one, and make them
interchangeable. Strate gylets the algorithm vary independently from clie nts that
use it.

Template Method ( 325) Define the skeleton of an algorithm in an operation, deferring
some steps to subclasses. Temp lateMethod lets subclasses redefine certain steps
of an algorithm without changing the algorithm 's structure.

Visitor( 331 ) Represent an operation to be performed on the elements of an object
structure. Vis itor lets you define a new operation without changing the classes of
the elements on which it operates.
