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
                File.Create(filePath);
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Unauthorized Access Exception: The program does not have permission to create the file in the specified location.");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory Not Found Exception: The specified directory path does not exist.");
<<<<<<< HEAD
                Console.WriteLine(ex.Message);
=======
                Console.WriteLine($"\r\nData ({ex.Data.Count}): " + string.Join("\r\n", ex.Data));
                Console.WriteLine("\r\nHelpLink: " + ex.HelpLink);
                Console.WriteLine("\r\nHResult: " + ex.HResult);
                //Console.WriteLine("\r\nInnerException: " + ex.InnerException.Message);
                Console.WriteLine("\r\nMessage: " + ex.Message);
                Console.WriteLine("\r\nStackTrace: " + ex.StackTrace);
                Console.WriteLine("\r\nSource: " + ex.Source);
                Console.WriteLine("\r\nTargetSite: " + ex.TargetSite.ToString());
>>>>>>> 10f084f8ef0a900a00fb19350ccd01b73b371d1c
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred while creating the file:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
