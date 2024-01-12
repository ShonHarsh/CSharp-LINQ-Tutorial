![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 11 - ElementAt

###### Definition
ElementAt - Returns the element at a specified index in a sequence

###### Method Signature Example
`public static TSource ElementAt<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, Index index);`

###### Documentation
[Enumerable.ElementAt Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.elementat)

###### Notes
1. This is an action desired often.
2. Getting an element at a position is easy in many collections such as a list or array, a collection of `IEnumerable<T>` does not support the standard syntax.
3. If there is no element at the index of where the `ElementAt` is accessing an System.ArgumentOutOfRangeException error will be thrown.
4. `ElementAtOrDefault` is a safer method as it will return the default type of the collection if the index does not exist.

###### Example
Get the element at location 3 in numbers[].

```c
static void Main(string[] args)
{
  //Standard method
  var numbers = new{} { 16, 8, 9, -1, 2};
  var firstNumber - numbers[0];

  //Error
  IEnumerable<T> numbers = new{} { 16, 8, 9, -1, 2};
  var firstNumber - numbers[0];

  //Valid
  IEnumerable<T> numbers = new{} { 16, 8, 9, -1, 2};
  var firstNumber - numbers.ElementAt(0);
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\ElementAt.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\ElementAt.cs
