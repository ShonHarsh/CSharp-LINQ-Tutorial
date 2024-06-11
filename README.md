![UiPath](https://shonharsh.github.io/curriculum-vitae/Images/GitHub-Banner-CSharp-01.png)

# CSharp-LINQ-Tutorial

This project contains resources for the class [LINQ Tutorial: Master the Key C# Library](https://www.udemy.com/course/linq-tutorial-master-the-key-csharp-library/?referralCode=384B340D233F12F6A498) authored by Krystyna Ślusarczyk.

## Course Thoughts

I am still working on the course but can already say that it is **extremely good!**  I have learned a lot about LINQ and C# already.  I am so impressed that am going to purchase all of Krystyna's courses.  I very much appreciate the work that Krystyna has put into the material.  There are many practices and code tests.

> [!WARNING]
> This repository is not forked.  Take note because it may not have updates from the source.  I chose to duplicate it locally because I did not want to inadvertently create a pull request back to the course files while I was working.

> [!Note]
> The course repository is located [LinqTutorialNet6
](https://github.com/KrystynaSlusarczykLearning/LinqTutorialNet6)

## FAQ:

### Q1: How do I download the files?
A: If you're not familiar with GitHub and just want to download the entire solution, click the green button saying "Code", and then select the "Download ZIP".

### Q2: What are the projects in this solution?
A: The solution consists of 4 main projects:
#### LinqTutorial
Contains the code shown in the course's videos.
#### Exercises
Contains coding exercises that you can solve to practice LINQ.
#### ExercisesSolutions
Contains solved versions of the coding exercises. You can take a look at them to check how some exercise can be solved.
#### ExercisesTests
Contains unit tests which validate if your solutions of exercises are correct (the solutions from the Exercises project are validated).

### Q3: How to approach solving coding exercises?
Let's say you want to practice using the Any method from LINQ. Go to Exercises project and open Any.cs file.

If you want to solve coding exercise 1, find the method with a comment describing what this method should do.

Before you solve the exercise, you can run unit tests that validate if it is correct. To do it, build the solution first. Then you can click on Test in the top menu of Visual Studio, and then Run All Test. In the Test Explorer window that will be open, you can unfold the list of tests that has been run. The tests for the Any should fail, because you haven't yet implement it.The failed tests are marked in red.

You can also run or debug a single test, which is described in the next point.

Now, you can implement the method, so it does what the description of the exercise says. If your solution is correct, and you run the tests again, you will see that tests for the first exercise for the Any method should pass, and they will be marked in green.

### Q3: How to debug the code of the coding exercise?
Place a breakpoint in the place that you are interested in.

Now, find the unit test that you want to run. To run it in the Debug mode, you can either right-click on it the the Test Explorer and select debug, or you can left click on the test marker just at the test body and select debug. Both places are shown in the image:

![image](https://user-images.githubusercontent.com/89634343/218571108-b4cf876b-45a9-4c20-be73-1efd44dee9ad.png)
