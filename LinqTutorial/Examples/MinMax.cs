using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using Utilities;

namespace LinqTutorial
{
    static class MinMax
    {
        //System.Linq.Enumerable.Min
        //System.Linq.Enumerable.Max
        public static void Run()
        {
            var numbers = new[] { 10, 1, 4, 17, 122 };

            //Min returns the minimal number in the collection
            var minNumber = numbers.Min();
            Console.WriteLine($"minNumber: {minNumber}");

            //we can select some particular numeric value from a collection of objects
            var lightestPetWeight = Data.Pets.Min(pet => pet.Weight);
            Console.WriteLine($"lightestPetWeight: {lightestPetWeight}");

            //Max works the same, but it returns the maximal number
            var maxNumber = numbers.Max();
            Printer.Print(maxNumber, nameof(maxNumber));

            var heaviestPetsWeight = Data.Pets.Max(pet => pet.Weight);
            Console.WriteLine($"heaviestPetsWeight: {heaviestPetsWeight}");

            IEnumerable<string> words = new string[] {"aaa", "bb", "c", "dddd"};
            int LengthOfTheShortestWord = words.Min(word => word.Length);
            Console.WriteLine("LengthOfTheShortestWord: " + LengthOfTheShortestWord.ToString());
            

            //if we don't pass the selector when finding
            //Min or Max of the collection that does not
            //implement the IComparable interface
            //an exception will be thrown
            //var minPet = Data.Pets.Min();

            //Min and Max will throw an exception if the collection is empty
            //that's why the below code will not work
            //var emptyPetsCollection = new Pet[0];
            //var lightestPetsWeight = emptyPetsCollection.Min(pet => pet.Weight);
        }
    }
}
