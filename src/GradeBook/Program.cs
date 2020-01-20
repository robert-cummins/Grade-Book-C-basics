using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
             

            var grades = new List<double>(){12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);
            
            var lowGrade = double.MaxValue;
            var highGrade = double.MinValue;
            var result = 0.0;
            foreach(double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result = result / grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"The Highest grade is {highGrade:N1}");
            Console.WriteLine($"The lowest grade is {lowGrade:N1}");

        }
    }
}
