## **Concepts**

### State
A computer program stores data in variables, which represent storage locations in the computer's memory. **The contents of these memory locations, at any given point in the program's execution, is called the program's state.**

### Programming Paradigms

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

**Side Effect = Changing something somewhere.**

### Problems with Side Effects

Less bugs, Easier to debug. 

Effect free programming doesn't necessarily create programs which has better performance and consumes less memory however due to increase in parallelization and low cost of memory these concerns are taken care. 

Programming without side effects means abstracting side effects away so that you could think about the problem in general -without worrying about the current state of the machine- and reduce dependencies across different modules of a program (be it procedures, classes or whatever else). By doing so, you'll make your program more reusable (as modules do not depend on a particular state to work).

### Functional Programming

Functional programming is a **programming paradigm**—a style of building the structure and elements of computer programs—that treats **computation** as the evaluation of **mathematical functions** and avoids changing-state and mutable data. It is a **declarative programming paradigm**, which means programming is done with expressions or declarations instead of statements. 

In functional code, the output value of a function depends only on the arguments that are passed to the function, so calling a function f twice with the same value for an argument x will produce the same result f(x) each time; this is in contrast to procedures depending on a local or global state, which may produce different results at different times when called with the same arguments but a different program state. 

**Eliminating side effects, i.e. changes in state that do not depend on the function inputs, can make it much easier to understand and predict the behavior of a program, which is one of the key motivations for the development of functional programming.**

### Computation

Computation is any type of calculation that includes both arithmetical and non-arithmetical steps and follows a well-defined model understood and described as, for example, an algorithm.

### Mathematical Functions

In mathematics, a function is a relation between a set of inputs and a set of permissible outputs with the property that each input is related to exactly one output.

An example is the function that relates each real number *x* to its square *x*2. The output of a function *f* corresponding to an input *x* is denoted by *f*(*x*) (read "*f* of *x*"). 

In this example, if the input is −3, then the output is 9, and we may write *f*(−3) = 9. Likewise, if the input is 3, then the output is also 9, and we may write *f*(3) = 9.

The same output may be produced by more than one input, but **each input gives only one output**.

The input variable(s) are sometimes referred to as the argument(s) of the function.

TODO :

1. How to view everything as function - Change in mindset
2. ​



**Further Reading:**

1. Functional vs Imperative :  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/functional-programming-vs-imperative-programming

   ​