## **Builder Pattern**

**Builder** is a creational design pattern that lets you produce different types and representations of an object using the same building process. Builder allows constructing complex objects step by step.

## **Problem**

Imagine a complex object that requires laborious step by step initialization of many fields and nested objects. Such code is usually buried inside a constructor with lots of parameters, or worse, scattered all over the client code.

## **Solution**

The Builder pattern suggests to extract the object construction code out of its own class and move it to separate objects called *builders*.

The pattern organizes the object construction into a set of steps. To create an object, you will need to call several building steps in a builder class. The important part here is that you do not need to call all the steps. You can use only the steps necessary for producing a particular configuration of an object.

## **Class Diagram**

![UML](C:\Users\sumit.gupta\Documents\CleanCodeWorkshops\Tracks\DesignPatterns\Creational\BuilderPattern\Images\UML.png)

#### Parts

Relationships :

ConcreteBuilder <> Builder - Generalization relationship -  Concrete Builder is a type of Builder - 

Builder <> Director - Aggregation Relationship - Whole/Part relationship - Builder is part of Director and can belong to other class too.

- The **Builder** class specifies an abstract interface for creating parts of a Product object.
- The **ConcreteBuilder** constructs and puts together parts of the product by implementing the Builder interface. It defines and keeps track of the representation it creates and provides an interface for saving the product.
- The **Director** class constructs the complex object using the Builder interface.
- The **Product** represents the complex object that is being built.

## **Builder vs Factory**

You typically use factories to create an object in a single step. But if you need to create an object in multiple steps and if you need the flexibility to vary those steps during creation (for example, some times you may want to skip some steps and sometimes include them), you would use the builder pattern.

You will not get the flexibility to do this if you use factories, because factories create the product in a single step and return you the product. Builders are typically used to build a composite structure. 