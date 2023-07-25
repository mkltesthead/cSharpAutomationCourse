namespace FileIOReadAndWriteDemoV2
{
    class FileIOReadAndWrite
    {
        static void Main()
        {
            // Create a working directory on our hard drive to read from and write to.
            string directoryPath = @"C:\Users\u1173906\OneDrive - MMC\Documents\SDET BootCamp\C sharp\CSharp Git repository\cSharpAutomationCourse\sneha-code\ExampleFileIOReadWriteDemoV2";
            Directory.CreateDirectory(directoryPath);

            // Call the WriteFile method to create and write to a file.
            WriteFile(directoryPath);

            // Display a message indicating that the file has been written successfully.
            Console.WriteLine("File has been written successfully!");

            // Call the ReadFile method to read from the file.
            ReadFile(directoryPath);

            // Display a message indicating that the file has been read successfully.
            Console.WriteLine("File was read successfully!");

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
