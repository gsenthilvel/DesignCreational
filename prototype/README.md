## Prototype Pattern

### What

Prototype design pattern is a creational pattern to create new objects by copying an existing object, 
known as a prototype. This pattern is particularly useful when the cost of creating a new object 
is high or complex.

### Who

It has three key actors (1) Prototype Interface (2) Concrete Prototype (3) Client.

Prototype Interface provides a blueprint for creating new objects by specifying the cloning contract.

Concrete Prototye is a class that implements the clone method with cloning logic specific to the class

Abstract Product is a class to initiate the cloning process without being aware of the concrete classes involved.

### Where

Though prototype is similar to base/derived classes, it is more focused on object creation by cloning

(1) Design: Prototype pattern focuses on object creation by cloning, whereas a base class focuses on defining a common interface and shared behavior for derived classes.
(2) Flexibility: Prototype is more flexible when it comes to creating objects dynamically at runtime, while base classes are more static and defined at compile-time.

As a side effect, it is not advisable to use prototype pattern when objects are immutable (unchangeable) and do not need variations,.

### How

End user promotes a clear separation between the creation of product familes with 
cars and their specifications. It has the following key steps:

(1) Create Prototype interface for concrete class with clone operation.

(2) Create concrete prototype class with memberwise cloning from the above interface.

(3) Client class to create new objects by cloning the prototype object.

```csharp

public interface IObjectPrototype
{
	IObjectPrototype Clone();
}
```

### When

Prototype is best fit when object creation is complex and resource-intensive- classic example is Microsoft Word. 
When users create a new document, they often start from a template in Microsoft Word. 
Prototype pattern helps to clone a template document instead of creating a new document from scratch.


### Reference

Code repository : https://github.com/gsenthilvel/DesignCreational

