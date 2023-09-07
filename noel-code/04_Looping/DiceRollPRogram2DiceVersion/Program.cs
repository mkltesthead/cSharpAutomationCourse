using System;

class DiceRollProgram2DiceVersion
{
    static void Main()
    {
        // Create a random() object.
        // See course material about the Random() class and how and why we are using it
        Random random = new Random();

        int totalSpaces = 40;
        int currentSpace = 0;
        int rollsRemaining = 5;

        Console.WriteLine("Welcome to the Dice Roll Game!");
        Console.WriteLine("Your goal is to try to travel the game board with 40 spaces within 5 rolls of the dice.");
        Console.WriteLine("Press any key to roll the dice...");
        Console.ReadKey();

        while (rollsRemaining > 0)
        {
            // Clear the screen for each roll
            Console.Clear();

            // Simulate rolling 2 dice
            int diceRoll1 = random.Next(1, 7);
            int diceRoll2 = random.Next(1, 7);
            int totalDiceRoll = diceRoll1 + diceRoll2;

            Console.WriteLine($"You rolled a {diceRoll1} and a {diceRoll2}! Total: {totalDiceRoll}");

            currentSpace += totalDiceRoll;

            Console.WriteLine($"You are now on space {currentSpace}.");

            if (currentSpace == totalSpaces)
            {
                Console.WriteLine("Congratulations! You reached the end of the game board exactly. YOU WIN!");
                break;
            }
            else if (currentSpace > totalSpaces)
            {
                Console.WriteLine("I'm sorry! You have gone over the end of the game board. YOU LOSE!");
                break;
            }

            rollsRemaining--;

            Console.WriteLine($"You have {rollsRemaining} roll(s) remaining.");
            if (rollsRemaining == 0)
            {
                break;
            }
            Console.WriteLine("Press any key to roll the dice again...");
            Console.ReadKey();
        }

        if (currentSpace < totalSpaces)
        {
            Console.WriteLine("Sorry, you did not reach the end of the game board within 5 rolls. YOU LOSE!");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
