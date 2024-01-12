![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 05 - Count

###### Definition
Count - Returns the number of elements in a sequence.

###### Method Signature Example
`public static int Count<TSource> (this System.Collections.Generic.IEnumerable<TSource> source);`

###### Documentation
[Enumerable.Count Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count)

###### Notes
1. `Count` returns an integer.  Int ranges from -2,147,483,648 to 2,147,483,647.
2. `LongCount` returns a long.  Long ranges from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.

###### Example
Check if any numbers in a number sequence is larger than a certain size.

```c
static void Main(string[] args)
{
  //Count returns the number of element that meet the specific criteria
  var countOfDogs = Data.Pets.Count(pet => pet.PetType == PetType.Dog);

  //count of all elements
  var countOfAllElements = Data.Pets.Count();
  Console.WriteLine($"countOfAllElements: {countOfAllElements}");
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\Count.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\Count.cs
