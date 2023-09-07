using System;

class Program
{
    static void Main()
    {
        //Set our numerical variables
        int a = 5;
        int b = 10;

        Console.WriteLine("a = 5");
        Console.WriteLine("b = 10");

        // Test out our combinations
        Console.WriteLine("a > b: " + (a > b));   // false
        Console.WriteLine("a < b: " + (a < b));   // true
        Console.WriteLine("a >= b: " + (a >= b)); // false
        Console.WriteLine("a <= b: " + (a <= b)); // true
        Console.WriteLine("a == b: " + (a == b)); // false
        Console.WriteLine("a != b: " + (a != b)); // true

        //Set our text examples
        string str1 = "Hello";
        string str2 = "World";

        Console.WriteLine("str1 = \"Hello\"");
        Console.WriteLine("str2 = \"World\"");

        Console.WriteLine("str1 < str2: " + string.Compare(str1, str2));   // (-1)
        Console.WriteLine("str1 > str2: " + string.Compare(str2, str1));   // (1)
        Console.WriteLine("str1 == str2: " + str1.Equals(str2, StringComparison.OrdinalIgnoreCase)); // false
        Console.WriteLine("str1 == str2: " + (str1 == str2)); // false
        Console.WriteLine("str1 != str2: " + (str1 != str2)); // true
    }
}

