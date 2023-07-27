using System;

class ExceptionWithHandlingExample
{
    static void Main()
    {
        // Exception example - IndexOutOfRangeException
        string[] employees = { "Andy", "Randy", "Gil", "Saba" };
        try
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hi there " + employees[i]);
            }
        }

        catch (IndexOutOfRangeException ex)
        {
            // Catch block handles the exception
            Console.WriteLine("An error occurred: " + ex.Data.Values.Count);
            Console.WriteLine("An error occurred: " + ex.Message);
            // Additional error handling code can be placed here if needed.
        }

        finally
        {
            // Finally block is executed regardless of whether an exception occurred or not.
            //  Console.WriteLine("End of the program.");
            //  Console.WriteLine("Press any key to exit...");
            //  Console.ReadKey();

            // Additional cleanup or resource releasing code can be placed here if needed.
        }
        Console.WriteLine("End of the program.");
        Console.WriteLine("Press any key to exit...");

        Console.ReadKey();
    }
}

