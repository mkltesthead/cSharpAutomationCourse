using System;

namespace StringCounterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = "This is a sample text.";
            countAndPrintWords(inputText); // Call the countAndPrintWords method with the input text

            Console.Write("Enter your own string to evaluate: ");
            string myInputText = Console.ReadLine();
            countAndPrintWords(myInputText); // Call the countAndPrintWords method with the input text

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }

        static void countAndPrintWords(string text)
        {
            // Split the text into words using spaces as the delimiter
            var words = text.Split(' ');

            int wordCount = words.Length; // Count the number of words

            // Print out word information
            string message = $"Your text contains {wordCount} words";
            Console.WriteLine(message);

            // Loop through the words and print them
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
