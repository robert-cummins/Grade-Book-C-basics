using System;
using System.Collections.Generic;

namespace  GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void showStatistics()
        {
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
        private List<double> grades;
        private string name;
    }
}