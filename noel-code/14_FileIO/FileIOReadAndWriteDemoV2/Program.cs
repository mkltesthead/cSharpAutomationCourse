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

            string filePath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), @"..\..");

            Console.WriteLine(filePath);

            //filePath = System.IO.Directory.GetParent((string)filePath);

            //Console.WriteLine(filePath);

            // Call the WriteFile method to create and write to a file.
            WriteFile(directoryPath);

            // Display a message indicating that the file has been written successfully.
            Console.WriteLine("File has been written successfully!");

            // Call the ReadFile method to read from the file.
            ReadFile(directoryPath);

            // Wait for user input before closing the console window.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static void WriteFile(string directoryPath)
        {
            try
            {
                string filePath = Path.Combine(directoryPath, "ReadAndWriteFromThisFile.txt");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Lloyd Ellis");
                    writer.WriteLine("Brian Horban");
                    writer.WriteLine("Victor Jones");
                    writer.WriteLine("Michael Larsen");
                    writer.WriteLine("Edward Scott");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while writing to the file:");
                Console.WriteLine(e.Message);
            }
        }

        public static void ReadFile(string directoryPath)
        {
            try
            {
                string filePath = Path.Combine(directoryPath, "ReadAndWriteFromThisFile.txt");

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