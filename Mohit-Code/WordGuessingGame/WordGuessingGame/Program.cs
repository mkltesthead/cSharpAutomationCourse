using System;
using System.Collections;

namespace Word_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = SelectSecretWord();

            PromptPlayer(secretWord);

        }


        public static string SelectSecretWord()
        {
            ArrayList arrayList = new ArrayList() { "lion", "cat", "orange", "apple", "india", "australia", "mango", "america", "kiwi", "grapes", "tiger", "papaya" };
            Random random = new Random();
            int index = random.Next(arrayList.Count);
            string secretWord = (string)arrayList[index];


            return secretWord;

        }

        public static void PromptPlayer(string secretWord)
        {


            int attempts = 0;
            int maxAttempts = 7;
            bool gameWon = false;
            string guessedWord = new string('_', secretWord.Length);

            while (!gameWon && attempts < maxAttempts)
            {
                Console.WriteLine("\n" + guessedWord);
                Console.Write("Enter a letter: ");
                char guess = Console.ReadKey().KeyChar;
                Console.WriteLine();

                bool correctGuess = false;
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (string.Equals(secretWord[i].ToString(), guess.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        guessedWord = guessedWord.Remove(i, 1).Insert(i, guess.ToString());
                        correctGuess = true;
                    }
                }

                if (!correctGuess)
                {
                    attempts++;
                    Console.WriteLine("Incorrect guess. Remaining Attempts: " + (maxAttempts - attempts));
                }

                if (string.Equals(guessedWord, secretWord, StringComparison.OrdinalIgnoreCase))
                {
                    gameWon = true;
                    Console.WriteLine("\nCongratulations! You guessed the word: " + secretWord);
                }
            }

            if (!gameWon)
            {
                Console.WriteLine("\nSorry, you're out of attempts. The secret word was: " + secretWord);
            }

            Console.WriteLine("\nThanks for playing!");

            Console.WriteLine();
            Console.WriteLine("Do you want to play again? yes or no");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                string secret = SelectSecretWord();

                PromptPlayer(secret);
            }

            else
                Environment.Exit(0);
        }
    }
}