using System;

class stringCharacterSearch
{
    static void Main()
    {
        // Initialize variables
        string text;
        bool letterFound = false;

        // Get text
        Console.WriteLine("Enter a word: ");
        text = Console.ReadLine();

        // Search text for 'E'
        for (int i = 0; i < text.Length; i++)
        {
            char currentLetter = text[i];
            Console.WriteLine("Character: " + currentLetter);

            if (currentLetter == 'E' || currentLetter == 'e')
            {
                letterFound = true;
                break;
            }
        }

        if (letterFound)
        {
            Console.WriteLine("This string contains the letter E");
        }
        else
        {
            Console.WriteLine("This string does not contain the letter E");
        }

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
