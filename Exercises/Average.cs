using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public static class Average
    {
        //Coding Exercise 1
        /*
        Let's define a class SnowFallData that holds the information about snowfall 
        in months of a given year. For example, for the year 2020, we could have:
            *20 centimeters of snowfall in January
            *25 centimeters  in February
            *5 centimeters  in March
            *0 centimeters  in April
            *etc.  
        Implement the AverageSnowFall method that will calculate the average snowfall 
        in centimeters for a given SnowFallData object. 
        This method should return null if the object is null, 
        or its monthly snowfall data is null or the count of MonthlySnowFallDataItems 
        is not 12 (one for each month).
        */
        public static float? AverageSnowFall(SnowFallData snowFallData)
        {
            /* First Answer
            if (snowFallData == null || 
                snowFallData.MonthlySnowFallDataItems == null ||
                snowFallData.MonthlySnowFallDataItems.Count() != 12)
            {
                return null;
            }

            return snowFallData.MonthlySnowFallDataItems.Average(snowFall => snowFall.SnowfallInCentimeters);
             */

            return isValid(snowFallData) ?
                snowFallData.MonthlySnowFallDataItems.Average(
                    snowFall => snowFall.SnowfallInCentimeters) :
                null;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Validates if the monthly snow fall data is valid by checking if the
        /// SnowFallData and the SnowFallData.MonthlySnowFallDataItems is not
        /// null and the month count it 12.
        /// </summary>
        /// <param name="snowFallData">The snow fall data</param>
        /// <returns>A boolean value representing if the snow fall data is valid.</returns>
        private static bool isValid(SnowFallData snowFallData)
        {
            bool isValid = false;

            //validate null
            if (snowFallData != null &&
                snowFallData.MonthlySnowFallDataItems != null &&
                snowFallData.MonthlySnowFallDataItems.Count() == 12)
            {
                isValid = true;
            }

            return isValid;
        }

        //Coding Exercise 2
        /*
        Let's define a Student class. A student has a collection of Marks, 
        which are numbers. We could calculate the average mark for each student, 
        for example, if a student's marks are 3,4,5, 
        the average mark for this student is 4.

        Implement the MaxAverageOfMarks method, which will find the maximum average mark 
        for all students.
        For example, let's consider students:
            *Cathy has marks 4,4,6 which gives an average of 4.66
            *Martin has marks 5,5,5,3 which gives an average of 4.5
            *Bethy has marks of 6,5,5,3 which gives an average of 4.75
        For those students, the MaxAverageOfMarks method shall return 4.75, 
        as this is the maximum average mark.

        If the student list is empty, the method shall return 0. 
        If a student has no marks at all, we assume their average mark is 0.
         */
        public static double MaxAverageOfMarks(IEnumerable<Student> students)
        {
            //course answer
            return students.Any() ?
                students.Max(
                    Student => Student.Marks.Any() ?
                    Student.Marks.Average() :
                    0) :
                0;

            throw new NotImplementedException();
        }


        //Refactoring challenge
        //TODO implement this method
        public static float CalculateAverageHeight_Refactored(
            List<float?> heights, float defaultIfNull)
        {
            //course answer
            return heights == null || !heights.Any() ?
                0 :
                heights.Average(
                    height => height ?? defaultIfNull);
            throw new NotImplementedException();
        }

        //do not modify this method
        public static float CalculateAverageHeight(
            List<float?> heights, float defaultIfNull)
        {
            if (heights == null || heights.Count == 0)
            {
                return 0;
            }
            var sum = 0f;
            foreach (var height in heights)
            {
                if (height == null)
                {
                    sum += defaultIfNull;
                }
                else
                {
                    sum += height.Value;
                }
            }
            return sum / heights.Count;
        }

        public class Student
        {
            public IEnumerable<int> Marks { get; set; }
        }

        public class SnowFallData
        {
            public int Year { get; set; }
            public List<MonthlySnowFallData> MonthlySnowFallDataItems { get; set; }
        }

        public class MonthlySnowFallData
        {
            public int Month { get; set; }
            public float SnowfallInCentimeters { get; set; }
        }
    }
}
