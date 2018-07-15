# .net-unit-tests-moq

Related blog post can be found [here](http://codereform.com/blog/post/mocking-a-class-dependency-which-casts-into-a-derived-type-using-moq/)
Mocking entities using Moq library.

## WorkingWithInterfaceCasting.Test
A use case on how to mock a dependency that needs to be casted into a derived interface.
Use of the `.As<T>()` method is demonstrated.

#### Example
```
_parentMock.As<IChildInterface>().Setup(m => m.ChildWork()).Verifiable();
```

# License
Apache Version 2.0 License
