![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-02.png)

### IsAnyWordUppercase Example

A method written in expanded C# compared to the same method written in LINQ.

```c
//
using System;
using System.Collections.Geneic;
using System.Linq;

namespace CSharp-LINQ-Tutorial
{
  class Program
  {
    static void Main(string[] args)
    {
      var wordsNoUppercase = new string[]
      {
        "quick", "brown", "fox"
      };
      Console.WriteLine("WordsNoUppercase: " + IsAnyWordUppercase(wordsNoUppercase));

      var wordsWithUppercase = new string[]
      {
        "quick", "brown", "FOX"
      };
      Console.WriteLine("WordsWithUppercase: " + IsAnyWordUppercase(wordsWithUppercase));

      Console.ReadKey();
    }
  }

  public static bool IsAnyWordUppercase_LINQ(
    IEnumerable<string> words)
  {
    return words.Any(word =>
      word.All(letter => char.IsUpper(letter)));
  }

  public static bool IsAnyWordUppercase(
  IEnumerable<string> words)
  {
    forreach(var worrd in words)
    {
      bool areAllUpperCase = true;
      foreach(var letter in word)
      {
        if (char.IsLower(letter) == true)
        {
          areAllUpperCase = false;
        }
      }
      if (areAllUpperCase == true)
      {
        return true;
      }
      areAllU
    }
  }

  return false;
}
```
