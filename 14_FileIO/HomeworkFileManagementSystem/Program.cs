using System;
using System.IO;

namespace FileManagementSystem
{
    class Program
    {
        // Define the root directory name
        static string rootDirectoryName = @"C:\Users\MichaelLarsen\source\repos\cSharpAutomationCourse\14_FileIO\HomeworkFileManagementSystem\documents";

        static void Main(string[] args)
        {
            // Check if the root directory exists, if not, create it
            if (!Directory.Exists(rootDirectoryName))
            {
                Directory.CreateDirectory(rootDirectoryName);
            }

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("File Management System");
                Console.WriteLine("1. Create a new document");
                Console.WriteLine("2. Append content to an existing document");
                Console.WriteLine("3. Create a new directory");
                Console.WriteLine("4. Move a file to a different directory");
                Console.WriteLine("5. List directory contents");
                Console.WriteLine("6. Delete a file");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateNewDocument();
                        break;
                    case 2:
                        AppendContentToDocument();
                        break;
                    case 3:
                        CreateNewDirectory();
                        break;
                    case 4:
                        MoveFileToDirectory();
                        break;
                    case 5:
                        ListDirectoryContents();
                        break;
                    case 6:
                        DeleteFile();
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void CreateNewDocument()
        {
            Console.Write("Enter the document name: ");
            string documentName = Console.ReadLine();

            Console.Write("Enter the content: ");
            string content = Console.ReadLine();

            string filePath = Path.Combine(rootDirectoryName, documentName);

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(content);
                }

                Console.WriteLine($"Document '{documentName}' created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void AppendContentToDocument()
        {
            Console.Write("Enter the name of the existing document: ");
            string documentName = Console.ReadLine();

            Console.Write("Enter the additional content: ");
            string content = Console.ReadLine();

            string filePath = Path.Combine(rootDirectoryName, documentName);

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.Write(content);
                }

                Console.WriteLine($"Content appended to '{documentName}' successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void CreateNewDirectory()
        {
            Console.Write("Enter the name of the new directory: ");
            string directoryName = Console.ReadLine();

            string directoryPath = Path.Combine(rootDirectoryName, directoryName);

            try
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine($"Directory '{directoryName}' created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void MoveFileToDirectory()
        {
            Console.Write("Enter the name of the file to move: ");
            string fileName = Console.ReadLine();

            Console.Write("Enter the name of the destination directory: ");
            string destinationDirectoryName = Console.ReadLine();

            string sourceFilePath = Path.Combine(rootDirectoryName, fileName);
            string destinationDirectoryPath = Path.Combine(rootDirectoryName, destinationDirectoryName);

            try
            {
                string destinationFilePath = Path.Combine(destinationDirectoryPath, fileName);
                File.Move(sourceFilePath, destinationFilePath);
                Console.WriteLine($"File '{fileName}' moved to '{destinationDirectoryName}' successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void ListDirectoryContents()
        {
            Console.Write("Enter the name of the directory: ");
            string directoryName = Console.ReadLine();

            string directoryPath = Path.Combine(rootDirectoryName, directoryName);

            try
            {
                string[] files = Directory.GetFiles(directoryPath);
                string[] directories = Directory.GetDirectories(directoryPath);

                Console.WriteLine($"Files in '{directoryName}':");
                foreach (string file in files)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }

                Console.WriteLine($"Subdirectories in '{directoryName}':");
                foreach (string directory in directories)
                {
                    Console.WriteLine(Path.GetFileName(directory));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static void DeleteFile()
        {
            Console.Write("Enter the name of the file to delete: ");
            string fileName = Console.ReadLine();

            string filePath = Path.Combine(rootDirectoryName, fileName);

            try
            {
                File.Delete(filePath);
                Console.WriteLine($"File '{fileName}' deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

