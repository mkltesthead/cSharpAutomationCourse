using System;

class LottoTicketApp
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Lotto Picker App!");

        Console.Write("How lucky are you feeling? (Enter a description): ");
        string luckyLevel = Console.ReadLine();

        Console.Write("Enter the number of tickets you would like to play: ");
        int numberOfTickets = int.Parse(Console.ReadLine());

        LottoTicket lottoTicket = new LottoTicket();

        // Generate and print lottery tickets for each play round
        for (int i = 1; i <= numberOfTickets; i++)
        {
            Console.WriteLine("Play Round {0} - {1}", i, luckyLevel);
            lottoTicket.GenerateNumbers();
            Console.WriteLine();
        }

        Console.WriteLine("Good luck with your lottery tickets!");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

class LottoTicket
{
    public void GenerateNumbers()
    {
        Random random = new Random();

        // Generate 6 random numbers between 1 and 69
        int[] numbers = new int[6];
        for (int i = 0; i < 6; i++)
        {
            numbers[i] = random.Next(1, 70);
        }

        // Print the lottery ticket with the generated numbers
        Console.WriteLine("Lotto Ticket Numbers: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}