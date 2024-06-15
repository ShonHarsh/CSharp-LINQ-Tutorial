![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 14 - Where

###### Definition
Where - Filters a sequence of values based on a predicate.

###### Method Signature Example
`public static System.Collections.Generic.IEnumerable<TSource> Where<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource,bool> predicate);`

###### Documentation
[Enumerable.Where Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where)

###### Notes
1. Remember that the return collection from the `Where` method is not the original collection modified but a new collection.
2. If no elements match the `Where` criteria then a message "The collection is empty!" is returned and no exception is thrown.
3. Where has an overloaded parameter signature. (variable, index)

###### Example
Find all the elements that are odd.

```c
static void Main(string[] args)
{
  var numbers = new{} { 10, 1, 4, 17, 122 };
  var evenNumbers = numbers.Where(number => number % 2 == 0);

  var verySpecificPets = pets.Where(pet =>
    (pet.PetType == PetType.Cat ||
    pet.PetType == PetType.Dog) &&
    pet.Weight > 10 &&
    pet.Id % 2 == 0);
}
```

###### Multiple Methods, Same Result
```c
// in LINQ we can often achieve one result in two ways.
// for example, to count all dogs heavier than 30 kilos we can do:
// A
var countOfDogsHeavierThan30KilosA = Data.Pets.Count(
    pet => pet.PetType == PetType.Dog && pet.Weight > 30);
//B
var countOfDogsHeavierThan30KilosB = Data.Pets.Where(
    pet => pet.PetType == PetType.Dog && pet.Weight > 30).Count();
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\Where.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\Where.cs
