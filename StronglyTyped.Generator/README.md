Strongly Typed
==============

# What is it?

Strongly Typed is a library of interfaces and extensions that allow developers to strongly type simple primitive values. 
Using strongly typed values eliminates certain classes of errors and potential bugs from code. You can't mix up two `Guid`
arguments to a method if they are of different types! You can also implement domain-specific functionality on types, or
allow conversions or other operations.  This is the incremental source generator that generates the bulk of the strong
type.

# What do I do with it?

This library should be used with StronglyTyped.Common, which defines the interfaces, attributes,  and extension methods 
for working with strongly typed values. You create a "stub" implementation and add an attribute which tags it for the 
Source Generator's attention.

For example, the Generator will generate an Employee Id type from this stub:

``` csharp
[StrongGuid] public partial record struct EmployeeId;
```

Note that it must be `partial`, the Source Generator will implement the rest.

The namespace will be preserved, as will any enclosing types (`static` or non-`static`), those must also be `partial`, 
like so:

``` csharp
namespace MyNamespace
{
    public static partial class Employee
    {
        [StrongGuid] public partial record struct Id;
    }
}
```

This will generate a strongly typed `Guid` of type `Id` nested in the `Employee` static class, in the namespace `MyNamespace`, 
for a full type name of `MyNamespace.Employee.Id`.

These types implement a `TypeConverter`, so they will convert transparently to and from primitive types for, say, ASP .Net
model binding for action methods. They also serialize and deserialize to and from Json transparently using `System.Text.Json`,
so if , say, your web client application uses javascript in AJAX it is not necessary to do any conversions. The serialization 
and deserialization will take care of mapping the strong types to the correct primitive types.

# But I want more control over my values!

These strong types use `partial` methods to provide options for manipulating values and validating them. For example, 

``` csharp
[StrongGuid]
public partial record struct HasAnOverriddenToString
{
    static partial void _overrideToString(Guid value, ref string result)
    {
        result = $"Overridden {value}";
    }
}
```

This will cause the `HasAnOverriddenToString`'s ToString() method to return `Overridden 7240837c-757e-4c02-b592-28b7c24132c6` for a value that
contains the `Guid` `7240837c-757e-4c02-b592-28b7c24132c6`.

There are other `partial` methods which can be implemented, depending on the wrapped primitive type. For example, the `StrongGuid` types allow
overrides for the following:

``` csharp
/// <summary>
/// If implemented, the wrapped value will be preprocessed by this method before creation
/// Preprocessing runs before validation (if implemented)
/// </summary>
/// <param name="value">The value which is to be preprocessed</param>
static partial void _preprocess(ref global::System.Guid result);

/// <summary>
/// If implemented, the result of calling CompareTo on the wrapped value will be modified by this method
/// </summary>
/// <param name="result">The value which will be returned by CompareTo</param>
partial void _overrideEquals(AStrongGuid? obj, ref global::System.Boolean result);

/// <summary>
/// If implemented, the result of calling ToString on the wrapped value will be modified by this method
/// </summary>
/// <param name="result">The value which will be returned by ToString</param>
static partial void _overrideToString(global::System.Guid value, ref global::System.String result);

/// <summary>
/// If implemented, the result of calling CompareTo on the wrapped value will be modified by this method
/// </summary>
/// <param name="result">The value which will be returned by CompareTo</param>
partial void _overrideCompareTo(global::System.Object? obj, ref global::System.Int32 result);

/// <summary>
/// If implemented, this method will be used to check that the value is valid.
/// Validation runs after preprocessing (if implemented)
/// If errors contains any values validation will be considered to have failed.
/// (note that using the constructor, Create, or cast operators will not use this method)
/// </summary>
/// <param name="errors">A set of reasons why the value fails validation</param>
partial void _validate(ref global::System.Collections.Generic.HashSet<global::System.String> errors);
```

# What is left to do?

Lots of other types. I have code for the following, which will be added as I find the time and energy to verify,
write tests, and generally tidy up:

* StrongBool
* StrongByte
* StrongDecimal
* StrongDouble
* StrongFloat
* StrongHalf
* StrongInt
* StrongLong
* StrongSByte
* StrongShort
* StrongString
* StrongUInt
* StrongULong
* StrongUShort

The following are on my to-do list:

* StrongDateTime
* StrongDateOnly
* StrongTimeOnly
* Newtonsoft Json.Net support

I also have some extension methods for Entity Framework that map these types to the database as though they were
the primitive types they wrap, but that will come in a separate package.