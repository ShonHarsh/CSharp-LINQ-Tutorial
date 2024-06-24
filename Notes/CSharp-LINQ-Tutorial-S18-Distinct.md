![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 18 - Distinct

###### Definition
Distinct - Returns distinct elements from a sequence.

###### Method Signature Example
`public static System.Collections.Generic.IEnumerable<TSource> Distinct<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, System.Collections.Generic.IEqualityComparer<TSource>? comparer);`

###### Documentation
[Enumerable.Distinct Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinct)

###### Notes
1. The `Disctinct` method removes all duplicate values from a collection returning a unique collection.
2. C# references equality differently for base types and reference types.  Thus a `Distinct` method on a collection of pets will not remove the pets because they have different references.
3. Reference the contains method to review the  base types and reference types differences.
4. There is an overloaded distinct method where a comparer method can be passed in.  This can be used to compare reference type objects.

###### Example
Removing duplicate integers from an array.

```c
static void Main(string[] args)
{
  var numbers = new[] { 10, 1, 10, 4, 17, 17, 122 };
  var numbersNoDuplicates = numbers.Distinct();
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\Distinct.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\Distinct.cs
