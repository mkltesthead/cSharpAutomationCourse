﻿using System;
using System.IO;

namespace FileIOReadAndWriteDemoV4
{
    class FileIOReadAndWrite
    {
        static void Main(string[] args)
        {
            // Create a working directory on our hard drive to read from and write to.
            string directoryPath = @"C:\dev\SDET\cSharpAutomationCourse\noel-code\14_FileIO\FileIOReadAndWriteDemoV5";
            Directory.CreateDirectory(directoryPath);

            // Call the WriteFile method to create and write to a file.
            WriteFile();

            // Display a message indicating that the file has been written successfully.
            Console.WriteLine("File has been written successfully!");

            // Call the ReadFile method to read from the file.
            ReadFile();

            // Display a message indicating that the file has been written successfully.
            Console.WriteLine("File has been displayed successfully!");

            // Call the CopyPasteText method to copy the content to a new file.
            CopyPasteText();

            // Display a message indicating that the content has been copied and pasted.
            Console.WriteLine("Content has been copied and pasted to a new file!");

            // Call the AppendTextToFile method to append text to an already created file
            AppendTextToFile();

            // Display a message indicating that the content has been copied and pasted.
            Console.WriteLine("Content has been appended to an existing file!");

            // Call the ReadFile method to read from the file.
            ReadFile();

            // Display a message indicating that the file has been written successfully.
            Console.WriteLine("Content displays original and appended info!");

            // Wait for user input before closing the console window.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static void WriteFile()
        {
            try
            {
                string filePath = Path.Combine(@"C:\dev\SDET\cSharpAutomationCourse\noel-code\14_FileIO\FileIOReadAndWriteDemoV4", "ReadAndWriteFromThisFile.txt");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write("Ensign Red Members: \n");
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
                string filePath = Path.Combine(@"C:\dev\SDET\cSharpAutomationCourse\noel-code\14_FileIO\FileIOReadAndWriteDemoV4", "ReadAndWriteFromThisFile.txt");

                using (StreamReader reader = new StreamReader(filePath))
                {
                    Console.WriteLine("Content of the file:");
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

        public static void CopyPasteText()
        {
            try
            {
                string sourceFilePath = Path.Combine(@"C:\dev\SDET\cSharpAutomationCourse\noel-code\14_FileIO\FileIOReadAndWriteDemoV4", "ReadAndWriteFromThisFile.txt");
                string destinationFilePath = Path.Combine(@"C:\dev\SDET\cSharpAutomationCourse\noel-code\14_FileIO\FileIOReadAndWriteDemoV4", "CopyTextToThisFile.txt");

                using (StreamReader reader = new StreamReader(sourceFilePath))
                using (StreamWriter writer = new StreamWriter(destinationFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while copying and pasting the content:");
                Console.WriteLine(e.Message);
            }
        }

        public static void AppendTextToFile()
        {
            try
            {
                string filePath = Path.Combine(@"C:\dev\SDET\cSharpAutomationCourse\noel-code\14_FileIO\FileIOReadAndWriteDemoV4", "ReadAndWriteFromThisFile.txt");

                // Use the StreamWriter constructor with the append parameter set to true.
                // This will open the file in append mode, allowing new content to be added at the end of the file.
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Use the WriteLine method to append data to the file.
                    writer.WriteLine("Ensign Red Releases:");
                    writer.WriteLine("EP: Behind the Ramparts");
                    writer.WriteLine("Single: So I Bleed");
                    writer.WriteLine("Single: From the Shadows");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while appending to the file:");
                Console.WriteLine(e.Message);
            }
        }
    }
}