# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 04 - All

**All** is used to check if all element in the selection matches the given criteria.

Example: Validate if all numbers in an array are larger than zero.

```c
static void Main(string[] args)
{
  var numbers = new[] { 5, 9, 2, 12, 6 };

  //are all numbers larger than zero
  var areAllLargerThanZero = numbers.All(number => number > 0);
  Printer.Print(areAllLargerThanZero, nameof(areAllLargerThanZero));

  //all pets have non-empty names
  var doAllHaveNonEmptyNames = pets.All(pet =>
    !string.IsNullOrEmpty(pet.Name));
  Printer.Print(doAllHaveNonEmptyNames, nameof(doAllHaveNonEmptyNames));

  //all pet types are cats
  var areAllCats = pets.All(pet =>
    pet.PetType == PetType.Cat);
  Printer.Print(areAllCats, nameof(areAllCats));

  Console.ReadKey();
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\All.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\All.cs
