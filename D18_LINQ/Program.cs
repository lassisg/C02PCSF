//https://docs.microsoft.com/en-us/dotnet/csharp/linq/write-linq-queries

using D00_Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace D18_LINQ
{

    class Program
    {

        static void Main(string[] args)
        {

            Utils.PrintHeader("LINQ");

            #region Query Syntax

            Utils.PrintSubHeader("Query Syntax");

            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Query #1.
            // IEnumerable --> interface
            IEnumerable<int> filteringQuery =
                from num in numbers
                where num < 3 || num >= 7
                select num;

            foreach (var item in filteringQuery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Query #2.
            var orderingQuery =
                from num in numbers
                where num < 3 || num > 7
                orderby num ascending
                select num;

            foreach (var item in orderingQuery)
            {
                Console.WriteLine(item);
            }
            
            Utils.CleanConsole();

            #endregion

            #region Method Syntax

            Utils.PrintSubHeader("Method Syntax");

            List<int> numbers1 = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            List<int> numbers2 = new List<int>() { 15, 14, 11, 13, 19, 18, 16, 17, 12, 10 };

            // Query #3.
            double average = numbers1.Average();

            Console.WriteLine(average);

            Console.WriteLine();

            // Query #4.
            IEnumerable<int> numbersConcatenated = numbers1.Concat(numbers2);

            foreach (var item in numbersConcatenated)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Query #5.
            var numbersGreaterThan15 = numbers2.Where(c => c > 15).OrderBy(c => c);

            foreach (var item in numbersGreaterThan15)
            {
                Console.WriteLine(item);
            }

            Utils.CleanConsole();

            #endregion

            #region LINQ tests

            List<int> numbers3 = new List<int>() { 1, 2, 3, 4, 5 };

            Utils.PrintSubHeader("LINQ tests | Skip");

            Console.WriteLine("List");
            foreach (var item in numbers3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nSkipped 3 List");
            var afterSkip = numbers3.Skip(3);
            foreach (var item in afterSkip)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nSkipped 10 List");
            afterSkip = numbers3.Skip(10);
            foreach (var item in afterSkip)
            {
                Console.WriteLine(item);
            }

            Utils.PrintSubHeader("LINQ tests | Take");

            Console.WriteLine("List");
            foreach (var item in numbers3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTaken 3 List");
            var afterTake = numbers3.Take(3);
            foreach (var item in afterTake)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTaken 10 List");
            afterTake = numbers3.Take(10);
            foreach (var item in afterTake)
            {
                Console.WriteLine(item);
            }

            Utils.CleanConsole();

            #endregion

        }

    }

}