# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 06 - Contains

###### Definition
Contains - Determines whether a sequence contains a specified element.

###### Method Signature Example
public static bool Contains<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, TSource value);

###### Documentation
[Enumerable.Contains Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.contains)

###### Notes
1. Since the Pet class does not implement the IEquatable<T> or the Equals method, the default System.Object implementation will be used.  This default implementation for classes compares objects by reference.

###### Example
1. Does an array of integer numbers contain the value 42.
2. Do any words in a collection match words from another word collection.

```c
static void Main(string[] args)
{
  var animals = new[] { "bear", "elephant", "owl", "rhinoceros", "tiger", "turtle", "zebra"};
  bool isTigerPresent = words.Contains("tiger");
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\A.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\A.cs
