using System;

// Custom exception for division by zero
public class DivisionByZeroException : Exception
{
    public DivisionByZeroException(string message) : base(message)
    {
    }
}

// Custom exception for calculation overflow
public class CalculationOverflowException : Exception
{
    public CalculationOverflowException(string message) : base(message)
    {
    }
}

// Custom exception for calculation underflow
public class CalculationUnderflowException : Exception
{
    public CalculationUnderflowException(string message) : base(message)
    {
    }
}

public class Calculator
{
    // Add method to perform integer addition
    public int Add(int a, int b)
    {
        checked
        {
            // Use long to prevent overflow during addition
            long result = (long)a + (long)b;
            if (result <= int.MaxValue)
            {
                return (int)result;
            }
            else
            {
                throw new CalculationOverflowException("Addition result exceeds the maximum value of an integer.");
            }
        }
    }

    // Subtract method to perform integer subtraction
    public int Subtract(int a, int b)
    {
        checked
        {
            // Use long to prevent underflow during subtraction
            long result = (long)a - (long)b;
            if (result >= int.MinValue)
            {
                return (int)result;
            }
            else
            {
                throw new CalculationUnderflowException("Subtraction result exceeds the minimum value of an integer.");
            }
        }
    }

    // Multiply method to perform integer multiplication
    public int Multiply(int a, int b)
    {
        checked
        {
            // Use long to prevent overflow/underflow during multiplication
            long result = (long)a * (long)b;
            if (result >= int.MinValue && result <= int.MaxValue)
            {
                return (int)result;
            }
            else
            {
                throw new CalculationOverflowException("Multiplication result exceeds the maximum value of an integer.");
            }
        }
    }

    // Divide method to perform double division
    public double Divide(double a, double b)
    {
        if (a == 0 || b == 0)
        {
            throw new DivisionByZeroException("Division by zero is not allowed.");
        }

        return a / b;
    }
}

public class ExceptionArithmeticCalculator
{
    // Main method to test the calculator functionality
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Welcome to the Calculator Program!");

        while (true)
        {
            Console.WriteLine("\nEnter the first number:");
            int num1 = GetIntegerInput();

            Console.WriteLine("Enter the second number:");
            int num2 = GetIntegerInput();

            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");

            int choice = GetIntegerInput();

            double result = 0;
            string operation = string.Empty;

            switch (choice)
            {
                case 1:
                    try
                    {
                        result = calculator.Add(num1, num2);
                        operation = "addition";
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
                        result = calculator.Subtract(num1, num2);
                        operation = "subtraction";
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
                        result = calculator.Multiply(num1, num2);
                        operation = "multiplication";
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
                        result = calculator.Divide(num1, num2);
                        operation = "division";
                    }
                    catch (DivisionByZeroException e)
                    {
                        Console.WriteLine($"Division By Zero Error: {e.Message}");
                        continue;
                    }
                    break;
                case 5:
                    Console.WriteLine("Exiting the Calculator Program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    continue;
            }

            if (choice == 4)
            {
                Console.WriteLine($"Result of {operation}: {result}");
            }
            else
            {
                Console.WriteLine($"Result of {operation}: {result:0}");
            }
        }
    }

    // Helper method to get integer input from the user
    static int GetIntegerInput()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                return number;
            }

            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
