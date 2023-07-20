using System;
using System.IO;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateFile();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void CreateFile()
        {
            // File path where the program might not have permission to create files
            // or the directory path doesn't exist.
            string filePath = @"C:\some_nonexistent_directory\newfile.txt";

            try
            {
                // Create the file
                System.IO.File.Create(filePath);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized Access Exception: The program does not have permission to create the file in the specified location.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory Not Found Exception: The specified directory path does not exist.");
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred while creating the file:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
