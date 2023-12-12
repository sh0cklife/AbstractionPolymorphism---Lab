//Abstractions, Interfaces, Abstract Classes, Interfaces vs Abstract Classes, Polymorphism, The 'is' keyword, The 'as' keyword;
//What is abstraction: Abs + Trahere = Abstraction
// Preserving information, relevant in a given context and forgetting information that is irrelevant in that context
// Relevant to what? 
// Relevant to the context of the project we develop
// Abstraction helps managing complexity
// Abstraction lets you focus on what the object does instead of how it does it
// There are two ways to achieve abstraction: Interfaces, Abstract class
public interface IRunning { }
public abstract class Mammal { }
public class Person : Mammal, IRunning { }
// Abstraction is the process of HIDING THE IMPLEMENTATION DETAILS and showing only func. to the user -- Achieved with INTERFACES and ABSTRACT CLASSES
// Encapsulation used to hide the CODE and DATA inside a SINGLE UNIT TO PROTECT THE DATA FROM THE OUTSIDE WORLD -- Achieved with ACCESS MODIFIERS (private, protected, public..)
// Interface: Internal addition by compiler
public interface IPrintable // Keyword interface, Name(starts with I per convention)
{
    void Print();
}
// complier
//public interface IPrintable
//{
//    public abstract void Print();
//}
// The implementation of Print() is provided in class Document
class Document: IPrintable 
{
    public void Print()
    {
        Console.WriteLine("Hello");
    }
}
// Abstract Class CANNOT be instantiated
// May containt ABSTRACT METHODS and ACCESSORS
// Must provide IMPLEMENTATION for all INHERITED interface members
// Implementing an interface might map the interface methods onto abstract methods
// An ABSTRACT method is implicitly a VIRTUAL method
// Abstract method declarations are only permitted in abstract classes
// An abstract method declaration provides no actual implementation:
public abstract void Build();
// Interface vs Abstract class (1)
// Interface: Class may implement several interfaces /// AC may inherit only one abstract class
// Interface: Cannot have access modifiers, everything is assumed as public /// AC can provide implementation and/or just the signature that have to be overriden
// Interface: Cannot provide any code, just the signature // AC can contain access modifiers for the fields, functions, properties
// Interface vs Abstract class (2)
// Interface: Fields and constants can't be defined // AC fields and contants can be defined
// Interface: If we add a new method we have to track down all the implementations of the interface and define implementation for the new method // AC: If we add a new method we have the option of providing default implementation and therefore all the existing code might work properly
// Project 1 - Shapes 

// Polimorphism
// This is something similiar to a word having several different meanings depending on the context
// Aiblity of an object to take on many forms
public interface IAnimal { }
public abstract class Mammal { }
public class Peron : Mammal, IAnimal { }
// person IS-A Person
// person IS-AN Object
// person IS-AN Animal
// person IS-A Mammal
// Variables Type is the compile-time type of the variable
// Data Type is the actual runtime type of the variable
// If you need an object method you need to cast it or override it
public class Person : IAnimal { }
IAnimal person = new Person();
object objPerson = new Person();
Mammal mammal = new Person();
Person person = new Person();
// Runtime check if an object is an instance of a specific class
public class Person: Mammal, IAnimal { }
IAnimal person = new Person();
Mammal personOne = new Person();
Person personTwo = new Person();
if (person is Person) // TRUE Check object type of person
{
    // Cast to object type and use its methods
    ((Person)person).GetSalary();
}
// Type pattern = tests whether an expression can be converted to a specified type and casts it to a variable of that type
public class Person: Mammal, IAnimal { }
Mammal personOne = new Person();
Person personTwo = new Person();
if (personOne is Person person) // Checks if object is of type person and casts it
{
    person.GetSalary(); // Uses its methods
}
// 'IS' Constant Pattern
// When performing pattern matching with the constant pattern, 'is' tests whether an expression equals to a specified constant
// Checking for null can be performed using the constant pattern
int i = 0;
int min = 0, max = 10;
while (true)
{
    Console.WriteLine($"i is {i}");
    i++;
    if (i is max or min) break;
}
// 'AS' Keyword: You can use the 'as' operator to perform certain types of conversions between compatible reference types
public class Person: Mammal, IAnimal { }
IAnimal person = new Person();
Mammal personOne = new Person();
Person personTwo;
personTwo = personOne as Person;
if (personTwo != null)
{
    // Do something specific for Person
}
// Summary:
// 1. Abstraction
// 2. How do we achieve abstraction
// 3. Interfaces
// 4. Abstract classes
// 5. Polymorphism - Definition and Types
// 6. is Keyword
// 7. as Keyword
