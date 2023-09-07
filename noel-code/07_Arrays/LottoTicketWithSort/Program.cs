using System;

namespace LottoTicketApp
{
    class LottoTicket
    {
        private static Random random = new Random();

        public static int[] GenerateNumbers()
        {
            int[] numbers = new int[6];
            int index = 0;

            while (index < 6)
            {
                // Generate a random number between 1 and 69
                int randomNumber = random.Next(1, 70);
                // make sure that each of our array indexes has a random number assigned
                if (Array.IndexOf(numbers, randomNumber) == -1)
                {
                    numbers[index] = randomNumber;
                    index++;
                }
            }
            Array.Sort(numbers);
            // Array.Reverse(numbers);
            return numbers;
        }

        public static void PrintTicket(int[] numbers)
        {
            Console.WriteLine("Lotto Ticket Numbers: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Lotto Picker App!");
            Console.Write("How lucky are you feeling? Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the number of tickets you would like to play: ");
            int numTickets = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= numTickets; i++)
            {
                Console.WriteLine("Ticket " + i + ":");
                int[] ticketNumbers = GenerateNumbers();
                PrintTicket(ticketNumbers);
                Console.WriteLine();
            }

            Console.WriteLine("Good luck, " + name + "!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
