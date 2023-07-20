using System;
using System.IO;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberExceptionHandling();
        }

        static void NumberExceptionHandling()
        {
            string filePath = @"C:\Users\MichaelLarsen\source\repos\cSharpAutomationCourse\13_Exceptions\ExceptionHandlingDemoPhase3\numbers.txt";

            try
            {
                using (StreamReader fileReader = new StreamReader(filePath))
                {
                    while (!fileReader.EndOfStream)
                    {
                        string line = fileReader.ReadLine();
                        if (double.TryParse(line, out double number))
                        {
                            Console.WriteLine(number);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid number format in the file: {line}");
                        }
                    }
                }
            }
            catch (Exception e) when (e is FileNotFoundException || e is FormatException)
            {
                Console.WriteLine("An error occurred while reading the file:");
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}

