![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 09 - Average

###### Definition
Average - Computes the average of a sequence of numeric values.

###### Method Signature Example
`public static float Average (this System.Collections.Generic.IEnumerable<float> source);`

###### Documentation
[Enumerable.Average Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.average)

###### Notes
1. The `Average` method can only be used on numbers.
2. An error is thrown if the `Average` method is called on an empty set.

###### Example
Calculate the average weight of pets.

```c
static void Main(string[] args)
{
  var averageWeightOfPets = pets.Average(pet => pet.Weight);
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\Average.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\Average.cs
