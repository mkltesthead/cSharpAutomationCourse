using System;

namespace calculator
{
    internal class Calculator
    {
        private int max = 1000;
        private int min = -1000;
        static void Main(string[] args)
        {
            Calculator app = new Calculator();

            try
            {
                int a = app.getInput("What is the value of a?");
                int b = app.getInput("What is the value of b?");

                Console.Write($"{a} + {b} = ");
                Console.WriteLine(app.add(a, b));

                Console.Write($"{a} - {b} = ");
                Console.WriteLine(app.subtract(a, b));

                Console.Write($"{a} * {b} = ");
                Console.WriteLine(app.multiply(a, b));

                Console.Write($"{a} / {b} = ");
                Console.WriteLine(app.divide(a, b));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        private int add(int a, int b)
        {
            if (a + b > max)
            {
                throw new ArgumentException($"Result is greater than {max}");
            }
            else if (a + b < min)
            {
                throw new ArgumentException($"Result is less than {min}");
            }
            return a + b;
        }

        private int subtract(int a, int b)
        {
            if (a - b > max)
            {
                throw new ArgumentException($"Result is greater than {max}");
            }
            else if (a - b < min)
            {
                throw new ArgumentException($"Result is less than {min}");
            }
            return a - b;
        }

        private int multiply(int a, int b)
        {
            if (a * b > max)
            {
                throw new ArgumentException($"Result is greater than {max}");
            }
            else if (a * b < min)
            {
                throw new ArgumentException($"Result is less than {min}");
            }
            return a * b;
        }

        private int divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Can't divide by 0.");
            }
            if (a % b != 0)
            {
                throw new ArgumentException($"{a} is not a multiple of {b}");
            }
            else if (a / b > max)
            {
                throw new ArgumentException($"Result is greater than {max}");
            }
            else if (a / b < min)
            {
                throw new ArgumentException($"Result is less than {min}");
            }
            return a / b;
        }
        public int getInput(string prompt)
        {
            Console.WriteLine(prompt);
            string option = Console.ReadLine();
            int result = (option == "") ? 0 : Convert.ToInt32(option);
            if (result > max)
            {
                throw new ArgumentException($"Argument is greater than {max}");
            }
            else if (result < min)
            {
                throw new ArgumentException($"Argument is less than {min}");
            }
            return result;
        }
    }
}