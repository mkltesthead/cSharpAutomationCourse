namespace PlaywrightElementsAdvanced
{
    class CalculateExampleLambda
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // This is the traditional approach to calculating square numbers
            List<int> squaredNumbers = CalculateSquaredNumbers(numbers);
            Console.WriteLine("Original Numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Squared Numbers (Traditional): " + string.Join(", ", squaredNumbers));

            // Using an Expression Lambda to calculate the square of each number
            List<int> numbers2 = new List<int> { 2, 4, 6, 8, 10 };
            List<int> squaredNumbers2 = numbers2.Select(x => x * x).ToList();
            Console.WriteLine("Original Numbers: " + string.Join(", ", numbers2));
            Console.WriteLine("Squared Numbers (Lambda): " + string.Join(", ", squaredNumbers2));

            // Define a statement lambda that calculates the sum of two numbers
            Func<int, int, int> add = (a, b) =>
            {
                int sum = a + b;
                return sum;
            };

            // Call the lambda expression 'add' and store the result
            int result = add(5, 7);

            Console.WriteLine("Result (Lambda): " + result); // Output: Result: 12

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
        static List<int> CalculateSquaredNumbers(List<int> numbers)
        {
            List<int> squaredNumbers = new List<int>();
            foreach (int number in numbers)
            {
                squaredNumbers.Add(number * number);
            }
            return squaredNumbers;
        }
    }
}