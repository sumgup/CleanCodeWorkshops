## **Concepts**

### State
A computer program stores data in variables, which represent storage locations in the computer's memory. **The contents of these memory locations, at any given point in the program's execution, is called the program's state.**

### Programming Paradigm

Programming paradigms are a way to classify programming languages based on their features.  Languages can be classified in multiple paradigms. 

Common programming paradigms include:

- imperative which allows side effects,
- functional which disallows side effects,
- [declarative](https://www.wikiwand.com/en/Declarative_programming) which does not state the order in which operations execute,
- [object-oriented](https://www.wikiwand.com/en/Object-oriented_programming) which groups code together with the state the code modifies,
- [procedural](https://www.wikiwand.com/en/Procedural_programming) which groups code into functions,
- [logic](https://www.wikiwand.com/en/Logic_programming) which has a particular style of execution model coupled to a particular style of syntax and grammar, and
- symbolic programming which has a particular style of syntax and grammar.

For example, languages that fall into the imperative paradigm have two main features: they state the order in which operations occur, with constructs that explicitly control that order, and they allow side effects, in which state can be modified at one point in time, within one unit of code, and then later read at a different point in time inside a different unit of code. 

Meanwhile, in object-oriented programming, code is organized into objects that contain state that is only modified by the code that is part of the object. Most object-oriented languages are also imperative languages.

*In contrast, languages that fit the declarative paradigm do not state the order in which to execute operations. Instead, they supply a number of operations that are available in the system, along with the conditions under which each is allowed to execute. The implementation of the language's execution model tracks which operations are free to execute and chooses the order on its own.*

Example : Smalltalk supports object oriented programming, Haskell/Closure - Functional 

### Side Effect

In computer science, a function or expression is said to have a side effect if it modifies some state outside its scope or has an observable interaction with its calling functions or the outside world besides returning a value. 

For example, a particular function might modify a global variable or static variable, modify one of its arguments, raise an exception, write data to a display or file, read data, or call other side-effecting functions**. In the presence of side effects, a program's behavior may depend on history; that is, the order of evaluation matters**. Understanding and debugging a function with side effects requires knowledge about the context and its possible histories.

Side effects are the most common way that a program interacts with the outside world (people, filesystems, other computers on networks). But the degree to which side effects are used depends on the programming paradigm. Imperative programming is known for its frequent utilization of side effects.

Side Effect = Changing something somewhere.

### Problems with Side Effects

Effect free programming doesn't necessarily create programs which has better performance and consumes less memory however due to increase in parallelization and low cost of memory these concerns are taken care. 



Programming without side effects means abstracting side effects away so that you could think about the problem in general -without worrying about the current state of the machine- and reduce dependencies across different modules of a program (be it procedures, classes or whatever else). By doing so, you'll make your program more reusable (as modules do not depend on a particular state to work).



**Further Reading:**

1. Functional vs Imperative :  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/functional-programming-vs-imperative-programming
2. ​