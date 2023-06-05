![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

# LINQ Tutorial: Master The Key C# Library

##### Author: Krystyna Ślusarczyk

### Section 19 - Prepend & Append

###### Definition
Append - Appends a value to the end of the sequence.  
Prepend - Adds a value to the beginning of the sequence.

###### Method Signature Example
`public static System.Collections.Generic.IEnumerable<TSource> Append<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, TSource element);`

`public static System.Collections.Generic.IEnumerable<TSource> Prepend<TSource> (this System.Collections.Generic.IEnumerable<TSource> source, TSource element);`

###### Documentation
[Enumerable.Append<TSource>(IEnumerable<TSource>, TSource) Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.append)  
[Enumerable.Prepend<TSource>(IEnumerable<TSource>, TSource) Method](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.prepend)

###### Notes
1. The origional collection is not modified.

###### Example
Add an elemnt to the end of a collection.

```c
static void Main(string[] args)
{
  IEnumerable<int> numbers = new[] { 10, 1, 4, 17, 122 };
  //prints 99, 10, 1, 4, 17, 122
  var samplePrepend = numbers.Prepend(99);
  //prints 10, 1, 4, 17, 122, 100
  var sampleAppend = numbers.Append(100);
}
```

```c
var originalGrades = new[] { "Bad", "Medium", "Good" };
//prints Terrible, Bad, Medium, Good, Excellent
var newGrades = originalGrades.Prepend("Terrible").Append("Excellent");
```

##### Visual Studio - Code Examples

LinqTutorial\Exercises\PrependAppend.cs

##### Visual Studio - Code Exercises

LinqTutorial\Exercises\PrependAppend.cs
