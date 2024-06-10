# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 07 - OrderBy

###### Definition
OrderBy - Sorts the elements of a sequence in ascending order.

###### Method Signature Example
public static System.Linq.IOrderedEnumerable<TSource> OrderBy<TSource,TKey> (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource,TKey> keySelector);

public static System.Linq.IOrderedEnumerable<TSource> OrderBy<TSource,TKey> (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource,TKey> keySelector, System.Collections.Generic.IComparer<TKey>? comparer);

###### Documentation
[Enumerable.OrderBy Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby)

###### Notes
1. LINQ never modifies the input collection but produces a new one.
2. `OrderByDescending` will order the collection descending.
3. `IOrderedEnumerable` is a subtype of `IEnumerable`.
4. `keySelector` is a function that takes the element of the collection as a parameter and returns the key that is used of ordering.
5. `.ThenBy` is a chaining method that can be used after `OrderBy`.
6. The `IComparer<TKey>? comparer` can be used to tell if one object should be placed before or after another when ordering them.
7. The use case for the `IComparer` interface is when the natural order, alphabetical or numeric, is incorrect.
8. The `IComparer` class can be used to set a complex ordering type and then a single point of code can control this ordering.  That way every time the order method is used a complex LINQ query is not required to be written.
9. The `Reverse` method takes no parameters and simply reverses the collection.
10. An important note is that in C# when ordering a collection by a boolean variable, the **false** values come before **true** values.

###### Example
1. Ordering a collection alphabetically.
2. `IComparer petsOrderedByCatsBeforeDogs` to sort by appointment time then by type so cats always go before dogs.
3. `IComparer petsOrderedByWeightThenType` to sort by a different method.

```c
static void Main(string[] args)
{
  var petsOrderedByName = Data.Pets.OrderBy(pet => pet.Name);

  var petsOrderedByIdDescending = Data.Pets.OrderByDescending(pet => pet.Id);

  var petsOrderedByTypeThenName = Data.Pets
      .OrderBy(pet => pet.PetType)
      .ThenBy(pet => pet.Name);
}
```


###### IComparer<TKey>? comparer Example

This is an example of setting the IComparer class to define the compare operation to order by pet type.

```c
//overloaded Comparer class for the Pet object
public class PetByTypeComparer : IComparer<Pet>
{
    public int Compare(Pet x, Pet y)
    {
        return x.PetType.CompareTo(y.PetType);
    }
}

//there are also overloaded versions of those methods
//Accepting IComparer<T> as an input
var petsOrderedByType = Data.Pets.OrderBy(
    pet => pet, new PetByTypeComparer());
Printer.Print(petsOrderedByType, nameof(petsOrderedByType));
```


##### Visual Studio - Code Examples

LinqTutorial\Exercises\OrderBy.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\OrderBy.cs
