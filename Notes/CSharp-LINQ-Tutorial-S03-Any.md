# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 03 - Any

**Any** is used to check if any element in the selection matches the given criteria.

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
