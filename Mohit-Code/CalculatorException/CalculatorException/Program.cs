namespace Calculator_App
{
    internal class Program
    {

        public class DivisionByZeroException : Exception
        {
            public DivisionByZeroException() : base("Division by zero is not allowed")
            {
            }
        }


        public class CalculationOverflowException : Exception
        {
            public CalculationOverflowException(string operation)
                : base($"Overflow occurred during {operation} operation")
            {
            }
        }

        public class CalculationUnderflowException : Exception
        {
            public CalculationUnderflowException(string operation)
                : base($"Underflow occurred during {operation} operation")
            {
            }
        }

        public class Calculator
        {
            public static int Add(int a, int b)
            {
                checked
                {
                    try
                    {
                        return a + b;
                    }
                    catch (OverflowException)
                    {
                        throw new CalculationOverflowException("addition");
                    }
                }
            }

            public static int Subtract(int a, int b)
            {
                checked
                {
                    try
                    {
                        return a - b;
                    }
                    catch (OverflowException)
                    {
                        throw new CalculationOverflowException("subtraction");
                    }
                }
            }

            public static int Multiply(int a, int b)
            {
                checked
                {
                    try
                    {
                        return a * b;
                    }
                    catch (OverflowException)
                    {
                        throw new CalculationOverflowException("multiplication");
                    }
                }
            }

            public static int Divide(int a, int b)
            {
                if (b == 0)
                {
                    throw new DivisionByZeroException();
                }

                checked
                {
                    try
                    {
                        return a / b;
                    }
                    catch (OverflowException)
                    {
                        throw new CalculationOverflowException("division");
                    }
                }
            }
        }

        public class MainClass
        {
            public static void Main(string[] args)
            {
                Calculator calculator = new Calculator();

                Console.WriteLine("Welcome to the Calculator Program!\n");

                while (true)
                {
                    Console.WriteLine("Enter first number:");
                    int number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number:");
                    int number2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Select an operation to perform:");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("5. Exit");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    double result = 0;


                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                result = Calculator.Add(number1, number2);

                            }
                            catch (CalculationOverflowException e)
                            {
                                Console.WriteLine($"Calculation Overflow Error: {e.Message}");
                                continue;
                            }
                            break;
                        case 2:
                            try
                            {
                                result = Calculator.Subtract(number1, number2);

                            }
                            catch (CalculationUnderflowException e)
                            {
                                Console.WriteLine($"Calculation Underflow Error: {e.Message}");
                                continue;
                            }
                            break;
                        case 3:
                            try
                            {
                                result = Calculator.Multiply(number1, number2);

                            }
                            catch (CalculationOverflowException e)
                            {
                                Console.WriteLine($"Calculation Overflow Error: {e.Message}");
                                continue;
                            }
                            break;
                        case 4:
                            try
                            {
                                result = Calculator.Divide(number1, number2);

                            }
                            catch (DivisionByZeroException e)
                            {
                                Console.WriteLine($"Division By Zero Error: {e.Message}");
                                continue;
                            }
                            break;
                        case 5:
                            Console.WriteLine("Exiting the program.....");
                            return;
                        default:
                            Console.WriteLine("Please select a valid choice.");
                            continue;
                    }
                }

            }
        }



    }
}