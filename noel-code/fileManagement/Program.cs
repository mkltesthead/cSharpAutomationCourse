using System;
using System.IO;

namespace fileManagement
{
    internal class FileManagement
    {
        static void Main(string[] args)
        {
            // Create a working directory on our hard drive to read from and write to.
            string directoryPath = @"C:\dev\SDET\cSharpAutomationCourse\noel-code\fileManagement\documents";
            Directory.CreateDirectory(directoryPath);

            // Call WriteFile to create and write to a file.
            CreateFile(directoryPath);

            // Call AppendFile to append text to an already created file
            AppendFile(directoryPath);

            // Call CreateDirectory to create a new directory in directoryPath
            CreateDirectory(directoryPath);
            Console.WriteLine();

            // Call MoveFile to move a file to a different directory
            MoveFile(directoryPath);
            Console.WriteLine();

            // Call ListDirectory to move a file to a different directory
            ListDirectory(directoryPath);
            Console.WriteLine();

            // Call DeleteFile to delete a file
            DeleteFile(directoryPath);
            Console.WriteLine();

            // Wait for user input before closing the console window.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public static void CreateFile(string directoryPath)
        {
            try
            {
                string fileName = getInput("Please enter the file name.");
                string filePath = Path.Combine(directoryPath, fileName);

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    string line;
                    while (true)
                    {
                        line = getInput("Please enter the next line or enter to quit.");
                        if (line == "")
                        {
                            break;
                        }
                        writer.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while writing to the file:");
                Console.WriteLine(e.Message);
            }
        }

        public static void AppendFile(string directoryPath)
        {
            try
            {
                string fileName;
                string filePath;
                while (true)
                {
                    fileName = getInput("Please enter the name of the file to which you would like to append text.");
                    filePath = Path.Combine(directoryPath, fileName);
                    if (File.Exists(filePath))
                    {
                        break;
                    }
                    Console.WriteLine($"There is no {fileName} file in {directoryPath}.");
                }

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    string line;
                    while (true)
                    {
                        line = getInput("Please enter the next line or enter to quit.");
                        if (line == "")
                        {
                            break;
                        }
                        writer.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while appending to the file:");
                Console.WriteLine(e.Message);
            }
        }

        public static void CreateDirectory(string directoryPath)
        {
            try
            {
                string dirName = getInput("Please enter the name of the directory you would like to create.");
                string dirPath = Path.Combine(directoryPath, dirName);
                Directory.CreateDirectory(dirPath);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while creating the directory:");
                Console.WriteLine(e.Message);
            }
        }

        public static void MoveFile(string directoryPath)
        {
            try
            {
                string sourceName;
                string sourcePath;
                while (true)
                {
                    sourceName = getInput("Please enter the name of the file which you would like to move.");
                    sourcePath = Path.Combine(directoryPath, sourceName);
                    if (File.Exists(sourcePath))
                    {
                        break;
                    }
                    Console.WriteLine($"There is no {sourceName} file in {directoryPath}.");
                }

                string dirName;
                string dirPath;
                string destPath;
                while (true)
                {
                    dirName = getInput("Please enter the name of the directory to which you would like to move the file.");
                    dirPath = Path.Combine(directoryPath, dirName);
                    if (Directory.Exists(dirPath))
                    {
                        destPath = Path.Combine(dirPath, sourceName);
                        break;
                    }
                    Console.WriteLine($"There is no {dirName} directory in {directoryPath}.");
                }

                File.Move(sourcePath, destPath);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while moving the file:");
                Console.WriteLine(e.Message);
            }
        }

        public static void ListDirectory(string directoryPath)
        {
            try
            {
                string dirName;
                string dirPath;
                while (true)
                {
                    dirName = getInput("Please enter the name of the directory of which you would like to list the contents.");
                    dirPath = Path.Combine(directoryPath, dirName);
                    if (Directory.Exists(dirPath))
                    {
                        break;
                    }
                    Console.WriteLine($"There is no {dirName} directory in {directoryPath}.");
                }

                ListDirectory(dirPath, "    ");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while listing the directory:");
                Console.WriteLine(e.Message);
            }
        }

        public static void ListDirectory(string dirPath, string prefix)
        {
            try
            {
                foreach (var file in Directory.GetFiles(dirPath))
                {
                    Console.WriteLine($"{prefix}{Path.GetFileName(file)}");
                }

                foreach (var dir in Directory.GetDirectories(dirPath))
                {
                    Console.WriteLine($"{prefix}{Path.GetFileName(dir)}:");
                    ListDirectory(dir, prefix + "    ");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while listing the directory:");
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteFile(string directoryPath)
        {
            try
            {
                string fileName;
                string filePath;
                while (true)
                {
                    fileName = getInput("Please enter the name of the file which you would like to delete.");
                    filePath = Path.Combine(directoryPath, fileName);
                    if (File.Exists(filePath))
                    {
                        break;
                    }
                    Console.WriteLine($"There is no {fileName} file in {directoryPath}.");
                }
                File.Delete(filePath);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while appending to the file:");
                Console.WriteLine(e.Message);
            }
        }

        public static string getInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}