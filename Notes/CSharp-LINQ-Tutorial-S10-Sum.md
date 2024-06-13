![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 10 - Sum

###### Definition
Sum - Computes the sum of a sequence of numeric values.

###### Method Signature Example
`public static float Sum (this System.Collections.Generic.IEnumerable<float> source);`

###### Documentation
[Enumerable.Sum Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum)

###### Notes
1. Calculates the sum on any numeric set.
2. `Sum` will return a zero value on an empty collection.

###### Example
Calculating the sum of pet weights.

```c
static void Main(string[] args)
{
  var numbers = new{} { 16, 8, 9, -1, 2};
  var sumOfNumber = numbers.Sum();
  var sumOfWeightsOfPets = pets.Sum(pet => pet.Weight);
}
```
###### Empty Collection Example
```c
static void Main(string[] args)
{
  var emptyCollection = new int[0];
  var sumOfEmptyCollection = emptyCollection.Sum();
  //sumOfEmptyCollection prints the value 0!
}
```


##### Visual Studio - Code Examples

LinqTutorial\Exercises\Sum.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\Sum.cs
