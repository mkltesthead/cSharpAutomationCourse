namespace FileIOReadAndWriteDemo
{
    class FileIOReadAndWrite
    {
        static void Main()
        {
            // Create a working directory on our hard drive to read from and write to.
            string directoryPath = @"C:\Users\u1173906\OneDrive - MMC\Documents\SDET BootCamp\C sharp\CSharp Git repository\cSharpAutomationCourse\sneha-code\ExampleFileIOReadWriteDemo\DemoReadWriteFile";
            Directory.CreateDirectory(directoryPath);

            // Call the writeFile method to create and write to a file.
            WriteFile(directoryPath);

            // Display a message indicating that the file has been written successfully.
            Console.WriteLine("File has been written successfully!");

            // Wait for user input before closing the console window.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static void WriteFile(string DirectoryPath)
        {
            try
            {
                // Combine the directory path and file name for the file.
                string filePath = Path.Combine(DirectoryPath, "ReadAndWriteFile.txt");

                // Create a new instance of StreamWriter named writer.
                // The StreamWriter class is used to write characters to a file.
                // We use the "using" statement to automatically close the writer after writing.
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Use the Write method to write data to the file.
                    // Each call to Write writes the data to the file without a new line.
                    // Experiment with different formatting options such as New Lines or Spaces
                    writer.Write("Mango\n");
                    writer.Write("Banana\n");
                    writer.Write("Peach\n");
                    writer.Write("Water\tMelon\n");
                    writer.Write("Apple");
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
