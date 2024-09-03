## Abstract Factory Pattern

### What

Abstract Factory Pattern is another layer of abstraction over Factory pattern. 
It is used to create families of related objects without specifying their concrete classes. 
It provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

### Who

It has four key actors (1) Abstract Factory (2) Concrete Factory (3) Abstract Product (4) Concrete Product.

Abstract Factory is an interface for creating a family of related objects, but it does not specify the concrete classes of the objects to be created.

Concrete Factory is a class that implements the Abstract Factory interface to create a family of related objects.

Abstract Product is an interface for a type of product. Concrete Product is a class that implements the Abstract Product interface to create a specific type of product.


### How

End user promotes a clear separation between the creation of product familes with 
cars and their specifications. It has the following key steps:

(1) Create an interface for the Abstract Factory with a method to create a family of related objects.

(2) Create an interface for the Abstract Product with a method to describe the product.

(3) Create a Concrete Factory class that implements the Abstract Factory interface to create a family of related objects.

(4) Create a Concrete Product class that implements the Abstract Product interface to describe the product.

(5) Create a client class that uses the Abstract Factory and Abstract Product interfaces to create and describe a family of related objects.
  

### When

Classic example of Abstract Factory pattern is GUI toolkit like button, checkbox, menu
across different operating systems like Windows, Linux Mac.

### Where

Factory pattern has three key elements 
(1) create objects without mentioning exact class 
(2) single product type focus with less complexity
(3) lower level abstraction

Abstract factory pattern has the following key elements
(1) create family of related objects without specification 
(2) multiple product type focus with more complexity
(3) higher level abstraction

### Reference

Code repository : https://github.com/gsenthilvel/DesignCreational

