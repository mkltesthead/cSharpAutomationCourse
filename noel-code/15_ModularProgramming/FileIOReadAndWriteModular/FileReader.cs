// FileReader.cs
using System;
using System.IO;

namespace FileIOReadAndWriteModular
{
    public class FileReader
    {
        public static void ReadFile(string filePath)
        {
            try
            {
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
    }
}

