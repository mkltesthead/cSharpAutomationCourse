using System;
using System.Text.RegularExpressions;

class WorkingWithStrings
{
    static void Main(string[] args)
    {
        string str = "ABCDEF";
        char[] characters = { 'A', 'B', 'C', 'D', 'E', 'F' };
        string newString = new string(characters);
        Console.WriteLine(str);
        Console.WriteLine(characters); // This line won't display the characters, but their type
        Console.WriteLine(newString);

        // Accessing a character using indexing
        Console.WriteLine(str[5]);

        // String methods in C#
        Console.WriteLine(str.Contains("C")); // Checks if the string contains a specific substring
        Console.WriteLine(str.Equals("ABCDEF")); // Checks if two strings are equal
        Console.WriteLine(str.EndsWith("F")); // Checks if the string ends with a specific substring
        Console.WriteLine(str.StartsWith("A")); // Checks if the string starts with a specific substring
        Console.WriteLine(string.Format("{0} is a string.", str)); // Replaces placeholders with values in the string
        Console.WriteLine(str.IndexOf("D")); // Returns the index of a substring within the string
        Console.WriteLine(string.IsNullOrEmpty(str)); // Checks if the string is null or empty
        Console.WriteLine(str.Length); // Returns the length of the string
        Console.WriteLine(Regex.IsMatch(str, "^[A-Z]+$")); // Matches a regular expression
        Console.WriteLine(str.Replace("A", "X")); // Replaces occurrences of a substring with another substring
        Console.WriteLine(string.Join(",", str.Split('C'))); // Splits the string by a delimiter and joins the resulting substrings
        Console.WriteLine(str.Substring(1, 3)); // Returns a substring starting at a specified index with a specified length
        Console.WriteLine(str.ToLower()); // Converts the string to lowercase
        Console.WriteLine(str.ToUpper()); // Converts the string to uppercase
        Console.WriteLine("   trim   ".Trim()); // Removes leading and trailing whitespace from the string
        Console.WriteLine(Convert.ToString(123)); // Converts a value to its string representation

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
