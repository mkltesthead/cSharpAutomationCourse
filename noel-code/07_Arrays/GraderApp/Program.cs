using System;

namespace GraderApp
{
    class Grader
    {
        private static int[] grades;

        static void Main(string[] args)
        {
            Console.WriteLine("Grader App");
            Console.WriteLine();

            GetGrades();
            Console.WriteLine();

            int sum = CalculateSum();
            double average = CalculateAverage();
            int highestGrade = GetHighestGrade();
            int lowestGrade = GetLowestGrade();

            Console.WriteLine("Grades Summary:");
            Console.WriteLine("Total Grades: " + grades.Length);
            Console.WriteLine("Sum of Grades: " + sum);
            Console.WriteLine("Average Grade: " + average);
            Console.WriteLine("Highest Grade: " + highestGrade);
            Console.WriteLine("Lowest Grade: " + lowestGrade);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void GetGrades()
        {
            Console.Write("Enter the number of grades: ");
            int numGrades = int.Parse(Console.ReadLine());

            grades = new int[numGrades];

            for (int i = 0; i < numGrades; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                grades[i] = int.Parse(Console.ReadLine());
            }
        }

        static int CalculateSum()
        {
            int sum = 0;
            foreach (int grade in grades)
            {
                sum += grade;
            }
            return sum;
        }

        static double CalculateAverage()
        {
            int sum = CalculateSum();
            double average = (double)sum / grades.Length;
            average = Math.Round(average, 2); // Round to two significant digits
            return average;
        }

        static int GetHighestGrade()
        {
            int highestGrade = grades[0];
            foreach (int grade in grades)
            {
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                }
            }
            return highestGrade;
        }

        static int GetLowestGrade()
        {
            int lowestGrade = grades[0];
            foreach (int grade in grades)
            {
                if (grade < lowestGrade)
                {
                    lowestGrade = grade;
                }
            }
            return lowestGrade;
        }
    }
}
