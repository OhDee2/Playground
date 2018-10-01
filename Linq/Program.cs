using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Linq
{
    internal class Program
    {
        private static void Main()
        {
            ProblemOne();
            ProblemTwo();
            ProblemThree();

            Console.ReadLine();
        }

        private static void ProblemOne()
        {
            //1.Write a program in C# Sharp to shows how the three parts of a query operation execute. Go to the editor
            //    Expected Output:
            //The numbers which produce the remainder 0 after divided by 2 are:
            //0 2 4 6 8
            Console.WriteLine("Problem One :");

            var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var query = numbers.Where(n => n % 2 == 0).Select(n => n);

            Action<int> write = Console.WriteLine;

            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext())
            {
                write(enumerator.Current);
            }
        }

        private static void ProblemTwo()
        {
            //Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.Go to the editor
            //    Expected Output:
            //The numbers within the range of 1 to 11 are:
            //1 3 6 9 10

            Console.WriteLine("Problem Two :");


            var numbers = new List<int> { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var query = numbers
                .Where(n => n > 0)
                .Where(n => n < 12)
                .Select(n => n);

            Action<int> write = Console.WriteLine;

            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext())
            {
                write(enumerator.Current);
            }
        }

        private static void ProblemThree()
        {
            // Write a program in C# Sharp to find the number of an array and the square of each number
            Console.WriteLine("Problem Three :");

            var numbers = new List<int> {3, 9, 2, 8, 6, 5};

            var query = numbers.Select(n => n * n);

            Action<int> write = Console.WriteLine;

            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext())
            {
                write(enumerator.Current);
            }
        }
    }
}
