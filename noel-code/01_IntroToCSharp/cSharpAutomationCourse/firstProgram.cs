class firstProgram
{

    static void PrintPassOrFail(int score)
    {
        if (score > 100) // If score is greater than 100
        {
            Console.WriteLine("Error: score is greater than 100!");
        }
        else if (score < 0) // Else If score is less than 0
        {
            Console.WriteLine("Error: score is less than 0!");
        }
        else if (score >= 50) // Else if score is greater or equal to 50 {
        {
            Console.WriteLine("Pass!");
        }
        else // If none above, then score must be between 0 and 49 {
            Console.WriteLine("Fail!");
    }

    public static void Main()
    {
        string helloWorld = "Here's the classic Hello, World! program.\n\n";
        string endIt = "Press any key to end it.";

        PrintPassOrFail(59);

        // Prints a message to the console.
        System.Console.WriteLine(helloWorld);

        /* Wait for the user to press a key. 
         * TIP: This prevents the console window from terminating 
         * and disappearing before the programmer can see the contents 
         * when the application is run via F5 in Visual Studio. 
         */

        System.Console.WriteLine(endIt);
        System.Console.ReadKey();
    }
}
