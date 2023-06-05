![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 17 - OfType

###### Definition
OfType - Filters the elements of an IEnumerable based on a specified type.

###### Method Signature Example
`public static System.Collections.Generic.IEnumerable<TResult> OfType<TResult> (this System.Collections.IEnumerable source);`

###### Documentation
[Enumerable.OfType<TResult>(IEnumerable) Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.oftype)

###### Notes
1. The `OfType` method is not an extension method of IEnumerable<T> like most LINQ methods.  Instead it returns a type of IEnumerable.
2. A collection can be of mixed type but the return of `OfType` will be a collection of objects of that parameter type.  For example, the array in the code segment below has integers and strings.  The return type of the strings LINQ call is string.
3. The `OfType` method is often used to operate on types that share a common interface.

###### Example
Get all elements that are of type string.

```c
static void Main(string[] args)
{
  var objects = new object[]
  {
      null,
      1,
      "all",
      2,
      "ducks",
      new List<int>(),
      "are",
      "awesome",
      true
  };

  var strings = objects.OfType<string>();
  Printer.Print(strings, nameof(strings));
  //Returns all, ducks, are, awesome
}
```

```c
var birds = flyables.OfType<Bird>();
Printer.Print(birds, nameof(birds));
//returns LinqTutorial.Bird

var fuelables = flyables.OfType<IFuelable>();
Printer.Print(fuelables, nameof(fuelables));
//returns LinqTutorial.Plane, LinqTutorial.Helecopter
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\OfType.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\OfType.cs
