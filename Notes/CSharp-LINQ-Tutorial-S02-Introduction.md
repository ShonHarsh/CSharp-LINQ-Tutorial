# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 02 - Introduction

##### What is LINQ?

Language Integrated Query

##### LINQ Data

| Data | LINQ Providers |
|-----:|-----:|
| C# data structures | Simple LINQ |
| Databases| LINQ to SQL |
| XML files| LINQ to XML |
| Any data source| Custom Provider |
| Example: Excel | LINQ to Excel |

The LINQ syntax is the same for all cases.

##### LINQ Benefits
- It allows a simple, efficient, and unified way of querying over different types of data.
- Queries execute only when the result is needed.
- Code written with LINQ is cleaner, more readable, and shorter.

"LINQ is widely considered a great library." -Krystyna Ślusarczyk

##### Lambda Expressions

C# Implementation of IsAnyLargerThan100:

```c
static void Main(string[] args)
{
    var numbers = new[] { 1, 4, 3, 99, 256, 2 };
    bool isAnyLargerThan100 = isAnyLargerThan100(numbers);

    Console.ReadKey();
}

private static bool IsAnyLargerThan100(int[] numbers)
{
  foreach (var number i in numbers)
  {
      if (IsAnyLargerThan100(number))
      {
        return true;
      }
  }
  return false;
}

private static bool IsAnyLargerThan100(int number)
{
  return number > 100;
}
```

LINQ Implementation of IsAnyLargerThan100 and isAnyEven:

```c
static void Main(string[] args)
{
    var numbers = new[] { 1, 4, 3, 99, 256, 2 };

    bool isAnyLargerThan100 = isAnyLargerThan100(numbers);
    Console.WriteLine($"Is any number > 100?: {isAnyLargerThan100}");

    bool isAnyEven = isAnyEven(numbers);
    Console.WriteLine($"Is any number even?: {isAnyEven}");

    Console.ReadKey();
}

private static bool isAnyEven(int[] numbers)
{
  foreach(var number i in numbers)
  {
      if (isAnyEven(number))
      {
        return true;
      }
  }
  return false;

  private static bool isAnyEven(int number)
  {
    return number % 2 == 0;
  }
}
```

IsAny Implementation:

```c
private static bool IsAny(
  int[] numbers,
  Func<int, bool>  predicate)
{
  foreach (var number i in numbers)
  {
      if (predicate(number))
      {
        return true;
      }
  }
  return false;
)
```

LINQ anonymous functions:

```c
bool isAnyLargerThan100 = IsAny(number, IsAnyLargerThan100);
bool isAnyEven = IsAny(number, IsAnyEven);
```
##### Key Points
1. Lamda expressions are used to create anonymous functions.
2. In C# we can use functions like any other types - store them in variables or pass as parameters.

**Other method options: IsAnyPrime, IsANyZero, IsAnyNegative, IsAnyOdd**

##### Lamda Methods
```c
static void Main(string[] args)
{
    var numbers = new[] { 1, 4, 3, 99, 256, 2 };

    bool isAnyLargerThan100 = IsAny(numbers, number => number > 100);
    Console.WriteLine($"Is any number > 100?: {isAnyLargerThan100}");

    bool isAnyEven = IsAny(numbers, numberr => number % 2 == 0);
    Console.WriteLine($"Is any number even?: {isAnyEven}");

    Console.ReadKey();
}
```

```c
bool isAnyLargerThan100 = IsAny(numbers, number =>
{
  const int max = 100;
  return number > max;
})
```

```c
Func<int bool> IsAnyEvenFunc = number => numberr % 2 == 0;
bool isAnyEven = IsAny(numbers, isAnyEvenFunc);
Console.WriteLine($"Is any number even?: {isAnyEven}");
```
Parameterize the type:

```c
private static bool IsAny<T>(
  IEnumerable[T] numbers,
  Func<T, bool>  predicate)
{
  foreach (var number i in numbers)
  {
      if (predicate(number))
      {
        return true;
      }
  }
  return false;
)
```

Example used:

```c
var words = new[] {"aaa", "BB", "cccc"}
bool isAnyOfLength4 = IsAny(words, word => word.Length == 4);
```

##### LINQ Implementation
```c
public static bool Any<TSource>(
  this IEnumerable<TSource> source,
  Func<TSource>, bool prerdicate)
  {

    if (source == null)
    {
      throw Error.ArgumentNull("source");
    }

    if (predicate == null)
    {
      throw Error.ArgumentNull("predicate");
    }

    foreach (TSource element in source)
    {
      if (predicate(element))
      {
        return true;
      }
    }

    return false;
  }
```

##### LINQ and extension methods

- An extension method is a method defined outside of a type, that can be called upon this type's object as a regular member method.
- Extension methods allow us to add new functionality to a type without modifying it.
- The 'this' type in the arguments makes the method an extension method.
- All extension methods must be static.
- Return types are inferred from the implementation.

##### LINQ, IEnumerable<T> and the method changing

- Examples of types that implement IEnumerable are Array, Dictionary, HashSet, List.
- If the type implements IEnumerable, then LINQ works with it.
- LINQ will never modify the input collections.  Thus there is no Add, Remove or Clear.
- LINQ arguments and return type are both IEnumerable<T>.  This allows chaining of operations.

#### Method chaining

```c
var orderedOddNumbers = numbers
  .Where(number => number % 2 == 1)
  .OrderBy(number => number);
  //can add .Discinct(); in method syntax but not query.
```

### Summary - LINQ can be used on any collection that implements IEnumerable.  LINQ arguments and return types are both IEnumerable<T> so the methods can be chained together.

##### Deferred execution in LINQ

- Deferred execution means that the evaluation of a LINQ expression is delayed until the value is actually needed.
- It allows us to work on the latest data.
- It improves the performance, as the query is materialized only when it is actually needed, so we can avoid unnecessary execution.

##### Method Syntax Versus Query Syntax

| Method Syntax | Query Syntax |
|--------------:|-------------:|
| + Pure C# | - New "Language" |
| Preferred by C# Developers | + Easy if you know SQL |
| Supports More Operations | - Not all LINQ operations supported |
| Sometimes Verbose | + Some Operations Simpler to write |
