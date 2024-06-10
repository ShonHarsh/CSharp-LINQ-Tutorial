# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 03 - Any

###### Definition
Any - Determines whether any element of a sequence exists or satisfies a condition.

###### Method Signature Example
public static bool Any<TSource> (this System.Collections.Generic.IEnumerable<TSource> source);

###### Documentation
[Enumerable.Any Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.any)

###### Notes
None

###### Example
Example: Validate if a number in an array is larger then 10.

```c
static void Main(string[] args)
{
  var numbers = new[] { 5, 9, 2, 12, 6 };

  bool isAnyLargerThan10 = numbers.Any(number => number > 10);

  Console.WriteLine($"isAnyNumberLargerThan10: {isAnyLargerThan10}");
  Console.ReadKey();
}
```
##### Visual Studio - Code Examples

LinqTutorial\Exercises\Any.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\Any.cs
