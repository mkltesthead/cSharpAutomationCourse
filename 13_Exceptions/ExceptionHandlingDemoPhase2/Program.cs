using System;

namespace ExceptionHandlingDemoPhase2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFile();
        }

        static void CreateFile()
        {
            // A legitimate file path for Windows (you can use forward slashes in C# too)
            string filePath = @"C:\Users\MichaelLarsen\source\repos\cSharpAutomationCourse\13_Exceptions\ExceptionHandlingDemoPhase2\test_file_create.txt";

            try
            {
                // Create the file
                System.IO.File.Create(filePath);
                Console.WriteLine("Hey, congratulations, you can create this file!");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hello beautiful user! An error occurred while creating the file.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
