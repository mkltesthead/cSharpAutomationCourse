using System;
using System.IO;

namespace FileIOReadAndWriteDemo
{
    class FileIOReadAndWrite
    {
        static void Main()
        {
            // Create a working directory on our hard drive to read from and write to.
            string directoryPath = @"C:\Users\MichaelLarsen\source\repos\cSharpAutomationCourse\14_FileIO\ReadAndWriteFromHere";
            Directory.CreateDirectory(directoryPath);

            // Call the writeFile method to create and write to a file.
            WriteFile();

            // Display a message indicating that the file has been written successfully.
            Console.WriteLine("File has been written successfully!");

            // Wait for user input before closing the console window.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static void WriteFile()
        {
            try
            {
                // Combine the directory path and file name for the file.
                string filePath = Path.Combine(@"C:\Users\MichaelLarsen\source\repos\cSharpAutomationCourse\14_FileIO\ReadAndWriteFromHere", "ReadAndWriteFile.txt");

                // Create a new instance of StreamWriter named writer.
                // The StreamWriter class is used to write characters to a file.
                // We use the "using" statement to automatically close the writer after writing.
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Use the Write method to write data to the file.
                    // Each call to Write writes the data to the file without a new line.
                    // Experiment with different formatting options such as New Lines or Spaces
                    writer.Write("Michael Larsen \n");
                    writer.Write("Victor Jones \n");
                    writer.Write("Brian Horban \n");
                    writer.Write("Lloyd Ellis \n");
                    writer.Write("Edward Scott \n");
                }

                // Note: The StreamWriter automatically flushes the buffer and writes the data to the file.

                // Note: In C#, we use StreamWriter to handle buffering and write efficiently, so we don't need
                // a separate BufferedWriter class like in Java.
            }
            catch (IOException e)
            {
                // If an exception occurs during file writing, print the error details.
                Console.WriteLine("An error occurred while writing to the file:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
