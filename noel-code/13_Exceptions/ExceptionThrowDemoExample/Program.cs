using System;
using System.IO;

namespace ExceptionHandlingDemo
{
    class Program
    {
        public static void CreateFileRethrow()
        {
            string filePath = @"C:\csharp_class_test\resources.txt";

            try
            {
                File.Create(filePath);
            }
            catch (IOException e)
            {
                // Rethrow the caught exception
                throw;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                CreateFileRethrow();
            }
            catch (IOException e)
            {
                // Handle the rethrown exception or remove the catch block parameter if not needed.
                Console.WriteLine("An error occurred while creating the file:");
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}