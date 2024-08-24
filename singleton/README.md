## Singleton Pattern

One of the easiest model, used in Creational design pattern

### What

It is a design pattern that restricts the instantiation of a class to one object. 
This is useful when exactly one object is needed to coordinate actions across the system.


### Why

I can think of a few scenarios where the Singleton pattern is useful.
On usage of a shared resource, like a database connection, or a logger, Singleton pattern makes sure that it has one instance of that resource.

### When

When you need to have a single instance of a class, and you want to provide a global point of access to the object.

It can be instantiated in two ways, either lazy or eager.

1. Eager instantiation is when the object is created when the class is loaded.
2. Lazy instantiation is when the object is created only when it is needed.

```        private static readonly Lazy<Singleton> _instance = 
            new Lazy<Singleton>(() => new Singleton());
```

### How

Key components of Singleton pattern are:

#### 1. Static member: 
Static member ensures that memory is allocated only once, preserving the single instance of the Singleton class.
```            private static Singleton instance;
```

#### 2. Private constructor:
Private constructor ensures that the class cannot be instantiated from outside the class.
```        private Singleton() {}
```

#### 3. Public static method:
Public static method provides a global point of access to the Singleton object.

```        public static Singleton Instance
		{
			get
			{
				return _instance.Value;
			}
		}
```

### Where

Code repository : https://github.com/gsenthilvel/DesignCreational

