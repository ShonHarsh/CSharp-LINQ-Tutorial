![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 16 - Skip

###### Definition
Skip - Bypasses a specified number of elements in a sequence and then returns the remaining elements.<br />
SkipLast - Returns a new enumerable collection that contains the elements from source with the last count elements of the source collection omitted.<br />
SkipWhile - Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.

###### Method Signature Example
`public static System.Collections.Generic.IEnumerable<TSource> Skip<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, int count);`

`public static System.Collections.Generic.IEnumerable<TSource> SkipLast<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, int count);`

`public static System.Collections.Generic.IEnumerable<TSource> SkipWhile<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource,bool> predicate);`

###### Documentation
[Enumerable.Skip<TSource>(IEnumerable<TSource>, Int32) Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.skip)<br />
[Enumerable.SkipLast<TSource>(IEnumerable<TSource>, Int32) Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.skiplast)<br />
[Enumerable.SkipWhile Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.skipwhile)

###### Notes
1. The `Skip` methods is similar to `Take` methods.
2. If the parameter for skip is larger than the data set then an empty collection is returned.  No exception is thrown.
3. The `Skip` and the `Take` methods are often used in conjunction.  For example, displaying records on a page with a page number.  For example, `var secondPageOfPets = pets.Skip(2).Take(2)` returns the pet number 3 and 4.
4. The `SkipWhile` can be used to skip until a condition is met.  For example, `var skipWhileSmallerThan20 = numbers.SkipWhile(number => number < 20);`

###### Example
Getting the second half of a collection.  `var secondHalfOfPets = pets.Skip(pets.Count() / 2);`

```c
static void Main(string[] args)
{
  var numbers = new[] { 1, 4, 10 ,154, 999, 15 };
  var skip3Numbers = numbers.Skip(3);
}
```

```c
static void Main(string[] args)
{
  var skipLast2 = numbers.SkipLast(2);
  var skipLast2WithTake = numbers
    .Take(numbers.Count() - 2);
    //result: 1, 4, 10, 154
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\Skip.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\Skip.cs
