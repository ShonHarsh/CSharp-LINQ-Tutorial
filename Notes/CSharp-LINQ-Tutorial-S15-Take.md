![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 15 - Take, TakeLast, & TakeWhile

###### Definition
Take - Returns a specified number of contiguous elements from the start of a sequence.  
TakeLast - Returns a new enumerable collection that contains the last count elements from source.  
TakeWhile - Returns elements from a sequence as long as a specified condition is true, and then skips the remaining elements.

###### Method Signature Example
`public static System.Collections.Generic.IEnumerable<TSource> Take<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, int count);`

`public static System.Collections.Generic.IEnumerable<TSource> TakeLast<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, int count);`

###### Documentation
[Enumerable.Take Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take)  
[Enumerable.TakeLast<TSource>(IEnumerable<TSource>, Int32) Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.takelast)<be />
[Enumerable.TakeWhile Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.takewhile)

###### Notes
1. If the `Take` parameter exceeds the collection size then all the elements will be returned.  No exception is thrown.
2. These methods are particularly useful when used with the `OrderBy` methods.
3. `TakeWhile` will take elements as long as the element matches the predicate and will stop when the match fails.
4. The `TakeWhile` method is often used with ordered collections as it can reduce computations significantly.

###### Example
Ordering a collection by weight and using the take last to get the top three elements.

```c
static void Main(string[] args)
{
  var numbers = new{} { 1, 4, 10, 154, 999, 15 };

  var firstThreeNumbers = numbers.Take(3);

  var lastThreeNumber = numbers.TakeLast(3);

  //get the second largest number
  var secondLargestNumber = numbers
    .OrderBy(number -=> number)
    .Take(2)
    .First();
    //prints 154

    //get a percentage of elements, first 4 pets of the collection
    var sixtyPercentOfPets = pets
      .Take((int)(pets.Count() * 0.6));

    //takes elements up until a match is not found
    var smallThan20TakeWhile = numbers
      .TakeWhile(number => number < 20);
      //prints 1, 4, 10
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\Take.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\Take.cs
