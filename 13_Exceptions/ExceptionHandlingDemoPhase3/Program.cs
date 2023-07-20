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
            // Legitimate location for file but it's not there
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
            catch (FileNotFoundException)
            {
                Console.WriteLine("Hello beautiful user! The file you are trying to read does not exist.");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while reading the file:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
