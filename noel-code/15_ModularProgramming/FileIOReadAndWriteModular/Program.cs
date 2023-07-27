// Program.cs
using System;
using System.IO;

namespace FileIOReadAndWriteModular
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable for the directory location.
            string directoryPath = @"C:\Users\MichaelLarsen\source\repos\cSharpAutomationCourse\14_FileIO\FileIOReadAndWriteDemoV6";

            // Create the working directory on our hard drive to read from and write to.
            Directory.CreateDirectory(directoryPath);

            // File writing using the FileWriter class
            string filePath = Path.Combine(directoryPath, "ReadAndWriteFromThisFile.txt");
            FileWriter.WriteFile(filePath);

            Console.WriteLine("File has been written successfully!");

            // File reading using the FileReader class
            FileReader.ReadFile(filePath);

            Console.WriteLine("File content displayed successfully!");

            // File appending using the FileAppender class
            FileAppender.AppendTextToFile(filePath);

            Console.WriteLine("Content has been appended to an existing file!");

            // File reading again to display the updated content
            FileReader.ReadFile(filePath);

            Console.WriteLine("Content displays original and appended info!");

            // Wait for user input before closing the console window.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
