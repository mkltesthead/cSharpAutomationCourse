using System;

namespace ExceptionValidateAgeDemo
{
    class Program
    {
        public static void ThrowExceptionDemo()
        {
            int age = -5;
            try
            {
                ValidateAge(age);
                Console.WriteLine("Age is valid!");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("An ArgumentException occurred: " + e.Message);
            }
        }

        public static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Age cannot be negative", nameof(age));
            }
        }

        static void Main(string[] args)
        {
            ThrowExceptionDemo();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

