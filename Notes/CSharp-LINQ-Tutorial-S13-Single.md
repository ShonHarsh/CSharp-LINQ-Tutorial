![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 13 - Single

###### Definition
Single - Returns a single, specific element of a sequence.

###### Method Signature Example
public static TSource Single<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, Func<TSource,bool> predicate);

###### Documentation
[Enumerable.Single Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.single)

###### Notes
1. If no such element exists in the collection, an exception will be thrown.
2. The `Single` method can be used with skipping the parameter on a collection of size 1.
3. A `Single` method will throw an error if no elements or multiple elements match the condition.
4. When using the `Single` method, be sure that there is only one element that matches the predicate.
5. The `SingleOrDefault` method retuns the default value if there are no matching elements.
6. The `SingleOrDefault` will still throw an error if there are multiple matching elements.

###### Example
Select a `Single` element equal to 16.

```c
static void Main(string[] args)
{
  var numbers = new{} { 16, 8, 9, -1, 2};

  var singleLargerThan100 = numbers
    .Single(number => number > 100);

    //throws an error - Sequence contains more than one matching element
    var singleLargerThan100 = numbers
      .Single(number => number > 15);
}
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\Single.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\Single.cs
