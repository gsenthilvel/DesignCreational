## Builder Pattern

### What
Builder pattern allows the product construction in a step-by-step fashion. Though construction process can vary 
based on product type, it separates the construction of a complex object from its representation


### Who

It has four key actors (1) Produt (2) Builder (3) Concrete Builder (4) Director.

1. Product is the complex object that the Builder pattern is responsible for constructing.
2. Builder is an interface or an abstract class that declares the construction steps for building a complex object.
3. ConcreteBuilder implements the interface to provide specific implementations for building each part of the product.
4. Director is responsible for managing the construction process of the complex object.

### How

(1) Construction steps are defined in the Builder interface. 

(2) ConcreteBuilder implements the interface to provide specific implementations for building each part of the product. 

(3) Director is responsible for managing the construction

(4) Client class creates the Director object and passes the ConcreteBuilder object to the Director object.

```csharp

public void Construct()
        {
            _builder.SetCPU();
            _builder.SetRAM();
            _builder.SetStorage();
            _builder.SetGPU();
            _builder.SetDisplay();
            _builder.SetOS();
            _builder.GetLaptop().ShowInfo();
        }
```

### When

Builder design pattern is best suitable for any job execution framework, where the job execution steps are common 
but the job execution order can vary like Quartz job scheduler in system programming.
In the given example, the builder pattern is used to create a laptop with different configurations.


### Reference

Code repository : https://github.com/gsenthilvel/DesignCreational

