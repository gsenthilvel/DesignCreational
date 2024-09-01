## Factory Pattern

Factory pattern is one of the most used creational design pattern in real world applications,
like DB, Logging frameworks. It is used to create objects based on a common interface.

### Without Factory

End user is responsible for creating the object by directly instantiating the class
based on the input type durint its construction.  It has limitation of tighly coupling,
limited scalability and single responsibility violation.

```       
	if (carModel == 1)
	{
		_evCar = new Tesla();
	}
```       

### With Factory

Two key actors in Factory design (1) underlying product (2) creator factory
Both actors are driven by interface with multiple derived classes.

It is a design pattern that provides an interface for creating objects in a superclass, 
but allows subclasses to alter the type of objects that will be created.

```       
	ICarFactory carFactory = new CarFactory();
	_evCar = carFactory.GetCar(carModel);
```

### Benefits

The Factory pattern is useful when you need to create an object based on a specific input or condition.
It has few design advantages like: decoupling of creation logic with client usage, code reusability,
scalability with extensiblity and single responsibility principle.

### Reference

Code repository : https://github.com/gsenthilvel/DesignCreational

