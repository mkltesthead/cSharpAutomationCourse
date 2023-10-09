namespace File_Management_Solution
{
    internal class Program
    {

        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();

            while (true)
            {
                Console.WriteLine("File Management System:\n");
                Console.WriteLine("1. Create a new document");
                Console.WriteLine("2. Append content to an existing document");
                Console.WriteLine("3. Create a new directory");
                Console.WriteLine("4. Move a file to a different directory");
                Console.WriteLine("5. List directory contents");
                Console.WriteLine("6. Delete a file");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice (1-7): ");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        fileManager.CreateDocument();
                        break;
                    case 2:
                        fileManager.AppendToDocument();
                        break;
                    case 3:
                        fileManager.CreateDirectory();
                        break;
                    case 4:
                        fileManager.MoveFile();
                        break;
                    case 5:
                        fileManager.ListDirectoryContents();
                        break;
                    case 6:
                        fileManager.DeleteFile();
                        break;
                    case 7:
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Please select a valid option between 1-7.");
                        break;
                }
            }
        }
    }

    class FileManager
    {
        private const string RootDirectory = "documents";

        public FileManager()
        {
            // Create the root directory if doesn't exists
            if (!Directory.Exists(RootDirectory))
            {
                Directory.CreateDirectory(RootDirectory);
            }
        }

        public void CreateDocument()
        {
            Console.Write("Enter the document name: ");
            string documentName = Console.ReadLine();


            Console.Write("Enter the document content: ");
            string content = Console.ReadLine();

            string filePath = Path.Combine(RootDirectory, documentName);

            File.WriteAllText(filePath, content);

            Console.WriteLine($"Document '{documentName}' is created successfully.");

        }

        public void AppendToDocument()
        {
            Console.Write("Enter the name of an existing document: ");
            string documentName = Console.ReadLine();

            string filePath = Path.Combine(RootDirectory, documentName);

            if (File.Exists(filePath))
            {
                Console.Write("Enter additional content to append: ");
                string additionalContent = Console.ReadLine();

                File.AppendAllText(filePath, additionalContent);

                Console.WriteLine($"Content appended to '{documentName}' successfully.");
            }
            else
            {
                Console.WriteLine($"Document '{documentName}' not found.");
            }
        }

        public void CreateDirectory()
        {
            Console.Write("Enter the name of new directory: ");
            string directoryName = Console.ReadLine();

            string directoryPath = Path.Combine(RootDirectory, directoryName);

            Directory.CreateDirectory(directoryPath);

            Console.WriteLine($"Directory '{directoryName}' is created successfully.");
        }



        public void MoveFile()
        {
            Console.Write("Enter the name of the file to move: ");
            string sourceFileName = Console.ReadLine();

            string sourceFilePath = Path.Combine(RootDirectory, sourceFileName);

            if (File.Exists(sourceFilePath))
            {
                Console.Write("Enter the name of the destination directory: ");
                string destinationDirectoryName = Console.ReadLine();

                string destinationDirectoryPath = Path.Combine(RootDirectory, destinationDirectoryName);


                if (!Directory.Exists(destinationDirectoryPath))
                {
                    Directory.CreateDirectory(destinationDirectoryPath);
                }

                string destinationFilePath = Path.Combine(destinationDirectoryPath, sourceFileName);


                File.Move(sourceFilePath, destinationFilePath);

                Console.WriteLine($"File '{sourceFileName}' moved to '{destinationDirectoryName}' successfully.");
            }
            else
            {
                Console.WriteLine($"File '{sourceFileName}' not found.");
            }
        }

        public void ListDirectoryContents()
        {
            Console.Write("Enter the name of directory: ");
            string directoryName = Console.ReadLine();

            string directoryPath = Path.Combine(RootDirectory, directoryName);

            if (Directory.Exists(directoryPath))
            {
                Console.WriteLine($"Contents of directory '{directoryName}':");

                string[] files = Directory.GetFiles(directoryPath);
                foreach (var file in files)
                {
                    Console.WriteLine($"File: {Path.GetFileName(file)}");
                }

                // List subdirectories in the directory
                string[] subdirectories = Directory.GetDirectories(directoryPath);
                foreach (var subdirectory in subdirectories)
                {
                    Console.WriteLine($"Directory: {Path.GetFileName(subdirectory)}");
                }
            }
            else
            {
                Console.WriteLine($"Directory '{directoryName}' not found.");
            }
        }

        public void DeleteFile()
        {
            Console.Write("Enter the name of a file to delete: ");
            string fileName = Console.ReadLine();

            string filePath = Path.Combine(RootDirectory, fileName);

            if (File.Exists(filePath))
            {

                File.Delete(filePath);

                Console.WriteLine($"File '{fileName}' is deleted successfully.");
            }
            else
            {
                Console.WriteLine($"File '{fileName}' not found.");
            }
        }
    }

}
