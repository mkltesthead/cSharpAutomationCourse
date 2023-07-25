using System.Text;

class WordGuessingGame
{
    private Dictionary<string, List<string>> wordCategories;
    private string? currentCategory;
    private List<string?> currentWordList;
    private string? secretWord;
    private StringBuilder guessedLetters;
    private int maxAttempts;
    private int remainingAttempts;

    public WordGuessingGame()
    {
        wordCategories = new Dictionary<string, List<string>>();
        guessedLetters = new StringBuilder();
        maxAttempts = 6;
        remainingAttempts = maxAttempts;

        wordCategories.Add("Animals", new List<string> { "cat", "dog", "rabbit", "rat", "snake" });
        wordCategories.Add("Countries", new List<string> { "India", "Dubai", "Canada", "Singapore", "Japan" });
        wordCategories.Add("Fruits", new List<string> { "Banana", "Apple", "Mango", "Orange", "Kiwi" });
    }

    public void SelectCategory()
    {
        Console.WriteLine("Choose a category:");

        foreach (string category in wordCategories.Keys)
        {
            Console.WriteLine(category);
        }

        Console.WriteLine();

        string input = Console.ReadLine();

        if (wordCategories.ContainsKey(input))
        {
            currentCategory = input;
            currentWordList = wordCategories[input];
        }
        else
        {
            Console.WriteLine("Invalid category. Please choose a valid category.");
            SelectCategory();
        }
    }

    public void SelectSecretWord()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, currentWordList.Count);
        secretWord = currentWordList[randomIndex].ToLower();
    }

    private char PromptPlayer()
    {
        Console.WriteLine("Guess a letter: ");
        string input = Console.ReadLine().ToLower();
        return input[0];// BUG FOUND: does not handle a carraige return resulting in a NULL string.
    }

    private bool ValidateGuess(char guess)
    {
        if (!Char.IsLetter(guess))
        {
            Console.WriteLine("Invalid input. Please enter a valid letter.");
            return false;
        }

        if (guessedLetters.ToString().Contains(guess.ToString().ToLower()))
        {
            Console.WriteLine("You have already guessed this letter. Please enter a new letter.");
            return false;
        }

        return true;
    }

    private void CheckGuess(char guess)
    {
        guessedLetters.Append(guess);

        if (secretWord.Contains(guess.ToString().ToLower()))
        {
            Console.WriteLine("Correct guess!");

            StringBuilder revealedWord = new StringBuilder();
            foreach (char letter in secretWord)
            {
                if (guessedLetters.ToString().Contains(letter.ToString().ToLower()))
                {
                    revealedWord.Append(letter);
                }
                else
                {
                    revealedWord.Append("-");
                }
            }

            Console.WriteLine("Current word: " + revealedWord);
        }
        else
        {
            Console.WriteLine("Incorrect guess!");
            remainingAttempts--;
        }
    }

    private bool GameResult()
    {
        foreach (char letter in secretWord)
        {
            if (!guessedLetters.ToString().Contains(letter.ToString().ToLower()))
            {
                return false;
            }
        }
        return true;
    }

    private bool IsGameOver()
    {
        return remainingAttempts <= 0 || GameResult();
    }

    private void DisplayGameOutcome()
    {
        if (GameResult())
        {
            Console.WriteLine("Congratulations! You won the game.");
        }
        else
        {
            Console.WriteLine("Game over. You lost.");
        }
    }

    public void Play()
    {
        bool playAgain = true;

        while (playAgain)
        {
            SelectCategory();
            SelectSecretWord();
            guessedLetters.Clear();
            remainingAttempts = maxAttempts;

            Console.WriteLine("Welcome to the Word Guessing Game!");
            Console.WriteLine("Category: " + currentCategory);

            while (!IsGameOver())
            {
                Console.WriteLine("Remaining attempts: " + remainingAttempts);
                char guess = PromptPlayer();

                while (!ValidateGuess(guess))
                {
                    guess = PromptPlayer();
                }

                CheckGuess(guess);
            }

            DisplayGameOutcome();

            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgainInput = Console.ReadLine().ToLower();

            if (playAgainInput == "yes")
            {
                playAgain = true;
                continue;
            }
            else
            {
                playAgain = false;
                break;
            }
        }

        Console.WriteLine("Thank you for playing!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        WordGuessingGame game = new WordGuessingGame();
        game.Play();


    }
}