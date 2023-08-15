namespace AssignmentFileIO
{
    using System;
    using System.IO;

    namespace FileManagementSystem
    {
        class Program
        {
            // Define the root directory name
            static string rootDirectory = @"C:\Users\u1173906\OneDrive - MMC\Documents\SDET BootCamp\C sharp\CSharp Git repository\cSharpAutomationCourse\sneha-code\AssignmentFileIO\TestDirectory";

            static void Main(string[] args)
            {
                // Check if the root directory exists, if not, create it
                if (!Directory.Exists(rootDirectory))
                {
                    Directory.CreateDirectory(rootDirectory);
                }

                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("File Management System");
                    Console.WriteLine("1. Create a new document");
                    Console.WriteLine("2. Append content to existing document");
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
                            createNewDocument();
                            break;
                        case 2:
                            appendContentToDocument();
                            break;
                        case 3:
                            createNewDirectory();
                            break;
                        case 4:
                            moveFileToDirectory();
                            break;
                        case 5:
                            listDirectoryContents();
                            break;
                        case 6:
                            deleteFile();
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

            static void createNewDocument()
            {
                Console.Write("Enter the document name: ");
                string document = Console.ReadLine();

                Console.Write("Enter the text: ");
                string text = Console.ReadLine();

                string filePath = Path.Combine(rootDirectory, document);

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(text);
                    }

                    Console.WriteLine($"Document '{document}' created successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            static void appendContentToDocument()
            {
                Console.Write("Enter the name of the existing document: ");
                string document = Console.ReadLine();

                Console.Write("Enter the additional text: ");
                string text = Console.ReadLine();

                string filePath = Path.Combine(rootDirectory, document);

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.Write(text);
                    }

                    Console.WriteLine($"Content appended to '{document}' successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            static void createNewDirectory()
            {
                Console.Write("Enter the name of the new directory: ");
                string directory = Console.ReadLine();

                string directoryPath = Path.Combine(rootDirectory, directory);

                try
                {
                    Directory.CreateDirectory(directoryPath);
                    Console.WriteLine($"Directory '{directory}' created successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            static void moveFileToDirectory()
            {
                Console.Write("Enter the name of the file to move: ");
                string fileName = Console.ReadLine();

                Console.Write("Enter the name of the destination directory: ");
                string destinationDirectory = Console.ReadLine();

                string sourceFilePath = Path.Combine(rootDirectory, fileName);
                string destinationDirectoryPath = Path.Combine(rootDirectory, destinationDirectory);

                try
                {
                    string destinationFilePath = Path.Combine(destinationDirectoryPath, fileName);
                    File.Move(sourceFilePath, destinationFilePath);
                    Console.WriteLine($"File '{fileName}' moved to '{destinationDirectory}' successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            static void listDirectoryContents()
            {
                Console.Write("Enter the name of the directory: ");
                string directory = Console.ReadLine();

                string directoryPath = Path.Combine(rootDirectory, directory);

                try
                {
                    string[] files = Directory.GetFiles(directoryPath);
                    string[] directories = Directory.GetDirectories(directoryPath);

                    Console.WriteLine($"Files in '{directory}':");
                    foreach (string file in files)
                    {
                        Console.WriteLine(Path.GetFileName(file));
                    }

                    Console.WriteLine($"Subdirectories in '{directory}':");
                    foreach (string dir in directories)
                    {
                        Console.WriteLine(Path.GetFileName(dir));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            static void deleteFile()
            {
                Console.Write("Enter the name of the file to delete: ");
                string fileName = Console.ReadLine();

                string filePath = Path.Combine(rootDirectory, fileName);

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


}