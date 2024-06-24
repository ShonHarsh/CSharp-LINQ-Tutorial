![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 20 - Concatenate & Union

###### Definition
Concat - Concatenates two sequences.
Union - Produces the set union of two sequences.

###### Method Signature Example
`public static System.Collections.Generic.IEnumerable<TSource> Concat<TSource> (this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second);`

`public static System.Collections.Generic.IEnumerable<TSource> Union<TSource> (this System.Collections.Generic.IEnumerable<TSource> first, System.Collections.Generic.IEnumerable<TSource> second);`

###### Documentation
[Enumerable.Concat<TSource> Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.concat) 
[Enumerable.Union Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.union)

###### Notes
1. The `Concat` method does not remove duplicates.
2. The `Union` method does remove duplicates.  \o/
3. The union method respects the equality comparators.  Thus if the equals method has not been overridden then the `Union` will contain two of the "same" objects because the references are note equal.  This is explained in the `Contains` method lesson.

###### Example
Combining two collections.

```c
static void Main(string[] args)
{
  var numbers1 = new[] { 1, 3, 5, 7, 9 };
  var numbers2 = new[] { 2, 4, 6, 8, 10 };
  var concatenatedNumbers = numbers1.Concat(numbers2);
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\ConcatUnion.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\ConcatUnion.cs
