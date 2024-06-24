![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 12 - FirstLast

###### Definition
First - Returns the first element of a sequence.  
Last - Returns the last element of a sequence.

###### Method Signature Example
`public static TSource First<TSource> (this System.Collections.Generic.IEnumerable<TSource> source);`

###### Documentation
[Enumerable.First Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.first)  
[Enumerable.Last Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.last)

###### Notes
1. Returns the first or last element that matches the predicate.
2. Both the `First` and `Last` methods will throw an exception if the collection is empty or if there are no matches for the give predicate.
3. There are both `FirstOrDefault` and `LastOrDefault` methods that will return the data type if there are no matches for the given predicate.
4. Some of the most commonnly used methods in LINQ.

###### Example
Finds the first number in the number[] collection.

```c
static void Main(string[] args)
{
  var numbers = new{} { 16, 8, 9, -1, 2};
  var firstNumber = numbers.First();

  //finds the first odd number
  var firstOddNumber = numbers.First(number => number %2 == 1);

  //ofteh the OrderBy is used in conjunction with First and Last
  var heaviestPet= pets.OrderBy(pet => pet.Weight).Last();
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\FirstLast.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\FirstLast.cs
