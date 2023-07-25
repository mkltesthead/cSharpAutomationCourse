using System;
using System.IO;

namespace FileIOReadAndWriteDemoV2
{
    class FileIOReadAndWrite
    {
        static void Main()
        {
            // Create a working directory on our hard drive to read from and write to.
            string directoryPath = @"C:\dev\SDET\cSharpAutomationCourse\noel-code\14_FileIO\FileIOReadAndWriteDemoV2";
            Directory.CreateDirectory(directoryPath);

            // Call the WriteFile method to create and write to a file.
            WriteFile();

            // Display a message indicating that the file has been written successfully.
            Console.WriteLine("File has been written successfully!");

            // Call the ReadFile method to read from the file.
            ReadFile();

            // Wait for user input before closing the console window.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static void WriteFile()
        {
            try
            {
                string filePath = Path.Combine(@"C:\dev\SDET\cSharpAutomationCourse\noel-code\14_FileIO\FileIOReadAndWriteDemoV2", "ReadAndWriteFromThisFile.txt");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write("Lloyd Ellis \n");
                    writer.Write("Brian Horban\n");
                    writer.Write("Victor Jones\n");
                    writer.Write("Michael Larsen\n");
                    writer.Write("Edward Scott\n");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while writing to the file:");
                Console.WriteLine(e.Message);
            }
        }

        public static void ReadFile()
        {
            try
            {
                string filePath = Path.Combine(@"C:\Users\MichaelLarsen\source\repos\cSharpAutomationCourse\14_FileIO\FileIOReadAndWriteDemoV2", "ReadAndWriteFromThisFile.txt");

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
