# StronglyTyped
StronglyTyped is a C# library that provides a simple and convenient way to strongly type values in your code. It consists of two parts: a package called `StronglyTyped.Common` that provides marker classes, interfaces, and extensions, and an incremental source generator called `StronglyTyped.Generator` that generates partial implementations of stub record structs to strongly type values.

When you use StronglyTyped, you can create strongly typed values in your code that are more expressive and self-documenting than raw primitives. For example, suppose you have a string that represents a last name value. With a raw string, you don't have any information about what the string represents or what values it should contain. If you pass this string around your codebase, it can be difficult to keep track of what it represents and what operations are valid on it.

However, if you use StronglyTyped, you can define a LastName struct using StronglyTyped.Generator that represents a last name value. This struct is strongly typed, which means that it has a specific type that is separate from other types in your code. This makes it clear what the value represents and what operations are valid on it.

```csharp
[StrongString] public partial record struct LastName;
```
Using this struct, you can create strongly typed values for last names. For example:

```csharp
var lastName = "Smith".As<LastName>();
```
Now, instead of a raw `string` that could contain any value, you have a strongly typed value that you can pass around your codebase. This helps prevent errors and makes your code easier to read and maintain. For example, if you have a method that takes a `LastName` parameter, you know exactly what kind of value you should pass to that method:

``` csharp
void Greet(FirstName firstName, LastName lastName)
{
    Console.WriteLine($"Hello {firstName} {lastName}");
}

var firstName = "Michael".As<FirstName>();
var lastName = "Smith".As<LastName>();
var email = "x@x"

Print(firstName, lastName); // This is clear and correct

Print(lastName, firstName); // This will cause a compilation error
Print(email, lastName); // This will cause a compilation error
Print("Michael", "Smith"); // This will cause a compilation error
```
By using StronglyTyped, you can make your code more robust and easier to work with, even as it grows and changes over time.

The StronglyTyped.Common package provides a set of interfaces and marker classes that you can use to create your own strongly typed values. The StronglyTyped.Generator package works by analyzing your code at build time and generating partial implementations of stub record structs for you.

In addition to providing strong typing, value types generated by StronglyTyped also implement type converters and serializers. This means you can transparently use these types at the edges of your application, for example in the action methods of an ASP.NET application.

For example, suppose you want to strongly type the ID, name, and salary of an employee in your code. You could define them using StronglyTyped like this:

``` csharp
namespace Example
{
    using StronglyTyped.Common;
    using StronglyTyped.Generator;

    public partial static class Employee
    {
        [StrongGuid] public partial record struct ID;
        [StrongString] public partial record struct Name;
        [StrongDecimal] public partial record struct Salary;
    } 
}
```
Once you've defined your strongly typed values, you can use them in your code just like any other type. For example, you could create an EmployeeObject class with strongly typed properties like this:

``` csharp
namespace Example
{
    public class EmployeeObject
    {
        public Employee.ID ID { get; init; }
        public Employee.Name Name { get; init; }
        public Employee.Salary Salary { get; init; } 
    } 
}
```
This makes it clear what type of value each property should contain, and helps prevent errors. And because the value types generated by StronglyTyped implement type converters and serializers, you can easily use them in other parts of your code, such as in the action methods of an ASP.Net application.

Whether you're working on a small project or a large codebase, StronglyTyped can help you write better, more robust code.
