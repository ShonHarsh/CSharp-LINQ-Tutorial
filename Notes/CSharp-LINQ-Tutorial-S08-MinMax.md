# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 08 - MinMax

###### Definition
Min - Returns the minimum value in a sequence of values.<br />
Max - Returns the maximum value in a sequence of values.

###### Method Signature Example
public static int? Min (this System.Collections.Generic.IEnumerable<int?> source);

###### Documentation
[Enumerable.Min Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.min)<br />
[Enumerable.Max Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.max)

###### Notes
1. For non-nullable types (such as integer), an exception will be thrown if the collection is empty.
2. For nullable types, the result for an empty collection will be null.
3. The same implementation of the CompareTo call can me completed as it is in the OrderrBy section.

###### Example
Find the minimum number in an integer array.

```c
static void Main(string[] args)
{
  //Min returns the minimal number in the collection
  var minNumber = numbers.Min();

  //we can select some particular numeric value from a collection of objects
  var lightestPetWeight = Data.Pets.Min(pet => pet.Weight);
}
```

###### IComparer<TKey>? comparer Example

```c
public class Pet : IComparable<Pet> { }

public int CompareTo(Pet other)
{
  return Weight.CompareTo(other.Weight);
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\MixMax.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\MinMax.cs
